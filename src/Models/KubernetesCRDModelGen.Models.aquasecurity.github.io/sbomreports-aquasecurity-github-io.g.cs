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
/// <summary>SbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SbomReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SbomReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SbomReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "sbomreports";
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
    public IList<V1alpha1SbomReport> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportArtifact
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsLicensesLicense
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsComponentsLicensesLicense? License { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsSupplierContact
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsComponentsSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponents
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsComponentsHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsComponentsLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsComponentsProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsComponentsSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsDependencies
{
    /// <summary></summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentLicensesLicense
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsMetadataComponentLicensesLicense? License { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentSupplierContact
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponent
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsMetadataComponentSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsHashes
{
    /// <summary></summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicensesLicense
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicenses
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicensesLicense? License { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsProperties
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplierContact
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplier
{
    /// <summary></summary>
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplierContact>? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponents
{
    /// <summary></summary>
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsHashes>? Hashes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicenses>? Licenses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsProperties>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplier? Supplier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataTools
{
    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponents>? Components { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadata
{
    /// <summary></summary>
    [JsonPropertyName("component")]
    public V1alpha1SbomReportReportComponentsMetadataComponent? Component { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tools")]
    public V1alpha1SbomReportReportComponentsMetadataTools? Tools { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Bom is artifact bill of materials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponents
{
    /// <summary></summary>
    [JsonPropertyName("bomFormat")]
    public string BomFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<V1alpha1SbomReportReportComponentsComponents>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dependencies")]
    public IList<V1alpha1SbomReportReportComponentsDependencies>? Dependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1SbomReportReportComponentsMetadata? Metadata { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Registry is the registry the Artifact was pulled from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportRegistry
{
    /// <summary>Server the FQDN of registry server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Scanner is the scanner that generated this report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportScanner
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
/// <summary>Summary is a summary of sbom report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportSummary
{
    /// <summary>ComponentsCount is the number of components in bom.</summary>
    [JsonPropertyName("componentsCount")]
    public int ComponentsCount { get; set; }

    /// <summary>DependenciesCount is the number of dependencies in bom.</summary>
    [JsonPropertyName("dependenciesCount")]
    public int DependenciesCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Report is the actual sbom report data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReport
{
    /// <summary>Artifact represents a standalone, executable package of software that includes everything needed to run an application.</summary>
    [JsonPropertyName("artifact")]
    public V1alpha1SbomReportReportArtifact Artifact { get; set; }

    /// <summary>Bom is artifact bill of materials.</summary>
    [JsonPropertyName("components")]
    public V1alpha1SbomReportReportComponents Components { get; set; }

    /// <summary>Registry is the registry the Artifact was pulled from.</summary>
    [JsonPropertyName("registry")]
    public V1alpha1SbomReportReportRegistry? Registry { get; set; }

    /// <summary>Scanner is the scanner that generated this report.</summary>
    [JsonPropertyName("scanner")]
    public V1alpha1SbomReportReportScanner Scanner { get; set; }

    /// <summary>Summary is a summary of sbom report.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1SbomReportReportSummary Summary { get; set; }

    /// <summary>UpdateTimestamp is a timestamp representing the server time in UTC when this report was updated.</summary>
    [JsonPropertyName("updateTimestamp")]
    public string UpdateTimestamp { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SbomReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SbomReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "sbomreports";
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

    /// <summary>Report is the actual sbom report data.</summary>
    [JsonPropertyName("report")]
    public V1alpha1SbomReportReport Report { get; set; }
}
#nullable disable
