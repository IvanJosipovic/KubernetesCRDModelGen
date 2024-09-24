using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.upbound.io;
public enum V1beta1JobTriggerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentify
{
    /// <summary>User settable Cloud Storage bucket and folders to store de-identified files. This field must be set for cloud storage deidentification. The output Cloud Storage bucket must be different from the input bucket. De-identified files will overwrite files in the output path. Form of: gs://bucket/folder/ or gs://bucket</summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed. If empty, all supported files will be transformed. Supported types may be automatically added over time. If a file type is set in this field that isn't supported by the Deidentify action then the job will fail and will not be successfully created/started. Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.</summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>User specified deidentify templates and configs for structured, unstructured, and image files. Structure is documented below.</summary>
    [JsonPropertyName("transformationConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationConfig>? TransformationConfig { get; set; }

    /// <summary>Config for storing transformation details. Structure is documented below.</summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig>? TransformationDetailsStorageConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsJobNotificationEmails
{
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsPublishSummaryToCscc
{
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsPublishToStackdriver
{
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>Schema used for writing the findings for Inspect jobs. This field is only used for Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding object. If appending to an existing table, any columns from the predefined schema that are missing will be added. No columns in the existing table will be deleted. If unspecified, then all available columns will be used for a new table or an (existing) table with no schema, and no changes will be made to an existing table that has a schema. Only for use with external storage. Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.</summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindings
{
    /// <summary>Information on where to store output Structure is documented below.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfig>? OutputConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobActions
{
    /// <summary>Create a de-identified copy of the requested table or files. Structure is documented below.</summary>
    [JsonPropertyName("deidentify")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsDeidentify>? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsJobNotificationEmails>? JobNotificationEmails { get; set; }

    /// <summary>Publish a message into a given Pub/Sub topic when the job completes. Structure is documented below.</summary>
    [JsonPropertyName("pubSub")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsPubSub>? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsPublishFindingsToCloudDataCatalog>? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsPublishSummaryToCscc>? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsPublishToStackdriver>? PublishToStackdriver { get; set; }

    /// <summary>If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk Structure is documented below.</summary>
    [JsonPropertyName("saveFindings")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActionsSaveFindings>? SaveFindings { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobInspectConfig
{
    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>References to fields excluded from scanning. This allows you to skip inspection of entire columns which you know have no findings. Structure is documented below.</summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>Limit scanning only to these fields. Structure is documented below.</summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("tableReference")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsTableReference>? TableReference { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>A list of regular expressions matching file paths to exclude. All files in the bucket that match at least one of these regular expressions will be excluded from the scan.</summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>A list of regular expressions matching file paths to include. All files in the bucket that match at least one of these regular expressions will be included in the set of files, except for those that also match an item in excludeRegex. Leaving this field empty will match all files by default (this is equivalent to including .* in the list)</summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>The regex-filtered set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("regexFileSet")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet>? RegexFileSet { get; set; }

    /// <summary>The Cloud Storage url of the file(s) to scan, in the format gs://<bucket>/<path>. Trailing wildcard in the path is allowed. If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>Max number of bytes to scan from a file. If a scanned file's size is bigger than this value then the rest of the bytes are omitted.</summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("fileSet")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSet>? FileSet { get; set; }

    /// <summary>List of file type groups to include in the scan. If empty, all files are scanned and available data format processors are applied. In addition, the binary content of the selected files is always scanned as well. Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified. Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.</summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>A representation of a Datastore kind. Structure is documented below.</summary>
    [JsonPropertyName("kind")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsKind>? Kind { get; set; }

    /// <summary>Datastore partition ID. A partition ID identifies a grouping of entities. The grouping is always by project and namespace, however the namespace ID may be empty. Structure is documented below.</summary>
    [JsonPropertyName("partitionId")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsPartitionId>? PartitionId { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>To organize findings, these labels will be added to each finding. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 10 labels can be associated with a given finding. Examples:</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>These are labels that each inspection request must include within their 'finding_labels' map. Request may contain others, but any missing one of these will be rejected. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. No more than 10 keys can be required.</summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>If the container is a table, additional information to make findings meaningful such as the columns that are primary keys. Structure is documented below.</summary>
    [JsonPropertyName("tableOptions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptions>? TableOptions { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid scanning files that have not been modified since the last time the JobTrigger executed. This will be based on the time of the execution of the last run of the JobTrigger or the timespan endTime used in the last run of the JobTrigger.</summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specification of the field containing the timestamp of scanned items. Structure is documented below.</summary>
    [JsonPropertyName("timestampField")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfigTimestampField>? TimestampField { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJobStorageConfig
{
    /// <summary>Options defining BigQuery table and row identifiers. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryOptions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptions>? BigQueryOptions { get; set; }

    /// <summary>Options defining a file or a set of files within a Google Cloud Storage bucket. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageOptions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptions>? CloudStorageOptions { get; set; }

    /// <summary>Options defining a data set within Google Cloud Datastore. Structure is documented below.</summary>
    [JsonPropertyName("datastoreOptions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptions>? DatastoreOptions { get; set; }

    /// <summary>Configuration to control jobs where the content being inspected is outside of Google Cloud Platform. Structure is documented below.</summary>
    [JsonPropertyName("hybridOptions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigHybridOptions>? HybridOptions { get; set; }

    /// <summary>Configuration of the timespan of the items to include in scanning Structure is documented below.</summary>
    [JsonPropertyName("timespanConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfig>? TimespanConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderInspectJob
{
    /// <summary>Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode. Structure is documented below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobActions>? Actions { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobInspectConfig>? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>Information on where to inspect Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJobStorageConfig>? StorageConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderTriggersManual
{
}

public partial class V1beta1JobTriggerSpecForProviderTriggersSchedule
{
    /// <summary>With this option a job is started a regular periodic basis. For example: every day (86400 seconds). A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs. This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

public partial class V1beta1JobTriggerSpecForProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public IList<V1beta1JobTriggerSpecForProviderTriggersManual>? Manual { get; set; }

    /// <summary>Schedule for triggered jobs Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1JobTriggerSpecForProviderTriggersSchedule>? Schedule { get; set; }
}

public partial class V1beta1JobTriggerSpecForProvider
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Controls what and how to inspect for findings. Structure is documented below.</summary>
    [JsonPropertyName("inspectJob")]
    public IList<V1beta1JobTriggerSpecForProviderInspectJob>? InspectJob { get; set; }

    /// <summary>The parent of the trigger, either in the format projects/{{project}} or projects/{{project}}/locations/{{location}}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Whether the trigger is currently active. Default value is HEALTHY. Possible values are: PAUSED, HEALTHY, CANCELLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The trigger id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>What event needs to occur for a new job to be started. Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1JobTriggerSpecForProviderTriggers>? Triggers { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentify
{
    /// <summary>User settable Cloud Storage bucket and folders to store de-identified files. This field must be set for cloud storage deidentification. The output Cloud Storage bucket must be different from the input bucket. De-identified files will overwrite files in the output path. Form of: gs://bucket/folder/ or gs://bucket</summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed. If empty, all supported files will be transformed. Supported types may be automatically added over time. If a file type is set in this field that isn't supported by the Deidentify action then the job will fail and will not be successfully created/started. Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.</summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>User specified deidentify templates and configs for structured, unstructured, and image files. Structure is documented below.</summary>
    [JsonPropertyName("transformationConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationConfig>? TransformationConfig { get; set; }

    /// <summary>Config for storing transformation details. Structure is documented below.</summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig>? TransformationDetailsStorageConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsJobNotificationEmails
{
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishSummaryToCscc
{
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishToStackdriver
{
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>Schema used for writing the findings for Inspect jobs. This field is only used for Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding object. If appending to an existing table, any columns from the predefined schema that are missing will be added. No columns in the existing table will be deleted. If unspecified, then all available columns will be used for a new table or an (existing) table with no schema, and no changes will be made to an existing table that has a schema. Only for use with external storage. Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.</summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindings
{
    /// <summary>Information on where to store output Structure is documented below.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfig>? OutputConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobActions
{
    /// <summary>Create a de-identified copy of the requested table or files. Structure is documented below.</summary>
    [JsonPropertyName("deidentify")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsDeidentify>? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsJobNotificationEmails>? JobNotificationEmails { get; set; }

    /// <summary>Publish a message into a given Pub/Sub topic when the job completes. Structure is documented below.</summary>
    [JsonPropertyName("pubSub")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsPubSub>? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishFindingsToCloudDataCatalog>? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishSummaryToCscc>? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsPublishToStackdriver>? PublishToStackdriver { get; set; }

    /// <summary>If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk Structure is documented below.</summary>
    [JsonPropertyName("saveFindings")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActionsSaveFindings>? SaveFindings { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobInspectConfig
{
    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>References to fields excluded from scanning. This allows you to skip inspection of entire columns which you know have no findings. Structure is documented below.</summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>Limit scanning only to these fields. Structure is documented below.</summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("tableReference")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsTableReference>? TableReference { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>A list of regular expressions matching file paths to exclude. All files in the bucket that match at least one of these regular expressions will be excluded from the scan.</summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>A list of regular expressions matching file paths to include. All files in the bucket that match at least one of these regular expressions will be included in the set of files, except for those that also match an item in excludeRegex. Leaving this field empty will match all files by default (this is equivalent to including .* in the list)</summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>The regex-filtered set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("regexFileSet")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet>? RegexFileSet { get; set; }

    /// <summary>The Cloud Storage url of the file(s) to scan, in the format gs://<bucket>/<path>. Trailing wildcard in the path is allowed. If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>Max number of bytes to scan from a file. If a scanned file's size is bigger than this value then the rest of the bytes are omitted.</summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("fileSet")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSet>? FileSet { get; set; }

    /// <summary>List of file type groups to include in the scan. If empty, all files are scanned and available data format processors are applied. In addition, the binary content of the selected files is always scanned as well. Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified. Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.</summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>A representation of a Datastore kind. Structure is documented below.</summary>
    [JsonPropertyName("kind")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsKind>? Kind { get; set; }

    /// <summary>Datastore partition ID. A partition ID identifies a grouping of entities. The grouping is always by project and namespace, however the namespace ID may be empty. Structure is documented below.</summary>
    [JsonPropertyName("partitionId")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsPartitionId>? PartitionId { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>To organize findings, these labels will be added to each finding. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 10 labels can be associated with a given finding. Examples:</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>These are labels that each inspection request must include within their 'finding_labels' map. Request may contain others, but any missing one of these will be rejected. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. No more than 10 keys can be required.</summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>If the container is a table, additional information to make findings meaningful such as the columns that are primary keys. Structure is documented below.</summary>
    [JsonPropertyName("tableOptions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptions>? TableOptions { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid scanning files that have not been modified since the last time the JobTrigger executed. This will be based on the time of the execution of the last run of the JobTrigger or the timespan endTime used in the last run of the JobTrigger.</summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specification of the field containing the timestamp of scanned items. Structure is documented below.</summary>
    [JsonPropertyName("timestampField")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfigTimestampField>? TimestampField { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJobStorageConfig
{
    /// <summary>Options defining BigQuery table and row identifiers. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryOptions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptions>? BigQueryOptions { get; set; }

    /// <summary>Options defining a file or a set of files within a Google Cloud Storage bucket. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageOptions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptions>? CloudStorageOptions { get; set; }

    /// <summary>Options defining a data set within Google Cloud Datastore. Structure is documented below.</summary>
    [JsonPropertyName("datastoreOptions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptions>? DatastoreOptions { get; set; }

    /// <summary>Configuration to control jobs where the content being inspected is outside of Google Cloud Platform. Structure is documented below.</summary>
    [JsonPropertyName("hybridOptions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptions>? HybridOptions { get; set; }

    /// <summary>Configuration of the timespan of the items to include in scanning Structure is documented below.</summary>
    [JsonPropertyName("timespanConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfig>? TimespanConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderInspectJob
{
    /// <summary>Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode. Structure is documented below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobActions>? Actions { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobInspectConfig>? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>Information on where to inspect Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJobStorageConfig>? StorageConfig { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderTriggersManual
{
}

public partial class V1beta1JobTriggerSpecInitProviderTriggersSchedule
{
    /// <summary>With this option a job is started a regular periodic basis. For example: every day (86400 seconds). A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs. This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public IList<V1beta1JobTriggerSpecInitProviderTriggersManual>? Manual { get; set; }

    /// <summary>Schedule for triggered jobs Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1JobTriggerSpecInitProviderTriggersSchedule>? Schedule { get; set; }
}

public partial class V1beta1JobTriggerSpecInitProvider
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Controls what and how to inspect for findings. Structure is documented below.</summary>
    [JsonPropertyName("inspectJob")]
    public IList<V1beta1JobTriggerSpecInitProviderInspectJob>? InspectJob { get; set; }

    /// <summary>The parent of the trigger, either in the format projects/{{project}} or projects/{{project}}/locations/{{location}}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Whether the trigger is currently active. Default value is HEALTHY. Possible values are: PAUSED, HEALTHY, CANCELLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The trigger id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>What event needs to occur for a new job to be started. Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1JobTriggerSpecInitProviderTriggers>? Triggers { get; set; }
}

public enum V1beta1JobTriggerSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1JobTriggerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1JobTriggerSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1JobTriggerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1JobTriggerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1JobTriggerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1JobTriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1JobTriggerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobTriggerSpecDeletionPolicyEnum>))]
    public V1beta1JobTriggerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1JobTriggerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1JobTriggerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1JobTriggerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobTriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1JobTriggerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobTriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentify
{
    /// <summary>User settable Cloud Storage bucket and folders to store de-identified files. This field must be set for cloud storage deidentification. The output Cloud Storage bucket must be different from the input bucket. De-identified files will overwrite files in the output path. Form of: gs://bucket/folder/ or gs://bucket</summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed. If empty, all supported files will be transformed. Supported types may be automatically added over time. If a file type is set in this field that isn't supported by the Deidentify action then the job will fail and will not be successfully created/started. Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.</summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>User specified deidentify templates and configs for structured, unstructured, and image files. Structure is documented below.</summary>
    [JsonPropertyName("transformationConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationConfig>? TransformationConfig { get; set; }

    /// <summary>Config for storing transformation details. Structure is documented below.</summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig>? TransformationDetailsStorageConfig { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsJobNotificationEmails
{
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishSummaryToCscc
{
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishToStackdriver
{
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>Schema used for writing the findings for Inspect jobs. This field is only used for Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding object. If appending to an existing table, any columns from the predefined schema that are missing will be added. No columns in the existing table will be deleted. If unspecified, then all available columns will be used for a new table or an (existing) table with no schema, and no changes will be made to an existing table that has a schema. Only for use with external storage. Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.</summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>The BigQuery table in which to store the output. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfigTable>? Table { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindings
{
    /// <summary>Information on where to store output Structure is documented below.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfig>? OutputConfig { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobActions
{
    /// <summary>Create a de-identified copy of the requested table or files. Structure is documented below.</summary>
    [JsonPropertyName("deidentify")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsDeidentify>? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsJobNotificationEmails>? JobNotificationEmails { get; set; }

    /// <summary>Publish a message into a given Pub/Sub topic when the job completes. Structure is documented below.</summary>
    [JsonPropertyName("pubSub")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsPubSub>? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishFindingsToCloudDataCatalog>? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishSummaryToCscc>? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsPublishToStackdriver>? PublishToStackdriver { get; set; }

    /// <summary>If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk Structure is documented below.</summary>
    [JsonPropertyName("saveFindings")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActionsSaveFindings>? SaveFindings { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>(Output) The creation timestamp of an inspectTemplate. Set by the server.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobInspectConfig
{
    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>References to fields excluded from scanning. This allows you to skip inspection of entire columns which you know have no findings. Structure is documented below.</summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>Limit scanning only to these fields. Structure is documented below.</summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("tableReference")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsTableReference>? TableReference { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>A list of regular expressions matching file paths to exclude. All files in the bucket that match at least one of these regular expressions will be excluded from the scan.</summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>A list of regular expressions matching file paths to include. All files in the bucket that match at least one of these regular expressions will be included in the set of files, except for those that also match an item in excludeRegex. Leaving this field empty will match all files by default (this is equivalent to including .* in the list)</summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>The regex-filtered set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("regexFileSet")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet>? RegexFileSet { get; set; }

    /// <summary>The Cloud Storage url of the file(s) to scan, in the format gs://<bucket>/<path>. Trailing wildcard in the path is allowed. If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>Max number of bytes to scan from a file. If a scanned file's size is bigger than this value then the rest of the bytes are omitted.</summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>Set of files to scan. Structure is documented below.</summary>
    [JsonPropertyName("fileSet")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSet>? FileSet { get; set; }

    /// <summary>List of file type groups to include in the scan. If empty, all files are scanned and available data format processors are applied. In addition, the binary content of the selected files is always scanned as well. Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified. Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.</summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.</summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile. If not specified, scanning would start from the top. Possible values are: TOP, RANDOM_START.</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>A representation of a Datastore kind. Structure is documented below.</summary>
    [JsonPropertyName("kind")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsKind>? Kind { get; set; }

    /// <summary>Datastore partition ID. A partition ID identifies a grouping of entities. The grouping is always by project and namespace, however the namespace ID may be empty. Structure is documented below.</summary>
    [JsonPropertyName("partitionId")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsPartitionId>? PartitionId { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided. Structure is documented below.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>To organize findings, these labels will be added to each finding. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 10 labels can be associated with a given finding. Examples:</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>These are labels that each inspection request must include within their 'finding_labels' map. Request may contain others, but any missing one of these will be rejected. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. No more than 10 keys can be required.</summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>If the container is a table, additional information to make findings meaningful such as the columns that are primary keys. Structure is documented below.</summary>
    [JsonPropertyName("tableOptions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptions>? TableOptions { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column. For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the timestamp property does not exist or its value is empty or invalid.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid scanning files that have not been modified since the last time the JobTrigger executed. This will be based on the time of the execution of the last run of the JobTrigger or the timespan endTime used in the last run of the JobTrigger.</summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specification of the field containing the timestamp of scanned items. Structure is documented below.</summary>
    [JsonPropertyName("timestampField")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfigTimestampField>? TimestampField { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJobStorageConfig
{
    /// <summary>Options defining BigQuery table and row identifiers. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryOptions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptions>? BigQueryOptions { get; set; }

    /// <summary>Options defining a file or a set of files within a Google Cloud Storage bucket. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageOptions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptions>? CloudStorageOptions { get; set; }

    /// <summary>Options defining a data set within Google Cloud Datastore. Structure is documented below.</summary>
    [JsonPropertyName("datastoreOptions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptions>? DatastoreOptions { get; set; }

    /// <summary>Configuration to control jobs where the content being inspected is outside of Google Cloud Platform. Structure is documented below.</summary>
    [JsonPropertyName("hybridOptions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptions>? HybridOptions { get; set; }

    /// <summary>Configuration of the timespan of the items to include in scanning Structure is documented below.</summary>
    [JsonPropertyName("timespanConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfig>? TimespanConfig { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderInspectJob
{
    /// <summary>Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode. Structure is documented below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobActions>? Actions { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobInspectConfig>? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>Information on where to inspect Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJobStorageConfig>? StorageConfig { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderTriggersManual
{
}

public partial class V1beta1JobTriggerStatusAtProviderTriggersSchedule
{
    /// <summary>With this option a job is started a regular periodic basis. For example: every day (86400 seconds). A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs. This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public IList<V1beta1JobTriggerStatusAtProviderTriggersManual>? Manual { get; set; }

    /// <summary>Schedule for triggered jobs Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1JobTriggerStatusAtProviderTriggersSchedule>? Schedule { get; set; }
}

public partial class V1beta1JobTriggerStatusAtProvider
{
    /// <summary>The creation timestamp of an inspectTemplate. Set by the server.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/jobTriggers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Controls what and how to inspect for findings. Structure is documented below.</summary>
    [JsonPropertyName("inspectJob")]
    public IList<V1beta1JobTriggerStatusAtProviderInspectJob>? InspectJob { get; set; }

    /// <summary>The timestamp of the last time this trigger executed.</summary>
    [JsonPropertyName("lastRunTime")]
    public string? LastRunTime { get; set; }

    /// <summary>The resource name of the job trigger. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the trigger, either in the format projects/{{project}} or projects/{{project}}/locations/{{location}}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Whether the trigger is currently active. Default value is HEALTHY. Possible values are: PAUSED, HEALTHY, CANCELLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The trigger id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>What event needs to occur for a new job to be started. Structure is documented below.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1JobTriggerStatusAtProviderTriggers>? Triggers { get; set; }

    /// <summary>The last update timestamp of an inspectTemplate. Set by the server.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

public partial class V1beta1JobTriggerStatusConditions
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

public partial class V1beta1JobTriggerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1JobTriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobTriggerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobTrigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobTriggerSpec>, IStatus<V1beta1JobTriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobTrigger";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "jobtriggers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobTriggerSpec defines the desired state of JobTrigger</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobTriggerSpec Spec { get; set; }

    /// <summary>JobTriggerStatus defines the observed state of JobTrigger.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobTriggerStatus? Status { get; set; }
}