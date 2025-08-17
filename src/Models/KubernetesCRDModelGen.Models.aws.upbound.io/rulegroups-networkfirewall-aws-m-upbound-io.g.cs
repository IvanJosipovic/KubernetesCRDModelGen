using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.aws.m.upbound.io;
#nullable enable
/// <summary>RuleGroup is the Schema for the RuleGroups API. Provides an AWS Network Firewall Rule Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RuleGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RuleGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RuleGroupList";
    public const string KubeGroup = "networkfirewall.aws.m.upbound.io";
    public const string KubePluralName = "rulegroups";
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
    public IList<V1beta1RuleGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector
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
    public V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnRef")]
    public V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef? ReferenceArnRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnSelector")]
    public V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector? ReferenceArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupReferenceSets
{
    /// <summary></summary>
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection. See Snort General Rule Options or Suricata Rule Options for more details.</summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>Set of flags to look for in a packet. This setting can only specify values that are also specified in masks. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>Set of flags to consider in the inspection. To inspect all flags, leave this empty. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol's assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition's match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta1RuleGroupSpecForProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta1RuleGroupSpecForProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta1RuleGroupSpecForProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProvider
{
    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RuleGroupSpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta1RuleGroupSpecForProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector
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
    public V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnRef")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef? ReferenceArnRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnSelector")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector? ReferenceArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSets
{
    /// <summary></summary>
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection. See Snort General Rule Options or Suricata Rule Options for more details.</summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>Set of flags to look for in a packet. This setting can only specify values that are also specified in masks. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>Set of flags to consider in the inspection. To inspect all flags, leave this empty. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol's assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition's match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta1RuleGroupSpecInitProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProvider
{
    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RuleGroupSpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta1RuleGroupSpecInitProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RuleGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RuleGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RuleGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RuleGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you're using a key that's managed by another account. If you're using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSets
{
    /// <summary></summary>
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection. See Snort General Rule Options or Suricata Rule Options for more details.</summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>Set of flags to look for in a packet. This setting can only specify values that are also specified in masks. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>Set of flags to consider in the inspection. To inspect all flags, leave this empty. Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.</summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol's assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition's match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta1RuleGroupStatusAtProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) that identifies the rule group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RuleGroupStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) that identifies the rule group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta1RuleGroupStatusAtProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A string token used when updating the rule group.</summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusConditions
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
#nullable disable

#nullable enable
/// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RuleGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RuleGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RuleGroup is the Schema for the RuleGroups API. Provides an AWS Network Firewall Rule Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RuleGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RuleGroupSpec>, IStatus<V1beta1RuleGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RuleGroup";
    public const string KubeGroup = "networkfirewall.aws.m.upbound.io";
    public const string KubePluralName = "rulegroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1RuleGroupSpec Spec { get; set; }

    /// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1RuleGroupStatus? Status { get; set; }
}
#nullable disable
