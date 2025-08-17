using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
#nullable enable
/// <summary>VPC is the Schema for the VPCs API. Provides a VPC resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPC>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "vpcs";
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
    public IList<V1beta1VPC> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecForProviderIpv4IpamPoolIdRefPolicy
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
/// <summary>Reference to a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecForProviderIpv4IpamPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCSpecForProviderIpv4IpamPoolIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecForProviderIpv4IpamPoolIdSelectorPolicy
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
/// <summary>Selector for a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecForProviderIpv4IpamPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCSpecForProviderIpv4IpamPoolIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecForProvider
{
    /// <summary>Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC. You cannot specify the range of IP addresses, or the size of the CIDR block. Default is false. Conflicts with ipv6_ipam_pool_id</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>The IPv4 CIDR block for the VPC. CIDR can be explicitly set or it can be derived from IPAM using ipv4_netmask_length.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary>A boolean flag to enable/disable DNS support in the VPC. Defaults to true.</summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary>Indicates whether Network Address Usage metrics are enabled for your VPC. Defaults to false.</summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>A tenancy option for instances launched into the VPC. Default is default, which ensures that EC2 instances launched in this VPC use the EC2 instance tenancy attribute specified when the EC2 instance is launched. The only other option is dedicated, which ensures that EC2 instances launched in this VPC are run on dedicated tenancy instances regardless of the tenancy attribute specified at launch. This has a dedicated per region fee of $2 per hour, plus an hourly per instance usage fee.</summary>
    [JsonPropertyName("instanceTenancy")]
    public string? InstanceTenancy { get; set; }

    /// <summary>The ID of an IPv4 IPAM pool you want to use for allocating this VPC's CIDR. IPAM is a VPC feature that you can use to automate your IP address management workflows including assigning, tracking, troubleshooting, and auditing IP addresses across AWS Regions and accounts. Using IPAM you can monitor IP address usage throughout your AWS Organization.</summary>
    [JsonPropertyName("ipv4IpamPoolId")]
    public string? Ipv4IpamPoolId { get; set; }

    /// <summary>Reference to a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
    [JsonPropertyName("ipv4IpamPoolIdRef")]
    public V1beta1VPCSpecForProviderIpv4IpamPoolIdRef? Ipv4IpamPoolIdRef { get; set; }

    /// <summary>Selector for a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
    [JsonPropertyName("ipv4IpamPoolIdSelector")]
    public V1beta1VPCSpecForProviderIpv4IpamPoolIdSelector? Ipv4IpamPoolIdSelector { get; set; }

    /// <summary>The netmask length of the IPv4 CIDR you want to allocate to this VPC. Requires specifying a ipv4_ipam_pool_id.</summary>
    [JsonPropertyName("ipv4NetmaskLength")]
    public double? Ipv4NetmaskLength { get; set; }

    /// <summary>IPv6 CIDR block to request from an IPAM Pool. Can be set explicitly or derived from IPAM using ipv6_netmask_length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>By default when an IPv6 CIDR is assigned to a VPC a default ipv6_cidr_block_network_border_group will be set to the region of the VPC. This can be changed to restrict advertisement of public addresses to specific Network Border Groups such as LocalZones.</summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary>IPAM Pool ID for a IPv6 pool. Conflicts with assign_generated_ipv6_cidr_block.</summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary>Netmask length to request from IPAM Pool. Conflicts with ipv6_cidr_block. This can be omitted if IPAM pool as a allocation_default_netmask_length set. Valid values are from 44 to 60 in increments of 4.</summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecInitProviderIpv4IpamPoolIdRefPolicy
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
/// <summary>Reference to a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecInitProviderIpv4IpamPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCSpecInitProviderIpv4IpamPoolIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecInitProviderIpv4IpamPoolIdSelectorPolicy
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
/// <summary>Selector for a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecInitProviderIpv4IpamPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCSpecInitProviderIpv4IpamPoolIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecInitProvider
{
    /// <summary>Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC. You cannot specify the range of IP addresses, or the size of the CIDR block. Default is false. Conflicts with ipv6_ipam_pool_id</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>The IPv4 CIDR block for the VPC. CIDR can be explicitly set or it can be derived from IPAM using ipv4_netmask_length.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary>A boolean flag to enable/disable DNS support in the VPC. Defaults to true.</summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary>Indicates whether Network Address Usage metrics are enabled for your VPC. Defaults to false.</summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>A tenancy option for instances launched into the VPC. Default is default, which ensures that EC2 instances launched in this VPC use the EC2 instance tenancy attribute specified when the EC2 instance is launched. The only other option is dedicated, which ensures that EC2 instances launched in this VPC are run on dedicated tenancy instances regardless of the tenancy attribute specified at launch. This has a dedicated per region fee of $2 per hour, plus an hourly per instance usage fee.</summary>
    [JsonPropertyName("instanceTenancy")]
    public string? InstanceTenancy { get; set; }

    /// <summary>The ID of an IPv4 IPAM pool you want to use for allocating this VPC's CIDR. IPAM is a VPC feature that you can use to automate your IP address management workflows including assigning, tracking, troubleshooting, and auditing IP addresses across AWS Regions and accounts. Using IPAM you can monitor IP address usage throughout your AWS Organization.</summary>
    [JsonPropertyName("ipv4IpamPoolId")]
    public string? Ipv4IpamPoolId { get; set; }

    /// <summary>Reference to a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
    [JsonPropertyName("ipv4IpamPoolIdRef")]
    public V1beta1VPCSpecInitProviderIpv4IpamPoolIdRef? Ipv4IpamPoolIdRef { get; set; }

    /// <summary>Selector for a VPCIpamPool in ec2 to populate ipv4IpamPoolId.</summary>
    [JsonPropertyName("ipv4IpamPoolIdSelector")]
    public V1beta1VPCSpecInitProviderIpv4IpamPoolIdSelector? Ipv4IpamPoolIdSelector { get; set; }

    /// <summary>The netmask length of the IPv4 CIDR you want to allocate to this VPC. Requires specifying a ipv4_ipam_pool_id.</summary>
    [JsonPropertyName("ipv4NetmaskLength")]
    public double? Ipv4NetmaskLength { get; set; }

    /// <summary>IPv6 CIDR block to request from an IPAM Pool. Can be set explicitly or derived from IPAM using ipv6_netmask_length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>By default when an IPv6 CIDR is assigned to a VPC a default ipv6_cidr_block_network_border_group will be set to the region of the VPC. This can be changed to restrict advertisement of public addresses to specific Network Border Groups such as LocalZones.</summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary>IPAM Pool ID for a IPv6 pool. Conflicts with assign_generated_ipv6_cidr_block.</summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary>Netmask length to request from IPAM Pool. Conflicts with ipv6_cidr_block. This can be omitted if IPAM pool as a allocation_default_netmask_length set. Valid values are from 44 to 60 in increments of 4.</summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VPCSpec defines the desired state of VPC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of VPC</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC. You cannot specify the range of IP addresses, or the size of the CIDR block. Default is false. Conflicts with ipv6_ipam_pool_id</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>The IPv4 CIDR block for the VPC. CIDR can be explicitly set or it can be derived from IPAM using ipv4_netmask_length.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>The ID of the network ACL created by default on VPC creation</summary>
    [JsonPropertyName("defaultNetworkAclId")]
    public string? DefaultNetworkAclId { get; set; }

    /// <summary>The ID of the route table created by default on VPC creation</summary>
    [JsonPropertyName("defaultRouteTableId")]
    public string? DefaultRouteTableId { get; set; }

    /// <summary>The ID of the security group created by default on VPC creation</summary>
    [JsonPropertyName("defaultSecurityGroupId")]
    public string? DefaultSecurityGroupId { get; set; }

    /// <summary>DHCP options id of the desired VPC.</summary>
    [JsonPropertyName("dhcpOptionsId")]
    public string? DhcpOptionsId { get; set; }

    /// <summary>A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary>A boolean flag to enable/disable DNS support in the VPC. Defaults to true.</summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary>Indicates whether Network Address Usage metrics are enabled for your VPC. Defaults to false.</summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>The ID of the VPC</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A tenancy option for instances launched into the VPC. Default is default, which ensures that EC2 instances launched in this VPC use the EC2 instance tenancy attribute specified when the EC2 instance is launched. The only other option is dedicated, which ensures that EC2 instances launched in this VPC are run on dedicated tenancy instances regardless of the tenancy attribute specified at launch. This has a dedicated per region fee of $2 per hour, plus an hourly per instance usage fee.</summary>
    [JsonPropertyName("instanceTenancy")]
    public string? InstanceTenancy { get; set; }

    /// <summary>The ID of an IPv4 IPAM pool you want to use for allocating this VPC's CIDR. IPAM is a VPC feature that you can use to automate your IP address management workflows including assigning, tracking, troubleshooting, and auditing IP addresses across AWS Regions and accounts. Using IPAM you can monitor IP address usage throughout your AWS Organization.</summary>
    [JsonPropertyName("ipv4IpamPoolId")]
    public string? Ipv4IpamPoolId { get; set; }

    /// <summary>The netmask length of the IPv4 CIDR you want to allocate to this VPC. Requires specifying a ipv4_ipam_pool_id.</summary>
    [JsonPropertyName("ipv4NetmaskLength")]
    public double? Ipv4NetmaskLength { get; set; }

    /// <summary>The association ID for the IPv6 CIDR block.</summary>
    [JsonPropertyName("ipv6AssociationId")]
    public string? Ipv6AssociationId { get; set; }

    /// <summary>IPv6 CIDR block to request from an IPAM Pool. Can be set explicitly or derived from IPAM using ipv6_netmask_length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>By default when an IPv6 CIDR is assigned to a VPC a default ipv6_cidr_block_network_border_group will be set to the region of the VPC. This can be changed to restrict advertisement of public addresses to specific Network Border Groups such as LocalZones.</summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary>IPAM Pool ID for a IPv6 pool. Conflicts with assign_generated_ipv6_cidr_block.</summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary>Netmask length to request from IPAM Pool. Conflicts with ipv6_cidr_block. This can be omitted if IPAM pool as a allocation_default_netmask_length set. Valid values are from 44 to 60 in increments of 4.</summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary>The ID of the main route table associated with this VPC. Note that you can change a VPC's main route table by using an aws_main_route_table_association.</summary>
    [JsonPropertyName("mainRouteTableId")]
    public string? MainRouteTableId { get; set; }

    /// <summary>The ID of the AWS account that owns the VPC.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCStatusConditions
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
/// <summary>VPCStatus defines the observed state of VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VPC is the Schema for the VPCs API. Provides a VPC resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPC : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCSpec>, IStatus<V1beta1VPCStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPC";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "vpcs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCSpec defines the desired state of VPC</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCSpec Spec { get; set; }

    /// <summary>VPCStatus defines the observed state of VPC.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCStatus? Status { get; set; }
}
#nullable disable
