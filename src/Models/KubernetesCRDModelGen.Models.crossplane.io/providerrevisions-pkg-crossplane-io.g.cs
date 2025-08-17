using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
#nullable enable
/// <summary>A ProviderRevision represents a revision of a Provider. Crossplane creates new revisions when there are changes to a Provider.  Crossplane creates and manages ProviderRevisions. Don't directly edit ProviderRevisions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ProviderRevisionList : IKubernetesObject<V1ListMeta>, IItems<V1ProviderRevision>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ProviderRevisionList";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "providerrevisions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1ProviderRevision> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionSpecPackagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionSpecRuntimeConfigRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the RuntimeConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderRevisionSpec specifies configuration for a ProviderRevision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionSpec
{
    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>DesiredState of the PackageRevision. Can be either Active or Inactive.</summary>
    [JsonPropertyName("desiredState")]
    public string DesiredState { get; set; }

    /// <summary>IgnoreCrossplaneConstraints indicates to the package manager whether to honor Crossplane version constrains specified by the package. Default is false.</summary>
    [JsonPropertyName("ignoreCrossplaneConstraints")]
    public bool? IgnoreCrossplaneConstraints { get; set; }

    /// <summary>Package image used by install Pod to extract package contents.</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>PackagePullPolicy defines the pull policy for the package. It is also applied to any images pulled for the package, such as a provider's controller image. Default is IfNotPresent.</summary>
    [JsonPropertyName("packagePullPolicy")]
    public string? PackagePullPolicy { get; set; }

    /// <summary>PackagePullSecrets are named secrets in the same namespace that can be used to fetch packages from private registries. They are also applied to any images pulled for the package, such as a provider's controller image.</summary>
    [JsonPropertyName("packagePullSecrets")]
    public IList<V1ProviderRevisionSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

    /// <summary>Revision number. Indicates when the revision will be garbage collected based on the parent's RevisionHistoryLimit.</summary>
    [JsonPropertyName("revision")]
    public long Revision { get; set; }

    /// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
    [JsonPropertyName("runtimeConfigRef")]
    public V1ProviderRevisionSpecRuntimeConfigRef? RuntimeConfigRef { get; set; }

    /// <summary>SkipDependencyResolution indicates to the package manager whether to skip resolving dependencies for a package. Setting this value to true may have unintended consequences. Default is false.</summary>
    [JsonPropertyName("skipDependencyResolution")]
    public bool? SkipDependencyResolution { get; set; }

    /// <summary>TLSClientSecretName is the name of the TLS Secret that stores client certificates of the Provider.</summary>
    [JsonPropertyName("tlsClientSecretName")]
    public string? TlsClientSecretName { get; set; }

    /// <summary>TLSServerSecretName is the name of the TLS Secret that stores server certificates of the Provider.</summary>
    [JsonPropertyName("tlsServerSecretName")]
    public string? TlsServerSecretName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageConfigRef is a reference to an image config that indicates how the referenced image config was used by the package manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionStatusAppliedImageConfigRefs
{
    /// <summary>Name is the name of the image config.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Reason indicates what the image config was used for.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionStatusConditions
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
#nullable disable

#nullable enable
/// <summary>A TypedReference refers to an object by Name, Kind, and APIVersion. It is commonly used to reference cluster-scoped objects or objects where the namespace is already known.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionStatusObjectRefs
{
    /// <summary>APIVersion of the referenced object.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>UID of the referenced object.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderRevisionStatus represents the observed state of a ProviderRevision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ProviderRevisionStatus
{
    /// <summary>AppliedImageConfigRefs records any image configs that were applied in reconciling this revision, and what they were used for.</summary>
    [JsonPropertyName("appliedImageConfigRefs")]
    public IList<V1ProviderRevisionStatusAppliedImageConfigRefs>? AppliedImageConfigRefs { get; set; }

    /// <summary>Capabilities of this package. Capabilities are opaque strings that may be meaningful to package consumers.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ProviderRevisionStatusConditions>? Conditions { get; set; }

    /// <summary>Dependency information.</summary>
    [JsonPropertyName("foundDependencies")]
    public long? FoundDependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("installedDependencies")]
    public long? InstalledDependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("invalidDependencies")]
    public long? InvalidDependencies { get; set; }

    /// <summary>References to objects owned by PackageRevision.</summary>
    [JsonPropertyName("objectRefs")]
    public IList<V1ProviderRevisionStatusObjectRefs>? ObjectRefs { get; set; }

    /// <summary>ResolvedPackage is the name of the package that was installed. It may be different from spec.image if the package path was rewritten using an image config.</summary>
    [JsonPropertyName("resolvedImage")]
    public string? ResolvedImage { get; set; }

    /// <summary>TLSClientSecretName is the name of the TLS Secret that stores client certificates of the Provider.</summary>
    [JsonPropertyName("tlsClientSecretName")]
    public string? TlsClientSecretName { get; set; }

    /// <summary>TLSServerSecretName is the name of the TLS Secret that stores server certificates of the Provider.</summary>
    [JsonPropertyName("tlsServerSecretName")]
    public string? TlsServerSecretName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A ProviderRevision represents a revision of a Provider. Crossplane creates new revisions when there are changes to a Provider.  Crossplane creates and manages ProviderRevisions. Don't directly edit ProviderRevisions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ProviderRevision : IKubernetesObject<V1ObjectMeta>, ISpec<V1ProviderRevisionSpec>, IStatus<V1ProviderRevisionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ProviderRevision";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "providerrevisions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderRevisionSpec specifies configuration for a ProviderRevision.</summary>
    [JsonPropertyName("spec")]
    public V1ProviderRevisionSpec? Spec { get; set; }

    /// <summary>ProviderRevisionStatus represents the observed state of a ProviderRevision.</summary>
    [JsonPropertyName("status")]
    public V1ProviderRevisionStatus? Status { get; set; }
}
#nullable disable
