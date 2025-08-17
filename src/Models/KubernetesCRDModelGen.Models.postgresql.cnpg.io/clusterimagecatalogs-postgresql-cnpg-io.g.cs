using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
#nullable enable
/// <summary>ClusterImageCatalog is the Schema for the clusterimagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterImageCatalogList : IKubernetesObject<V1ListMeta>, IItems<V1ClusterImageCatalog>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterImageCatalogList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusterimagecatalogs";
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
    public IList<V1ClusterImageCatalog> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CatalogImage defines the image and major version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecImages
{
    /// <summary>The image reference</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>The PostgreSQL major version of the image. Must be unique within the catalog.</summary>
    [JsonPropertyName("major")]
    public int Major { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification of the desired behavior of the ClusterImageCatalog. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpec
{
    /// <summary>List of CatalogImages available in the catalog</summary>
    [JsonPropertyName("images")]
    public IList<V1ClusterImageCatalogSpecImages> Images { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterImageCatalog is the Schema for the clusterimagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterImageCatalog : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterImageCatalogSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterImageCatalog";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusterimagecatalogs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the ClusterImageCatalog. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1ClusterImageCatalogSpec Spec { get; set; }
}
#nullable disable
