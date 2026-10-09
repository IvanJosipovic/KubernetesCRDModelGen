using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace KubernetesCRDModelGen.SourceGenerator.Tests;

public class SourceGeneratorPackageTests
{
    [Fact]
    public async Task PackWithoutBuild_ProducesFunctionalAnalyzerPackage()
    {
        var repositoryRoot = FindRepositoryRoot();
        var configuration = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Name
            ?? throw new InvalidOperationException("Could not determine the test build configuration.");
        var packageVersion = $"0.0.1-package-test-{Guid.NewGuid():N}";
        var projectPath = Path.Combine(
            repositoryRoot,
            "src",
            "KubernetesCRDModelGen.SourceGenerator",
            "KubernetesCRDModelGen.SourceGenerator.csproj");
        var outputDirectory = Path.Combine(
            repositoryRoot,
            "src",
            "KubernetesCRDModelGen.SourceGenerator",
            "bin",
            configuration,
            "netstandard2.0");
        var temporaryDirectory = Directory.CreateTempSubdirectory("KubernetesCRDModelGen.SourceGenerator.Tests-");
        var packageOutputDirectory = Path.Combine(temporaryDirectory.FullName, "packages");
        Directory.CreateDirectory(packageOutputDirectory);

        try
        {
            var cancellationToken = TestContext.Current.CancellationToken;
            await RunDotnetAsync(
                repositoryRoot,
                cancellationToken,
                "pack",
                projectPath,
                "--configuration",
                configuration,
                "--no-build",
                "--output",
                packageOutputDirectory,
                $"-p:Version={packageVersion}");

            var packagePath = Directory.GetFiles(packageOutputDirectory, "*.nupkg").Single();
            string[] packageEntries;
            using (var package = ZipFile.OpenRead(packagePath))
            {
                packageEntries = package.Entries
                    .Select(entry => entry.FullName)
                    .ToArray();
            }

            var packageEntrySet = packageEntries.ToHashSet(StringComparer.OrdinalIgnoreCase);

            var expectedAssemblies = Directory.GetFiles(outputDirectory, "*.dll")
                .Select(path => new FileInfo(path).Name)
                .Where(fileName => !fileName.StartsWith("Microsoft.CodeAnalysis", StringComparison.Ordinal))
                .ToArray();
            var missingAssemblies = expectedAssemblies
                .Where(fileName => !packageEntrySet.Contains($"analyzers/dotnet/cs/{fileName}"))
                .ToArray();

            if (missingAssemblies.Length > 0)
            {
                throw new InvalidOperationException(
                    $"The source-generator package is missing analyzer dependencies: {string.Join(", ", missingAssemblies)}");
            }

            var consumerDirectory = Path.Combine(temporaryDirectory.FullName, "consumer");
            Directory.CreateDirectory(consumerDirectory);
            var consumerProjectPath = Path.Combine(consumerDirectory, "Consumer.csproj");
            File.WriteAllText(
                consumerProjectPath,
                $"""
                <Project Sdk="Microsoft.NET.Sdk">
                    <PropertyGroup>
                        <TargetFramework>net10.0</TargetFramework>
                        <ImplicitUsings>enable</ImplicitUsings>
                        <Nullable>enable</Nullable>
                        <EmitCompilerGeneratedFiles>true</EmitCompilerGeneratedFiles>
                        <CompilerGeneratedFilesOutputPath>obj/Generated</CompilerGeneratedFilesOutputPath>
                        <WarningsAsErrors>$(WarningsAsErrors);CS8785</WarningsAsErrors>
                    </PropertyGroup>
                    <ItemGroup>
                        <PackageReference Include="KubernetesClient" Version="19.0.2" />
                        <PackageReference Include="KubernetesCRDModelGen.SourceGenerator" Version="{packageVersion}">
                            <PrivateAssets>all</PrivateAssets>
                        </PackageReference>
                        <AdditionalFiles Include="kubevirts.kubevirt.io.yaml" />
                    </ItemGroup>
                </Project>
                """);
            var nugetConfigPath = Path.Combine(consumerDirectory, "NuGet.Config");
            File.WriteAllText(
                nugetConfigPath,
                """
                <configuration>
                    <packageSources>
                        <clear />
                        <add key="package-test" value="../packages" />
                        <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
                    </packageSources>
                </configuration>
                """);
            File.WriteAllText(
                Path.Combine(consumerDirectory, "Consumer.cs"),
                """
                public sealed class Consumer
                {
                }
                """);
            File.Copy(
                Path.Combine(AppContext.BaseDirectory, "kubevirts.kubevirt.io.yaml"),
                Path.Combine(consumerDirectory, "kubevirts.kubevirt.io.yaml"));

            await RunDotnetAsync(
                repositoryRoot,
                cancellationToken,
                "restore",
                consumerProjectPath,
                "--configfile",
                nugetConfigPath,
                "-p:NuGetAudit=false");
            await RunDotnetAsync(
                repositoryRoot,
                cancellationToken,
                "build",
                consumerProjectPath,
                "--configuration",
                configuration,
                "--no-restore");

            var generatedDirectory = Path.Combine(consumerDirectory, "obj", "Generated");
            var generatedSources = Directory.GetFiles(generatedDirectory, "*.cs", SearchOption.AllDirectories);
            if (!generatedSources.Any(path =>
                File.ReadAllText(path).Contains("partial class ", StringComparison.Ordinal)))
            {
                throw new InvalidOperationException("The packaged source generator built successfully but emitted no generated model classes.");
            }
        }
        finally
        {
            temporaryDirectory.Delete(recursive: true);
        }
    }

    private static string FindRepositoryRoot()
    {
        DirectoryInfo? directory = new(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "global.json")))
        {
            directory = directory.Parent;
        }

        return directory?.FullName
            ?? throw new DirectoryNotFoundException("Could not find the repository root.");
    }

    private static async Task RunDotnetAsync(
        string workingDirectory,
        CancellationToken cancellationToken,
        params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            },
        };

        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        if (!process.Start())
        {
            throw new InvalidOperationException("Could not start dotnet.");
        }

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();
        try
        {
            await process.WaitForExitAsync(cancellationToken);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            try
            {
                process.Kill(entireProcessTree: true);
            }
            catch (InvalidOperationException) when (process.HasExited)
            {
            }

            await process.WaitForExitAsync(CancellationToken.None);
            await Task.WhenAll(standardOutputTask, standardErrorTask);
            throw;
        }

        var standardOutput = await standardOutputTask;
        var standardError = await standardErrorTask;
        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException(
                $"dotnet {string.Join(" ", arguments)} failed with exit code {process.ExitCode}." +
                $"{Environment.NewLine}{standardOutput}{Environment.NewLine}{standardError}");
        }

    }
}
