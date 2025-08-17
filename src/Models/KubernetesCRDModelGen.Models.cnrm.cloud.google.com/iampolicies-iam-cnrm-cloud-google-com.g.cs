using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
#nullable enable
/// <summary>IAMPolicy is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPolicyList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampolicies";
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
    public IList<V1beta1IAMPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpecAuditConfigsAuditLogConfigs
{
    /// <summary>Identities that do not cause logging for this type of permission. The format is the same as that for 'members' in IAMPolicy/IAMPolicyMember.</summary>
    [JsonPropertyName("exemptedMembers")]
    public IList<string>? ExemptedMembers { get; set; }

    /// <summary>Permission type for which logging is to be configured. Must be one of 'DATA_READ', 'DATA_WRITE', or 'ADMIN_READ'.</summary>
    [JsonPropertyName("logType")]
    public string LogType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the Cloud Audit Logs configuration for the IAM policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpecAuditConfigs
{
    /// <summary>Required. The configuration for logging of each type of permission.</summary>
    [JsonPropertyName("auditLogConfigs")]
    public IList<V1beta1IAMPolicySpecAuditConfigsAuditLogConfigs> AuditLogConfigs { get; set; }

    /// <summary>Required. The service for which to enable Data Access audit logs. The special value 'allServices' covers all services. Note that if there are audit configs covering both 'allServices' and a specific service, then the union of the two audit configs is used for that service: the 'logTypes' specified in each 'auditLogConfig' are enabled, and the 'exemptedMembers' in each 'auditLogConfig' are exempted.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpecBindingsCondition
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
#nullable disable

#nullable enable
/// <summary>Specifies the members to bind to an IAM role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpecBindings
{
    /// <summary>Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public V1beta1IAMPolicySpecBindingsCondition? Condition { get; set; }

    /// <summary>Optional. The list of IAM users to be bound to the role.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Required. The role to bind the users to.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpecResourceRef
{
    /// <summary>APIVersion of the referenced resource</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referenced resource</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>IAMPolicySpec defines the desired state of IAMPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicySpec
{
    /// <summary>Optional. The list of IAM audit configs.</summary>
    [JsonPropertyName("auditConfigs")]
    public IList<V1beta1IAMPolicySpecAuditConfigs>? AuditConfigs { get; set; }

    /// <summary>Optional. The list of IAM bindings.</summary>
    [JsonPropertyName("bindings")]
    public IList<V1beta1IAMPolicySpecBindings>? Bindings { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1IAMPolicySpecResourceRef ResourceRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyStatusConditions
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
/// <summary>IAMPolicyStatus defines the observed state of IAMPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the IAM policy's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>IAMPolicy is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMPolicySpec>, IStatus<V1beta1IAMPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPolicy";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMPolicySpec defines the desired state of IAMPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMPolicySpec? Spec { get; set; }

    /// <summary>IAMPolicyStatus defines the observed state of IAMPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMPolicyStatus? Status { get; set; }
}
#nullable disable
