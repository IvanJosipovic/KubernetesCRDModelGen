using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>ManagedApplication represents a managed application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedApplication>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedApplicationList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedapplications";
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
    public IList<V1alpha1ManagedApplication> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedApplicationSpecApiKeys
{
    /// <summary>SecretName references the name of the secret containing the API key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }

    /// <summary></summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Value is the API key value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ManagedApplicationSpec describes the ManagedApplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedApplicationSpec
{
    /// <summary>APIKeys references the API keys used to authenticate the application when calling APIs.</summary>
    [JsonPropertyName("apiKeys")]
    public IList<V1alpha1ManagedApplicationSpecApiKeys>? ApiKeys { get; set; }

    /// <summary>AppID is the identifier of the ManagedApplication. It should be unique.</summary>
    [JsonPropertyName("appId")]
    public string AppId { get; set; }

    /// <summary>Notes contains notes about application.</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>Owner represents the owner of the ManagedApplication. It should be: - `sub` when using OIDC - `externalID` when using external IDP</summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }
}

/// <summary>The current status of this ManagedApplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("apiKeyVersions")]
    public IDictionary<string, string>? ApiKeyVersions { get; set; }

    /// <summary>Hash is a hash representing the ManagedApplication.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ManagedApplication represents a managed application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedApplication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedApplicationSpec>, IStatus<V1alpha1ManagedApplicationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedApplication";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedapplications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedApplicationSpec describes the ManagedApplication.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ManagedApplicationSpec? Spec { get; set; }

    /// <summary>The current status of this ManagedApplication.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedApplicationStatus? Status { get; set; }
}