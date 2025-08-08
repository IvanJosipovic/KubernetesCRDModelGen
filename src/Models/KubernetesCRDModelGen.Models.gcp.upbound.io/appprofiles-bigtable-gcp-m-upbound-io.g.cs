using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.gcp.m.upbound.io;
/// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderDataBoostIsolationReadOnly
{
    /// <summary>The Compute Billing Owner for this Data Boost App Profile. Possible values are: HOST_PAYS.</summary>
    [JsonPropertyName("computeBillingOwner")]
    public string? ComputeBillingOwner { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderInstanceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in bigtable to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppProfileSpecForProviderInstanceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderInstanceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in bigtable to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderInstanceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppProfileSpecForProviderInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderSingleClusterRouting
{
    /// <summary>If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile. It is unsafe to send these requests to the same table/row/column in multiple clusters.</summary>
    [JsonPropertyName("allowTransactionalWrites")]
    public bool? AllowTransactionalWrites { get; set; }

    /// <summary>The cluster to which read/write requests should be routed.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }
}

/// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProviderStandardIsolation
{
    /// <summary>The priority of requests sent using this app profile. Possible values are: PRIORITY_LOW, PRIORITY_MEDIUM, PRIORITY_HIGH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecForProvider
{
    /// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
    [JsonPropertyName("dataBoostIsolationReadOnly")]
    public V1beta1AppProfileSpecForProviderDataBoostIsolationReadOnly? DataBoostIsolationReadOnly { get; set; }

    /// <summary>Long form description of the use case for this app profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, ignore safety checks when deleting/updating the app profile.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary>The name of the instance to create the app profile within.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in bigtable to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1AppProfileSpecForProviderInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in bigtable to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1AppProfileSpecForProviderInstanceSelector? InstanceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multiClusterRoutingClusterIds")]
    public IList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes consistency to improve availability.</summary>
    [JsonPropertyName("multiClusterRoutingUseAny")]
    public bool? MultiClusterRoutingUseAny { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowAffinity")]
    public bool? RowAffinity { get; set; }

    /// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
    [JsonPropertyName("singleClusterRouting")]
    public V1beta1AppProfileSpecForProviderSingleClusterRouting? SingleClusterRouting { get; set; }

    /// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
    [JsonPropertyName("standardIsolation")]
    public V1beta1AppProfileSpecForProviderStandardIsolation? StandardIsolation { get; set; }
}

/// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecInitProviderDataBoostIsolationReadOnly
{
    /// <summary>The Compute Billing Owner for this Data Boost App Profile. Possible values are: HOST_PAYS.</summary>
    [JsonPropertyName("computeBillingOwner")]
    public string? ComputeBillingOwner { get; set; }
}

/// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecInitProviderSingleClusterRouting
{
    /// <summary>If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile. It is unsafe to send these requests to the same table/row/column in multiple clusters.</summary>
    [JsonPropertyName("allowTransactionalWrites")]
    public bool? AllowTransactionalWrites { get; set; }

    /// <summary>The cluster to which read/write requests should be routed.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }
}

/// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecInitProviderStandardIsolation
{
    /// <summary>The priority of requests sent using this app profile. Possible values are: PRIORITY_LOW, PRIORITY_MEDIUM, PRIORITY_HIGH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecInitProvider
{
    /// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
    [JsonPropertyName("dataBoostIsolationReadOnly")]
    public V1beta1AppProfileSpecInitProviderDataBoostIsolationReadOnly? DataBoostIsolationReadOnly { get; set; }

    /// <summary>Long form description of the use case for this app profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, ignore safety checks when deleting/updating the app profile.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multiClusterRoutingClusterIds")]
    public IList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes consistency to improve availability.</summary>
    [JsonPropertyName("multiClusterRoutingUseAny")]
    public bool? MultiClusterRoutingUseAny { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowAffinity")]
    public bool? RowAffinity { get; set; }

    /// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
    [JsonPropertyName("singleClusterRouting")]
    public V1beta1AppProfileSpecInitProviderSingleClusterRouting? SingleClusterRouting { get; set; }

    /// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
    [JsonPropertyName("standardIsolation")]
    public V1beta1AppProfileSpecInitProviderStandardIsolation? StandardIsolation { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AppProfileSpec defines the desired state of AppProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatusAtProviderDataBoostIsolationReadOnly
{
    /// <summary>The Compute Billing Owner for this Data Boost App Profile. Possible values are: HOST_PAYS.</summary>
    [JsonPropertyName("computeBillingOwner")]
    public string? ComputeBillingOwner { get; set; }
}

/// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatusAtProviderSingleClusterRouting
{
    /// <summary>If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile. It is unsafe to send these requests to the same table/row/column in multiple clusters.</summary>
    [JsonPropertyName("allowTransactionalWrites")]
    public bool? AllowTransactionalWrites { get; set; }

    /// <summary>The cluster to which read/write requests should be routed.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }
}

/// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatusAtProviderStandardIsolation
{
    /// <summary>The priority of requests sent using this app profile. Possible values are: PRIORITY_LOW, PRIORITY_MEDIUM, PRIORITY_HIGH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatusAtProvider
{
    /// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Structure is documented below.</summary>
    [JsonPropertyName("dataBoostIsolationReadOnly")]
    public V1beta1AppProfileStatusAtProviderDataBoostIsolationReadOnly? DataBoostIsolationReadOnly { get; set; }

    /// <summary>Long form description of the use case for this app profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/instances/{{instance}}/appProfiles/{{app_profile_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If true, ignore safety checks when deleting/updating the app profile.</summary>
    [JsonPropertyName("ignoreWarnings")]
    public bool? IgnoreWarnings { get; set; }

    /// <summary>The name of the instance to create the app profile within.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary></summary>
    [JsonPropertyName("multiClusterRoutingClusterIds")]
    public IList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes consistency to improve availability.</summary>
    [JsonPropertyName("multiClusterRoutingUseAny")]
    public bool? MultiClusterRoutingUseAny { get; set; }

    /// <summary>The unique name of the requested app profile. Values are of the form projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;appProfileId&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rowAffinity")]
    public bool? RowAffinity { get; set; }

    /// <summary>Use a single-cluster routing policy. Structure is documented below.</summary>
    [JsonPropertyName("singleClusterRouting")]
    public V1beta1AppProfileStatusAtProviderSingleClusterRouting? SingleClusterRouting { get; set; }

    /// <summary>The standard options used for isolating this app profile's traffic from other use cases. Structure is documented below.</summary>
    [JsonPropertyName("standardIsolation")]
    public V1beta1AppProfileStatusAtProviderStandardIsolation? StandardIsolation { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatusConditions
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

/// <summary>AppProfileStatus defines the observed state of AppProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AppProfile is the Schema for the AppProfiles API. App profile is a configuration object describing how Cloud Bigtable should treat traffic from a particular end user application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppProfileSpec>, IStatus<V1beta1AppProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppProfile";
    public const string KubeGroup = "bigtable.gcp.m.upbound.io";
    public const string KubePluralName = "appprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppProfileSpec defines the desired state of AppProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppProfileSpec Spec { get; set; }

    /// <summary>AppProfileStatus defines the observed state of AppProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppProfileStatus? Status { get; set; }
}

/// <summary>AppProfile is the Schema for the AppProfiles API. App profile is a configuration object describing how Cloud Bigtable should treat traffic from a particular end user application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppProfileList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AppProfile>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppProfileList";
    public const string KubeGroup = "bigtable.gcp.m.upbound.io";
    public const string KubePluralName = "appprofiles";
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
    public IList<V1beta1AppProfile> Items { get; set; }
}