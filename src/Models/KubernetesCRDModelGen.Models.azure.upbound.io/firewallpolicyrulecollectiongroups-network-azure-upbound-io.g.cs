using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRuleHttpHeaders
{
    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRuleProtocols
{
    /// <summary>Port number of the protocol. Range is 0-64000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol type. Possible values are Http and Https.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDN tags.</summary>
    [JsonPropertyName("destinationFqdnTags")]
    public IList<string>? DestinationFqdnTags { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination URLs for which policy should hold. Needs Premium SKU for Firewall Policy. Conflicts with destination_fqdns.</summary>
    [JsonPropertyName("destinationUrls")]
    public IList<string>? DestinationUrls { get; set; }

    /// <summary>Specifies a list of HTTP/HTTPS headers to insert. One or more http_headers blocks as defined below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRuleHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRuleProtocols>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Boolean specifying if TLS shall be terminated (true) or not (false). Must be true when using destination_urls. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("terminateTls")]
    public bool? TerminateTls { get; set; }

    /// <summary>Specifies a list of web categories to which access is denied or allowed depending on the value of action above. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollection
{
    /// <summary>The action to take for the application rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this application rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the application rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more application_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollectionRule>? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FirewallPolicy in network to populate firewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FirewallPolicy in network to populate firewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNatRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination IP address (including CIDR).</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Specifies the translated address.</summary>
    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    /// <summary>Specifies the translated FQDN.</summary>
    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    /// <summary>Specifies the translated port.</summary>
    [JsonPropertyName("translatedPort")]
    public double? TranslatedPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNatRuleCollection
{
    /// <summary>The action to take for the NAT rules in this collection. Currently, the only possible value is Dnat.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this NAT rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the NAT rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A nat_rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNatRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNetworkRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination IP groups.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNetworkRuleCollection
{
    /// <summary>The action to take for the network rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the network rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more network_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNetworkRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecForProvider
{
    /// <summary>One or more application_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("applicationRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderApplicationRuleCollection>? ApplicationRuleCollection { get; set; }

    /// <summary>The ID of the Firewall Policy where the Firewall Policy Rule Collection Group should exist. Changing this forces a new Firewall Policy Rule Collection Group to be created.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Reference to a FirewallPolicy in network to populate firewallPolicyId.</summary>
    [JsonPropertyName("firewallPolicyIdRef")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdRef? FirewallPolicyIdRef { get; set; }

    /// <summary>Selector for a FirewallPolicy in network to populate firewallPolicyId.</summary>
    [JsonPropertyName("firewallPolicyIdSelector")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderFirewallPolicyIdSelector? FirewallPolicyIdSelector { get; set; }

    /// <summary>One or more nat_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("natRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNatRuleCollection>? NatRuleCollection { get; set; }

    /// <summary>One or more network_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("networkRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecForProviderNetworkRuleCollection>? NetworkRuleCollection { get; set; }

    /// <summary>The priority of the Firewall Policy Rule Collection Group. The range is 100-65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRuleHttpHeaders
{
    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRuleProtocols
{
    /// <summary>Port number of the protocol. Range is 0-64000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol type. Possible values are Http and Https.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDN tags.</summary>
    [JsonPropertyName("destinationFqdnTags")]
    public IList<string>? DestinationFqdnTags { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination URLs for which policy should hold. Needs Premium SKU for Firewall Policy. Conflicts with destination_fqdns.</summary>
    [JsonPropertyName("destinationUrls")]
    public IList<string>? DestinationUrls { get; set; }

    /// <summary>Specifies a list of HTTP/HTTPS headers to insert. One or more http_headers blocks as defined below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRuleHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRuleProtocols>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Boolean specifying if TLS shall be terminated (true) or not (false). Must be true when using destination_urls. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("terminateTls")]
    public bool? TerminateTls { get; set; }

    /// <summary>Specifies a list of web categories to which access is denied or allowed depending on the value of action above. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollection
{
    /// <summary>The action to take for the application rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this application rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the application rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more application_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNatRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination IP address (including CIDR).</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Specifies the translated address.</summary>
    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    /// <summary>Specifies the translated FQDN.</summary>
    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    /// <summary>Specifies the translated port.</summary>
    [JsonPropertyName("translatedPort")]
    public double? TranslatedPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNatRuleCollection
{
    /// <summary>The action to take for the NAT rules in this collection. Currently, the only possible value is Dnat.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this NAT rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the NAT rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A nat_rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNatRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNetworkRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination IP groups.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNetworkRuleCollection
{
    /// <summary>The action to take for the network rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the network rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more network_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNetworkRuleCollectionRule>? Rule { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecInitProvider
{
    /// <summary>One or more application_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("applicationRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderApplicationRuleCollection>? ApplicationRuleCollection { get; set; }

    /// <summary>One or more nat_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("natRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNatRuleCollection>? NatRuleCollection { get; set; }

    /// <summary>One or more network_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("networkRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecInitProviderNetworkRuleCollection>? NetworkRuleCollection { get; set; }

    /// <summary>The priority of the Firewall Policy Rule Collection Group. The range is 100-65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FirewallPolicyRuleCollectionGroupSpec defines the desired state of FirewallPolicyRuleCollectionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FirewallPolicyRuleCollectionGroupSpecDeletionPolicyEnum>))]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRuleHttpHeaders
{
    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRuleProtocols
{
    /// <summary>Port number of the protocol. Range is 0-64000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol type. Possible values are Http and Https.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDN tags.</summary>
    [JsonPropertyName("destinationFqdnTags")]
    public IList<string>? DestinationFqdnTags { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination URLs for which policy should hold. Needs Premium SKU for Firewall Policy. Conflicts with destination_fqdns.</summary>
    [JsonPropertyName("destinationUrls")]
    public IList<string>? DestinationUrls { get; set; }

    /// <summary>Specifies a list of HTTP/HTTPS headers to insert. One or more http_headers blocks as defined below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRuleHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRuleProtocols>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Boolean specifying if TLS shall be terminated (true) or not (false). Must be true when using destination_urls. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("terminateTls")]
    public bool? TerminateTls { get; set; }

    /// <summary>Specifies a list of web categories to which access is denied or allowed depending on the value of action above. Needs Premium SKU for Firewall Policy.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollection
{
    /// <summary>The action to take for the application rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this application rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the application rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more application_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNatRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination IP address (including CIDR).</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>Specifies the translated address.</summary>
    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    /// <summary>Specifies the translated FQDN.</summary>
    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    /// <summary>Specifies the translated port.</summary>
    [JsonPropertyName("translatedPort")]
    public double? TranslatedPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNatRuleCollection
{
    /// <summary>The action to take for the NAT rules in this collection. Currently, the only possible value is Dnat.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this NAT rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the NAT rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A nat_rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNatRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNetworkRuleCollectionRule
{
    /// <summary>The description which should be used for this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses (including CIDR, IP range and *) or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>Specifies a list of destination IP groups.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of network protocols this rule applies to. Possible values are Any, TCP, UDP, ICMP.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Specifies a list of source IP addresses (including CIDR, IP range and *).</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNetworkRuleCollection
{
    /// <summary>The action to take for the network rules in this collection. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this network rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the network rule collection. The range is 100 - 65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>One or more network_rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNetworkRuleCollectionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusAtProvider
{
    /// <summary>One or more application_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("applicationRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderApplicationRuleCollection>? ApplicationRuleCollection { get; set; }

    /// <summary>The ID of the Firewall Policy where the Firewall Policy Rule Collection Group should exist. Changing this forces a new Firewall Policy Rule Collection Group to be created.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The ID of the Firewall Policy Rule Collection Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more nat_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("natRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNatRuleCollection>? NatRuleCollection { get; set; }

    /// <summary>One or more network_rule_collection blocks as defined below.</summary>
    [JsonPropertyName("networkRuleCollection")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusAtProviderNetworkRuleCollection>? NetworkRuleCollection { get; set; }

    /// <summary>The priority of the Firewall Policy Rule Collection Group. The range is 100-65000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatusConditions
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

/// <summary>FirewallPolicyRuleCollectionGroupStatus defines the observed state of FirewallPolicyRuleCollectionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirewallPolicyRuleCollectionGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FirewallPolicyRuleCollectionGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirewallPolicyRuleCollectionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FirewallPolicyRuleCollectionGroup is the Schema for the FirewallPolicyRuleCollectionGroups API. Manages a Firewall Policy Rule Collection Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirewallPolicyRuleCollectionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirewallPolicyRuleCollectionGroupSpec>, IStatus<V1beta1FirewallPolicyRuleCollectionGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirewallPolicyRuleCollectionGroup";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "firewallpolicyrulecollectiongroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallPolicyRuleCollectionGroupSpec defines the desired state of FirewallPolicyRuleCollectionGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1FirewallPolicyRuleCollectionGroupSpec Spec { get; set; }

    /// <summary>FirewallPolicyRuleCollectionGroupStatus defines the observed state of FirewallPolicyRuleCollectionGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1FirewallPolicyRuleCollectionGroupStatus? Status { get; set; }
}