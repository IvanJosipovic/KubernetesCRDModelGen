using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>An EnvironmentConfig contains user-defined unstructured values for use in a Composition.   Read the Crossplane documentation for [more information about EnvironmentConfigs](https://docs.crossplane.io/latest/concepts/environment-configs).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentConfig : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentConfig";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "environmentconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The data of this EnvironmentConfig. This may contain any kind of structure that can be serialized into JSON.</summary>
    [JsonPropertyName("data")]
    public IDictionary<string, JsonNode>? Data { get; set; }
}