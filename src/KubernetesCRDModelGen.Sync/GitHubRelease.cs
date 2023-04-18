namespace KubernetesCRDModelGen.Sync
{
    internal class GitHubRelease
    {
        public string tag_name { get; set; }
        public string name { get; set; }
        public bool draft { get; set; }
        public bool prerelease { get; set; }
        public Asset[] assets { get; set; }
        public string tarball_url { get; set; }
        public string zipball_url { get; set; }

        internal class Asset
        {
            public string name { get; set; }
            public string browser_download_url { get; set; }
        }
    }
}
