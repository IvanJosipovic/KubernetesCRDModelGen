using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vpc.aws.m.upbound.io;
#nullable enable
/// <summary>NetworkPerformanceMetricSubscription is the Schema for the NetworkPerformanceMetricSubscriptions API. Provides a resource to manage an Infrastructure Performance subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkPerformanceMetricSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkPerformanceMetricSubscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkPerformanceMetricSubscriptionList";
    public const string KubeGroup = "vpc.aws.m.upbound.io";
    public const string KubePluralName = "networkperformancemetricsubscriptions";
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
    public IList<V1beta1NetworkPerformanceMetricSubscription> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionSpecForProvider
{
    /// <summary>The target Region or Availability Zone that the metric subscription is enabled for. For example, eu-west-1.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The metric used for the enabled subscription. Valid values: aggregate-latency. Default: aggregate-latency.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The source Region or Availability Zone that the metric subscription is enabled for. For example, us-east-1.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The statistic used for the enabled subscription. Valid values: p50. Default: p50.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionSpecInitProvider
{
    /// <summary>The target Region or Availability Zone that the metric subscription is enabled for. For example, eu-west-1.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The metric used for the enabled subscription. Valid values: aggregate-latency. Default: aggregate-latency.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The source Region or Availability Zone that the metric subscription is enabled for. For example, us-east-1.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The statistic used for the enabled subscription. Valid values: p50. Default: p50.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NetworkPerformanceMetricSubscriptionSpec defines the desired state of NetworkPerformanceMetricSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NetworkPerformanceMetricSubscriptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NetworkPerformanceMetricSubscriptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkPerformanceMetricSubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkPerformanceMetricSubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionStatusAtProvider
{
    /// <summary>The target Region or Availability Zone that the metric subscription is enabled for. For example, eu-west-1.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The metric used for the enabled subscription. Valid values: aggregate-latency. Default: aggregate-latency.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The data aggregation time for the subscription.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The source Region or Availability Zone that the metric subscription is enabled for. For example, us-east-1.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The statistic used for the enabled subscription. Valid values: p50. Default: p50.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionStatusConditions
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
#nullable disable

#nullable enable
/// <summary>NetworkPerformanceMetricSubscriptionStatus defines the observed state of NetworkPerformanceMetricSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkPerformanceMetricSubscriptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkPerformanceMetricSubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkPerformanceMetricSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NetworkPerformanceMetricSubscription is the Schema for the NetworkPerformanceMetricSubscriptions API. Provides a resource to manage an Infrastructure Performance subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkPerformanceMetricSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkPerformanceMetricSubscriptionSpec>, IStatus<V1beta1NetworkPerformanceMetricSubscriptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkPerformanceMetricSubscription";
    public const string KubeGroup = "vpc.aws.m.upbound.io";
    public const string KubePluralName = "networkperformancemetricsubscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkPerformanceMetricSubscriptionSpec defines the desired state of NetworkPerformanceMetricSubscription</summary>
    [JsonPropertyName("spec")]
    public V1beta1NetworkPerformanceMetricSubscriptionSpec Spec { get; set; }

    /// <summary>NetworkPerformanceMetricSubscriptionStatus defines the observed state of NetworkPerformanceMetricSubscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkPerformanceMetricSubscriptionStatus? Status { get; set; }
}
#nullable disable
