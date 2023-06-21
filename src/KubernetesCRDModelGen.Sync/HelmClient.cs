using CliWrap;
using System;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace KubernetesCRDModelGen.Sync;

public static class HelmClient
{
    public static async Task RepoAdd(string name, string url)
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "add", name, url })
            .ExecuteAsync();
    }

    public static async Task RepoRemove(string name)
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "remove", name })
            .WithValidation(CommandResultValidation.None)
            .ExecuteAsync();
    }

    public static async Task RepoUpdate()
    {
        await Cli.Wrap("helm")
            .WithArguments(new[] { "repo", "update" })
            .ExecuteAsync();
    }

    public static async Task<string> Template(string repo, string name, bool devel, string appendCMD)
    {
        var stdOutBuffer = new StringBuilder();

        await Cli.Wrap("helm")
            .WithArguments($"template {repo}/{name} --include-crds{(devel ? " --devel" : "")} {appendCMD}")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
            .ExecuteAsync();

        return stdOutBuffer.ToString();
    }
}
