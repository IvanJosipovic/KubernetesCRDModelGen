using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aquasecurity.github.io;
/// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReportArtifact
{
    /// <summary>Digest is a unique and immutable identifier of an Artifact.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>MimeType represents a type and format of an Artifact.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>Repository is the name of the repository in the Artifact registry.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Tag is a mutable, human-readable string used to identify an Artifact.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Registry is the registry the Artifact was pulled from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReportRegistry
{
    /// <summary>Server the FQDN of registry server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>Scanner is the scanner that generated this report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReportScanner
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

/// <summary>ExposedSecret is the spec for a exposed secret record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReportSecrets
{
    /// <summary></summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>Match where the exposed rule matched.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }

    /// <summary>RuleID is rule the identifier.</summary>
    [JsonPropertyName("ruleID")]
    public string RuleID { get; set; }

    /// <summary>Severity level of a vulnerability or a configuration audit check.</summary>
    [JsonPropertyName("severity")]
    public string Severity { get; set; }

    /// <summary>Target is where the exposed secret was found.</summary>
    [JsonPropertyName("target")]
    public string Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>Summary is the exposed secrets counts grouped by Severity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReportSummary
{
    /// <summary>CriticalCount is the number of exposed secrets with Critical Severity.</summary>
    [JsonPropertyName("criticalCount")]
    public int CriticalCount { get; set; }

    /// <summary>HighCount is the number of exposed secrets with High Severity.</summary>
    [JsonPropertyName("highCount")]
    public int HighCount { get; set; }

    /// <summary>LowCount is the number of exposed secrets with Low Severity.</summary>
    [JsonPropertyName("lowCount")]
    public int LowCount { get; set; }

    /// <summary>MediumCount is the number of exposed secrets with Medium Severity.</summary>
    [JsonPropertyName("mediumCount")]
    public int MediumCount { get; set; }
}

/// <summary>Report is the actual exposed secret report data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExposedSecretReportReport
{
    /// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
    [JsonPropertyName("artifact")]
    public V1alpha1ExposedSecretReportReportArtifact Artifact { get; set; }

    /// <summary>Registry is the registry the Artifact was pulled from.</summary>
    [JsonPropertyName("registry")]
    public V1alpha1ExposedSecretReportReportRegistry? Registry { get; set; }

    /// <summary>Scanner is the scanner that generated this report.</summary>
    [JsonPropertyName("scanner")]
    public V1alpha1ExposedSecretReportReportScanner Scanner { get; set; }

    /// <summary>Exposed secrets is a list of passwords, api keys, tokens and others items found in the Artifact.</summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1ExposedSecretReportReportSecrets> Secrets { get; set; }

    /// <summary>Summary is the exposed secrets counts grouped by Severity.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1ExposedSecretReportReportSummary Summary { get; set; }

    /// <summary>UpdateTimestamp is a timestamp representing the server time in UTC when this report was updated.</summary>
    [JsonPropertyName("updateTimestamp")]
    public string UpdateTimestamp { get; set; }
}

/// <summary>ExposedSecretReport summarizes exposed secrets in plaintext files built into container images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ExposedSecretReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ExposedSecretReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "exposedsecretreports";
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

    /// <summary>Report is the actual exposed secret report data.</summary>
    [JsonPropertyName("report")]
    public V1alpha1ExposedSecretReportReport Report { get; set; }
}

/// <summary>ExposedSecretReport summarizes exposed secrets in plaintext files built into container images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ExposedSecretReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ExposedSecretReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ExposedSecretReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "exposedsecretreports";
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
    public IList<V1alpha1ExposedSecretReport> Items { get; set; }
}