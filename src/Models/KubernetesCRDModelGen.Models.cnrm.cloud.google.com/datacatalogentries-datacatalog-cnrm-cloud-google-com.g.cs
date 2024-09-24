using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecGcsFilesetSpecSampleGcsFileSpecs
{
    /// <summary>The full file path.</summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    /// <summary>The size of the file, in bytes.</summary>
    [JsonPropertyName("sizeBytes")]
    public int? SizeBytes { get; set; }
}

/// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecGcsFilesetSpec
{
    /// <summary>Patterns to identify a set of files in Google Cloud Storage. See [Cloud Storage documentation](https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames) for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:  * gs://bucket_name/dir/*: matches all files within bucket_name/dir directory. * gs://bucket_name/dir/**: matches all files in bucket_name/dir spanning all subdirectories. * gs://bucket_name/file*: matches files prefixed by file in bucket_name * gs://bucket_name/??.txt: matches files with two characters followed by .txt in bucket_name * gs://bucket_name/[aeiou].txt: matches files that contain a single vowel character followed by .txt in bucket_name * gs://bucket_name/[a-m].txt: matches files that contain a, b, ... or m followed by .txt in bucket_name * gs://bucket_name/a/*/b: matches all files in bucket_name that match a/*/b pattern, such as a/c/b, a/d/b * gs://another_bucket/a.txt: matches gs://another_bucket/a.txt.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string> FilePatterns { get; set; }

    /// <summary>Sample files contained in this fileset, not all files contained in this fileset are represented here.</summary>
    [JsonPropertyName("sampleGcsFileSpecs")]
    public IList<V1alpha1DataCatalogEntrySpecGcsFilesetSpecSampleGcsFileSpecs>? SampleGcsFileSpecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpec
{
    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string EntryGroup { get; set; }

    /// <summary>Immutable. The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string EntryId { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1alpha1DataCatalogEntrySpecGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>The resource this metadata entry refers to. For Google Cloud Platform resources, linkedResource is the full name of the resource. For example, the linkedResource for a table resource from BigQuery is: //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType, this field is optional and defaults to an empty string.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema attached to it. See https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema for what fields this schema can contain.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Immutable. The type of the entry. Only used for Entries with types in the EntryType enum. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values: ["FILESET"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog does not integrate with. userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>Entry type if it does not fit any of the input-allowed values listed in EntryType enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". userSpecifiedType strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusBigqueryDateShardedSpec
{
    /// <summary>The Data Catalog resource name of the dataset entry the current table belongs to, for example, projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}.</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Total number of shards.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>The table name prefix of the shards. The name of any given shard is [tablePrefix]YYYYMMDD, for example, for shard MyTable20180101, the tablePrefix is MyTable.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusBigqueryTableSpecTableSpec
{
    /// <summary>If the table is a dated shard, i.e., with name pattern [prefix]YYYYMMDD, groupedEntry is the Data Catalog resource name of the date sharded grouped entry, for example, projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}. Otherwise, groupedEntry is empty.</summary>
    [JsonPropertyName("groupedEntry")]
    public string? GroupedEntry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusBigqueryTableSpecViewSpec
{
    /// <summary>The query that defines the table view.</summary>
    [JsonPropertyName("viewQuery")]
    public string? ViewQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusBigqueryTableSpec
{
    /// <summary>The table source type.</summary>
    [JsonPropertyName("tableSourceType")]
    public string? TableSourceType { get; set; }

    /// <summary>Spec of a BigQuery table. This field should only be populated if tableSourceType is BIGQUERY_TABLE.</summary>
    [JsonPropertyName("tableSpec")]
    public IList<V1alpha1DataCatalogEntryStatusBigqueryTableSpecTableSpec>? TableSpec { get; set; }

    /// <summary>Table view specification. This field should only be populated if tableSourceType is BIGQUERY_VIEW.</summary>
    [JsonPropertyName("viewSpec")]
    public IList<V1alpha1DataCatalogEntryStatusBigqueryTableSpecViewSpec>? ViewSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusConditions
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
public partial class V1alpha1DataCatalogEntryStatus
{
    /// <summary>Specification for a group of BigQuery tables with name pattern [prefix]YYYYMMDD. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.</summary>
    [JsonPropertyName("bigqueryDateShardedSpec")]
    public IList<V1alpha1DataCatalogEntryStatusBigqueryDateShardedSpec>? BigqueryDateShardedSpec { get; set; }

    /// <summary>Specification that applies to a BigQuery table. This is only valid on entries of type TABLE.</summary>
    [JsonPropertyName("bigqueryTableSpec")]
    public IList<V1alpha1DataCatalogEntryStatusBigqueryTableSpec>? BigqueryTableSpec { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogEntryStatusConditions>? Conditions { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.</summary>
    [JsonPropertyName("integratedSystem")]
    public string? IntegratedSystem { get; set; }

    /// <summary>The Data Catalog resource name of the entry in URL format. Example: projects/{project_id}/locations/{location}/entryGroups/{entryGroupId}/entries/{entryId}. Note that this Entry and its child resources may not actually be stored in the location in this name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataCatalogEntrySpec>, IStatus<V1alpha1DataCatalogEntryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogEntry";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogentries";
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
    public V1alpha1DataCatalogEntrySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogEntryStatus? Status { get; set; }
}