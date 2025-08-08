using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecForProviderNetworkAclIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkACL in ec2 to populate networkAclId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecForProviderNetworkAclIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkACLRuleSpecForProviderNetworkAclIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecForProviderNetworkAclIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkACL in ec2 to populate networkAclId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecForProviderNetworkAclIdSelector
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
    public V1beta1NetworkACLRuleSpecForProviderNetworkAclIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecForProvider
{
    /// <summary>The network range to allow or deny, in CIDR notation (for example 172.16.0.0/24 ).</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Indicates whether this is an egress rule (rule is applied to traffic leaving the subnet). Default false.</summary>
    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    /// <summary>The from port to match.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>ICMP protocol: The ICMP code. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpCode")]
    public double? IcmpCode { get; set; }

    /// <summary>ICMP protocol: The ICMP type. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpType")]
    public double? IcmpType { get; set; }

    /// <summary>The IPv6 CIDR block to allow or deny.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>The ID of the network ACL.</summary>
    [JsonPropertyName("networkAclId")]
    public string? NetworkAclId { get; set; }

    /// <summary>Reference to a NetworkACL in ec2 to populate networkAclId.</summary>
    [JsonPropertyName("networkAclIdRef")]
    public V1beta1NetworkACLRuleSpecForProviderNetworkAclIdRef? NetworkAclIdRef { get; set; }

    /// <summary>Selector for a NetworkACL in ec2 to populate networkAclId.</summary>
    [JsonPropertyName("networkAclIdSelector")]
    public V1beta1NetworkACLRuleSpecForProviderNetworkAclIdSelector? NetworkAclIdSelector { get; set; }

    /// <summary>The protocol. A value of -1 means all protocols.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Indicates whether to allow or deny the traffic that matches the rule. Accepted values: allow | deny</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>The rule number for the entry (for example, 100). ACL entries are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>The to port to match.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkACL in ec2 to populate networkAclId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkACL in ec2 to populate networkAclId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdSelector
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
    public V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecInitProvider
{
    /// <summary>The network range to allow or deny, in CIDR notation (for example 172.16.0.0/24 ).</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Indicates whether this is an egress rule (rule is applied to traffic leaving the subnet). Default false.</summary>
    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    /// <summary>The from port to match.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>ICMP protocol: The ICMP code. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpCode")]
    public double? IcmpCode { get; set; }

    /// <summary>ICMP protocol: The ICMP type. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpType")]
    public double? IcmpType { get; set; }

    /// <summary>The IPv6 CIDR block to allow or deny.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>The ID of the network ACL.</summary>
    [JsonPropertyName("networkAclId")]
    public string? NetworkAclId { get; set; }

    /// <summary>Reference to a NetworkACL in ec2 to populate networkAclId.</summary>
    [JsonPropertyName("networkAclIdRef")]
    public V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdRef? NetworkAclIdRef { get; set; }

    /// <summary>Selector for a NetworkACL in ec2 to populate networkAclId.</summary>
    [JsonPropertyName("networkAclIdSelector")]
    public V1beta1NetworkACLRuleSpecInitProviderNetworkAclIdSelector? NetworkAclIdSelector { get; set; }

    /// <summary>The protocol. A value of -1 means all protocols.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Indicates whether to allow or deny the traffic that matches the rule. Accepted values: allow | deny</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>The rule number for the entry (for example, 100). ACL entries are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>The to port to match.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpecProviderConfigRef
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
public partial class V1beta1NetworkACLRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NetworkACLRuleSpec defines the desired state of NetworkACLRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NetworkACLRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NetworkACLRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkACLRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkACLRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleStatusAtProvider
{
    /// <summary>The network range to allow or deny, in CIDR notation (for example 172.16.0.0/24 ).</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Indicates whether this is an egress rule (rule is applied to traffic leaving the subnet). Default false.</summary>
    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    /// <summary>The from port to match.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>ICMP protocol: The ICMP code. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpCode")]
    public double? IcmpCode { get; set; }

    /// <summary>ICMP protocol: The ICMP type. Required if specifying ICMP for the protocolE.g., -1</summary>
    [JsonPropertyName("icmpType")]
    public double? IcmpType { get; set; }

    /// <summary>The ID of the network ACL Rule</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IPv6 CIDR block to allow or deny.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>The ID of the network ACL.</summary>
    [JsonPropertyName("networkAclId")]
    public string? NetworkAclId { get; set; }

    /// <summary>The protocol. A value of -1 means all protocols.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Indicates whether to allow or deny the traffic that matches the rule. Accepted values: allow | deny</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>The rule number for the entry (for example, 100). ACL entries are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>The to port to match.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleStatusConditions
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

/// <summary>NetworkACLRuleStatus defines the observed state of NetworkACLRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkACLRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkACLRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkACLRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NetworkACLRule is the Schema for the NetworkACLRules API. Provides an network ACL Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkACLRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkACLRuleSpec>, IStatus<V1beta1NetworkACLRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkACLRule";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkaclrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkACLRuleSpec defines the desired state of NetworkACLRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1NetworkACLRuleSpec Spec { get; set; }

    /// <summary>NetworkACLRuleStatus defines the observed state of NetworkACLRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkACLRuleStatus? Status { get; set; }
}

/// <summary>NetworkACLRule is the Schema for the NetworkACLRules API. Provides an network ACL Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkACLRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkACLRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkACLRuleList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkaclrules";
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
    public IList<V1beta1NetworkACLRule> Items { get; set; }
}