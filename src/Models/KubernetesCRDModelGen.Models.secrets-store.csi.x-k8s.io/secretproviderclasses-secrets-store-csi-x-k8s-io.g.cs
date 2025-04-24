using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretsstore.csi.xk8s.io;
/// <summary>SecretObjectData defines the desired state of synced K8s secret object data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassSpecSecretObjectsData
{
    /// <summary>data field to populate</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name of the object to sync</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>SecretObject defines the desired state of synced K8s secret objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassSpecSecretObjects
{
    /// <summary>annotations of k8s secret object</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("data")]
    public IList<V1SecretProviderClassSpecSecretObjectsData>? Data { get; set; }

    /// <summary>labels of K8s secret object</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>name of the K8s secret object</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>type of K8s secret object</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SecretProviderClassSpec defines the desired state of SecretProviderClass</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassSpec
{
    /// <summary>Configuration for specific provider</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration for provider name</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretObjects")]
    public IList<V1SecretProviderClassSpecSecretObjects>? SecretObjects { get; set; }
}

/// <summary>SecretProviderClassStatus defines the observed state of SecretProviderClass</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecretProviderClassStatus
{
}

/// <summary>SecretProviderClass is the Schema for the secretproviderclasses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecretProviderClass : IKubernetesObject<V1ObjectMeta>, ISpec<V1SecretProviderClassSpec>, IStatus<V1SecretProviderClassStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecretProviderClass";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretProviderClassSpec defines the desired state of SecretProviderClass</summary>
    [JsonPropertyName("spec")]
    public V1SecretProviderClassSpec? Spec { get; set; }

    /// <summary>SecretProviderClassStatus defines the observed state of SecretProviderClass</summary>
    [JsonPropertyName("status")]
    public V1SecretProviderClassStatus? Status { get; set; }
}

/// <summary>SecretProviderClass is the Schema for the secretproviderclasses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecretProviderClassList : IKubernetesObject<V1ListMeta>, IItems<V1SecretProviderClass>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecretProviderClassList";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasses";
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
    public IList<V1SecretProviderClass> Items { get; set; }
}