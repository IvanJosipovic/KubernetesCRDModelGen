using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
public partial class V1beta1LockPackagesDependencies
{
    /// <summary>Constraints is a valid semver range or a digest, which will be used to select a valid dependency version.</summary>
    [JsonPropertyName("constraints")]
    public string Constraints { get; set; }

    /// <summary>Package is the OCI image name without a tag or digest.</summary>
    [JsonPropertyName("package")]
    public string Package { get; set; }

    /// <summary>Type is the type of package. Can be either Configuration or Provider.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1beta1LockPackages
{
    /// <summary>Dependencies are the list of dependencies of this package. The order of the dependencies will dictate the order in which they are resolved.</summary>
    [JsonPropertyName("dependencies")]
    public IList<V1beta1LockPackagesDependencies> Dependencies { get; set; }

    /// <summary>Name corresponds to the name of the package revision for this package.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Source is the OCI image name without a tag or digest.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }

    /// <summary>Type is the type of package. Can be either Configuration or Provider.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>Version is the tag or digest of the OCI image.</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Lock : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Lock";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "locks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("packages")]
    public IList<V1beta1LockPackages>? Packages { get; set; }
}