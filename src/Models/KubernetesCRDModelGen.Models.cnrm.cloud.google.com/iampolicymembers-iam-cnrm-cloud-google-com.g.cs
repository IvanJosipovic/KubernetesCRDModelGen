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
public partial class IAMPolicyMemberMetadata
{
}

/// <summary>Immutable. Optional. The condition under which the binding applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberSpecCondition
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
public partial class IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRef
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
public partial class IAMPolicyMemberSpecMemberFromLogSinkRef
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
public partial class IAMPolicyMemberSpecMemberFromServiceAccountRef
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
public partial class IAMPolicyMemberSpecMemberFromServiceIdentityRef
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
public partial class IAMPolicyMemberSpecMemberFromSqlInstanceRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used, and only one subfield within 'memberFrom' can be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberSpecMemberFrom
{
    /// <summary>BigQueryConnectionConnection whose service account is to be bound to the role. Use the Type field to specifie the connection type. For "spark" connetion, the service account is in `status.observedState.spark.serviceAccountID`. For "cloudSQL" connection, the service account is in `status.observedState.cloudSQL.serviceAccountID`. For "cloudResource" connection, the service account is in `status.observedState.cloudResource.serviceAccountID`.</summary>
    [JsonPropertyName("bigQueryConnectionConnectionRef")]
    public IAMPolicyMemberSpecMemberFromBigQueryConnectionConnectionRef? BigQueryConnectionConnectionRef { get; set; }

    /// <summary>The LoggingLogSink whose writer identity (i.e. its 'status.writerIdentity') is to be bound to the role.</summary>
    [JsonPropertyName("logSinkRef")]
    public IAMPolicyMemberSpecMemberFromLogSinkRef? LogSinkRef { get; set; }

    /// <summary>The IAMServiceAccount to be bound to the role.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public IAMPolicyMemberSpecMemberFromServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The ServiceIdentity whose service account (i.e., its 'status.email') is to be bound to the role.</summary>
    [JsonPropertyName("serviceIdentityRef")]
    public IAMPolicyMemberSpecMemberFromServiceIdentityRef? ServiceIdentityRef { get; set; }

    /// <summary>The SQLInstance whose service account (i.e. its 'status.serviceAccountEmailAddress') is to be bound to the role.</summary>
    [JsonPropertyName("sqlInstanceRef")]
    public IAMPolicyMemberSpecMemberFromSqlInstanceRef? SqlInstanceRef { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAM policy on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberSpecResourceRef
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

/// <summary>IAMPolicyMemberSpec defines the desired state of IAMPolicyMember</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberSpec
{
    /// <summary>Immutable. Optional. The condition under which the binding applies.</summary>
    [JsonPropertyName("condition")]
    public IAMPolicyMemberSpecCondition? Condition { get; set; }

    /// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used.</summary>
    [JsonPropertyName("member")]
    public string? Member { get; set; }

    /// <summary>Immutable. The IAM identity to be bound to the role. Exactly one of 'member' or 'memberFrom' must be used, and only one subfield within 'memberFrom' can be used.</summary>
    [JsonPropertyName("memberFrom")]
    public IAMPolicyMemberSpecMemberFrom? MemberFrom { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAM policy on.</summary>
    [JsonPropertyName("resourceRef")]
    public IAMPolicyMemberSpecResourceRef ResourceRef { get; set; }

    /// <summary>Immutable. Required. The role for which the Member will be bound.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberStatusConditions
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

/// <summary>IAMPolicyMemberStatus defines the observed state of IAMPolicyMember</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMemberStatus
{
    /// <summary>Conditions represent the latest available observations of the IAM policy's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<IAMPolicyMemberStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAMPolicyMember is the Schema for the iampolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IAMPolicyMember
{
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IAMPolicyMemberMetadata? Metadata { get; set; }

    /// <summary>IAMPolicyMemberSpec defines the desired state of IAMPolicyMember</summary>
    [JsonPropertyName("spec")]
    public IAMPolicyMemberSpec? Spec { get; set; }

    /// <summary>IAMPolicyMemberStatus defines the observed state of IAMPolicyMember</summary>
    [JsonPropertyName("status")]
    public IAMPolicyMemberStatus? Status { get; set; }
}