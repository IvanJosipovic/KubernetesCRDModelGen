using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securityinsights.azure.upbound.io;
/// <summary>SentinelWatchlist is the Schema for the SentinelWatchlists API. Manages a Sentinel Watchlist.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SentinelWatchlistList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SentinelWatchlist>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SentinelWatchlistList";
    public const string KubeGroup = "securityinsights.azure.upbound.io";
    public const string KubePluralName = "sentinelwatchlists";
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
    public IList<V1beta1SentinelWatchlist> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecForProvider
{
    /// <summary>The default duration in ISO8601 duration form of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("defaultDuration")]
    public string? DefaultDuration { get; set; }

    /// <summary>The description of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The key used to optimize query performance when using Watchlist for joins with other data. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("itemSearchKey")]
    public string? ItemSearchKey { get; set; }

    /// <summary>Specifies a list of labels related to this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The ID of the Log Analytics Workspace where this Sentinel Watchlist resides in. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1SentinelWatchlistSpecForProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecInitProvider
{
    /// <summary>The default duration in ISO8601 duration form of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("defaultDuration")]
    public string? DefaultDuration { get; set; }

    /// <summary>The description of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The key used to optimize query performance when using Watchlist for joins with other data. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("itemSearchKey")]
    public string? ItemSearchKey { get; set; }

    /// <summary>Specifies a list of labels related to this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecProviderConfigRefPolicy
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
public partial class V1beta1SentinelWatchlistSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelWatchlistSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SentinelWatchlistSpec defines the desired state of SentinelWatchlist</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SentinelWatchlistSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SentinelWatchlistSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SentinelWatchlistSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SentinelWatchlistSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistStatusAtProvider
{
    /// <summary>The default duration in ISO8601 duration form of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("defaultDuration")]
    public string? DefaultDuration { get; set; }

    /// <summary>The description of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Sentinel Watchlist.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The key used to optimize query performance when using Watchlist for joins with other data. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("itemSearchKey")]
    public string? ItemSearchKey { get; set; }

    /// <summary>Specifies a list of labels related to this Sentinel Watchlist. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The ID of the Log Analytics Workspace where this Sentinel Watchlist resides in. Changing this forces a new Sentinel Watchlist to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistStatusConditions
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

/// <summary>SentinelWatchlistStatus defines the observed state of SentinelWatchlist.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelWatchlistStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SentinelWatchlistStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SentinelWatchlistStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SentinelWatchlist is the Schema for the SentinelWatchlists API. Manages a Sentinel Watchlist.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SentinelWatchlist : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SentinelWatchlistSpec>, IStatus<V1beta1SentinelWatchlistStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SentinelWatchlist";
    public const string KubeGroup = "securityinsights.azure.upbound.io";
    public const string KubePluralName = "sentinelwatchlists";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SentinelWatchlistSpec defines the desired state of SentinelWatchlist</summary>
    [JsonPropertyName("spec")]
    public V1beta1SentinelWatchlistSpec Spec { get; set; }

    /// <summary>SentinelWatchlistStatus defines the observed state of SentinelWatchlist.</summary>
    [JsonPropertyName("status")]
    public V1beta1SentinelWatchlistStatus? Status { get; set; }
}