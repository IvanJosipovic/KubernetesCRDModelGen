using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicequotas.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaSpecForProvider
{
    /// <summary>Code of the service quota to track. For example: L-F678F1CE. Available values can be found with the AWS CLI service-quotas list-service-quotas command.</summary>
    [JsonPropertyName("quotaCode")]
    public string? QuotaCode { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Code of the service to track. For example: vpc. Available values can be found with the AWS CLI service-quotas list-services command.</summary>
    [JsonPropertyName("serviceCode")]
    public string? ServiceCode { get; set; }

    /// <summary>Float specifying the desired value for the service quota. If the desired value is higher than the current value, a quota increase request is submitted. When a known request is submitted and pending, the value reflects the desired value of the pending request.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaSpecInitProvider
{
    /// <summary>Code of the service quota to track. For example: L-F678F1CE. Available values can be found with the AWS CLI service-quotas list-service-quotas command.</summary>
    [JsonPropertyName("quotaCode")]
    public string? QuotaCode { get; set; }

    /// <summary>Code of the service to track. For example: vpc. Available values can be found with the AWS CLI service-quotas list-services command.</summary>
    [JsonPropertyName("serviceCode")]
    public string? ServiceCode { get; set; }

    /// <summary>Float specifying the desired value for the service quota. If the desired value is higher than the current value, a quota increase request is submitted. When a known request is submitted and pending, the value reflects the desired value of the pending request.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaSpecProviderConfigRef
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
public partial class V1beta1ServiceQuotaSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServiceQuotaSpec defines the desired state of ServiceQuota</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceQuotaSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceQuotaSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceQuotaSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceQuotaSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaStatusAtProviderUsageMetricMetricDimensions
{
    /// <summary></summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaStatusAtProviderUsageMetric
{
    /// <summary>The metric dimensions.</summary>
    [JsonPropertyName("metricDimensions")]
    public IList<V1beta1ServiceQuotaStatusAtProviderUsageMetricMetricDimensions>? MetricDimensions { get; set; }

    /// <summary>The name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The metric statistic that AWS recommend you use when determining quota usage.</summary>
    [JsonPropertyName("metricStatisticRecommendation")]
    public string? MetricStatisticRecommendation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaStatusAtProvider
{
    /// <summary>Whether the service quota can be increased.</summary>
    [JsonPropertyName("adjustable")]
    public bool? Adjustable { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service quota.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Default value of the service quota.</summary>
    [JsonPropertyName("defaultValue")]
    public double? DefaultValue { get; set; }

    /// <summary>Service code and quota code, separated by a front slash (/)</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Code of the service quota to track. For example: L-F678F1CE. Available values can be found with the AWS CLI service-quotas list-service-quotas command.</summary>
    [JsonPropertyName("quotaCode")]
    public string? QuotaCode { get; set; }

    /// <summary>Name of the quota.</summary>
    [JsonPropertyName("quotaName")]
    public string? QuotaName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Service code and quota code, separated by a front slash (/)</summary>
    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestStatus")]
    public string? RequestStatus { get; set; }

    /// <summary>Code of the service to track. For example: vpc. Available values can be found with the AWS CLI service-quotas list-services command.</summary>
    [JsonPropertyName("serviceCode")]
    public string? ServiceCode { get; set; }

    /// <summary>Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Information about the measurement.</summary>
    [JsonPropertyName("usageMetric")]
    public IList<V1beta1ServiceQuotaStatusAtProviderUsageMetric>? UsageMetric { get; set; }

    /// <summary>Float specifying the desired value for the service quota. If the desired value is higher than the current value, a quota increase request is submitted. When a known request is submitted and pending, the value reflects the desired value of the pending request.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaStatusConditions
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

/// <summary>ServiceQuotaStatus defines the observed state of ServiceQuota.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceQuotaStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceQuotaStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceQuotaStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServiceQuota is the Schema for the ServiceQuotas API. Manages an individual Service Quota</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceQuota : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceQuotaSpec>, IStatus<V1beta1ServiceQuotaStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceQuota";
    public const string KubeGroup = "servicequotas.aws.m.upbound.io";
    public const string KubePluralName = "servicequotas";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceQuotaSpec defines the desired state of ServiceQuota</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceQuotaSpec Spec { get; set; }

    /// <summary>ServiceQuotaStatus defines the observed state of ServiceQuota.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceQuotaStatus? Status { get; set; }
}

/// <summary>ServiceQuota is the Schema for the ServiceQuotas API. Manages an individual Service Quota</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceQuotaList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServiceQuota>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceQuotaList";
    public const string KubeGroup = "servicequotas.aws.m.upbound.io";
    public const string KubePluralName = "servicequotas";
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
    public IList<V1beta1ServiceQuota> Items { get; set; }
}