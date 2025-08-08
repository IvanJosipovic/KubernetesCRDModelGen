using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecForProviderFairSharePolicyShareDistribution
{
    /// <summary>A fair share identifier or fair share identifier prefix. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("shareIdentifier")]
    public string? ShareIdentifier { get; set; }

    /// <summary>The weight factor for the fair share identifier. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("weightFactor")]
    public double? WeightFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecForProviderFairSharePolicy
{
    /// <summary>A value used to reserve some of the available maximum vCPU for fair share identifiers that have not yet been used. For more information, see FairsharePolicy.</summary>
    [JsonPropertyName("computeReservation")]
    public double? ComputeReservation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareDecaySeconds")]
    public double? ShareDecaySeconds { get; set; }

    /// <summary>One or more share distribution blocks which define the weights for the fair share identifiers for the fair share policy. For more information, see FairsharePolicy. The share_distribution block is documented below.</summary>
    [JsonPropertyName("shareDistribution")]
    public IList<V1beta1SchedulingPolicySpecForProviderFairSharePolicyShareDistribution>? ShareDistribution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("fairSharePolicy")]
    public V1beta1SchedulingPolicySpecForProviderFairSharePolicy? FairSharePolicy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecInitProviderFairSharePolicyShareDistribution
{
    /// <summary>A fair share identifier or fair share identifier prefix. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("shareIdentifier")]
    public string? ShareIdentifier { get; set; }

    /// <summary>The weight factor for the fair share identifier. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("weightFactor")]
    public double? WeightFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecInitProviderFairSharePolicy
{
    /// <summary>A value used to reserve some of the available maximum vCPU for fair share identifiers that have not yet been used. For more information, see FairsharePolicy.</summary>
    [JsonPropertyName("computeReservation")]
    public double? ComputeReservation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareDecaySeconds")]
    public double? ShareDecaySeconds { get; set; }

    /// <summary>One or more share distribution blocks which define the weights for the fair share identifiers for the fair share policy. For more information, see FairsharePolicy. The share_distribution block is documented below.</summary>
    [JsonPropertyName("shareDistribution")]
    public IList<V1beta1SchedulingPolicySpecInitProviderFairSharePolicyShareDistribution>? ShareDistribution { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("fairSharePolicy")]
    public V1beta1SchedulingPolicySpecInitProviderFairSharePolicy? FairSharePolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SchedulingPolicySpec defines the desired state of SchedulingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SchedulingPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SchedulingPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SchedulingPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SchedulingPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicyStatusAtProviderFairSharePolicyShareDistribution
{
    /// <summary>A fair share identifier or fair share identifier prefix. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("shareIdentifier")]
    public string? ShareIdentifier { get; set; }

    /// <summary>The weight factor for the fair share identifier. For more information, see ShareAttributes.</summary>
    [JsonPropertyName("weightFactor")]
    public double? WeightFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicyStatusAtProviderFairSharePolicy
{
    /// <summary>A value used to reserve some of the available maximum vCPU for fair share identifiers that have not yet been used. For more information, see FairsharePolicy.</summary>
    [JsonPropertyName("computeReservation")]
    public double? ComputeReservation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareDecaySeconds")]
    public double? ShareDecaySeconds { get; set; }

    /// <summary>One or more share distribution blocks which define the weights for the fair share identifiers for the fair share policy. For more information, see FairsharePolicy. The share_distribution block is documented below.</summary>
    [JsonPropertyName("shareDistribution")]
    public IList<V1beta1SchedulingPolicyStatusAtProviderFairSharePolicyShareDistribution>? ShareDistribution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicyStatusAtProvider
{
    /// <summary>The Amazon Resource Name of the scheduling policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fairSharePolicy")]
    public V1beta1SchedulingPolicyStatusAtProviderFairSharePolicy? FairSharePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicyStatusConditions
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

/// <summary>SchedulingPolicyStatus defines the observed state of SchedulingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SchedulingPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SchedulingPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SchedulingPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SchedulingPolicy is the Schema for the SchedulingPolicys API. Provides a Batch Scheduling Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SchedulingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SchedulingPolicySpec>, IStatus<V1beta1SchedulingPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SchedulingPolicy";
    public const string KubeGroup = "batch.aws.m.upbound.io";
    public const string KubePluralName = "schedulingpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SchedulingPolicySpec defines the desired state of SchedulingPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1SchedulingPolicySpec Spec { get; set; }

    /// <summary>SchedulingPolicyStatus defines the observed state of SchedulingPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1SchedulingPolicyStatus? Status { get; set; }
}

/// <summary>SchedulingPolicy is the Schema for the SchedulingPolicys API. Provides a Batch Scheduling Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SchedulingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SchedulingPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SchedulingPolicyList";
    public const string KubeGroup = "batch.aws.m.upbound.io";
    public const string KubePluralName = "schedulingpolicies";
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
    public IList<V1beta1SchedulingPolicy> Items { get; set; }
}