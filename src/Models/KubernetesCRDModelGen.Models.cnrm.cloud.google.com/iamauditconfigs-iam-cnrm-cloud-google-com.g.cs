using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1beta1IAMAuditConfigSpecAuditLogConfigs
{
    /// <summary>Identities that do not cause logging for this type of permission. The format is the same as that for 'members' in IAMPolicy/IAMPolicyMember.</summary>
    [JsonPropertyName("exemptedMembers")]
    public IList<string>? ExemptedMembers { get; set; }

    /// <summary>Permission type for which logging is to be configured. Must be one of 'DATA_READ', 'DATA_WRITE', or 'ADMIN_READ'.</summary>
    [JsonPropertyName("logType")]
    public string LogType { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAMAuditConfig on (e.g. project).</summary>
public partial class V1beta1IAMAuditConfigSpecResourceRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>IAMAuditConfigSpec defines the desired state of IAMAuditConfig.</summary>
public partial class V1beta1IAMAuditConfigSpec
{
    /// <summary>Required. The configuration for logging of each type of permission.</summary>
    [JsonPropertyName("auditLogConfigs")]
    public IList<V1beta1IAMAuditConfigSpecAuditLogConfigs> AuditLogConfigs { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAMAuditConfig on (e.g. project).</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1IAMAuditConfigSpecResourceRef ResourceRef { get; set; }

    /// <summary>Immutable. Required. The service for which to enable Data Access audit logs. The special value 'allServices' covers all services. Note that if there are audit configs covering both 'allServices' and a specific service, then the union of the two audit configs is used for that service: the 'logTypes' specified in each 'auditLogConfig' are enabled, and the 'exemptedMembers' in each 'auditLogConfg' are exempted.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary></summary>
public partial class V1beta1IAMAuditConfigStatusConditions
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

/// <summary>IAMAuditConfigStatus defines the observed state of IAMAuditConfig.</summary>
public partial class V1beta1IAMAuditConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the IAMAuditConfig's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMAuditConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>IAMAuditConfig is the schema for the IAM audit logging API.</summary>
public partial class V1beta1IAMAuditConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMAuditConfigSpec>, IStatus<V1beta1IAMAuditConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMAuditConfig";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamauditconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMAuditConfigSpec defines the desired state of IAMAuditConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMAuditConfigSpec? Spec { get; set; }

    /// <summary>IAMAuditConfigStatus defines the observed state of IAMAuditConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMAuditConfigStatus? Status { get; set; }
}