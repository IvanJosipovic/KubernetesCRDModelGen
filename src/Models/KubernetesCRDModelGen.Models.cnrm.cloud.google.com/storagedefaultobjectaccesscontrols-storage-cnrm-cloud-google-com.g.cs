using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
/// <summary>Reference to the bucket.</summary>
public partial class V1beta1StorageDefaultObjectAccessControlSpecBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
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
public partial class V1beta1StorageDefaultObjectAccessControlSpec
{
    /// <summary>Reference to the bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageDefaultObjectAccessControlSpecBucketRef BucketRef { get; set; }

    /// <summary>The entity holding the permission, in one of the following forms:   * user-{{userId}}   * user-{{email}} (such as "user-liz@example.com")   * group-{{groupId}}   * group-{{email}} (such as "group-example@googlegroups.com")   * domain-{{domain}} (such as "domain-example.com")   * project-team-{{projectId}}   * allUsers   * allAuthenticatedUsers.</summary>
    [JsonPropertyName("entity")]
    public string Entity { get; set; }

    /// <summary>The name of the object, if applied to an object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>The access permission for the entity. Possible values: ["OWNER", "READER"].</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageDefaultObjectAccessControlStatusConditions
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

/// <summary>The project team associated with the entity.</summary>
public partial class V1beta1StorageDefaultObjectAccessControlStatusProjectTeam
{
    /// <summary>The project team associated with the entity.</summary>
    [JsonPropertyName("projectNumber")]
    public string? ProjectNumber { get; set; }

    /// <summary>The team. Possible values: ["editors", "owners", "viewers"].</summary>
    [JsonPropertyName("team")]
    public string? Team { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageDefaultObjectAccessControlStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageDefaultObjectAccessControlStatusConditions>? Conditions { get; set; }

    /// <summary>The domain associated with the entity.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The email address associated with the entity.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The ID for the entity.</summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>The content generation of the object, if applied to an object.</summary>
    [JsonPropertyName("generation")]
    public int? Generation { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The project team associated with the entity.</summary>
    [JsonPropertyName("projectTeam")]
    public V1beta1StorageDefaultObjectAccessControlStatusProjectTeam? ProjectTeam { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1StorageDefaultObjectAccessControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageDefaultObjectAccessControlSpec>, IStatus<V1beta1StorageDefaultObjectAccessControlStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageDefaultObjectAccessControl";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagedefaultobjectaccesscontrols";
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
    public V1beta1StorageDefaultObjectAccessControlSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1StorageDefaultObjectAccessControlStatus? Status { get; set; }
}