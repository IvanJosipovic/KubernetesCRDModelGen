namespace KubernetesCRDModelGen.Sync;

internal class Config
{
    public required string Group { get; set; }

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
        public required string Repo { get; set; }

        public string? AssetFilter { get; set; }

        public required string SemVer { get; set; }
    }

    internal class HelmConfig
    {
        public required string Repo { get; set; }

        public required string Chart { get; set; }

        public bool? PreRelease { get; set; }

        public string? CMD { get; set; }
    }
}
