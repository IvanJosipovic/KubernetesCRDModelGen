using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.upbound.io;
public enum V1beta1DocumentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DocumentSpecForProviderAttachmentsSource
{
    /// <summary>The key of a key-value pair that identifies the location of an attachment to the document. Valid values: SourceUrl, S3FileUrl, AttachmentReference.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The name of the document attachment file.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of a key-value pair that identifies the location of an attachment to the document. The argument format is a list of a single string that depends on the type of key you specify - see the API Reference for details.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1DocumentSpecForProvider
{
    /// <summary>One or more configuration blocks describing attachments sources to a version of a document. See attachments_source block below for details.</summary>
    [JsonPropertyName("attachmentsSource")]
    public IList<V1beta1DocumentSpecForProviderAttachmentsSource>? AttachmentsSource { get; set; }

    /// <summary>The content for the SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The format of the document. Valid values: JSON, TEXT, YAML.</summary>
    [JsonPropertyName("documentFormat")]
    public string? DocumentFormat { get; set; }

    /// <summary>The type of the document. For a list of valid values, see the API Reference.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Additional permissions to attach to the document. See Permissions below for details.</summary>
    [JsonPropertyName("permissions")]
    public IDictionary<string, string>? Permissions { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS resource and property types reference.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>The version of the artifact associated with the document. For example, 12.6. This value is unique across all versions of a document, and can't be changed.</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary></summary>
public partial class V1beta1DocumentSpecInitProviderAttachmentsSource
{
    /// <summary>The key of a key-value pair that identifies the location of an attachment to the document. Valid values: SourceUrl, S3FileUrl, AttachmentReference.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The name of the document attachment file.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of a key-value pair that identifies the location of an attachment to the document. The argument format is a list of a single string that depends on the type of key you specify - see the API Reference for details.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DocumentSpecInitProvider
{
    /// <summary>One or more configuration blocks describing attachments sources to a version of a document. See attachments_source block below for details.</summary>
    [JsonPropertyName("attachmentsSource")]
    public IList<V1beta1DocumentSpecInitProviderAttachmentsSource>? AttachmentsSource { get; set; }

    /// <summary>The content for the SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The format of the document. Valid values: JSON, TEXT, YAML.</summary>
    [JsonPropertyName("documentFormat")]
    public string? DocumentFormat { get; set; }

    /// <summary>The type of the document. For a list of valid values, see the API Reference.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Additional permissions to attach to the document. See Permissions below for details.</summary>
    [JsonPropertyName("permissions")]
    public IDictionary<string, string>? Permissions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS resource and property types reference.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>The version of the artifact associated with the document. For example, 12.6. This value is unique across all versions of a document, and can't be changed.</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

public enum V1beta1DocumentSpecManagementPoliciesEnum
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

public enum V1beta1DocumentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DocumentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DocumentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DocumentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DocumentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DocumentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DocumentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DocumentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DocumentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DocumentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DocumentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DocumentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DocumentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DocumentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DocumentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DocumentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DocumentSpec defines the desired state of Document</summary>
public partial class V1beta1DocumentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DocumentSpecDeletionPolicyEnum>))]
    public V1beta1DocumentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DocumentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DocumentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DocumentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DocumentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DocumentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DocumentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DocumentStatusAtProviderAttachmentsSource
{
    /// <summary>The key of a key-value pair that identifies the location of an attachment to the document. Valid values: SourceUrl, S3FileUrl, AttachmentReference.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The name of the document attachment file.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of a key-value pair that identifies the location of an attachment to the document. The argument format is a list of a single string that depends on the type of key you specify - see the API Reference for details.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1DocumentStatusAtProviderParameter
{
    /// <summary>If specified, the default values for the parameters. Parameters without a default value are required. Parameters with a default value are optional.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of what the parameter does, how to use it, the default value, and whether or not the parameter is optional.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of parameter. Valid values: String, StringList.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DocumentStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the document.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>One or more configuration blocks describing attachments sources to a version of a document. See attachments_source block below for details.</summary>
    [JsonPropertyName("attachmentsSource")]
    public IList<V1beta1DocumentStatusAtProviderAttachmentsSource>? AttachmentsSource { get; set; }

    /// <summary>The content for the SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The date the document was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>The default version of the document.</summary>
    [JsonPropertyName("defaultVersion")]
    public string? DefaultVersion { get; set; }

    /// <summary>The description of the document.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The format of the document. Valid values: JSON, TEXT, YAML.</summary>
    [JsonPropertyName("documentFormat")]
    public string? DocumentFormat { get; set; }

    /// <summary>The type of the document. For a list of valid values, see the API Reference.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>The document version.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The Sha256 or Sha1 hash created by the system when the document was created.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>The hash type of the document. Valid values: Sha256, Sha1.</summary>
    [JsonPropertyName("hashType")]
    public string? HashType { get; set; }

    /// <summary>The name of the document.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The latest version of the document.</summary>
    [JsonPropertyName("latestVersion")]
    public string? LatestVersion { get; set; }

    /// <summary>The Amazon Web Services user that created the document.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>One or more configuration blocks describing the parameters for the document. See parameter block below for details.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1DocumentStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>Additional permissions to attach to the document. See Permissions below for details.</summary>
    [JsonPropertyName("permissions")]
    public IDictionary<string, string>? Permissions { get; set; }

    /// <summary>The list of operating system (OS) platforms compatible with this SSM document. Valid values: Windows, Linux, MacOS.</summary>
    [JsonPropertyName("platformTypes")]
    public IList<string>? PlatformTypes { get; set; }

    /// <summary>The schema version of the document.</summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }

    /// <summary>The status of the SSM document. Valid values: Creating, Active, Updating, Deleting, Failed.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS resource and property types reference.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>The version of the artifact associated with the document. For example, 12.6. This value is unique across all versions of a document, and can't be changed.</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DocumentStatusConditions
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

/// <summary>DocumentStatus defines the observed state of Document.</summary>
public partial class V1beta1DocumentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DocumentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DocumentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Document is the Schema for the Documents API. Provides an SSM Document resource</summary>
public partial class V1beta1Document : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DocumentSpec>, IStatus<V1beta1DocumentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Document";
    public const string KubeGroup = "ssm.aws.upbound.io";
    public const string KubePluralName = "documents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DocumentSpec defines the desired state of Document</summary>
    [JsonPropertyName("spec")]
    public V1beta1DocumentSpec Spec { get; set; }

    /// <summary>DocumentStatus defines the observed state of Document.</summary>
    [JsonPropertyName("status")]
    public V1beta1DocumentStatus? Status { get; set; }
}