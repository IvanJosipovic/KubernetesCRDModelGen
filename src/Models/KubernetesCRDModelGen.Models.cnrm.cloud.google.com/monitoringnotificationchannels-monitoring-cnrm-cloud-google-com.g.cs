using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.cnrm.cloud.google.com;
/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthTokenValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthTokenValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthTokenValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>An authorization token for a notification channel. Channel types that support this field include: slack.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthToken
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthTokenValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Different notification type behaviors are configured primarily using the the 'labels' field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the 'labels' map in the api request.  Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state.</summary>
public partial class V1beta1MonitoringNotificationChannelSpecSensitiveLabels
{
    /// <summary>An authorization token for a notification channel. Channel types that support this field include: slack.</summary>
    [JsonPropertyName("authToken")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsAuthToken? AuthToken { get; set; }

    /// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth.</summary>
    [JsonPropertyName("password")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsPassword? Password { get; set; }

    /// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty.</summary>
    [JsonPropertyName("serviceKey")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabelsServiceKey? ServiceKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1MonitoringNotificationChannelSpec
{
    /// <summary>An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, the notification channel will be deleted regardless of its use in alert policies (the policies will be updated to remove the channel). If false, channels that are still referenced by an existing alerting policy will fail to be deleted in a delete operation.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Different notification type behaviors are configured primarily using the the 'labels' field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the 'labels' map in the api request.  Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state.</summary>
    [JsonPropertyName("sensitiveLabels")]
    public V1beta1MonitoringNotificationChannelSpecSensitiveLabels? SensitiveLabels { get; set; }

    /// <summary>The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as "email", "slack", etc...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1MonitoringNotificationChannelStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1MonitoringNotificationChannelStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitoringNotificationChannelStatusConditions>? Conditions { get; set; }

    /// <summary>The full REST resource name for this channel. The syntax is: projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID] The [CHANNEL_ID] is automatically assigned by the server on creation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.</summary>
    [JsonPropertyName("verificationStatus")]
    public string? VerificationStatus { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1MonitoringNotificationChannel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitoringNotificationChannelSpec>, IStatus<V1beta1MonitoringNotificationChannelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitoringNotificationChannel";
    public const string KubeGroup = "monitoring.cnrm.cloud.google.com";
    public const string KubePluralName = "monitoringnotificationchannels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitoringNotificationChannelSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1MonitoringNotificationChannelStatus? Status { get; set; }
}