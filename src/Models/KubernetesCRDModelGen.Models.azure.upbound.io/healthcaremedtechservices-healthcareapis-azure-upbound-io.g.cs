using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcareapis.azure.upbound.io;
public enum V1beta1HealthcareMedtechServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Healthcare Med Tech Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Healthcare Med Tech Service. Possible values are SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1HealthcareMedtechServiceSpecForProvider
{
    /// <summary>Specifies the Device Mappings of the Med Tech Service.</summary>
    [JsonPropertyName("deviceMappingJson")]
    public string? DeviceMappingJson { get; set; }

    /// <summary>Specifies the Consumer Group of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubConsumerGroupName")]
    public string? EventhubConsumerGroupName { get; set; }

    /// <summary>Reference to a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
    [JsonPropertyName("eventhubConsumerGroupNameRef")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameRef? EventhubConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
    [JsonPropertyName("eventhubConsumerGroupNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubConsumerGroupNameSelector? EventhubConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the namespace name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameRef")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameRef? EventhubNamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecForProviderEventhubNamespaceNameSelector? EventhubNamespaceNameSelector { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareMedtechServiceSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare Med Tech Service should be created. Changing this forces a new Healthcare Med Tech Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare Med Tech Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the id of the Healthcare Workspace where the Healthcare Med Tech Service should exist. Changing this forces a new Healthcare Med Tech Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a HealthcareWorkspace in healthcareapis to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta1HealthcareMedtechServiceSpecForProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Healthcare Med Tech Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Healthcare Med Tech Service. Possible values are SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecInitProvider
{
    /// <summary>Specifies the Device Mappings of the Med Tech Service.</summary>
    [JsonPropertyName("deviceMappingJson")]
    public string? DeviceMappingJson { get; set; }

    /// <summary>Specifies the Consumer Group of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubConsumerGroupName")]
    public string? EventhubConsumerGroupName { get; set; }

    /// <summary>Reference to a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
    [JsonPropertyName("eventhubConsumerGroupNameRef")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameRef? EventhubConsumerGroupNameRef { get; set; }

    /// <summary>Selector for a ConsumerGroup in eventhub to populate eventhubConsumerGroupName.</summary>
    [JsonPropertyName("eventhubConsumerGroupNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubConsumerGroupNameSelector? EventhubConsumerGroupNameSelector { get; set; }

    /// <summary>Specifies the name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameRef")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameRef? EventhubNameRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventhubName.</summary>
    [JsonPropertyName("eventhubNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNameSelector? EventhubNameSelector { get; set; }

    /// <summary>Specifies the namespace name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameRef")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameRef? EventhubNamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate eventhubNamespaceName.</summary>
    [JsonPropertyName("eventhubNamespaceNameSelector")]
    public V1beta1HealthcareMedtechServiceSpecInitProviderEventhubNamespaceNameSelector? EventhubNamespaceNameSelector { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareMedtechServiceSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare Med Tech Service should be created. Changing this forces a new Healthcare Med Tech Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare Med Tech Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecManagementPoliciesEnum
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

public enum V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1HealthcareMedtechServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>HealthcareMedtechServiceSpec defines the desired state of HealthcareMedtechService</summary>
public partial class V1beta1HealthcareMedtechServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HealthcareMedtechServiceSpecDeletionPolicyEnum>))]
    public V1beta1HealthcareMedtechServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HealthcareMedtechServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HealthcareMedtechServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1HealthcareMedtechServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HealthcareMedtechServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1HealthcareMedtechServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HealthcareMedtechServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1HealthcareMedtechServiceStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Healthcare Med Tech Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Healthcare Med Tech Service. Possible values are SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1HealthcareMedtechServiceStatusAtProvider
{
    /// <summary>Specifies the Device Mappings of the Med Tech Service.</summary>
    [JsonPropertyName("deviceMappingJson")]
    public string? DeviceMappingJson { get; set; }

    /// <summary>Specifies the Consumer Group of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubConsumerGroupName")]
    public string? EventhubConsumerGroupName { get; set; }

    /// <summary>Specifies the name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Specifies the namespace name of the Event Hub to connect to.</summary>
    [JsonPropertyName("eventhubNamespaceName")]
    public string? EventhubNamespaceName { get; set; }

    /// <summary>The ID of the Healthcare Med Tech Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HealthcareMedtechServiceStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the Azure Region where the Healthcare Med Tech Service should be created. Changing this forces a new Healthcare Med Tech Service to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags to assign to the Healthcare Med Tech Service.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the id of the Healthcare Workspace where the Healthcare Med Tech Service should exist. Changing this forces a new Healthcare Med Tech Service to be created.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1HealthcareMedtechServiceStatusConditions
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

/// <summary>HealthcareMedtechServiceStatus defines the observed state of HealthcareMedtechService.</summary>
public partial class V1beta1HealthcareMedtechServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HealthcareMedtechServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HealthcareMedtechServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>HealthcareMedtechService is the Schema for the HealthcareMedtechServices API. Manages a Healthcare MedTech (Internet of Medical Things) devices Service.</summary>
public partial class V1beta1HealthcareMedtechService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HealthcareMedtechServiceSpec>, IStatus<V1beta1HealthcareMedtechServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HealthcareMedtechService";
    public const string KubeGroup = "healthcareapis.azure.upbound.io";
    public const string KubePluralName = "healthcaremedtechservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HealthcareMedtechServiceSpec defines the desired state of HealthcareMedtechService</summary>
    [JsonPropertyName("spec")]
    public V1beta1HealthcareMedtechServiceSpec Spec { get; set; }

    /// <summary>HealthcareMedtechServiceStatus defines the observed state of HealthcareMedtechService.</summary>
    [JsonPropertyName("status")]
    public V1beta1HealthcareMedtechServiceStatus? Status { get; set; }
}