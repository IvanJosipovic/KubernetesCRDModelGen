using System.Diagnostics;

namespace KubernetesCRDModelGen.Sync;

public static class HelmClient
{
    public static void RepoAdd(string name, string url)
    {
        var process = new Process();
        process.StartInfo.FileName = "helm";
        process.StartInfo.Arguments = $"repo add {name} {url}";
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

        process.Start();
        process.WaitForExit();
    }

    public static void RepoRemove(string name)
    {
        var process = new Process();
        process.StartInfo.FileName = "helm";
        process.StartInfo.Arguments = $"repo remove {name}";
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

        process.Start();
        process.WaitForExit();
    }

    public static void RepoUpdate()
    {
        var process = new Process();
        process.StartInfo.FileName = "helm";
        process.StartInfo.Arguments = "repo update";
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

        process.Start();
        process.WaitForExit();
    }

    public static string Template(string repo, string name, bool devel, string appendCMD)
    {
        var process = new Process();
        process.StartInfo.FileName = "helm";
        process.StartInfo.Arguments = $"template {repo}/{name} --include-crds{(devel ? " --devel" : "")} {appendCMD}";
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;

        process.Start();

        var output =  process.StandardOutput.ReadToEnd();

        process.WaitForExit();

        return output;
    }
}
