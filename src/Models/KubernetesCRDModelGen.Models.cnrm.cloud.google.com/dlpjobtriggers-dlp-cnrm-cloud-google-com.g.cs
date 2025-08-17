using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DLPJobTriggerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DLPJobTrigger>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DLPJobTriggerList";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpjobtriggers";
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
    public IList<V1beta1DLPJobTrigger> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsPubSubTopicRef
{
    /// <summary>Cloud Pub/Sub topic to send notifications to. The topic must have given publishing access rights to the DLP API service account executing the long running DlpJob sending the notifications. Format is projects/{project}/topics/{topic}.  Allowed value: The Google Cloud resource name of a `PubSubTopic` resource (format: `projects/{{project}}/topics/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Publish a notification to a pubsub topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsPubSub
{
    /// <summary></summary>
    [JsonPropertyName("topicRef")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsPubSubTopicRef? TopicRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableDatasetRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableProjectRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableTableRef
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
#nullable disable

#nullable enable
/// <summary>Store findings in an existing table or a new table in an existing dataset. If table_id is not set a new one will be generated for you with the following format: dlp_googleapis_yyyy_mm_dd_[dlp_job_id]. Pacific timezone will be used for generating the date details. For Inspect, each column in an existing output table must have the same name, type, and mode of a field in the `Finding` object. For Risk, an existing output table should be the output of a previous Risk analysis job run on the same source table, with the same privacy metric and quasi-identifiers. Risk jobs that analyze the same table but compute a different privacy metric, or use different sets of quasi-identifiers, cannot store their results in the same table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary></summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableDatasetRef? DatasetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableProjectRef? ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableRef")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTableTableRef? TableRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Location to store findings outside of DLP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>Store findings directly to DLP. If neither this or bigquery is chosen only summary stats of total infotype count will be stored. Quotes will not be stored to dlp findings. If quotes are needed, store to BigQuery. Currently only for inspect jobs.</summary>
    [JsonPropertyName("dlpStorage")]
    public JsonNode? DlpStorage { get; set; }

    /// <summary>Schema used for writing the findings for Inspect jobs. This field is only used for Inspect and must be unspecified for Risk jobs. Columns are derived from the `Finding` object. If appending to an existing table, any columns from the predefined schema that are missing will be added. No columns in the existing table will be deleted. If unspecified, then all available columns will be used for a new table or an (existing) table with no schema, and no changes will be made to an existing table that has a schema. Only for use with external storage. Possible values: OUTPUT_SCHEMA_UNSPECIFIED, BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS</summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>Store findings in an existing table or a new table in an existing dataset. If table_id is not set a new one will be generated for you with the following format: dlp_googleapis_yyyy_mm_dd_[dlp_job_id]. Pacific timezone will be used for generating the date details. For Inspect, each column in an existing output table must have the same name, type, and mode of a field in the `Finding` object. For Risk, an existing output table should be the output of a previous Risk analysis job run on the same source table, with the same privacy metric and quasi-identifiers. Risk jobs that analyze the same table but compute a different privacy metric, or use different sets of quasi-identifiers, cannot store their results in the same table.</summary>
    [JsonPropertyName("table")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfigTable? Table { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Save resulting findings in a provided location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindings
{
    /// <summary>Location to store findings outside of DLP.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindingsOutputConfig? OutputConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobActions
{
    /// <summary>Enable email notification for project owners and editors on job's completion/failure.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public JsonNode? JobNotificationEmails { get; set; }

    /// <summary>Publish a notification to a pubsub topic.</summary>
    [JsonPropertyName("pubSub")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsPubSub? PubSub { get; set; }

    /// <summary>Publish findings to Cloud Datahub.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public JsonNode? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish summary to Cloud Security Command Center (Alpha).</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public JsonNode? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/finding_count.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public JsonNode? PublishToStackdriver { get; set; }

    /// <summary>Save resulting findings in a provided location.</summary>
    [JsonPropertyName("saveFindings")]
    public V1beta1DLPJobTriggerSpecInspectJobActionsSaveFindings? SaveFindings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Likelihood adjustment to apply to all matching findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be `POSSIBLE` without the detection rule and `relative_likelihood` is 1, then it is upgraded to `LIKELY`, while a value of -1 would downgrade it to `UNLIKELY`. Likelihood may never drop below `VERY_UNLIKELY` or exceed `VERY_LIKELY`, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is `VERY_LIKELY` will result in a final likelihood of `LIKELY`.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public long? RelativeLikelihood { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex "(d{3}) d{3}-d{4}" could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex "(xxx)", where "xxx" is the area code in question.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider.</summary>
    [JsonPropertyName("windowAfter")]
    public long? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider.</summary>
    [JsonPropertyName("windowBefore")]
    public long? WindowBefore { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Hotword-based detection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex "(d{3}) d{3}-d{4}" could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex "(xxx)", where "xxx" is the area code in question.</summary>
    [JsonPropertyName("proximity")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRuleProximity? Proximity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRules
{
    /// <summary>Hotword-based detection rule.</summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRulesHotwordRule? HotwordRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>List of words or phrases to search for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits. [required]</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A list of phrases to detect as a CustomInfoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CustomInfoType can either be a new infoType, or an extension of built-in infoType, when the name matches one of existing infoTypes and that infoType is specified in `InspectContent.info_types` field. Specifying the latter adds findings to the one detected by the system. If built-in info type is not specified in `InspectContent.info_types` list then the name is treated as a custom info type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression based CustomInfoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesStoredTypeNameRef
{
    /// <summary>Resource name of the requested `StoredInfoType`, for example `organizations/433245324/storedInfoTypes/432452342` or `projects/project-id/storedInfoTypes/432452342`.  Allowed value: The Google Cloud resource name of a `DLPStoredInfoType` resource (format: `{{parent}}/storedInfoTypes/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Load an existing `StoredInfoType` resource for use in `InspectDataSource`. Not currently supported in `InspectContent`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Timestamp indicating when the version of the `StoredInfoType` used for inspection was created. Output-only field, populated by the system.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesStoredTypeNameRef? NameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>Set of detection rules to apply to all findings of this CustomInfoType. Rules are applied in order that they are specified. Not supported for the `surrogate_type` CustomInfoType.</summary>
    [JsonPropertyName("detectionRules")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDetectionRules>? DetectionRules { get; set; }

    /// <summary>A list of phrases to detect as a CustomInfoType.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values: EXCLUSION_TYPE_UNSPECIFIED, EXCLUSION_TYPE_EXCLUDE</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>CustomInfoType can either be a new infoType, or an extension of built-in infoType, when the name matches one of existing infoTypes and that infoType is specified in `InspectContent.info_types` field. Specifying the latter adds findings to the one detected by the system. If built-in info type is not specified in `InspectContent.info_types` list then the name is treated as a custom info type.</summary>
    [JsonPropertyName("infoType")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Defaults to `VERY_LIKELY` if not specified. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression based CustomInfoType.</summary>
    [JsonPropertyName("regex")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>Load an existing `StoredInfoType` resource for use in `InspectDataSource`. Not currently supported in `InspectContent`.</summary>
    [JsonPropertyName("storedType")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public JsonNode? SurrogateType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Type of information the findings limit applies to. Only one limit per info_type should be provided. If InfoTypeLimit does not have an info_type, the DLP API applies the limit against all info_types that are found but not specified in another InfoTypeLimit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per info_type should be provided. If InfoTypeLimit does not have an info_type, the DLP API applies the limit against all info_types that are found but not specified in another InfoTypeLimit.</summary>
    [JsonPropertyName("infoType")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public long? MaxFindings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration to control the number of findings returned. This is not used for data profiling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. When set within `InspectJobConfig`, the maximum returned is 2000 regardless if this is set higher. When set within `InspectContentRequest`, this field is ignored.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public long? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. When set within `InspectContentRequest`, the maximum returned is 2000 regardless if this is set higher.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public long? MaxFindingsPerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>List of words or phrases to search for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits. [required]</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Set of infoTypes for which findings would affect this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>InfoType list in ExclusionRule rule drops a finding when it overlaps or contained within with a finding of an infoType from this list. For example, for `InspectionRuleSet.info_types` containing "PHONE_NUMBER"` and `exclusion_rule` containing `exclude_info_types.info_types` with "EMAIL_ADDRESS" the phone number findings are dropped if they overlap with EMAIL_ADDRESS finding. That leads to "555-222-2222@example.org" to generate only a single finding, namely email address.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression which defines the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Exclusion rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>Set of infoTypes for which findings would affect this rule.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied, see MatchingType documentation for details. Possible values: MATCHING_TYPE_UNSPECIFIED, MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule.</summary>
    [JsonPropertyName("regex")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Likelihood adjustment to apply to all matching findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be `POSSIBLE` without the detection rule and `relative_likelihood` is 1, then it is upgraded to `LIKELY`, while a value of -1 would downgrade it to `UNLIKELY`. Likelihood may never drop below `VERY_UNLIKELY` or exceed `VERY_LIKELY`, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is `VERY_LIKELY` will result in a final likelihood of `LIKELY`.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public long? RelativeLikelihood { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex "(d{3}) d{3}-d{4}" could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex "(xxx)", where "xxx" is the area code in question.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider.</summary>
    [JsonPropertyName("windowAfter")]
    public long? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider.</summary>
    [JsonPropertyName("windowBefore")]
    public long? WindowBefore { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex "(d{3}) d{3}-d{4}" could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex "(xxx)", where "xxx" is the area code in question.</summary>
    [JsonPropertyName("proximity")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRules
{
    /// <summary>Exclusion rule.</summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>How and what to scan for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectConfig
{
    /// <summary>CustomInfoTypes provided by the user. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings. This is not used for data profiling.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response; see Finding.quote. This is not used for data profiling.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>Restricts what info_types to look for. The values must correspond to InfoType values returned by ListInfoTypes or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By default this may be all types, but may change over time as detectors are updated. If you need precise control and predictability as to what detectors are run you should specify specific InfoTypes listed in the reference, otherwise a default list will be used, which may change over time.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. This is not used for data profiling.</summary>
    [JsonPropertyName("limits")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfigLimits? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. The default is POSSIBLE. See https://cloud.google.com/dlp/docs/likelihood to learn more. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobInspectTemplateRef
{
    /// <summary>If provided, will be used as the default for all values in InspectConfig. `inspect_config` will be merged into the values persisted as part of the template.  Allowed value: The Google Cloud resource name of a `DLPInspectTemplate` resource (format: `{{parent}}/inspectTemplates/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceDatasetRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceProjectRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceTableRef
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
#nullable disable

#nullable enable
/// <summary>Complete BigQuery table reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary></summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceDatasetRef? DatasetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceProjectRef? ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableRef")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReferenceTableRef? TableRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQuery options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptions
{
    /// <summary>References to fields excluded from scanning. This allows you to skip inspection of entire columns which you know have no findings.</summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>Table fields that may uniquely identify a row within the table. When `actions.saveFindings.outputConfig.table` is specified, the values of columns specified here are available in the output table under `location.content_locations.record_location.record_key.id_values`. Nested fields such as `person.birthdate.year` are allowed.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>Limit scanning only to these fields.</summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If not set, or if set to 0, all rows will be scanned. Only one of rows_limit and rows_limit_percent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimit")]
    public long? RowsLimit { get; set; }

    /// <summary>Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rows_limit and rows_limit_percent can be specified. Cannot be used in conjunction with TimespanConfig.</summary>
    [JsonPropertyName("rowsLimitPercent")]
    public long? RowsLimitPercent { get; set; }

    /// <summary> Possible values: SAMPLE_METHOD_UNSPECIFIED, TOP, RANDOM_START</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>Complete BigQuery table reference.</summary>
    [JsonPropertyName("tableReference")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptionsTableReference TableReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSetBucketRef
{
    /// <summary>The name of a Cloud Storage bucket. Required.  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The regex-filtered set of files to scan. Exactly one of `url` or `regex_file_set` must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary></summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSetBucketRef BucketRef { get; set; }

    /// <summary>A list of regular expressions matching file paths to exclude. All files in the bucket that match at least one of these regular expressions will be excluded from the scan. Regular expressions use RE2 [syntax](https://github.com/google/re2/wiki/Syntax); a guide can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>A list of regular expressions matching file paths to include. All files in the bucket that match at least one of these regular expressions will be included in the set of files, except for those that also match an item in `exclude_regex`. Leaving this field empty will match all files by default (this is equivalent to including `.*` in the list). Regular expressions use RE2 [syntax](https://github.com/google/re2/wiki/Syntax); a guide can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The set of one or more files to scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>The regex-filtered set of files to scan. Exactly one of `url` or `regex_file_set` must be set.</summary>
    [JsonPropertyName("regexFileSet")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet? RegexFileSet { get; set; }

    /// <summary>The Cloud Storage url of the file(s) to scan, in the format `gs:///`. Trailing wildcard in the path is allowed. If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned non-recursively (content in sub-directories will not be scanned). This means that `gs://mybucket/` is equivalent to `gs://mybucket/*`, and `gs://mybucket/directory/` is equivalent to `gs://mybucket/directory/*`. Exactly one of `url` or `regex_file_set` must be set.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Cloud Storage options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>Max number of bytes to scan from a file. If a scanned file's size is bigger than this value then the rest of the bytes are omitted. Only one of bytes_limit_per_file and bytes_limit_per_file_percent can be specified. Cannot be set if de-identification is requested.</summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public long? BytesLimitPerFile { get; set; }

    /// <summary>Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of bytes_limit_per_file and bytes_limit_per_file_percent can be specified. Cannot be set if de-identification is requested.</summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public long? BytesLimitPerFilePercent { get; set; }

    /// <summary>The set of one or more files to scan.</summary>
    [JsonPropertyName("fileSet")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptionsFileSet? FileSet { get; set; }

    /// <summary>List of file type groups to include in the scan. If empty, all files are scanned and available data format processors are applied. In addition, the binary content of the selected files is always scanned as well. Images are scanned only as binary if the specified region does not support image inspection and no file_types were specified. Image inspection is restricted to 'global', 'us', 'asia', and 'europe'.</summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0.</summary>
    [JsonPropertyName("filesLimitPercent")]
    public long? FilesLimitPercent { get; set; }

    /// <summary> Possible values: SAMPLE_METHOD_UNSPECIFIED, TOP, RANDOM_START</summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The kind to process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>The name of the kind.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsPartitionIdProjectRef
{
    /// <summary>The ID of the project to which the entities belong.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A partition ID identifies a grouping of entities. The grouping is always by project namespace ID may be empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsPartitionIdProjectRef? ProjectRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Cloud Datastore options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptions
{
    /// <summary>The kind to process.</summary>
    [JsonPropertyName("kind")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsKind? Kind { get; set; }

    /// <summary>A partition ID identifies a grouping of entities. The grouping is always by project namespace ID may be empty.</summary>
    [JsonPropertyName("partitionId")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptionsPartitionId? PartitionId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value will stored alongside alongside each finding so that the finding can be traced to the specific row it came from. No more than 3 may be provided.</summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Hybrid inspection options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptions
{
    /// <summary>A short description of where the data is coming from. Will be stored once in the job. 256 max length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>To organize findings, these labels will be added to each finding. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. Label values must be between 0 and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. No more than 10 labels can be associated with a given finding. Examples: * `"environment" : "production"` * `"pipeline" : "etl"`</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>These are labels that each inspection request must include within their 'finding_labels' map. Request may contain others, but any missing one of these will be rejected. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. No more than 10 keys can be required.</summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.</summary>
    [JsonPropertyName("tableOptions")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptionsTableOptions? TableOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: If this value is not specified and the table was modified between the given start and end times, the entire table will be scanned. If this value is specified, then rows are filtered based on the given start and end times. Rows with a `NULL` value in the provided BigQuery column are skipped. Valid data types of the provided BigQuery column are: `INTEGER`, `DATE`, `TIMESTAMP`, and `DATETIME`. For Datastore: If this value is specified, then entities are filtered based on the given start and end times. If an entity does not contain the provided timestamp property or contains empty or invalid values, then it is included. Valid data types of the provided timestamp property are: `TIMESTAMP`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfigTimespanConfig
{
    /// <summary>When the job is started by a JobTrigger we will automatically figure out a valid start_time to avoid scanning files that have not been modified since the last time the JobTrigger executed. This will be based on the time of the execution of the last run of the JobTrigger.</summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery. For BigQuery: If this value is not specified and the table was modified between the given start and end times, the entire table will be scanned. If this value is specified, then rows are filtered based on the given start and end times. Rows with a `NULL` value in the provided BigQuery column are skipped. Valid data types of the provided BigQuery column are: `INTEGER`, `DATE`, `TIMESTAMP`, and `DATETIME`. For Datastore: If this value is specified, then entities are filtered based on the given start and end times. If an entity does not contain the provided timestamp property or contains empty or invalid values, then it is included. Valid data types of the provided timestamp property are: `TIMESTAMP`.</summary>
    [JsonPropertyName("timestampField")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigTimespanConfigTimestampField? TimestampField { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The data to scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJobStorageConfig
{
    /// <summary>BigQuery options.</summary>
    [JsonPropertyName("bigQueryOptions")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigBigQueryOptions? BigQueryOptions { get; set; }

    /// <summary>Google Cloud Storage options.</summary>
    [JsonPropertyName("cloudStorageOptions")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigCloudStorageOptions? CloudStorageOptions { get; set; }

    /// <summary>Google Cloud Datastore options.</summary>
    [JsonPropertyName("datastoreOptions")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigDatastoreOptions? DatastoreOptions { get; set; }

    /// <summary>Hybrid inspection options.</summary>
    [JsonPropertyName("hybridOptions")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigHybridOptions? HybridOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timespanConfig")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfigTimespanConfig? TimespanConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>For inspect jobs, a snapshot of the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecInspectJob
{
    /// <summary>Actions to execute at the completion of the job.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1DLPJobTriggerSpecInspectJobActions>? Actions { get; set; }

    /// <summary>How and what to scan for.</summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectConfig? InspectConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inspectTemplateRef")]
    public V1beta1DLPJobTriggerSpecInspectJobInspectTemplateRef? InspectTemplateRef { get; set; }

    /// <summary>The data to scan.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta1DLPJobTriggerSpecInspectJobStorageConfig StorageConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to. Only one of [projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>Create a job on a repeating basis based on the elapse of time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecTriggersSchedule
{
    /// <summary>With this option a job is started a regular periodic basis. For example: every day (86400 seconds). A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs. This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.</summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpecTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public JsonNode? Manual { get; set; }

    /// <summary>Create a job on a repeating basis based on the elapse of time.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1DLPJobTriggerSpecTriggersSchedule? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerSpec
{
    /// <summary>User provided description (max 256 chars)</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name (max 100 chars)</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>For inspect jobs, a snapshot of the configuration.</summary>
    [JsonPropertyName("inspectJob")]
    public V1beta1DLPJobTriggerSpecInspectJob InspectJob { get; set; }

    /// <summary>Immutable. The location of the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPJobTriggerSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Required. A status for this trigger. Possible values: STATUS_UNSPECIFIED, HEALTHY, PAUSED, CANCELLED</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>A list of triggers which will be OR'ed together. Only one in the list needs to trigger for a job to be started. The list may contain only a single Schedule trigger and must have at least one object.</summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta1DLPJobTriggerSpecTriggers> Triggers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerStatusErrorsDetailsDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized protocol buffer message. This string must contain at least one "/" character. The last segment of the URL's path must represent the fully qualified name of the type (as in `path/google.protobuf.Duration`). The name should be in a canonical form (e.g., leading "." is not accepted). In practice, teams usually precompile into the binary all types that they expect it to use in the context of Any. However, for URLs which use the scheme `http`, `https`, or no scheme, one can optionally set up a type server that maps type URLs to message definitions as follows: * If no scheme is provided, `https` is assumed. * An HTTP GET on the URL must yield a google.protobuf.Type value in binary format, or produce an error. * Applications are allowed to cache lookup results based on the URL, or have them precompiled into a binary to avoid any lookup. Therefore, binary compatibility needs to be preserved on changes to types. (Use versioned type names to manage breaking changes.) Note: this functionality is not currently available in the official protobuf release, and it is not used for type URLs beginning with type.googleapis.com. Schemes other than `http`, `https` (or the empty scheme) might be used with implementation specific semantics.</summary>
    [JsonPropertyName("typeUrl")]
    public string? TypeUrl { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Detailed error codes and messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerStatusErrorsDetails
{
    /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
    [JsonPropertyName("code")]
    public long? Code { get; set; }

    /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1beta1DLPJobTriggerStatusErrorsDetailsDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerStatusErrors
{
    /// <summary>Detailed error codes and messages.</summary>
    [JsonPropertyName("details")]
    public V1beta1DLPJobTriggerStatusErrorsDetails? Details { get; set; }

    /// <summary>The times the error occurred.</summary>
    [JsonPropertyName("timestamps")]
    public IList<string>? Timestamps { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DLPJobTriggerStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPJobTriggerStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of a triggeredJob.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. A stream of errors encountered when the trigger was activated. Repeated errors may result in the JobTrigger automatically being paused. Will return the last 100 errors. Whenever the JobTrigger is modified this list will be cleared.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1DLPJobTriggerStatusErrors>? Errors { get; set; }

    /// <summary>Output only. The timestamp of the last time this trigger executed.</summary>
    [JsonPropertyName("lastRunTime")]
    public string? LastRunTime { get; set; }

    /// <summary>Output only. The geographic location where this resource is stored.</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of a triggeredJob.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DLPJobTrigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DLPJobTriggerSpec>, IStatus<V1beta1DLPJobTriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DLPJobTrigger";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpjobtriggers";
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
    public V1beta1DLPJobTriggerSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DLPJobTriggerStatus? Status { get; set; }
}
#nullable disable
