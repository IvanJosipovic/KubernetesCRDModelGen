using CliWrap;
using CliWrap.Buffered;
using System.Text;

namespace KubernetesCRDModelGen.Sync;

public static class HelmClient
{
    public static async Task RepoAdd(string name, string url)
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "add", name, url })
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();
    }

    public static async Task RepoRemove(string name)
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "remove", name })
            .WithValidation(CommandResultValidation.None)
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();
    }

    public static async Task RepoUpdate()
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "update" })
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();
    }

    public static async Task<string> Template(string repo, string name, bool devel, string appendCMD)
    {
        var stdOutBuffer = new StringBuilder();

        await Cli.Wrap("helm")
            .WithArguments($"template {repo}/{name} --include-crds{(devel ? " --devel" : "")} {appendCMD}")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
            .WithStandardErrorPipe(PipeTarget.ToDelegate(Console.WriteLine))
            .ExecuteBufferedAsync();

        return stdOutBuffer.ToString();
    }
}
