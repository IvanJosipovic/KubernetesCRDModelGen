using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VirtualHubRouteTableSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderRoute
{
    /// <summary>A list of destination addresses for this route.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The type of destinations. Possible values are CIDR, ResourceId and Service.</summary>
    [JsonPropertyName("destinationsType")]
    public string? DestinationsType { get; set; }

    /// <summary>The name which should be used for this route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next hop's resource ID.</summary>
    [JsonPropertyName("nextHop")]
    public string? NextHop { get; set; }

    /// <summary>Reference to a VirtualHubConnection in network to populate nextHop.</summary>
    [JsonPropertyName("nextHopRef")]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopRef? NextHopRef { get; set; }

    /// <summary>Selector for a VirtualHubConnection in network to populate nextHop.</summary>
    [JsonPropertyName("nextHopSelector")]
    public V1beta1VirtualHubRouteTableSpecForProviderRouteNextHopSelector? NextHopSelector { get; set; }

    /// <summary>The type of next hop. Currently the only possible value is ResourceId. Defaults to ResourceId.</summary>
    [JsonPropertyName("nextHopType")]
    public string? NextHopType { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecForProvider
{
    /// <summary>List of labels associated with this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>One or more route blocks as defined below.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualHubRouteTableSpecForProviderRoute>? Route { get; set; }

    /// <summary>The ID of the Virtual Hub within which this route table should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1VirtualHubRouteTableSpecForProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecInitProviderRoute
{
    /// <summary>A list of destination addresses for this route.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The type of destinations. Possible values are CIDR, ResourceId and Service.</summary>
    [JsonPropertyName("destinationsType")]
    public string? DestinationsType { get; set; }

    /// <summary>The name which should be used for this route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next hop's resource ID.</summary>
    [JsonPropertyName("nextHop")]
    public string? NextHop { get; set; }

    /// <summary>Reference to a VirtualHubConnection in network to populate nextHop.</summary>
    [JsonPropertyName("nextHopRef")]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopRef? NextHopRef { get; set; }

    /// <summary>Selector for a VirtualHubConnection in network to populate nextHop.</summary>
    [JsonPropertyName("nextHopSelector")]
    public V1beta1VirtualHubRouteTableSpecInitProviderRouteNextHopSelector? NextHopSelector { get; set; }

    /// <summary>The type of next hop. Currently the only possible value is ResourceId. Defaults to ResourceId.</summary>
    [JsonPropertyName("nextHopType")]
    public string? NextHopType { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecInitProvider
{
    /// <summary>List of labels associated with this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>One or more route blocks as defined below.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualHubRouteTableSpecInitProviderRoute>? Route { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecManagementPoliciesEnum
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

public enum V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1VirtualHubRouteTableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubRouteTableSpecDeletionPolicyEnum>))]
    public V1beta1VirtualHubRouteTableSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualHubRouteTableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualHubRouteTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualHubRouteTableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualHubRouteTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualHubRouteTableSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualHubRouteTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1VirtualHubRouteTableStatusAtProviderRoute
{
    /// <summary>A list of destination addresses for this route.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The type of destinations. Possible values are CIDR, ResourceId and Service.</summary>
    [JsonPropertyName("destinationsType")]
    public string? DestinationsType { get; set; }

    /// <summary>The name which should be used for this route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next hop's resource ID.</summary>
    [JsonPropertyName("nextHop")]
    public string? NextHop { get; set; }

    /// <summary>The type of next hop. Currently the only possible value is ResourceId. Defaults to ResourceId.</summary>
    [JsonPropertyName("nextHopType")]
    public string? NextHopType { get; set; }
}

public partial class V1beta1VirtualHubRouteTableStatusAtProvider
{
    /// <summary>The ID of the Virtual Hub Route Table.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of labels associated with this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>One or more route blocks as defined below.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualHubRouteTableStatusAtProviderRoute>? Route { get; set; }

    /// <summary>The ID of the Virtual Hub within which this route table should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }
}

public partial class V1beta1VirtualHubRouteTableStatusConditions
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

public partial class V1beta1VirtualHubRouteTableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualHubRouteTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualHubRouteTableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualHubRouteTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualHubRouteTableSpec>, IStatus<V1beta1VirtualHubRouteTableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualHubRouteTable";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualhubroutetables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualHubRouteTableSpec defines the desired state of VirtualHubRouteTable</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualHubRouteTableSpec Spec { get; set; }

    /// <summary>VirtualHubRouteTableStatus defines the observed state of VirtualHubRouteTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualHubRouteTableStatus? Status { get; set; }
}