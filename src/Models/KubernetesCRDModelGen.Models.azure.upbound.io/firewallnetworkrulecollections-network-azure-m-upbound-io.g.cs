using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>FirewallNetworkRuleCollection is the Schema for the FirewallNetworkRuleCollections API. Manages a Network Rule Collection within an Azure Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirewallNetworkRuleCollectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FirewallNetworkRuleCollection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirewallNetworkRuleCollectionList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "firewallnetworkrulecollections";
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
    public IList<V1beta1FirewallNetworkRuleCollection> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Firewall in network to populate azureFirewallName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Firewall in network to populate azureFirewallName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameSelector
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
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameSelector
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
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProviderRule
{
    /// <summary>Specifies a description for the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Either a list of destination IP addresses and/or IP ranges, or a list of destination Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>A list of destination FQDNS for the rule.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>A list of destination IP Group IDs for the rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>A list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Specifies the name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of protocols. Possible values are Any, ICMP, TCP and UDP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>A list of source IP addresses and/or IP ranges.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>A list of IP Group IDs for the rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecForProvider
{
    /// <summary>Specifies the action the rule will apply to matching traffic. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Specifies the name of the Firewall in which the Network Rule Collection should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("azureFirewallName")]
    public string? AzureFirewallName { get; set; }

    /// <summary>Reference to a Firewall in network to populate azureFirewallName.</summary>
    [JsonPropertyName("azureFirewallNameRef")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameRef? AzureFirewallNameRef { get; set; }

    /// <summary>Selector for a Firewall in network to populate azureFirewallName.</summary>
    [JsonPropertyName("azureFirewallNameSelector")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderAzureFirewallNameSelector? AzureFirewallNameSelector { get; set; }

    /// <summary>Specifies the priority of the rule collection. Possible values are between 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallNetworkRuleCollectionSpecForProviderRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecInitProviderRule
{
    /// <summary>Specifies a description for the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Either a list of destination IP addresses and/or IP ranges, or a list of destination Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>A list of destination FQDNS for the rule.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>A list of destination IP Group IDs for the rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>A list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Specifies the name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of protocols. Possible values are Any, ICMP, TCP and UDP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>A list of source IP addresses and/or IP ranges.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>A list of IP Group IDs for the rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecInitProvider
{
    /// <summary>Specifies the action the rule will apply to matching traffic. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Specifies the priority of the rule collection. Possible values are between 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallNetworkRuleCollectionSpecInitProviderRule>? Rule { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpecProviderConfigRef
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
public partial class V1beta1FirewallNetworkRuleCollectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FirewallNetworkRuleCollectionSpec defines the desired state of FirewallNetworkRuleCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FirewallNetworkRuleCollectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FirewallNetworkRuleCollectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FirewallNetworkRuleCollectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FirewallNetworkRuleCollectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionStatusAtProviderRule
{
    /// <summary>Specifies a description for the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Either a list of destination IP addresses and/or IP ranges, or a list of destination Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>A list of destination FQDNS for the rule.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>A list of destination IP Group IDs for the rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>A list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Specifies the name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of protocols. Possible values are Any, ICMP, TCP and UDP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>A list of source IP addresses and/or IP ranges.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>A list of IP Group IDs for the rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionStatusAtProvider
{
    /// <summary>Specifies the action the rule will apply to matching traffic. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Specifies the name of the Firewall in which the Network Rule Collection should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("azureFirewallName")]
    public string? AzureFirewallName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the priority of the rule collection. Possible values are between 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallNetworkRuleCollectionStatusAtProviderRule>? Rule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionStatusConditions
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

/// <summary>FirewallNetworkRuleCollectionStatus defines the observed state of FirewallNetworkRuleCollection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallNetworkRuleCollectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FirewallNetworkRuleCollectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirewallNetworkRuleCollectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FirewallNetworkRuleCollection is the Schema for the FirewallNetworkRuleCollections API. Manages a Network Rule Collection within an Azure Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirewallNetworkRuleCollection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirewallNetworkRuleCollectionSpec>, IStatus<V1beta1FirewallNetworkRuleCollectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirewallNetworkRuleCollection";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "firewallnetworkrulecollections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallNetworkRuleCollectionSpec defines the desired state of FirewallNetworkRuleCollection</summary>
    [JsonPropertyName("spec")]
    public V1beta1FirewallNetworkRuleCollectionSpec Spec { get; set; }

    /// <summary>FirewallNetworkRuleCollectionStatus defines the observed state of FirewallNetworkRuleCollection.</summary>
    [JsonPropertyName("status")]
    public V1beta1FirewallNetworkRuleCollectionStatus? Status { get; set; }
}