using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits. [required]</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesStoredTypeNameRef
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

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Timestamp indicating when the version of the `StoredInfoType` used for inspection was created. Output-only field, populated by the system.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesStoredTypeNameRef? NameRef { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypes
{
    /// <summary>A list of phrases to detect as a CustomInfoType.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values: EXCLUSION_TYPE_UNSPECIFIED, EXCLUSION_TYPE_EXCLUDE</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>CustomInfoType can either be a new infoType, or an extension of built-in infoType, when the name matches one of existing infoTypes and that infoType is specified in `InspectContent.info_types` field. Specifying the latter adds findings to the one detected by the system. If built-in info type is not specified in `InspectContent.info_types` list then the name is treated as a custom info type.</summary>
    [JsonPropertyName("infoType")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Defaults to `VERY_LIKELY` if not specified. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression based CustomInfoType.</summary>
    [JsonPropertyName("regex")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>Load an existing `StoredInfoType` resource for use in `InspectDataSource`. Not currently supported in `InspectContent`.</summary>
    [JsonPropertyName("storedType")]
    public V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public JsonNode? SurrogateType { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per info_type should be provided. If InfoTypeLimit does not have an info_type, the DLP API applies the limit against all info_types that are found but not specified in another InfoTypeLimit.</summary>
    [JsonPropertyName("infoType")]
    public V1beta1DLPInspectTemplateSpecInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public long? MaxFindings { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. When set within `InspectJobConfig`, the maximum returned is 2000 regardless if this is set higher. When set within `InspectContentRequest`, this field is ignored.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public long? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. When set within `InspectContentRequest`, the maximum returned is 2000 regardless if this is set higher.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public long? MaxFindingsPerRequest { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits. [required]</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>InfoType list in ExclusionRule rule drops a finding when it overlaps or contained within with a finding of an infoType from this list. For example, for `InspectionRuleSet.info_types` containing "PHONE_NUMBER"` and `exclusion_rule` containing `exclude_info_types.info_types` with "EMAIL_ADDRESS" the phone number findings are dropped if they overlap with EMAIL_ADDRESS finding. That leads to "555-222-2222@example.org" to generate only a single finding, namely email address.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>Set of infoTypes for which findings would affect this rule.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied, see MatchingType documentation for details. Possible values: MATCHING_TYPE_UNSPECIFIED, MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule.</summary>
    [JsonPropertyName("regex")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<long>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be `POSSIBLE` without the detection rule and `relative_likelihood` is 1, then it is upgraded to `LIKELY`, while a value of -1 would downgrade it to `UNLIKELY`. Likelihood may never drop below `VERY_UNLIKELY` or exceed `VERY_LIKELY`, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is `VERY_LIKELY` will result in a final likelihood of `LIKELY`.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public long? RelativeLikelihood { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider.</summary>
    [JsonPropertyName("windowAfter")]
    public long? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider.</summary>
    [JsonPropertyName("windowBefore")]
    public long? WindowBefore { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex "(d{3}) d{3}-d{4}" could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex "(xxx)", where "xxx" is the area code in question.</summary>
    [JsonPropertyName("proximity")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRules
{
    /// <summary>Exclusion rule.</summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigRuleSetRules>? Rules { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecInspectConfig
{
    /// <summary>List of options defining data content to scan. If empty, text, images, and other content will be included.</summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>CustomInfoTypes provided by the user. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response; see Finding.quote.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>Restricts what info_types to look for. The values must correspond to InfoType values returned by ListInfoTypes or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By default this may be all types, but may change over time as detectors are updated. If you need precise control and predictability as to what detectors are run you should specify specific InfoTypes listed in the reference, otherwise a default list will be used, which may change over time.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned.</summary>
    [JsonPropertyName("limits")]
    public V1beta1DLPInspectTemplateSpecInspectConfigLimits? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. The default is POSSIBLE. See https://cloud.google.com/dlp/docs/likelihood to learn more. Possible values: LIKELIHOOD_UNSPECIFIED, VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1DLPInspectTemplateSpecInspectConfigRuleSet>? RuleSet { get; set; }
}

public partial class V1beta1DLPInspectTemplateSpecOrganizationRef
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

public partial class V1beta1DLPInspectTemplateSpecProjectRef
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

public partial class V1beta1DLPInspectTemplateSpec
{
    /// <summary>Short description (max 256 chars).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name (max 256 chars).</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The core content of the template. Configuration of the scanning process.</summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta1DLPInspectTemplateSpecInspectConfig? InspectConfig { get; set; }

    /// <summary>Immutable. The location of the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1DLPInspectTemplateSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPInspectTemplateSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1beta1DLPInspectTemplateStatusConditions
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

public partial class V1beta1DLPInspectTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPInspectTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of an inspectTemplate.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The geographic location where this resource is stored.</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of an inspectTemplate.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DLPInspectTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DLPInspectTemplateSpec>, IStatus<V1beta1DLPInspectTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DLPInspectTemplate";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpinspecttemplates";
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
    public V1beta1DLPInspectTemplateSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DLPInspectTemplateStatus? Status { get; set; }
}