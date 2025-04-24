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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpecAuditConfigsAuditLogConfigs
{
    /// <summary>Identities that do not cause logging for this type of permission. The format is the same as that for 'members' in IAMPolicy/IAMPolicyMember.</summary>
    [JsonPropertyName("exemptedMembers")]
    public IList<string>? ExemptedMembers { get; set; }

    /// <summary>Permission type for which logging is to be configured. Must be one of 'DATA_READ', 'DATA_WRITE', or 'ADMIN_READ'.</summary>
    [JsonPropertyName("logType")]
    public string LogType { get; set; }
}

/// <summary>Specifies the Cloud Audit Logs configuration for the IAM policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpecAuditConfigs
{
    /// <summary>Required. The configuration for logging of each type of permission.</summary>
    [JsonPropertyName("auditLogConfigs")]
    public IList<IAMPolicySpecAuditConfigsAuditLogConfigs> AuditLogConfigs { get; set; }

    /// <summary>Required. The service for which to enable Data Access audit logs. The special value 'allServices' covers all services. Note that if there are audit configs covering both 'allServices' and a specific service, then the union of the two audit configs is used for that service: the 'logTypes' specified in each 'auditLogConfig' are enabled, and the 'exemptedMembers' in each 'auditLogConfig' are exempted.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary>Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpecBindingsCondition
{
    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>Specifies the members to bind to an IAM role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpecBindings
{
    /// <summary>Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public IAMPolicySpecBindingsCondition? Condition { get; set; }

    /// <summary>Optional. The list of IAM users to be bound to the role.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Required. The role to bind the users to.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAM policy on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpecResourceRef
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

/// <summary>IAMPolicySpec defines the desired state of IAMPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicySpec
{
    /// <summary>Optional. The list of IAM audit configs.</summary>
    [JsonPropertyName("auditConfigs")]
    public IList<IAMPolicySpecAuditConfigs>? AuditConfigs { get; set; }

    /// <summary>Optional. The list of IAM bindings.</summary>
    [JsonPropertyName("bindings")]
    public IList<IAMPolicySpecBindings>? Bindings { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAM policy on.</summary>
    [JsonPropertyName("resourceRef")]
    public IAMPolicySpecResourceRef ResourceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyStatusConditions
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

/// <summary>IAMPolicyStatus defines the observed state of IAMPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the IAM policy's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<IAMPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAMPolicy is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicy
{
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IAMPolicyMetadata? Metadata { get; set; }

    /// <summary>IAMPolicySpec defines the desired state of IAMPolicy</summary>
    [JsonPropertyName("spec")]
    public IAMPolicySpec? Spec { get; set; }

    /// <summary>IAMPolicyStatus defines the observed state of IAMPolicy</summary>
    [JsonPropertyName("status")]
    public IAMPolicyStatus? Status { get; set; }
}