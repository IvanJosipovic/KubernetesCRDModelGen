using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devices.azure.upbound.io;
public enum V1beta1IOTHubFallbackRouteSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefsPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecForProvider
{
    /// <summary>The condition that is evaluated to apply the routing rule. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language. Defaults to true.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Used to specify whether the fallback route is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>References to IOTHubEndpointStorageContainer in devices to populate endpointNames.</summary>
    [JsonPropertyName("endpointNamesRefs")]
    public IList<V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesRefs>? EndpointNamesRefs { get; set; }

    /// <summary>Selector for a list of IOTHubEndpointStorageContainer in devices to populate endpointNames.</summary>
    [JsonPropertyName("endpointNamesSelector")]
    public V1beta1IOTHubFallbackRouteSpecForProviderEndpointNamesSelector? EndpointNamesSelector { get; set; }

    /// <summary>The name of the IoTHub to which this Fallback Route belongs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("iothubName")]
    public string? IothubName { get; set; }

    /// <summary>Reference to a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameRef")]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameRef? IothubNameRef { get; set; }

    /// <summary>Selector for a IOTHub in devices to populate iothubName.</summary>
    [JsonPropertyName("iothubNameSelector")]
    public V1beta1IOTHubFallbackRouteSpecForProviderIothubNameSelector? IothubNameSelector { get; set; }

    /// <summary>The name of the resource group under which the IotHub Storage Container Endpoint resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1IOTHubFallbackRouteSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The source that the routing rule is to be applied to. Possible values include: DeviceConnectionStateEvents, DeviceJobLifecycleEvents, DeviceLifecycleEvents, DeviceMessages, DigitalTwinChangeEvents, Invalid, TwinChangeEvents. Defaults to DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefsPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecInitProvider
{
    /// <summary>The condition that is evaluated to apply the routing rule. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language. Defaults to true.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Used to specify whether the fallback route is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>References to IOTHubEndpointStorageContainer in devices to populate endpointNames.</summary>
    [JsonPropertyName("endpointNamesRefs")]
    public IList<V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesRefs>? EndpointNamesRefs { get; set; }

    /// <summary>Selector for a list of IOTHubEndpointStorageContainer in devices to populate endpointNames.</summary>
    [JsonPropertyName("endpointNamesSelector")]
    public V1beta1IOTHubFallbackRouteSpecInitProviderEndpointNamesSelector? EndpointNamesSelector { get; set; }

    /// <summary>The source that the routing rule is to be applied to. Possible values include: DeviceConnectionStateEvents, DeviceJobLifecycleEvents, DeviceLifecycleEvents, DeviceMessages, DigitalTwinChangeEvents, Invalid, TwinChangeEvents. Defaults to DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecManagementPoliciesEnum
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

public enum V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IOTHubFallbackRouteSpecDeletionPolicyEnum>))]
    public V1beta1IOTHubFallbackRouteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IOTHubFallbackRouteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IOTHubFallbackRouteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IOTHubFallbackRouteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IOTHubFallbackRouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IOTHubFallbackRouteSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IOTHubFallbackRouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteStatusAtProvider
{
    /// <summary>The condition that is evaluated to apply the routing rule. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language. Defaults to true.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Used to specify whether the fallback route is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>The ID of the IoTHub Fallback Route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the IoTHub to which this Fallback Route belongs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("iothubName")]
    public string? IothubName { get; set; }

    /// <summary>The name of the resource group under which the IotHub Storage Container Endpoint resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The source that the routing rule is to be applied to. Possible values include: DeviceConnectionStateEvents, DeviceJobLifecycleEvents, DeviceLifecycleEvents, DeviceMessages, DigitalTwinChangeEvents, Invalid, TwinChangeEvents. Defaults to DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

public partial class V1beta1IOTHubFallbackRouteStatusConditions
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

public partial class V1beta1IOTHubFallbackRouteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IOTHubFallbackRouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IOTHubFallbackRouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTHubFallbackRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IOTHubFallbackRouteSpec>, IStatus<V1beta1IOTHubFallbackRouteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTHubFallbackRoute";
    public const string KubeGroup = "devices.azure.upbound.io";
    public const string KubePluralName = "iothubfallbackroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTHubFallbackRouteSpec defines the desired state of IOTHubFallbackRoute</summary>
    [JsonPropertyName("spec")]
    public V1beta1IOTHubFallbackRouteSpec Spec { get; set; }

    /// <summary>IOTHubFallbackRouteStatus defines the observed state of IOTHubFallbackRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta1IOTHubFallbackRouteStatus? Status { get; set; }
}