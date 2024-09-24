using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.netapp.azure.upbound.io;
public enum V1beta1VolumeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VolumeSpecForProviderAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderAccountNameRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderAccountNameRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in netapp to populate accountName.</summary>
public partial class V1beta1VolumeSpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in netapp to populate accountName.</summary>
public partial class V1beta1VolumeSpecForProviderAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
public partial class V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
public partial class V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Volume in netapp to populate remoteVolumeResourceId.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Volume in netapp to populate remoteVolumeResourceId.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionReplication
{
    /// <summary>The endpoint type, default value is dst for destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Location of the primary volume. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVolumeLocation")]
    public string? RemoteVolumeLocation { get; set; }

    /// <summary>Resource ID of the primary volume.</summary>
    [JsonPropertyName("remoteVolumeResourceId")]
    public string? RemoteVolumeResourceId { get; set; }

    /// <summary>Reference to a Volume in netapp to populate remoteVolumeResourceId.</summary>
    [JsonPropertyName("remoteVolumeResourceIdRef")]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdRef? RemoteVolumeResourceIdRef { get; set; }

    /// <summary>Selector for a Volume in netapp to populate remoteVolumeResourceId.</summary>
    [JsonPropertyName("remoteVolumeResourceIdSelector")]
    public V1beta1VolumeSpecForProviderDataProtectionReplicationRemoteVolumeResourceIdSelector? RemoteVolumeResourceIdSelector { get; set; }

    /// <summary>Replication frequency, supported values are '10minutes', 'hourly', 'daily', values are case sensitive.</summary>
    [JsonPropertyName("replicationFrequency")]
    public string? ReplicationFrequency { get; set; }
}

public enum V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicy
{
    /// <summary>Resource ID of the snapshot policy to apply to the volume.</summary>
    [JsonPropertyName("snapshotPolicyId")]
    public string? SnapshotPolicyId { get; set; }

    /// <summary>Reference to a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
    [JsonPropertyName("snapshotPolicyIdRef")]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdRef? SnapshotPolicyIdRef { get; set; }

    /// <summary>Selector for a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
    [JsonPropertyName("snapshotPolicyIdSelector")]
    public V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelector? SnapshotPolicyIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecForProviderExportPolicyRule
{
    /// <summary>A list of allowed clients IPv4 addresses.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>A list of allowed protocols. Valid values include CIFS, NFSv3, or NFSv4.1. Only one value is supported at this time. This replaces the previous arguments: cifs_enabled, nfsv3_enabled and nfsv4_enabled.</summary>
    [JsonPropertyName("protocolsEnabled")]
    public IList<string>? ProtocolsEnabled { get; set; }

    /// <summary>Is root access permitted to this volume?</summary>
    [JsonPropertyName("rootAccessEnabled")]
    public bool? RootAccessEnabled { get; set; }

    /// <summary>The index number of the rule.</summary>
    [JsonPropertyName("ruleIndex")]
    public double? RuleIndex { get; set; }

    /// <summary>Is the file system on unix read only?</summary>
    [JsonPropertyName("unixReadOnly")]
    public bool? UnixReadOnly { get; set; }

    /// <summary>Is the file system on unix read and write?</summary>
    [JsonPropertyName("unixReadWrite")]
    public bool? UnixReadWrite { get; set; }
}

public enum V1beta1VolumeSpecForProviderPoolNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderPoolNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderPoolNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderPoolNameRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderPoolNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderPoolNameRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderPoolNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Pool in netapp to populate poolName.</summary>
public partial class V1beta1VolumeSpecForProviderPoolNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderPoolNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderPoolNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderPoolNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Pool in netapp to populate poolName.</summary>
public partial class V1beta1VolumeSpecForProviderPoolNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderPoolNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VolumeSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VolumeSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1VolumeSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1VolumeSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecForProvider
{
    /// <summary>The name of the NetApp account in which the NetApp Pool should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in netapp to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta1VolumeSpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in netapp to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta1VolumeSpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>Is the NetApp Volume enabled for Azure VMware Solution (AVS) datastore purpose. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("azureVmwareDataStoreEnabled")]
    public bool? AzureVmwareDataStoreEnabled { get; set; }

    /// <summary>Creates volume from snapshot. Following properties must be the same as the original volume where the snapshot was taken from: protocols, subnet_id, location, service_level, resource_group_name, account_name and pool_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createFromSnapshotResourceId")]
    public string? CreateFromSnapshotResourceId { get; set; }

    /// <summary>Reference to a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
    [JsonPropertyName("createFromSnapshotResourceIdRef")]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdRef? CreateFromSnapshotResourceIdRef { get; set; }

    /// <summary>Selector for a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
    [JsonPropertyName("createFromSnapshotResourceIdSelector")]
    public V1beta1VolumeSpecForProviderCreateFromSnapshotResourceIdSelector? CreateFromSnapshotResourceIdSelector { get; set; }

    /// <summary>A data_protection_replication block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataProtectionReplication")]
    public IList<V1beta1VolumeSpecForProviderDataProtectionReplication>? DataProtectionReplication { get; set; }

    /// <summary>A data_protection_snapshot_policy block as defined below.</summary>
    [JsonPropertyName("dataProtectionSnapshotPolicy")]
    public IList<V1beta1VolumeSpecForProviderDataProtectionSnapshotPolicy>? DataProtectionSnapshotPolicy { get; set; }

    /// <summary>The encryption key source, it can be Microsoft.NetApp for platform managed keys or Microsoft.KeyVault for customer-managed keys. This is required with key_vault_private_endpoint_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionKeySource")]
    public string? EncryptionKeySource { get; set; }

    /// <summary>One or more export_policy_rule block defined below.</summary>
    [JsonPropertyName("exportPolicyRule")]
    public IList<V1beta1VolumeSpecForProviderExportPolicyRule>? ExportPolicyRule { get; set; }

    /// <summary>The Private Endpoint ID for Key Vault, which is required when using customer-managed keys. This is required with encryption_key_source. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultPrivateEndpointId")]
    public string? KeyVaultPrivateEndpointId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Indicates which network feature to use, accepted values are Basic or Standard, it defaults to Basic if not defined. This is a feature in public preview and for more information about it and how to register, please refer to Configure network features for an Azure NetApp Files volume.</summary>
    [JsonPropertyName("networkFeatures")]
    public string? NetworkFeatures { get; set; }

    /// <summary>The name of the NetApp pool in which the NetApp Volume should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary>Reference to a Pool in netapp to populate poolName.</summary>
    [JsonPropertyName("poolNameRef")]
    public V1beta1VolumeSpecForProviderPoolNameRef? PoolNameRef { get; set; }

    /// <summary>Selector for a Pool in netapp to populate poolName.</summary>
    [JsonPropertyName("poolNameSelector")]
    public V1beta1VolumeSpecForProviderPoolNameSelector? PoolNameSelector { get; set; }

    /// <summary>The target volume protocol expressed as a list. Supported single value include CIFS, NFSv3, or NFSv4.1. If argument is not defined it will default to NFSv3. Changing this forces a new resource to be created and data will be lost. Dual protocol scenario is supported for CIFS and NFSv3, for more information, please refer to Create a dual-protocol volume for Azure NetApp Files document.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The name of the resource group where the NetApp Volume should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VolumeSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VolumeSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Volume security style, accepted values are unix or ntfs. If not provided, single-protocol volume is created defaulting to unix if it is NFSv3 or NFSv4.1 volume, if CIFS, it will default to ntfs. In a dual-protocol volume, if not provided, its value will be ntfs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityStyle")]
    public string? SecurityStyle { get; set; }

    /// <summary>The target performance of the file system. Valid values include Premium, Standard, or Ultra. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; set; }

    /// <summary>Limits enumeration of files and folders (that is, listing the contents) in SMB only to users with allowed access on the share. For instance, if a user doesn't have access to read a file or folder in a share with access-based enumeration enabled, then the file or folder doesn't show up in directory listings. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbAccessBasedEnumerationEnabled")]
    public bool? SmbAccessBasedEnumerationEnabled { get; set; }

    /// <summary>Limits clients from browsing for an SMB share by hiding the share from view in Windows Explorer or when listing shares in "net view." Only end users that know the absolute paths to the share are able to find the share. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbNonBrowsableEnabled")]
    public bool? SmbNonBrowsableEnabled { get; set; }

    /// <summary>Specifies whether the .snapshot (NFS clients) or ~snapshot (SMB clients) path of a volume is visible, default value is true.</summary>
    [JsonPropertyName("snapshotDirectoryVisible")]
    public bool? SnapshotDirectoryVisible { get; set; }

    /// <summary>The maximum Storage Quota allowed for a file system in Gigabytes.</summary>
    [JsonPropertyName("storageQuotaInGb")]
    public double? StorageQuotaInGb { get; set; }

    /// <summary>The ID of the Subnet the NetApp Volume resides in, which must have the Microsoft.NetApp/volumes delegation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1VolumeSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1VolumeSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput of this volume in Mibps.</summary>
    [JsonPropertyName("throughputInMibps")]
    public double? ThroughputInMibps { get; set; }

    /// <summary>A unique file path for the volume. Used when creating mount targets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumePath")]
    public string? VolumePath { get; set; }

    /// <summary>Specifies the Availability Zone in which the Volume should be located. Possible values are 1, 2 and 3. Changing this forces a new resource to be created. This feature is currently in preview, for more information on how to enable it, please refer to Manage availability zone volume placement for Azure NetApp Files.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public enum V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
public partial class V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
public partial class V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Volume in netapp to populate remoteVolumeResourceId.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Volume in netapp to populate remoteVolumeResourceId.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionReplication
{
    /// <summary>The endpoint type, default value is dst for destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Location of the primary volume. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVolumeLocation")]
    public string? RemoteVolumeLocation { get; set; }

    /// <summary>Resource ID of the primary volume.</summary>
    [JsonPropertyName("remoteVolumeResourceId")]
    public string? RemoteVolumeResourceId { get; set; }

    /// <summary>Reference to a Volume in netapp to populate remoteVolumeResourceId.</summary>
    [JsonPropertyName("remoteVolumeResourceIdRef")]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdRef? RemoteVolumeResourceIdRef { get; set; }

    /// <summary>Selector for a Volume in netapp to populate remoteVolumeResourceId.</summary>
    [JsonPropertyName("remoteVolumeResourceIdSelector")]
    public V1beta1VolumeSpecInitProviderDataProtectionReplicationRemoteVolumeResourceIdSelector? RemoteVolumeResourceIdSelector { get; set; }

    /// <summary>Replication frequency, supported values are '10minutes', 'hourly', 'daily', values are case sensitive.</summary>
    [JsonPropertyName("replicationFrequency")]
    public string? ReplicationFrequency { get; set; }
}

public enum V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicy
{
    /// <summary>Resource ID of the snapshot policy to apply to the volume.</summary>
    [JsonPropertyName("snapshotPolicyId")]
    public string? SnapshotPolicyId { get; set; }

    /// <summary>Reference to a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
    [JsonPropertyName("snapshotPolicyIdRef")]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdRef? SnapshotPolicyIdRef { get; set; }

    /// <summary>Selector for a SnapshotPolicy in netapp to populate snapshotPolicyId.</summary>
    [JsonPropertyName("snapshotPolicyIdSelector")]
    public V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicySnapshotPolicyIdSelector? SnapshotPolicyIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeSpecInitProviderExportPolicyRule
{
    /// <summary>A list of allowed clients IPv4 addresses.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>A list of allowed protocols. Valid values include CIFS, NFSv3, or NFSv4.1. Only one value is supported at this time. This replaces the previous arguments: cifs_enabled, nfsv3_enabled and nfsv4_enabled.</summary>
    [JsonPropertyName("protocolsEnabled")]
    public IList<string>? ProtocolsEnabled { get; set; }

    /// <summary>Is root access permitted to this volume?</summary>
    [JsonPropertyName("rootAccessEnabled")]
    public bool? RootAccessEnabled { get; set; }

    /// <summary>The index number of the rule.</summary>
    [JsonPropertyName("ruleIndex")]
    public double? RuleIndex { get; set; }

    /// <summary>Is the file system on unix read only?</summary>
    [JsonPropertyName("unixReadOnly")]
    public bool? UnixReadOnly { get; set; }

    /// <summary>Is the file system on unix read and write?</summary>
    [JsonPropertyName("unixReadWrite")]
    public bool? UnixReadWrite { get; set; }
}

public enum V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1VolumeSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1VolumeSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VolumeSpecInitProvider
{
    /// <summary>Is the NetApp Volume enabled for Azure VMware Solution (AVS) datastore purpose. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("azureVmwareDataStoreEnabled")]
    public bool? AzureVmwareDataStoreEnabled { get; set; }

    /// <summary>Creates volume from snapshot. Following properties must be the same as the original volume where the snapshot was taken from: protocols, subnet_id, location, service_level, resource_group_name, account_name and pool_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createFromSnapshotResourceId")]
    public string? CreateFromSnapshotResourceId { get; set; }

    /// <summary>Reference to a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
    [JsonPropertyName("createFromSnapshotResourceIdRef")]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdRef? CreateFromSnapshotResourceIdRef { get; set; }

    /// <summary>Selector for a Snapshot in netapp to populate createFromSnapshotResourceId.</summary>
    [JsonPropertyName("createFromSnapshotResourceIdSelector")]
    public V1beta1VolumeSpecInitProviderCreateFromSnapshotResourceIdSelector? CreateFromSnapshotResourceIdSelector { get; set; }

    /// <summary>A data_protection_replication block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataProtectionReplication")]
    public IList<V1beta1VolumeSpecInitProviderDataProtectionReplication>? DataProtectionReplication { get; set; }

    /// <summary>A data_protection_snapshot_policy block as defined below.</summary>
    [JsonPropertyName("dataProtectionSnapshotPolicy")]
    public IList<V1beta1VolumeSpecInitProviderDataProtectionSnapshotPolicy>? DataProtectionSnapshotPolicy { get; set; }

    /// <summary>The encryption key source, it can be Microsoft.NetApp for platform managed keys or Microsoft.KeyVault for customer-managed keys. This is required with key_vault_private_endpoint_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionKeySource")]
    public string? EncryptionKeySource { get; set; }

    /// <summary>One or more export_policy_rule block defined below.</summary>
    [JsonPropertyName("exportPolicyRule")]
    public IList<V1beta1VolumeSpecInitProviderExportPolicyRule>? ExportPolicyRule { get; set; }

    /// <summary>The Private Endpoint ID for Key Vault, which is required when using customer-managed keys. This is required with encryption_key_source. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultPrivateEndpointId")]
    public string? KeyVaultPrivateEndpointId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Indicates which network feature to use, accepted values are Basic or Standard, it defaults to Basic if not defined. This is a feature in public preview and for more information about it and how to register, please refer to Configure network features for an Azure NetApp Files volume.</summary>
    [JsonPropertyName("networkFeatures")]
    public string? NetworkFeatures { get; set; }

    /// <summary>The target volume protocol expressed as a list. Supported single value include CIFS, NFSv3, or NFSv4.1. If argument is not defined it will default to NFSv3. Changing this forces a new resource to be created and data will be lost. Dual protocol scenario is supported for CIFS and NFSv3, for more information, please refer to Create a dual-protocol volume for Azure NetApp Files document.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Volume security style, accepted values are unix or ntfs. If not provided, single-protocol volume is created defaulting to unix if it is NFSv3 or NFSv4.1 volume, if CIFS, it will default to ntfs. In a dual-protocol volume, if not provided, its value will be ntfs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityStyle")]
    public string? SecurityStyle { get; set; }

    /// <summary>The target performance of the file system. Valid values include Premium, Standard, or Ultra. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; set; }

    /// <summary>Limits enumeration of files and folders (that is, listing the contents) in SMB only to users with allowed access on the share. For instance, if a user doesn't have access to read a file or folder in a share with access-based enumeration enabled, then the file or folder doesn't show up in directory listings. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbAccessBasedEnumerationEnabled")]
    public bool? SmbAccessBasedEnumerationEnabled { get; set; }

    /// <summary>Limits clients from browsing for an SMB share by hiding the share from view in Windows Explorer or when listing shares in "net view." Only end users that know the absolute paths to the share are able to find the share. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbNonBrowsableEnabled")]
    public bool? SmbNonBrowsableEnabled { get; set; }

    /// <summary>Specifies whether the .snapshot (NFS clients) or ~snapshot (SMB clients) path of a volume is visible, default value is true.</summary>
    [JsonPropertyName("snapshotDirectoryVisible")]
    public bool? SnapshotDirectoryVisible { get; set; }

    /// <summary>The maximum Storage Quota allowed for a file system in Gigabytes.</summary>
    [JsonPropertyName("storageQuotaInGb")]
    public double? StorageQuotaInGb { get; set; }

    /// <summary>The ID of the Subnet the NetApp Volume resides in, which must have the Microsoft.NetApp/volumes delegation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1VolumeSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1VolumeSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput of this volume in Mibps.</summary>
    [JsonPropertyName("throughputInMibps")]
    public double? ThroughputInMibps { get; set; }

    /// <summary>A unique file path for the volume. Used when creating mount targets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumePath")]
    public string? VolumePath { get; set; }

    /// <summary>Specifies the Availability Zone in which the Volume should be located. Possible values are 1, 2 and 3. Changing this forces a new resource to be created. This feature is currently in preview, for more information on how to enable it, please refer to Manage availability zone volume placement for Azure NetApp Files.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public enum V1beta1VolumeSpecManagementPoliciesEnum
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

public enum V1beta1VolumeSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VolumeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VolumeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VolumeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VolumeSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VolumeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VolumeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VolumeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VolumeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VolumeSpec defines the desired state of Volume</summary>
public partial class V1beta1VolumeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VolumeSpecDeletionPolicyEnum>))]
    public V1beta1VolumeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VolumeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VolumeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VolumeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VolumeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VolumeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VolumeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeStatusAtProviderDataProtectionReplication
{
    /// <summary>The endpoint type, default value is dst for destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Location of the primary volume. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVolumeLocation")]
    public string? RemoteVolumeLocation { get; set; }

    /// <summary>Resource ID of the primary volume.</summary>
    [JsonPropertyName("remoteVolumeResourceId")]
    public string? RemoteVolumeResourceId { get; set; }

    /// <summary>Replication frequency, supported values are '10minutes', 'hourly', 'daily', values are case sensitive.</summary>
    [JsonPropertyName("replicationFrequency")]
    public string? ReplicationFrequency { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeStatusAtProviderDataProtectionSnapshotPolicy
{
    /// <summary>Resource ID of the snapshot policy to apply to the volume.</summary>
    [JsonPropertyName("snapshotPolicyId")]
    public string? SnapshotPolicyId { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeStatusAtProviderExportPolicyRule
{
    /// <summary>A list of allowed clients IPv4 addresses.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>A list of allowed protocols. Valid values include CIFS, NFSv3, or NFSv4.1. Only one value is supported at this time. This replaces the previous arguments: cifs_enabled, nfsv3_enabled and nfsv4_enabled.</summary>
    [JsonPropertyName("protocolsEnabled")]
    public IList<string>? ProtocolsEnabled { get; set; }

    /// <summary>Is root access permitted to this volume?</summary>
    [JsonPropertyName("rootAccessEnabled")]
    public bool? RootAccessEnabled { get; set; }

    /// <summary>The index number of the rule.</summary>
    [JsonPropertyName("ruleIndex")]
    public double? RuleIndex { get; set; }

    /// <summary>Is the file system on unix read only?</summary>
    [JsonPropertyName("unixReadOnly")]
    public bool? UnixReadOnly { get; set; }

    /// <summary>Is the file system on unix read and write?</summary>
    [JsonPropertyName("unixReadWrite")]
    public bool? UnixReadWrite { get; set; }
}

/// <summary></summary>
public partial class V1beta1VolumeStatusAtProvider
{
    /// <summary>The name of the NetApp account in which the NetApp Pool should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Is the NetApp Volume enabled for Azure VMware Solution (AVS) datastore purpose. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("azureVmwareDataStoreEnabled")]
    public bool? AzureVmwareDataStoreEnabled { get; set; }

    /// <summary>Creates volume from snapshot. Following properties must be the same as the original volume where the snapshot was taken from: protocols, subnet_id, location, service_level, resource_group_name, account_name and pool_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createFromSnapshotResourceId")]
    public string? CreateFromSnapshotResourceId { get; set; }

    /// <summary>A data_protection_replication block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataProtectionReplication")]
    public IList<V1beta1VolumeStatusAtProviderDataProtectionReplication>? DataProtectionReplication { get; set; }

    /// <summary>A data_protection_snapshot_policy block as defined below.</summary>
    [JsonPropertyName("dataProtectionSnapshotPolicy")]
    public IList<V1beta1VolumeStatusAtProviderDataProtectionSnapshotPolicy>? DataProtectionSnapshotPolicy { get; set; }

    /// <summary>The encryption key source, it can be Microsoft.NetApp for platform managed keys or Microsoft.KeyVault for customer-managed keys. This is required with key_vault_private_endpoint_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionKeySource")]
    public string? EncryptionKeySource { get; set; }

    /// <summary>One or more export_policy_rule block defined below.</summary>
    [JsonPropertyName("exportPolicyRule")]
    public IList<V1beta1VolumeStatusAtProviderExportPolicyRule>? ExportPolicyRule { get; set; }

    /// <summary>The ID of the NetApp Volume.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Private Endpoint ID for Key Vault, which is required when using customer-managed keys. This is required with encryption_key_source. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultPrivateEndpointId")]
    public string? KeyVaultPrivateEndpointId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of IPv4 Addresses which should be used to mount the volume.</summary>
    [JsonPropertyName("mountIpAddresses")]
    public IList<string>? MountIpAddresses { get; set; }

    /// <summary>Indicates which network feature to use, accepted values are Basic or Standard, it defaults to Basic if not defined. This is a feature in public preview and for more information about it and how to register, please refer to Configure network features for an Azure NetApp Files volume.</summary>
    [JsonPropertyName("networkFeatures")]
    public string? NetworkFeatures { get; set; }

    /// <summary>The name of the NetApp pool in which the NetApp Volume should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary>The target volume protocol expressed as a list. Supported single value include CIFS, NFSv3, or NFSv4.1. If argument is not defined it will default to NFSv3. Changing this forces a new resource to be created and data will be lost. Dual protocol scenario is supported for CIFS and NFSv3, for more information, please refer to Create a dual-protocol volume for Azure NetApp Files document.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The name of the resource group where the NetApp Volume should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Volume security style, accepted values are unix or ntfs. If not provided, single-protocol volume is created defaulting to unix if it is NFSv3 or NFSv4.1 volume, if CIFS, it will default to ntfs. In a dual-protocol volume, if not provided, its value will be ntfs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityStyle")]
    public string? SecurityStyle { get; set; }

    /// <summary>The target performance of the file system. Valid values include Premium, Standard, or Ultra. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; set; }

    /// <summary>Limits enumeration of files and folders (that is, listing the contents) in SMB only to users with allowed access on the share. For instance, if a user doesn't have access to read a file or folder in a share with access-based enumeration enabled, then the file or folder doesn't show up in directory listings. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbAccessBasedEnumerationEnabled")]
    public bool? SmbAccessBasedEnumerationEnabled { get; set; }

    /// <summary>Limits clients from browsing for an SMB share by hiding the share from view in Windows Explorer or when listing shares in "net view." Only end users that know the absolute paths to the share are able to find the share. Defaults to false. For more information, please refer to Understand NAS share permissions in Azure NetApp Files</summary>
    [JsonPropertyName("smbNonBrowsableEnabled")]
    public bool? SmbNonBrowsableEnabled { get; set; }

    /// <summary>Specifies whether the .snapshot (NFS clients) or ~snapshot (SMB clients) path of a volume is visible, default value is true.</summary>
    [JsonPropertyName("snapshotDirectoryVisible")]
    public bool? SnapshotDirectoryVisible { get; set; }

    /// <summary>The maximum Storage Quota allowed for a file system in Gigabytes.</summary>
    [JsonPropertyName("storageQuotaInGb")]
    public double? StorageQuotaInGb { get; set; }

    /// <summary>The ID of the Subnet the NetApp Volume resides in, which must have the Microsoft.NetApp/volumes delegation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput of this volume in Mibps.</summary>
    [JsonPropertyName("throughputInMibps")]
    public double? ThroughputInMibps { get; set; }

    /// <summary>A unique file path for the volume. Used when creating mount targets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("volumePath")]
    public string? VolumePath { get; set; }

    /// <summary>Specifies the Availability Zone in which the Volume should be located. Possible values are 1, 2 and 3. Changing this forces a new resource to be created. This feature is currently in preview, for more information on how to enable it, please refer to Manage availability zone volume placement for Azure NetApp Files.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VolumeStatusConditions
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

/// <summary>VolumeStatus defines the observed state of Volume.</summary>
public partial class V1beta1VolumeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VolumeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VolumeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Volume is the Schema for the Volumes API. Manages a NetApp Volume.</summary>
public partial class V1beta1Volume : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VolumeSpec>, IStatus<V1beta1VolumeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Volume";
    public const string KubeGroup = "netapp.azure.upbound.io";
    public const string KubePluralName = "volumes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VolumeSpec defines the desired state of Volume</summary>
    [JsonPropertyName("spec")]
    public V1beta1VolumeSpec Spec { get; set; }

    /// <summary>VolumeStatus defines the observed state of Volume.</summary>
    [JsonPropertyName("status")]
    public V1beta1VolumeStatus? Status { get; set; }
}