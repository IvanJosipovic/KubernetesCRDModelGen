using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
/// <summary>IAMPartialPolicy is the Schema for the iampartialpolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPartialPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMPartialPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPartialPolicyList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampartialpolicies";
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
    public IList<V1beta1IAMPartialPolicy> Items { get; set; }
}

/// <summary>Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsCondition
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

/// <summary>BigQueryConnectionConnection whose service account is to be bound to the role. Use the Type field to specifie the connection type. For "spark" connetion, the service account is in `status.observedState.spark.serviceAccountID`. For "cloudSQL" connection, the service account is in `status.observedState.cloudSQL.serviceAccountID`. For "cloudResource" connection, the service account is in `status.observedState.cloudResource.serviceAccountID`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFromBigQueryConnectionConnectionRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Type field specifies the connection type of the BigQueryConnectionConnection resource, whose service account is to be bound to the role.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The LoggingLogSink whose writer identity (i.e. its 'status.writerIdentity') is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFromLogSinkRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The IAMServiceAccount to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFromServiceAccountRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The ServiceIdentity whose service account (i.e., its 'status.email') is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFromServiceIdentityRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The SQLInstance whose service account (i.e. its 'status.serviceAccountEmailAddress') is to be bound to the role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFromSqlInstanceRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used, and only one subfield within 'memberFrom' can be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembersMemberFrom
{
    /// <summary>BigQueryConnectionConnection whose service account is to be bound to the role. Use the Type field to specifie the connection type. For "spark" connetion, the service account is in `status.observedState.spark.serviceAccountID`. For "cloudSQL" connection, the service account is in `status.observedState.cloudSQL.serviceAccountID`. For "cloudResource" connection, the service account is in `status.observedState.cloudResource.serviceAccountID`.</summary>
    [JsonPropertyName("bigQueryConnectionConnectionRef")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFromBigQueryConnectionConnectionRef? BigQueryConnectionConnectionRef { get; set; }

    /// <summary>The LoggingLogSink whose writer identity (i.e. its 'status.writerIdentity') is to be bound to the role.</summary>
    [JsonPropertyName("logSinkRef")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFromLogSinkRef? LogSinkRef { get; set; }

    /// <summary>The IAMServiceAccount to be bound to the role.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFromServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The ServiceIdentity whose service account (i.e., its 'status.email') is to be bound to the role.</summary>
    [JsonPropertyName("serviceIdentityRef")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFromServiceIdentityRef? ServiceIdentityRef { get; set; }

    /// <summary>The SQLInstance whose service account (i.e. its 'status.serviceAccountEmailAddress') is to be bound to the role.</summary>
    [JsonPropertyName("sqlInstanceRef")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFromSqlInstanceRef? SqlInstanceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindingsMembers
{
    /// <summary>The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used.</summary>
    [JsonPropertyName("member")]
    public string? Member { get; set; }

    /// <summary>The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used, and only one subfield within 'memberFrom' can be used.</summary>
    [JsonPropertyName("memberFrom")]
    public V1beta1IAMPartialPolicySpecBindingsMembersMemberFrom? MemberFrom { get; set; }
}

/// <summary>Specifies the members to bind to an IAM role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecBindings
{
    /// <summary>Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public V1beta1IAMPartialPolicySpecBindingsCondition? Condition { get; set; }

    /// <summary>Optional. The list of IAM users to be bound to the role.</summary>
    [JsonPropertyName("members")]
    public IList<V1beta1IAMPartialPolicySpecBindingsMembers>? Members { get; set; }

    /// <summary>Required. The role to bind the users to.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpecResourceRef
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

/// <summary>IAMPartialPolicySpec defines the desired state of IAMPartialPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicySpec
{
    /// <summary>Optional. The list of IAM bindings managed by Config Connector.</summary>
    [JsonPropertyName("bindings")]
    public IList<V1beta1IAMPartialPolicySpecBindings>? Bindings { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAM policy on (e.g. organization, project...)</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1IAMPartialPolicySpecResourceRef ResourceRef { get; set; }
}

/// <summary>Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicyStatusAllBindingsCondition
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
public partial class V1beta1IAMPartialPolicyStatusAllBindings
{
    /// <summary>Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public V1beta1IAMPartialPolicyStatusAllBindingsCondition? Condition { get; set; }

    /// <summary>Optional. The list of IAM users to be bound to the role.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Required. The role to bind the users to.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicyStatusConditions
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

/// <summary>Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicyStatusLastAppliedBindingsCondition
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
public partial class V1beta1IAMPartialPolicyStatusLastAppliedBindings
{
    /// <summary>Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public V1beta1IAMPartialPolicyStatusLastAppliedBindingsCondition? Condition { get; set; }

    /// <summary>Optional. The list of IAM users to be bound to the role.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>Required. The role to bind the users to.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary>IAMPartialPolicyStatus defines the observed state of IAMPartialPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMPartialPolicyStatus
{
    /// <summary>AllBindings surfaces all IAM bindings for the referenced resource.</summary>
    [JsonPropertyName("allBindings")]
    public IList<V1beta1IAMPartialPolicyStatusAllBindings>? AllBindings { get; set; }

    /// <summary>Conditions represent the latest available observations of the IAM policy's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMPartialPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>LastAppliedBindings is the list of IAM bindings that were most recently applied by Config Connector.</summary>
    [JsonPropertyName("lastAppliedBindings")]
    public IList<V1beta1IAMPartialPolicyStatusLastAppliedBindings>? LastAppliedBindings { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAMPartialPolicy is the Schema for the iampartialpolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMPartialPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMPartialPolicySpec>, IStatus<V1beta1IAMPartialPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMPartialPolicy";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iampartialpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMPartialPolicySpec defines the desired state of IAMPartialPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMPartialPolicySpec? Spec { get; set; }

    /// <summary>IAMPartialPolicyStatus defines the observed state of IAMPartialPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMPartialPolicyStatus? Status { get; set; }
}