using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.m.upbound.io;
#nullable enable
/// <summary>CapacityProvider is the Schema for the CapacityProviders API. Provides an ECS cluster capacity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CapacityProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityProviderList";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "capacityproviders";
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
    public IList<V1beta1CapacityProvider> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnRef")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRef? AutoScalingGroupArnRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnSelector")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelector? AutoScalingGroupArnSelector { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProvider
{
    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnRef")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRef? AutoScalingGroupArnRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnSelector")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelector? AutoScalingGroupArnSelector { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProvider
{
    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecProviderConfigRef
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
public partial class V1beta1CapacityProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CapacityProviderSpec defines the desired state of CapacityProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CapacityProviderSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CapacityProviderSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CapacityProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CapacityProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProvider
{
    /// <summary>ARN that identifies the capacity provider.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusConditions
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
/// <summary>CapacityProviderStatus defines the observed state of CapacityProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CapacityProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CapacityProviderStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CapacityProvider is the Schema for the CapacityProviders API. Provides an ECS cluster capacity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CapacityProviderSpec>, IStatus<V1beta1CapacityProviderStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityProvider";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "capacityproviders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CapacityProviderSpec defines the desired state of CapacityProvider</summary>
    [JsonPropertyName("spec")]
    public V1beta1CapacityProviderSpec Spec { get; set; }

    /// <summary>CapacityProviderStatus defines the observed state of CapacityProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1CapacityProviderStatus? Status { get; set; }
}
#nullable disable
