using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.filestore.gcp.upbound.io;
public enum V1beta1InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1InstanceSpecForProviderFileSharesNfsExportOptions
{
    /// <summary>Either READ_ONLY, for allowing only read requests on the exported directory, or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>An integer representing the anonymous group id with a default value of 65534. Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>An integer representing the anonymous user id with a default value of 65534. Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share. Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned. The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH, for not allowing root access. The default is NO_ROOT_SQUASH. Default value is NO_ROOT_SQUASH. Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.</summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

public partial class V1beta1InstanceSpecForProviderFileShares
{
    /// <summary>File share capacity in GiB. This must be at least 1024 GiB for the standard tier, or 2560 GiB for the premium tier.</summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nfs Export Options. There is a limit of 10 export options per file share. Structure is documented below.</summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta1InstanceSpecForProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>The resource name of the backup, in the format projects/{projectId}/locations/{locationId}/backups/{backupId}, that this file share has been restored from.</summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

public enum V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecForProviderKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecForProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecForProviderKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1InstanceSpecForProviderNetworks
{
    /// <summary>The network connect mode of the Filestore instance. If not provided, the connect mode defaults to DIRECT_PEERING. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>IP versions for which the instance has IP addresses assigned. Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.</summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>The name of the GCE VPC network to which the instance is connected.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A /29 CIDR block that identifies the range of IP addresses reserved for this instance.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>File system shares on the instance. For this version, only a single file share is supported. Structure is documented below.</summary>
    [JsonPropertyName("fileShares")]
    public IList<V1beta1InstanceSpecForProviderFileShares>? FileShares { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1InstanceSpecForProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1InstanceSpecForProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location of the instance. This can be a region for ENTERPRISE tier instances.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>VPC networks to which the instance is connected. For this version, only a single network is supported. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1InstanceSpecForProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The service tier of the instance. Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1InstanceSpecInitProviderFileSharesNfsExportOptions
{
    /// <summary>Either READ_ONLY, for allowing only read requests on the exported directory, or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>An integer representing the anonymous group id with a default value of 65534. Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>An integer representing the anonymous user id with a default value of 65534. Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share. Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned. The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH, for not allowing root access. The default is NO_ROOT_SQUASH. Default value is NO_ROOT_SQUASH. Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.</summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

public partial class V1beta1InstanceSpecInitProviderFileShares
{
    /// <summary>File share capacity in GiB. This must be at least 1024 GiB for the standard tier, or 2560 GiB for the premium tier.</summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nfs Export Options. There is a limit of 10 export options per file share. Structure is documented below.</summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta1InstanceSpecInitProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>The resource name of the backup, in the format projects/{projectId}/locations/{locationId}/backups/{backupId}, that this file share has been restored from.</summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

public enum V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecInitProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecInitProviderKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1InstanceSpecInitProviderNetworks
{
    /// <summary>The network connect mode of the Filestore instance. If not provided, the connect mode defaults to DIRECT_PEERING. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>IP versions for which the instance has IP addresses assigned. Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.</summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>The name of the GCE VPC network to which the instance is connected.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A /29 CIDR block that identifies the range of IP addresses reserved for this instance.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>File system shares on the instance. For this version, only a single file share is supported. Structure is documented below.</summary>
    [JsonPropertyName("fileShares")]
    public IList<V1beta1InstanceSpecInitProviderFileShares>? FileShares { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1InstanceSpecInitProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1InstanceSpecInitProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>VPC networks to which the instance is connected. For this version, only a single network is supported. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1InstanceSpecInitProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The service tier of the instance. Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public enum V1beta1InstanceSpecManagementPoliciesEnum
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

public enum V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1InstanceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1InstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecDeletionPolicyEnum>))]
    public V1beta1InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1InstanceStatusAtProviderFileSharesNfsExportOptions
{
    /// <summary>Either READ_ONLY, for allowing only read requests on the exported directory, or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE. Default value is READ_WRITE. Possible values are: READ_ONLY, READ_WRITE.</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>An integer representing the anonymous group id with a default value of 65534. Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>An integer representing the anonymous user id with a default value of 65534. Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned if this field is specified for other squashMode settings.</summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share. Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned. The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH, for not allowing root access. The default is NO_ROOT_SQUASH. Default value is NO_ROOT_SQUASH. Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.</summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

public partial class V1beta1InstanceStatusAtProviderFileShares
{
    /// <summary>File share capacity in GiB. This must be at least 1024 GiB for the standard tier, or 2560 GiB for the premium tier.</summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nfs Export Options. There is a limit of 10 export options per file share. Structure is documented below.</summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta1InstanceStatusAtProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>The resource name of the backup, in the format projects/{projectId}/locations/{locationId}/backups/{backupId}, that this file share has been restored from.</summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

public partial class V1beta1InstanceStatusAtProviderNetworks
{
    /// <summary>The network connect mode of the Filestore instance. If not provided, the connect mode defaults to DIRECT_PEERING. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>(Output) A list of IPv4 or IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>IP versions for which the instance has IP addresses assigned. Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.</summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>The name of the GCE VPC network to which the instance is connected.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>A /29 CIDR block that identifies the range of IP addresses reserved for this instance.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Server-specified ETag for the instance resource to prevent simultaneous updates from overwriting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>File system shares on the instance. For this version, only a single file share is supported. Structure is documented below.</summary>
    [JsonPropertyName("fileShares")]
    public IList<V1beta1InstanceStatusAtProviderFileShares>? FileShares { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location of the instance. This can be a region for ENTERPRISE tier instances.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>VPC networks to which the instance is connected. For this version, only a single network is supported. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1InstanceStatusAtProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The service tier of the instance. Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1InstanceStatusConditions
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

public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "filestore.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}