using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appstream.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProviderAccessEndpoints
{
    /// <summary>Type of the interface endpoint. See the AccessEndpoint AWS API documentation for valid values.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ID of the VPC in which the interface endpoint is used.</summary>
    [JsonPropertyName("vpceId")]
    public string? VpceId { get; set; }
}

/// <summary>Settings for application settings persistence. See application_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProviderApplicationSettings
{
    /// <summary>Whether application settings should be persisted.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the settings group. Required when enabled is true. Can be up to 100 characters.</summary>
    [JsonPropertyName("settingsGroup")]
    public string? SettingsGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProviderStorageConnectors
{
    /// <summary>Type of storage connector. Valid values are HOMEFOLDERS, GOOGLE_DRIVE, or ONE_DRIVE.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Names of the domains for the account.</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>ARN of the storage connector.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }
}

/// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProviderStreamingExperienceSettings
{
    /// <summary>The preferred protocol that you want to use while streaming your application. Valid values are TCP and UDP.</summary>
    [JsonPropertyName("preferredProtocol")]
    public string? PreferredProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProviderUserSettings
{
    /// <summary>Action that is enabled or disabled. Valid values are AUTO_TIME_ZONE_REDIRECTION, CLIPBOARD_COPY_FROM_LOCAL_DEVICE, CLIPBOARD_COPY_TO_LOCAL_DEVICE, DOMAIN_PASSWORD_SIGNIN, DOMAIN_SMART_CARD_SIGNIN, FILE_UPLOAD, FILE_DOWNLOAD, or PRINTING_TO_LOCAL_DEVICE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether the action is enabled or disabled. Valid values are ENABLED or DISABLED.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecForProvider
{
    /// <summary>Set of configuration blocks defining the interface VPC endpoints. Users of the stack can connect to AppStream 2.0 only through the specified endpoints. See access_endpoints below.</summary>
    [JsonPropertyName("accessEndpoints")]
    public IList<V1beta1StackSpecForProviderAccessEndpoints>? AccessEndpoints { get; set; }

    /// <summary>Settings for application settings persistence. See application_settings below.</summary>
    [JsonPropertyName("applicationSettings")]
    public V1beta1StackSpecForProviderApplicationSettings? ApplicationSettings { get; set; }

    /// <summary>Description for the AppStream stack.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stack name to display.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Domains where AppStream 2.0 streaming sessions can be embedded in an iframe. You must approve the domains that you want to host embedded AppStream 2.0 streaming sessions.</summary>
    [JsonPropertyName("embedHostDomains")]
    public IList<string>? EmbedHostDomains { get; set; }

    /// <summary>URL that users are redirected to after they click the Send Feedback link. If no URL is specified, no Send Feedback link is displayed. .</summary>
    [JsonPropertyName("feedbackUrl")]
    public string? FeedbackUrl { get; set; }

    /// <summary>Unique name for the AppStream stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL that users are redirected to after their streaming session ends.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for the storage connectors to enable. See storage_connectors below.</summary>
    [JsonPropertyName("storageConnectors")]
    public IList<V1beta1StackSpecForProviderStorageConnectors>? StorageConnectors { get; set; }

    /// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
    [JsonPropertyName("streamingExperienceSettings")]
    public V1beta1StackSpecForProviderStreamingExperienceSettings? StreamingExperienceSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the actions that are enabled or disabled for users during their streaming sessions. If not provided, these settings are configured automatically by AWS. See user_settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1StackSpecForProviderUserSettings>? UserSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProviderAccessEndpoints
{
    /// <summary>Type of the interface endpoint. See the AccessEndpoint AWS API documentation for valid values.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ID of the VPC in which the interface endpoint is used.</summary>
    [JsonPropertyName("vpceId")]
    public string? VpceId { get; set; }
}

/// <summary>Settings for application settings persistence. See application_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProviderApplicationSettings
{
    /// <summary>Whether application settings should be persisted.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the settings group. Required when enabled is true. Can be up to 100 characters.</summary>
    [JsonPropertyName("settingsGroup")]
    public string? SettingsGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProviderStorageConnectors
{
    /// <summary>Type of storage connector. Valid values are HOMEFOLDERS, GOOGLE_DRIVE, or ONE_DRIVE.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Names of the domains for the account.</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>ARN of the storage connector.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }
}

/// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProviderStreamingExperienceSettings
{
    /// <summary>The preferred protocol that you want to use while streaming your application. Valid values are TCP and UDP.</summary>
    [JsonPropertyName("preferredProtocol")]
    public string? PreferredProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProviderUserSettings
{
    /// <summary>Action that is enabled or disabled. Valid values are AUTO_TIME_ZONE_REDIRECTION, CLIPBOARD_COPY_FROM_LOCAL_DEVICE, CLIPBOARD_COPY_TO_LOCAL_DEVICE, DOMAIN_PASSWORD_SIGNIN, DOMAIN_SMART_CARD_SIGNIN, FILE_UPLOAD, FILE_DOWNLOAD, or PRINTING_TO_LOCAL_DEVICE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether the action is enabled or disabled. Valid values are ENABLED or DISABLED.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecInitProvider
{
    /// <summary>Set of configuration blocks defining the interface VPC endpoints. Users of the stack can connect to AppStream 2.0 only through the specified endpoints. See access_endpoints below.</summary>
    [JsonPropertyName("accessEndpoints")]
    public IList<V1beta1StackSpecInitProviderAccessEndpoints>? AccessEndpoints { get; set; }

    /// <summary>Settings for application settings persistence. See application_settings below.</summary>
    [JsonPropertyName("applicationSettings")]
    public V1beta1StackSpecInitProviderApplicationSettings? ApplicationSettings { get; set; }

    /// <summary>Description for the AppStream stack.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stack name to display.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Domains where AppStream 2.0 streaming sessions can be embedded in an iframe. You must approve the domains that you want to host embedded AppStream 2.0 streaming sessions.</summary>
    [JsonPropertyName("embedHostDomains")]
    public IList<string>? EmbedHostDomains { get; set; }

    /// <summary>URL that users are redirected to after they click the Send Feedback link. If no URL is specified, no Send Feedback link is displayed. .</summary>
    [JsonPropertyName("feedbackUrl")]
    public string? FeedbackUrl { get; set; }

    /// <summary>Unique name for the AppStream stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL that users are redirected to after their streaming session ends.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Configuration block for the storage connectors to enable. See storage_connectors below.</summary>
    [JsonPropertyName("storageConnectors")]
    public IList<V1beta1StackSpecInitProviderStorageConnectors>? StorageConnectors { get; set; }

    /// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
    [JsonPropertyName("streamingExperienceSettings")]
    public V1beta1StackSpecInitProviderStreamingExperienceSettings? StreamingExperienceSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the actions that are enabled or disabled for users during their streaming sessions. If not provided, these settings are configured automatically by AWS. See user_settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1StackSpecInitProviderUserSettings>? UserSettings { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpecProviderConfigRef
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
public partial class V1beta1StackSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>StackSpec defines the desired state of Stack</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StackSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StackSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StackSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StackSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProviderAccessEndpoints
{
    /// <summary>Type of the interface endpoint. See the AccessEndpoint AWS API documentation for valid values.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ID of the VPC in which the interface endpoint is used.</summary>
    [JsonPropertyName("vpceId")]
    public string? VpceId { get; set; }
}

/// <summary>Settings for application settings persistence. See application_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProviderApplicationSettings
{
    /// <summary>Whether application settings should be persisted.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the settings group. Required when enabled is true. Can be up to 100 characters.</summary>
    [JsonPropertyName("settingsGroup")]
    public string? SettingsGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProviderStorageConnectors
{
    /// <summary>Type of storage connector. Valid values are HOMEFOLDERS, GOOGLE_DRIVE, or ONE_DRIVE.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Names of the domains for the account.</summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>ARN of the storage connector.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }
}

/// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProviderStreamingExperienceSettings
{
    /// <summary>The preferred protocol that you want to use while streaming your application. Valid values are TCP and UDP.</summary>
    [JsonPropertyName("preferredProtocol")]
    public string? PreferredProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProviderUserSettings
{
    /// <summary>Action that is enabled or disabled. Valid values are AUTO_TIME_ZONE_REDIRECTION, CLIPBOARD_COPY_FROM_LOCAL_DEVICE, CLIPBOARD_COPY_TO_LOCAL_DEVICE, DOMAIN_PASSWORD_SIGNIN, DOMAIN_SMART_CARD_SIGNIN, FILE_UPLOAD, FILE_DOWNLOAD, or PRINTING_TO_LOCAL_DEVICE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether the action is enabled or disabled. Valid values are ENABLED or DISABLED.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusAtProvider
{
    /// <summary>Set of configuration blocks defining the interface VPC endpoints. Users of the stack can connect to AppStream 2.0 only through the specified endpoints. See access_endpoints below.</summary>
    [JsonPropertyName("accessEndpoints")]
    public IList<V1beta1StackStatusAtProviderAccessEndpoints>? AccessEndpoints { get; set; }

    /// <summary>Settings for application settings persistence. See application_settings below.</summary>
    [JsonPropertyName("applicationSettings")]
    public V1beta1StackStatusAtProviderApplicationSettings? ApplicationSettings { get; set; }

    /// <summary>ARN of the appstream stack.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Date and time, in UTC and extended RFC 3339 format, when the stack was created.</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>Description for the AppStream stack.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stack name to display.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Domains where AppStream 2.0 streaming sessions can be embedded in an iframe. You must approve the domains that you want to host embedded AppStream 2.0 streaming sessions.</summary>
    [JsonPropertyName("embedHostDomains")]
    public IList<string>? EmbedHostDomains { get; set; }

    /// <summary>URL that users are redirected to after they click the Send Feedback link. If no URL is specified, no Send Feedback link is displayed. .</summary>
    [JsonPropertyName("feedbackUrl")]
    public string? FeedbackUrl { get; set; }

    /// <summary>Unique ID of the appstream stack.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Unique name for the AppStream stack.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL that users are redirected to after their streaming session ends.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for the storage connectors to enable. See storage_connectors below.</summary>
    [JsonPropertyName("storageConnectors")]
    public IList<V1beta1StackStatusAtProviderStorageConnectors>? StorageConnectors { get; set; }

    /// <summary>The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently, UDP is only supported in the Windows native client. See streaming_experience_settings below.</summary>
    [JsonPropertyName("streamingExperienceSettings")]
    public V1beta1StackStatusAtProviderStreamingExperienceSettings? StreamingExperienceSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for the actions that are enabled or disabled for users during their streaming sessions. If not provided, these settings are configured automatically by AWS. See user_settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1StackStatusAtProviderUserSettings>? UserSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatusConditions
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

/// <summary>StackStatus defines the observed state of Stack.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StackStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StackStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Stack is the Schema for the Stacks API. Provides an AppStream stack</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Stack : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StackSpec>, IStatus<V1beta1StackStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Stack";
    public const string KubeGroup = "appstream.aws.m.upbound.io";
    public const string KubePluralName = "stacks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSpec defines the desired state of Stack</summary>
    [JsonPropertyName("spec")]
    public V1beta1StackSpec Spec { get; set; }

    /// <summary>StackStatus defines the observed state of Stack.</summary>
    [JsonPropertyName("status")]
    public V1beta1StackStatus? Status { get; set; }
}

/// <summary>Stack is the Schema for the Stacks API. Provides an AppStream stack</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StackList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Stack>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StackList";
    public const string KubeGroup = "appstream.aws.m.upbound.io";
    public const string KubePluralName = "stacks";
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
    public IList<V1beta1Stack> Items { get; set; }
}