using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.gcp.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProviderEntryGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProviderEntryGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EntrySpecForProviderEntryGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProviderEntryGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProviderEntryGroupSelector
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
    public V1beta1EntrySpecForProviderEntryGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProviderGcsFilesetSpec
{
    /// <summary>Patterns to identify a set of files in Google Cloud Storage. See Cloud Storage documentation for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecForProvider
{
    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupRef")]
    public V1beta1EntrySpecForProviderEntryGroupRef? EntryGroupRef { get; set; }

    /// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupSelector")]
    public V1beta1EntrySpecForProviderEntryGroupSelector? EntryGroupSelector { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta1EntrySpecForProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>The resource this metadata entry refers to. For Google Cloud Platform resources, linkedResource is the full name of the resource. For example, the linkedResource for a table resource from BigQuery is: //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType, this field is optional and defaults to an empty string.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema attached to it. See https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema for what fields this schema can contain.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The type of the entry. Only used for Entries with types in the EntryType enum. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values are: FILESET.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog does not integrate with. userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>Entry type if it does not fit any of the input-allowed values listed in EntryType enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". userSpecifiedType strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProviderEntryGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProviderEntryGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EntrySpecInitProviderEntryGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProviderEntryGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProviderEntryGroupSelector
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
    public V1beta1EntrySpecInitProviderEntryGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProviderGcsFilesetSpec
{
    /// <summary>Patterns to identify a set of files in Google Cloud Storage. See Cloud Storage documentation for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecInitProvider
{
    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupRef")]
    public V1beta1EntrySpecInitProviderEntryGroupRef? EntryGroupRef { get; set; }

    /// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupSelector")]
    public V1beta1EntrySpecInitProviderEntryGroupSelector? EntryGroupSelector { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta1EntrySpecInitProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>The resource this metadata entry refers to. For Google Cloud Platform resources, linkedResource is the full name of the resource. For example, the linkedResource for a table resource from BigQuery is: //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType, this field is optional and defaults to an empty string.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema attached to it. See https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema for what fields this schema can contain.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The type of the entry. Only used for Entries with types in the EntryType enum. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values are: FILESET.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog does not integrate with. userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>Entry type if it does not fit any of the input-allowed values listed in EntryType enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". userSpecifiedType strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpecProviderConfigRef
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
public partial class V1beta1EntrySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>EntrySpec defines the desired state of Entry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntrySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EntrySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EntrySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EntrySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EntrySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderBigqueryDateShardedSpec
{
    /// <summary>(Output) The Data Catalog resource name of the dataset entry the current table belongs to, for example, projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>(Output) Total number of shards.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>(Output) The table name prefix of the shards. The name of any given shard is [tablePrefix]YYYYMMDD, for example, for shard MyTable20180101, the tablePrefix is MyTable.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderBigqueryTableSpecTableSpec
{
    /// <summary>(Output) If the table is a dated shard, i.e., with name pattern [prefix]YYYYMMDD, groupedEntry is the Data Catalog resource name of the date sharded grouped entry, for example, projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}. Otherwise, groupedEntry is empty.</summary>
    [JsonPropertyName("groupedEntry")]
    public string? GroupedEntry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderBigqueryTableSpecViewSpec
{
    /// <summary>(Output) The query that defines the table view.</summary>
    [JsonPropertyName("viewQuery")]
    public string? ViewQuery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderBigqueryTableSpec
{
    /// <summary>(Output) The table source type.</summary>
    [JsonPropertyName("tableSourceType")]
    public string? TableSourceType { get; set; }

    /// <summary>(Output) Spec of a BigQuery table. This field should only be populated if tableSourceType is BIGQUERY_TABLE. Structure is documented below.</summary>
    [JsonPropertyName("tableSpec")]
    public IList<V1beta1EntryStatusAtProviderBigqueryTableSpecTableSpec>? TableSpec { get; set; }

    /// <summary>(Output) Table view specification. This field should only be populated if tableSourceType is BIGQUERY_VIEW. Structure is documented below.</summary>
    [JsonPropertyName("viewSpec")]
    public IList<V1beta1EntryStatusAtProviderBigqueryTableSpecViewSpec>? ViewSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderGcsFilesetSpecSampleGcsFileSpecs
{
    /// <summary>(Output) The full file path</summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    /// <summary>(Output) The size of the file, in bytes.</summary>
    [JsonPropertyName("sizeBytes")]
    public double? SizeBytes { get; set; }
}

/// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProviderGcsFilesetSpec
{
    /// <summary>Patterns to identify a set of files in Google Cloud Storage. See Cloud Storage documentation for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>(Output) Sample files contained in this fileset, not all files contained in this fileset are represented here. Structure is documented below.</summary>
    [JsonPropertyName("sampleGcsFileSpecs")]
    public IList<V1beta1EntryStatusAtProviderGcsFilesetSpecSampleGcsFileSpecs>? SampleGcsFileSpecs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusAtProvider
{
    /// <summary>Specification for a group of BigQuery tables with name pattern [prefix]YYYYMMDD. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryDateShardedSpec")]
    public IList<V1beta1EntryStatusAtProviderBigqueryDateShardedSpec>? BigqueryDateShardedSpec { get; set; }

    /// <summary>Specification that applies to a BigQuery table. This is only valid on entries of type TABLE. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryTableSpec")]
    public IList<V1beta1EntryStatusAtProviderBigqueryTableSpec>? BigqueryTableSpec { get; set; }

    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET. Structure is documented below.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta1EntryStatusAtProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.</summary>
    [JsonPropertyName("integratedSystem")]
    public string? IntegratedSystem { get; set; }

    /// <summary>The resource this metadata entry refers to. For Google Cloud Platform resources, linkedResource is the full name of the resource. For example, the linkedResource for a table resource from BigQuery is: //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType, this field is optional and defaults to an empty string.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>The Data Catalog resource name of the entry in URL format. Example: projects/{project_id}/locations/{location}/entryGroups/{entryGroupId}/entries/{entryId}. Note that this Entry and its child resources may not actually be stored in the location in this name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema attached to it. See https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema for what fields this schema can contain.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The type of the entry. Only used for Entries with types in the EntryType enum. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values are: FILESET.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>This field indicates the entry's source system that Data Catalog does not integrate with. userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>Entry type if it does not fit any of the input-allowed values listed in EntryType enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". userSpecifiedType strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatusConditions
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

/// <summary>EntryStatus defines the observed state of Entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EntryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EntryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EntryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Entry is the Schema for the Entrys API. Entry Metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Entry : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EntrySpec>, IStatus<V1beta1EntryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Entry";
    public const string KubeGroup = "datacatalog.gcp.m.upbound.io";
    public const string KubePluralName = "entries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EntrySpec defines the desired state of Entry</summary>
    [JsonPropertyName("spec")]
    public V1beta1EntrySpec Spec { get; set; }

    /// <summary>EntryStatus defines the observed state of Entry.</summary>
    [JsonPropertyName("status")]
    public V1beta1EntryStatus? Status { get; set; }
}

/// <summary>Entry is the Schema for the Entrys API. Entry Metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EntryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Entry>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EntryList";
    public const string KubeGroup = "datacatalog.gcp.m.upbound.io";
    public const string KubePluralName = "entries";
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
    public IList<V1beta1Entry> Items { get; set; }
}