using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProviderClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a KubernetesCluster in containerservice to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProviderClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterExtensionSpecForProviderClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProviderClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a KubernetesCluster in containerservice to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProviderClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterExtensionSpecForProviderClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProviderPlan
{
    /// <summary>Specifies the name of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the promotion code to use with the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Specifies the publisher of the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the version of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecForProvider
{
    /// <summary>Specifies the Cluster ID. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Reference to a KubernetesCluster in containerservice to populate clusterId.</summary>
    [JsonPropertyName("clusterIdRef")]
    public V1beta1KubernetesClusterExtensionSpecForProviderClusterIdRef? ClusterIdRef { get; set; }

    /// <summary>Selector for a KubernetesCluster in containerservice to populate clusterId.</summary>
    [JsonPropertyName("clusterIdSelector")]
    public V1beta1KubernetesClusterExtensionSpecForProviderClusterIdSelector? ClusterIdSelector { get; set; }

    /// <summary>Configuration settings that are sensitive, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationSettings")]
    public IDictionary<string, string>? ConfigurationSettings { get; set; }

    /// <summary>Specifies the type of extension. It must be one of the extension types registered with Microsoft.KubernetesConfiguration by the Extension publisher. For more information, please refer to Available Extensions for AKS. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("extensionType")]
    public string? ExtensionType { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta1KubernetesClusterExtensionSpecForProviderPlan? Plan { get; set; }

    /// <summary>Namespace where the extension release must be placed for a cluster scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseNamespace")]
    public string? ReleaseNamespace { get; set; }

    /// <summary>The release train used by this extension. Possible values include but are not limited to Stable, Preview. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseTrain")]
    public string? ReleaseTrain { get; set; }

    /// <summary>Namespace where the extension will be created for a namespace scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>User-specified version that the extension should pin to. If it is not set, Azure will use the latest version and auto upgrade it. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecInitProviderPlan
{
    /// <summary>Specifies the name of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the promotion code to use with the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Specifies the publisher of the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the version of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecInitProvider
{
    /// <summary>Configuration settings that are sensitive, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationSettings")]
    public IDictionary<string, string>? ConfigurationSettings { get; set; }

    /// <summary>Specifies the type of extension. It must be one of the extension types registered with Microsoft.KubernetesConfiguration by the Extension publisher. For more information, please refer to Available Extensions for AKS. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("extensionType")]
    public string? ExtensionType { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta1KubernetesClusterExtensionSpecInitProviderPlan? Plan { get; set; }

    /// <summary>Namespace where the extension release must be placed for a cluster scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseNamespace")]
    public string? ReleaseNamespace { get; set; }

    /// <summary>The release train used by this extension. Possible values include but are not limited to Stable, Preview. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseTrain")]
    public string? ReleaseTrain { get; set; }

    /// <summary>Namespace where the extension will be created for a namespace scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>User-specified version that the extension should pin to. If it is not set, Azure will use the latest version and auto upgrade it. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterExtensionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>KubernetesClusterExtensionSpec defines the desired state of KubernetesClusterExtension</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KubernetesClusterExtensionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KubernetesClusterExtensionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KubernetesClusterExtensionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KubernetesClusterExtensionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionStatusAtProviderAksAssignedIdentity
{
    /// <summary>The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionStatusAtProviderPlan
{
    /// <summary>Specifies the name of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the promotion code to use with the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Specifies the publisher of the plan. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the version of the plan from the marketplace. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionStatusAtProvider
{
    /// <summary>An aks_assigned_identity block as defined below.</summary>
    [JsonPropertyName("aksAssignedIdentity")]
    public IList<V1beta1KubernetesClusterExtensionStatusAtProviderAksAssignedIdentity>? AksAssignedIdentity { get; set; }

    /// <summary>Specifies the Cluster ID. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Configuration settings that are sensitive, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationProtectedSettings")]
    public IDictionary<string, string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
    [JsonPropertyName("configurationSettings")]
    public IDictionary<string, string>? ConfigurationSettings { get; set; }

    /// <summary>The current version of the extension.</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>Specifies the type of extension. It must be one of the extension types registered with Microsoft.KubernetesConfiguration by the Extension publisher. For more information, please refer to Available Extensions for AKS. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("extensionType")]
    public string? ExtensionType { get; set; }

    /// <summary>The ID of the Kubernetes Cluster Extension.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta1KubernetesClusterExtensionStatusAtProviderPlan? Plan { get; set; }

    /// <summary>Namespace where the extension release must be placed for a cluster scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseNamespace")]
    public string? ReleaseNamespace { get; set; }

    /// <summary>The release train used by this extension. Possible values include but are not limited to Stable, Preview. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("releaseTrain")]
    public string? ReleaseTrain { get; set; }

    /// <summary>Namespace where the extension will be created for a namespace scoped extension. If this namespace does not exist, it will be created. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>User-specified version that the extension should pin to. If it is not set, Azure will use the latest version and auto upgrade it. Changing this forces a new Kubernetes Cluster Extension to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionStatusConditions
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

/// <summary>KubernetesClusterExtensionStatus defines the observed state of KubernetesClusterExtension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterExtensionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KubernetesClusterExtensionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KubernetesClusterExtensionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KubernetesClusterExtension is the Schema for the KubernetesClusterExtensions API. Manages a Kubernetes Cluster Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KubernetesClusterExtension : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KubernetesClusterExtensionSpec>, IStatus<V1beta1KubernetesClusterExtensionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KubernetesClusterExtension";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusterextensions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KubernetesClusterExtensionSpec defines the desired state of KubernetesClusterExtension</summary>
    [JsonPropertyName("spec")]
    public V1beta1KubernetesClusterExtensionSpec Spec { get; set; }

    /// <summary>KubernetesClusterExtensionStatus defines the observed state of KubernetesClusterExtension.</summary>
    [JsonPropertyName("status")]
    public V1beta1KubernetesClusterExtensionStatus? Status { get; set; }
}

/// <summary>KubernetesClusterExtension is the Schema for the KubernetesClusterExtensions API. Manages a Kubernetes Cluster Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KubernetesClusterExtensionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KubernetesClusterExtension>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KubernetesClusterExtensionList";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusterextensions";
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
    public IList<V1beta1KubernetesClusterExtension> Items { get; set; }
}