using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codestarnotifications.aws.upbound.io;
public enum V1beta1NotificationRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecForProviderResourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecForProviderResourceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProviderResourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecForProviderResourceRefPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecForProviderResourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecForProviderResourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProviderResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecForProviderResourceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProviderTargetAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecForProviderTargetAddressRefPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProviderTargetAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecForProviderTargetAddressSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProviderTarget
{
    /// <summary>The ARN of notification rule target. For example, a SNS Topic ARN.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Reference to a Topic in sns to populate address.</summary>
    [JsonPropertyName("addressRef")]
    public V1beta1NotificationRuleSpecForProviderTargetAddressRef? AddressRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate address.</summary>
    [JsonPropertyName("addressSelector")]
    public V1beta1NotificationRuleSpecForProviderTargetAddressSelector? AddressSelector { get; set; }

    /// <summary>The type of the notification target. Default value is SNS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1NotificationRuleSpecForProvider
{
    /// <summary>The level of detail to include in the notifications for this resource. Possible values are BASIC and FULL.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>A list of event types associated with this notification rule. For list of allowed events see here.</summary>
    [JsonPropertyName("eventTypeIds")]
    public IList<string>? EventTypeIds { get; set; }

    /// <summary>The name of notification rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ARN of the resource to associate with the notification rule.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Reference to a Repository in codecommit to populate resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1NotificationRuleSpecForProviderResourceRef? ResourceRef { get; set; }

    /// <summary>Selector for a Repository in codecommit to populate resource.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1NotificationRuleSpecForProviderResourceSelector? ResourceSelector { get; set; }

    /// <summary>The status of the notification rule. Possible values are ENABLED and DISABLED, default is ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration blocks containing notification target information. Can be specified multiple times. At least one target must be specified on creation.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1NotificationRuleSpecForProviderTarget>? Target { get; set; }
}

public enum V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecInitProviderResourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecInitProviderResourceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProviderResourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecInitProviderResourceRefPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProviderResourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecInitProviderResourceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProviderTargetAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressRefPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProviderTargetAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProviderTarget
{
    /// <summary>The ARN of notification rule target. For example, a SNS Topic ARN.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Reference to a Topic in sns to populate address.</summary>
    [JsonPropertyName("addressRef")]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressRef? AddressRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate address.</summary>
    [JsonPropertyName("addressSelector")]
    public V1beta1NotificationRuleSpecInitProviderTargetAddressSelector? AddressSelector { get; set; }

    /// <summary>The type of the notification target. Default value is SNS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1NotificationRuleSpecInitProvider
{
    /// <summary>The level of detail to include in the notifications for this resource. Possible values are BASIC and FULL.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>A list of event types associated with this notification rule. For list of allowed events see here.</summary>
    [JsonPropertyName("eventTypeIds")]
    public IList<string>? EventTypeIds { get; set; }

    /// <summary>The name of notification rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the resource to associate with the notification rule.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Reference to a Repository in codecommit to populate resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1NotificationRuleSpecInitProviderResourceRef? ResourceRef { get; set; }

    /// <summary>Selector for a Repository in codecommit to populate resource.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1beta1NotificationRuleSpecInitProviderResourceSelector? ResourceSelector { get; set; }

    /// <summary>The status of the notification rule. Possible values are ENABLED and DISABLED, default is ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration blocks containing notification target information. Can be specified multiple times. At least one target must be specified on creation.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1NotificationRuleSpecInitProviderTarget>? Target { get; set; }
}

public enum V1beta1NotificationRuleSpecManagementPoliciesEnum
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

public enum V1beta1NotificationRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1NotificationRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1NotificationRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1NotificationRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1NotificationRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NotificationRuleSpecDeletionPolicyEnum>))]
    public V1beta1NotificationRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NotificationRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NotificationRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NotificationRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NotificationRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NotificationRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NotificationRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1NotificationRuleStatusAtProviderTarget
{
    /// <summary>The ARN of notification rule target. For example, a SNS Topic ARN.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The status of the notification rule. Possible values are ENABLED and DISABLED, default is ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The type of the notification target. Default value is SNS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1NotificationRuleStatusAtProvider
{
    /// <summary>The codestar notification rule ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The level of detail to include in the notifications for this resource. Possible values are BASIC and FULL.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>A list of event types associated with this notification rule. For list of allowed events see here.</summary>
    [JsonPropertyName("eventTypeIds")]
    public IList<string>? EventTypeIds { get; set; }

    /// <summary>The codestar notification rule ARN.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of notification rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the resource to associate with the notification rule.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>The status of the notification rule. Possible values are ENABLED and DISABLED, default is ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration blocks containing notification target information. Can be specified multiple times. At least one target must be specified on creation.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1NotificationRuleStatusAtProviderTarget>? Target { get; set; }
}

public partial class V1beta1NotificationRuleStatusConditions
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

public partial class V1beta1NotificationRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NotificationRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NotificationRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotificationRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NotificationRuleSpec>, IStatus<V1beta1NotificationRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotificationRule";
    public const string KubeGroup = "codestarnotifications.aws.upbound.io";
    public const string KubePluralName = "notificationrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotificationRuleSpec defines the desired state of NotificationRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1NotificationRuleSpec Spec { get; set; }

    /// <summary>NotificationRuleStatus defines the observed state of NotificationRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1NotificationRuleStatus? Status { get; set; }
}