using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.speech.cnrm.cloud.google.com;
#nullable enable
/// <summary>SpeechPhraseSet is the Schema for the SpeechPhraseSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpeechPhraseSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpeechPhraseSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpeechPhraseSetList";
    public const string KubeGroup = "speech.cnrm.cloud.google.com";
    public const string KubePluralName = "speechphrasesets";
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
    public IList<V1beta1SpeechPhraseSet> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetSpecPhrases
{
    /// <summary>Hint Boost. Overrides the boost set at the phrase set level. Positive value will increase the probability that a specific phrase will be recognized over other similar sounding phrases. The higher the boost, the higher the chance of false positive recognition as well. Negative boost values would correspond to anti-biasing. Anti-biasing is not enabled, so negative boost values will return an error. Boost values must be between 0 and 20. Any values outside that range will return an error. We recommend using a binary search approach to finding the optimal value for your use case as well as adding phrases both with and without boost to your requests.</summary>
    [JsonPropertyName("boost")]
    public string? Boost { get; set; }

    /// <summary>The phrase itself.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpeechPhraseSetSpec defines the desired state of SpeechPhraseSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetSpec
{
    /// <summary>Allows users to store small amounts of arbitrary data. Both the key and the value must be 63 characters or less each. At most 100 annotations.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>User-settable, human-readable name for the PhraseSet. Must be 63 characters or less.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>A list of word and phrases.</summary>
    [JsonPropertyName("phrases")]
    public IList<V1beta1SpeechPhraseSetSpecPhrases>? Phrases { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1SpeechPhraseSetSpecProjectRef ProjectRef { get; set; }

    /// <summary>The SpeechPhraseSet name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetStatusObservedState
{
    /// <summary>Output only. Creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this resource was requested for deletion.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields. This may be sent on update, undelete, and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The time at which this resource will be purged.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The [KMS key name](https://cloud.google.com/kms/docs/resource-hierarchy#keys) with which the PhraseSet is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Output only. The [KMS key version name](https://cloud.google.com/kms/docs/resource-hierarchy#key_versions) with which the PhraseSet is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }

    /// <summary>Output only. Whether or not this PhraseSet is in the process of being updated.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The PhraseSet lifecycle state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-assigned unique identifier for the PhraseSet.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The most recent time this resource was modified.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpeechPhraseSetStatus defines the config connector machine state of SpeechPhraseSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpeechPhraseSetStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpeechPhraseSetStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpeechPhraseSet resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SpeechPhraseSetStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpeechPhraseSet is the Schema for the SpeechPhraseSet API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpeechPhraseSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpeechPhraseSetSpec>, IStatus<V1beta1SpeechPhraseSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpeechPhraseSet";
    public const string KubeGroup = "speech.cnrm.cloud.google.com";
    public const string KubePluralName = "speechphrasesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpeechPhraseSetSpec defines the desired state of SpeechPhraseSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpeechPhraseSetSpec Spec { get; set; }

    /// <summary>SpeechPhraseSetStatus defines the config connector machine state of SpeechPhraseSet</summary>
    [JsonPropertyName("status")]
    public V1beta1SpeechPhraseSetStatus? Status { get; set; }
}
#nullable disable
