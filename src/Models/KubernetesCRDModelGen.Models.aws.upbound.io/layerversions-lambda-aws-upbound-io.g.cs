using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.upbound.io;
public enum V1beta1LayerVersionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1LayerVersionSpecForProvider
{
    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Unique name for your Lambda Layer</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is ${filebase64sha256("file.11.12 or later) or ${base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }
}

public partial class V1beta1LayerVersionSpecInitProvider
{
    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Unique name for your Lambda Layer</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is ${filebase64sha256("file.11.12 or later) or ${base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }
}

public enum V1beta1LayerVersionSpecManagementPoliciesEnum
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

public enum V1beta1LayerVersionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LayerVersionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LayerVersionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LayerVersionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LayerVersionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LayerVersionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LayerVersionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LayerVersionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1LayerVersionSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1LayerVersionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LayerVersionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LayerVersionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1LayerVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1LayerVersionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LayerVersionSpecDeletionPolicyEnum>))]
    public V1beta1LayerVersionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LayerVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LayerVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LayerVersionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LayerVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LayerVersionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LayerVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1LayerVersionStatusAtProvider
{
    /// <summary>ARN of the Lambda Layer with version.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Base64-encoded representation of raw SHA-256 sum of the zip file.</summary>
    [JsonPropertyName("codeSha256")]
    public string? CodeSha256 { get; set; }

    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Date this resource was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the Lambda Layer without version.</summary>
    [JsonPropertyName("layerArn")]
    public string? LayerArn { get; set; }

    /// <summary>Unique name for your Lambda Layer</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>ARN of a signing job.</summary>
    [JsonPropertyName("signingJobArn")]
    public string? SigningJobArn { get; set; }

    /// <summary>ARN for a signing profile version.</summary>
    [JsonPropertyName("signingProfileVersionArn")]
    public string? SigningProfileVersionArn { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is ${filebase64sha256("file.11.12 or later) or ${base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }

    /// <summary>Size in bytes of the function .zip file.</summary>
    [JsonPropertyName("sourceCodeSize")]
    public double? SourceCodeSize { get; set; }

    /// <summary>Lambda Layer version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1LayerVersionStatusConditions
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

public partial class V1beta1LayerVersionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LayerVersionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LayerVersionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LayerVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LayerVersionSpec>, IStatus<V1beta1LayerVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LayerVersion";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "layerversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LayerVersionSpec defines the desired state of LayerVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1LayerVersionSpec Spec { get; set; }

    /// <summary>LayerVersionStatus defines the observed state of LayerVersion.</summary>
    [JsonPropertyName("status")]
    public V1beta1LayerVersionStatus? Status { get; set; }
}