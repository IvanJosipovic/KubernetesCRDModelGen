using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.cnrm.cloud.google.com;
/// <summary>DataplexLake is the Schema for the DataplexLake API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexLakeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexLake>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexLakeList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexlakes";
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
    public IList<V1alpha1DataplexLake> Items { get; set; }
}

/// <summary>Optional. A relative reference to the Dataproc Metastore (https://cloud.google.com/dataproc-metastore/docs) service associated with the lake: `projects/{project_id}/locations/{location_id}/services/{service_id}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeSpecMetastoreServiceRef
{
    /// <summary>A reference to an externally managed DataprocJob resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/services/{{serviceID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary>Optional. Settings to manage lake and Dataproc Metastore service instance association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeSpecMetastore
{
    /// <summary>Optional. A relative reference to the Dataproc Metastore (https://cloud.google.com/dataproc-metastore/docs) service associated with the lake: `projects/{project_id}/locations/{location_id}/services/{service_id}`</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1DataplexLakeSpecMetastoreServiceRef? ServiceRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DataplexLakeSpec defines the desired state of DataplexLake</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeSpec
{
    /// <summary>Optional. Description of the lake.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User-defined labels for the lake.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Settings to manage lake and Dataproc Metastore service instance association.</summary>
    [JsonPropertyName("metastore")]
    public V1alpha1DataplexLakeSpecMetastore? Metastore { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataplexLakeSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataplexLake name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeStatusConditions
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

/// <summary>Output only. Aggregated status of the underlying assets of the lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeStatusObservedStateAssetStatus
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

/// <summary>Output only. Metastore status of the lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeStatusObservedStateMetastoreStatus
{
    /// <summary>The URI of the endpoint used to access the Metastore service.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Additional information about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Current state of association.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Last update time of the metastore status of the lake.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeStatusObservedState
{
    /// <summary>Output only. Aggregated status of the underlying assets of the lake.</summary>
    [JsonPropertyName("assetStatus")]
    public V1alpha1DataplexLakeStatusObservedStateAssetStatus? AssetStatus { get; set; }

    /// <summary>Output only. The time when the lake was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Metastore status of the lake.</summary>
    [JsonPropertyName("metastoreStatus")]
    public V1alpha1DataplexLakeStatusObservedStateMetastoreStatus? MetastoreStatus { get; set; }

    /// <summary>Output only. Service account associated with this lake. This service account must be authorized to access or operate on resources managed by the lake.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Output only. Current state of the lake.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System generated globally unique ID for the lake. This ID will be different if the lake is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the lake was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexLakeStatus defines the config connector machine state of DataplexLake</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexLakeStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexLakeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexLake resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexLakeStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexLake is the Schema for the DataplexLake API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexLake : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexLakeSpec>, IStatus<V1alpha1DataplexLakeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexLake";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexlakes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexLakeSpec defines the desired state of DataplexLake</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataplexLakeSpec Spec { get; set; }

    /// <summary>DataplexLakeStatus defines the config connector machine state of DataplexLake</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexLakeStatus? Status { get; set; }
}