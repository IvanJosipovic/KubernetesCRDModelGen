using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
#nullable enable
/// <summary>DefaultSecurityGroup is the Schema for the DefaultSecurityGroups API. Manage a default security group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSecurityGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DefaultSecurityGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSecurityGroupList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultsecuritygroups";
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
    public IList<V1beta1DefaultSecurityGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderEgress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderIngress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderVpcIdRefPolicy
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
/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DefaultSecurityGroupSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderVpcIdSelectorPolicy
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
/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProviderVpcIdSelector
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
    public V1beta1DefaultSecurityGroupSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecForProvider
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("egress")]
    public IList<V1beta1DefaultSecurityGroupSpecForProviderEgress>? Egress { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1DefaultSecurityGroupSpecForProviderIngress>? Ingress { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revokeRulesOnDelete")]
    public bool? RevokeRulesOnDelete { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VPC ID. Note that changing the  It will be left in its current state.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1DefaultSecurityGroupSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1DefaultSecurityGroupSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderEgress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderIngress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderVpcIdRefPolicy
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
/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DefaultSecurityGroupSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderVpcIdSelectorPolicy
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
/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProviderVpcIdSelector
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
    public V1beta1DefaultSecurityGroupSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecInitProvider
{
    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("egress")]
    public IList<V1beta1DefaultSecurityGroupSpecInitProviderEgress>? Egress { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1DefaultSecurityGroupSpecInitProviderIngress>? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revokeRulesOnDelete")]
    public bool? RevokeRulesOnDelete { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VPC ID. Note that changing the  It will be left in its current state.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1DefaultSecurityGroupSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1DefaultSecurityGroupSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpecProviderConfigRef
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
public partial class V1beta1DefaultSecurityGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DefaultSecurityGroupSpec defines the desired state of DefaultSecurityGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DefaultSecurityGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DefaultSecurityGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DefaultSecurityGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DefaultSecurityGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupStatusAtProviderEgress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupStatusAtProviderIngress
{
    /// <summary>List of CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Start port (or ICMP type number if protocol is icmp)</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>List of IPv6 CIDR blocks.</summary>
    [JsonPropertyName("ipv6CidrBlocks")]
    public IList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>List of prefix list IDs (for allowing access to VPC endpoints)</summary>
    [JsonPropertyName("prefixListIds")]
    public IList<string>? PrefixListIds { get; set; }

    /// <summary>Protocol. If you select a protocol of "-1" (semantically equivalent to all, which is not a valid value here), you must specify a from_port and to_port equal to 0. If not icmp, tcp, udp, or -1 use the protocol number.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>List of security groups. A group name can be used relative to the default VPC. Otherwise, group ID.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether the security group itself will be added as a source to this egress rule.</summary>
    [JsonPropertyName("self")]
    public bool? Self { get; set; }

    /// <summary>End range port (or ICMP code if protocol is icmp).</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupStatusAtProvider
{
    /// <summary>ARN of the security group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("egress")]
    public IList<V1beta1DefaultSecurityGroupStatusAtProviderEgress>? Egress { get; set; }

    /// <summary>ID of the security group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block. Detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1DefaultSecurityGroupStatusAtProviderIngress>? Ingress { get; set; }

    /// <summary>Name of the security group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner ID.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revokeRulesOnDelete")]
    public bool? RevokeRulesOnDelete { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>VPC ID. Note that changing the  It will be left in its current state.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupStatusConditions
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
/// <summary>DefaultSecurityGroupStatus defines the observed state of DefaultSecurityGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSecurityGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DefaultSecurityGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DefaultSecurityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DefaultSecurityGroup is the Schema for the DefaultSecurityGroups API. Manage a default security group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSecurityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DefaultSecurityGroupSpec>, IStatus<V1beta1DefaultSecurityGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSecurityGroup";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultsecuritygroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DefaultSecurityGroupSpec defines the desired state of DefaultSecurityGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1DefaultSecurityGroupSpec Spec { get; set; }

    /// <summary>DefaultSecurityGroupStatus defines the observed state of DefaultSecurityGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1DefaultSecurityGroupStatus? Status { get; set; }
}
#nullable disable
