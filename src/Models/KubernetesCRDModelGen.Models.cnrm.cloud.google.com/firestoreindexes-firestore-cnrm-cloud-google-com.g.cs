using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexSpecFields
{
    /// <summary>Immutable. Indicates that this field supports operations on arrayValues. Only one of 'order' and 'arrayConfig' can be specified. Possible values: ["CONTAINS"].</summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Immutable. Name of the field.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Immutable. Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=. Only one of 'order' and 'arrayConfig' can be specified. Possible values: ["ASCENDING", "DESCENDING"].</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexSpec
{
    /// <summary>Immutable. The collection being indexed.</summary>
    [JsonPropertyName("collection")]
    public string Collection { get; set; }

    /// <summary>Immutable. The Firestore database id. Defaults to '"(default)"'.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Immutable. The fields supported by this index. The last field entry is always for the field path '__name__'. If, on creation, '__name__' was not specified as the last field, it will be added automatically with the same direction as that of the last field defined. If the final field in a composite index is not directional, the '__name__' will be ordered '"ASCENDING"' (unless explicitly specified otherwise).</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1FirestoreIndexSpecFields> Fields { get; set; }

    /// <summary>Immutable. The scope at which a query is run. Default value: "COLLECTION" Possible values: ["COLLECTION", "COLLECTION_GROUP"].</summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexStatusConditions
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
public partial class V1beta1FirestoreIndexStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirestoreIndexStatusConditions>? Conditions { get; set; }

    /// <summary>A server defined name for this index. Format: 'projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirestoreIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirestoreIndexSpec>, IStatus<V1beta1FirestoreIndexStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirestoreIndex";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestoreindexes";
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
    public V1beta1FirestoreIndexSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1FirestoreIndexStatus? Status { get; set; }
}