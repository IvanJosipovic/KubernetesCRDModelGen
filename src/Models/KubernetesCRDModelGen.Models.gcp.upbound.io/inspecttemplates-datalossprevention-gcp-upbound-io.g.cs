using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSurrogateType
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. For tabular data, the context includes the column name. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProviderInspectConfig
{
    /// <summary>List of options defining data content to scan. If empty, text, images, and other content will be included. Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.</summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By default this may be all types, but may change over time as detectors are updated. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfigRuleSet>? RuleSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecForProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1InspectTemplateSpecForProviderInspectConfig>? InspectConfig { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSurrogateType
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. For tabular data, the context includes the column name. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProviderInspectConfig
{
    /// <summary>List of options defining data content to scan. If empty, text, images, and other content will be included. Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.</summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By default this may be all types, but may change over time as detectors are updated. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfigRuleSet>? RuleSet { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecInitProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1InspectTemplateSpecInitProviderInspectConfig>? InspectConfig { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InspectTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InspectTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InspectTemplateSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InspectTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InspectTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InspectTemplateSpec defines the desired state of InspectTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InspectTemplateSpecDeletionPolicyEnum>))]
    public V1beta1InspectTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InspectTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InspectTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InspectTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InspectTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InspectTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InspectTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSurrogateType
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypes
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionary>? Dictionary { get; set; }

    /// <summary>If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values are: EXCLUSION_TYPE_EXCLUDE.</summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoType>? InfoType { get; set; }

    /// <summary>Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria specified by the rule. Default value is VERY_LIKELY. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesRegex>? Regex { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>A reference to a StoredInfoType to use with scanning. Structure is documented below.</summary>
    [JsonPropertyName("storedType")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesStoredType>? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSurrogateType>? SurrogateType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does not have an infoType, the DLP API applies the limit against all infoTypes that are found but not specified in another InfoTypeLimit. Structure is documented below.</summary>
    [JsonPropertyName("infoType")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType>? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigLimits
{
    /// <summary>Configuration of findings limit given for specified infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath>? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342 or projects/project-id/storedInfoTypes/432452342.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionary>? Dictionary { get; set; }

    /// <summary>Drop if the hotword rule is contained in the proximate context. For tabular data, the context includes the column name. Structure is documented below.</summary>
    [JsonPropertyName("excludeByHotword")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword>? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes>? ExcludeInfoTypes { get; set; }

    /// <summary>How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.</summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleRegex>? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1, then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY. Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.</summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>Regular expression pattern defining what qualifies as a hotword. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRegex")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex>? HotwordRegex { get; set; }

    /// <summary>Likelihood adjustment to apply to all matching findings. Structure is documented below.</summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment>? LikelihoodAdjustment { get; set; }

    /// <summary>Proximity of the finding within which the entire hotword must reside. The total length of the window cannot exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be used to match substrings of the finding itself. For example, the certainty of a phone number regex (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company office using the hotword regex (xxx), where xxx is the area code in question. Structure is documented below.</summary>
    [JsonPropertyName("proximity")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleProximity>? Proximity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRules
{
    /// <summary>The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results. Structure is documented below.</summary>
    [JsonPropertyName("exclusionRule")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRule>? ExclusionRule { get; set; }

    /// <summary>Hotword-based detection rule. Structure is documented below.</summary>
    [JsonPropertyName("hotwordRule")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRule>? HotwordRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSet
{
    /// <summary>List of infoTypes this rule set is applied to. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order. Structure is documented below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProviderInspectConfig
{
    /// <summary>List of options defining data content to scan. If empty, text, images, and other content will be included. Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.</summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more. Structure is documented below.</summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By default this may be all types, but may change over time as detectors are updated. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>Configuration to control the number of findings returned. Structure is documented below.</summary>
    [JsonPropertyName("limits")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigLimits>? Limits { get; set; }

    /// <summary>Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value is POSSIBLE. Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.</summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end, other rules are executed in the order they are specified for each info type. Structure is documented below.</summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfigRuleSet>? RuleSet { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusAtProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/inspectTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The core content of the template. Structure is documented below.</summary>
    [JsonPropertyName("inspectConfig")]
    public IList<V1beta1InspectTemplateStatusAtProviderInspectConfig>? InspectConfig { get; set; }

    /// <summary>The resource name of the inspect template. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatusConditions
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

/// <summary>InspectTemplateStatus defines the observed state of InspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InspectTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InspectTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InspectTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InspectTemplate is the Schema for the InspectTemplates API. An inspect job template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InspectTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InspectTemplateSpec>, IStatus<V1beta1InspectTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InspectTemplate";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "inspecttemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InspectTemplateSpec defines the desired state of InspectTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1InspectTemplateSpec Spec { get; set; }

    /// <summary>InspectTemplateStatus defines the observed state of InspectTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1InspectTemplateStatus? Status { get; set; }
}