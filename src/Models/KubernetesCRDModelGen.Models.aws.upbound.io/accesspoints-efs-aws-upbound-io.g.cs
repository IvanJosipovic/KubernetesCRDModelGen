using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.efs.aws.upbound.io;
public enum V1beta1AccessPointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPointSpecForProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolveEnum>))]
    public V1beta1AccessPointSpecForProviderFileSystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FileSystem in efs to populate fileSystemId.</summary>
public partial class V1beta1AccessPointSpecForProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecForProviderFileSystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolveEnum>))]
    public V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FileSystem in efs to populate fileSystemId.</summary>
public partial class V1beta1AccessPointSpecForProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecForProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecForProviderPosixUser
{
    /// <summary>POSIX group ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>Secondary POSIX group IDs used for all file system operations using this access point.</summary>
    [JsonPropertyName("secondaryGids")]
    public IList<double>? SecondaryGids { get; set; }

    /// <summary>POSIX user ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecForProviderRootDirectoryCreationInfo
{
    /// <summary>POSIX group ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerGid")]
    public double? OwnerGid { get; set; }

    /// <summary>POSIX user ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerUid")]
    public double? OwnerUid { get; set; }

    /// <summary>POSIX permissions to apply to the RootDirectory, in the format of an octal number representing the file's mode bits.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecForProviderRootDirectory
{
    /// <summary>POSIX IDs and permissions to apply to the access point's Root Directory. See Creation Info below.</summary>
    [JsonPropertyName("creationInfo")]
    public IList<V1beta1AccessPointSpecForProviderRootDirectoryCreationInfo>? CreationInfo { get; set; }

    /// <summary>Path on the EFS file system to expose as the root directory to NFS clients using the access point to access the EFS file system. A path can have up to four subdirectories. If the specified path does not exist, you are required to provide creation_info.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecForProvider
{
    /// <summary>ID of the file system for which the access point is intended.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a FileSystem in efs to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1AccessPointSpecForProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a FileSystem in efs to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1AccessPointSpecForProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>Operating system user and group applied to all file system requests made using the access point. Detailed below.</summary>
    [JsonPropertyName("posixUser")]
    public IList<V1beta1AccessPointSpecForProviderPosixUser>? PosixUser { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Directory on the Amazon EFS file system that the access point provides access to. Detailed below.</summary>
    [JsonPropertyName("rootDirectory")]
    public IList<V1beta1AccessPointSpecForProviderRootDirectory>? RootDirectory { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolveEnum>))]
    public V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FileSystem in efs to populate fileSystemId.</summary>
public partial class V1beta1AccessPointSpecInitProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecInitProviderFileSystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolveEnum>))]
    public V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FileSystem in efs to populate fileSystemId.</summary>
public partial class V1beta1AccessPointSpecInitProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecInitProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecInitProviderPosixUser
{
    /// <summary>POSIX group ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>Secondary POSIX group IDs used for all file system operations using this access point.</summary>
    [JsonPropertyName("secondaryGids")]
    public IList<double>? SecondaryGids { get; set; }

    /// <summary>POSIX user ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecInitProviderRootDirectoryCreationInfo
{
    /// <summary>POSIX group ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerGid")]
    public double? OwnerGid { get; set; }

    /// <summary>POSIX user ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerUid")]
    public double? OwnerUid { get; set; }

    /// <summary>POSIX permissions to apply to the RootDirectory, in the format of an octal number representing the file's mode bits.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointSpecInitProviderRootDirectory
{
    /// <summary>POSIX IDs and permissions to apply to the access point's Root Directory. See Creation Info below.</summary>
    [JsonPropertyName("creationInfo")]
    public IList<V1beta1AccessPointSpecInitProviderRootDirectoryCreationInfo>? CreationInfo { get; set; }

    /// <summary>Path on the EFS file system to expose as the root directory to NFS clients using the access point to access the EFS file system. A path can have up to four subdirectories. If the specified path does not exist, you are required to provide creation_info.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AccessPointSpecInitProvider
{
    /// <summary>ID of the file system for which the access point is intended.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a FileSystem in efs to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1AccessPointSpecInitProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a FileSystem in efs to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1AccessPointSpecInitProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>Operating system user and group applied to all file system requests made using the access point. Detailed below.</summary>
    [JsonPropertyName("posixUser")]
    public IList<V1beta1AccessPointSpecInitProviderPosixUser>? PosixUser { get; set; }

    /// <summary>Directory on the Amazon EFS file system that the access point provides access to. Detailed below.</summary>
    [JsonPropertyName("rootDirectory")]
    public IList<V1beta1AccessPointSpecInitProviderRootDirectory>? RootDirectory { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1AccessPointSpecManagementPoliciesEnum
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

public enum V1beta1AccessPointSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPointSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AccessPointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AccessPointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AccessPointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AccessPointSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AccessPointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccessPointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccessPointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AccessPointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccessPointSpec defines the desired state of AccessPoint</summary>
public partial class V1beta1AccessPointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPointSpecDeletionPolicyEnum>))]
    public V1beta1AccessPointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccessPointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccessPointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AccessPointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccessPointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccessPointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccessPointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointStatusAtProviderPosixUser
{
    /// <summary>POSIX group ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>Secondary POSIX group IDs used for all file system operations using this access point.</summary>
    [JsonPropertyName("secondaryGids")]
    public IList<double>? SecondaryGids { get; set; }

    /// <summary>POSIX user ID used for all file system operations using this access point.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointStatusAtProviderRootDirectoryCreationInfo
{
    /// <summary>POSIX group ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerGid")]
    public double? OwnerGid { get; set; }

    /// <summary>POSIX user ID to apply to the root_directory.</summary>
    [JsonPropertyName("ownerUid")]
    public double? OwnerUid { get; set; }

    /// <summary>POSIX permissions to apply to the RootDirectory, in the format of an octal number representing the file's mode bits.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointStatusAtProviderRootDirectory
{
    /// <summary>POSIX IDs and permissions to apply to the access point's Root Directory. See Creation Info below.</summary>
    [JsonPropertyName("creationInfo")]
    public IList<V1beta1AccessPointStatusAtProviderRootDirectoryCreationInfo>? CreationInfo { get; set; }

    /// <summary>Path on the EFS file system to expose as the root directory to NFS clients using the access point to access the EFS file system. A path can have up to four subdirectories. If the specified path does not exist, you are required to provide creation_info.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPointStatusAtProvider
{
    /// <summary>ARN of the access point.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the file system.</summary>
    [JsonPropertyName("fileSystemArn")]
    public string? FileSystemArn { get; set; }

    /// <summary>ID of the file system for which the access point is intended.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>ID of the access point.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ID of the access point.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Operating system user and group applied to all file system requests made using the access point. Detailed below.</summary>
    [JsonPropertyName("posixUser")]
    public IList<V1beta1AccessPointStatusAtProviderPosixUser>? PosixUser { get; set; }

    /// <summary>Directory on the Amazon EFS file system that the access point provides access to. Detailed below.</summary>
    [JsonPropertyName("rootDirectory")]
    public IList<V1beta1AccessPointStatusAtProviderRootDirectory>? RootDirectory { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AccessPointStatusConditions
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

/// <summary>AccessPointStatus defines the observed state of AccessPoint.</summary>
public partial class V1beta1AccessPointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccessPointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AccessPoint is the Schema for the AccessPoints API. Provides an Elastic File System (EFS) access point.</summary>
public partial class V1beta1AccessPoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessPointSpec>, IStatus<V1beta1AccessPointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessPoint";
    public const string KubeGroup = "efs.aws.upbound.io";
    public const string KubePluralName = "accesspoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessPointSpec defines the desired state of AccessPoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessPointSpec Spec { get; set; }

    /// <summary>AccessPointStatus defines the observed state of AccessPoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessPointStatus? Status { get; set; }
}