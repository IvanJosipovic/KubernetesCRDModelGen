using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sesv2.aws.upbound.io;
public enum V1beta1ConfigurationSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1ConfigurationSetSpecForProviderDeliveryOptions
{
    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard.</summary>
    [JsonPropertyName("dashboardOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderVdmOptionsDashboardOptions>? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian.</summary>
    [JsonPropertyName("guardianOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderVdmOptionsGuardianOptions>? GuardianOptions { get; set; }
}

public partial class V1beta1ConfigurationSetSpecForProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set.</summary>
    [JsonPropertyName("deliveryOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderDeliveryOptions>? DeliveryOptions { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set.</summary>
    [JsonPropertyName("reputationOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderReputationOptions>? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set.</summary>
    [JsonPropertyName("sendingOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderSendingOptions>? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account.</summary>
    [JsonPropertyName("suppressionOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderSuppressionOptions>? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set.</summary>
    [JsonPropertyName("trackingOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderTrackingOptions>? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set.</summary>
    [JsonPropertyName("vdmOptions")]
    public IList<V1beta1ConfigurationSetSpecForProviderVdmOptions>? VdmOptions { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderDeliveryOptions
{
    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard.</summary>
    [JsonPropertyName("dashboardOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions>? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian.</summary>
    [JsonPropertyName("guardianOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions>? GuardianOptions { get; set; }
}

public partial class V1beta1ConfigurationSetSpecInitProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set.</summary>
    [JsonPropertyName("deliveryOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderDeliveryOptions>? DeliveryOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set.</summary>
    [JsonPropertyName("reputationOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderReputationOptions>? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set.</summary>
    [JsonPropertyName("sendingOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderSendingOptions>? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account.</summary>
    [JsonPropertyName("suppressionOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderSuppressionOptions>? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set.</summary>
    [JsonPropertyName("trackingOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderTrackingOptions>? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set.</summary>
    [JsonPropertyName("vdmOptions")]
    public IList<V1beta1ConfigurationSetSpecInitProviderVdmOptions>? VdmOptions { get; set; }
}

public enum V1beta1ConfigurationSetSpecManagementPoliciesEnum
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

public enum V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConfigurationSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ConfigurationSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConfigurationSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ConfigurationSetSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ConfigurationSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ConfigurationSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ConfigurationSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigurationSetSpecDeletionPolicyEnum>))]
    public V1beta1ConfigurationSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigurationSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigurationSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConfigurationSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigurationSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConfigurationSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigurationSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderDeliveryOptions
{
    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderReputationOptions
{
    /// <summary>The date and time (in Unix time) when the reputation metrics were last given a fresh start. When your account is given a fresh start, your reputation metrics are calculated starting from the date of the fresh start.</summary>
    [JsonPropertyName("lastFreshStart")]
    public string? LastFreshStart { get; set; }

    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard.</summary>
    [JsonPropertyName("dashboardOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions>? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian.</summary>
    [JsonPropertyName("guardianOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions>? GuardianOptions { get; set; }
}

public partial class V1beta1ConfigurationSetStatusAtProvider
{
    /// <summary>ARN of the Configuration Set.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set.</summary>
    [JsonPropertyName("deliveryOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderDeliveryOptions>? DeliveryOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set.</summary>
    [JsonPropertyName("reputationOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderReputationOptions>? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set.</summary>
    [JsonPropertyName("sendingOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderSendingOptions>? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account.</summary>
    [JsonPropertyName("suppressionOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderSuppressionOptions>? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set.</summary>
    [JsonPropertyName("trackingOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderTrackingOptions>? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set.</summary>
    [JsonPropertyName("vdmOptions")]
    public IList<V1beta1ConfigurationSetStatusAtProviderVdmOptions>? VdmOptions { get; set; }
}

public partial class V1beta1ConfigurationSetStatusConditions
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

public partial class V1beta1ConfigurationSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigurationSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigurationSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigurationSetSpec>, IStatus<V1beta1ConfigurationSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSet";
    public const string KubeGroup = "sesv2.aws.upbound.io";
    public const string KubePluralName = "configurationsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSetSpec defines the desired state of ConfigurationSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigurationSetSpec Spec { get; set; }

    /// <summary>ConfigurationSetStatus defines the observed state of ConfigurationSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigurationSetStatus? Status { get; set; }
}