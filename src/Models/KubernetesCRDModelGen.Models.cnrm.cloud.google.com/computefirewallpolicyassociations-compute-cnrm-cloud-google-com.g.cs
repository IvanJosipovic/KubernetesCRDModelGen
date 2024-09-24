using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Immutable.</summary>
public partial class V1beta1ComputeFirewallPolicyAssociationSpecAttachmentTargetRef
{
    /// <summary>The target that the firewall policy is attached to.  Allowed values: * The Google Cloud resource name of a `Folder` resource (format: `folders/{{name}}`). * The Google Cloud resource name of a Google Cloud Organization (format: `organizations/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: Folder</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>[WARNING] Organization not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
public partial class V1beta1ComputeFirewallPolicyAssociationSpecFirewallPolicyRef
{
    /// <summary>The firewall policy ID of the association.  Allowed value: The Google Cloud resource name of a `ComputeFirewallPolicy` resource (format: `locations/global/firewallPolicies/{{name}}`).</summary>
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
public partial class V1beta1ComputeFirewallPolicyAssociationSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("attachmentTargetRef")]
    public V1beta1ComputeFirewallPolicyAssociationSpecAttachmentTargetRef AttachmentTargetRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("firewallPolicyRef")]
    public V1beta1ComputeFirewallPolicyAssociationSpecFirewallPolicyRef FirewallPolicyRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1beta1ComputeFirewallPolicyAssociationStatusConditions
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
public partial class V1beta1ComputeFirewallPolicyAssociationStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeFirewallPolicyAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The short name of the firewall policy of the association.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1ComputeFirewallPolicyAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeFirewallPolicyAssociationSpec>, IStatus<V1beta1ComputeFirewallPolicyAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeFirewallPolicyAssociation";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computefirewallpolicyassociations";
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
    public V1beta1ComputeFirewallPolicyAssociationSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeFirewallPolicyAssociationStatus? Status { get; set; }
}