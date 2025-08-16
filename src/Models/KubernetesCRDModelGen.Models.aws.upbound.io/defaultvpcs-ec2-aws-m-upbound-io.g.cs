using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>DefaultVPC is the Schema for the DefaultVPCs API. Manage a default VPC resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultVPCList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DefaultVPC>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultVPCList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultvpcs";
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
    public IList<V1beta1DefaultVPC> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCSpecForProvider
{
    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>Whether destroying the resource deletes the default VPC. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCSpecInitProvider
{
    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>Whether destroying the resource deletes the default VPC. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCSpecProviderConfigRef
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
public partial class V1beta1DefaultVPCSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DefaultVPCSpec defines the desired state of DefaultVPC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DefaultVPCSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DefaultVPCSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DefaultVPCSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DefaultVPCSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("assignGeneratedIpv6CidrBlock")]
    public bool? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultNetworkAclId")]
    public string? DefaultNetworkAclId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultRouteTableId")]
    public string? DefaultRouteTableId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSecurityGroupId")]
    public string? DefaultSecurityGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dhcpOptionsId")]
    public string? DhcpOptionsId { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("enableDnsHostnames")]
    public bool? EnableDnsHostnames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsSupport")]
    public bool? EnableDnsSupport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("existingDefaultVpc")]
    public bool? ExistingDefaultVpc { get; set; }

    /// <summary>Whether destroying the resource deletes the default VPC. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The allowed tenancy of instances launched into the VPC</summary>
    [JsonPropertyName("instanceTenancy")]
    public string? InstanceTenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6AssociationId")]
    public string? Ipv6AssociationId { get; set; }

    /// <summary>and instance_tenancy arguments become computed attributes</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6CidrBlockNetworkBorderGroup")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6IpamPoolId")]
    public string? Ipv6IpamPoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public double? Ipv6NetmaskLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mainRouteTableId")]
    public string? MainRouteTableId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCStatusConditions
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

/// <summary>DefaultVPCStatus defines the observed state of DefaultVPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultVPCStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DefaultVPCStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DefaultVPCStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DefaultVPC is the Schema for the DefaultVPCs API. Manage a default VPC resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultVPC : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DefaultVPCSpec>, IStatus<V1beta1DefaultVPCStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultVPC";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "defaultvpcs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DefaultVPCSpec defines the desired state of DefaultVPC</summary>
    [JsonPropertyName("spec")]
    public V1beta1DefaultVPCSpec Spec { get; set; }

    /// <summary>DefaultVPCStatus defines the observed state of DefaultVPC.</summary>
    [JsonPropertyName("status")]
    public V1beta1DefaultVPCStatus? Status { get; set; }
}