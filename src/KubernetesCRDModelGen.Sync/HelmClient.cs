using CliWrap;
using CliWrap.Buffered;
using System.Text;

namespace KubernetesCRDModelGen.Sync;

public static class HelmClient
{
    public static async Task<string> TemplateHttpRepo(string repo, string name, bool devel, string appendCMD)
    {
        var stdOutBuffer = new StringBuilder();

        await Cli.Wrap("helm")
            .WithArguments($"template {name} --repo {repo} --include-crds{(devel ? " --devel" : "")} {appendCMD}")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();

        return stdOutBuffer.ToString();
    }

    public static async Task<string> TemplateOCIRepo(string repo, string name, bool devel, string appendCMD)
    {
        var stdOutBuffer = new StringBuilder();

        await Cli.Wrap("helm")
            .WithArguments($"template {name} {repo} --include-crds{(devel ? " --devel" : "")} {appendCMD}")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();

        return stdOutBuffer.ToString();
    }
}
