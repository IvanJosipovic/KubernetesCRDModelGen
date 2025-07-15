using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>ManagedResourceActivationPolicySpec specifies the desired activation state of ManagedResourceDefinitions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2alpha1ManagedResourceActivationPolicySpec
{
    /// <summary>Activations is an array of MRD names to activate. Supports wildcard prefixes (like `*.aws.crossplane.io`) but not full regular expressions.</summary>
    [JsonPropertyName("activate")]
    public IList<string> Activate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2alpha1ManagedResourceActivationPolicyStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ManagedResourceActivationPolicyStatus shows the observed state of the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2alpha1ManagedResourceActivationPolicyStatus
{
    /// <summary>Activated names the ManagedResourceDefinitions this policy has activated.</summary>
    [JsonPropertyName("activated")]
    public IList<string>? Activated { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V2alpha1ManagedResourceActivationPolicyStatusConditions>? Conditions { get; set; }
}

/// <summary>A ManagedResourceActivationPolicy defines the activation policy for ManagedResourceDefinitions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2alpha1ManagedResourceActivationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V2alpha1ManagedResourceActivationPolicySpec>, IStatus<V2alpha1ManagedResourceActivationPolicyStatus>
{
    public const string KubeApiVersion = "v2alpha1";
    public const string KubeKind = "ManagedResourceActivationPolicy";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "managedresourceactivationpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedResourceActivationPolicySpec specifies the desired activation state of ManagedResourceDefinitions.</summary>
    [JsonPropertyName("spec")]
    public V2alpha1ManagedResourceActivationPolicySpec? Spec { get; set; }

    /// <summary>ManagedResourceActivationPolicyStatus shows the observed state of the policy.</summary>
    [JsonPropertyName("status")]
    public V2alpha1ManagedResourceActivationPolicyStatus? Status { get; set; }
}

/// <summary>A ManagedResourceActivationPolicy defines the activation policy for ManagedResourceDefinitions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2alpha1ManagedResourceActivationPolicyList : IKubernetesObject<V1ListMeta>, IItems<V2alpha1ManagedResourceActivationPolicy>
{
    public const string KubeApiVersion = "v2alpha1";
    public const string KubeKind = "ManagedResourceActivationPolicyList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "managedresourceactivationpolicies";
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
    public IList<V2alpha1ManagedResourceActivationPolicy> Items { get; set; }
}