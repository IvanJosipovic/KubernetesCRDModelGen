using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.filestore.cnrm.cloud.google.com;
public partial class V1beta1FilestoreInstanceSpecFileSharesNfsExportOptions
{
    /// <summary>Either READ_ONLY, for allowing only read requests on the exported directory, or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE. Possible values: ACCESS_MODE_UNSPECIFIED, READ_ONLY, READ_WRITE</summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>An integer representing the anonymous group id with a default value of 65534. Anon_gid may only be set with squash_mode of ROOT_SQUASH. An error will be returned if this field is specified for other squash_mode settings.</summary>
    [JsonPropertyName("anonGid")]
    public long? AnonGid { get; set; }

    /// <summary>An integer representing the anonymous user id with a default value of 65534. Anon_uid may only be set with squash_mode of ROOT_SQUASH. An error will be returned if this field is specified for other squash_mode settings.</summary>
    [JsonPropertyName("anonUid")]
    public long? AnonUid { get; set; }

    /// <summary>List of either an IPv4 addresses in the format `{octet1}.{octet2}.{octet3}.{octet4}` or CIDR ranges in the format `{octet1}.{octet2}.{octet3}.{octet4}/{mask size}` which may mount the file share. Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned. The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH, for not allowing root access. The default is NO_ROOT_SQUASH. Possible values: SQUASH_MODE_UNSPECIFIED, NO_ROOT_SQUASH, ROOT_SQUASH</summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

public partial class V1beta1FilestoreInstanceSpecFileSharesSourceBackupRef
{
    /// <summary>The resource name of the backup, in the format `projects/{project_number}/locations/{location_id}/backups/{backup_id}`, that this file share has been restored from.  Allowed value: The Google Cloud resource name of a `FilestoreBackup` resource (format: `projects/{{project}}/locations/{{location}}/backups/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1FilestoreInstanceSpecFileShares
{
    /// <summary>File share capacity in gigabytes (GB). Cloud Filestore defines 1 GB as 1024^3 bytes.</summary>
    [JsonPropertyName("capacityGb")]
    public long? CapacityGb { get; set; }

    /// <summary>The name of the file share (must be 16 characters or less).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nfs Export Options. There is a limit of 10 export options per file share.</summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta1FilestoreInstanceSpecFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceBackupRef")]
    public V1beta1FilestoreInstanceSpecFileSharesSourceBackupRef? SourceBackupRef { get; set; }
}

public partial class V1beta1FilestoreInstanceSpecNetworksNetworkRef
{
    /// <summary>The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc) to which the instance is connected.  Allowed value: The Google Cloud resource name of a `ComputeNetwork` resource (format: `projects/{{project}}/global/networks/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1FilestoreInstanceSpecNetworks
{
    /// <summary>Immutable. Output only. IPv4 addresses in the format `{octet1}.{octet2}.{octet3}.{octet4}` or IPv6 addresses in the format `{block1}:{block2}:{block3}:{block4}:{block5}:{block6}:{block7}:{block8}`.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Immutable. Internet protocol versions for which the instance has IP addresses assigned. For this version, only MODE_IPV4 is supported.</summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1FilestoreInstanceSpecNetworksNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. A /29 CIDR block in one of the [internal IP address ranges](https://www.arin.net/reference/research/statistics/address_filters/) that identifies the range of IP addresses reserved for this instance. For example, 10.0.0.0/29 or 192.168.0.0/29. The range you specify can't overlap with either existing subnets or assigned IP address ranges for other Cloud Filestore instances in the selected VPC network.</summary>
    [JsonPropertyName("reservedIPRange")]
    public string? ReservedIPRange { get; set; }
}

public partial class V1beta1FilestoreInstanceSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1FilestoreInstanceSpec
{
    /// <summary>The description of the instance (2048 characters or less).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>File system shares on the instance. For this version, only a single file share is supported.</summary>
    [JsonPropertyName("fileShares")]
    public IList<V1beta1FilestoreInstanceSpecFileShares>? FileShares { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. VPC networks to which the instance is connected. For this version, only a single network is supported.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1FilestoreInstanceSpecNetworks>? Networks { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1FilestoreInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The service tier of the instance. Possible values: TIER_UNSPECIFIED, STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ENTERPRISE</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

public partial class V1beta1FilestoreInstanceStatusConditions
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

public partial class V1beta1FilestoreInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FilestoreInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Server-specified ETag for the instance resource to prevent simultaneous updates from overwriting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The instance state. Possible values: STATE_UNSPECIFIED, CREATING, READY, REPAIRING, DELETING, ERROR</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the instance state, if available.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FilestoreInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FilestoreInstanceSpec>, IStatus<V1beta1FilestoreInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FilestoreInstance";
    public const string KubeGroup = "filestore.cnrm.cloud.google.com";
    public const string KubePluralName = "filestoreinstances";
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
    public V1beta1FilestoreInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1FilestoreInstanceStatus? Status { get; set; }
}