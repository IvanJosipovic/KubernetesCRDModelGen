using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
public enum V1beta1GalleryApplicationVersionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderManageAction
{
    /// <summary>The command to install the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("install")]
    public string? Install { get; set; }

    /// <summary>The command to remove the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remove")]
    public string? Remove { get; set; }

    /// <summary>The command to update the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("update")]
    public string? Update { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderSource
{
    /// <summary>The Storage Blob URI of the default configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultConfigurationLink")]
    public string? DefaultConfigurationLink { get; set; }

    /// <summary>The Storage Blob URI of the source application package. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mediaLink")]
    public string? MediaLink { get; set; }

    /// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
    [JsonPropertyName("mediaLinkRef")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRef? MediaLinkRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
    [JsonPropertyName("mediaLinkSelector")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelector? MediaLinkSelector { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegion
{
    /// <summary>Specifies whether this Gallery Application Version should be excluded from the latest filter. If set to true, this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The Azure Region in which the Gallery Application Version exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRef? NameRef { get; set; }

    /// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelector? NameSelector { get; set; }

    /// <summary>The number of replicas of the Gallery Application Version to be created per region. Possible values are between 1 and 10.</summary>
    [JsonPropertyName("regionalReplicaCount")]
    public double? RegionalReplicaCount { get; set; }

    /// <summary>The storage account type for the Gallery Application Version. Possible values are Standard_LRS, Premium_LRS and Standard_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecForProvider
{
    /// <summary>Specifies the name of the config file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configFile")]
    public string? ConfigFile { get; set; }

    /// <summary>Should the Gallery Application reports health. Defaults to false.</summary>
    [JsonPropertyName("enableHealthCheck")]
    public bool? EnableHealthCheck { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Gallery Application Version.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>Should the Gallery Application Version be excluded from the latest filter? If set to true this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The ID of the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryApplicationId")]
    public string? GalleryApplicationId { get; set; }

    /// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
    [JsonPropertyName("galleryApplicationIdRef")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRef? GalleryApplicationIdRef { get; set; }

    /// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
    [JsonPropertyName("galleryApplicationIdSelector")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelector? GalleryApplicationIdSelector { get; set; }

    /// <summary>The Azure Region where the Gallery Application Version exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manage_action block as defined below.</summary>
    [JsonPropertyName("manageAction")]
    public IList<V1beta1GalleryApplicationVersionSpecForProviderManageAction>? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1GalleryApplicationVersionSpecForProviderSource>? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionSpecForProviderTargetRegion>? TargetRegion { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderManageAction
{
    /// <summary>The command to install the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("install")]
    public string? Install { get; set; }

    /// <summary>The command to remove the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remove")]
    public string? Remove { get; set; }

    /// <summary>The command to update the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("update")]
    public string? Update { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSource
{
    /// <summary>The Storage Blob URI of the default configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultConfigurationLink")]
    public string? DefaultConfigurationLink { get; set; }

    /// <summary>The Storage Blob URI of the source application package. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mediaLink")]
    public string? MediaLink { get; set; }

    /// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
    [JsonPropertyName("mediaLinkRef")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRef? MediaLinkRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
    [JsonPropertyName("mediaLinkSelector")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelector? MediaLinkSelector { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegion
{
    /// <summary>Specifies whether this Gallery Application Version should be excluded from the latest filter. If set to true, this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The Azure Region in which the Gallery Application Version exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRef? NameRef { get; set; }

    /// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelector? NameSelector { get; set; }

    /// <summary>The number of replicas of the Gallery Application Version to be created per region. Possible values are between 1 and 10.</summary>
    [JsonPropertyName("regionalReplicaCount")]
    public double? RegionalReplicaCount { get; set; }

    /// <summary>The storage account type for the Gallery Application Version. Possible values are Standard_LRS, Premium_LRS and Standard_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1GalleryApplicationVersionSpecInitProvider
{
    /// <summary>Specifies the name of the config file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configFile")]
    public string? ConfigFile { get; set; }

    /// <summary>Should the Gallery Application reports health. Defaults to false.</summary>
    [JsonPropertyName("enableHealthCheck")]
    public bool? EnableHealthCheck { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Gallery Application Version.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>Should the Gallery Application Version be excluded from the latest filter? If set to true this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The ID of the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryApplicationId")]
    public string? GalleryApplicationId { get; set; }

    /// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
    [JsonPropertyName("galleryApplicationIdRef")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRef? GalleryApplicationIdRef { get; set; }

    /// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
    [JsonPropertyName("galleryApplicationIdSelector")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelector? GalleryApplicationIdSelector { get; set; }

    /// <summary>The Azure Region where the Gallery Application Version exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manage_action block as defined below.</summary>
    [JsonPropertyName("manageAction")]
    public IList<V1beta1GalleryApplicationVersionSpecInitProviderManageAction>? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1GalleryApplicationVersionSpecInitProviderSource>? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegion>? TargetRegion { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecManagementPoliciesEnum
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

public enum V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1GalleryApplicationVersionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1GalleryApplicationVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>GalleryApplicationVersionSpec defines the desired state of GalleryApplicationVersion</summary>
public partial class V1beta1GalleryApplicationVersionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GalleryApplicationVersionSpecDeletionPolicyEnum>))]
    public V1beta1GalleryApplicationVersionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GalleryApplicationVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GalleryApplicationVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GalleryApplicationVersionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GalleryApplicationVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1GalleryApplicationVersionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GalleryApplicationVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionStatusAtProviderManageAction
{
    /// <summary>The command to install the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("install")]
    public string? Install { get; set; }

    /// <summary>The command to remove the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remove")]
    public string? Remove { get; set; }

    /// <summary>The command to update the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("update")]
    public string? Update { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionStatusAtProviderSource
{
    /// <summary>The Storage Blob URI of the default configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultConfigurationLink")]
    public string? DefaultConfigurationLink { get; set; }

    /// <summary>The Storage Blob URI of the source application package. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("mediaLink")]
    public string? MediaLink { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionStatusAtProviderTargetRegion
{
    /// <summary>Specifies whether this Gallery Application Version should be excluded from the latest filter. If set to true, this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The Azure Region in which the Gallery Application Version exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of replicas of the Gallery Application Version to be created per region. Possible values are between 1 and 10.</summary>
    [JsonPropertyName("regionalReplicaCount")]
    public double? RegionalReplicaCount { get; set; }

    /// <summary>The storage account type for the Gallery Application Version. Possible values are Standard_LRS, Premium_LRS and Standard_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary></summary>
public partial class V1beta1GalleryApplicationVersionStatusAtProvider
{
    /// <summary>Specifies the name of the config file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configFile")]
    public string? ConfigFile { get; set; }

    /// <summary>Should the Gallery Application reports health. Defaults to false.</summary>
    [JsonPropertyName("enableHealthCheck")]
    public bool? EnableHealthCheck { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Gallery Application Version.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>Should the Gallery Application Version be excluded from the latest filter? If set to true this Gallery Application Version won't be returned for the latest version. Defaults to false.</summary>
    [JsonPropertyName("excludeFromLatest")]
    public bool? ExcludeFromLatest { get; set; }

    /// <summary>The ID of the Gallery Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryApplicationId")]
    public string? GalleryApplicationId { get; set; }

    /// <summary>The ID of the Gallery Application Version.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Gallery Application Version exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manage_action block as defined below.</summary>
    [JsonPropertyName("manageAction")]
    public IList<V1beta1GalleryApplicationVersionStatusAtProviderManageAction>? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1GalleryApplicationVersionStatusAtProviderSource>? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionStatusAtProviderTargetRegion>? TargetRegion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1GalleryApplicationVersionStatusConditions
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

/// <summary>GalleryApplicationVersionStatus defines the observed state of GalleryApplicationVersion.</summary>
public partial class V1beta1GalleryApplicationVersionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GalleryApplicationVersionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GalleryApplicationVersionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>GalleryApplicationVersion is the Schema for the GalleryApplicationVersions API. Manages a Gallery Application Version.</summary>
public partial class V1beta1GalleryApplicationVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GalleryApplicationVersionSpec>, IStatus<V1beta1GalleryApplicationVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GalleryApplicationVersion";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "galleryapplicationversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GalleryApplicationVersionSpec defines the desired state of GalleryApplicationVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1GalleryApplicationVersionSpec Spec { get; set; }

    /// <summary>GalleryApplicationVersionStatus defines the observed state of GalleryApplicationVersion.</summary>
    [JsonPropertyName("status")]
    public V1beta1GalleryApplicationVersionStatus? Status { get; set; }
}