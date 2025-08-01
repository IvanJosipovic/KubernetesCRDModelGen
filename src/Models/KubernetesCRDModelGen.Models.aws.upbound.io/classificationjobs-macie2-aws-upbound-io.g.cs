using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.macie2.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteria
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteriaIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketDefinitions
{
    /// <summary>The unique identifier for the AWS account that owns the buckets.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array that lists the names of the buckets.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinitionScoping
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScopingIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderS3JobDefinition
{
    /// <summary>The property- and tag-based conditions that determine which S3 buckets to include or exclude from the analysis. Conflicts with bucket_definitions. (documented below)</summary>
    [JsonPropertyName("bucketCriteria")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketCriteria>? BucketCriteria { get; set; }

    /// <summary>An array of objects, one for each AWS account that owns buckets to analyze. Each object specifies the account ID for an account and one or more buckets to analyze for the account. Conflicts with bucket_criteria. (documented below)</summary>
    [JsonPropertyName("bucketDefinitions")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionBucketDefinitions>? BucketDefinitions { get; set; }

    /// <summary>The property- and tag-based conditions that determine which objects to include or exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("scoping")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinitionScoping>? Scoping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProviderScheduleFrequency
{
    /// <summary>Specifies a daily recurrence pattern for running the job.</summary>
    [JsonPropertyName("dailySchedule")]
    public bool? DailySchedule { get; set; }

    /// <summary>Specifies a monthly recurrence pattern for running the job.</summary>
    [JsonPropertyName("monthlySchedule")]
    public double? MonthlySchedule { get; set; }

    /// <summary>Specifies a weekly recurrence pattern for running the job.</summary>
    [JsonPropertyName("weeklySchedule")]
    public string? WeeklySchedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecForProvider
{
    /// <summary>The custom data identifiers to use for data analysis and classification.</summary>
    [JsonPropertyName("customDataIdentifierIds")]
    public IList<string>? CustomDataIdentifierIds { get; set; }

    /// <summary>A custom description of the job. The description can contain as many as 200 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether to analyze all existing, eligible objects immediately after the job is created.</summary>
    [JsonPropertyName("initialRun")]
    public bool? InitialRun { get; set; }

    /// <summary>The status for the job. Valid values are: CANCELLED, RUNNING and USER_PAUSED</summary>
    [JsonPropertyName("jobStatus")]
    public string? JobStatus { get; set; }

    /// <summary>The schedule for running the job. Valid values are: ONE_TIME - Run the job only once. If you specify this value, don't specify a value for the schedule_frequency property. SCHEDULED - Run the job on a daily, weekly, or monthly basis. If you specify this value, use the schedule_frequency property to define the recurrence pattern for the job.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>A custom name for the job. The name can contain as many as 500 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The S3 buckets that contain the objects to analyze, and the scope of that analysis. (documented below)</summary>
    [JsonPropertyName("s3JobDefinition")]
    public IList<V1beta1ClassificationJobSpecForProviderS3JobDefinition>? S3JobDefinition { get; set; }

    /// <summary>The sampling depth, as a percentage, to apply when processing objects. This value determines the percentage of eligible objects that the job analyzes. If this value is less than 100, Amazon Macie selects the objects to analyze at random, up to the specified percentage, and analyzes all the data in those objects.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>The recurrence pattern for running the job. To run the job only once, don't specify a value for this property and set the value for the job_type property to ONE_TIME. (documented below)</summary>
    [JsonPropertyName("scheduleFrequency")]
    public IList<V1beta1ClassificationJobSpecForProviderScheduleFrequency>? ScheduleFrequency { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteria
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteriaIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketDefinitions
{
    /// <summary>The unique identifier for the AWS account that owns the buckets.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array that lists the names of the buckets.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScoping
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScopingIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderS3JobDefinition
{
    /// <summary>The property- and tag-based conditions that determine which S3 buckets to include or exclude from the analysis. Conflicts with bucket_definitions. (documented below)</summary>
    [JsonPropertyName("bucketCriteria")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketCriteria>? BucketCriteria { get; set; }

    /// <summary>An array of objects, one for each AWS account that owns buckets to analyze. Each object specifies the account ID for an account and one or more buckets to analyze for the account. Conflicts with bucket_criteria. (documented below)</summary>
    [JsonPropertyName("bucketDefinitions")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionBucketDefinitions>? BucketDefinitions { get; set; }

    /// <summary>The property- and tag-based conditions that determine which objects to include or exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("scoping")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinitionScoping>? Scoping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProviderScheduleFrequency
{
    /// <summary>Specifies a daily recurrence pattern for running the job.</summary>
    [JsonPropertyName("dailySchedule")]
    public bool? DailySchedule { get; set; }

    /// <summary>Specifies a monthly recurrence pattern for running the job.</summary>
    [JsonPropertyName("monthlySchedule")]
    public double? MonthlySchedule { get; set; }

    /// <summary>Specifies a weekly recurrence pattern for running the job.</summary>
    [JsonPropertyName("weeklySchedule")]
    public string? WeeklySchedule { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecInitProvider
{
    /// <summary>The custom data identifiers to use for data analysis and classification.</summary>
    [JsonPropertyName("customDataIdentifierIds")]
    public IList<string>? CustomDataIdentifierIds { get; set; }

    /// <summary>A custom description of the job. The description can contain as many as 200 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies whether to analyze all existing, eligible objects immediately after the job is created.</summary>
    [JsonPropertyName("initialRun")]
    public bool? InitialRun { get; set; }

    /// <summary>The status for the job. Valid values are: CANCELLED, RUNNING and USER_PAUSED</summary>
    [JsonPropertyName("jobStatus")]
    public string? JobStatus { get; set; }

    /// <summary>The schedule for running the job. Valid values are: ONE_TIME - Run the job only once. If you specify this value, don't specify a value for the schedule_frequency property. SCHEDULED - Run the job on a daily, weekly, or monthly basis. If you specify this value, use the schedule_frequency property to define the recurrence pattern for the job.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>A custom name for the job. The name can contain as many as 500 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The S3 buckets that contain the objects to analyze, and the scope of that analysis. (documented below)</summary>
    [JsonPropertyName("s3JobDefinition")]
    public IList<V1beta1ClassificationJobSpecInitProviderS3JobDefinition>? S3JobDefinition { get; set; }

    /// <summary>The sampling depth, as a percentage, to apply when processing objects. This value determines the percentage of eligible objects that the job analyzes. If this value is less than 100, Amazon Macie selects the objects to analyze at random, up to the specified percentage, and analyzes all the data in those objects.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>The recurrence pattern for running the job. To run the job only once, don't specify a value for this property and set the value for the job_type property to ONE_TIME. (documented below)</summary>
    [JsonPropertyName("scheduleFrequency")]
    public IList<V1beta1ClassificationJobSpecInitProviderScheduleFrequency>? ScheduleFrequency { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClassificationJobSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClassificationJobSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ClassificationJobSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClassificationJobSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClassificationJobSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClassificationJobSpec defines the desired state of ClassificationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClassificationJobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClassificationJobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClassificationJobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClassificationJobSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClassificationJobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues>? TagValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("simpleCriterion")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion>? SimpleCriterion { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an S3 buckets from the job. (documented below)</summary>
    [JsonPropertyName("tagCriterion")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAndTagCriterion>? TagCriterion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteria
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteriaIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketDefinitions
{
    /// <summary>The unique identifier for the AWS account that owns the buckets.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array that lists the names of the buckets.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>An array that lists the values to use in the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues
{
    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndTagScopeTerm
{
    /// <summary>The operator to use in a condition. Valid values are: EQ, GT, GTE, LT, LTE, NE, CONTAINS, STARTS_WITH</summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>The object property to use in the condition.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The tag keys or tag key and value pairs to use in the condition.</summary>
    [JsonPropertyName("tagValues")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndTagScopeTermTagValues>? TagValues { get; set; }

    /// <summary>The type of object to apply the condition to. The only valid value is S3_OBJECT.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAnd
{
    /// <summary>A property-based condition that defines a property, operator, and one or more values for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("simpleScopeTerm")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndSimpleScopeTerm>? SimpleScopeTerm { get; set; }

    /// <summary>A tag-based condition that defines the operator and tag keys or tag key and value pairs for including or excluding an object from the job. (documented below)</summary>
    [JsonPropertyName("tagScopeTerm")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAndTagScopeTerm>? TagScopeTerm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludes
{
    /// <summary>An array of conditions, one for each condition that determines which objects to include or exclude from the job. (documented below)</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludesAnd>? And { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScoping
{
    /// <summary>The property- or tag-based conditions that determine which objects to exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingExcludes>? Excludes { get; set; }

    /// <summary>The property- or tag-based conditions that determine which objects to include in the analysis. (documented below)</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScopingIncludes>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderS3JobDefinition
{
    /// <summary>The property- and tag-based conditions that determine which S3 buckets to include or exclude from the analysis. Conflicts with bucket_definitions. (documented below)</summary>
    [JsonPropertyName("bucketCriteria")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketCriteria>? BucketCriteria { get; set; }

    /// <summary>An array of objects, one for each AWS account that owns buckets to analyze. Each object specifies the account ID for an account and one or more buckets to analyze for the account. Conflicts with bucket_criteria. (documented below)</summary>
    [JsonPropertyName("bucketDefinitions")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionBucketDefinitions>? BucketDefinitions { get; set; }

    /// <summary>The property- and tag-based conditions that determine which objects to include or exclude from the analysis. (documented below)</summary>
    [JsonPropertyName("scoping")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinitionScoping>? Scoping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderScheduleFrequency
{
    /// <summary>Specifies a daily recurrence pattern for running the job.</summary>
    [JsonPropertyName("dailySchedule")]
    public bool? DailySchedule { get; set; }

    /// <summary>Specifies a monthly recurrence pattern for running the job.</summary>
    [JsonPropertyName("monthlySchedule")]
    public double? MonthlySchedule { get; set; }

    /// <summary>Specifies a weekly recurrence pattern for running the job.</summary>
    [JsonPropertyName("weeklySchedule")]
    public string? WeeklySchedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProviderUserPausedDetails
{
    /// <summary></summary>
    [JsonPropertyName("jobExpiresAt")]
    public string? JobExpiresAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jobImminentExpirationHealthEventArn")]
    public string? JobImminentExpirationHealthEventArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jobPausedAt")]
    public string? JobPausedAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusAtProvider
{
    /// <summary>The date and time, in UTC and extended RFC 3339 format, when the job was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>The custom data identifiers to use for data analysis and classification.</summary>
    [JsonPropertyName("customDataIdentifierIds")]
    public IList<string>? CustomDataIdentifierIds { get; set; }

    /// <summary>A custom description of the job. The description can contain as many as 200 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique identifier (ID) of the macie classification job.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies whether to analyze all existing, eligible objects immediately after the job is created.</summary>
    [JsonPropertyName("initialRun")]
    public bool? InitialRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jobArn")]
    public string? JobArn { get; set; }

    /// <summary>The unique identifier (ID) of the macie classification job.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The status for the job. Valid values are: CANCELLED, RUNNING and USER_PAUSED</summary>
    [JsonPropertyName("jobStatus")]
    public string? JobStatus { get; set; }

    /// <summary>The schedule for running the job. Valid values are: ONE_TIME - Run the job only once. If you specify this value, don't specify a value for the schedule_frequency property. SCHEDULED - Run the job on a daily, weekly, or monthly basis. If you specify this value, use the schedule_frequency property to define the recurrence pattern for the job.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>A custom name for the job. The name can contain as many as 500 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The S3 buckets that contain the objects to analyze, and the scope of that analysis. (documented below)</summary>
    [JsonPropertyName("s3JobDefinition")]
    public IList<V1beta1ClassificationJobStatusAtProviderS3JobDefinition>? S3JobDefinition { get; set; }

    /// <summary>The sampling depth, as a percentage, to apply when processing objects. This value determines the percentage of eligible objects that the job analyzes. If this value is less than 100, Amazon Macie selects the objects to analyze at random, up to the specified percentage, and analyzes all the data in those objects.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>The recurrence pattern for running the job. To run the job only once, don't specify a value for this property and set the value for the job_type property to ONE_TIME. (documented below)</summary>
    [JsonPropertyName("scheduleFrequency")]
    public IList<V1beta1ClassificationJobStatusAtProviderScheduleFrequency>? ScheduleFrequency { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>If the current status of the job is USER_PAUSED, specifies when the job was paused and when the job or job run will expire and be canceled if it isn't resumed. This value is present only if the value for job-status is USER_PAUSED.</summary>
    [JsonPropertyName("userPausedDetails")]
    public IList<V1beta1ClassificationJobStatusAtProviderUserPausedDetails>? UserPausedDetails { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatusConditions
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

/// <summary>ClassificationJobStatus defines the observed state of ClassificationJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassificationJobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClassificationJobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClassificationJobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ClassificationJob is the Schema for the ClassificationJobs API. Provides a resource to manage an AWS Macie Classification Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClassificationJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClassificationJobSpec>, IStatus<V1beta1ClassificationJobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClassificationJob";
    public const string KubeGroup = "macie2.aws.upbound.io";
    public const string KubePluralName = "classificationjobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClassificationJobSpec defines the desired state of ClassificationJob</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClassificationJobSpec Spec { get; set; }

    /// <summary>ClassificationJobStatus defines the observed state of ClassificationJob.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClassificationJobStatus? Status { get; set; }
}

/// <summary>ClassificationJob is the Schema for the ClassificationJobs API. Provides a resource to manage an AWS Macie Classification Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClassificationJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ClassificationJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClassificationJobList";
    public const string KubeGroup = "macie2.aws.upbound.io";
    public const string KubePluralName = "classificationjobs";
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
    public IList<V1beta1ClassificationJob> Items { get; set; }
}