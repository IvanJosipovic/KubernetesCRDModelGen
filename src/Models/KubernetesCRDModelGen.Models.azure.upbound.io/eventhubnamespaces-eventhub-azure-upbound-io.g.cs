using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventhub.azure.upbound.io;
public enum V1beta1EventHubNamespaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1EventHubNamespaceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this EventHub namespace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Hub Namespace. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

public enum V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRule
{
    /// <summary>Are missing virtual network service endpoints ignored?</summary>
    [JsonPropertyName("ignoreMissingVirtualNetworkServiceEndpoint")]
    public bool? IgnoreMissingVirtualNetworkServiceEndpoint { get; set; }

    /// <summary>The id of the subnet to match on.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelector? SubnetIdSelector { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderNetworkRulesets
{
    /// <summary>The default action to take when a rule is not matched. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsIpRule>? IpRule { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Whether Trusted Microsoft Services are allowed to bypass firewall.</summary>
    [JsonPropertyName("trustedServiceAccessEnabled")]
    public bool? TrustedServiceAccessEnabled { get; set; }

    /// <summary>One or more virtual_network_rule blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1EventHubNamespaceSpecForProviderNetworkRulesetsVirtualNetworkRule>? VirtualNetworkRule { get; set; }
}

public enum V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecForProvider
{
    /// <summary>Is Auto Inflate enabled for the EventHub Namespace?</summary>
    [JsonPropertyName("autoInflateEnabled")]
    public bool? AutoInflateEnabled { get; set; }

    /// <summary>Specifies the Capacity / Throughput Units for a Standard SKU namespace. Default capacity has a maximum of 2, but can be increased in blocks of 2 on a committed purchase basis. Defaults to 1.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Specifies the ID of the EventHub Dedicated Cluster where this Namespace should created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dedicatedClusterId")]
    public string? DedicatedClusterId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1EventHubNamespaceSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Is SAS authentication enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from 1 - 20.</summary>
    [JsonPropertyName("maximumThroughputUnits")]
    public double? MaximumThroughputUnits { get; set; }

    /// <summary>The minimum supported TLS version for this EventHub Namespace. Valid values are: 1.0, 1.1 and 1.2. The current default minimum TLS version is 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>A network_rulesets block as defined below.</summary>
    [JsonPropertyName("networkRulesets")]
    public IList<V1beta1EventHubNamespaceSpecForProviderNetworkRulesets>? NetworkRulesets { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the namespace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1EventHubNamespaceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Defines which tier to use. Valid options are Basic, Standard, and Premium. Please note that setting this field to Premium will force the creation of a new resource.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if the EventHub Namespace should be Zone Redundant (created across Availability Zones). Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this EventHub namespace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Hub Namespace. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

public enum V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRule
{
    /// <summary>Are missing virtual network service endpoints ignored?</summary>
    [JsonPropertyName("ignoreMissingVirtualNetworkServiceEndpoint")]
    public bool? IgnoreMissingVirtualNetworkServiceEndpoint { get; set; }

    /// <summary>The id of the subnet to match on.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRuleSubnetIdSelector? SubnetIdSelector { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProviderNetworkRulesets
{
    /// <summary>The default action to take when a rule is not matched. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsIpRule>? IpRule { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Whether Trusted Microsoft Services are allowed to bypass firewall.</summary>
    [JsonPropertyName("trustedServiceAccessEnabled")]
    public bool? TrustedServiceAccessEnabled { get; set; }

    /// <summary>One or more virtual_network_rule blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesetsVirtualNetworkRule>? VirtualNetworkRule { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecInitProvider
{
    /// <summary>Is Auto Inflate enabled for the EventHub Namespace?</summary>
    [JsonPropertyName("autoInflateEnabled")]
    public bool? AutoInflateEnabled { get; set; }

    /// <summary>Specifies the Capacity / Throughput Units for a Standard SKU namespace. Default capacity has a maximum of 2, but can be increased in blocks of 2 on a committed purchase basis. Defaults to 1.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Specifies the ID of the EventHub Dedicated Cluster where this Namespace should created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dedicatedClusterId")]
    public string? DedicatedClusterId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1EventHubNamespaceSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Is SAS authentication enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from 1 - 20.</summary>
    [JsonPropertyName("maximumThroughputUnits")]
    public double? MaximumThroughputUnits { get; set; }

    /// <summary>The minimum supported TLS version for this EventHub Namespace. Valid values are: 1.0, 1.1 and 1.2. The current default minimum TLS version is 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>A network_rulesets block as defined below.</summary>
    [JsonPropertyName("networkRulesets")]
    public IList<V1beta1EventHubNamespaceSpecInitProviderNetworkRulesets>? NetworkRulesets { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Defines which tier to use. Valid options are Basic, Standard, and Premium. Please note that setting this field to Premium will force the creation of a new resource.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if the EventHub Namespace should be Zone Redundant (created across Availability Zones). Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

public enum V1beta1EventHubNamespaceSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1EventHubNamespaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1EventHubNamespaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventHubNamespaceSpecDeletionPolicyEnum>))]
    public V1beta1EventHubNamespaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventHubNamespaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventHubNamespaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventHubNamespaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventHubNamespaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EventHubNamespaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventHubNamespaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this EventHub namespace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Hub Namespace. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusAtProviderNetworkRulesetsIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusAtProviderNetworkRulesetsVirtualNetworkRule
{
    /// <summary>Are missing virtual network service endpoints ignored?</summary>
    [JsonPropertyName("ignoreMissingVirtualNetworkServiceEndpoint")]
    public bool? IgnoreMissingVirtualNetworkServiceEndpoint { get; set; }

    /// <summary>The id of the subnet to match on.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusAtProviderNetworkRulesets
{
    /// <summary>The default action to take when a rule is not matched. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta1EventHubNamespaceStatusAtProviderNetworkRulesetsIpRule>? IpRule { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Whether Trusted Microsoft Services are allowed to bypass firewall.</summary>
    [JsonPropertyName("trustedServiceAccessEnabled")]
    public bool? TrustedServiceAccessEnabled { get; set; }

    /// <summary>One or more virtual_network_rule blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1EventHubNamespaceStatusAtProviderNetworkRulesetsVirtualNetworkRule>? VirtualNetworkRule { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusAtProvider
{
    /// <summary>Is Auto Inflate enabled for the EventHub Namespace?</summary>
    [JsonPropertyName("autoInflateEnabled")]
    public bool? AutoInflateEnabled { get; set; }

    /// <summary>Specifies the Capacity / Throughput Units for a Standard SKU namespace. Default capacity has a maximum of 2, but can be increased in blocks of 2 on a committed purchase basis. Defaults to 1.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Specifies the ID of the EventHub Dedicated Cluster where this Namespace should created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dedicatedClusterId")]
    public string? DedicatedClusterId { get; set; }

    /// <summary>The EventHub Namespace ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1EventHubNamespaceStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Is SAS authentication enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the maximum number of throughput units when Auto Inflate is Enabled. Valid values range from 1 - 20.</summary>
    [JsonPropertyName("maximumThroughputUnits")]
    public double? MaximumThroughputUnits { get; set; }

    /// <summary>The minimum supported TLS version for this EventHub Namespace. Valid values are: 1.0, 1.1 and 1.2. The current default minimum TLS version is 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>A network_rulesets block as defined below.</summary>
    [JsonPropertyName("networkRulesets")]
    public IList<V1beta1EventHubNamespaceStatusAtProviderNetworkRulesets>? NetworkRulesets { get; set; }

    /// <summary>Is public network access enabled for the EventHub Namespace? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the namespace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Defines which tier to use. Valid options are Basic, Standard, and Premium. Please note that setting this field to Premium will force the creation of a new resource.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if the EventHub Namespace should be Zone Redundant (created across Availability Zones). Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

public partial class V1beta1EventHubNamespaceStatusConditions
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

public partial class V1beta1EventHubNamespaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventHubNamespaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventHubNamespaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventHubNamespace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventHubNamespaceSpec>, IStatus<V1beta1EventHubNamespaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventHubNamespace";
    public const string KubeGroup = "eventhub.azure.upbound.io";
    public const string KubePluralName = "eventhubnamespaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventHubNamespaceSpec defines the desired state of EventHubNamespace</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventHubNamespaceSpec Spec { get; set; }

    /// <summary>EventHubNamespaceStatus defines the observed state of EventHubNamespace.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventHubNamespaceStatus? Status { get; set; }
}