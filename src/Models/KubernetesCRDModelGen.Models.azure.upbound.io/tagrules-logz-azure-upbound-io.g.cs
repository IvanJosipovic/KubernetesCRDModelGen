using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logz.azure.upbound.io;
public enum V1beta1TagRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolutionEnum>))]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolveEnum>))]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagRuleSpecForProviderLogzMonitorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolutionEnum>))]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolveEnum>))]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagRuleSpecForProviderLogzMonitorIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TagRuleSpecForProviderTagFilter
{
    /// <summary>The action for a filtering tag. Possible values are Include and Exclude is allowed. Note that the Exclude takes priority over the Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of this tag_filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of this tag_filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1TagRuleSpecForProvider
{
    /// <summary>The ID of the Logz Monitor. Changing this forces a new logz Tag Rule to be created.</summary>
    [JsonPropertyName("logzMonitorId")]
    public string? LogzMonitorId { get; set; }

    /// <summary>Reference to a Monitor in logz to populate logzMonitorId.</summary>
    [JsonPropertyName("logzMonitorIdRef")]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdRef? LogzMonitorIdRef { get; set; }

    /// <summary>Selector for a Monitor in logz to populate logzMonitorId.</summary>
    [JsonPropertyName("logzMonitorIdSelector")]
    public V1beta1TagRuleSpecForProviderLogzMonitorIdSelector? LogzMonitorIdSelector { get; set; }

    /// <summary>Whether AAD logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendAadLogs")]
    public bool? SendAadLogs { get; set; }

    /// <summary>Whether activity logs from Azure resources should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Whether subscription logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }

    /// <summary>One or more (up to 10) tag_filter blocks as defined below.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1TagRuleSpecForProviderTagFilter>? TagFilter { get; set; }
}

public partial class V1beta1TagRuleSpecInitProviderTagFilter
{
    /// <summary>The action for a filtering tag. Possible values are Include and Exclude is allowed. Note that the Exclude takes priority over the Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of this tag_filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of this tag_filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1TagRuleSpecInitProvider
{
    /// <summary>Whether AAD logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendAadLogs")]
    public bool? SendAadLogs { get; set; }

    /// <summary>Whether activity logs from Azure resources should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Whether subscription logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }

    /// <summary>One or more (up to 10) tag_filter blocks as defined below.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1TagRuleSpecInitProviderTagFilter>? TagFilter { get; set; }
}

public enum V1beta1TagRuleSpecManagementPoliciesEnum
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

public enum V1beta1TagRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TagRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TagRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TagRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TagRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TagRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TagRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TagRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TagRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TagRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TagRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TagRuleSpecDeletionPolicyEnum>))]
    public V1beta1TagRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TagRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TagRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TagRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TagRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TagRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TagRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TagRuleStatusAtProviderTagFilter
{
    /// <summary>The action for a filtering tag. Possible values are Include and Exclude is allowed. Note that the Exclude takes priority over the Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of this tag_filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of this tag_filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1TagRuleStatusAtProvider
{
    /// <summary>The ID of the logz Tag Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Logz Monitor. Changing this forces a new logz Tag Rule to be created.</summary>
    [JsonPropertyName("logzMonitorId")]
    public string? LogzMonitorId { get; set; }

    /// <summary>Whether AAD logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendAadLogs")]
    public bool? SendAadLogs { get; set; }

    /// <summary>Whether activity logs from Azure resources should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Whether subscription logs should be sent to the Monitor resource?</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }

    /// <summary>One or more (up to 10) tag_filter blocks as defined below.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1TagRuleStatusAtProviderTagFilter>? TagFilter { get; set; }
}

public partial class V1beta1TagRuleStatusConditions
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

public partial class V1beta1TagRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TagRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TagRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TagRuleSpec>, IStatus<V1beta1TagRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagRule";
    public const string KubeGroup = "logz.azure.upbound.io";
    public const string KubePluralName = "tagrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TagRuleSpec defines the desired state of TagRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1TagRuleSpec Spec { get; set; }

    /// <summary>TagRuleStatus defines the observed state of TagRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1TagRuleStatus? Status { get; set; }
}