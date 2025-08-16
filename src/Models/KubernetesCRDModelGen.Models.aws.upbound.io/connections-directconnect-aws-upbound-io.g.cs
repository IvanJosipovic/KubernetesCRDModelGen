using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.directconnect.aws.upbound.io;
/// <summary>Connection is the Schema for the Connections API. Provides a Connection of Direct Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Connection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectionList";
    public const string KubeGroup = "directconnect.aws.upbound.io";
    public const string KubePluralName = "connections";
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
    public IList<V1beta1Connection> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProvider
{
    /// <summary>The bandwidth of the connection. Valid values for dedicated connections: 1Gbps, 10Gbps, 100Gbps, and 400Gbps. Valid values for hosted connections: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps, 10Gbps, and 25Gbps. Case sensitive. Refer to the AWS Direct Connection supported bandwidths for Dedicated Connections and Hosted Connections.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>The connection MAC Security (MACsec) encryption mode. MAC Security (MACsec) is only available on dedicated connections. Valid values are no_encrypt, should_encrypt, and must_encrypt.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>The AWS Direct Connect location where the connection is located. See DescribeLocations for the list of AWS Direct Connect locations. Use locationCode.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the service provider associated with the connection.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Boolean value indicating whether you want the connection to support MAC Security (MACsec). MAC Security (MACsec) is only available on dedicated connections. See MACsec prerequisites for more information about MAC Security (MACsec) prerequisites. Default value: false.</summary>
    [JsonPropertyName("requestMacsec")]
    public bool? RequestMacsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProvider
{
    /// <summary>The bandwidth of the connection. Valid values for dedicated connections: 1Gbps, 10Gbps, 100Gbps, and 400Gbps. Valid values for hosted connections: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps, 10Gbps, and 25Gbps. Case sensitive. Refer to the AWS Direct Connection supported bandwidths for Dedicated Connections and Hosted Connections.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>The connection MAC Security (MACsec) encryption mode. MAC Security (MACsec) is only available on dedicated connections. Valid values are no_encrypt, should_encrypt, and must_encrypt.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>The AWS Direct Connect location where the connection is located. See DescribeLocations for the list of AWS Direct Connect locations. Use locationCode.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the service provider associated with the connection.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>Boolean value indicating whether you want the connection to support MAC Security (MACsec). MAC Security (MACsec) is only available on dedicated connections. See MACsec prerequisites for more information about MAC Security (MACsec) prerequisites. Default value: false.</summary>
    [JsonPropertyName("requestMacsec")]
    public bool? RequestMacsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecProviderConfigRefPolicy
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
public partial class V1beta1ConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConnectionSpec defines the desired state of Connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProvider
{
    /// <summary>The ARN of the connection.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Direct Connect endpoint on which the physical connection terminates.</summary>
    [JsonPropertyName("awsDevice")]
    public string? AwsDevice { get; set; }

    /// <summary>The bandwidth of the connection. Valid values for dedicated connections: 1Gbps, 10Gbps, 100Gbps, and 400Gbps. Valid values for hosted connections: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps, 10Gbps, and 25Gbps. Case sensitive. Refer to the AWS Direct Connection supported bandwidths for Dedicated Connections and Hosted Connections.</summary>
    [JsonPropertyName("bandwidth")]
    public string? Bandwidth { get; set; }

    /// <summary>The connection MAC Security (MACsec) encryption mode. MAC Security (MACsec) is only available on dedicated connections. Valid values are no_encrypt, should_encrypt, and must_encrypt.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>Indicates whether the connection supports a secondary BGP peer in the same address family (IPv4/IPv6).</summary>
    [JsonPropertyName("hasLogicalRedundancy")]
    public string? HasLogicalRedundancy { get; set; }

    /// <summary>The ID of the connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Boolean value representing if jumbo frames have been enabled for this connection.</summary>
    [JsonPropertyName("jumboFrameCapable")]
    public bool? JumboFrameCapable { get; set; }

    /// <summary>The AWS Direct Connect location where the connection is located. See DescribeLocations for the list of AWS Direct Connect locations. Use locationCode.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Boolean value indicating whether the connection supports MAC Security (MACsec).</summary>
    [JsonPropertyName("macsecCapable")]
    public bool? MacsecCapable { get; set; }

    /// <summary>The name of the connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the AWS account that owns the connection.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The name of the AWS Direct Connect service provider associated with the connection.</summary>
    [JsonPropertyName("partnerName")]
    public string? PartnerName { get; set; }

    /// <summary>The MAC Security (MACsec) port link status of the connection.</summary>
    [JsonPropertyName("portEncryptionStatus")]
    public string? PortEncryptionStatus { get; set; }

    /// <summary>The name of the service provider associated with the connection.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Boolean value indicating whether you want the connection to support MAC Security (MACsec). MAC Security (MACsec) is only available on dedicated connections. See MACsec prerequisites for more information about MAC Security (MACsec) prerequisites. Default value: false.</summary>
    [JsonPropertyName("requestMacsec")]
    public bool? RequestMacsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusConditions
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

/// <summary>ConnectionStatus defines the observed state of Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. Provides a Connection of Direct Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Connection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectionSpec>, IStatus<V1beta1ConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Connection";
    public const string KubeGroup = "directconnect.aws.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionSpec defines the desired state of Connection</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectionSpec Spec { get; set; }

    /// <summary>ConnectionStatus defines the observed state of Connection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectionStatus? Status { get; set; }
}