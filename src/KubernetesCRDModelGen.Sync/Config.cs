namespace KubernetesCRDModelGen.Sync;

internal class Config
{
    public string Group { get; set; }

    public HelmConfig? Helm { get; set; }

    public GitHubConfig? GitHub { get; set; }

    public DirectUrlConfig? DirectUrl { get; set; }

    internal class DirectUrlConfig
    {
        public List<string>? Urls { get; set; }

        public string? Filter { get; set; }
    }

    internal class GitHubConfig
    {
        public string Repo { get; set; }

        public string? AssetFilter { get; set; }

        public string SemVer { get; set; }
    }

    internal class HelmConfig
    {
        public string Repo { get; set; }

        public string Chart { get; set; }

        public bool? PreRelease { get; set; }

        public string? CMD { get; set; }
    }
}
