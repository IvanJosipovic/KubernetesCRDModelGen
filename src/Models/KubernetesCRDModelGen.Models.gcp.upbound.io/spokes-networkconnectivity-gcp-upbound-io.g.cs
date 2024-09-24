using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkconnectivity.gcp.upbound.io;
public enum V1beta1SpokeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SpokeSpecForProviderHubRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderHubRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecForProviderHubRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderHubRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderHubRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderHubRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderHubRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Hub in networkconnectivity to populate hub.</summary>
public partial class V1beta1SpokeSpecForProviderHubRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderHubRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecForProviderHubSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderHubSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecForProviderHubSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderHubSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderHubSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderHubSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderHubSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Hub in networkconnectivity to populate hub.</summary>
public partial class V1beta1SpokeSpecForProviderHubSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderHubSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProviderLinkedInterconnectAttachments
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked interconnect attachment resources</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

public enum V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate virtualMachine.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate virtualMachine.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstances
{
    /// <summary>The IP address on the VM to use for peering.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The URI of the virtual machine resource</summary>
    [JsonPropertyName("virtualMachine")]
    public string? VirtualMachine { get; set; }

    /// <summary>Reference to a Instance in compute to populate virtualMachine.</summary>
    [JsonPropertyName("virtualMachineRef")]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRef? VirtualMachineRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate virtualMachine.</summary>
    [JsonPropertyName("virtualMachineSelector")]
    public V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelector? VirtualMachineSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProviderLinkedRouterApplianceInstances
{
    /// <summary>The list of router appliance instances</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstancesInstances>? Instances { get; set; }

    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }
}

public enum V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate uri.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate uri.</summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpcNetwork
{
    /// <summary>IP ranges encompassing the subnets to be excluded from peering.</summary>
    [JsonPropertyName("excludeExportRanges")]
    public IList<string>? ExcludeExportRanges { get; set; }

    /// <summary>The URI of the VPC network resource.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference to a Network in compute to populate uri.</summary>
    [JsonPropertyName("uriRef")]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriRef? UriRef { get; set; }

    /// <summary>Selector for a Network in compute to populate uri.</summary>
    [JsonPropertyName("uriSelector")]
    public V1beta1SpokeSpecForProviderLinkedVpcNetworkUriSelector? UriSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProviderLinkedVpnTunnels
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecForProvider
{
    /// <summary>An optional description of the spoke.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The URI of the hub that this spoke is attached to.</summary>
    [JsonPropertyName("hub")]
    public string? Hub { get; set; }

    /// <summary>Reference to a Hub in networkconnectivity to populate hub.</summary>
    [JsonPropertyName("hubRef")]
    public V1beta1SpokeSpecForProviderHubRef? HubRef { get; set; }

    /// <summary>Selector for a Hub in networkconnectivity to populate hub.</summary>
    [JsonPropertyName("hubSelector")]
    public V1beta1SpokeSpecForProviderHubSelector? HubSelector { get; set; }

    /// <summary>Optional labels in key:value format. For more information about labels, see Requirements for labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A collection of VLAN attachment resources. These resources should be redundant attachments that all advertise the same prefixes to Google Cloud. Alternatively, in active/passive configurations, all attachments should be capable of advertising the same prefixes.</summary>
    [JsonPropertyName("linkedInterconnectAttachments")]
    public IList<V1beta1SpokeSpecForProviderLinkedInterconnectAttachments>? LinkedInterconnectAttachments { get; set; }

    /// <summary>The URIs of linked Router appliance resources</summary>
    [JsonPropertyName("linkedRouterApplianceInstances")]
    public IList<V1beta1SpokeSpecForProviderLinkedRouterApplianceInstances>? LinkedRouterApplianceInstances { get; set; }

    /// <summary>VPC network that is associated with the spoke.</summary>
    [JsonPropertyName("linkedVpcNetwork")]
    public IList<V1beta1SpokeSpecForProviderLinkedVpcNetwork>? LinkedVpcNetwork { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources</summary>
    [JsonPropertyName("linkedVpnTunnels")]
    public IList<V1beta1SpokeSpecForProviderLinkedVpnTunnels>? LinkedVpnTunnels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The name of the spoke. Spoke names must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1SpokeSpecInitProviderHubRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderHubRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecInitProviderHubRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderHubRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderHubRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderHubRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderHubRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Hub in networkconnectivity to populate hub.</summary>
public partial class V1beta1SpokeSpecInitProviderHubRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderHubRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecInitProviderHubSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderHubSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecInitProviderHubSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderHubSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderHubSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderHubSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderHubSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Hub in networkconnectivity to populate hub.</summary>
public partial class V1beta1SpokeSpecInitProviderHubSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderHubSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecInitProviderLinkedInterconnectAttachments
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked interconnect attachment resources</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

public enum V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate virtualMachine.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate virtualMachine.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstances
{
    /// <summary>The IP address on the VM to use for peering.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The URI of the virtual machine resource</summary>
    [JsonPropertyName("virtualMachine")]
    public string? VirtualMachine { get; set; }

    /// <summary>Reference to a Instance in compute to populate virtualMachine.</summary>
    [JsonPropertyName("virtualMachineRef")]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineRef? VirtualMachineRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate virtualMachine.</summary>
    [JsonPropertyName("virtualMachineSelector")]
    public V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstancesVirtualMachineSelector? VirtualMachineSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstances
{
    /// <summary>The list of router appliance instances</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstancesInstances>? Instances { get; set; }

    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }
}

public enum V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate uri.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum>))]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate uri.</summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpcNetwork
{
    /// <summary>IP ranges encompassing the subnets to be excluded from peering.</summary>
    [JsonPropertyName("excludeExportRanges")]
    public IList<string>? ExcludeExportRanges { get; set; }

    /// <summary>The URI of the VPC network resource.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference to a Network in compute to populate uri.</summary>
    [JsonPropertyName("uriRef")]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriRef? UriRef { get; set; }

    /// <summary>Selector for a Network in compute to populate uri.</summary>
    [JsonPropertyName("uriSelector")]
    public V1beta1SpokeSpecInitProviderLinkedVpcNetworkUriSelector? UriSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeSpecInitProviderLinkedVpnTunnels
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1SpokeSpecInitProvider
{
    /// <summary>An optional description of the spoke.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The URI of the hub that this spoke is attached to.</summary>
    [JsonPropertyName("hub")]
    public string? Hub { get; set; }

    /// <summary>Reference to a Hub in networkconnectivity to populate hub.</summary>
    [JsonPropertyName("hubRef")]
    public V1beta1SpokeSpecInitProviderHubRef? HubRef { get; set; }

    /// <summary>Selector for a Hub in networkconnectivity to populate hub.</summary>
    [JsonPropertyName("hubSelector")]
    public V1beta1SpokeSpecInitProviderHubSelector? HubSelector { get; set; }

    /// <summary>Optional labels in key:value format. For more information about labels, see Requirements for labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A collection of VLAN attachment resources. These resources should be redundant attachments that all advertise the same prefixes to Google Cloud. Alternatively, in active/passive configurations, all attachments should be capable of advertising the same prefixes.</summary>
    [JsonPropertyName("linkedInterconnectAttachments")]
    public IList<V1beta1SpokeSpecInitProviderLinkedInterconnectAttachments>? LinkedInterconnectAttachments { get; set; }

    /// <summary>The URIs of linked Router appliance resources</summary>
    [JsonPropertyName("linkedRouterApplianceInstances")]
    public IList<V1beta1SpokeSpecInitProviderLinkedRouterApplianceInstances>? LinkedRouterApplianceInstances { get; set; }

    /// <summary>VPC network that is associated with the spoke.</summary>
    [JsonPropertyName("linkedVpcNetwork")]
    public IList<V1beta1SpokeSpecInitProviderLinkedVpcNetwork>? LinkedVpcNetwork { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources</summary>
    [JsonPropertyName("linkedVpnTunnels")]
    public IList<V1beta1SpokeSpecInitProviderLinkedVpnTunnels>? LinkedVpnTunnels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The name of the spoke. Spoke names must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1SpokeSpecManagementPoliciesEnum
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

public enum V1beta1SpokeSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1SpokeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1SpokeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpokeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1SpokeSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SpokeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpokeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpokeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1SpokeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpokeSpec defines the desired state of Spoke</summary>
public partial class V1beta1SpokeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpokeSpecDeletionPolicyEnum>))]
    public V1beta1SpokeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpokeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpokeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpokeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpokeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpokeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpokeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProviderLinkedInterconnectAttachments
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked interconnect attachment resources</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProviderLinkedRouterApplianceInstancesInstances
{
    /// <summary>The IP address on the VM to use for peering.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The URI of the virtual machine resource</summary>
    [JsonPropertyName("virtualMachine")]
    public string? VirtualMachine { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProviderLinkedRouterApplianceInstances
{
    /// <summary>The list of router appliance instances</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1SpokeStatusAtProviderLinkedRouterApplianceInstancesInstances>? Instances { get; set; }

    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProviderLinkedVpcNetwork
{
    /// <summary>IP ranges encompassing the subnets to be excluded from peering.</summary>
    [JsonPropertyName("excludeExportRanges")]
    public IList<string>? ExcludeExportRanges { get; set; }

    /// <summary>The URI of the VPC network resource.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProviderLinkedVpnTunnels
{
    /// <summary>A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.</summary>
    [JsonPropertyName("siteToSiteDataTransfer")]
    public bool? SiteToSiteDataTransfer { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary></summary>
public partial class V1beta1SpokeStatusAtProvider
{
    /// <summary>Output only. The time the spoke was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>An optional description of the spoke.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Immutable. The URI of the hub that this spoke is attached to.</summary>
    [JsonPropertyName("hub")]
    public string? Hub { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/spokes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional labels in key:value format. For more information about labels, see Requirements for labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>A collection of VLAN attachment resources. These resources should be redundant attachments that all advertise the same prefixes to Google Cloud. Alternatively, in active/passive configurations, all attachments should be capable of advertising the same prefixes.</summary>
    [JsonPropertyName("linkedInterconnectAttachments")]
    public IList<V1beta1SpokeStatusAtProviderLinkedInterconnectAttachments>? LinkedInterconnectAttachments { get; set; }

    /// <summary>The URIs of linked Router appliance resources</summary>
    [JsonPropertyName("linkedRouterApplianceInstances")]
    public IList<V1beta1SpokeStatusAtProviderLinkedRouterApplianceInstances>? LinkedRouterApplianceInstances { get; set; }

    /// <summary>VPC network that is associated with the spoke.</summary>
    [JsonPropertyName("linkedVpcNetwork")]
    public IList<V1beta1SpokeStatusAtProviderLinkedVpcNetwork>? LinkedVpcNetwork { get; set; }

    /// <summary>The URIs of linked VPN tunnel resources</summary>
    [JsonPropertyName("linkedVpnTunnels")]
    public IList<V1beta1SpokeStatusAtProviderLinkedVpnTunnels>? LinkedVpnTunnels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The name of the spoke. Spoke names must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. The current lifecycle state of this spoke. Possible values: STATE_UNSPECIFIED, CREATING, ACTIVE, DELETING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. The Google-generated UUID for the spoke. This value is unique across all spoke resources. If a spoke is deleted and another with the same name is created, the new spoke is assigned a different unique_id.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Output only. The time the spoke was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1SpokeStatusConditions
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

/// <summary>SpokeStatus defines the observed state of Spoke.</summary>
public partial class V1beta1SpokeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpokeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpokeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Spoke is the Schema for the Spokes API. The NetworkConnectivity Spoke resource</summary>
public partial class V1beta1Spoke : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpokeSpec>, IStatus<V1beta1SpokeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Spoke";
    public const string KubeGroup = "networkconnectivity.gcp.upbound.io";
    public const string KubePluralName = "spokes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpokeSpec defines the desired state of Spoke</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpokeSpec Spec { get; set; }

    /// <summary>SpokeStatus defines the observed state of Spoke.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpokeStatus? Status { get; set; }
}