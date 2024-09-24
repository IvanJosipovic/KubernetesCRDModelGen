using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cache.azure.upbound.io;
public enum V1beta1RedisLinkedServerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecForProvider
{
    /// <summary>The ID of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheId")]
    public string? LinkedRedisCacheId { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate linkedRedisCacheId.</summary>
    [JsonPropertyName("linkedRedisCacheIdRef")]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdRef? LinkedRedisCacheIdRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate linkedRedisCacheId.</summary>
    [JsonPropertyName("linkedRedisCacheIdSelector")]
    public V1beta1RedisLinkedServerSpecForProviderLinkedRedisCacheIdSelector? LinkedRedisCacheIdSelector { get; set; }

    /// <summary>The location of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheLocation")]
    public string? LinkedRedisCacheLocation { get; set; }

    /// <summary>The name of the Resource Group where the Redis caches exists. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1RedisLinkedServerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The role of the linked Redis cache (eg "Secondary"). Changing this forces a new Redis to be created. Possible values are Primary and Secondary.</summary>
    [JsonPropertyName("serverRole")]
    public string? ServerRole { get; set; }

    /// <summary>The name of Redis cache to link with. Changing this forces a new Redis to be created. (eg The primary role)</summary>
    [JsonPropertyName("targetRedisCacheName")]
    public string? TargetRedisCacheName { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate targetRedisCacheName.</summary>
    [JsonPropertyName("targetRedisCacheNameRef")]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameRef? TargetRedisCacheNameRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate targetRedisCacheName.</summary>
    [JsonPropertyName("targetRedisCacheNameSelector")]
    public V1beta1RedisLinkedServerSpecForProviderTargetRedisCacheNameSelector? TargetRedisCacheNameSelector { get; set; }
}

public enum V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecInitProvider
{
    /// <summary>The ID of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheId")]
    public string? LinkedRedisCacheId { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate linkedRedisCacheId.</summary>
    [JsonPropertyName("linkedRedisCacheIdRef")]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdRef? LinkedRedisCacheIdRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate linkedRedisCacheId.</summary>
    [JsonPropertyName("linkedRedisCacheIdSelector")]
    public V1beta1RedisLinkedServerSpecInitProviderLinkedRedisCacheIdSelector? LinkedRedisCacheIdSelector { get; set; }

    /// <summary>The location of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheLocation")]
    public string? LinkedRedisCacheLocation { get; set; }

    /// <summary>The role of the linked Redis cache (eg "Secondary"). Changing this forces a new Redis to be created. Possible values are Primary and Secondary.</summary>
    [JsonPropertyName("serverRole")]
    public string? ServerRole { get; set; }
}

public enum V1beta1RedisLinkedServerSpecManagementPoliciesEnum
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

public enum V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1RedisLinkedServerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1RedisLinkedServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1RedisLinkedServerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisLinkedServerSpecDeletionPolicyEnum>))]
    public V1beta1RedisLinkedServerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RedisLinkedServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RedisLinkedServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RedisLinkedServerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RedisLinkedServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RedisLinkedServerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RedisLinkedServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1RedisLinkedServerStatusAtProvider
{
    /// <summary>The geo-replicated primary hostname for this linked server.</summary>
    [JsonPropertyName("geoReplicatedPrimaryHostName")]
    public string? GeoReplicatedPrimaryHostName { get; set; }

    /// <summary>The ID of the Redis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheId")]
    public string? LinkedRedisCacheId { get; set; }

    /// <summary>The location of the linked Redis cache. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("linkedRedisCacheLocation")]
    public string? LinkedRedisCacheLocation { get; set; }

    /// <summary>The name of the linked server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the Resource Group where the Redis caches exists. Changing this forces a new Redis to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The role of the linked Redis cache (eg "Secondary"). Changing this forces a new Redis to be created. Possible values are Primary and Secondary.</summary>
    [JsonPropertyName("serverRole")]
    public string? ServerRole { get; set; }

    /// <summary>The name of Redis cache to link with. Changing this forces a new Redis to be created. (eg The primary role)</summary>
    [JsonPropertyName("targetRedisCacheName")]
    public string? TargetRedisCacheName { get; set; }
}

public partial class V1beta1RedisLinkedServerStatusConditions
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

public partial class V1beta1RedisLinkedServerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RedisLinkedServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RedisLinkedServerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisLinkedServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RedisLinkedServerSpec>, IStatus<V1beta1RedisLinkedServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisLinkedServer";
    public const string KubeGroup = "cache.azure.upbound.io";
    public const string KubePluralName = "redislinkedservers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RedisLinkedServerSpec defines the desired state of RedisLinkedServer</summary>
    [JsonPropertyName("spec")]
    public V1beta1RedisLinkedServerSpec Spec { get; set; }

    /// <summary>RedisLinkedServerStatus defines the observed state of RedisLinkedServer.</summary>
    [JsonPropertyName("status")]
    public V1beta1RedisLinkedServerStatus? Status { get; set; }
}