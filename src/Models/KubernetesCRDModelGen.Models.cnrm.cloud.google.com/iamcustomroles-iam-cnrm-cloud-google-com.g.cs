using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
public partial class V1beta1IAMCustomRoleSpec
{
    /// <summary>A human-readable description for the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.</summary>
    [JsonPropertyName("permissions")]
    public IList<string> Permissions { get; set; }

    /// <summary>Immutable. Optional. The roleId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The current launch stage of the role. Defaults to GA.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>A human-readable title for the role.</summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

public partial class V1beta1IAMCustomRoleStatusConditions
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

public partial class V1beta1IAMCustomRoleStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMCustomRoleStatusConditions>? Conditions { get; set; }

    /// <summary>The current deleted state of the role.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>The full name of the role.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMCustomRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMCustomRoleSpec>, IStatus<V1beta1IAMCustomRoleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMCustomRole";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamcustomroles";
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
    public V1beta1IAMCustomRoleSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IAMCustomRoleStatus? Status { get; set; }
}