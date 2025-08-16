using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.crossplane.io;
/// <summary>SQLQuery is the Schema for the SQLQuerys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLQueryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SQLQuery>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLQueryList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlqueries";
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
    public IList<V1alpha1SQLQuery> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDateRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDateRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDateRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetimeRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetimeRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetimeRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetimesecRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterDatetimesecRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetimesecRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterEnumMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterEnum
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterEnumMultiple>? Multiple { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterQueryMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterQuery
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterQueryMultiple>? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderParameter
{
    /// <summary></summary>
    [JsonPropertyName("date")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDate>? Date { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dateRange")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDateRange>? DateRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetime")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetime>? Datetime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeRange")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetimeRange>? DatetimeRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesec")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetimesec>? Datetimesec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesecRange")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterDatetimesecRange>? DatetimesecRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enum")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterEnum>? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("number")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterNumber>? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterQuery>? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("text")]
    public IList<V1alpha1SQLQuerySpecForProviderParameterText>? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderScheduleContinuous
{
    /// <summary></summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderScheduleDaily
{
    /// <summary></summary>
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderScheduleWeekly
{
    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProviderSchedule
{
    /// <summary></summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1SQLQuerySpecForProviderScheduleContinuous>? Continuous { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daily")]
    public IList<V1alpha1SQLQuerySpecForProviderScheduleDaily>? Daily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekly")]
    public IList<V1alpha1SQLQuerySpecForProviderScheduleWeekly>? Weekly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1SQLQuerySpecForProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1SQLQuerySpecForProviderSchedule>? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDateRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDateRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDateRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetimeRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetimeRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetimeRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetimesecRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterDatetimesecRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetimesecRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterEnumMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterEnum
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterEnumMultiple>? Multiple { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterQueryMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterQuery
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterQueryMultiple>? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderParameter
{
    /// <summary></summary>
    [JsonPropertyName("date")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDate>? Date { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dateRange")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDateRange>? DateRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetime")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetime>? Datetime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeRange")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetimeRange>? DatetimeRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesec")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetimesec>? Datetimesec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesecRange")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterDatetimesecRange>? DatetimesecRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enum")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterEnum>? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("number")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterNumber>? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterQuery>? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("text")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameterText>? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderScheduleContinuous
{
    /// <summary></summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderScheduleDaily
{
    /// <summary></summary>
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderScheduleWeekly
{
    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProviderSchedule
{
    /// <summary></summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1SQLQuerySpecInitProviderScheduleContinuous>? Continuous { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daily")]
    public IList<V1alpha1SQLQuerySpecInitProviderScheduleDaily>? Daily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekly")]
    public IList<V1alpha1SQLQuerySpecInitProviderScheduleWeekly>? Weekly { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1SQLQuerySpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1SQLQuerySpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecProviderConfigRefPolicy
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
public partial class V1alpha1SQLQuerySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLQuerySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1SQLQuerySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLQuerySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1SQLQuerySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1SQLQuerySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1SQLQuerySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SQLQuerySpec defines the desired state of SQLQuery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQuerySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1SQLQuerySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1SQLQuerySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SQLQuerySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1SQLQuerySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SQLQuerySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDateRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDateRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDateRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetimeRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetimeRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetimeRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetimesecRangeRange
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterDatetimesecRange
{
    /// <summary></summary>
    [JsonPropertyName("range")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetimesecRangeRange>? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterEnumMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterEnum
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterEnumMultiple>? Multiple { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterQueryMultiple
{
    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterQuery
{
    /// <summary></summary>
    [JsonPropertyName("multiple")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterQueryMultiple>? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderParameter
{
    /// <summary></summary>
    [JsonPropertyName("date")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDate>? Date { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dateRange")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDateRange>? DateRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetime")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetime>? Datetime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimeRange")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetimeRange>? DatetimeRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesec")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetimesec>? Datetimesec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datetimesecRange")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterDatetimesecRange>? DatetimesecRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enum")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterEnum>? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("number")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterNumber>? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterQuery>? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("text")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameterText>? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderScheduleContinuous
{
    /// <summary></summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderScheduleDaily
{
    /// <summary></summary>
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderScheduleWeekly
{
    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProviderSchedule
{
    /// <summary></summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1SQLQueryStatusAtProviderScheduleContinuous>? Continuous { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daily")]
    public IList<V1alpha1SQLQueryStatusAtProviderScheduleDaily>? Daily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekly")]
    public IList<V1alpha1SQLQueryStatusAtProviderScheduleWeekly>? Weekly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1SQLQueryStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1SQLQueryStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatusConditions
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

/// <summary>SQLQueryStatus defines the observed state of SQLQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLQueryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1SQLQueryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SQLQueryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLQuery is the Schema for the SQLQuerys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLQuery : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SQLQuerySpec>, IStatus<V1alpha1SQLQueryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLQuery";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlqueries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLQuerySpec defines the desired state of SQLQuery</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SQLQuerySpec Spec { get; set; }

    /// <summary>SQLQueryStatus defines the observed state of SQLQuery.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SQLQueryStatus? Status { get; set; }
}