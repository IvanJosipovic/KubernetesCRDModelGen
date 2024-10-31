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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionSpecControllerConfigRef
{
    /// <summary>Name of the ControllerConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionSpecPackagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionSpecRuntimeConfigRef
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

/// <summary>FunctionSpec specifies the configuration of a Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionSpec
{
    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>ControllerConfigRef references a ControllerConfig resource that will be used to configure the packaged controller Deployment. Deprecated: Use RuntimeConfigReference instead.</summary>
    [JsonPropertyName("controllerConfigRef")]
    public V1FunctionSpecControllerConfigRef? ControllerConfigRef { get; set; }

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
    public IList<V1FunctionSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

    /// <summary>RevisionActivationPolicy specifies how the package controller should update from one revision to the next. Options are Automatic or Manual. Default is Automatic.</summary>
    [JsonPropertyName("revisionActivationPolicy")]
    public string? RevisionActivationPolicy { get; set; }

    /// <summary>RevisionHistoryLimit dictates how the package controller cleans up old inactive package revisions. Defaults to 1. Can be disabled by explicitly setting to 0.</summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
    [JsonPropertyName("runtimeConfigRef")]
    public V1FunctionSpecRuntimeConfigRef? RuntimeConfigRef { get; set; }

    /// <summary>SkipDependencyResolution indicates to the package manager whether to skip resolving dependencies for a package. Setting this value to true may have unintended consequences. Default is false.</summary>
    [JsonPropertyName("skipDependencyResolution")]
    public bool? SkipDependencyResolution { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionStatusConditions
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

/// <summary>FunctionStatus represents the observed state of a Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>CurrentIdentifier is the most recent package source that was used to produce a revision. The package manager uses this field to determine whether to check for package updates for a given source when packagePullPolicy is set to IfNotPresent. Manually removing this field will cause the package manager to check that the current revision is correct for the given package source.</summary>
    [JsonPropertyName("currentIdentifier")]
    public string? CurrentIdentifier { get; set; }

    /// <summary>CurrentRevision is the name of the current package revision. It will reflect the most up to date revision, whether it has been activated or not.</summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }
}

/// <summary>A Function installs an OCI compatible Crossplane package, extending Crossplane with support for a new kind of composition function.  Read the Crossplane documentation for [more information about Functions](https://docs.crossplane.io/latest/concepts/composition-functions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1FunctionSpec>, IStatus<V1FunctionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "functions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec specifies the configuration of a Function.</summary>
    [JsonPropertyName("spec")]
    public V1FunctionSpec? Spec { get; set; }

    /// <summary>FunctionStatus represents the observed state of a Function.</summary>
    [JsonPropertyName("status")]
    public V1FunctionStatus? Status { get; set; }
}