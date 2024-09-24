using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1TransitGatewayMulticastGroupSourceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecForProvider
{
    /// <summary>The IP address assigned to the transit gateway multicast group.</summary>
    [JsonPropertyName("groupIpAddress")]
    public string? GroupIpAddress { get; set; }

    /// <summary>The group members' network interface ID to register with the transit gateway multicast group.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ID of the transit gateway multicast domain.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainId")]
    public string? TransitGatewayMulticastDomainId { get; set; }

    /// <summary>Reference to a TransitGatewayMulticastDomain in ec2 to populate transitGatewayMulticastDomainId.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainIdRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdRef? TransitGatewayMulticastDomainIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayMulticastDomain in ec2 to populate transitGatewayMulticastDomainId.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainIdSelector")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProviderTransitGatewayMulticastDomainIdSelector? TransitGatewayMulticastDomainIdSelector { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecInitProvider
{
    /// <summary>The IP address assigned to the transit gateway multicast group.</summary>
    [JsonPropertyName("groupIpAddress")]
    public string? GroupIpAddress { get; set; }

    /// <summary>The group members' network interface ID to register with the transit gateway multicast group.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>The ID of the transit gateway multicast domain.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainId")]
    public string? TransitGatewayMulticastDomainId { get; set; }

    /// <summary>Reference to a TransitGatewayMulticastDomain in ec2 to populate transitGatewayMulticastDomainId.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainIdRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdRef? TransitGatewayMulticastDomainIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayMulticastDomain in ec2 to populate transitGatewayMulticastDomainId.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainIdSelector")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProviderTransitGatewayMulticastDomainIdSelector? TransitGatewayMulticastDomainIdSelector { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecManagementPoliciesEnum
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

public enum V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayMulticastGroupSourceSpecDeletionPolicyEnum>))]
    public V1beta1TransitGatewayMulticastGroupSourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TransitGatewayMulticastGroupSourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewayMulticastGroupSourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceStatusAtProvider
{
    /// <summary>The IP address assigned to the transit gateway multicast group.</summary>
    [JsonPropertyName("groupIpAddress")]
    public string? GroupIpAddress { get; set; }

    /// <summary>EC2 Transit Gateway Multicast Group Member identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The group members' network interface ID to register with the transit gateway multicast group.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>The ID of the transit gateway multicast domain.</summary>
    [JsonPropertyName("transitGatewayMulticastDomainId")]
    public string? TransitGatewayMulticastDomainId { get; set; }
}

public partial class V1beta1TransitGatewayMulticastGroupSourceStatusConditions
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

public partial class V1beta1TransitGatewayMulticastGroupSourceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayMulticastGroupSourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayMulticastGroupSourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayMulticastGroupSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewayMulticastGroupSourceSpec>, IStatus<V1beta1TransitGatewayMulticastGroupSourceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayMulticastGroupSource";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "transitgatewaymulticastgroupsources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewayMulticastGroupSourceSpec defines the desired state of TransitGatewayMulticastGroupSource</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewayMulticastGroupSourceSpec Spec { get; set; }

    /// <summary>TransitGatewayMulticastGroupSourceStatus defines the observed state of TransitGatewayMulticastGroupSource.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayMulticastGroupSourceStatus? Status { get; set; }
}