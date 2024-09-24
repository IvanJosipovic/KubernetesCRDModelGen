using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
public partial class V1ClusterImageCatalogSpecImages
{
    /// <summary>The image reference</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>The PostgreSQL major version of the image. Must be unique within the catalog.</summary>
    [JsonPropertyName("major")]
    public int Major { get; set; }
}

public partial class V1ClusterImageCatalogSpec
{
    /// <summary>List of CatalogImages available in the catalog</summary>
    [JsonPropertyName("images")]
    public IList<V1ClusterImageCatalogSpecImages> Images { get; set; }
}

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