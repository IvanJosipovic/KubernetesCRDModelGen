using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securityhub.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InsightSpecDeletionPolicyEnum
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
public partial class V1beta1InsightSpecForProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersFirstObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersNoteUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessTerminatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceContainerLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecForProviderFiltersUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta1InsightSpecForProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta1InsightSpecForProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta1InsightSpecForProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding's confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta1InsightSpecForProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta1InsightSpecForProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta1InsightSpecForProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding's description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1InsightSpecForProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider's original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta1InsightSpecForProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta1InsightSpecForProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta1InsightSpecForProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta1InsightSpecForProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta1InsightSpecForProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta1InsightSpecForProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta1InsightSpecForProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta1InsightSpecForProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta1InsightSpecForProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta1InsightSpecForProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta1InsightSpecForProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider's product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta1InsightSpecForProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren't part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta1InsightSpecForProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta1InsightSpecForProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta1InsightSpecForProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta1InsightSpecForProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta1InsightSpecForProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta1InsightSpecForProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn't have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta1InsightSpecForProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta1InsightSpecForProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding's severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta1InsightSpecForProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider's solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta1InsightSpecForProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta1InsightSpecForProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding's title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta1InsightSpecForProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta1InsightSpecForProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta1InsightSpecForProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta1InsightSpecForProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta1InsightSpecForProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta1InsightSpecForProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecForProvider
{
    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1InsightSpecForProviderFilters>? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersFirstObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersNoteUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessTerminatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceContainerLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightSpecInitProviderFiltersUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta1InsightSpecInitProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta1InsightSpecInitProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta1InsightSpecInitProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding's confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta1InsightSpecInitProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta1InsightSpecInitProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding's description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1InsightSpecInitProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider's original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta1InsightSpecInitProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta1InsightSpecInitProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta1InsightSpecInitProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta1InsightSpecInitProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta1InsightSpecInitProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta1InsightSpecInitProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta1InsightSpecInitProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta1InsightSpecInitProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta1InsightSpecInitProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta1InsightSpecInitProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta1InsightSpecInitProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider's product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta1InsightSpecInitProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren't part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta1InsightSpecInitProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta1InsightSpecInitProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta1InsightSpecInitProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta1InsightSpecInitProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta1InsightSpecInitProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta1InsightSpecInitProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn't have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta1InsightSpecInitProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding's severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta1InsightSpecInitProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider's solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta1InsightSpecInitProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta1InsightSpecInitProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding's title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta1InsightSpecInitProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta1InsightSpecInitProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta1InsightSpecInitProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta1InsightSpecInitProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta1InsightSpecInitProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta1InsightSpecInitProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecInitProvider
{
    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1InsightSpecInitProviderFilters>? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InsightSpecManagementPoliciesEnum
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
public enum V1beta1InsightSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1InsightSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1InsightSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InsightSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InsightSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InsightSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InsightSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InsightSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InsightSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1InsightSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InsightSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InsightSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InsightSpec defines the desired state of Insight</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InsightSpecDeletionPolicyEnum>))]
    public V1beta1InsightSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InsightSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InsightSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InsightSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InsightSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InsightSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InsightSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersFirstObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersNoteUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessTerminatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding's CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceContainerLaunchedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public IList<V1beta1InsightStatusAtProviderFiltersUpdatedAtDateRange>? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta1InsightStatusAtProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta1InsightStatusAtProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta1InsightStatusAtProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding's confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta1InsightStatusAtProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta1InsightStatusAtProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding's description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1InsightStatusAtProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider's original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta1InsightStatusAtProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta1InsightStatusAtProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta1InsightStatusAtProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta1InsightStatusAtProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta1InsightStatusAtProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta1InsightStatusAtProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta1InsightStatusAtProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta1InsightStatusAtProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta1InsightStatusAtProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta1InsightStatusAtProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta1InsightStatusAtProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider's product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta1InsightStatusAtProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren't part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta1InsightStatusAtProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta1InsightStatusAtProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta1InsightStatusAtProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta1InsightStatusAtProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta1InsightStatusAtProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta1InsightStatusAtProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn't have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta1InsightStatusAtProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding's severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta1InsightStatusAtProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider's solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta1InsightStatusAtProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta1InsightStatusAtProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding's title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta1InsightStatusAtProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta1InsightStatusAtProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta1InsightStatusAtProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta1InsightStatusAtProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta1InsightStatusAtProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta1InsightStatusAtProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusAtProvider
{
    /// <summary>ARN of the insight.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1InsightStatusAtProviderFilters>? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>ARN of the insight.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatusConditions
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

/// <summary>InsightStatus defines the observed state of Insight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InsightStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InsightStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InsightStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Insight is the Schema for the Insights API. Provides a Security Hub custom insight resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Insight : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InsightSpec>, IStatus<V1beta1InsightStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Insight";
    public const string KubeGroup = "securityhub.aws.upbound.io";
    public const string KubePluralName = "insights";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InsightSpec defines the desired state of Insight</summary>
    [JsonPropertyName("spec")]
    public V1beta1InsightSpec Spec { get; set; }

    /// <summary>InsightStatus defines the observed state of Insight.</summary>
    [JsonPropertyName("status")]
    public V1beta1InsightStatus? Status { get; set; }
}