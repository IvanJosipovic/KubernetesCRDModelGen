using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.crossplane.io;
/// <summary>Query is the Schema for the Querys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1QueryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Query>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "QueryList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "queries";
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
    public IList<V1alpha1Query> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QuerySpecForProviderParameterDateRangeValueDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QuerySpecForProviderParameterEnumValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QuerySpecForProviderParameterQueryBackedValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QuerySpecForProviderParameterDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1alpha1QuerySpecForProviderParameterDateValue>? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public IList<V1alpha1QuerySpecForProviderParameterEnumValue>? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public IList<V1alpha1QuerySpecForProviderParameterNumericValue>? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public IList<V1alpha1QuerySpecForProviderParameterQueryBackedValue>? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public IList<V1alpha1QuerySpecForProviderParameterTextValue>? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecForProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Query owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1QuerySpecForProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user's home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the "Run as" role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterDateRangeValueDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QuerySpecInitProviderParameterEnumValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QuerySpecInitProviderParameterQueryBackedValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterDateValue>? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterEnumValue>? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterNumericValue>? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterQueryBackedValue>? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public IList<V1alpha1QuerySpecInitProviderParameterTextValue>? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecInitProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Query owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1QuerySpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user's home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the "Run as" role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecProviderConfigRefPolicy
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
public partial class V1alpha1QuerySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1QuerySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1QuerySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1QuerySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1QuerySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1QuerySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1QuerySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>QuerySpec defines the desired state of Query</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QuerySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1QuerySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1QuerySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1QuerySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1QuerySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1QuerySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterDateRangeValueDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QueryStatusAtProviderParameterEnumValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public IList<V1alpha1QueryStatusAtProviderParameterQueryBackedValueMultiValuesOptions>? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterDateRangeValue>? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterDateValue>? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterEnumValue>? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterNumericValue>? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterQueryBackedValue>? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public IList<V1alpha1QueryStatusAtProviderParameterTextValue>? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusAtProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The timestamp string indicating when the query was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>unique ID of the created Query.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Username of the user who last saved changes to this query.</summary>
    [JsonPropertyName("lastModifierUserName")]
    public string? LastModifierUserName { get; set; }

    /// <summary>The workspace state of the query. Used for tracking trashed status. (Possible values are ACTIVE or TRASHED).</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    /// <summary>Query owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1QueryStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user's home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the "Run as" role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The timestamp string indicating when the query was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatusConditions
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

/// <summary>QueryStatus defines the observed state of Query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QueryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1QueryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1QueryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Query is the Schema for the Querys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Query : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1QuerySpec>, IStatus<V1alpha1QueryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Query";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "queries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QuerySpec defines the desired state of Query</summary>
    [JsonPropertyName("spec")]
    public V1alpha1QuerySpec Spec { get; set; }

    /// <summary>QueryStatus defines the observed state of Query.</summary>
    [JsonPropertyName("status")]
    public V1alpha1QueryStatus? Status { get; set; }
}