using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sourcerepo.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SourceRepoRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SourceRepoRepository>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SourceRepoRepositoryList";
    public const string KubeGroup = "sourcerepo.cnrm.cloud.google.com";
    public const string KubePluralName = "sourcereporepositories";
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
    public IList<V1beta1SourceRepoRepository> Items { get; set; }
}

/// <summary>Service account used for publishing Cloud Pub/Sub messages. This service account needs to be in the same project as the pubsubConfig. When added, the caller needs to have iam.serviceAccounts.actAs permission on this service account. If unspecified, it defaults to the compute engine default service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositorySpecPubsubConfigsServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositorySpecPubsubConfigsTopicRef
{
    /// <summary>Allowed value: The `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositorySpecPubsubConfigs
{
    /// <summary>The format of the Cloud Pub/Sub messages. - PROTOBUF: The message payload is a serialized protocol buffer of SourceRepoEvent. - JSON: The message payload is a JSON string of SourceRepoEvent. Possible values: ["PROTOBUF", "JSON"].</summary>
    [JsonPropertyName("messageFormat")]
    public string MessageFormat { get; set; }

    /// <summary>Service account used for publishing Cloud Pub/Sub messages. This service account needs to be in the same project as the pubsubConfig. When added, the caller needs to have iam.serviceAccounts.actAs permission on this service account. If unspecified, it defaults to the compute engine default service account.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1SourceRepoRepositorySpecPubsubConfigsServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topicRef")]
    public V1beta1SourceRepoRepositorySpecPubsubConfigsTopicRef TopicRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositorySpec
{
    /// <summary>How this repository publishes a change in the repository through Cloud Pub/Sub. Keyed by the topic names.</summary>
    [JsonPropertyName("pubsubConfigs")]
    public IList<V1beta1SourceRepoRepositorySpecPubsubConfigs>? PubsubConfigs { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositoryStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SourceRepoRepositoryStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SourceRepoRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The disk usage of the repo, in bytes.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>URL to clone the repository from Google Cloud Source Repositories.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SourceRepoRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SourceRepoRepositorySpec>, IStatus<V1beta1SourceRepoRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SourceRepoRepository";
    public const string KubeGroup = "sourcerepo.cnrm.cloud.google.com";
    public const string KubePluralName = "sourcereporepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1SourceRepoRepositorySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1SourceRepoRepositoryStatus? Status { get; set; }
}