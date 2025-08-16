using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.m.upbound.io;
/// <summary>NotificationChannel is the Schema for the NotificationChannels API. A NotificationChannel is a medium through which an alert is delivered when a policy violation is detected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotificationChannelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NotificationChannel>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotificationChannelList";
    public const string KubeGroup = "monitoring.gcp.m.upbound.io";
    public const string KubePluralName = "notificationchannels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1NotificationChannel> Items { get; set; }
}

/// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecForProviderSensitiveLabelsAuthTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecForProviderSensitiveLabelsPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecForProviderSensitiveLabelsServiceKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecForProviderSensitiveLabels
{
    /// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("authTokenSecretRef")]
    public V1beta1NotificationChannelSpecForProviderSensitiveLabelsAuthTokenSecretRef? AuthTokenSecretRef { get; set; }

    /// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1NotificationChannelSpecForProviderSensitiveLabelsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("serviceKeySecretRef")]
    public V1beta1NotificationChannelSpecForProviderSensitiveLabelsServiceKeySecretRef? ServiceKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecForProvider
{
    /// <summary>An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, the notification channel will be deleted regardless of its use in alert policies (the policies will be updated to remove the channel). If false, channels that are still referenced by an existing alerting policy will fail to be deleted in a delete operation.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Configuration fields that define the channel and its behavior. The permissible and required labels are specified in the NotificationChannelDescriptor corresponding to the type field. They can also be configured via the sensitive_labels block, but cannot be configured in both places.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
    [JsonPropertyName("sensitiveLabels")]
    public V1beta1NotificationChannelSpecForProviderSensitiveLabels? SensitiveLabels { get; set; }

    /// <summary>The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as "email", "slack", etc...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor's schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecInitProviderSensitiveLabelsAuthTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecInitProviderSensitiveLabelsPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecInitProviderSensitiveLabelsServiceKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecInitProviderSensitiveLabels
{
    /// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("authTokenSecretRef")]
    public V1beta1NotificationChannelSpecInitProviderSensitiveLabelsAuthTokenSecretRef? AuthTokenSecretRef { get; set; }

    /// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1NotificationChannelSpecInitProviderSensitiveLabelsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("serviceKeySecretRef")]
    public V1beta1NotificationChannelSpecInitProviderSensitiveLabelsServiceKeySecretRef? ServiceKeySecretRef { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecInitProvider
{
    /// <summary>An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, the notification channel will be deleted regardless of its use in alert policies (the policies will be updated to remove the channel). If false, channels that are still referenced by an existing alerting policy will fail to be deleted in a delete operation.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Configuration fields that define the channel and its behavior. The permissible and required labels are specified in the NotificationChannelDescriptor corresponding to the type field. They can also be configured via the sensitive_labels block, but cannot be configured in both places.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
    [JsonPropertyName("sensitiveLabels")]
    public V1beta1NotificationChannelSpecInitProviderSensitiveLabels? SensitiveLabels { get; set; }

    /// <summary>The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as "email", "slack", etc...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor's schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NotificationChannelSpec defines the desired state of NotificationChannel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NotificationChannelSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NotificationChannelSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NotificationChannelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NotificationChannelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusAtProviderSensitiveLabelsAuthTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusAtProviderSensitiveLabelsPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusAtProviderSensitiveLabelsServiceKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusAtProviderSensitiveLabels
{
    /// <summary>An authorization token for a notification channel. Channel types that support this field include: slack Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("authTokenSecretRef")]
    public V1beta1NotificationChannelStatusAtProviderSensitiveLabelsAuthTokenSecretRef? AuthTokenSecretRef { get; set; }

    /// <summary>An password for a notification channel. Channel types that support this field include: webhook_basicauth Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1NotificationChannelStatusAtProviderSensitiveLabelsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An servicekey token for a notification channel. Channel types that support this field include: pagerduty Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("serviceKeySecretRef")]
    public V1beta1NotificationChannelStatusAtProviderSensitiveLabelsServiceKeySecretRef? ServiceKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusAtProvider
{
    /// <summary>An optional human-readable description of this notification channel. This description may provide additional details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An optional human-readable name for this notification channel. It is recommended that you specify a non-empty and unique name in order to make it easier to identify the channels in your project, though this is not enforced. The display name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of notifications to a particular channel without removing the channel from all alerting policies that reference the channel. This is a more convenient approach when the change is temporary and you want to receive notifications from the same set of alerting policies on the channel at some point in the future.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, the notification channel will be deleted regardless of its use in alert policies (the policies will be updated to remove the channel). If false, channels that are still referenced by an existing alerting policy will fail to be deleted in a delete operation.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration fields that define the channel and its behavior. The permissible and required labels are specified in the NotificationChannelDescriptor corresponding to the type field. They can also be configured via the sensitive_labels block, but cannot be configured in both places.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The full REST resource name for this channel. The syntax is: projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID] The [CHANNEL_ID] is automatically assigned by the server on creation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Different notification type behaviors are configured primarily using the the labels field on this resource. This block contains the labels which contain secrets or passwords so that they can be marked sensitive and hidden from plan output. The name of the field, eg: password, will be the key in the labels map in the api request. Credentials may not be specified in both locations and will cause an error. Changing from one location to a different credential configuration in the config will require an apply to update state. Structure is documented below.</summary>
    [JsonPropertyName("sensitiveLabels")]
    public V1beta1NotificationChannelStatusAtProviderSensitiveLabels? SensitiveLabels { get; set; }

    /// <summary>The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type field. See https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list to get the list of valid values such as "email", "slack", etc...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User-supplied key/value data that does not need to conform to the corresponding NotificationChannelDescriptor's schema, unlike the labels field. This field is intended to be used for organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>Indicates whether this channel has been verified or not. On a ListNotificationChannels or GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it indicates that the channel is non-functioning (it both requires verification and lacks verification); otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it implies that the channel is of a type that does not require verification or that this specific channel has been exempted from verification because it was created prior to verification being required for channels of this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the value of this field, you must call VerifyNotificationChannel.</summary>
    [JsonPropertyName("verificationStatus")]
    public string? VerificationStatus { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatusConditions
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

/// <summary>NotificationChannelStatus defines the observed state of NotificationChannel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationChannelStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NotificationChannelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NotificationChannelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NotificationChannel is the Schema for the NotificationChannels API. A NotificationChannel is a medium through which an alert is delivered when a policy violation is detected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotificationChannel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NotificationChannelSpec>, IStatus<V1beta1NotificationChannelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotificationChannel";
    public const string KubeGroup = "monitoring.gcp.m.upbound.io";
    public const string KubePluralName = "notificationchannels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotificationChannelSpec defines the desired state of NotificationChannel</summary>
    [JsonPropertyName("spec")]
    public V1beta1NotificationChannelSpec Spec { get; set; }

    /// <summary>NotificationChannelStatus defines the observed state of NotificationChannel.</summary>
    [JsonPropertyName("status")]
    public V1beta1NotificationChannelStatus? Status { get; set; }
}