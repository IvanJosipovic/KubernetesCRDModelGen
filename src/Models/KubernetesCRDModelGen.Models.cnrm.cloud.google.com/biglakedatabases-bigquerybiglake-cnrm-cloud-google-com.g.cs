using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerybiglake.cnrm.cloud.google.com;
/// <summary>BigLakeDatabase is the Schema for the BigLakeDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigLakeDatabase>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeDatabaseList";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglakedatabases";
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
    public IList<V1alpha1BigLakeDatabase> Items { get; set; }
}

/// <summary>Options of a Hive database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpecHiveOptions
{
    /// <summary>Cloud Storage folder URI where the database data is stored, starting with "gs://".</summary>
    [JsonPropertyName("locationURI")]
    public string? LocationURI { get; set; }

    /// <summary>Stores user supplied Hive database parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpecProjectRef
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

/// <summary>BigLakeDatabaseSpec defines the desired state of BigLakeDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpec
{
    /// <summary>Options of a Hive database.</summary>
    [JsonPropertyName("hiveOptions")]
    public V1alpha1BigLakeDatabaseSpecHiveOptions? HiveOptions { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigLakeDatabaseSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The BigLakeDatabase name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The database type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseStatusConditions
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
public partial class V1alpha1BigLakeDatabaseStatusObservedState
{
    /// <summary>Output only. The creation time of the database.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The deletion time of the database. Only set after the database is deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. The time when this database is considered expired. Only set after the database is deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The last modification time of the database.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BigLakeDatabaseStatus defines the config connector machine state of BigLakeDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigLakeDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigLakeDatabase resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigLakeDatabaseStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigLakeDatabase is the Schema for the BigLakeDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigLakeDatabaseSpec>, IStatus<V1alpha1BigLakeDatabaseStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeDatabase";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglakedatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigLakeDatabaseSpec defines the desired state of BigLakeDatabase</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigLakeDatabaseSpec Spec { get; set; }

    /// <summary>BigLakeDatabaseStatus defines the config connector machine state of BigLakeDatabase</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigLakeDatabaseStatus? Status { get; set; }
}