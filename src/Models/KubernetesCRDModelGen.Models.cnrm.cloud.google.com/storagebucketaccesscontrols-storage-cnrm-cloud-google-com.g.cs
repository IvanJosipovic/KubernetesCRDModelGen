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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageBucketAccessControlSpecBucketRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageBucketAccessControlSpec
{
    /// <summary>Reference to the bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageBucketAccessControlSpecBucketRef BucketRef { get; set; }

    /// <summary>Immutable. The entity holding the permission, in one of the following forms:   user-userId   user-email   group-groupId   group-email   domain-domain   project-team-projectId   allUsers   allAuthenticatedUsers Examples:   The user liz@example.com would be user-liz@example.com.   The group example@googlegroups.com would be   group-example@googlegroups.com.   To refer to all members of the Google Apps for Business domain   example.com, the entity would be domain-example.com.</summary>
    [JsonPropertyName("entity")]
    public string Entity { get; set; }

    /// <summary>The access permission for the entity. Possible values: ["OWNER", "READER", "WRITER"].</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageBucketAccessControlStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageBucketAccessControlStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageBucketAccessControlStatusConditions>? Conditions { get; set; }

    /// <summary>The domain associated with the entity.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The email address associated with the entity.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageBucketAccessControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageBucketAccessControlSpec>, IStatus<V1beta1StorageBucketAccessControlStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageBucketAccessControl";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagebucketaccesscontrols";
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
    public V1beta1StorageBucketAccessControlSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1StorageBucketAccessControlStatus? Status { get; set; }
}