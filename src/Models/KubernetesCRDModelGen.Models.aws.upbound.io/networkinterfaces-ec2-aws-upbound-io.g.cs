using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecForProviderSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecForProviderSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecForProvider
{
    /// <summary>Description for the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Type of network interface to create. Set to efa for Elastic Fabric Adapter. Changing interface_type will cause the resource to be destroyed and re-created.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Number of IPv4 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>Number of IPv6 addresses to assign to a network interface. You can't use this option if specifying specific ipv6_addresses. If your subnet has the AssignIpv6AddressOnCreation attribute set to true, you can specify 0 to override this setting.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order.</summary>
    [JsonPropertyName("ipv6AddressList")]
    public IList<string>? Ipv6AddressList { get; set; }

    /// <summary>Whether ipv6_address_list is allowed and controls the IPs to assign to the ENI and ipv6_addresses and ipv6_address_count become read-only. Default false.</summary>
    [JsonPropertyName("ipv6AddressListEnabled")]
    public bool? Ipv6AddressListEnabled { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Addresses are assigned without regard to order. You can't use this option if you're specifying ipv6_address_count.</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Number of IPv6 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order. Requires setting private_ip_list_enabled to true.</summary>
    [JsonPropertyName("privateIpList")]
    public IList<string>? PrivateIpList { get; set; }

    /// <summary>Whether private_ip_list is allowed and controls the IPs to assign to the ENI and private_ips and private_ips_count become read-only. Default false.</summary>
    [JsonPropertyName("privateIpListEnabled")]
    public bool? PrivateIpListEnabled { get; set; }

    /// <summary>List of private IPs to assign to the ENI without regard to order.</summary>
    [JsonPropertyName("privateIps")]
    public IList<string>? PrivateIps { get; set; }

    /// <summary>Number of secondary private IPs to assign to the ENI. The total number of private IPs will be 1 + private_ips_count, as a primary private IP will be assiged to an ENI by default.</summary>
    [JsonPropertyName("privateIpsCount")]
    public double? PrivateIpsCount { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1NetworkInterfaceSpecForProviderSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1NetworkInterfaceSpecForProviderSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>List of security group IDs to assign to the ENI.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether to enable source destination checking for the ENI. Default true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>Subnet ID to create the ENI in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1NetworkInterfaceSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NetworkInterfaceSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecInitProviderSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecInitProviderSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecInitProvider
{
    /// <summary>Description for the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Type of network interface to create. Set to efa for Elastic Fabric Adapter. Changing interface_type will cause the resource to be destroyed and re-created.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Number of IPv4 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>Number of IPv6 addresses to assign to a network interface. You can't use this option if specifying specific ipv6_addresses. If your subnet has the AssignIpv6AddressOnCreation attribute set to true, you can specify 0 to override this setting.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order.</summary>
    [JsonPropertyName("ipv6AddressList")]
    public IList<string>? Ipv6AddressList { get; set; }

    /// <summary>Whether ipv6_address_list is allowed and controls the IPs to assign to the ENI and ipv6_addresses and ipv6_address_count become read-only. Default false.</summary>
    [JsonPropertyName("ipv6AddressListEnabled")]
    public bool? Ipv6AddressListEnabled { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Addresses are assigned without regard to order. You can't use this option if you're specifying ipv6_address_count.</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Number of IPv6 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order. Requires setting private_ip_list_enabled to true.</summary>
    [JsonPropertyName("privateIpList")]
    public IList<string>? PrivateIpList { get; set; }

    /// <summary>Whether private_ip_list is allowed and controls the IPs to assign to the ENI and private_ips and private_ips_count become read-only. Default false.</summary>
    [JsonPropertyName("privateIpListEnabled")]
    public bool? PrivateIpListEnabled { get; set; }

    /// <summary>List of private IPs to assign to the ENI without regard to order.</summary>
    [JsonPropertyName("privateIps")]
    public IList<string>? PrivateIps { get; set; }

    /// <summary>Number of secondary private IPs to assign to the ENI. The total number of private IPs will be 1 + private_ips_count, as a primary private IP will be assiged to an ENI by default.</summary>
    [JsonPropertyName("privateIpsCount")]
    public double? PrivateIpsCount { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1NetworkInterfaceSpecInitProviderSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1NetworkInterfaceSpecInitProviderSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>List of security group IDs to assign to the ENI.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether to enable source destination checking for the ENI. Default true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>Subnet ID to create the ENI in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1NetworkInterfaceSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NetworkInterfaceSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInterfaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1NetworkInterfaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NetworkInterfaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NetworkInterfaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NetworkInterfaceSpec defines the desired state of NetworkInterface</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NetworkInterfaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NetworkInterfaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkInterfaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NetworkInterfaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkInterfaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceStatusAtProviderAttachment
{
    /// <summary>ID of the network interface.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    /// <summary>Integer to define the devices index.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>ID of the instance to attach to.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceStatusAtProvider
{
    /// <summary>ARN of the network interface.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block to define the attachment of the ENI. See Attachment below for more details!</summary>
    [JsonPropertyName("attachment")]
    public IList<V1beta1NetworkInterfaceStatusAtProviderAttachment>? Attachment { get; set; }

    /// <summary>Description for the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of the network interface.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of network interface to create. Set to efa for Elastic Fabric Adapter. Changing interface_type will cause the resource to be destroyed and re-created.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Number of IPv4 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>Number of IPv6 addresses to assign to a network interface. You can't use this option if specifying specific ipv6_addresses. If your subnet has the AssignIpv6AddressOnCreation attribute set to true, you can specify 0 to override this setting.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order.</summary>
    [JsonPropertyName("ipv6AddressList")]
    public IList<string>? Ipv6AddressList { get; set; }

    /// <summary>Whether ipv6_address_list is allowed and controls the IPs to assign to the ENI and ipv6_addresses and ipv6_address_count become read-only. Default false.</summary>
    [JsonPropertyName("ipv6AddressListEnabled")]
    public bool? Ipv6AddressListEnabled { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Addresses are assigned without regard to order. You can't use this option if you're specifying ipv6_address_count.</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Number of IPv6 prefixes that AWS automatically assigns to the network interface.</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes assigned to the network interface.</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>MAC address of the network interface.</summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>ARN of the network interface.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>AWS account ID of the owner of the network interface.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Private DNS name of the network interface (IPv4).</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>List of private IPs to assign to the ENI in sequential order. Requires setting private_ip_list_enabled to true.</summary>
    [JsonPropertyName("privateIpList")]
    public IList<string>? PrivateIpList { get; set; }

    /// <summary>Whether private_ip_list is allowed and controls the IPs to assign to the ENI and private_ips and private_ips_count become read-only. Default false.</summary>
    [JsonPropertyName("privateIpListEnabled")]
    public bool? PrivateIpListEnabled { get; set; }

    /// <summary>List of private IPs to assign to the ENI without regard to order.</summary>
    [JsonPropertyName("privateIps")]
    public IList<string>? PrivateIps { get; set; }

    /// <summary>Number of secondary private IPs to assign to the ENI. The total number of private IPs will be 1 + private_ips_count, as a primary private IP will be assiged to an ENI by default.</summary>
    [JsonPropertyName("privateIpsCount")]
    public double? PrivateIpsCount { get; set; }

    /// <summary>List of security group IDs to assign to the ENI.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Whether to enable source destination checking for the ENI. Default true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>Subnet ID to create the ENI in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceStatusConditions
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

/// <summary>NetworkInterfaceStatus defines the observed state of NetworkInterface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInterfaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkInterfaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkInterfaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NetworkInterface is the Schema for the NetworkInterfaces API. Provides an Elastic network interface (ENI) resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkInterface : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkInterfaceSpec>, IStatus<V1beta1NetworkInterfaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkInterface";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "networkinterfaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkInterfaceSpec defines the desired state of NetworkInterface</summary>
    [JsonPropertyName("spec")]
    public V1beta1NetworkInterfaceSpec Spec { get; set; }

    /// <summary>NetworkInterfaceStatus defines the observed state of NetworkInterface.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkInterfaceStatus? Status { get; set; }
}