using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1SecurityGroupIngressRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate prefixListId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate prefixListId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityGroupIngressRuleSpecForProvider
{
    /// <summary>The source IPv4 CIDR range.</summary>
    [JsonPropertyName("cidrIpv4")]
    public string? CidrIpv4 { get; set; }

    /// <summary>The source IPv6 CIDR range.</summary>
    [JsonPropertyName("cidrIpv6")]
    public string? CidrIpv6 { get; set; }

    /// <summary>The security group rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The IP protocol name or number. Use -1 to specify all protocols. Note that if ip_protocol is set to -1, it translates to all protocols, all port ranges, and from_port and to_port values should not be defined.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The ID of the source prefix list.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate prefixListId.</summary>
    [JsonPropertyName("prefixListIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdRef? PrefixListIdRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate prefixListId.</summary>
    [JsonPropertyName("prefixListIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderPrefixListIdSelector? PrefixListIdSelector { get; set; }

    /// <summary>The source security group that is referenced in the rule.</summary>
    [JsonPropertyName("referencedSecurityGroupId")]
    public string? ReferencedSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
    [JsonPropertyName("referencedSecurityGroupIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdRef? ReferencedSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
    [JsonPropertyName("referencedSecurityGroupIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderReferencedSecurityGroupIdSelector? ReferencedSecurityGroupIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ID of the security group.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdRef? SecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate prefixListId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate prefixListId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecInitProvider
{
    /// <summary>The source IPv4 CIDR range.</summary>
    [JsonPropertyName("cidrIpv4")]
    public string? CidrIpv4 { get; set; }

    /// <summary>The source IPv6 CIDR range.</summary>
    [JsonPropertyName("cidrIpv6")]
    public string? CidrIpv6 { get; set; }

    /// <summary>The security group rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The IP protocol name or number. Use -1 to specify all protocols. Note that if ip_protocol is set to -1, it translates to all protocols, all port ranges, and from_port and to_port values should not be defined.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The ID of the source prefix list.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate prefixListId.</summary>
    [JsonPropertyName("prefixListIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdRef? PrefixListIdRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate prefixListId.</summary>
    [JsonPropertyName("prefixListIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderPrefixListIdSelector? PrefixListIdSelector { get; set; }

    /// <summary>The source security group that is referenced in the rule.</summary>
    [JsonPropertyName("referencedSecurityGroupId")]
    public string? ReferencedSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
    [JsonPropertyName("referencedSecurityGroupIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdRef? ReferencedSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate referencedSecurityGroupId.</summary>
    [JsonPropertyName("referencedSecurityGroupIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderReferencedSecurityGroupIdSelector? ReferencedSecurityGroupIdSelector { get; set; }

    /// <summary>The ID of the security group.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdRef")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdRef? SecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1SecurityGroupIngressRuleSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecManagementPoliciesEnum
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

public enum V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SecurityGroupIngressRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SecurityGroupIngressRuleSpec defines the desired state of SecurityGroupIngressRule</summary>
public partial class V1beta1SecurityGroupIngressRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupIngressRuleSpecDeletionPolicyEnum>))]
    public V1beta1SecurityGroupIngressRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecurityGroupIngressRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecurityGroupIngressRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SecurityGroupIngressRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityGroupIngressRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SecurityGroupIngressRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityGroupIngressRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecurityGroupIngressRuleStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the security group rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The source IPv4 CIDR range.</summary>
    [JsonPropertyName("cidrIpv4")]
    public string? CidrIpv4 { get; set; }

    /// <summary>The source IPv6 CIDR range.</summary>
    [JsonPropertyName("cidrIpv6")]
    public string? CidrIpv6 { get; set; }

    /// <summary>The security group rule description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IP protocol name or number. Use -1 to specify all protocols. Note that if ip_protocol is set to -1, it translates to all protocols, all port ranges, and from_port and to_port values should not be defined.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The ID of the source prefix list.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>The source security group that is referenced in the rule.</summary>
    [JsonPropertyName("referencedSecurityGroupId")]
    public string? ReferencedSecurityGroupId { get; set; }

    /// <summary>The ID of the security group.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The ID of the security group rule.</summary>
    [JsonPropertyName("securityGroupRuleId")]
    public string? SecurityGroupRuleId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1SecurityGroupIngressRuleStatusConditions
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

/// <summary>SecurityGroupIngressRuleStatus defines the observed state of SecurityGroupIngressRule.</summary>
public partial class V1beta1SecurityGroupIngressRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SecurityGroupIngressRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecurityGroupIngressRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>SecurityGroupIngressRule is the Schema for the SecurityGroupIngressRules API. Provides a VPC security group ingress rule resource.</summary>
public partial class V1beta1SecurityGroupIngressRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityGroupIngressRuleSpec>, IStatus<V1beta1SecurityGroupIngressRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityGroupIngressRule";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "securitygroupingressrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityGroupIngressRuleSpec defines the desired state of SecurityGroupIngressRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecurityGroupIngressRuleSpec Spec { get; set; }

    /// <summary>SecurityGroupIngressRuleStatus defines the observed state of SecurityGroupIngressRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecurityGroupIngressRuleStatus? Status { get; set; }
}