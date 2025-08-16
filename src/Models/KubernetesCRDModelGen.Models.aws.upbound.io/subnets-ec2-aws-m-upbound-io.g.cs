using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>Subnet is the Schema for the Subnets API. Provides an VPC subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubnetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Subnet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubnetList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "subnets";
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
    public IList<V1beta1Subnet> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVpcIdSelector
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
    public V1beta1SubnetSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProvider
{
    /// <summary>Specify true to indicate that network interfaces created in the specified subnet should be assigned an IPv6 address. Default is false</summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>AZ for the subnet.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>AZ ID of the subnet. This argument is not supported in all regions or partitions. If necessary, use availability_zone instead.</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>The IPv4 CIDR block for the subnet.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>The customer owned IPv4 address pool. Typically used with the map_customer_owned_ip_on_launch argument. The outpost_arn argument must be specified when configured.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>Indicates whether DNS queries made to the Amazon-provided DNS Resolver in this subnet should return synthetic IPv6 addresses for IPv4-only destinations. Default: false.</summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary>Indicates the device position for local network interfaces in this subnet. For example, 1 indicates local network interfaces in this subnet are the secondary network interface (eth1). A local network interface cannot be the primary network interface (eth0).</summary>
    [JsonPropertyName("enableLniAtDeviceIndex")]
    public double? EnableLniAtDeviceIndex { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>The IPv6 network range for the subnet, in CIDR notation. The subnet size must use a /64 prefix length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>Indicates whether to create an IPv6-only subnet. Default: false.</summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary>Specify true to indicate that network interfaces created in the subnet should be assigned a customer owned IP address. The customer_owned_ipv4_pool and outpost_arn arguments must be specified when set to true. Default is false.</summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>Specify true to indicate that instances launched into the subnet should be assigned a public IP address. Default is false.</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The type of hostnames to assign to instances in the subnet at launch. For IPv6-only subnets, an instance DNS name must be based on the instance ID. For dual-stack and IPv4-only subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name, resource-name.</summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VPC ID.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1SubnetSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1SubnetSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderVpcIdSelector
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
    public V1beta1SubnetSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProvider
{
    /// <summary>Specify true to indicate that network interfaces created in the specified subnet should be assigned an IPv6 address. Default is false</summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>AZ for the subnet.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>AZ ID of the subnet. This argument is not supported in all regions or partitions. If necessary, use availability_zone instead.</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>The IPv4 CIDR block for the subnet.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>The customer owned IPv4 address pool. Typically used with the map_customer_owned_ip_on_launch argument. The outpost_arn argument must be specified when configured.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>Indicates whether DNS queries made to the Amazon-provided DNS Resolver in this subnet should return synthetic IPv6 addresses for IPv4-only destinations. Default: false.</summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary>Indicates the device position for local network interfaces in this subnet. For example, 1 indicates local network interfaces in this subnet are the secondary network interface (eth1). A local network interface cannot be the primary network interface (eth0).</summary>
    [JsonPropertyName("enableLniAtDeviceIndex")]
    public double? EnableLniAtDeviceIndex { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>The IPv6 network range for the subnet, in CIDR notation. The subnet size must use a /64 prefix length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>Indicates whether to create an IPv6-only subnet. Default: false.</summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary>Specify true to indicate that network interfaces created in the subnet should be assigned a customer owned IP address. The customer_owned_ipv4_pool and outpost_arn arguments must be specified when set to true. Default is false.</summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>Specify true to indicate that instances launched into the subnet should be assigned a public IP address. Default is false.</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The type of hostnames to assign to instances in the subnet at launch. For IPv6-only subnets, an instance DNS name must be based on the instance ID. For dual-stack and IPv4-only subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name, resource-name.</summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VPC ID.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1SubnetSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1SubnetSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecProviderConfigRef
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
public partial class V1beta1SubnetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SubnetSpec defines the desired state of Subnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubnetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubnetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubnetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubnetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusAtProvider
{
    /// <summary>The ARN of the subnet.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specify true to indicate that network interfaces created in the specified subnet should be assigned an IPv6 address. Default is false</summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>AZ for the subnet.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>AZ ID of the subnet. This argument is not supported in all regions or partitions. If necessary, use availability_zone instead.</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>The IPv4 CIDR block for the subnet.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>The customer owned IPv4 address pool. Typically used with the map_customer_owned_ip_on_launch argument. The outpost_arn argument must be specified when configured.</summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>Indicates whether DNS queries made to the Amazon-provided DNS Resolver in this subnet should return synthetic IPv6 addresses for IPv4-only destinations. Default: false.</summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary>Indicates the device position for local network interfaces in this subnet. For example, 1 indicates local network interfaces in this subnet are the secondary network interface (eth1). A local network interface cannot be the primary network interface (eth0).</summary>
    [JsonPropertyName("enableLniAtDeviceIndex")]
    public double? EnableLniAtDeviceIndex { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records. Default: false.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>The ID of the subnet</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IPv6 network range for the subnet, in CIDR notation. The subnet size must use a /64 prefix length.</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary>The association ID for the IPv6 CIDR block.</summary>
    [JsonPropertyName("ipv6CidrBlockAssociationId")]
    public string? Ipv6CidrBlockAssociationId { get; set; }

    /// <summary>Indicates whether to create an IPv6-only subnet. Default: false.</summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary>Specify true to indicate that network interfaces created in the subnet should be assigned a customer owned IP address. The customer_owned_ipv4_pool and outpost_arn arguments must be specified when set to true. Default is false.</summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>Specify true to indicate that instances launched into the subnet should be assigned a public IP address. Default is false.</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The ID of the AWS account that owns the subnet.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The type of hostnames to assign to instances in the subnet at launch. For IPv6-only subnets, an instance DNS name must be based on the instance ID. For dual-stack and IPv4-only subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name, resource-name.</summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The VPC ID.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusConditions
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

/// <summary>SubnetStatus defines the observed state of Subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubnetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubnetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subnet is the Schema for the Subnets API. Provides an VPC subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Subnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubnetSpec>, IStatus<V1beta1SubnetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Subnet";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "subnets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubnetSpec defines the desired state of Subnet</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubnetSpec Spec { get; set; }

    /// <summary>SubnetStatus defines the observed state of Subnet.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubnetStatus? Status { get; set; }
}