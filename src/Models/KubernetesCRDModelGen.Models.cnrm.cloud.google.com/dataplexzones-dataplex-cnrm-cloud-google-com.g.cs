using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.cnrm.cloud.google.com;
/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpecDiscoverySpecCsvOptions
{
    /// <summary>Optional. The delimiter being used to separate values. This defaults to ','.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Optional. Whether to disable the inference of data type for CSV data. If true, all columns will be registered as strings.</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.</summary>
    [JsonPropertyName("headerRows")]
    public int? HeaderRows { get; set; }
}

/// <summary>Optional. Configuration for Json data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpecDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Optional. Specification of the discovery feature applied to data in this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpecDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1alpha1DataplexZoneSpecDiscoverySpecCsvOptions? CsvOptions { get; set; }

    /// <summary>Required. Whether discovery is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to exclude during discovery.  For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("includePatterns")]
    public IList<string>? IncludePatterns { get; set; }

    /// <summary>Optional. Configuration for Json data.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1alpha1DataplexZoneSpecDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: "CRON_TZ=${IANA_TIME_ZONE}" or TZ=${IANA_TIME_ZONE}". The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, `CRON_TZ=America/New_York 1 * * * *`, or `TZ=America/New_York 1 * * * *`.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>Reference to the parent DataplexLake that owns this Zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpecLakeRef
{
    /// <summary>A reference to an externally managed DataplexLake resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/lakes/{{lakeID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexLake resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexLake resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Specification of the resources that are referenced by the assets within this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpecResourceSpec
{
    /// <summary>Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone.</summary>
    [JsonPropertyName("locationType")]
    public string? LocationType { get; set; }
}

/// <summary>DataplexZoneSpec defines the desired state of DataplexZone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneSpec
{
    /// <summary>Optional. Description of the zone.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Specification of the discovery feature applied to data in this zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1alpha1DataplexZoneSpecDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User defined labels for the zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Reference to the parent DataplexLake that owns this Zone.</summary>
    [JsonPropertyName("lakeRef")]
    public V1alpha1DataplexZoneSpecLakeRef LakeRef { get; set; }

    /// <summary>The DataplexZone name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Specification of the resources that are referenced by the assets within this zone.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1alpha1DataplexZoneSpecResourceSpec ResourceSpec { get; set; }

    /// <summary>Required. Immutable. The type of the zone.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneStatusConditions
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

/// <summary>Output only. Aggregated status of the underlying assets of the zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneStatusObservedStateAssetStatus
{
    /// <summary>Number of active assets.</summary>
    [JsonPropertyName("activeAssets")]
    public int? ActiveAssets { get; set; }

    /// <summary>Number of assets that are in process of updating the security policy on attached resources.</summary>
    [JsonPropertyName("securityPolicyApplyingAssets")]
    public int? SecurityPolicyApplyingAssets { get; set; }

    /// <summary>Last update time of the status.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneStatusObservedState
{
    /// <summary>Output only. Aggregated status of the underlying assets of the zone.</summary>
    [JsonPropertyName("assetStatus")]
    public V1alpha1DataplexZoneStatusObservedStateAssetStatus? AssetStatus { get; set; }

    /// <summary>Output only. The time when the zone was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Current state of the zone.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System generated globally unique ID for the zone. This ID will be different if the zone is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the zone was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexZoneStatus defines the config connector machine state of DataplexZone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexZoneStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexZoneStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexZone resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexZoneStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexZone is the Schema for the DataplexZone API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexZoneSpec>, IStatus<V1alpha1DataplexZoneStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexZone";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexzones";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexZoneSpec defines the desired state of DataplexZone</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataplexZoneSpec Spec { get; set; }

    /// <summary>DataplexZoneStatus defines the config connector machine state of DataplexZone</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexZoneStatus? Status { get; set; }
}

/// <summary>DataplexZone is the Schema for the DataplexZone API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexZoneList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexZone>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexZoneList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexzones";
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
    public IList<V1alpha1DataplexZone> Items { get; set; }
}