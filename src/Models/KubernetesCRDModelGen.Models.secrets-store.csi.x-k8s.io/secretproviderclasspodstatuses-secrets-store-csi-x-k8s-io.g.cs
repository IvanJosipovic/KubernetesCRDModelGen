using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretsstore.csi.xk8s.io;
public partial class V1SecretProviderClassPodStatusStatusObjects
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

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