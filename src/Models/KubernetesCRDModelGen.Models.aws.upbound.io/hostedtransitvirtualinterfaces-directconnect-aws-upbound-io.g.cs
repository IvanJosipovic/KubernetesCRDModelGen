using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.directconnect.aws.upbound.io;
public enum V1beta1HostedTransitVirtualInterfaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecForProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1HostedTransitVirtualInterfaceSpecForProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual transit interface can be either 1500 or 8500 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AWS account that will own the new virtual interface.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }
}

public enum V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecInitProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual transit interface can be either 1500 or 8500 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AWS account that will own the new virtual interface.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }
}

public enum V1beta1HostedTransitVirtualInterfaceSpecManagementPoliciesEnum
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

public enum V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HostedTransitVirtualInterfaceSpecDeletionPolicyEnum>))]
    public V1beta1HostedTransitVirtualInterfaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HostedTransitVirtualInterfaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HostedTransitVirtualInterfaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1HostedTransitVirtualInterfaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HostedTransitVirtualInterfaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1HostedTransitVirtualInterfaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HostedTransitVirtualInterfaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceStatusAtProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("amazonSideAsn")]
    public string? AmazonSideAsn { get; set; }

    /// <summary>The ARN of the virtual interface.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Direct Connect endpoint on which the virtual interface terminates.</summary>
    [JsonPropertyName("awsDevice")]
    public string? AwsDevice { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The ID of the virtual interface.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether jumbo frames (8500 MTU) are supported.</summary>
    [JsonPropertyName("jumboFrameCapable")]
    public bool? JumboFrameCapable { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual transit interface can be either 1500 or 8500 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AWS account that will own the new virtual interface.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }
}

public partial class V1beta1HostedTransitVirtualInterfaceStatusConditions
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

public partial class V1beta1HostedTransitVirtualInterfaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HostedTransitVirtualInterfaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HostedTransitVirtualInterfaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HostedTransitVirtualInterface : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HostedTransitVirtualInterfaceSpec>, IStatus<V1beta1HostedTransitVirtualInterfaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HostedTransitVirtualInterface";
    public const string KubeGroup = "directconnect.aws.upbound.io";
    public const string KubePluralName = "hostedtransitvirtualinterfaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HostedTransitVirtualInterfaceSpec defines the desired state of HostedTransitVirtualInterface</summary>
    [JsonPropertyName("spec")]
    public V1beta1HostedTransitVirtualInterfaceSpec Spec { get; set; }

    /// <summary>HostedTransitVirtualInterfaceStatus defines the observed state of HostedTransitVirtualInterface.</summary>
    [JsonPropertyName("status")]
    public V1beta1HostedTransitVirtualInterfaceStatus? Status { get; set; }
}