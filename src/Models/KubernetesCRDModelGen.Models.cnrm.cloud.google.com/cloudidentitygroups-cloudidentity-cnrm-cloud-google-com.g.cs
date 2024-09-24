using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudidentity.cnrm.cloud.google.com;
public partial class V1beta1CloudIdentityGroupSpecGroupKey
{
    /// <summary>Immutable. The ID of the entity.  For Google-managed entities, the id must be the email address of an existing group or user.  For external-identity-mapped entities, the id must be a string conforming to the Identity Source's requirements.  Must be unique within a namespace.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Immutable. The namespace in which the entity exists.  If not specified, the EntityKey represents a Google-managed entity such as a Google user or a Google Group.  If specified, the EntityKey represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of 'identitysources/{identity_source_id}'.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1CloudIdentityGroupSpec
{
    /// <summary>An extended description to help users determine the purpose of a Group. Must not be longer than 4,096 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. EntityKey of the Group.</summary>
    [JsonPropertyName("groupKey")]
    public V1beta1CloudIdentityGroupSpecGroupKey GroupKey { get; set; }

    /// <summary>Immutable. The initial configuration options for creating a Group.  See the [API reference](https://cloud.google.com/identity/docs/reference/rest/v1beta1/groups/create#initialgroupconfig) for possible values. Default value: "EMPTY" Possible values: ["INITIAL_GROUP_CONFIG_UNSPECIFIED", "WITH_INITIAL_OWNER", "EMPTY"].</summary>
    [JsonPropertyName("initialGroupConfig")]
    public string? InitialGroupConfig { get; set; }

    /// <summary>One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.  Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.  Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.  Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.  Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string> Labels { get; set; }

    /// <summary>Immutable. The resource name of the entity under which this Group resides in the Cloud Identity resource hierarchy.  Must be of the form identitysources/{identity_source_id} for external-identity-mapped groups or customers/{customer_id} for Google Groups.</summary>
    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1beta1CloudIdentityGroupStatusConditions
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

public partial class V1beta1CloudIdentityGroupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudIdentityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the Group was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Resource name of the Group in the format: groups/{group_id}, where group_id is the unique ID assigned to the Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The time when the Group was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudIdentityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudIdentityGroupSpec>, IStatus<V1beta1CloudIdentityGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudIdentityGroup";
    public const string KubeGroup = "cloudidentity.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidentitygroups";
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
    public V1beta1CloudIdentityGroupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1CloudIdentityGroupStatus? Status { get; set; }
}