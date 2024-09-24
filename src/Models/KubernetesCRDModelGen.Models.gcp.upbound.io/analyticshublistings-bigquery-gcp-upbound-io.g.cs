using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum
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
public partial class V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRef? DatasetRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetSelector")]
    public V1beta1AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelector? DatasetSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum
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
public partial class V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecForProvider
{
    /// <summary>Shared dataset i.e. BigQuery dataset source. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryDataset")]
    public IList<V1beta1AnalyticsHubListingSpecForProviderBigqueryDataset>? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Reference to a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
    [JsonPropertyName("dataExchangeIdRef")]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdRef? DataExchangeIdRef { get; set; }

    /// <summary>Selector for a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
    [JsonPropertyName("dataExchangeIdSelector")]
    public V1beta1AnalyticsHubListingSpecForProviderDataExchangeIdSelector? DataExchangeIdSelector { get; set; }

    /// <summary>Details of the data provider who owns the source data. Structure is documented below.</summary>
    [JsonPropertyName("dataProvider")]
    public IList<V1beta1AnalyticsHubListingSpecForProviderDataProvider>? DataProvider { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can't start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>The name of the location this data exchange listing.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Details of the publisher who owns the listing and who can share the source data. Structure is documented below.</summary>
    [JsonPropertyName("publisher")]
    public IList<V1beta1AnalyticsHubListingSpecForProviderPublisher>? Publisher { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>If set, restricted export configuration will be propagated and enforced on the linked dataset. Structure is documented below.</summary>
    [JsonPropertyName("restrictedExportConfig")]
    public IList<V1beta1AnalyticsHubListingSpecForProviderRestrictedExportConfig>? RestrictedExportConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum
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
public partial class V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRef? DatasetRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetSelector")]
    public V1beta1AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelector? DatasetSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecInitProvider
{
    /// <summary>Shared dataset i.e. BigQuery dataset source. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryDataset")]
    public IList<V1beta1AnalyticsHubListingSpecInitProviderBigqueryDataset>? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>Details of the data provider who owns the source data. Structure is documented below.</summary>
    [JsonPropertyName("dataProvider")]
    public IList<V1beta1AnalyticsHubListingSpecInitProviderDataProvider>? DataProvider { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can't start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Details of the publisher who owns the listing and who can share the source data. Structure is documented below.</summary>
    [JsonPropertyName("publisher")]
    public IList<V1beta1AnalyticsHubListingSpecInitProviderPublisher>? Publisher { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>If set, restricted export configuration will be propagated and enforced on the linked dataset. Structure is documented below.</summary>
    [JsonPropertyName("restrictedExportConfig")]
    public IList<V1beta1AnalyticsHubListingSpecInitProviderRestrictedExportConfig>? RestrictedExportConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1AnalyticsHubListingSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AnalyticsHubListingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AnalyticsHubListingSpec defines the desired state of AnalyticsHubListing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AnalyticsHubListingSpecDeletionPolicyEnum>))]
    public V1beta1AnalyticsHubListingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AnalyticsHubListingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AnalyticsHubListingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AnalyticsHubListingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AnalyticsHubListingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AnalyticsHubListingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AnalyticsHubListingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusAtProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusAtProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusAtProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusAtProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusAtProvider
{
    /// <summary>Shared dataset i.e. BigQuery dataset source. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryDataset")]
    public IList<V1beta1AnalyticsHubListingStatusAtProviderBigqueryDataset>? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Details of the data provider who owns the source data. Structure is documented below.</summary>
    [JsonPropertyName("dataProvider")]
    public IList<V1beta1AnalyticsHubListingStatusAtProviderDataProvider>? DataProvider { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can't start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/dataExchanges/{{data_exchange_id}}/listings/{{listing_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the location this data exchange listing.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The resource name of the listing. e.g. "projects/myproject/locations/US/dataExchanges/123/listings/456"</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Details of the publisher who owns the listing and who can share the source data. Structure is documented below.</summary>
    [JsonPropertyName("publisher")]
    public IList<V1beta1AnalyticsHubListingStatusAtProviderPublisher>? Publisher { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>If set, restricted export configuration will be propagated and enforced on the linked dataset. Structure is documented below.</summary>
    [JsonPropertyName("restrictedExportConfig")]
    public IList<V1beta1AnalyticsHubListingStatusAtProviderRestrictedExportConfig>? RestrictedExportConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatusConditions
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

/// <summary>AnalyticsHubListingStatus defines the observed state of AnalyticsHubListing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AnalyticsHubListingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AnalyticsHubListingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AnalyticsHubListingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AnalyticsHubListing is the Schema for the AnalyticsHubListings API. A Bigquery Analytics Hub data exchange listing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AnalyticsHubListing : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AnalyticsHubListingSpec>, IStatus<V1beta1AnalyticsHubListingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AnalyticsHubListing";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "analyticshublistings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AnalyticsHubListingSpec defines the desired state of AnalyticsHubListing</summary>
    [JsonPropertyName("spec")]
    public V1beta1AnalyticsHubListingSpec Spec { get; set; }

    /// <summary>AnalyticsHubListingStatus defines the observed state of AnalyticsHubListing.</summary>
    [JsonPropertyName("status")]
    public V1beta1AnalyticsHubListingStatus? Status { get; set; }
}