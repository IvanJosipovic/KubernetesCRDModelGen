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
/// <summary>ClusterConfigAuditReport is a specification for the ClusterConfigAuditReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterConfigAuditReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterConfigAuditReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterConfigAuditReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clusterconfigauditreports";
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
    public IList<V1alpha1ClusterConfigAuditReport> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Scope indicates the section of config that was audited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterConfigAuditReportReportChecksScope
{
    /// <summary>Type indicates type of this scope, e.g. Container, ConfigMapKey or JSONPath.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>Value indicates value of this scope that depends on Type, e.g. container name, ConfigMap key or JSONPath expression</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Check provides the result of conducting a single audit step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterConfigAuditReportReportChecks
{
    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("checkID")]
    public string CheckID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messages")]
    public IList<string>? Messages { get; set; }

    /// <summary>Remediation provides description or links to external resources to remediate failing check.</summary>
    [JsonPropertyName("remediation")]
    public string? Remediation { get; set; }

    /// <summary>Scope indicates the section of config that was audited.</summary>
    [JsonPropertyName("scope")]
    public V1alpha1ClusterConfigAuditReportReportChecksScope? Scope { get; set; }

    /// <summary>Severity level of a vulnerability or a configuration audit check.</summary>
    [JsonPropertyName("severity")]
    public string Severity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary></summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Scanner is the spec for a scanner generating a security assessment report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterConfigAuditReportReportScanner
{
    /// <summary>Name the name of the scanner.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Vendor the name of the vendor providing the scanner.</summary>
    [JsonPropertyName("vendor")]
    public string Vendor { get; set; }

    /// <summary>Version the version of the scanner.</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigAuditSummary counts failed checks by severity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterConfigAuditReportReportSummary
{
    /// <summary>CriticalCount is the number of failed checks with critical severity.</summary>
    [JsonPropertyName("criticalCount")]
    public int CriticalCount { get; set; }

    /// <summary>HighCount is the number of failed checks with high severity.</summary>
    [JsonPropertyName("highCount")]
    public int HighCount { get; set; }

    /// <summary>LowCount is the number of failed check with low severity.</summary>
    [JsonPropertyName("lowCount")]
    public int LowCount { get; set; }

    /// <summary>MediumCount is the number of failed checks with medium severity.</summary>
    [JsonPropertyName("mediumCount")]
    public int MediumCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterConfigAuditReportReport
{
    /// <summary>Checks provides results of conducting audit steps.</summary>
    [JsonPropertyName("checks")]
    public IList<V1alpha1ClusterConfigAuditReportReportChecks> Checks { get; set; }

    /// <summary>Scanner is the spec for a scanner generating a security assessment report.</summary>
    [JsonPropertyName("scanner")]
    public V1alpha1ClusterConfigAuditReportReportScanner? Scanner { get; set; }

    /// <summary>ConfigAuditSummary counts failed checks by severity.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1ClusterConfigAuditReportReportSummary? Summary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateTimestamp")]
    public string? UpdateTimestamp { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterConfigAuditReport is a specification for the ClusterConfigAuditReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterConfigAuditReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterConfigAuditReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clusterconfigauditreports";
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

    /// <summary></summary>
    [JsonPropertyName("report")]
    public V1alpha1ClusterConfigAuditReportReport Report { get; set; }
}
#nullable disable
