using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1SecurityGroupRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecForProvider
{
    /// <summary>List of CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is "icmp" or "icmpv6").</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>References to ManagedPrefixList in ec2 to populate prefixListIds.</summary>
    [JsonPropertyName("prefixListIdRefs")]
    public IList<V1beta1SecurityGroupRuleSpecForProviderPrefixListIdRefs>? PrefixListIdRefs { get; set; }

    /// <summary>Selector for a list of ManagedPrefixList in ec2 to populate prefixListIds.</summary>
    [JsonPropertyName("prefixListIdSelector")]
    public V1beta1SecurityGroupRuleSpecForProviderPrefixListIdSelector? PrefixListIdSelector { get; set; }

    /// <summary>List of Prefix List IDs.</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If not icmp, icmpv6, tcp, udp, or all use the protocol number</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Security group to apply this rule to.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdRef")]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdRef? SecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1SecurityGroupRuleSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this ingress rule. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or source_security_group_id.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>Security group id to allow access to/from, depending on the type. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or self.</summary>
    [JsonPropertyName("sourceSecurityGroupId")]
    public string? SourceSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate sourceSecurityGroupId.</summary>
    [JsonPropertyName("sourceSecurityGroupIdRef")]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdRef? SourceSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate sourceSecurityGroupId.</summary>
    [JsonPropertyName("sourceSecurityGroupIdSelector")]
    public V1beta1SecurityGroupRuleSpecForProviderSourceSecurityGroupIdSelector? SourceSecurityGroupIdSelector { get; set; }

    /// <summary>End port (or ICMP code if protocol is "icmp").</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }

    /// <summary>Type of rule being created. Valid options are ingress (inbound) or egress (outbound).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecInitProvider
{
    /// <summary>List of CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is "icmp" or "icmpv6").</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>References to ManagedPrefixList in ec2 to populate prefixListIds.</summary>
    [JsonPropertyName("prefixListIdRefs")]
    public IList<V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdRefs>? PrefixListIdRefs { get; set; }

    /// <summary>Selector for a list of ManagedPrefixList in ec2 to populate prefixListIds.</summary>
    [JsonPropertyName("prefixListIdSelector")]
    public V1beta1SecurityGroupRuleSpecInitProviderPrefixListIdSelector? PrefixListIdSelector { get; set; }

    /// <summary>List of Prefix List IDs.</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If not icmp, icmpv6, tcp, udp, or all use the protocol number</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Security group to apply this rule to.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdRef")]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdRef? SecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate securityGroupId.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1SecurityGroupRuleSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this ingress rule. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or source_security_group_id.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>Security group id to allow access to/from, depending on the type. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or self.</summary>
    [JsonPropertyName("sourceSecurityGroupId")]
    public string? SourceSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate sourceSecurityGroupId.</summary>
    [JsonPropertyName("sourceSecurityGroupIdRef")]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdRef? SourceSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate sourceSecurityGroupId.</summary>
    [JsonPropertyName("sourceSecurityGroupIdSelector")]
    public V1beta1SecurityGroupRuleSpecInitProviderSourceSecurityGroupIdSelector? SourceSecurityGroupIdSelector { get; set; }

    /// <summary>End port (or ICMP code if protocol is "icmp").</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }

    /// <summary>Type of rule being created. Valid options are ingress (inbound) or egress (outbound).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecManagementPoliciesEnum
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

public enum V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SecurityGroupRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SecurityGroupRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupRuleSpecDeletionPolicyEnum>))]
    public V1beta1SecurityGroupRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecurityGroupRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecurityGroupRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SecurityGroupRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityGroupRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SecurityGroupRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityGroupRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SecurityGroupRuleStatusAtProvider
{
    /// <summary>List of CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is "icmp" or "icmpv6").</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>ID of the security group rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of IPv6 CIDR blocks. Cannot be specified with source_security_group_id or self.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of Prefix List IDs.</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If not icmp, icmpv6, tcp, udp, or all use the protocol number</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Security group to apply this rule to.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>If the aws_security_group_rule resource has a single source or destination then this is the AWS Security Group Rule resource ID. Otherwise it is empty.</summary>
    [JsonPropertyName("securityGroupRuleId")]
    public string? SecurityGroupRuleId { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this ingress rule. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or source_security_group_id.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>Security group id to allow access to/from, depending on the type. Cannot be specified with cidr_blocks, ipv6_cidr_blocks, or self.</summary>
    [JsonPropertyName("sourceSecurityGroupId")]
    public string? SourceSecurityGroupId { get; set; }

    /// <summary>End port (or ICMP code if protocol is "icmp").</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }

    /// <summary>Type of rule being created. Valid options are ingress (inbound) or egress (outbound).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SecurityGroupRuleStatusConditions
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

public partial class V1beta1SecurityGroupRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SecurityGroupRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecurityGroupRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityGroupRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityGroupRuleSpec>, IStatus<V1beta1SecurityGroupRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityGroupRule";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "securitygrouprules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityGroupRuleSpec defines the desired state of SecurityGroupRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecurityGroupRuleSpec Spec { get; set; }

    /// <summary>SecurityGroupRuleStatus defines the observed state of SecurityGroupRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecurityGroupRuleStatus? Status { get; set; }
}