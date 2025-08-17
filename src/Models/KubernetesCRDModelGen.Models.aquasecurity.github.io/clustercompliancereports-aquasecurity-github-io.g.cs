using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aquasecurity.github.io;
#nullable enable
/// <summary>ClusterComplianceReport is a specification for the ClusterComplianceReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterComplianceReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterComplianceReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterComplianceReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustercompliancereports";
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
    public IList<V1alpha1ClusterComplianceReport> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpecCheck represent the scanner who perform the control check</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControlsChecks
{
    /// <summary>id define the check id as produced by scanner</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Commands represent the commands to be executed by the node-collector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControlsCommands
{
    /// <summary>id define the commands id</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Control represent the cps controls data and mapping checks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControls
{
    /// <summary></summary>
    [JsonPropertyName("checks")]
    public IList<V1alpha1ClusterComplianceReportSpecComplianceControlsChecks>? Checks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commands")]
    public IList<V1alpha1ClusterComplianceReportSpecComplianceControlsCommands>? Commands { get; set; }

    /// <summary>define the default value for check status in case resource not found</summary>
    [JsonPropertyName("defaultStatus")]
    public string? DefaultStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>id define the control check id</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>define the severity of the control</summary>
    [JsonPropertyName("severity")]
    public string Severity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecCompliance
{
    /// <summary>Control represent the cps controls data and mapping checks</summary>
    [JsonPropertyName("controls")]
    public IList<V1alpha1ClusterComplianceReportSpecComplianceControls> Controls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relatedResources")]
    public IList<string> RelatedResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ReportSpec represent the compliance specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpec
{
    /// <summary></summary>
    [JsonPropertyName("compliance")]
    public V1alpha1ClusterComplianceReportSpecCompliance Compliance { get; set; }

    /// <summary>cron define the intervals for report generation</summary>
    [JsonPropertyName("cron")]
    public string Cron { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportStatusSummary
{
    /// <summary></summary>
    [JsonPropertyName("failCount")]
    public int? FailCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCount")]
    public int? PassCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportStatus
{
    /// <summary>ComplianceReport represents a kubernetes scan report</summary>
    [JsonPropertyName("detailReport")]
    public JsonNode? DetailReport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("summary")]
    public V1alpha1ClusterComplianceReportStatusSummary? Summary { get; set; }

    /// <summary>SummaryReport represents a kubernetes scan report with consolidated findings</summary>
    [JsonPropertyName("summaryReport")]
    public JsonNode? SummaryReport { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateTimestamp")]
    public string UpdateTimestamp { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterComplianceReport is a specification for the ClusterComplianceReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterComplianceReport : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterComplianceReportSpec>, IStatus<V1alpha1ClusterComplianceReportStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterComplianceReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustercompliancereports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }

    /// <summary>ReportSpec represent the compliance specification</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterComplianceReportSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterComplianceReportStatus? Status { get; set; }
}
#nullable disable
