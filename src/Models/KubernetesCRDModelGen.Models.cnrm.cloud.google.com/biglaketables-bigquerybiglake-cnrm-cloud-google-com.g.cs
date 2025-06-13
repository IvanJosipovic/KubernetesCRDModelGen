using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerybiglake.cnrm.cloud.google.com;
/// <summary>The BigLakeCatalog that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecCatalogRef
{
    /// <summary>A reference to an externally managed BigLakeCatalog resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/catalogs/{{catalogID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigLakeCatalog resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigLakeCatalog resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The parent resource where this table will be created. Format: projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecDatabaseRef
{
    /// <summary>A reference to an externally managed BigLakeDatabase resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/databases/{{databaseID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigLakeDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigLakeDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Serializer and deserializer information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecHiveOptionsStorageDescriptorSerdeInfo
{
    /// <summary>The fully qualified Java class name of the serialization library.</summary>
    [JsonPropertyName("serializationLib")]
    public string? SerializationLib { get; set; }
}

/// <summary>Stores physical storage information of the data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecHiveOptionsStorageDescriptor
{
    /// <summary>The fully qualified Java class name of the input format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Cloud Storage folder URI where the table data is stored, starting with "gs://".</summary>
    [JsonPropertyName("locationURI")]
    public string? LocationURI { get; set; }

    /// <summary>The fully qualified Java class name of the output format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Serializer and deserializer information.</summary>
    [JsonPropertyName("serdeInfo")]
    public V1alpha1BigLakeTableSpecHiveOptionsStorageDescriptorSerdeInfo? SerdeInfo { get; set; }
}

/// <summary>Options of a Hive table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecHiveOptions
{
    /// <summary>Stores user supplied Hive table parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Stores physical storage information of the data.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1alpha1BigLakeTableSpecHiveOptionsStorageDescriptor? StorageDescriptor { get; set; }

    /// <summary>Hive table type. For example, MANAGED_TABLE, EXTERNAL_TABLE.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpecProjectRef
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

/// <summary>BigLakeTableSpec defines the desired state of BigLakeTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableSpec
{
    /// <summary>The BigLakeCatalog that this resource belongs to.</summary>
    [JsonPropertyName("catalogRef")]
    public V1alpha1BigLakeTableSpecCatalogRef CatalogRef { get; set; }

    /// <summary>Required. The parent resource where this table will be created. Format: projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}</summary>
    [JsonPropertyName("databaseRef")]
    public V1alpha1BigLakeTableSpecDatabaseRef DatabaseRef { get; set; }

    /// <summary>The checksum of a table object computed by the server based on the value of other fields. It may be sent on update requests to ensure the client has an up-to-date value before proceeding. It is only checked for update table operations.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Options of a Hive table.</summary>
    [JsonPropertyName("hiveOptions")]
    public V1alpha1BigLakeTableSpecHiveOptions? HiveOptions { get; set; }

    /// <summary>Immutable. The location where the Table should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigLakeTableSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BigLake Table ID. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableStatusObservedState
{
    /// <summary>Output only. The creation time of the table.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The deletion time of the table. Only set after the table is deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. The time when this table is considered expired. Only set after the table is deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The last modification time of the table.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BigLakeTableStatus defines the config connector machine state of BigLakeTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeTableStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigLakeTableStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigLakeTable resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigLakeTableStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigLakeTable is the Schema for the BigLakeTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigLakeTableSpec>, IStatus<V1alpha1BigLakeTableStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeTable";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglaketables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigLakeTableSpec defines the desired state of BigLakeTable</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigLakeTableSpec Spec { get; set; }

    /// <summary>BigLakeTableStatus defines the config connector machine state of BigLakeTable</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigLakeTableStatus? Status { get; set; }
}

/// <summary>BigLakeTable is the Schema for the BigLakeTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeTableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigLakeTable>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeTableList";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglaketables";
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
    public IList<V1alpha1BigLakeTable> Items { get; set; }
}