using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.cnrm.cloud.google.com;
/// <summary>The Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLDatabaseSpecInstanceRef
{
    /// <summary>Allowed value: The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLDatabaseSpec
{
    /// <summary>The charset value. See MySQL's [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html) and Postgres' [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html) for more details and supported values. Postgres databases only support a value of 'UTF8' at creation time.</summary>
    [JsonPropertyName("charset")]
    public string? Charset { get; set; }

    /// <summary>The collation value. See MySQL's [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html) and Postgres' [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html) for more details and supported values. Postgres databases only support a value of 'en_US.UTF8' at creation time.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The deletion policy for the database. Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful for Postgres, where databases cannot be deleted from the API if there are users other than cloudsqlsuperuser with access. Possible values are: "ABANDON", "DELETE". Defaults to "DELETE".</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>The Cloud SQL instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1SQLDatabaseSpecInstanceRef InstanceRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLDatabaseStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLDatabaseStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLDatabaseSpec>, IStatus<V1beta1SQLDatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLDatabase";
    public const string KubeGroup = "sql.cnrm.cloud.google.com";
    public const string KubePluralName = "sqldatabases";
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
    public V1beta1SQLDatabaseSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1SQLDatabaseStatus? Status { get; set; }
}