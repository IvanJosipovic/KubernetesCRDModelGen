using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1ExpressRouteCircuitConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderAuthorizationKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecForProvider
{
    /// <summary>The IPv4 address space from which to allocate customer address for global reach. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("addressPrefixIpv4")]
    public string? AddressPrefixIpv4 { get; set; }

    /// <summary>The IPv6 address space from which to allocate customer addresses for global reach.</summary>
    [JsonPropertyName("addressPrefixIpv6")]
    public string? AddressPrefixIpv6 { get; set; }

    /// <summary>The authorization key which is associated with the Express Route Circuit Connection.</summary>
    [JsonPropertyName("authorizationKeySecretRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderAuthorizationKeySecretRef? AuthorizationKeySecretRef { get; set; }

    /// <summary>The ID of the peered Express Route Circuit Private Peering. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("peerPeeringId")]
    public string? PeerPeeringId { get; set; }

    /// <summary>Reference to a ExpressRouteCircuitPeering in network to populate peerPeeringId.</summary>
    [JsonPropertyName("peerPeeringIdRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdRef? PeerPeeringIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuitPeering in network to populate peerPeeringId.</summary>
    [JsonPropertyName("peerPeeringIdSelector")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeerPeeringIdSelector? PeerPeeringIdSelector { get; set; }

    /// <summary>The ID of the Express Route Circuit Private Peering that this Express Route Circuit Connection connects with. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("peeringId")]
    public string? PeeringId { get; set; }

    /// <summary>Reference to a ExpressRouteCircuitPeering in network to populate peeringId.</summary>
    [JsonPropertyName("peeringIdRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdRef? PeeringIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuitPeering in network to populate peeringId.</summary>
    [JsonPropertyName("peeringIdSelector")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProviderPeeringIdSelector? PeeringIdSelector { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProviderAuthorizationKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecInitProvider
{
    /// <summary>The IPv4 address space from which to allocate customer address for global reach. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("addressPrefixIpv4")]
    public string? AddressPrefixIpv4 { get; set; }

    /// <summary>The IPv6 address space from which to allocate customer addresses for global reach.</summary>
    [JsonPropertyName("addressPrefixIpv6")]
    public string? AddressPrefixIpv6 { get; set; }

    /// <summary>The authorization key which is associated with the Express Route Circuit Connection.</summary>
    [JsonPropertyName("authorizationKeySecretRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderAuthorizationKeySecretRef? AuthorizationKeySecretRef { get; set; }

    /// <summary>The ID of the peered Express Route Circuit Private Peering. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("peerPeeringId")]
    public string? PeerPeeringId { get; set; }

    /// <summary>Reference to a ExpressRouteCircuitPeering in network to populate peerPeeringId.</summary>
    [JsonPropertyName("peerPeeringIdRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdRef? PeerPeeringIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuitPeering in network to populate peerPeeringId.</summary>
    [JsonPropertyName("peerPeeringIdSelector")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProviderPeerPeeringIdSelector? PeerPeeringIdSelector { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecManagementPoliciesEnum
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

public enum V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteCircuitConnectionSpecDeletionPolicyEnum>))]
    public V1beta1ExpressRouteCircuitConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ExpressRouteCircuitConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ExpressRouteCircuitConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ExpressRouteCircuitConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ExpressRouteCircuitConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExpressRouteCircuitConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionStatusAtProvider
{
    /// <summary>The IPv4 address space from which to allocate customer address for global reach. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("addressPrefixIpv4")]
    public string? AddressPrefixIpv4 { get; set; }

    /// <summary>The IPv6 address space from which to allocate customer addresses for global reach.</summary>
    [JsonPropertyName("addressPrefixIpv6")]
    public string? AddressPrefixIpv6 { get; set; }

    /// <summary>The ID of the Express Route Circuit Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the peered Express Route Circuit Private Peering. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("peerPeeringId")]
    public string? PeerPeeringId { get; set; }

    /// <summary>The ID of the Express Route Circuit Private Peering that this Express Route Circuit Connection connects with. Changing this forces a new Express Route Circuit Connection to be created.</summary>
    [JsonPropertyName("peeringId")]
    public string? PeeringId { get; set; }
}

public partial class V1beta1ExpressRouteCircuitConnectionStatusConditions
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

public partial class V1beta1ExpressRouteCircuitConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ExpressRouteCircuitConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExpressRouteCircuitConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRouteCircuitConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExpressRouteCircuitConnectionSpec>, IStatus<V1beta1ExpressRouteCircuitConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRouteCircuitConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressroutecircuitconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRouteCircuitConnectionSpec defines the desired state of ExpressRouteCircuitConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1ExpressRouteCircuitConnectionSpec Spec { get; set; }

    /// <summary>ExpressRouteCircuitConnectionStatus defines the observed state of ExpressRouteCircuitConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExpressRouteCircuitConnectionStatus? Status { get; set; }
}