using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.m.upbound.io;
/// <summary>GalleryApplicationVersion is the Schema for the GalleryApplicationVersions API. Manages a Gallery Application Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GalleryApplicationVersionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GalleryApplicationVersion>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GalleryApplicationVersionList";
    public const string KubeGroup = "compute.azure.m.upbound.io";
    public const string KubePluralName = "galleryapplicationversions";
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
    public IList<V1beta1GalleryApplicationVersion> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderGalleryApplicationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A manage_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderSourceMediaLinkSelectorPolicy? Policy { get; set; }
}

/// <summary>A source block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecForProviderTargetRegionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1GalleryApplicationVersionSpecForProviderManageAction? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public V1beta1GalleryApplicationVersionSpecForProviderSource? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionSpecForProviderTargetRegion>? TargetRegion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate galleryApplicationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate galleryApplicationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderGalleryApplicationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A manage_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Blob in storage to populate mediaLink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Blob in storage to populate mediaLink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSourceMediaLinkSelectorPolicy? Policy { get; set; }
}

/// <summary>A source block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GalleryApplication in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GalleryApplication in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GalleryApplicationVersionSpecInitProviderTargetRegionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1GalleryApplicationVersionSpecInitProviderManageAction? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public V1beta1GalleryApplicationVersionSpecInitProviderSource? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionSpecInitProviderTargetRegion>? TargetRegion { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpecProviderConfigRef
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
public partial class V1beta1GalleryApplicationVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GalleryApplicationVersionSpec defines the desired state of GalleryApplicationVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GalleryApplicationVersionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GalleryApplicationVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GalleryApplicationVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GalleryApplicationVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GalleryApplicationVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A manage_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A source block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1GalleryApplicationVersionStatusAtProviderManageAction? ManageAction { get; set; }

    /// <summary>The version name of the Gallery Application Version, such as 1.0.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the name of the package file on the VM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("packageFile")]
    public string? PackageFile { get; set; }

    /// <summary>A source block as defined below.</summary>
    [JsonPropertyName("source")]
    public V1beta1GalleryApplicationVersionStatusAtProviderSource? Source { get; set; }

    /// <summary>A mapping of tags to assign to the Gallery Application Version.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more target_region blocks as defined below.</summary>
    [JsonPropertyName("targetRegion")]
    public IList<V1beta1GalleryApplicationVersionStatusAtProviderTargetRegion>? TargetRegion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>GalleryApplicationVersion is the Schema for the GalleryApplicationVersions API. Manages a Gallery Application Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GalleryApplicationVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GalleryApplicationVersionSpec>, IStatus<V1beta1GalleryApplicationVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GalleryApplicationVersion";
    public const string KubeGroup = "compute.azure.m.upbound.io";
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