using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deploy.aws.m.upbound.io;
/// <summary>DeploymentGroup is the Schema for the DeploymentGroups API. Provides a CodeDeploy deployment group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeploymentGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DeploymentGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeploymentGroupList";
    public const string KubeGroup = "deploy.aws.m.upbound.io";
    public const string KubePluralName = "deploymentgroups";
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
    public IList<V1beta1DeploymentGroup> Items { get; set; }
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAppNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a App in deploy to populate appName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAppNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderAppNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAppNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a App in deploy to populate appName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAppNameSelector
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
    public V1beta1DeploymentGroupSpecForProviderAppNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupSpecForProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameSelector
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
    public V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameSelector
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
    public V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceClusterNameSelector? ClusterNameSelector { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Reference to a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameRef")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameRef? ServiceNameRef { get; set; }

    /// <summary>Selector for a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameSelector")]
    public V1beta1DeploymentGroupSpecForProviderEcsServiceServiceNameSelector? ServiceNameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelector
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
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRef? NameRef { get; set; }

    /// <summary>Selector for a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector
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
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }

    /// <summary>References to LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsRefs")]
    public IList<V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs>? ListenerArnsRefs { get; set; }

    /// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsSelector")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector? ListenerArnsSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector
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
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef? NameRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderServiceRoleArnSelector
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
    public V1beta1DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelector
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
    public V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnRef")]
    public V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRef? TriggerTargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnSelector")]
    public V1beta1DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelector? TriggerTargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecForProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta1DeploymentGroupSpecForProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("appName")]
    public string? AppName { get; set; }

    /// <summary>Reference to a App in deploy to populate appName.</summary>
    [JsonPropertyName("appNameRef")]
    public V1beta1DeploymentGroupSpecForProviderAppNameRef? AppNameRef { get; set; }

    /// <summary>Selector for a App in deploy to populate appName.</summary>
    [JsonPropertyName("appNameSelector")]
    public V1beta1DeploymentGroupSpecForProviderAppNameSelector? AppNameSelector { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta1DeploymentGroupSpecForProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta1DeploymentGroupSpecForProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta1DeploymentGroupSpecForProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupSpecForProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta1DeploymentGroupSpecForProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta1DeploymentGroupSpecForProviderEcsService? EcsService { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta1DeploymentGroupSpecForProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta1DeploymentGroupSpecForProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1DeploymentGroupSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1DeploymentGroupSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta1DeploymentGroupSpecForProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupSpecInitProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameSelector
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
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameSelector
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
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceClusterNameSelector? ClusterNameSelector { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Reference to a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameRef")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameRef? ServiceNameRef { get; set; }

    /// <summary>Selector for a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameSelector")]
    public V1beta1DeploymentGroupSpecInitProviderEcsServiceServiceNameSelector? ServiceNameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelector
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
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRef? NameRef { get; set; }

    /// <summary>Selector for a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector
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
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }

    /// <summary>References to LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsRefs")]
    public IList<V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs>? ListenerArnsRefs { get; set; }

    /// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsSelector")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector? ListenerArnsSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector
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
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef? NameRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderServiceRoleArnSelector
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
    public V1beta1DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelector
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
    public V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnRef")]
    public V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRef? TriggerTargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnSelector")]
    public V1beta1DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelector? TriggerTargetArnSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecInitProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta1DeploymentGroupSpecInitProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta1DeploymentGroupSpecInitProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta1DeploymentGroupSpecInitProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta1DeploymentGroupSpecInitProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupSpecInitProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta1DeploymentGroupSpecInitProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta1DeploymentGroupSpecInitProviderEcsService? EcsService { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta1DeploymentGroupSpecInitProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta1DeploymentGroupSpecInitProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1DeploymentGroupSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1DeploymentGroupSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta1DeploymentGroupSpecInitProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpecProviderConfigRef
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
public partial class V1beta1DeploymentGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DeploymentGroupSpec defines the desired state of DeploymentGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DeploymentGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DeploymentGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DeploymentGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DeploymentGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupStatusAtProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusAtProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta1DeploymentGroupStatusAtProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("appName")]
    public string? AppName { get; set; }

    /// <summary>The ARN of the CodeDeploy deployment group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta1DeploymentGroupStatusAtProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta1DeploymentGroupStatusAtProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The destination platform type for the deployment.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>The ID of the CodeDeploy deployment group.</summary>
    [JsonPropertyName("deploymentGroupId")]
    public string? DeploymentGroupId { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta1DeploymentGroupStatusAtProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta1DeploymentGroupStatusAtProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta1DeploymentGroupStatusAtProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta1DeploymentGroupStatusAtProviderEcsService? EcsService { get; set; }

    /// <summary>Application name and deployment group name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta1DeploymentGroupStatusAtProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta1DeploymentGroupStatusAtProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta1DeploymentGroupStatusAtProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatusConditions
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

/// <summary>DeploymentGroupStatus defines the observed state of DeploymentGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeploymentGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DeploymentGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeploymentGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeploymentGroup is the Schema for the DeploymentGroups API. Provides a CodeDeploy deployment group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeploymentGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DeploymentGroupSpec>, IStatus<V1beta1DeploymentGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeploymentGroup";
    public const string KubeGroup = "deploy.aws.m.upbound.io";
    public const string KubePluralName = "deploymentgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeploymentGroupSpec defines the desired state of DeploymentGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1DeploymentGroupSpec Spec { get; set; }

    /// <summary>DeploymentGroupStatus defines the observed state of DeploymentGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1DeploymentGroupStatus? Status { get; set; }
}