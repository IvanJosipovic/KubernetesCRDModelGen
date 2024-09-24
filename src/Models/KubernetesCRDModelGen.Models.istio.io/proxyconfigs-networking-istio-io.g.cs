using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
/// <summary>Specifies the details of the proxy image.</summary>
public partial class V1beta1ProxyConfigSpecImage
{
    /// <summary>The image type of the image.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }
}

/// <summary>Optional.</summary>
public partial class V1beta1ProxyConfigSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Provides configuration for individual workloads. See more details at: https://istio.io/docs/reference/config/networking/proxy-config.html</summary>
public partial class V1beta1ProxyConfigSpec
{
    /// <summary>The number of worker threads to run.</summary>
    [JsonPropertyName("concurrency")]
    public int? Concurrency { get; set; }

    /// <summary>Additional environment variables for the proxy.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Specifies the details of the proxy image.</summary>
    [JsonPropertyName("image")]
    public V1beta1ProxyConfigSpecImage? Image { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1beta1ProxyConfigSpecSelector? Selector { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1ProxyConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProxyConfigSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProxyConfig";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "proxyconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Provides configuration for individual workloads. See more details at: https://istio.io/docs/reference/config/networking/proxy-config.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProxyConfigSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}