using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.orgpolicy.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1alpha1OrgPolicyCustomConstraintSpec
{
    /// <summary>The action to take if the condition is met. Possible values: ["ALLOW", "DENY"].</summary>
    [JsonPropertyName("actionType")]
    public string ActionType { get; set; }

    /// <summary>A CEL condition that refers to a supported service resource, for example 'resource.management.autoUpgrade == false'. For details about CEL usage, see [Common Expression Language](https://cloud.google.com/resource-manager/docs/organization-policy/creating-managing-custom-constraints#common_expression_language).</summary>
    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    /// <summary>A human-friendly description of the constraint to display as an error message when the policy is violated.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A human-friendly name for the constraint.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A list of RESTful methods for which to enforce the constraint. Can be 'CREATE', 'UPDATE', or both. Not all Google Cloud services support both methods. To see supported methods for each service, find the service in [Supported services](https://cloud.google.com/resource-manager/docs/organization-policy/custom-constraint-supported-services).</summary>
    [JsonPropertyName("methodTypes")]
    public IList<string> MethodTypes { get; set; }

    /// <summary>Immutable. The parent of the resource, an organization. Format should be 'organizations/{organization_id}'.</summary>
    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Immutable. The fully qualified name of the Google Cloud REST resource containing the object and field you want to restrict. For example, 'container.googleapis.com/NodePool'.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string> ResourceTypes { get; set; }
}

/// <summary></summary>
public partial class V1alpha1OrgPolicyCustomConstraintStatusConditions
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
public partial class V1alpha1OrgPolicyCustomConstraintStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrgPolicyCustomConstraintStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The timestamp representing when the constraint was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1OrgPolicyCustomConstraint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrgPolicyCustomConstraintSpec>, IStatus<V1alpha1OrgPolicyCustomConstraintStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrgPolicyCustomConstraint";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicycustomconstraints";
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
    public V1alpha1OrgPolicyCustomConstraintSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1OrgPolicyCustomConstraintStatus? Status { get; set; }
}