//using System.Collections.Immutable;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Text;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.Emit;
//using Microsoft.CodeAnalysis.Text;
//using Microsoft.Extensions.Logging;
//using Microsoft.OpenApi.Models;
//using NuGet.Frameworks;
//using NuGet.Packaging.Core;
//using Yardarm;
//using Yardarm.Enrichment;
//using Yardarm.Enrichment.Compilation;
//using Yardarm.Packaging;
//using Yardarm.Packaging.Internal;

//namespace Worker {
//    /// <summary>
//    /// Generator creates an assembly from an OpenApiDocument.
//    /// </summary>
//    public class CRDGenerator {
//        IServiceProvider ServiceProvider { get; }
//        CRDGeneratorSettings Settings { get; }
//        readonly OpenApiDocument _document;

//        public CRDGenerator(OpenApiDocument document, CRDGeneratorSettings settings) {
//            ArgumentNullException.ThrowIfNull(document);
//            ArgumentNullException.ThrowIfNull(document);

//            Settings = settings;
//            ServiceProvider = Settings.BuildServiceProvider(document);
//            _document = document;
//        }

//        public async Task<YardarmGenerationResult> EmitAsync(CancellationToken cancellationToken = default) {
//            var toDispose = new List<IDisposable>();
//            try {
//                var context = ServiceProvider.GetRequiredService<GenerationContext>();

//                await PerformRestoreAsync(context, Settings.NoRestore, cancellationToken);

//                var compilationResults = new List<YardarmCompilationResult>();

//                if (Settings.TargetFrameworkMonikers.Length == 1) {
//                    var targetFramework = NuGetFramework.Parse(Settings.TargetFrameworkMonikers[0]);

//                    // Perform the compilation
//                    var (emitResult, additionalDiagnostics) = await BuildForTargetFrameworkAsync(
//                        context, targetFramework,
//                        Settings.DllOutput, Settings.PdbOutput, Settings.XmlDocumentationOutput, Settings.ReferenceAssemblyOutput,
//                        cancellationToken).ConfigureAwait(false);

//                    compilationResults.Add(new(targetFramework, emitResult,
//                        Settings.DllOutput, Settings.PdbOutput, Settings.XmlDocumentationOutput, Settings.ReferenceAssemblyOutput,
//                        additionalDiagnostics));
//                }
//                else
//                {
//                    if (Settings.NuGetOutput is null) {
//                        throw new InvalidOperationException(
//                            "Targeting multiple frameworks is only supported with NuGet output.");
//                    }

//                    foreach (var targetFramework in Settings.TargetFrameworkMonikers.Select(NuGetFramework.Parse)) {
//                        var dllOutput = new MemoryStream();
//                        toDispose.Add(dllOutput);
//                        var pdbOutput = new MemoryStream();
//                        toDispose.Add(pdbOutput);
//                        var xmlDocumentationOutput = new MemoryStream();
//                        toDispose.Add(xmlDocumentationOutput);
//                        var referenceAssemblyOutput = new MemoryStream();
//                        toDispose.Add(referenceAssemblyOutput);

//                        // Perform the compilation
//                        var (emitResult, additionalDiagnostics) = await BuildForTargetFrameworkAsync(
//                            context, targetFramework,
//                            dllOutput, pdbOutput, xmlDocumentationOutput, referenceAssemblyOutput,
//                            cancellationToken).ConfigureAwait(false);

//                        compilationResults.Add(new(targetFramework, emitResult,
//                            dllOutput, pdbOutput, xmlDocumentationOutput, referenceAssemblyOutput,
//                            additionalDiagnostics));
//                    }
//                }

//                if (compilationResults.All(p => p.EmitResult.Success)) {
//                    if (Settings.NuGetOutput != null) {
//                        PackNuGet(compilationResults);
//                    }
//                }

//                return new YardarmGenerationResult(context, compilationResults);
//            }
//            finally {
//                foreach (var disposable in toDispose) {
//                    disposable.Dispose();
//                }
//            }
//        }

//        private async Task<(EmitResult, ImmutableArray<Diagnostic>)> BuildForTargetFrameworkAsync(
//            GenerationContext context, NuGetFramework targetFramework,
//            Stream dllOutput, Stream pdbOutput, Stream xmlDocumentationOutput, Stream? referenceAssemblyOutput,
//            CancellationToken cancellationToken = default) {
//            context.CurrentTargetFramework = targetFramework;

//            // Create the empty compilation
//            var compilation = CSharpCompilation.Create(Settings.AssemblyName)
//                .WithOptions(Settings.CompilationOptions);

//            // Run all enrichers against the compilation
//            var enrichers = context.GenerationServices.GetRequiredService<IEnumerable<ICompilationEnricher>>();
//            compilation = await compilation.EnrichAsync(enrichers, cancellationToken);

//            ImmutableArray<Diagnostic> additionalDiagnostics = new ImmutableArray<Diagnostic>();

//            return (compilation.Emit(dllOutput,
//                    pdbStream: pdbOutput,
//                    xmlDocumentationStream: xmlDocumentationOutput,
//                    metadataPEStream: referenceAssemblyOutput,
//                    embeddedTexts: await GetEmbeddedTextsAsync(compilation, cancellationToken)
//                        .ToListAsync(cancellationToken),
//                    options: new EmitOptions()
//                        .WithDebugInformationFormat(DebugInformationFormat.PortablePdb)
//                        .WithHighEntropyVirtualAddressSpace(true)
//                        .WithIncludePrivateMembers(false)),
//                additionalDiagnostics);
//        }

//        private async IAsyncEnumerable<EmbeddedText> GetEmbeddedTextsAsync(
//            CSharpCompilation compilation, [EnumeratorCancellation] CancellationToken cancellationToken = default) {
//            if (!Settings.EmbedAllSources) {
//                yield break;
//            }

//            foreach (var syntaxTree in compilation.SyntaxTrees
//                         .Where(static p => p.FilePath != "")
//                         .Cast<CSharpSyntaxTree>()) {
//                var content = (await syntaxTree.GetRootAsync(cancellationToken))
//                    .GetText(Encoding.UTF8, SourceHashAlgorithm.Sha1);

//                if (content.CanBeEmbedded) {
//                    yield return EmbeddedText.FromSource(syntaxTree.FilePath, content);
//                }
//            }
//        }

//        private void PackNuGet(List<YardarmCompilationResult> results) {
//            foreach (var result in results) {
//                if (!result.DllOutput.CanRead || !result.DllOutput.CanSeek) {
//                    throw new InvalidOperationException(
//                        $"{nameof(YardarmGenerationSettings.DllOutput)} must be seekable and readable to pack a NuGet package.");
//                }

//                if (!result.XmlDocumentationOutput.CanRead || !result.XmlDocumentationOutput.CanSeek) {
//                    throw new InvalidOperationException(
//                        $"{nameof(YardarmGenerationSettings.XmlDocumentationOutput)} must be seekable and readable to pack a NuGet package.");
//                }

//                result.DllOutput.Seek(0, SeekOrigin.Begin);
//                result.XmlDocumentationOutput.Seek(0, SeekOrigin.Begin);
//                result.ReferenceAssemblyOutput?.Seek(0, SeekOrigin.Begin);

//                if (Settings.NuGetSymbolsOutput != null) {
//                    if (!result.PdbOutput.CanRead || !result.PdbOutput.CanSeek) {
//                        throw new InvalidOperationException(
//                            $"{nameof(YardarmGenerationSettings.PdbOutput)} must be seekable and readable to pack a NuGet symbols package.");
//                    }

//                    result.PdbOutput.Seek(0, SeekOrigin.Begin);
//                }
//            }


//            var packer = ServiceProvider.GetRequiredService<NuGetPacker>();

//            packer.Pack(results, Settings.NuGetOutput!);

//            if (Settings.NuGetSymbolsOutput != null) {
//                if (!Settings.PdbOutput.CanRead || !Settings.PdbOutput.CanSeek) {
//                    throw new InvalidOperationException(
//                        $"{nameof(YardarmGenerationSettings.PdbOutput)} must be seekable and readable to pack a NuGet symbols package.");
//                }



//                packer.PackSymbols(results, Settings.NuGetSymbolsOutput);
//            }
//        }

//        protected async Task PerformRestoreAsync(YardarmContext context, bool readLockFileOnly, CancellationToken cancellationToken = default) {
//            // Perform the NuGet restore
//            //var restoreProcessor = context.GenerationServices.GetRequiredService<NuGetRestoreProcessor>();
//            //context.NuGetRestoreInfo = await restoreProcessor.ExecuteAsync(readLockFileOnly, cancellationToken).ConfigureAwait(false);

//            if (context.Settings.TargetFrameworkMonikers.Length == 0) {
//                throw new InvalidOperationException("No target framework monikers provided.");
//            }
//        }
//    }
//}
