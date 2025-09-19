using Semver;
using System.Formats.Tar;
using System.IO.Compression;
using System.Text.RegularExpressions;
using Valleysoft.DockerRegistryClient;
using Valleysoft.DockerRegistryClient.Models;
using Valleysoft.DockerRegistryClient.Models.Manifests.Docker;
using Valleysoft.DockerRegistryClient.Models.Manifests.Oci;
using Valleysoft.DockerRegistryClient.Models.Manifests;

namespace KubernetesCRDModelGen.Sync.OCIClient;

internal static partial class OCIClient
{
    public static async Task<Dictionary<string, Stream>> GetStreams(Config config)
    {
        var tags = await GetTags(config.OCI.Image);

        if (!string.IsNullOrEmpty(config.OCI.SemVer))
        {
            var range = SemVersionRange.Parse(config.OCI.SemVer);

            var matchingVersions = tags
                .Select(tag => SemVersion.TryParse(tag, SemVersionStyles.Any, out var version) ? (tag, version) : (tag, null))
                .Where(version => version.version is not null && range.Contains(version.version))
                .ToList();

            if (matchingVersions.Count == 0)
            {
                throw new Exception($"No tags match the specified SemVer range: {config.OCI.SemVer}");
            }

            var highestVersion = matchingVersions.OrderBy(x => x.version).First();

            var yamls = await DownloadImage(config.OCI.Image + ":" + highestVersion.tag);
            return yamls;
        }
        else
        {
            var yamls = await DownloadImage(config.OCI.Image + ":" + config.OCI.Tag);
            return yamls;
        }
    }

    [GeneratedRegex(ImageRegex)]
    private static partial Regex ImageRegexMatcher();

    private const string ImageRegex = @"(^([a-zA-Z0-9_.-]+)\/((?:[a-z0-9_.-]+\/?)+))(?::?([a-z0-9_.-]+))?$";

    private static string GetRegistry(string image)
    {
        var match = ImageRegexMatcher().Match(image);

        if (!match.Success)
        {
            throw new Exception($"Image format is not valid: '{image}'. Should be host/repository/image");
        }

        return match.Groups[2].Value;
    }

    private static string GetRepositoryName(string image)
    {
        var match = ImageRegexMatcher().Match(image);

        if (!match.Success)
        {
            throw new Exception($"Image format is not valid: '{image}'. Should be host/repository/image");
        }

        return match.Groups[3].Value;
    }

    private static string GetTag(string image)
    {
        var match = ImageRegexMatcher().Match(image);

        if (!match.Success)
        {
            throw new Exception($"Image format is not valid: '{image}'. Should be host/repository/image");
        }

        return match.Groups[4].Value;
    }

    private static async Task<string[]> GetTags(string image)
    {
        RegistryClient client = new(GetRegistry(image));
        RepositoryTags tags = await client.Tags.GetAllAsync(GetRepositoryName(image));

        foreach (var tag in tags.Tags)
        {
            Console.WriteLine(tag);
        }

        return tags.Tags;
    }

    private static async Task<Dictionary<string, Stream>> DownloadImage(string image)
    {
        RegistryClient client = new(GetRegistry(image));

        var manifest = await client.Manifests.GetAsync(GetRepositoryName(image), GetTag(image));

        return await ProcessManifests(client, image, manifest.Manifest);
    }

    private static async Task<Dictionary<string, Stream>> ProcessManifests(RegistryClient client, string image, IManifest manifest)
    {
        var yamls = new Dictionary<string, Stream>();

        if (manifest is ManifestList dockerManigest)
        {
            foreach (var manifestReference in dockerManigest.Manifests)
            {
                if (manifestReference.Platform?.Architecture == "arm64")
                {
                    continue;
                }

                var manifest2 = await client.Manifests.GetAsync(GetRepositoryName(image), manifestReference.Digest);

                var newYamls = await ProcessManifests(client, image, manifest2.Manifest);
                foreach (var kvp in newYamls)
                    yamls[kvp.Key] = kvp.Value;
            }
        }
        if (manifest is OciImageIndex ociImageIndex)
        {
            foreach (var manifestReference in ociImageIndex.Manifests)
            {
                if (manifestReference.Platform?.Architecture == "arm64")
                {
                    continue;
                }

                var manifest2 = await client.Manifests.GetAsync(GetRepositoryName(image), manifestReference.Digest);

                var newYamls = await ProcessManifests(client, image, manifest2.Manifest);
                foreach (var kvp in newYamls)
                    yamls[kvp.Key] = kvp.Value;
            }
        }
        if (manifest is DockerManifest docker)
        {
            foreach (var layer in docker.Layers)
            {
                var stream = await client.Blobs.GetAsync(GetRepositoryName(image), layer.Digest);

                var copy = new MemoryStream();
                stream.CopyTo(copy);
                copy.Position = 0;

                var newYamls = ExtractAllYaml(copy);
                foreach (var kvp in newYamls)
                    yamls[kvp.Key] = kvp.Value;
            }
        }
        if (manifest is OciImageManifest oci)
        {
            foreach (var layer in oci.Layers)
            {
                var stream = await client.Blobs.GetAsync(GetRepositoryName(image), layer.Digest);

                var copy = new MemoryStream();
                stream.CopyTo(copy);
                copy.Position = 0;

                var newYamls = ExtractAllYaml(copy);
                foreach (var kvp in newYamls)
                    yamls[kvp.Key] = kvp.Value;
            }
        }

        return yamls;
    }

    private static Dictionary<string, Stream> ExtractAllYaml(Stream stream)
    {
        Dictionary<string, Stream> result = [];

        var gz = new GZipStream(stream, CompressionMode.Decompress);
        var reader = new TarReader(gz);

        try
        {
            while (reader.GetNextEntry() is TarEntry entry)
            {
                string name = entry.Name;

                if (entry.EntryType == TarEntryType.RegularFile &&
                    (name.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) ||
                     name.EndsWith(".yml", StringComparison.OrdinalIgnoreCase)))
                {
                    if (entry.DataStream == null || !entry.DataStream.CanRead)
                    {
                        continue;
                    }

                    using Stream data = entry.DataStream;
                    MemoryStream ms = new();
                    data.CopyTo(ms);
                    ms.Position = 0;

                    result[name] = ms;
                    Console.WriteLine($"Extracted {name}");
                }
            }
        }
        catch (ObjectDisposedException)
        {
        }



        return result;
    }
}

public static class Extensions
{
    public static async Task<RepositoryTags> GetAllAsync(this ITagOperations client, string image)
    {
        List<string> allTags = [];

        var tagsPage = await client.GetAsync(image);
        var repository = tagsPage.Value.RepositoryName;
        allTags.AddRange(tagsPage.Value.Tags);

        while (!string.IsNullOrEmpty(tagsPage.NextPageLink))
        {
            tagsPage = await client.GetNextAsync(tagsPage.NextPageLink);
            allTags.AddRange(tagsPage.Value.Tags);
        }

        return new RepositoryTags
        {
            RepositoryName = repository,
            Tags = [.. allTags]
        };
    }
}