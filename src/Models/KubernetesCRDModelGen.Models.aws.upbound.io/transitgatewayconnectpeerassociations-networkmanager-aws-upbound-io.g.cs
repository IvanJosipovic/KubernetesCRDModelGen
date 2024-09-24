using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkmanager.aws.upbound.io;
public enum V1beta1TransitGatewayConnectPeerAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecForProvider
{
    /// <summary>The ID of the device.</summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    /// <summary>Reference to a Device in networkmanager to populate deviceId.</summary>
    [JsonPropertyName("deviceIdRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdRef? DeviceIdRef { get; set; }

    /// <summary>Selector for a Device in networkmanager to populate deviceId.</summary>
    [JsonPropertyName("deviceIdSelector")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderDeviceIdSelector? DeviceIdSelector { get; set; }

    /// <summary>The ID of the global network.</summary>
    [JsonPropertyName("globalNetworkId")]
    public string? GlobalNetworkId { get; set; }

    /// <summary>Reference to a GlobalNetwork in networkmanager to populate globalNetworkId.</summary>
    [JsonPropertyName("globalNetworkIdRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdRef? GlobalNetworkIdRef { get; set; }

    /// <summary>Selector for a GlobalNetwork in networkmanager to populate globalNetworkId.</summary>
    [JsonPropertyName("globalNetworkIdSelector")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderGlobalNetworkIdSelector? GlobalNetworkIdSelector { get; set; }

    /// <summary>The ID of the link.</summary>
    [JsonPropertyName("linkId")]
    public string? LinkId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Connect peer.</summary>
    [JsonPropertyName("transitGatewayConnectPeerArn")]
    public string? TransitGatewayConnectPeerArn { get; set; }

    /// <summary>Reference to a TransitGatewayConnectPeer in ec2 to populate transitGatewayConnectPeerArn.</summary>
    [JsonPropertyName("transitGatewayConnectPeerArnRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnRef? TransitGatewayConnectPeerArnRef { get; set; }

    /// <summary>Selector for a TransitGatewayConnectPeer in ec2 to populate transitGatewayConnectPeerArn.</summary>
    [JsonPropertyName("transitGatewayConnectPeerArnSelector")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProviderTransitGatewayConnectPeerArnSelector? TransitGatewayConnectPeerArnSelector { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecInitProvider
{
    /// <summary>The ID of the device.</summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    /// <summary>Reference to a Device in networkmanager to populate deviceId.</summary>
    [JsonPropertyName("deviceIdRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdRef? DeviceIdRef { get; set; }

    /// <summary>Selector for a Device in networkmanager to populate deviceId.</summary>
    [JsonPropertyName("deviceIdSelector")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProviderDeviceIdSelector? DeviceIdSelector { get; set; }

    /// <summary>The ID of the link.</summary>
    [JsonPropertyName("linkId")]
    public string? LinkId { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecManagementPoliciesEnum
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

public enum V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayConnectPeerAssociationSpecDeletionPolicyEnum>))]
    public V1beta1TransitGatewayConnectPeerAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TransitGatewayConnectPeerAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewayConnectPeerAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationStatusAtProvider
{
    /// <summary>The ID of the device.</summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    /// <summary>The ID of the global network.</summary>
    [JsonPropertyName("globalNetworkId")]
    public string? GlobalNetworkId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the link.</summary>
    [JsonPropertyName("linkId")]
    public string? LinkId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Connect peer.</summary>
    [JsonPropertyName("transitGatewayConnectPeerArn")]
    public string? TransitGatewayConnectPeerArn { get; set; }
}

public partial class V1beta1TransitGatewayConnectPeerAssociationStatusConditions
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

public partial class V1beta1TransitGatewayConnectPeerAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayConnectPeerAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayConnectPeerAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayConnectPeerAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewayConnectPeerAssociationSpec>, IStatus<V1beta1TransitGatewayConnectPeerAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayConnectPeerAssociation";
    public const string KubeGroup = "networkmanager.aws.upbound.io";
    public const string KubePluralName = "transitgatewayconnectpeerassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewayConnectPeerAssociationSpec defines the desired state of TransitGatewayConnectPeerAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewayConnectPeerAssociationSpec Spec { get; set; }

    /// <summary>TransitGatewayConnectPeerAssociationStatus defines the observed state of TransitGatewayConnectPeerAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayConnectPeerAssociationStatus? Status { get; set; }
}