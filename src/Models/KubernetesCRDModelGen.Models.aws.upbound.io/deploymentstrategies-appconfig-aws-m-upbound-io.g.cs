using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appconfig.aws.m.upbound.io;
/// <summary>DeploymentStrategy is the Schema for the DeploymentStrategys API. Provides an AppConfig Deployment Strategy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeploymentStrategyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DeploymentStrategy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeploymentStrategyList";
    public const string KubeGroup = "appconfig.aws.m.upbound.io";
    public const string KubePluralName = "deploymentstrategies";
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
    public IList<V1beta1DeploymentStrategy> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategySpecForProvider
{
    /// <summary>Total amount of time for a deployment to last. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("deploymentDurationInMinutes")]
    public double? DeploymentDurationInMinutes { get; set; }

    /// <summary>Description of the deployment strategy. Can be at most 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time AWS AppConfig monitors for alarms before considering the deployment to be complete and no longer eligible for automatic roll back. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("finalBakeTimeInMinutes")]
    public double? FinalBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of targets to receive a deployed configuration during each interval. Minimum value of 1.0, maximum value of 100.0.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Algorithm used to define how percentage grows over time. Valid value: LINEAR and EXPONENTIAL. Defaults to LINEAR.</summary>
    [JsonPropertyName("growthType")]
    public string? GrowthType { get; set; }

    /// <summary>Name for the deployment strategy. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Where to save the deployment strategy. Valid values: NONE and SSM_DOCUMENT.</summary>
    [JsonPropertyName("replicateTo")]
    public string? ReplicateTo { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategySpecInitProvider
{
    /// <summary>Total amount of time for a deployment to last. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("deploymentDurationInMinutes")]
    public double? DeploymentDurationInMinutes { get; set; }

    /// <summary>Description of the deployment strategy. Can be at most 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time AWS AppConfig monitors for alarms before considering the deployment to be complete and no longer eligible for automatic roll back. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("finalBakeTimeInMinutes")]
    public double? FinalBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of targets to receive a deployed configuration during each interval. Minimum value of 1.0, maximum value of 100.0.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Algorithm used to define how percentage grows over time. Valid value: LINEAR and EXPONENTIAL. Defaults to LINEAR.</summary>
    [JsonPropertyName("growthType")]
    public string? GrowthType { get; set; }

    /// <summary>Name for the deployment strategy. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Where to save the deployment strategy. Valid values: NONE and SSM_DOCUMENT.</summary>
    [JsonPropertyName("replicateTo")]
    public string? ReplicateTo { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategySpecProviderConfigRef
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
public partial class V1beta1DeploymentStrategySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DeploymentStrategySpec defines the desired state of DeploymentStrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DeploymentStrategySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DeploymentStrategySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DeploymentStrategySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DeploymentStrategySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategyStatusAtProvider
{
    /// <summary>ARN of the AppConfig Deployment Strategy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Total amount of time for a deployment to last. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("deploymentDurationInMinutes")]
    public double? DeploymentDurationInMinutes { get; set; }

    /// <summary>Description of the deployment strategy. Can be at most 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time AWS AppConfig monitors for alarms before considering the deployment to be complete and no longer eligible for automatic roll back. Minimum value of 0, maximum value of 1440.</summary>
    [JsonPropertyName("finalBakeTimeInMinutes")]
    public double? FinalBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of targets to receive a deployed configuration during each interval. Minimum value of 1.0, maximum value of 100.0.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Algorithm used to define how percentage grows over time. Valid value: LINEAR and EXPONENTIAL. Defaults to LINEAR.</summary>
    [JsonPropertyName("growthType")]
    public string? GrowthType { get; set; }

    /// <summary>AppConfig deployment strategy ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name for the deployment strategy. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Where to save the deployment strategy. Valid values: NONE and SSM_DOCUMENT.</summary>
    [JsonPropertyName("replicateTo")]
    public string? ReplicateTo { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategyStatusConditions
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

/// <summary>DeploymentStrategyStatus defines the observed state of DeploymentStrategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentStrategyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DeploymentStrategyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeploymentStrategyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeploymentStrategy is the Schema for the DeploymentStrategys API. Provides an AppConfig Deployment Strategy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeploymentStrategy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DeploymentStrategySpec>, IStatus<V1beta1DeploymentStrategyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeploymentStrategy";
    public const string KubeGroup = "appconfig.aws.m.upbound.io";
    public const string KubePluralName = "deploymentstrategies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeploymentStrategySpec defines the desired state of DeploymentStrategy</summary>
    [JsonPropertyName("spec")]
    public V1beta1DeploymentStrategySpec Spec { get; set; }

    /// <summary>DeploymentStrategyStatus defines the observed state of DeploymentStrategy.</summary>
    [JsonPropertyName("status")]
    public V1beta1DeploymentStrategyStatus? Status { get; set; }
}