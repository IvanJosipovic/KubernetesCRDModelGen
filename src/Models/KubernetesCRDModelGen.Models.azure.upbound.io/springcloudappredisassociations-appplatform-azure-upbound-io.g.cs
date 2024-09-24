using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
public enum V1beta1SpringCloudAppRedisAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecForProvider
{
    /// <summary>Specifies the Redis Cache access key.</summary>
    [JsonPropertyName("redisAccessKey")]
    public string? RedisAccessKey { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate redisAccessKey.</summary>
    [JsonPropertyName("redisAccessKeyRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeyRef? RedisAccessKeyRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate redisAccessKey.</summary>
    [JsonPropertyName("redisAccessKeySelector")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisAccessKeySelector? RedisAccessKeySelector { get; set; }

    /// <summary>Specifies the Redis Cache resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("redisCacheId")]
    public string? RedisCacheId { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate redisCacheId.</summary>
    [JsonPropertyName("redisCacheIdRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdRef? RedisCacheIdRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate redisCacheId.</summary>
    [JsonPropertyName("redisCacheIdSelector")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderRedisCacheIdSelector? RedisCacheIdSelector { get; set; }

    /// <summary>Specifies the Spring Cloud Application resource ID in which the Association is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdRef? SpringCloudAppIdRef { get; set; }

    /// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdSelector")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProviderSpringCloudAppIdSelector? SpringCloudAppIdSelector { get; set; }

    /// <summary>Should SSL be used when connecting to Redis? Defaults to true.</summary>
    [JsonPropertyName("sslEnabled")]
    public bool? SslEnabled { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelectorPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecInitProvider
{
    /// <summary>Specifies the Redis Cache access key.</summary>
    [JsonPropertyName("redisAccessKey")]
    public string? RedisAccessKey { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate redisAccessKey.</summary>
    [JsonPropertyName("redisAccessKeyRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeyRef? RedisAccessKeyRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate redisAccessKey.</summary>
    [JsonPropertyName("redisAccessKeySelector")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisAccessKeySelector? RedisAccessKeySelector { get; set; }

    /// <summary>Specifies the Redis Cache resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("redisCacheId")]
    public string? RedisCacheId { get; set; }

    /// <summary>Reference to a RedisCache in cache to populate redisCacheId.</summary>
    [JsonPropertyName("redisCacheIdRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdRef? RedisCacheIdRef { get; set; }

    /// <summary>Selector for a RedisCache in cache to populate redisCacheId.</summary>
    [JsonPropertyName("redisCacheIdSelector")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProviderRedisCacheIdSelector? RedisCacheIdSelector { get; set; }

    /// <summary>Should SSL be used when connecting to Redis? Defaults to true.</summary>
    [JsonPropertyName("sslEnabled")]
    public bool? SslEnabled { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecManagementPoliciesEnum
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

public enum V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAppRedisAssociationSpecDeletionPolicyEnum>))]
    public V1beta1SpringCloudAppRedisAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudAppRedisAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudAppRedisAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudAppRedisAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpringCloudAppRedisAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudAppRedisAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationStatusAtProvider
{
    /// <summary>The ID of the Spring Cloud Application Redis Association.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Redis Cache access key.</summary>
    [JsonPropertyName("redisAccessKey")]
    public string? RedisAccessKey { get; set; }

    /// <summary>Specifies the Redis Cache resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("redisCacheId")]
    public string? RedisCacheId { get; set; }

    /// <summary>Specifies the Spring Cloud Application resource ID in which the Association is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Should SSL be used when connecting to Redis? Defaults to true.</summary>
    [JsonPropertyName("sslEnabled")]
    public bool? SslEnabled { get; set; }
}

public partial class V1beta1SpringCloudAppRedisAssociationStatusConditions
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

public partial class V1beta1SpringCloudAppRedisAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudAppRedisAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudAppRedisAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudAppRedisAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudAppRedisAssociationSpec>, IStatus<V1beta1SpringCloudAppRedisAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAppRedisAssociation";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudappredisassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudAppRedisAssociationSpec defines the desired state of SpringCloudAppRedisAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudAppRedisAssociationSpec Spec { get; set; }

    /// <summary>SpringCloudAppRedisAssociationStatus defines the observed state of SpringCloudAppRedisAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudAppRedisAssociationStatus? Status { get; set; }
}