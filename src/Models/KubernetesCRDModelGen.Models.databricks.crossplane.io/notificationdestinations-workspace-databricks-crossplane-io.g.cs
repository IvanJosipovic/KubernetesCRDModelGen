using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workspace.databricks.crossplane.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

/// <summary>The password for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The username for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUsernameSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhook
{
    /// <summary>The password for basic authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    /// <summary>The username for basic authentication.</summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUsernameSecretRef? UsernameSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeams
{
    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary>The PagerDuty integration key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigPagerdutyIntegrationKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigPagerduty
{
    /// <summary>The PagerDuty integration key.</summary>
    [JsonPropertyName("integrationKeySecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigPagerdutyIntegrationKeySecretRef? IntegrationKeySecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlackUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlack
{
    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigSlackUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigSlack>? Slack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecForProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

/// <summary>The password for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The username for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUsernameSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhook
{
    /// <summary>The password for basic authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    /// <summary>The username for basic authentication.</summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUsernameSecretRef? UsernameSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeams
{
    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary>The PagerDuty integration key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigPagerdutyIntegrationKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigPagerduty
{
    /// <summary>The PagerDuty integration key.</summary>
    [JsonPropertyName("integrationKeySecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigPagerdutyIntegrationKeySecretRef? IntegrationKeySecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlackUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlack
{
    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigSlackUrlSecretRef? UrlSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigSlack>? Slack { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecInitProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1NotificationDestinationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1NotificationDestinationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1NotificationDestinationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1NotificationDestinationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NotificationDestinationSpec defines the desired state of NotificationDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1NotificationDestinationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1NotificationDestinationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1NotificationDestinationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1NotificationDestinationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1NotificationDestinationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigGenericWebhook
{
    /// <summary></summary>
    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigMicrosoftTeams
{
    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigPagerduty
{
    /// <summary></summary>
    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigSlack
{
    /// <summary></summary>
    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigSlack>? Slack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusAtProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The unique ID of the Notification Destination.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatusConditions
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

/// <summary>NotificationDestinationStatus defines the observed state of NotificationDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotificationDestinationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1NotificationDestinationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotificationDestinationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NotificationDestination is the Schema for the NotificationDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotificationDestination : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotificationDestinationSpec>, IStatus<V1alpha1NotificationDestinationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotificationDestination";
    public const string KubeGroup = "workspace.databricks.crossplane.io";
    public const string KubePluralName = "notificationdestinations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotificationDestinationSpec defines the desired state of NotificationDestination</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NotificationDestinationSpec Spec { get; set; }

    /// <summary>NotificationDestinationStatus defines the observed state of NotificationDestination.</summary>
    [JsonPropertyName("status")]
    public V1alpha1NotificationDestinationStatus? Status { get; set; }
}

/// <summary>NotificationDestination is the Schema for the NotificationDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotificationDestinationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NotificationDestination>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotificationDestinationList";
    public const string KubeGroup = "workspace.databricks.crossplane.io";
    public const string KubePluralName = "notificationdestinations";
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
    public IList<V1alpha1NotificationDestination> Items { get; set; }
}