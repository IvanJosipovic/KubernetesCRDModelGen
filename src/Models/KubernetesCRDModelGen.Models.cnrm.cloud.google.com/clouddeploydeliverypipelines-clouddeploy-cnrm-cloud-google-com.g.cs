using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
#nullable enable
/// <summary>CloudDeployDeliveryPipeline is the Schema for the CloudDeployDeliveryPipeline API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployDeliveryPipelineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDeployDeliveryPipeline>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployDeliveryPipelineList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploydeliverypipelines";
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
    public IList<V1alpha1CloudDeployDeliveryPipeline> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesDeployParameters
{
    /// <summary>Optional. Deploy parameters are applied to targets with match labels. If unspecified, deploy parameters are applied to all targets (including child targets of a multi-target).</summary>
    [JsonPropertyName("matchTargetLabels")]
    public IDictionary<string, string>? MatchTargetLabels { get; set; }

    /// <summary>Required. Values are deploy parameters in key-value pairs.</summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the postdeploy job of the last phase. If this is not configured, there will be no postdeploy job for this phase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeploymentPostdeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the postdeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the predeploy job of the first phase. If this is not configured, there will be no predeploy job for this phase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeploymentPredeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the predeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configures the progressive based deployment for a Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeployment
{
    /// <summary>Required. The percentage based deployments that will occur as a part of a `Rollout`. List is expected in ascending order and each integer n is 0 &lt;= n &lt; 100. If the GatewayServiceMesh is configured for Kubernetes, then the range for n is 0 &lt;= n &lt;= 100.</summary>
    [JsonPropertyName("percentages")]
    public IList<int>? Percentages { get; set; }

    /// <summary>Optional. Configuration for the postdeploy job of the last phase. If this is not configured, there will be no postdeploy job for this phase.</summary>
    [JsonPropertyName("postdeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeploymentPostdeploy? Postdeploy { get; set; }

    /// <summary>Optional. Configuration for the predeploy job of the first phase. If this is not configured, there will be no predeploy job for this phase.</summary>
    [JsonPropertyName("predeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeploymentPredeploy? Predeploy { get; set; }

    /// <summary>Whether to run verify tests after each percentage deployment.</summary>
    [JsonPropertyName("verify")]
    public bool? Verify { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the postdeploy job of this phase. If this is not configured, there will be no postdeploy job for this phase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigsPostdeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the postdeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the predeploy job of this phase. If this is not configured, there will be no predeploy job for this phase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigsPredeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the predeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigs
{
    /// <summary>Required. Percentage deployment for the phase.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    /// <summary>Required. The ID to assign to the `Rollout` phase. This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters. In other words, it must match the following regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.</summary>
    [JsonPropertyName("phaseID")]
    public string? PhaseID { get; set; }

    /// <summary>Optional. Configuration for the postdeploy job of this phase. If this is not configured, there will be no postdeploy job for this phase.</summary>
    [JsonPropertyName("postdeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigsPostdeploy? Postdeploy { get; set; }

    /// <summary>Optional. Configuration for the predeploy job of this phase. If this is not configured, there will be no predeploy job for this phase.</summary>
    [JsonPropertyName("predeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigsPredeploy? Predeploy { get; set; }

    /// <summary>Skaffold profiles to use when rendering the manifest for this phase. These are in addition to the profiles list specified in the `DeliveryPipeline` stage.</summary>
    [JsonPropertyName("profiles")]
    public IList<string>? Profiles { get; set; }

    /// <summary>Whether to run verify tests after the deployment.</summary>
    [JsonPropertyName("verify")]
    public bool? Verify { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configures the progressive based deployment for a Target, but allows customizing at the phase level where a phase represents each of the percentage deployments.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeployment
{
    /// <summary>Required. Configuration for each phase in the canary deployment in the order executed.</summary>
    [JsonPropertyName("phaseConfigs")]
    public IList<V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeploymentPhaseConfigs>? PhaseConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cloud Run runtime configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigCloudRun
{
    /// <summary>Whether Cloud Deploy should update the traffic stanza in a Cloud Run Service on the user's behalf to facilitate traffic splitting. This is required to be true for CanaryDeployments, but optional for CustomCanaryDeployments.</summary>
    [JsonPropertyName("automaticTrafficControl")]
    public bool? AutomaticTrafficControl { get; set; }

    /// <summary>Optional. A list of tags that are added to the canary revision while the canary phase is in progress.</summary>
    [JsonPropertyName("canaryRevisionTags")]
    public IList<string>? CanaryRevisionTags { get; set; }

    /// <summary>Optional. A list of tags that are added to the prior revision while the canary phase is in progress.</summary>
    [JsonPropertyName("priorRevisionTags")]
    public IList<string>? PriorRevisionTags { get; set; }

    /// <summary>Optional. A list of tags that are added to the final stable revision when the stable phase is applied.</summary>
    [JsonPropertyName("stableRevisionTags")]
    public IList<string>? StableRevisionTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Route destinations allow configuring the Gateway API HTTPRoute to be deployed to additional clusters. This option is available for multi-cluster service mesh set ups that require the route to exist in the clusters that call the service. If unspecified, the HTTPRoute will only be deployed to the Target cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesGatewayServiceMeshRouteDestinations
{
    /// <summary>Required. The clusters where the Gateway API HTTPRoute resource will be deployed to. Valid entries include the associated entities IDs configured in the Target resource and "@self" to include the Target cluster.</summary>
    [JsonPropertyName("destinationIDs")]
    public IList<string>? DestinationIDs { get; set; }

    /// <summary>Optional. Whether to propagate the Kubernetes Service to the route destination clusters. The Service will always be deployed to the Target cluster even if the HTTPRoute is not. This option may be used to facilitate successful DNS lookup in the route destination clusters. Can only be set to true if destinations are specified.</summary>
    [JsonPropertyName("propagateService")]
    public bool? PropagateService { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubernetes Gateway API service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesGatewayServiceMesh
{
    /// <summary>Required. Name of the Kubernetes Deployment whose traffic is managed by the specified HTTPRoute and Service.</summary>
    [JsonPropertyName("deployment")]
    public string? Deployment { get; set; }

    /// <summary>Required. Name of the Gateway API HTTPRoute.</summary>
    [JsonPropertyName("httpRoute")]
    public string? HttpRoute { get; set; }

    /// <summary>Optional. The label to use when selecting Pods for the Deployment and Service resources. This label must already be present in both resources.</summary>
    [JsonPropertyName("podSelectorLabel")]
    public string? PodSelectorLabel { get; set; }

    /// <summary>Optional. Route destinations allow configuring the Gateway API HTTPRoute to be deployed to additional clusters. This option is available for multi-cluster service mesh set ups that require the route to exist in the clusters that call the service. If unspecified, the HTTPRoute will only be deployed to the Target cluster.</summary>
    [JsonPropertyName("routeDestinations")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesGatewayServiceMeshRouteDestinations? RouteDestinations { get; set; }

    /// <summary>Optional. The time to wait for route updates to propagate. The maximum configurable time is 3 hours, in seconds format. If unspecified, there is no wait time.</summary>
    [JsonPropertyName("routeUpdateWaitTime")]
    public string? RouteUpdateWaitTime { get; set; }

    /// <summary>Required. Name of the Kubernetes Service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Optional. The amount of time to migrate traffic back from the canary Service to the original Service during the stable phase deployment. If specified, must be between 15s and 3600s. If unspecified, there is no cutback time.</summary>
    [JsonPropertyName("stableCutbackDuration")]
    public string? StableCutbackDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubernetes Service networking configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesServiceNetworking
{
    /// <summary>Required. Name of the Kubernetes Deployment whose traffic is managed by the specified Service.</summary>
    [JsonPropertyName("deployment")]
    public string? Deployment { get; set; }

    /// <summary>Optional. Whether to disable Pod overprovisioning. If Pod overprovisioning is disabled then Cloud Deploy will limit the number of total Pods used for the deployment strategy to the number of Pods the Deployment has on the cluster.</summary>
    [JsonPropertyName("disablePodOverprovisioning")]
    public bool? DisablePodOverprovisioning { get; set; }

    /// <summary>Optional. The label to use when selecting Pods for the Deployment resource. This label must already be present in the Deployment.</summary>
    [JsonPropertyName("podSelectorLabel")]
    public string? PodSelectorLabel { get; set; }

    /// <summary>Required. Name of the Kubernetes Service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubernetes runtime configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetes
{
    /// <summary>Kubernetes Gateway API service mesh configuration.</summary>
    [JsonPropertyName("gatewayServiceMesh")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesGatewayServiceMesh? GatewayServiceMesh { get; set; }

    /// <summary>Kubernetes Service networking configuration.</summary>
    [JsonPropertyName("serviceNetworking")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetesServiceNetworking? ServiceNetworking { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Runtime specific configurations for the deployment strategy. The runtime configuration is used to determine how Cloud Deploy will split traffic to enable a progressive deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfig
{
    /// <summary>Cloud Run runtime configuration.</summary>
    [JsonPropertyName("cloudRun")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigCloudRun? CloudRun { get; set; }

    /// <summary>Kubernetes runtime configuration.</summary>
    [JsonPropertyName("kubernetes")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfigKubernetes? Kubernetes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Canary deployment strategy provides progressive percentage based deployments to a Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanary
{
    /// <summary>Configures the progressive based deployment for a Target.</summary>
    [JsonPropertyName("canaryDeployment")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCanaryDeployment? CanaryDeployment { get; set; }

    /// <summary>Configures the progressive based deployment for a Target, but allows customizing at the phase level where a phase represents each of the percentage deployments.</summary>
    [JsonPropertyName("customCanaryDeployment")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryCustomCanaryDeployment? CustomCanaryDeployment { get; set; }

    /// <summary>Optional. Runtime specific configurations for the deployment strategy. The runtime configuration is used to determine how Cloud Deploy will split traffic to enable a progressive deployment.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanaryRuntimeConfig? RuntimeConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the postdeploy job. If this is not configured, postdeploy job will not be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandardPostdeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the postdeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the predeploy job. If this is not configured, predeploy job will not be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandardPredeploy
{
    /// <summary>Optional. A sequence of Skaffold custom actions to invoke during execution of the predeploy job.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Standard deployment strategy executes a single deploy and allows verifying the deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandard
{
    /// <summary>Optional. Configuration for the postdeploy job. If this is not configured, postdeploy job will not be present.</summary>
    [JsonPropertyName("postdeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandardPostdeploy? Postdeploy { get; set; }

    /// <summary>Optional. Configuration for the predeploy job. If this is not configured, predeploy job will not be present.</summary>
    [JsonPropertyName("predeploy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandardPredeploy? Predeploy { get; set; }

    /// <summary>Whether to verify a deployment.</summary>
    [JsonPropertyName("verify")]
    public bool? Verify { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The strategy to use for a `Rollout` to this stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategy
{
    /// <summary>Canary deployment strategy provides progressive percentage based deployments to a Target.</summary>
    [JsonPropertyName("canary")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyCanary? Canary { get; set; }

    /// <summary>Standard deployment strategy executes a single deploy and allows verifying the deployment.</summary>
    [JsonPropertyName("standard")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategyStandard? Standard { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStages
{
    /// <summary>Optional. The deploy parameters to use for the target in this stage.</summary>
    [JsonPropertyName("deployParameters")]
    public IList<V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesDeployParameters>? DeployParameters { get; set; }

    /// <summary>Skaffold profiles to use when rendering the manifest for this stage's `Target`.</summary>
    [JsonPropertyName("profiles")]
    public IList<string>? Profiles { get; set; }

    /// <summary>Optional. The strategy to use for a `Rollout` to this stage.</summary>
    [JsonPropertyName("strategy")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStagesStrategy? Strategy { get; set; }

    /// <summary>The target_id to which this stage points. This field refers exclusively to the last segment of a target name. For example, this field would just be `my-target` (rather than `projects/project/locations/location/targets/my-target`). The location of the `Target` is inferred to be the same as the location of the `DeliveryPipeline` that contains this `Stage`.</summary>
    [JsonPropertyName("targetID")]
    public string? TargetID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SerialPipeline defines a sequential set of stages for a `DeliveryPipeline`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpecSerialPipeline
{
    /// <summary>Each stage specifies configuration for a `Target`. The ordering of this list defines the promotion flow.</summary>
    [JsonPropertyName("stages")]
    public IList<V1alpha1CloudDeployDeliveryPipelineSpecSerialPipelineStages>? Stages { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DeliveryPipelineSpec defines the desired state of DeployDeliveryPipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineSpec
{
    /// <summary>User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Description of the `DeliveryPipeline`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Immutable. The location where the DeliveryPipeline should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudDeployDeliveryPipelineSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>SerialPipeline defines a sequential set of stages for a `DeliveryPipeline`.</summary>
    [JsonPropertyName("serialPipeline")]
    public V1alpha1CloudDeployDeliveryPipelineSpecSerialPipeline? SerialPipeline { get; set; }

    /// <summary>When suspended, no new releases or rollouts can be created, but in-progress ones will complete.</summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Details around the Pipeline's overall status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionPipelineReadyCondition
{
    /// <summary>True if the Pipeline is in a valid state. Otherwise at least one condition in `PipelineCondition` is in an invalid state. Iterate over those conditions and see which condition(s) has status = false to find out what is wrong with the Pipeline.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details around targets enumerated in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionTargetsPresentCondition
{
    /// <summary>The list of Target names that do not exist. For example, `projects/{project_id}/locations/{location_name}/targets/{target_name}`.</summary>
    [JsonPropertyName("missingTargets")]
    public IList<string>? MissingTargets { get; set; }

    /// <summary>True if there aren't any missing Targets.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }

    /// <summary>Last time the condition was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Details on the whether the targets enumerated in the pipeline are of the same type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionTargetsTypeCondition
{
    /// <summary>Human readable error message.</summary>
    [JsonPropertyName("errorDetails")]
    public string? ErrorDetails { get; set; }

    /// <summary>True if the targets are all a comparable type. For example this is true if all targets are GKE clusters. This is false if some targets are Cloud Run targets and others are GKE clusters.</summary>
    [JsonPropertyName("status")]
    public bool? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Information around the state of the Delivery Pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusObservedStateCondition
{
    /// <summary>Details around the Pipeline's overall status.</summary>
    [JsonPropertyName("pipelineReadyCondition")]
    public V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionPipelineReadyCondition? PipelineReadyCondition { get; set; }

    /// <summary>Details around targets enumerated in the pipeline.</summary>
    [JsonPropertyName("targetsPresentCondition")]
    public V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionTargetsPresentCondition? TargetsPresentCondition { get; set; }

    /// <summary>Details on the whether the targets enumerated in the pipeline are of the same type.</summary>
    [JsonPropertyName("targetsTypeCondition")]
    public V1alpha1CloudDeployDeliveryPipelineStatusObservedStateConditionTargetsTypeCondition? TargetsTypeCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatusObservedState
{
    /// <summary>Output only. Information around the state of the Delivery Pipeline.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudDeployDeliveryPipelineStatusObservedStateCondition? Condition { get; set; }

    /// <summary>Output only. Time at which the pipeline was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Unique identifier of the `DeliveryPipeline`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Most recent time at which the pipeline was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DeliveryPipelineStatus defines the config connector machine state of DeployDeliveryPipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeliveryPipelineStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDeployDeliveryPipelineStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DeployDeliveryPipeline resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDeployDeliveryPipelineStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDeployDeliveryPipeline is the Schema for the CloudDeployDeliveryPipeline API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployDeliveryPipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDeployDeliveryPipelineSpec>, IStatus<V1alpha1CloudDeployDeliveryPipelineStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployDeliveryPipeline";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploydeliverypipelines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeliveryPipelineSpec defines the desired state of DeployDeliveryPipeline</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudDeployDeliveryPipelineSpec Spec { get; set; }

    /// <summary>DeliveryPipelineStatus defines the config connector machine state of DeployDeliveryPipeline</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDeployDeliveryPipelineStatus? Status { get; set; }
}
#nullable disable
