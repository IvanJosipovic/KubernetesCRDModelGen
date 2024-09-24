using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
/// <summary>ControllerConfigRef references a ControllerConfig resource that will be used to configure the packaged controller Deployment. Deprecated: Use RuntimeConfigReference instead.</summary>
public partial class V1ProviderSpecControllerConfigRef
{
    /// <summary>Name of the ControllerConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
public partial class V1ProviderSpecPackagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
public partial class V1ProviderSpecRuntimeConfigRef
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

/// <summary>ProviderSpec specifies details about a request to install a provider to Crossplane.</summary>
public partial class V1ProviderSpec
{
    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>ControllerConfigRef references a ControllerConfig resource that will be used to configure the packaged controller Deployment. Deprecated: Use RuntimeConfigReference instead.</summary>
    [JsonPropertyName("controllerConfigRef")]
    public V1ProviderSpecControllerConfigRef? ControllerConfigRef { get; set; }

    /// <summary>IgnoreCrossplaneConstraints indicates to the package manager whether to honor Crossplane version constrains specified by the package. Default is false.</summary>
    [JsonPropertyName("ignoreCrossplaneConstraints")]
    public bool? IgnoreCrossplaneConstraints { get; set; }

    /// <summary>Package is the name of the package that is being requested.</summary>
    [JsonPropertyName("package")]
    public string Package { get; set; }

    /// <summary>PackagePullPolicy defines the pull policy for the package. Default is IfNotPresent.</summary>
    [JsonPropertyName("packagePullPolicy")]
    public string? PackagePullPolicy { get; set; }

    /// <summary>PackagePullSecrets are named secrets in the same namespace that can be used to fetch packages from private registries.</summary>
    [JsonPropertyName("packagePullSecrets")]
    public IList<V1ProviderSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

    /// <summary>RevisionActivationPolicy specifies how the package controller should update from one revision to the next. Options are Automatic or Manual. Default is Automatic.</summary>
    [JsonPropertyName("revisionActivationPolicy")]
    public string? RevisionActivationPolicy { get; set; }

    /// <summary>RevisionHistoryLimit dictates how the package controller cleans up old inactive package revisions. Defaults to 1. Can be disabled by explicitly setting to 0.</summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
    [JsonPropertyName("runtimeConfigRef")]
    public V1ProviderSpecRuntimeConfigRef? RuntimeConfigRef { get; set; }

    /// <summary>SkipDependencyResolution indicates to the package manager whether to skip resolving dependencies for a package. Setting this value to true may have unintended consequences. Default is false.</summary>
    [JsonPropertyName("skipDependencyResolution")]
    public bool? SkipDependencyResolution { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1ProviderStatusConditions
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

/// <summary>ProviderStatus represents the observed state of a Provider.</summary>
public partial class V1ProviderStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ProviderStatusConditions>? Conditions { get; set; }

    /// <summary>CurrentIdentifier is the most recent package source that was used to produce a revision. The package manager uses this field to determine whether to check for package updates for a given source when packagePullPolicy is set to IfNotPresent. Manually removing this field will cause the package manager to check that the current revision is correct for the given package source.</summary>
    [JsonPropertyName("currentIdentifier")]
    public string? CurrentIdentifier { get; set; }

    /// <summary>CurrentRevision is the name of the current package revision. It will reflect the most up to date revision, whether it has been activated or not.</summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>A Provider installs an OCI compatible Crossplane package, extending Crossplane with support for new kinds of managed resources.   Read the Crossplane documentation for [more information about Providers](https://docs.crossplane.io/latest/concepts/providers).</summary>
public partial class V1Provider : IKubernetesObject<V1ObjectMeta>, ISpec<V1ProviderSpec>, IStatus<V1ProviderStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Provider";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "providers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderSpec specifies details about a request to install a provider to Crossplane.</summary>
    [JsonPropertyName("spec")]
    public V1ProviderSpec? Spec { get; set; }

    /// <summary>ProviderStatus represents the observed state of a Provider.</summary>
    [JsonPropertyName("status")]
    public V1ProviderStatus? Status { get; set; }
}