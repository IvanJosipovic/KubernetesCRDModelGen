using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>DefaultSubnet is the Schema for the DefaultSubnets API. Manage a default subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSubnetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DefaultSubnet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSubnetList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultsubnets";
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
    public IList<V1beta1DefaultSubnet> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecProviderConfigRef
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
public partial class V1beta1DefaultSubnetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DefaultSubnetSpec defines the desired state of DefaultSubnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DefaultSubnetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DefaultSubnetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DefaultSubnetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DefaultSubnetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>, cidr_block and vpc_id arguments become computed attributes</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLniAtDeviceIndex")]
    public double? EnableLniAtDeviceIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("existingDefaultSubnet")]
    public bool? ExistingDefaultSubnet { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6CidrBlockAssociationId")]
    public string? Ipv6CidrBlockAssociationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The ID of the VPC the subnet is in</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatusConditions
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

/// <summary>DefaultSubnetStatus defines the observed state of DefaultSubnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DefaultSubnetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DefaultSubnetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DefaultSubnet is the Schema for the DefaultSubnets API. Manage a default subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSubnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DefaultSubnetSpec>, IStatus<V1beta1DefaultSubnetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSubnet";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultsubnets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DefaultSubnetSpec defines the desired state of DefaultSubnet</summary>
    [JsonPropertyName("spec")]
    public V1beta1DefaultSubnetSpec Spec { get; set; }

    /// <summary>DefaultSubnetStatus defines the observed state of DefaultSubnet.</summary>
    [JsonPropertyName("status")]
    public V1beta1DefaultSubnetStatus? Status { get; set; }
}