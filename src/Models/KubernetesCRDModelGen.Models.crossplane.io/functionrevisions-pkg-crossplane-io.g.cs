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
public partial class V1FunctionRevisionSpecControllerConfigRef
{
    /// <summary>Name of the ControllerConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionSpecPackagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionSpecRuntimeConfigRef
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

/// <summary>FunctionRevisionSpec specifies configuration for a FunctionRevision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionSpec
{
    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>ControllerConfigRef references a ControllerConfig resource that will be used to configure the packaged controller Deployment. Deprecated: Use RuntimeConfigReference instead.</summary>
    [JsonPropertyName("controllerConfigRef")]
    public V1FunctionRevisionSpecControllerConfigRef? ControllerConfigRef { get; set; }

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
    public IList<V1FunctionRevisionSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

    /// <summary>Revision number. Indicates when the revision will be garbage collected based on the parent's RevisionHistoryLimit.</summary>
    [JsonPropertyName("revision")]
    public long Revision { get; set; }

    /// <summary>RuntimeConfigRef references a RuntimeConfig resource that will be used to configure the package runtime.</summary>
    [JsonPropertyName("runtimeConfigRef")]
    public V1FunctionRevisionSpecRuntimeConfigRef? RuntimeConfigRef { get; set; }

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

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionStatusConditions
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

/// <summary>A TypedReference refers to an object by Name, Kind, and APIVersion. It is commonly used to reference cluster-scoped objects or objects where the namespace is already known.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionStatusObjectRefs
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

/// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionStatusPermissionRequests
{
    /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed. "" represents the core API group and "*" represents all API groups.</summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.</summary>
    [JsonPropertyName("nonResourceURLs")]
    public IList<string>? NonResourceURLs { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>Resources is a list of resources this rule applies to. '*' represents all resources.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds contained in this rule. '*' represents all verbs.</summary>
    [JsonPropertyName("verbs")]
    public IList<string> Verbs { get; set; }
}

/// <summary>FunctionRevisionStatus represents the observed state of a FunctionRevision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FunctionRevisionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1FunctionRevisionStatusConditions>? Conditions { get; set; }

    /// <summary>Endpoint is the gRPC endpoint where Crossplane will send RunFunctionRequests.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

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
    public IList<V1FunctionRevisionStatusObjectRefs>? ObjectRefs { get; set; }

    /// <summary>PermissionRequests made by this package. The package declares that its controller needs these permissions to run. The RBAC manager is responsible for granting them.</summary>
    [JsonPropertyName("permissionRequests")]
    public IList<V1FunctionRevisionStatusPermissionRequests>? PermissionRequests { get; set; }
}

/// <summary>A FunctionRevision represents a revision of a Function. Crossplane creates new revisions when there are changes to the Function.  Crossplane creates and manages FunctionRevisions. Don't directly edit FunctionRevisions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FunctionRevision : IKubernetesObject<V1ObjectMeta>, ISpec<V1FunctionRevisionSpec>, IStatus<V1FunctionRevisionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FunctionRevision";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "functionrevisions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionRevisionSpec specifies configuration for a FunctionRevision.</summary>
    [JsonPropertyName("spec")]
    public V1FunctionRevisionSpec? Spec { get; set; }

    /// <summary>FunctionRevisionStatus represents the observed state of a FunctionRevision.</summary>
    [JsonPropertyName("status")]
    public V1FunctionRevisionStatus? Status { get; set; }
}