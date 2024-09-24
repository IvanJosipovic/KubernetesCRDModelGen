using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
public enum V1beta1NamespaceNetworkRuleSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRules
{
    /// <summary>Should the ServiceBus Namespace Network Rule Set ignore missing Virtual Network Service Endpoint option in the Subnet? Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>The Subnet ID which should be able to access this ServiceBus Namespace.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRulesSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecForProvider
{
    /// <summary>Specifies the default action for the ServiceBus Namespace Network Rule Set. Possible values are Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the ServiceBus Namespace.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>Specifies the ServiceBus Namespace ID to which to attach the ServiceBus Namespace Network Rule Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1NamespaceNetworkRuleSetSpecForProviderNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>One or more network_rules blocks as defined below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1NamespaceNetworkRuleSetSpecForProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Whether to allow traffic over public network. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>If True, then Azure Services that are known and trusted for this resource type are allowed to bypass firewall configuration. See Trusted Microsoft Services</summary>
    [JsonPropertyName("trustedServicesAllowed")]
    public bool? TrustedServicesAllowed { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRules
{
    /// <summary>Should the ServiceBus Namespace Network Rule Set ignore missing Virtual Network Service Endpoint option in the Subnet? Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>The Subnet ID which should be able to access this ServiceBus Namespace.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRulesSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecInitProvider
{
    /// <summary>Specifies the default action for the ServiceBus Namespace Network Rule Set. Possible values are Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the ServiceBus Namespace.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>Specifies the ServiceBus Namespace ID to which to attach the ServiceBus Namespace Network Rule Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProviderNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>One or more network_rules blocks as defined below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1NamespaceNetworkRuleSetSpecInitProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Whether to allow traffic over public network. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>If True, then Azure Services that are known and trusted for this resource type are allowed to bypass firewall configuration. See Trusted Microsoft Services</summary>
    [JsonPropertyName("trustedServicesAllowed")]
    public bool? TrustedServicesAllowed { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecManagementPoliciesEnum
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

public enum V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NamespaceNetworkRuleSetSpec defines the desired state of NamespaceNetworkRuleSet</summary>
public partial class V1beta1NamespaceNetworkRuleSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespaceNetworkRuleSetSpecDeletionPolicyEnum>))]
    public V1beta1NamespaceNetworkRuleSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NamespaceNetworkRuleSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NamespaceNetworkRuleSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NamespaceNetworkRuleSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NamespaceNetworkRuleSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NamespaceNetworkRuleSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NamespaceNetworkRuleSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1NamespaceNetworkRuleSetStatusAtProviderNetworkRules
{
    /// <summary>Should the ServiceBus Namespace Network Rule Set ignore missing Virtual Network Service Endpoint option in the Subnet? Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>The Subnet ID which should be able to access this ServiceBus Namespace.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
public partial class V1beta1NamespaceNetworkRuleSetStatusAtProvider
{
    /// <summary>Specifies the default action for the ServiceBus Namespace Network Rule Set. Possible values are Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>The ID of the ServiceBus Namespace Network Rule Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the ServiceBus Namespace.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>Specifies the ServiceBus Namespace ID to which to attach the ServiceBus Namespace Network Rule Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>One or more network_rules blocks as defined below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1NamespaceNetworkRuleSetStatusAtProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Whether to allow traffic over public network. Possible values are true and false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>If True, then Azure Services that are known and trusted for this resource type are allowed to bypass firewall configuration. See Trusted Microsoft Services</summary>
    [JsonPropertyName("trustedServicesAllowed")]
    public bool? TrustedServicesAllowed { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1NamespaceNetworkRuleSetStatusConditions
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

/// <summary>NamespaceNetworkRuleSetStatus defines the observed state of NamespaceNetworkRuleSet.</summary>
public partial class V1beta1NamespaceNetworkRuleSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NamespaceNetworkRuleSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NamespaceNetworkRuleSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>NamespaceNetworkRuleSet is the Schema for the NamespaceNetworkRuleSets API. Manages a ServiceBus Namespace Network Rule Set.</summary>
public partial class V1beta1NamespaceNetworkRuleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NamespaceNetworkRuleSetSpec>, IStatus<V1beta1NamespaceNetworkRuleSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespaceNetworkRuleSet";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "namespacenetworkrulesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NamespaceNetworkRuleSetSpec defines the desired state of NamespaceNetworkRuleSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1NamespaceNetworkRuleSetSpec Spec { get; set; }

    /// <summary>NamespaceNetworkRuleSetStatus defines the observed state of NamespaceNetworkRuleSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1NamespaceNetworkRuleSetStatus? Status { get; set; }
}