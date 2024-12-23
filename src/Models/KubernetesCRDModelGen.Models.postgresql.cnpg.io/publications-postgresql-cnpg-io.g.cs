using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>The name of the PostgreSQL cluster that identifies the "publisher"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationSpecCluster
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specifies a list of tables to add to the publication. Corresponding to `FOR TABLE` in PostgreSQL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationSpecTargetObjectsTable
{
    /// <summary>The columns to publish</summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }

    /// <summary>The table name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Whether to limit to the table only or include all its descendants</summary>
    [JsonPropertyName("only")]
    public bool? Only { get; set; }

    /// <summary>The schema name</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>PublicationTargetObject is an object to publish</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationSpecTargetObjects
{
    /// <summary>Specifies a list of tables to add to the publication. Corresponding to `FOR TABLE` in PostgreSQL.</summary>
    [JsonPropertyName("table")]
    public V1PublicationSpecTargetObjectsTable? Table { get; set; }

    /// <summary>Marks the publication as one that replicates changes for all tables in the specified list of schemas, including tables created in the future. Corresponding to `FOR TABLES IN SCHEMA` in PostgreSQL.</summary>
    [JsonPropertyName("tablesInSchema")]
    public string? TablesInSchema { get; set; }
}

/// <summary>Target of the publication as expected by PostgreSQL `CREATE PUBLICATION` command</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationSpecTarget
{
    /// <summary>Marks the publication as one that replicates changes for all tables in the database, including tables created in the future. Corresponding to `FOR ALL TABLES` in PostgreSQL.</summary>
    [JsonPropertyName("allTables")]
    public bool? AllTables { get; set; }

    /// <summary>Just the following schema objects</summary>
    [JsonPropertyName("objects")]
    public IList<V1PublicationSpecTargetObjects>? Objects { get; set; }
}

/// <summary>PublicationSpec defines the desired state of Publication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationSpec
{
    /// <summary>The name of the PostgreSQL cluster that identifies the "publisher"</summary>
    [JsonPropertyName("cluster")]
    public V1PublicationSpecCluster Cluster { get; set; }

    /// <summary>The name of the database where the publication will be installed in the "publisher" cluster</summary>
    [JsonPropertyName("dbname")]
    public string Dbname { get; set; }

    /// <summary>The name of the publication inside PostgreSQL</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Publication parameters part of the `WITH` clause as expected by PostgreSQL `CREATE PUBLICATION` command</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The policy for end-of-life maintenance of this publication</summary>
    [JsonPropertyName("publicationReclaimPolicy")]
    public string? PublicationReclaimPolicy { get; set; }

    /// <summary>Target of the publication as expected by PostgreSQL `CREATE PUBLICATION` command</summary>
    [JsonPropertyName("target")]
    public V1PublicationSpecTarget Target { get; set; }
}

/// <summary>PublicationStatus defines the observed state of Publication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PublicationStatus
{
    /// <summary>Applied is true if the publication was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>Message is the reconciliation output message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A sequence number representing the latest desired state that was synchronized</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Publication is the Schema for the publications API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Publication : IKubernetesObject<V1ObjectMeta>, ISpec<V1PublicationSpec>, IStatus<V1PublicationStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Publication";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "publications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PublicationSpec defines the desired state of Publication</summary>
    [JsonPropertyName("spec")]
    public V1PublicationSpec Spec { get; set; }

    /// <summary>PublicationStatus defines the observed state of Publication</summary>
    [JsonPropertyName("status")]
    public V1PublicationStatus? Status { get; set; }
}