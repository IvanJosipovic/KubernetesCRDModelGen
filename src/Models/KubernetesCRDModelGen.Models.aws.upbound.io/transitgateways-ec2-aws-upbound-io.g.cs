using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecForProvider
{
    /// <summary>Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs. Default value: 64512.</summary>
    [JsonPropertyName("amazonSideAsn")]
    public double? AmazonSideAsn { get; set; }

    /// <summary>Whether resource attachment requests are automatically accepted. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("autoAcceptSharedAttachments")]
    public string? AutoAcceptSharedAttachments { get; set; }

    /// <summary>Whether resource attachments are automatically associated with the default association route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTableAssociation")]
    public string? DefaultRouteTableAssociation { get; set; }

    /// <summary>Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTablePropagation")]
    public string? DefaultRouteTablePropagation { get; set; }

    /// <summary>Description of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether DNS support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("dnsSupport")]
    public string? DnsSupport { get; set; }

    /// <summary>Whether Multicast support is enabled. Required to use ec2_transit_gateway_multicast_domain. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("multicastSupport")]
    public string? MulticastSupport { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether Security Group Referencing Support is enabled. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("securityGroupReferencingSupport")]
    public string? SecurityGroupReferencingSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block or larger for IPv4, or a size /64 CIDR block or larger for IPv6.</summary>
    [JsonPropertyName("transitGatewayCidrBlocks")]
    public IList<string>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("vpnEcmpSupport")]
    public string? VpnEcmpSupport { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecInitProvider
{
    /// <summary>Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs. Default value: 64512.</summary>
    [JsonPropertyName("amazonSideAsn")]
    public double? AmazonSideAsn { get; set; }

    /// <summary>Whether resource attachment requests are automatically accepted. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("autoAcceptSharedAttachments")]
    public string? AutoAcceptSharedAttachments { get; set; }

    /// <summary>Whether resource attachments are automatically associated with the default association route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTableAssociation")]
    public string? DefaultRouteTableAssociation { get; set; }

    /// <summary>Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTablePropagation")]
    public string? DefaultRouteTablePropagation { get; set; }

    /// <summary>Description of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether DNS support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("dnsSupport")]
    public string? DnsSupport { get; set; }

    /// <summary>Whether Multicast support is enabled. Required to use ec2_transit_gateway_multicast_domain. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("multicastSupport")]
    public string? MulticastSupport { get; set; }

    /// <summary>Whether Security Group Referencing Support is enabled. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("securityGroupReferencingSupport")]
    public string? SecurityGroupReferencingSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block or larger for IPv4, or a size /64 CIDR block or larger for IPv6.</summary>
    [JsonPropertyName("transitGatewayCidrBlocks")]
    public IList<string>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("vpnEcmpSupport")]
    public string? VpnEcmpSupport { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecProviderConfigRefPolicy
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
public partial class V1beta1TransitGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1TransitGatewaySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewaySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TransitGatewaySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TransitGatewaySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TransitGatewaySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TransitGatewaySpec defines the desired state of TransitGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TransitGatewaySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayStatusAtProvider
{
    /// <summary>Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs. Default value: 64512.</summary>
    [JsonPropertyName("amazonSideAsn")]
    public double? AmazonSideAsn { get; set; }

    /// <summary>EC2 Transit Gateway Amazon Resource Name (ARN)</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier of the default association route table</summary>
    [JsonPropertyName("associationDefaultRouteTableId")]
    public string? AssociationDefaultRouteTableId { get; set; }

    /// <summary>Whether resource attachment requests are automatically accepted. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("autoAcceptSharedAttachments")]
    public string? AutoAcceptSharedAttachments { get; set; }

    /// <summary>Whether resource attachments are automatically associated with the default association route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTableAssociation")]
    public string? DefaultRouteTableAssociation { get; set; }

    /// <summary>Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("defaultRouteTablePropagation")]
    public string? DefaultRouteTablePropagation { get; set; }

    /// <summary>Description of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether DNS support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("dnsSupport")]
    public string? DnsSupport { get; set; }

    /// <summary>EC2 Transit Gateway identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether Multicast support is enabled. Required to use ec2_transit_gateway_multicast_domain. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("multicastSupport")]
    public string? MulticastSupport { get; set; }

    /// <summary>Identifier of the AWS account that owns the EC2 Transit Gateway</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Identifier of the default propagation route table</summary>
    [JsonPropertyName("propagationDefaultRouteTableId")]
    public string? PropagationDefaultRouteTableId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether Security Group Referencing Support is enabled. Valid values: disable, enable. Default value: disable.</summary>
    [JsonPropertyName("securityGroupReferencingSupport")]
    public string? SecurityGroupReferencingSupport { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>One or more IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block or larger for IPv4, or a size /64 CIDR block or larger for IPv6.</summary>
    [JsonPropertyName("transitGatewayCidrBlocks")]
    public IList<string>? TransitGatewayCidrBlocks { get; set; }

    /// <summary>Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: disable, enable. Default value: enable.</summary>
    [JsonPropertyName("vpnEcmpSupport")]
    public string? VpnEcmpSupport { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayStatusConditions
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

/// <summary>TransitGatewayStatus defines the observed state of TransitGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TransitGateway is the Schema for the TransitGateways API. Manages an EC2 Transit Gateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewaySpec>, IStatus<V1beta1TransitGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGateway";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "transitgateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewaySpec defines the desired state of TransitGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewaySpec Spec { get; set; }

    /// <summary>TransitGatewayStatus defines the observed state of TransitGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayStatus? Status { get; set; }
}

/// <summary>TransitGateway is the Schema for the TransitGateways API. Manages an EC2 Transit Gateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TransitGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "transitgateways";
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
    public IList<V1beta1TransitGateway> Items { get; set; }
}