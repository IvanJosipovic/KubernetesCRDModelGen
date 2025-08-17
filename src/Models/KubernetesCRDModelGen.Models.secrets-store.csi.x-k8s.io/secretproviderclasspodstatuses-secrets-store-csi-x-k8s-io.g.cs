using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretsstore.csi.xk8s.io;
#nullable enable
/// <summary>SecretProviderClassPodStatus is the Schema for the secretproviderclassespodstatus API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecretProviderClassPodStatusList : IKubernetesObject<V1ListMeta>, IItems<V1SecretProviderClassPodStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecretProviderClassPodStatusList";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasspodstatuses";
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
    public IList<V1SecretProviderClassPodStatus> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretProviderClassObject defines the object fetched from external secrets store</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassPodStatusStatusObjects
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretProviderClassPodStatusStatus defines the observed state of SecretProviderClassPodStatus</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassPodStatusStatus
{
    /// <summary></summary>
    [JsonPropertyName("mounted")]
    public bool? Mounted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objects")]
    public IList<V1SecretProviderClassPodStatusStatusObjects>? Objects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podName")]
    public string? PodName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretProviderClassName")]
    public string? SecretProviderClassName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretProviderClassPodStatus is the Schema for the secretproviderclassespodstatus API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecretProviderClassPodStatus : IKubernetesObject<V1ObjectMeta>, IStatus<V1SecretProviderClassPodStatusStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecretProviderClassPodStatus";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasspodstatuses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretProviderClassPodStatusStatus defines the observed state of SecretProviderClassPodStatus</summary>
    [JsonPropertyName("status")]
    public V1SecretProviderClassPodStatusStatus? Status { get; set; }
}
#nullable disable
