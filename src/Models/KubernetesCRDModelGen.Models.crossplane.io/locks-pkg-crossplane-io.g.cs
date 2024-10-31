using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
/// <summary>A Dependency is a dependency of a package in the lock.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>LockPackage is a package that is in the lock.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LockStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status of the Lock.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LockStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LockStatusConditions>? Conditions { get; set; }
}

/// <summary>Lock is the CRD type that tracks package dependencies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Lock : IKubernetesObject<V1ObjectMeta>, IStatus<V1beta1LockStatus>
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

    /// <summary>Status of the Lock.</summary>
    [JsonPropertyName("status")]
    public V1beta1LockStatus? Status { get; set; }
}