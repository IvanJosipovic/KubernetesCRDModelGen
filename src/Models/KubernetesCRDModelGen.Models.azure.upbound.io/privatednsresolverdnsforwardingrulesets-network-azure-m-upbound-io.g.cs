using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>PrivateDNSResolverDNSForwardingRuleset is the Schema for the PrivateDNSResolverDNSForwardingRulesets API. Manages a Private DNS Resolver Dns Forwarding Ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateDNSResolverDNSForwardingRuleset>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateDNSResolverDNSForwardingRulesetList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privatednsresolverdnsforwardingrulesets";
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
    public IList<V1beta1PrivateDNSResolverDNSForwardingRuleset> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsSelector
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
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameSelector
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
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProvider
{
    /// <summary>Specifies the Azure Region where the Private DNS Resolver Dns Forwarding Ruleset should exist. Changing this forces a new Private DNS Resolver Dns Forwarding Ruleset to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The list of IDs of the Private DNS Resolver Outbound Endpoint that is linked to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIds")]
    public IList<string>? PrivateDnsResolverOutboundEndpointIds { get; set; }

    /// <summary>References to PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIdsRefs")]
    public IList<V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsRefs>? PrivateDnsResolverOutboundEndpointIdsRefs { get; set; }

    /// <summary>Selector for a list of PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIdsSelector")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderPrivateDnsResolverOutboundEndpointIdsSelector? PrivateDnsResolverOutboundEndpointIdsSelector { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Private DNS Resolver Dns Forwarding Ruleset should exist. Changing this forces a new Private DNS Resolver Dns Forwarding Ruleset to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsSelector
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
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProvider
{
    /// <summary>Specifies the Azure Region where the Private DNS Resolver Dns Forwarding Ruleset should exist. Changing this forces a new Private DNS Resolver Dns Forwarding Ruleset to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The list of IDs of the Private DNS Resolver Outbound Endpoint that is linked to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIds")]
    public IList<string>? PrivateDnsResolverOutboundEndpointIds { get; set; }

    /// <summary>References to PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIdsRefs")]
    public IList<V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsRefs>? PrivateDnsResolverOutboundEndpointIdsRefs { get; set; }

    /// <summary>Selector for a list of PrivateDNSResolverOutboundEndpoint in network to populate privateDnsResolverOutboundEndpointIds.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIdsSelector")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProviderPrivateDnsResolverOutboundEndpointIdsSelector? PrivateDnsResolverOutboundEndpointIdsSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecProviderConfigRef
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
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PrivateDNSResolverDNSForwardingRulesetSpec defines the desired state of PrivateDNSResolverDNSForwardingRuleset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetStatusAtProvider
{
    /// <summary>The ID of the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region where the Private DNS Resolver Dns Forwarding Ruleset should exist. Changing this forces a new Private DNS Resolver Dns Forwarding Ruleset to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The list of IDs of the Private DNS Resolver Outbound Endpoint that is linked to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("privateDnsResolverOutboundEndpointIds")]
    public IList<string>? PrivateDnsResolverOutboundEndpointIds { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Private DNS Resolver Dns Forwarding Ruleset should exist. Changing this forces a new Private DNS Resolver Dns Forwarding Ruleset to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Private DNS Resolver Dns Forwarding Ruleset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetStatusConditions
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

/// <summary>PrivateDNSResolverDNSForwardingRulesetStatus defines the observed state of PrivateDNSResolverDNSForwardingRuleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverDNSForwardingRulesetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateDNSResolverDNSForwardingRulesetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PrivateDNSResolverDNSForwardingRuleset is the Schema for the PrivateDNSResolverDNSForwardingRulesets API. Manages a Private DNS Resolver Dns Forwarding Ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateDNSResolverDNSForwardingRuleset : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateDNSResolverDNSForwardingRulesetSpec>, IStatus<V1beta1PrivateDNSResolverDNSForwardingRulesetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateDNSResolverDNSForwardingRuleset";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privatednsresolverdnsforwardingrulesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateDNSResolverDNSForwardingRulesetSpec defines the desired state of PrivateDNSResolverDNSForwardingRuleset</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetSpec Spec { get; set; }

    /// <summary>PrivateDNSResolverDNSForwardingRulesetStatus defines the observed state of PrivateDNSResolverDNSForwardingRuleset.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateDNSResolverDNSForwardingRulesetStatus? Status { get; set; }
}