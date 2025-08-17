using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.aws.upbound.io;
#nullable enable
/// <summary>Stage is the Schema for the Stages API. Manages an Amazon API Gateway Version 2 stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Stage>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StageList";
    public const string KubeGroup = "apigatewayv2.aws.upbound.io";
    public const string KubePluralName = "stages";
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
    public IList<V1beta1Stage> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderAccessLogSettings
{
    /// <summary>ARN of the CloudWatch Logs log group to receive access logs. Any trailing :* is trimmed from the ARN.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>Single line format of the access logs of data. Refer to log settings for HTTP or Websocket.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderApiIdRefPolicy
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
/// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecForProviderApiIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderApiIdSelectorPolicy
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
/// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderDefaultRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the default route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Throttling burst limit for the default route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the default route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderDeploymentIdRefPolicy
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
/// <summary>Reference to a Deployment in apigatewayv2 to populate deploymentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderDeploymentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecForProviderDeploymentIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderDeploymentIdSelectorPolicy
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
/// <summary>Selector for a Deployment in apigatewayv2 to populate deploymentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderDeploymentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecForProviderDeploymentIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProviderRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Route key.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>Throttling burst limit for the route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecForProvider
{
    /// <summary>Settings for logging access in this stage. Use the aws_api_gateway_account resource to configure permissions for CloudWatch Logging.</summary>
    [JsonPropertyName("accessLogSettings")]
    public IList<V1beta1StageSpecForProviderAccessLogSettings>? AccessLogSettings { get; set; }

    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1StageSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1StageSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Whether updates to an API automatically trigger a new deployment. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("autoDeploy")]
    public bool? AutoDeploy { get; set; }

    /// <summary>Identifier of a client certificate for the stage. Use the aws_api_gateway_client_certificate resource to configure a client certificate. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>Default route settings for the stage.</summary>
    [JsonPropertyName("defaultRouteSettings")]
    public IList<V1beta1StageSpecForProviderDefaultRouteSettings>? DefaultRouteSettings { get; set; }

    /// <summary>Deployment identifier of the stage. Use the aws_apigatewayv2_deployment resource to configure a deployment.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    /// <summary>Reference to a Deployment in apigatewayv2 to populate deploymentId.</summary>
    [JsonPropertyName("deploymentIdRef")]
    public V1beta1StageSpecForProviderDeploymentIdRef? DeploymentIdRef { get; set; }

    /// <summary>Selector for a Deployment in apigatewayv2 to populate deploymentId.</summary>
    [JsonPropertyName("deploymentIdSelector")]
    public V1beta1StageSpecForProviderDeploymentIdSelector? DeploymentIdSelector { get; set; }

    /// <summary>Description for the stage. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Route settings for the stage.</summary>
    [JsonPropertyName("routeSettings")]
    public IList<V1beta1StageSpecForProviderRouteSettings>? RouteSettings { get; set; }

    /// <summary>Map that defines the stage variables for the stage.</summary>
    [JsonPropertyName("stageVariables")]
    public IDictionary<string, string>? StageVariables { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderAccessLogSettings
{
    /// <summary>ARN of the CloudWatch Logs log group to receive access logs. Any trailing :* is trimmed from the ARN.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>Single line format of the access logs of data. Refer to log settings for HTTP or Websocket.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderApiIdRefPolicy
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
/// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecInitProviderApiIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderApiIdSelectorPolicy
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
/// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecInitProviderApiIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderDefaultRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the default route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Throttling burst limit for the default route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the default route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderDeploymentIdRefPolicy
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
/// <summary>Reference to a Deployment in apigatewayv2 to populate deploymentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderDeploymentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecInitProviderDeploymentIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderDeploymentIdSelectorPolicy
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
/// <summary>Selector for a Deployment in apigatewayv2 to populate deploymentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderDeploymentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecInitProviderDeploymentIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProviderRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Route key.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>Throttling burst limit for the route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecInitProvider
{
    /// <summary>Settings for logging access in this stage. Use the aws_api_gateway_account resource to configure permissions for CloudWatch Logging.</summary>
    [JsonPropertyName("accessLogSettings")]
    public IList<V1beta1StageSpecInitProviderAccessLogSettings>? AccessLogSettings { get; set; }

    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1StageSpecInitProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1StageSpecInitProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Whether updates to an API automatically trigger a new deployment. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("autoDeploy")]
    public bool? AutoDeploy { get; set; }

    /// <summary>Identifier of a client certificate for the stage. Use the aws_api_gateway_client_certificate resource to configure a client certificate. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>Default route settings for the stage.</summary>
    [JsonPropertyName("defaultRouteSettings")]
    public IList<V1beta1StageSpecInitProviderDefaultRouteSettings>? DefaultRouteSettings { get; set; }

    /// <summary>Deployment identifier of the stage. Use the aws_apigatewayv2_deployment resource to configure a deployment.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    /// <summary>Reference to a Deployment in apigatewayv2 to populate deploymentId.</summary>
    [JsonPropertyName("deploymentIdRef")]
    public V1beta1StageSpecInitProviderDeploymentIdRef? DeploymentIdRef { get; set; }

    /// <summary>Selector for a Deployment in apigatewayv2 to populate deploymentId.</summary>
    [JsonPropertyName("deploymentIdSelector")]
    public V1beta1StageSpecInitProviderDeploymentIdSelector? DeploymentIdSelector { get; set; }

    /// <summary>Description for the stage. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Route settings for the stage.</summary>
    [JsonPropertyName("routeSettings")]
    public IList<V1beta1StageSpecInitProviderRouteSettings>? RouteSettings { get; set; }

    /// <summary>Map that defines the stage variables for the stage.</summary>
    [JsonPropertyName("stageVariables")]
    public IDictionary<string, string>? StageVariables { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StageSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>StageSpec defines the desired state of Stage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageStatusAtProviderAccessLogSettings
{
    /// <summary>ARN of the CloudWatch Logs log group to receive access logs. Any trailing :* is trimmed from the ARN.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>Single line format of the access logs of data. Refer to log settings for HTTP or Websocket.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageStatusAtProviderDefaultRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the default route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the default route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Throttling burst limit for the default route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the default route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageStatusAtProviderRouteSettings
{
    /// <summary>Whether data trace logging is enabled for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Defaults to false. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Whether detailed metrics are enabled for the route. Defaults to false.</summary>
    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>Logging level for the route. Affects the log entries pushed to Amazon CloudWatch Logs. Valid values: ERROR, INFO, OFF. Defaults to OFF. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Route key.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>Throttling burst limit for the route.</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit for the route.</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageStatusAtProvider
{
    /// <summary>Settings for logging access in this stage. Use the aws_api_gateway_account resource to configure permissions for CloudWatch Logging.</summary>
    [JsonPropertyName("accessLogSettings")]
    public IList<V1beta1StageStatusAtProviderAccessLogSettings>? AccessLogSettings { get; set; }

    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ARN of the stage.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether updates to an API automatically trigger a new deployment. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("autoDeploy")]
    public bool? AutoDeploy { get; set; }

    /// <summary>Identifier of a client certificate for the stage. Use the aws_api_gateway_client_certificate resource to configure a client certificate. Supported only for WebSocket APIs.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>Default route settings for the stage.</summary>
    [JsonPropertyName("defaultRouteSettings")]
    public IList<V1beta1StageStatusAtProviderDefaultRouteSettings>? DefaultRouteSettings { get; set; }

    /// <summary>Deployment identifier of the stage. Use the aws_apigatewayv2_deployment resource to configure a deployment.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    /// <summary>Description for the stage. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN prefix to be used in an aws_lambda_permission's source_arn attribute. For WebSocket APIs this attribute can additionally be used in an aws_iam_policy to authorize access to the @connections API. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("executionArn")]
    public string? ExecutionArn { get; set; }

    /// <summary>Stage identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>URL to invoke the API pointing to the stage, e.g., wss://z4675bid1j.execute-api.eu-west-2.amazonaws.com/example-stage, or https://z4675bid1j.execute-api.eu-west-2.amazonaws.com/</summary>
    [JsonPropertyName("invokeUrl")]
    public string? InvokeUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Route settings for the stage.</summary>
    [JsonPropertyName("routeSettings")]
    public IList<V1beta1StageStatusAtProviderRouteSettings>? RouteSettings { get; set; }

    /// <summary>Map that defines the stage variables for the stage.</summary>
    [JsonPropertyName("stageVariables")]
    public IDictionary<string, string>? StageVariables { get; set; }

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
public partial class V1beta1StageStatusConditions
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
/// <summary>StageStatus defines the observed state of Stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Stage is the Schema for the Stages API. Manages an Amazon API Gateway Version 2 stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Stage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StageSpec>, IStatus<V1beta1StageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Stage";
    public const string KubeGroup = "apigatewayv2.aws.upbound.io";
    public const string KubePluralName = "stages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StageSpec defines the desired state of Stage</summary>
    [JsonPropertyName("spec")]
    public V1beta1StageSpec Spec { get; set; }

    /// <summary>StageStatus defines the observed state of Stage.</summary>
    [JsonPropertyName("status")]
    public V1beta1StageStatus? Status { get; set; }
}
#nullable disable
