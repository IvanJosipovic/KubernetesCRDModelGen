using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aquasecurity.github.io;
/// <summary>ClusterSbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterSbomReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterSbomReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterSbomReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustersbomreports";
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
    public IList<V1alpha1ClusterSbomReport> Items { get; set; }
}

/// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportArtifact
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsLicensesLicense
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1ClusterSbomReportReportComponentsComponentsLicensesLicense? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsSupplierContact
{
    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponentsSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1ClusterSbomReportReportComponentsComponentsSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsComponents
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1ClusterSbomReportReportComponentsComponentsHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1ClusterSbomReportReportComponentsComponentsLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1ClusterSbomReportReportComponentsComponentsProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1ClusterSbomReportReportComponentsComponentsSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsDependencies
{
    /// <summary></summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentLicensesLicense
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataComponentLicensesLicense? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentSupplierContact
{
    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponentSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataComponentSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataComponent
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataComponentHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataComponentLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataComponentProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataComponentSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsLicensesLicense
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsLicensesLicense? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsSupplierContact
{
    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponents
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponentsSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadataTools
{
    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<V1alpha1ClusterSbomReportReportComponentsMetadataToolsComponents>? Components { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponentsMetadata
{
    /// <summary></summary>
    [JsonPropertyName("component")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataComponent? Component { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tools")]
    public V1alpha1ClusterSbomReportReportComponentsMetadataTools? Tools { get; set; }
}

/// <summary>Bom is artifact bill of materials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportComponents
{
    /// <summary></summary>
    [JsonPropertyName("bomFormat")]
    public string BomFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<V1alpha1ClusterSbomReportReportComponentsComponents>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dependencies")]
    public IList<V1alpha1ClusterSbomReportReportComponentsDependencies>? Dependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterSbomReportReportComponentsMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("specVersion")]
    public string SpecVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>Registry is the registry the Artifact was pulled from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportRegistry
{
    /// <summary>Server the FQDN of registry server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>Scanner is the scanner that generated this report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportScanner
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

/// <summary>Summary is a summary of sbom report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReportSummary
{
    /// <summary>ComponentsCount is the number of components in bom.</summary>
    [JsonPropertyName("componentsCount")]
    public int ComponentsCount { get; set; }

    /// <summary>DependenciesCount is the number of dependencies in bom.</summary>
    [JsonPropertyName("dependenciesCount")]
    public int DependenciesCount { get; set; }
}

/// <summary>Report is the actual sbom report data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSbomReportReport
{
    /// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
    [JsonPropertyName("artifact")]
    public V1alpha1ClusterSbomReportReportArtifact Artifact { get; set; }

    /// <summary>Bom is artifact bill of materials.</summary>
    [JsonPropertyName("components")]
    public V1alpha1ClusterSbomReportReportComponents Components { get; set; }

    /// <summary>Registry is the registry the Artifact was pulled from.</summary>
    [JsonPropertyName("registry")]
    public V1alpha1ClusterSbomReportReportRegistry? Registry { get; set; }

    /// <summary>Scanner is the scanner that generated this report.</summary>
    [JsonPropertyName("scanner")]
    public V1alpha1ClusterSbomReportReportScanner Scanner { get; set; }

    /// <summary>Summary is a summary of sbom report.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1ClusterSbomReportReportSummary Summary { get; set; }

    /// <summary>UpdateTimestamp is a timestamp representing the server time in UTC when this report was updated.</summary>
    [JsonPropertyName("updateTimestamp")]
    public string UpdateTimestamp { get; set; }
}

/// <summary>ClusterSbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterSbomReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterSbomReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustersbomreports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Report is the actual sbom report data.</summary>
    [JsonPropertyName("report")]
    public V1alpha1ClusterSbomReportReport Report { get; set; }
}