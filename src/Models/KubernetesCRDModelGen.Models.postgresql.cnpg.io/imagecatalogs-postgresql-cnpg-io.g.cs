using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>CatalogImage defines the image and major version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageCatalogSpecImages
{
    /// <summary>The image reference</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>The PostgreSQL major version of the image. Must be unique within the catalog.</summary>
    [JsonPropertyName("major")]
    public int Major { get; set; }
}

/// <summary>Specification of the desired behavior of the ImageCatalog. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageCatalogSpec
{
    /// <summary>List of CatalogImages available in the catalog</summary>
    [JsonPropertyName("images")]
    public IList<V1ImageCatalogSpecImages> Images { get; set; }
}

/// <summary>ImageCatalog is the Schema for the imagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageCatalog : IKubernetesObject<V1ObjectMeta>, ISpec<V1ImageCatalogSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageCatalog";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "imagecatalogs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the ImageCatalog. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1ImageCatalogSpec Spec { get; set; }
}

/// <summary>ImageCatalog is the Schema for the imagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageCatalogList : IKubernetesObject<V1ListMeta>, IItems<V1ImageCatalog>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageCatalogList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "imagecatalogs";
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
    public IList<V1ImageCatalog> Items { get; set; }
}