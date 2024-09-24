using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
public partial class V1beta1DLPStoredInfoTypeSpecDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits. [required]</summary>
    [JsonPropertyName("words")]
    public IList<string> Words { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1DLPStoredInfoTypeSpecDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1DLPStoredInfoTypeSpecDictionaryWordList? WordList { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableDatasetRef
{
    /// <summary>Dataset ID of the table.  Allowed value: The Google Cloud resource name of a `BigQueryDataset` resource (format: `projects/{{project}}/datasets/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableProjectRef
{
    /// <summary>The Google Cloud Platform project ID of the project containing the table. If omitted, project ID is inferred from the API call.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableTableRef
{
    /// <summary>Name of the table.  Allowed value: The Google Cloud resource name of a `BigQueryTable` resource (format: `projects/{{project}}/datasets/{{dataset_id}}/tables/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary></summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableDatasetRef? DatasetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableProjectRef? ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableRef")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTableTableRef? TableRef { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryField
{
    /// <summary>Designated field in the BigQuery table.</summary>
    [JsonPropertyName("field")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>Source table of the field.</summary>
    [JsonPropertyName("table")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format `gs:///`. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecLargeCustomDictionary
{
    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase.</summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>Set of files containing newline-delimited lists of dictionary phrases.</summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.</summary>
    [JsonPropertyName("outputPath")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecOrganizationRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a Google Cloud Organization (format: `organizations/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] Organization not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecProjectRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpecRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string Pattern { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeSpec
{
    /// <summary>Description of the StoredInfoType (max 256 characters).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Store dictionary-based CustomInfoType.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1DLPStoredInfoTypeSpecDictionary? Dictionary { get; set; }

    /// <summary>Display name of the StoredInfoType (max 256 characters).</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>StoredInfoType where findings are defined by a dictionary of phrases.</summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta1DLPStoredInfoTypeSpecLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>Immutable. The location of the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1DLPStoredInfoTypeSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPStoredInfoTypeSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Store regular expression-based StoredInfoType.</summary>
    [JsonPropertyName("regex")]
    public V1beta1DLPStoredInfoTypeSpecRegex? Regex { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1beta1DLPStoredInfoTypeStatusConditions
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

public partial class V1beta1DLPStoredInfoTypeStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPStoredInfoTypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DLPStoredInfoType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DLPStoredInfoTypeSpec>, IStatus<V1beta1DLPStoredInfoTypeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DLPStoredInfoType";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpstoredinfotypes";
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
    public V1beta1DLPStoredInfoTypeSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DLPStoredInfoTypeStatus? Status { get; set; }
}