using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aiplatform.cnrm.cloud.google.com;
/// <summary>Information about the base model of Genie models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecBaseModelSourceGenieSource
{
    /// <summary>Required. The public base model URI.</summary>
    [JsonPropertyName("baseModelURI")]
    public string? BaseModelURI { get; set; }
}

/// <summary>Source information of Model Garden models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecBaseModelSourceModelGardenSource
{
    /// <summary>Required. The model garden source model resource name.</summary>
    [JsonPropertyName("publicModelName")]
    public string? PublicModelName { get; set; }
}

/// <summary>Optional. User input field to specify the base model source. Currently it only supports specifying the Model Garden models and Genie models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecBaseModelSource
{
    /// <summary>Information about the base model of Genie models.</summary>
    [JsonPropertyName("genieSource")]
    public V1alpha1AIPlatformModelSpecBaseModelSourceGenieSource? GenieSource { get; set; }

    /// <summary>Source information of Model Garden models.</summary>
    [JsonPropertyName("modelGardenSource")]
    public V1alpha1AIPlatformModelSpecBaseModelSourceModelGardenSource? ModelGardenSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecEnv
{
    /// <summary>Required. Name of the environment variable. Must be a valid C identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. Variables that reference a $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecGrpcPorts
{
    /// <summary>The number of the port to expose on the pod's IP address. Must be a valid port number, between 1 and 65535 inclusive.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }
}

/// <summary>ExecAction probes the health of a container by executing a command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecHealthProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>Immutable. Specification for Kubernetes readiness probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecHealthProbe
{
    /// <summary>ExecAction probes the health of a container by executing a command.</summary>
    [JsonPropertyName("exec")]
    public V1alpha1AIPlatformModelSpecContainerSpecHealthProbeExec? Exec { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds.  Minimum value is 1. Must be less than timeout_seconds.   Maps to Kubernetes probe argument 'periodSeconds'.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second.  Minimum value is 1. Must be greater or equal to period_seconds.   Maps to Kubernetes probe argument 'timeoutSeconds'.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecPorts
{
    /// <summary>The number of the port to expose on the pod's IP address. Must be a valid port number, between 1 and 65535 inclusive.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }
}

/// <summary>ExecAction probes the health of a container by executing a command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>Immutable. Specification for Kubernetes startup probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpecStartupProbe
{
    /// <summary>ExecAction probes the health of a container by executing a command.</summary>
    [JsonPropertyName("exec")]
    public V1alpha1AIPlatformModelSpecContainerSpecStartupProbeExec? Exec { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds.  Minimum value is 1. Must be less than timeout_seconds.   Maps to Kubernetes probe argument 'periodSeconds'.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second.  Minimum value is 1. Must be greater or equal to period_seconds.   Maps to Kubernetes probe argument 'timeoutSeconds'.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Input only. The specification of the container that is to be used when deploying this Model. The specification is ingested upon [ModelService.UploadModel][google.cloud.aiplatform.v1.ModelService.UploadModel], and all binaries it contains are copied and stored internally by Vertex AI. Not required for AutoML Models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecContainerSpec
{
    /// <summary>Immutable. Specifies arguments for the command that runs when the container  starts. This overrides the container's  [`CMD`](https://docs.docker.com/engine/reference/builder/#cmd). Specify  this field as an array of executable and arguments, similar to a Docker  `CMD`'s "default parameters" form.   If you don't specify this field but do specify the  [command][google.cloud.aiplatform.v1.ModelContainerSpec.command] field,  then the command from the `command` field runs without any additional  arguments. See the [Kubernetes documentation about how the `command` and  `args` fields interact with a container's `ENTRYPOINT` and  `CMD`](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).   If you don't specify this field and don't specify the `command` field,  then the container's  [`ENTRYPOINT`](https://docs.docker.com/engine/reference/builder/#cmd) and  `CMD` determine what runs based on their default behavior. See the Docker  documentation about [how `CMD` and `ENTRYPOINT`  interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact).   In this field, you can reference [environment variables  set by Vertex  AI](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables)  and environment variables set in the  [env][google.cloud.aiplatform.v1.ModelContainerSpec.env] field. You cannot  reference environment variables set in the Docker image. In order for  environment variables to be expanded, reference them by using the following  syntax: &lt;code&gt;$(&lt;var&gt;VARIABLE_NAME&lt;/var&gt;)&lt;/code&gt; Note that this differs  from Bash variable expansion, which does not use parentheses. If a variable  cannot be resolved, the reference in the input string is used unchanged. To  avoid variable expansion, you can escape this syntax with `$$`; for  example: &lt;code&gt;$$(&lt;var&gt;VARIABLE_NAME&lt;/var&gt;)&lt;/code&gt; This field corresponds  to the `args` field of the Kubernetes Containers [v1 core  API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Immutable. Specifies the command that runs when the container starts. This  overrides the container's  [ENTRYPOINT](https://docs.docker.com/engine/reference/builder/#entrypoint).  Specify this field as an array of executable and arguments, similar to a  Docker `ENTRYPOINT`'s "exec" form, not its "shell" form.   If you do not specify this field, then the container's `ENTRYPOINT` runs,  in conjunction with the  [args][google.cloud.aiplatform.v1.ModelContainerSpec.args] field or the  container's [`CMD`](https://docs.docker.com/engine/reference/builder/#cmd),  if either exists. If this field is not specified and the container does not  have an `ENTRYPOINT`, then refer to the Docker documentation about [how  `CMD` and `ENTRYPOINT`  interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact).   If you specify this field, then you can also specify the `args` field to  provide additional arguments for this command. However, if you specify this  field, then the container's `CMD` is ignored. See the  [Kubernetes documentation about how the  `command` and `args` fields interact with a container's `ENTRYPOINT` and  `CMD`](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).   In this field, you can reference [environment variables set by Vertex  AI](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables)  and environment variables set in the  [env][google.cloud.aiplatform.v1.ModelContainerSpec.env] field. You cannot  reference environment variables set in the Docker image. In order for  environment variables to be expanded, reference them by using the following  syntax: &lt;code&gt;$(&lt;var&gt;VARIABLE_NAME&lt;/var&gt;)&lt;/code&gt; Note that this differs  from Bash variable expansion, which does not use parentheses. If a variable  cannot be resolved, the reference in the input string is used unchanged. To  avoid variable expansion, you can escape this syntax with `$$`; for  example: &lt;code&gt;$$(&lt;var&gt;VARIABLE_NAME&lt;/var&gt;)&lt;/code&gt; This field corresponds  to the `command` field of the Kubernetes Containers [v1 core  API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Immutable. Deployment timeout. Limit for deployment timeout is 2 hours.</summary>
    [JsonPropertyName("deploymentTimeout")]
    public string? DeploymentTimeout { get; set; }

    /// <summary>Immutable. List of environment variables to set in the container. After the  container starts running, code running in the container can read these  environment variables.   Additionally, the  [command][google.cloud.aiplatform.v1.ModelContainerSpec.command] and  [args][google.cloud.aiplatform.v1.ModelContainerSpec.args] fields can  reference these variables. Later entries in this list can also reference  earlier entries. For example, the following example sets the variable  `VAR_2` to have the value `foo bar`:   ```json  [    {      "name": "VAR_1",      "value": "foo"    },    {      "name": "VAR_2",      "value": "$(VAR_1) bar"    }  ]  ```   If you switch the order of the variables in the example, then the expansion  does not occur.   This field corresponds to the `env` field of the Kubernetes Containers  [v1 core  API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AIPlatformModelSpecContainerSpecEnv>? Env { get; set; }

    /// <summary>Immutable. List of ports to expose from the container. Vertex AI sends gRPC  prediction requests that it receives to the first port on this list. Vertex  AI also sends liveness and health checks to this port.   If you do not specify this field, gRPC requests to the container will be  disabled.   Vertex AI does not use ports other than the first one listed. This field  corresponds to the `ports` field of the Kubernetes Containers v1 core API.</summary>
    [JsonPropertyName("grpcPorts")]
    public IList<V1alpha1AIPlatformModelSpecContainerSpecGrpcPorts>? GrpcPorts { get; set; }

    /// <summary>Immutable. Specification for Kubernetes readiness probe.</summary>
    [JsonPropertyName("healthProbe")]
    public V1alpha1AIPlatformModelSpecContainerSpecHealthProbe? HealthProbe { get; set; }

    /// <summary>Immutable. HTTP path on the container to send health checks to. Vertex AI  intermittently sends GET requests to this path on the container's IP  address and port to check that the container is healthy. Read more about  [health  checks](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#health).   For example, if you set this field to `/bar`, then Vertex AI  intermittently sends a GET request to the `/bar` path on the port of your  container specified by the first value of this `ModelContainerSpec`'s  [ports][google.cloud.aiplatform.v1.ModelContainerSpec.ports] field.   If you don't specify this field, it defaults to the following value when  you [deploy this Model to an  Endpoint][google.cloud.aiplatform.v1.EndpointService.DeployModel]:  &lt;code&gt;/v1/endpoints/&lt;var&gt;ENDPOINT&lt;/var&gt;/deployedModels/&lt;var&gt;DEPLOYED_MODEL&lt;/var&gt;:predict&lt;/code&gt;  The placeholders in this value are replaced as follows:   * &lt;var&gt;ENDPOINT&lt;/var&gt;: The last segment (following `endpoints/`)of the    Endpoint.name][] field of the Endpoint where this Model has been    deployed. (Vertex AI makes this value available to your container code    as the [`AIP_ENDPOINT_ID` environment    variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)   * &lt;var&gt;DEPLOYED_MODEL&lt;/var&gt;:  [DeployedModel.id][google.cloud.aiplatform.v1.DeployedModel.id] of the  `DeployedModel`.    (Vertex AI makes this value available to your container code as the    [`AIP_DEPLOYED_MODEL_ID` environment    variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)</summary>
    [JsonPropertyName("healthRoute")]
    public string? HealthRoute { get; set; }

    /// <summary>Required. Immutable. URI of the Docker image to be used as the custom  container for serving predictions. This URI must identify an image in  Artifact Registry or Container Registry. Learn more about the [container  publishing  requirements](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#publishing),  including permissions requirements for the Vertex AI Service Agent.   The container image is ingested upon  [ModelService.UploadModel][google.cloud.aiplatform.v1.ModelService.UploadModel],  stored internally, and this original path is afterwards not used.   To learn about the requirements for the Docker image itself, see  [Custom container  requirements](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#).   You can use the URI to one of Vertex AI's [pre-built container images for  prediction](https://cloud.google.com/vertex-ai/docs/predictions/pre-built-containers)  in this field.</summary>
    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    /// <summary>Immutable. List of ports to expose from the container. Vertex AI sends any  prediction requests that it receives to the first port on this list. Vertex  AI also sends  [liveness and health  checks](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#liveness)  to this port.   If you do not specify this field, it defaults to following value:   ```json  [    {      "containerPort": 8080    }  ]  ```   Vertex AI does not use ports other than the first one listed. This field  corresponds to the `ports` field of the Kubernetes Containers  [v1 core  API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.23/#container-v1-core).</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AIPlatformModelSpecContainerSpecPorts>? Ports { get; set; }

    /// <summary>Immutable. HTTP path on the container to send prediction requests to.  Vertex AI forwards requests sent using  [projects.locations.endpoints.predict][google.cloud.aiplatform.v1.PredictionService.Predict]  to this path on the container's IP address and port. Vertex AI then returns  the container's response in the API response.   For example, if you set this field to `/foo`, then when Vertex AI  receives a prediction request, it forwards the request body in a POST  request to the `/foo` path on the port of your container specified by the  first value of this `ModelContainerSpec`'s  [ports][google.cloud.aiplatform.v1.ModelContainerSpec.ports] field.   If you don't specify this field, it defaults to the following value when  you [deploy this Model to an  Endpoint][google.cloud.aiplatform.v1.EndpointService.DeployModel]:  &lt;code&gt;/v1/endpoints/&lt;var&gt;ENDPOINT&lt;/var&gt;/deployedModels/&lt;var&gt;DEPLOYED_MODEL&lt;/var&gt;:predict&lt;/code&gt;  The placeholders in this value are replaced as follows:   * &lt;var&gt;ENDPOINT&lt;/var&gt;: The last segment (following `endpoints/`)of the    Endpoint.name][] field of the Endpoint where this Model has been    deployed. (Vertex AI makes this value available to your container code    as the [`AIP_ENDPOINT_ID` environment   variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)   * &lt;var&gt;DEPLOYED_MODEL&lt;/var&gt;:  [DeployedModel.id][google.cloud.aiplatform.v1.DeployedModel.id] of the  `DeployedModel`.    (Vertex AI makes this value available to your container code    as the [`AIP_DEPLOYED_MODEL_ID` environment    variable](https://cloud.google.com/vertex-ai/docs/predictions/custom-container-requirements#aip-variables).)</summary>
    [JsonPropertyName("predictRoute")]
    public string? PredictRoute { get; set; }

    /// <summary>Immutable. The amount of the VM memory to reserve as the shared memory for the model in megabytes.</summary>
    [JsonPropertyName("sharedMemorySizeMb")]
    public long? SharedMemorySizeMb { get; set; }

    /// <summary>Immutable. Specification for Kubernetes startup probe.</summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AIPlatformModelSpecContainerSpecStartupProbe? StartupProbe { get; set; }
}

/// <summary>Stats of data used for training or evaluating the Model.   Only populated when the Model is trained by a TrainingPipeline with  [data_input_config][google.cloud.aiplatform.v1.TrainingPipeline.input_data_config].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecDataStats
{
    /// <summary>Number of Annotations that are used for evaluating this Model. If the Model is evaluated multiple times, this will be the number of test Annotations used by the first evaluation. If the Model is not evaluated, the number is 0.</summary>
    [JsonPropertyName("testAnnotationsCount")]
    public long? TestAnnotationsCount { get; set; }

    /// <summary>Number of DataItems that were used for evaluating this Model. If the Model is evaluated multiple times, this will be the number of test DataItems used by the first evaluation. If the Model is not evaluated, the number is 0.</summary>
    [JsonPropertyName("testDataItemsCount")]
    public long? TestDataItemsCount { get; set; }

    /// <summary>Number of Annotations that are used for training this Model.</summary>
    [JsonPropertyName("trainingAnnotationsCount")]
    public long? TrainingAnnotationsCount { get; set; }

    /// <summary>Number of DataItems that were used for training this Model.</summary>
    [JsonPropertyName("trainingDataItemsCount")]
    public long? TrainingDataItemsCount { get; set; }

    /// <summary>Number of Annotations that are used for validating this Model during training.</summary>
    [JsonPropertyName("validationAnnotationsCount")]
    public long? ValidationAnnotationsCount { get; set; }

    /// <summary>Number of DataItems that were used for validating this Model during training.</summary>
    [JsonPropertyName("validationDataItemsCount")]
    public long? ValidationDataItemsCount { get; set; }
}

/// <summary>Customer-managed encryption key spec for a Model. If set, this Model and all sub-resources of this Model will be secured by this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsEncodedBaselines
{
    /// <summary>Represents a boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Represents a null value.</summary>
    [JsonPropertyName("nullValue")]
    public string? NullValue { get; set; }

    /// <summary>Represents a double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Represents a string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a structured value.</summary>
    [JsonPropertyName("structValue")]
    public IDictionary<string, string>? StructValue { get; set; }
}

/// <summary>The domain details of the input feature value. Like min/max, original mean or standard deviation if normalized.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsFeatureValueDomain
{
    /// <summary>The maximum permissible value for this feature.</summary>
    [JsonPropertyName("maxValue")]
    public double? MaxValue { get; set; }

    /// <summary>The minimum permissible value for this feature.</summary>
    [JsonPropertyName("minValue")]
    public double? MinValue { get; set; }

    /// <summary>If this input feature has been normalized to a mean value of 0, the original_mean specifies the mean value of the domain prior to normalization.</summary>
    [JsonPropertyName("originalMean")]
    public double? OriginalMean { get; set; }

    /// <summary>If this input feature has been normalized to a standard deviation of 1.0, the original_stddev specifies the standard deviation of the domain prior to normalization.</summary>
    [JsonPropertyName("originalStddev")]
    public double? OriginalStddev { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsInputBaselines
{
    /// <summary>Represents a boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Represents a null value.</summary>
    [JsonPropertyName("nullValue")]
    public string? NullValue { get; set; }

    /// <summary>Represents a double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Represents a string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a structured value.</summary>
    [JsonPropertyName("structValue")]
    public IDictionary<string, string>? StructValue { get; set; }
}

/// <summary>Visualization configurations for image explanation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsVisualization
{
    /// <summary>Excludes attributions below the specified percentile, from the highlighted areas. Defaults to 62.</summary>
    [JsonPropertyName("clipPercentLowerbound")]
    public double? ClipPercentLowerbound { get; set; }

    /// <summary>Excludes attributions above the specified percentile from the highlighted areas. Using the clip_percent_upperbound and clip_percent_lowerbound together can be useful for filtering out noise and making it easier to see areas of strong attribution. Defaults to 99.9.</summary>
    [JsonPropertyName("clipPercentUpperbound")]
    public double? ClipPercentUpperbound { get; set; }

    /// <summary>The color scheme used for the highlighted areas.   Defaults to PINK_GREEN for  [Integrated Gradients  attribution][google.cloud.aiplatform.v1.ExplanationParameters.integrated_gradients_attribution],  which shows positive attributions in green and negative in pink.   Defaults to VIRIDIS for  [XRAI  attribution][google.cloud.aiplatform.v1.ExplanationParameters.xrai_attribution],  which highlights the most influential regions in yellow and the least  influential in blue.</summary>
    [JsonPropertyName("colorMap")]
    public string? ColorMap { get; set; }

    /// <summary>How the original image is displayed in the visualization. Adjusting the overlay can help increase visual clarity if the original image makes it difficult to view the visualization. Defaults to NONE.</summary>
    [JsonPropertyName("overlayType")]
    public string? OverlayType { get; set; }

    /// <summary>Whether to only highlight pixels with positive contributions, negative or both. Defaults to POSITIVE.</summary>
    [JsonPropertyName("polarity")]
    public string? Polarity { get; set; }

    /// <summary>Type of the image visualization. Only applicable to [Integrated Gradients attribution][google.cloud.aiplatform.v1.ExplanationParameters.integrated_gradients_attribution]. OUTLINES shows regions of attribution, while PIXELS shows per-pixel attribution. Defaults to OUTLINES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputs
{
    /// <summary>Specifies the shape of the values of the input if the input is a sparse representation. Refer to Tensorflow documentation for more details: https://www.tensorflow.org/api_docs/python/tf/sparse/SparseTensor.</summary>
    [JsonPropertyName("denseShapeTensorName")]
    public string? DenseShapeTensorName { get; set; }

    /// <summary>A list of baselines for the encoded tensor.   The shape of each baseline should match the shape of the encoded tensor.  If a scalar is provided, Vertex AI broadcasts to the same shape as the  encoded tensor.</summary>
    [JsonPropertyName("encodedBaselines")]
    public IList<V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsEncodedBaselines>? EncodedBaselines { get; set; }

    /// <summary>Encoded tensor is a transformation of the input tensor. Must be provided  if choosing  [Integrated Gradients  attribution][google.cloud.aiplatform.v1.ExplanationParameters.integrated_gradients_attribution]  or [XRAI  attribution][google.cloud.aiplatform.v1.ExplanationParameters.xrai_attribution]  and the input tensor is not differentiable.   An encoded tensor is generated if the input tensor is encoded by a lookup  table.</summary>
    [JsonPropertyName("encodedTensorName")]
    public string? EncodedTensorName { get; set; }

    /// <summary>Defines how the feature is encoded into the input tensor. Defaults to IDENTITY.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The domain details of the input feature value. Like min/max, original mean or standard deviation if normalized.</summary>
    [JsonPropertyName("featureValueDomain")]
    public V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsFeatureValueDomain? FeatureValueDomain { get; set; }

    /// <summary>Name of the group that the input belongs to. Features with the same group name will be treated as one feature when computing attributions. Features grouped together can have different shapes in value. If provided, there will be one single attribution generated in [Attribution.feature_attributions][google.cloud.aiplatform.v1.Attribution.feature_attributions], keyed by the group name.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>A list of feature names for each index in the input tensor. Required when the input [InputMetadata.encoding][google.cloud.aiplatform.v1.ExplanationMetadata.InputMetadata.encoding] is BAG_OF_FEATURES, BAG_OF_FEATURES_SPARSE, INDICATOR.</summary>
    [JsonPropertyName("indexFeatureMapping")]
    public IList<string>? IndexFeatureMapping { get; set; }

    /// <summary>Specifies the index of the values of the input tensor. Required when the input tensor is a sparse representation. Refer to Tensorflow documentation for more details: https://www.tensorflow.org/api_docs/python/tf/sparse/SparseTensor.</summary>
    [JsonPropertyName("indicesTensorName")]
    public string? IndicesTensorName { get; set; }

    /// <summary>Baseline inputs for this feature.   If no baseline is specified, Vertex AI chooses the baseline for this  feature. If multiple baselines are specified, Vertex AI returns the  average attributions across them in  [Attribution.feature_attributions][google.cloud.aiplatform.v1.Attribution.feature_attributions].   For Vertex AI-provided Tensorflow images (both 1.x and 2.x), the shape  of each baseline must match the shape of the input tensor. If a scalar is  provided, we broadcast to the same shape as the input tensor.   For custom images, the element of the baselines must be in the same  format as the feature's input in the  [instance][google.cloud.aiplatform.v1.ExplainRequest.instances][]. The  schema of any single instance may be specified via Endpoint's  DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]  [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]  [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].</summary>
    [JsonPropertyName("inputBaselines")]
    public IList<V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsInputBaselines>? InputBaselines { get; set; }

    /// <summary>Name of the input tensor for this feature. Required and is only applicable to Vertex AI-provided images for Tensorflow.</summary>
    [JsonPropertyName("inputTensorName")]
    public string? InputTensorName { get; set; }

    /// <summary>Modality of the feature. Valid values are: numeric, image. Defaults to numeric.</summary>
    [JsonPropertyName("modality")]
    public string? Modality { get; set; }

    /// <summary>Visualization configurations for image explanation.</summary>
    [JsonPropertyName("visualization")]
    public V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputsVisualization? Visualization { get; set; }
}

/// <summary>Static mapping between the index and display name.   Use this if the outputs are a deterministic n-dimensional array, e.g. a  list of scores of all the classes in a pre-defined order for a  multi-classification Model. It's not feasible if the outputs are  non-deterministic, e.g. the Model produces top-k classes or sort the  outputs by their values.   The shape of the value must be an n-dimensional array of strings. The  number of dimensions must match that of the outputs to be explained.  The  [Attribution.output_display_name][google.cloud.aiplatform.v1.Attribution.output_display_name]  is populated by locating in the mapping with  [Attribution.output_index][google.cloud.aiplatform.v1.Attribution.output_index].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataOutputsIndexDisplayNameMapping
{
    /// <summary>Represents a boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Represents a null value.</summary>
    [JsonPropertyName("nullValue")]
    public string? NullValue { get; set; }

    /// <summary>Represents a double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Represents a string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a structured value.</summary>
    [JsonPropertyName("structValue")]
    public IDictionary<string, string>? StructValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadataOutputs
{
    /// <summary>Specify a field name in the prediction to look for the display name.   Use this if the prediction contains the display names for the outputs.   The display names in the prediction must have the same shape of the  outputs, so that it can be located by  [Attribution.output_index][google.cloud.aiplatform.v1.Attribution.output_index]  for a specific output.</summary>
    [JsonPropertyName("displayNameMappingKey")]
    public string? DisplayNameMappingKey { get; set; }

    /// <summary>Static mapping between the index and display name.   Use this if the outputs are a deterministic n-dimensional array, e.g. a  list of scores of all the classes in a pre-defined order for a  multi-classification Model. It's not feasible if the outputs are  non-deterministic, e.g. the Model produces top-k classes or sort the  outputs by their values.   The shape of the value must be an n-dimensional array of strings. The  number of dimensions must match that of the outputs to be explained.  The  [Attribution.output_display_name][google.cloud.aiplatform.v1.Attribution.output_display_name]  is populated by locating in the mapping with  [Attribution.output_index][google.cloud.aiplatform.v1.Attribution.output_index].</summary>
    [JsonPropertyName("indexDisplayNameMapping")]
    public V1alpha1AIPlatformModelSpecExplanationSpecMetadataOutputsIndexDisplayNameMapping? IndexDisplayNameMapping { get; set; }

    /// <summary>Name of the output tensor. Required and is only applicable to Vertex AI provided images for Tensorflow.</summary>
    [JsonPropertyName("outputTensorName")]
    public string? OutputTensorName { get; set; }
}

/// <summary>Optional. Metadata describing the Model's input and output for explanation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecMetadata
{
    /// <summary>Points to a YAML file stored on Google Cloud Storage describing the format of the [feature attributions][google.cloud.aiplatform.v1.Attribution.feature_attributions]. The schema is defined as an OpenAPI 3.0.2 [Schema Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject). AutoML tabular Models always have this field populated by Vertex AI. Note: The URI given on output may be different, including the URI scheme, than the one given on input. The output URI will point to a location where the user only has a read access.</summary>
    [JsonPropertyName("featureAttributionsSchemaURI")]
    public string? FeatureAttributionsSchemaURI { get; set; }

    /// <summary>Required. Map from feature names to feature input metadata. Keys are the name of the features. Values are the specification of the feature.  An empty InputMetadata is valid. It describes a text feature which has the name specified as the key in [ExplanationMetadata.inputs][google.cloud.aiplatform.v1.ExplanationMetadata.inputs]. The baseline of the empty feature is chosen by Vertex AI.  For Vertex AI-provided Tensorflow images, the key can be any friendly name of the feature. Once specified, [featureAttributions][google.cloud.aiplatform.v1.Attribution.feature_attributions] are keyed by this key (if not grouped with another feature).  For custom images, the key must match with the key in [instance][google.cloud.aiplatform.v1.ExplainRequest.instances].</summary>
    [JsonPropertyName("inputs")]
    public IDictionary<string, V1alpha1AIPlatformModelSpecExplanationSpecMetadataInputs>? Inputs { get; set; }

    /// <summary>Name of the source to generate embeddings for example based explanations.</summary>
    [JsonPropertyName("latentSpaceSource")]
    public string? LatentSpaceSource { get; set; }

    /// <summary>Required. Map from output names to output metadata.  For Vertex AI-provided Tensorflow images, keys can be any user defined string that consists of any UTF-8 characters.  For custom images, keys are the name of the output field in the prediction to be explained.  Currently only one key is allowed.</summary>
    [JsonPropertyName("outputs")]
    public IDictionary<string, V1alpha1AIPlatformModelSpecExplanationSpecMetadataOutputs>? Outputs { get; set; }
}

/// <summary>The Cloud Storage location for the input instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesExampleGCSSourceGcsSource
{
    /// <summary>Required. Google Cloud Storage URI(-s) to the input file(s). May contain wildcards. For more information on wildcards, see https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>The Cloud Storage input instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesExampleGCSSource
{
    /// <summary>The format in which instances are given, if not specified, assume it's JSONL format. Currently only JSONL format is supported.</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>The Cloud Storage location for the input instances.</summary>
    [JsonPropertyName("gcsSource")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesExampleGCSSourceGcsSource? GcsSource { get; set; }
}

/// <summary>The full configuration for the generated index, the semantics are the same as [metadata][google.cloud.aiplatform.v1.Index.metadata] and should match [NearestNeighborSearchConfig](https://cloud.google.com/vertex-ai/docs/explainable-ai/configuring-explanations-example-based#nearest-neighbor-search-config).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesNearestNeighborSearchConfig
{
    /// <summary>Represents a boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Represents a null value.</summary>
    [JsonPropertyName("nullValue")]
    public string? NullValue { get; set; }

    /// <summary>Represents a double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Represents a string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a structured value.</summary>
    [JsonPropertyName("structValue")]
    public IDictionary<string, string>? StructValue { get; set; }
}

/// <summary>Simplified preset configuration, which automatically sets configuration values based on the desired query speed-precision trade-off and modality.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesPresets
{
    /// <summary>The modality of the uploaded model, which automatically configures the distance measurement and feature normalization for the underlying example index and queries. If your model does not precisely fit one of these types, it is okay to choose the closest type.</summary>
    [JsonPropertyName("modality")]
    public string? Modality { get; set; }

    /// <summary>Preset option controlling parameters for speed-precision trade-off when querying for examples. If omitted, defaults to `PRECISE`.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>Example-based explanations that returns the nearest neighbors from the provided dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersExamples
{
    /// <summary>The Cloud Storage input instances.</summary>
    [JsonPropertyName("exampleGCSSource")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesExampleGCSSource? ExampleGCSSource { get; set; }

    /// <summary>The full configuration for the generated index, the semantics are the same as [metadata][google.cloud.aiplatform.v1.Index.metadata] and should match [NearestNeighborSearchConfig](https://cloud.google.com/vertex-ai/docs/explainable-ai/configuring-explanations-example-based#nearest-neighbor-search-config).</summary>
    [JsonPropertyName("nearestNeighborSearchConfig")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesNearestNeighborSearchConfig? NearestNeighborSearchConfig { get; set; }

    /// <summary>The number of neighbors to return when querying for examples.</summary>
    [JsonPropertyName("neighborCount")]
    public int? NeighborCount { get; set; }

    /// <summary>Simplified preset configuration, which automatically sets configuration values based on the desired query speed-precision trade-off and modality.</summary>
    [JsonPropertyName("presets")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersExamplesPresets? Presets { get; set; }
}

/// <summary>Config for IG with blur baseline.   When enabled, a linear path from the maximally blurred image to the input  image is created. Using a blurred baseline instead of zero (black image) is  motivated by the BlurIG approach explained here:  https://arxiv.org/abs/2004.03383</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionBlurBaselineConfig
{
    /// <summary>The standard deviation of the blur kernel for the blurred baseline. The same blurring parameter is used for both the height and the width dimension. If not set, the method defaults to the zero (i.e. black for images) baseline.</summary>
    [JsonPropertyName("maxBlurSigma")]
    public double? MaxBlurSigma { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfigFeatureNoiseSigmaNoiseSigma
{
    /// <summary>The name of the input feature for which noise sigma is provided. The features are defined in [explanation metadata inputs][google.cloud.aiplatform.v1.ExplanationMetadata.inputs].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>This represents the standard deviation of the Gaussian kernel that will be used to add noise to the feature prior to computing gradients. Similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] but represents the noise added to the current feature. Defaults to 0.1.</summary>
    [JsonPropertyName("sigma")]
    public double? Sigma { get; set; }
}

/// <summary>This is similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma], but provides additional flexibility. A separate noise sigma can be provided for each feature, which is useful if their distributions are different. No noise is added to features that are not set. If this field is unset, [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] will be used for all features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfigFeatureNoiseSigma
{
    /// <summary>Noise sigma per feature. No noise is added to features that are not set.</summary>
    [JsonPropertyName("noiseSigma")]
    public IList<V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfigFeatureNoiseSigmaNoiseSigma>? NoiseSigma { get; set; }
}

/// <summary>Config for SmoothGrad approximation of gradients.   When enabled, the gradients are approximated by averaging the gradients  from noisy samples in the vicinity of the inputs. Adding  noise can help improve the computed gradients. Refer to this paper for more  details: https://arxiv.org/pdf/1706.03825.pdf</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfig
{
    /// <summary>This is similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma], but provides additional flexibility. A separate noise sigma can be provided for each feature, which is useful if their distributions are different. No noise is added to features that are not set. If this field is unset, [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] will be used for all features.</summary>
    [JsonPropertyName("featureNoiseSigma")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfigFeatureNoiseSigma? FeatureNoiseSigma { get; set; }

    /// <summary>This is a single float value and will be used to add noise to all the  features. Use this field when all features are normalized to have the  same distribution: scale to range [0, 1], [-1, 1] or z-scoring, where  features are normalized to have 0-mean and 1-variance. Learn more about  [normalization](https://developers.google.com/machine-learning/data-prep/transform/normalization).   For best results the recommended value is about 10% - 20% of the standard  deviation of the input feature. Refer to section 3.2 of the SmoothGrad  paper: https://arxiv.org/pdf/1706.03825.pdf. Defaults to 0.1.   If the distribution is different per feature, set  [feature_noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.feature_noise_sigma]  instead for each feature.</summary>
    [JsonPropertyName("noiseSigma")]
    public double? NoiseSigma { get; set; }

    /// <summary>The number of gradient samples to use for approximation. The higher this number, the more accurate the gradient is, but the runtime complexity increases by this factor as well. Valid range of its value is [1, 50]. Defaults to 3.</summary>
    [JsonPropertyName("noisySampleCount")]
    public int? NoisySampleCount { get; set; }
}

/// <summary>An attribution method that computes Aumann-Shapley values taking advantage of the model's fully differentiable structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttribution
{
    /// <summary>Config for IG with blur baseline.   When enabled, a linear path from the maximally blurred image to the input  image is created. Using a blurred baseline instead of zero (black image) is  motivated by the BlurIG approach explained here:  https://arxiv.org/abs/2004.03383</summary>
    [JsonPropertyName("blurBaselineConfig")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionBlurBaselineConfig? BlurBaselineConfig { get; set; }

    /// <summary>Config for SmoothGrad approximation of gradients.   When enabled, the gradients are approximated by averaging the gradients  from noisy samples in the vicinity of the inputs. Adding  noise can help improve the computed gradients. Refer to this paper for more  details: https://arxiv.org/pdf/1706.03825.pdf</summary>
    [JsonPropertyName("smoothGradConfig")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttributionSmoothGradConfig? SmoothGradConfig { get; set; }

    /// <summary>Required. The number of steps for approximating the path integral.  A good value to start is 50 and gradually increase until the  sum to diff property is within the desired error range.   Valid range of its value is [1, 100], inclusively.</summary>
    [JsonPropertyName("stepCount")]
    public int? StepCount { get; set; }
}

/// <summary>An attribution method that approximates Shapley values for features that contribute to the label being predicted. A sampling strategy is used to approximate the value rather than considering all subsets of features. Refer to this paper for model details: https://arxiv.org/abs/1306.4265.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersSampledShapleyAttribution
{
    /// <summary>Required. The number of feature permutations to consider when approximating  the Shapley values.   Valid range of its value is [1, 50], inclusively.</summary>
    [JsonPropertyName("pathCount")]
    public int? PathCount { get; set; }
}

/// <summary>Config for XRAI with blur baseline.   When enabled, a linear path from the maximally blurred image to the input  image is created. Using a blurred baseline instead of zero (black image) is  motivated by the BlurIG approach explained here:  https://arxiv.org/abs/2004.03383</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionBlurBaselineConfig
{
    /// <summary>The standard deviation of the blur kernel for the blurred baseline. The same blurring parameter is used for both the height and the width dimension. If not set, the method defaults to the zero (i.e. black for images) baseline.</summary>
    [JsonPropertyName("maxBlurSigma")]
    public double? MaxBlurSigma { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfigFeatureNoiseSigmaNoiseSigma
{
    /// <summary>The name of the input feature for which noise sigma is provided. The features are defined in [explanation metadata inputs][google.cloud.aiplatform.v1.ExplanationMetadata.inputs].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>This represents the standard deviation of the Gaussian kernel that will be used to add noise to the feature prior to computing gradients. Similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] but represents the noise added to the current feature. Defaults to 0.1.</summary>
    [JsonPropertyName("sigma")]
    public double? Sigma { get; set; }
}

/// <summary>This is similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma], but provides additional flexibility. A separate noise sigma can be provided for each feature, which is useful if their distributions are different. No noise is added to features that are not set. If this field is unset, [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] will be used for all features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfigFeatureNoiseSigma
{
    /// <summary>Noise sigma per feature. No noise is added to features that are not set.</summary>
    [JsonPropertyName("noiseSigma")]
    public IList<V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfigFeatureNoiseSigmaNoiseSigma>? NoiseSigma { get; set; }
}

/// <summary>Config for SmoothGrad approximation of gradients.   When enabled, the gradients are approximated by averaging the gradients  from noisy samples in the vicinity of the inputs. Adding  noise can help improve the computed gradients. Refer to this paper for more  details: https://arxiv.org/pdf/1706.03825.pdf</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfig
{
    /// <summary>This is similar to [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma], but provides additional flexibility. A separate noise sigma can be provided for each feature, which is useful if their distributions are different. No noise is added to features that are not set. If this field is unset, [noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.noise_sigma] will be used for all features.</summary>
    [JsonPropertyName("featureNoiseSigma")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfigFeatureNoiseSigma? FeatureNoiseSigma { get; set; }

    /// <summary>This is a single float value and will be used to add noise to all the  features. Use this field when all features are normalized to have the  same distribution: scale to range [0, 1], [-1, 1] or z-scoring, where  features are normalized to have 0-mean and 1-variance. Learn more about  [normalization](https://developers.google.com/machine-learning/data-prep/transform/normalization).   For best results the recommended value is about 10% - 20% of the standard  deviation of the input feature. Refer to section 3.2 of the SmoothGrad  paper: https://arxiv.org/pdf/1706.03825.pdf. Defaults to 0.1.   If the distribution is different per feature, set  [feature_noise_sigma][google.cloud.aiplatform.v1.SmoothGradConfig.feature_noise_sigma]  instead for each feature.</summary>
    [JsonPropertyName("noiseSigma")]
    public double? NoiseSigma { get; set; }

    /// <summary>The number of gradient samples to use for approximation. The higher this number, the more accurate the gradient is, but the runtime complexity increases by this factor as well. Valid range of its value is [1, 50]. Defaults to 3.</summary>
    [JsonPropertyName("noisySampleCount")]
    public int? NoisySampleCount { get; set; }
}

/// <summary>An attribution method that redistributes Integrated Gradients  attribution to segmented regions, taking advantage of the model's fully  differentiable structure. Refer to this paper for  more details: https://arxiv.org/abs/1906.02825   XRAI currently performs better on natural images, like a picture of a  house or an animal. If the images are taken in artificial environments,  like a lab or manufacturing line, or from diagnostic equipment, like  x-rays or quality-control cameras, use Integrated Gradients instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttribution
{
    /// <summary>Config for XRAI with blur baseline.   When enabled, a linear path from the maximally blurred image to the input  image is created. Using a blurred baseline instead of zero (black image) is  motivated by the BlurIG approach explained here:  https://arxiv.org/abs/2004.03383</summary>
    [JsonPropertyName("blurBaselineConfig")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionBlurBaselineConfig? BlurBaselineConfig { get; set; }

    /// <summary>Config for SmoothGrad approximation of gradients.   When enabled, the gradients are approximated by averaging the gradients  from noisy samples in the vicinity of the inputs. Adding  noise can help improve the computed gradients. Refer to this paper for more  details: https://arxiv.org/pdf/1706.03825.pdf</summary>
    [JsonPropertyName("smoothGradConfig")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttributionSmoothGradConfig? SmoothGradConfig { get; set; }

    /// <summary>Required. The number of steps for approximating the path integral.  A good value to start is 50 and gradually increase until the  sum to diff property is met within the desired error range.   Valid range of its value is [1, 100], inclusively.</summary>
    [JsonPropertyName("stepCount")]
    public int? StepCount { get; set; }
}

/// <summary>Required. Parameters that configure explaining of the Model's predictions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpecParameters
{
    /// <summary>Example-based explanations that returns the nearest neighbors from the provided dataset.</summary>
    [JsonPropertyName("examples")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersExamples? Examples { get; set; }

    /// <summary>An attribution method that computes Aumann-Shapley values taking advantage of the model's fully differentiable structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365</summary>
    [JsonPropertyName("integratedGradientsAttribution")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersIntegratedGradientsAttribution? IntegratedGradientsAttribution { get; set; }

    /// <summary>An attribution method that approximates Shapley values for features that contribute to the label being predicted. A sampling strategy is used to approximate the value rather than considering all subsets of features. Refer to this paper for model details: https://arxiv.org/abs/1306.4265.</summary>
    [JsonPropertyName("sampledShapleyAttribution")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersSampledShapleyAttribution? SampledShapleyAttribution { get; set; }

    /// <summary>If populated, returns attributions for top K indices of outputs (defaults to 1). Only applies to Models that predicts more than one outputs (e,g, multi-class Models). When set to -1, returns explanations for all outputs.</summary>
    [JsonPropertyName("topK")]
    public int? TopK { get; set; }

    /// <summary>An attribution method that redistributes Integrated Gradients  attribution to segmented regions, taking advantage of the model's fully  differentiable structure. Refer to this paper for  more details: https://arxiv.org/abs/1906.02825   XRAI currently performs better on natural images, like a picture of a  house or an animal. If the images are taken in artificial environments,  like a lab or manufacturing line, or from diagnostic equipment, like  x-rays or quality-control cameras, use Integrated Gradients instead.</summary>
    [JsonPropertyName("xraiAttribution")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParametersXraiAttribution? XraiAttribution { get; set; }
}

/// <summary>The default explanation specification for this Model.   The Model can be used for  [requesting  explanation][google.cloud.aiplatform.v1.PredictionService.Explain] after  being [deployed][google.cloud.aiplatform.v1.EndpointService.DeployModel] if  it is populated. The Model can be used for [batch  explanation][google.cloud.aiplatform.v1.BatchPredictionJob.generate_explanation]  if it is populated.   All fields of the explanation_spec can be overridden by  [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]  of  [DeployModelRequest.deployed_model][google.cloud.aiplatform.v1.DeployModelRequest.deployed_model],  or  [explanation_spec][google.cloud.aiplatform.v1.BatchPredictionJob.explanation_spec]  of [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].   If the default explanation specification is not set for this Model, this  Model can still be used for  [requesting  explanation][google.cloud.aiplatform.v1.PredictionService.Explain] by  setting  [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]  of  [DeployModelRequest.deployed_model][google.cloud.aiplatform.v1.DeployModelRequest.deployed_model]  and for [batch  explanation][google.cloud.aiplatform.v1.BatchPredictionJob.generate_explanation]  by setting  [explanation_spec][google.cloud.aiplatform.v1.BatchPredictionJob.explanation_spec]  of [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecExplanationSpec
{
    /// <summary>Optional. Metadata describing the Model's input and output for explanation.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AIPlatformModelSpecExplanationSpecMetadata? Metadata { get; set; }

    /// <summary>Required. Parameters that configure explaining of the Model's predictions.</summary>
    [JsonPropertyName("parameters")]
    public V1alpha1AIPlatformModelSpecExplanationSpecParameters? Parameters { get; set; }
}

/// <summary>Immutable. An additional information about the Model; the schema of the metadata can be found in [metadata_schema][google.cloud.aiplatform.v1.Model.metadata_schema_uri]. Unset if the Model does not have any additional information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecMetadata
{
    /// <summary>Represents a boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Represents a null value.</summary>
    [JsonPropertyName("nullValue")]
    public string? NullValue { get; set; }

    /// <summary>Represents a double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Represents a string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a structured value.</summary>
    [JsonPropertyName("structValue")]
    public IDictionary<string, string>? StructValue { get; set; }
}

/// <summary>The schemata that describe formats of the Model's predictions and explanations as given and returned via [PredictionService.Predict][google.cloud.aiplatform.v1.PredictionService.Predict] and [PredictionService.Explain][google.cloud.aiplatform.v1.PredictionService.Explain].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecPredictSchemata
{
    /// <summary>Immutable. Points to a YAML file stored on Google Cloud Storage describing the format of a single instance, which are used in [PredictRequest.instances][google.cloud.aiplatform.v1.PredictRequest.instances], [ExplainRequest.instances][google.cloud.aiplatform.v1.ExplainRequest.instances] and [BatchPredictionJob.input_config][google.cloud.aiplatform.v1.BatchPredictionJob.input_config]. The schema is defined as an OpenAPI 3.0.2 [Schema Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject). AutoML Models always have this field populated by Vertex AI. Note: The URI given on output will be immutable and probably different, including the URI scheme, than the one given on input. The output URI will point to a location where the user only has a read access.</summary>
    [JsonPropertyName("instanceSchemaURI")]
    public string? InstanceSchemaURI { get; set; }

    /// <summary>Immutable. Points to a YAML file stored on Google Cloud Storage describing the parameters of prediction and explanation via [PredictRequest.parameters][google.cloud.aiplatform.v1.PredictRequest.parameters], [ExplainRequest.parameters][google.cloud.aiplatform.v1.ExplainRequest.parameters] and [BatchPredictionJob.model_parameters][google.cloud.aiplatform.v1.BatchPredictionJob.model_parameters]. The schema is defined as an OpenAPI 3.0.2 [Schema Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject). AutoML Models always have this field populated by Vertex AI, if no parameters are supported, then it is set to an empty string. Note: The URI given on output will be immutable and probably different, including the URI scheme, than the one given on input. The output URI will point to a location where the user only has a read access.</summary>
    [JsonPropertyName("parametersSchemaURI")]
    public string? ParametersSchemaURI { get; set; }

    /// <summary>Immutable. Points to a YAML file stored on Google Cloud Storage describing the format of a single prediction produced by this Model, which are returned via [PredictResponse.predictions][google.cloud.aiplatform.v1.PredictResponse.predictions], [ExplainResponse.explanations][google.cloud.aiplatform.v1.ExplainResponse.explanations], and [BatchPredictionJob.output_config][google.cloud.aiplatform.v1.BatchPredictionJob.output_config]. The schema is defined as an OpenAPI 3.0.2 [Schema Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject). AutoML Models always have this field populated by Vertex AI. Note: The URI given on output will be immutable and probably different, including the URI scheme, than the one given on input. The output URI will point to a location where the user only has a read access.</summary>
    [JsonPropertyName("predictionSchemaURI")]
    public string? PredictionSchemaURI { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpecProjectRef
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

/// <summary>AIPlatformModelSpec defines the desired state of AIPlatformModel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelSpec
{
    /// <summary>Immutable. The path to the directory containing the Model artifact and any of its supporting files. Not required for AutoML Models.</summary>
    [JsonPropertyName("artifactURI")]
    public string? ArtifactURI { get; set; }

    /// <summary>Optional. User input field to specify the base model source. Currently it only supports specifying the Model Garden models and Genie models.</summary>
    [JsonPropertyName("baseModelSource")]
    public V1alpha1AIPlatformModelSpecBaseModelSource? BaseModelSource { get; set; }

    /// <summary>Input only. The specification of the container that is to be used when deploying this Model. The specification is ingested upon [ModelService.UploadModel][google.cloud.aiplatform.v1.ModelService.UploadModel], and all binaries it contains are copied and stored internally by Vertex AI. Not required for AutoML Models.</summary>
    [JsonPropertyName("containerSpec")]
    public V1alpha1AIPlatformModelSpecContainerSpec? ContainerSpec { get; set; }

    /// <summary>Stats of data used for training or evaluating the Model.   Only populated when the Model is trained by a TrainingPipeline with  [data_input_config][google.cloud.aiplatform.v1.TrainingPipeline.input_data_config].</summary>
    [JsonPropertyName("dataStats")]
    public V1alpha1AIPlatformModelSpecDataStats? DataStats { get; set; }

    /// <summary>The description of the Model.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the Model. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Customer-managed encryption key spec for a Model. If set, this Model and all sub-resources of this Model will be secured by this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1AIPlatformModelSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The default explanation specification for this Model.   The Model can be used for  [requesting  explanation][google.cloud.aiplatform.v1.PredictionService.Explain] after  being [deployed][google.cloud.aiplatform.v1.EndpointService.DeployModel] if  it is populated. The Model can be used for [batch  explanation][google.cloud.aiplatform.v1.BatchPredictionJob.generate_explanation]  if it is populated.   All fields of the explanation_spec can be overridden by  [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]  of  [DeployModelRequest.deployed_model][google.cloud.aiplatform.v1.DeployModelRequest.deployed_model],  or  [explanation_spec][google.cloud.aiplatform.v1.BatchPredictionJob.explanation_spec]  of [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].   If the default explanation specification is not set for this Model, this  Model can still be used for  [requesting  explanation][google.cloud.aiplatform.v1.PredictionService.Explain] by  setting  [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]  of  [DeployModelRequest.deployed_model][google.cloud.aiplatform.v1.DeployModelRequest.deployed_model]  and for [batch  explanation][google.cloud.aiplatform.v1.BatchPredictionJob.generate_explanation]  by setting  [explanation_spec][google.cloud.aiplatform.v1.BatchPredictionJob.explanation_spec]  of [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].</summary>
    [JsonPropertyName("explanationSpec")]
    public V1alpha1AIPlatformModelSpecExplanationSpec? ExplanationSpec { get; set; }

    /// <summary>The labels with user-defined metadata to organize your Models.   Label keys and values can be no longer than 64 characters  (Unicode codepoints), can only contain lowercase letters, numeric  characters, underscores and dashes. International characters are allowed.   See https://goo.gl/xmQnxf for more information and examples of labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The location where the model should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. An additional information about the Model; the schema of the metadata can be found in [metadata_schema][google.cloud.aiplatform.v1.Model.metadata_schema_uri]. Unset if the Model does not have any additional information.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AIPlatformModelSpecMetadata? Metadata { get; set; }

    /// <summary>Immutable. Points to a YAML file stored on Google Cloud Storage describing additional information about the Model, that is specific to it. Unset if the Model does not have any additional information. The schema is defined as an OpenAPI 3.0.2 [Schema Object](https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.2.md#schemaObject). AutoML Models always have this field populated by Vertex AI, if no additional metadata is needed, this field is set to an empty string. Note: The URI given on output will be immutable and probably different, including the URI scheme, than the one given on input. The output URI will point to a location where the user only has a read access.</summary>
    [JsonPropertyName("metadataSchemaURI")]
    public string? MetadataSchemaURI { get; set; }

    /// <summary>Optional. This field is populated if the model is produced by a pipeline job.</summary>
    [JsonPropertyName("pipelineJob")]
    public string? PipelineJob { get; set; }

    /// <summary>The schemata that describe formats of the Model's predictions and explanations as given and returned via [PredictionService.Predict][google.cloud.aiplatform.v1.PredictionService.Predict] and [PredictionService.Explain][google.cloud.aiplatform.v1.PredictionService.Explain].</summary>
    [JsonPropertyName("predictSchemata")]
    public V1alpha1AIPlatformModelSpecPredictSchemata? PredictSchemata { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AIPlatformModelSpecProjectRef ProjectRef { get; set; }

    /// <summary>The AIPlatformModel name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>User provided version aliases so that a model version can be referenced via alias (i.e. `projects/{project}/locations/{location}/models/{model_id}@{version_alias}` instead of auto-generated version id (i.e. `projects/{project}/locations/{location}/models/{model_id}@{version_id})`. The format is [a-z][a-zA-Z0-9-]{0,126}[a-z0-9] to distinguish from version_id. A default version alias will be created for the first version of the model, and there must be exactly one default version alias for a model.</summary>
    [JsonPropertyName("versionAliases")]
    public IList<string>? VersionAliases { get; set; }

    /// <summary>The description of this version.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatusConditions
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
public partial class V1alpha1AIPlatformModelStatusObservedStateDeployedModels
{
    /// <summary>Immutable. An ID of a DeployedModel in the above Endpoint.</summary>
    [JsonPropertyName("deployedModelID")]
    public string? DeployedModelID { get; set; }

    /// <summary>Immutable. A resource name of an Endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>Output only. Source of a model. It can either be automl training pipeline, custom training pipeline, BigQuery ML, or saved and tuned from Genie or Model Garden.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatusObservedStateModelSourceInfo
{
    /// <summary>If this Model is copy of another Model. If true then [source_type][google.cloud.aiplatform.v1.ModelSourceInfo.source_type] pertains to the original.</summary>
    [JsonPropertyName("copy")]
    public bool? Copy { get; set; }

    /// <summary>Type of the model source.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>Output only. If this Model is a copy of another Model, this contains info about the original.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatusObservedStateOriginalModelInfo
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatusObservedStateSupportedExportFormats
{
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatusObservedState
{
    /// <summary>Output only. Timestamp when this Model was uploaded into Vertex AI.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The pointers to DeployedModels created from this Model. Note that Model could have been deployed to Endpoints in different Locations.</summary>
    [JsonPropertyName("deployedModels")]
    public IList<V1alpha1AIPlatformModelStatusObservedStateDeployedModels>? DeployedModels { get; set; }

    /// <summary>Output only. The resource name of the Artifact that was created in MetadataStore when creating the Model. The Artifact resource name pattern is `projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}`.</summary>
    [JsonPropertyName("metadataArtifact")]
    public string? MetadataArtifact { get; set; }

    /// <summary>Output only. Source of a model. It can either be automl training pipeline, custom training pipeline, BigQuery ML, or saved and tuned from Genie or Model Garden.</summary>
    [JsonPropertyName("modelSourceInfo")]
    public V1alpha1AIPlatformModelStatusObservedStateModelSourceInfo? ModelSourceInfo { get; set; }

    /// <summary>Output only. If this Model is a copy of another Model, this contains info about the original.</summary>
    [JsonPropertyName("originalModelInfo")]
    public V1alpha1AIPlatformModelStatusObservedStateOriginalModelInfo? OriginalModelInfo { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzi")]
    public bool? SatisfiesPzi { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzs")]
    public bool? SatisfiesPzs { get; set; }

    /// <summary>Output only. When this Model is deployed, its prediction resources are described by the `prediction_resources` field of the [Endpoint.deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models] object. Because not all Models support all resource configuration types, the configuration types this Model supports are listed here. If no configuration types are listed, the Model cannot be deployed to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and does not support online predictions ([PredictionService.Predict][google.cloud.aiplatform.v1.PredictionService.Predict] or [PredictionService.Explain][google.cloud.aiplatform.v1.PredictionService.Explain]). Such a Model can serve predictions by using a [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob], if it has at least one entry each in [supported_input_storage_formats][google.cloud.aiplatform.v1.Model.supported_input_storage_formats] and [supported_output_storage_formats][google.cloud.aiplatform.v1.Model.supported_output_storage_formats].</summary>
    [JsonPropertyName("supportedDeploymentResourcesTypes")]
    public IList<string>? SupportedDeploymentResourcesTypes { get; set; }

    /// <summary>Output only. The formats in which this Model may be exported. If empty, this Model is not available for export.</summary>
    [JsonPropertyName("supportedExportFormats")]
    public IList<V1alpha1AIPlatformModelStatusObservedStateSupportedExportFormats>? SupportedExportFormats { get; set; }

    /// <summary>Output only. The formats this Model supports in  [BatchPredictionJob.input_config][google.cloud.aiplatform.v1.BatchPredictionJob.input_config].  If  [PredictSchemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]  exists, the instances should be given as per that schema.   The possible formats are:   * `jsonl`  The JSON Lines format, where each instance is a single line. Uses  [GcsSource][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig.gcs_source].   * `csv`  The CSV format, where each instance is a single comma-separated line.  The first line in the file is the header, containing comma-separated field  names. Uses  [GcsSource][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig.gcs_source].   * `tf-record`  The TFRecord format, where each instance is a single record in tfrecord  syntax. Uses  [GcsSource][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig.gcs_source].   * `tf-record-gzip`  Similar to `tf-record`, but the file is gzipped. Uses  [GcsSource][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig.gcs_source].   * `bigquery`  Each instance is a single row in BigQuery. Uses  [BigQuerySource][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig.bigquery_source].   * `file-list`  Each line of the file is the location of an instance to process, uses  `gcs_source` field of the  [InputConfig][google.cloud.aiplatform.v1.BatchPredictionJob.InputConfig]  object.   If this Model doesn't support any of these formats it means it cannot be  used with a  [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].  However, if it has  [supported_deployment_resources_types][google.cloud.aiplatform.v1.Model.supported_deployment_resources_types],  it could serve online predictions by using  [PredictionService.Predict][google.cloud.aiplatform.v1.PredictionService.Predict]  or  [PredictionService.Explain][google.cloud.aiplatform.v1.PredictionService.Explain].</summary>
    [JsonPropertyName("supportedInputStorageFormats")]
    public IList<string>? SupportedInputStorageFormats { get; set; }

    /// <summary>Output only. The formats this Model supports in  [BatchPredictionJob.output_config][google.cloud.aiplatform.v1.BatchPredictionJob.output_config].  If both  [PredictSchemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]  and  [PredictSchemata.prediction_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.prediction_schema_uri]  exist, the predictions are returned together with their instances. In other  words, the prediction has the original instance data first, followed by the  actual prediction content (as per the schema).   The possible formats are:   * `jsonl`  The JSON Lines format, where each prediction is a single line. Uses  [GcsDestination][google.cloud.aiplatform.v1.BatchPredictionJob.OutputConfig.gcs_destination].   * `csv`  The CSV format, where each prediction is a single comma-separated line.  The first line in the file is the header, containing comma-separated field  names. Uses  [GcsDestination][google.cloud.aiplatform.v1.BatchPredictionJob.OutputConfig.gcs_destination].   * `bigquery`  Each prediction is a single row in a BigQuery table, uses  [BigQueryDestination][google.cloud.aiplatform.v1.BatchPredictionJob.OutputConfig.bigquery_destination]  .   If this Model doesn't support any of these formats it means it cannot be  used with a  [BatchPredictionJob][google.cloud.aiplatform.v1.BatchPredictionJob].  However, if it has  [supported_deployment_resources_types][google.cloud.aiplatform.v1.Model.supported_deployment_resources_types],  it could serve online predictions by using  [PredictionService.Predict][google.cloud.aiplatform.v1.PredictionService.Predict]  or  [PredictionService.Explain][google.cloud.aiplatform.v1.PredictionService.Explain].</summary>
    [JsonPropertyName("supportedOutputStorageFormats")]
    public IList<string>? SupportedOutputStorageFormats { get; set; }

    /// <summary>Output only. The resource name of the TrainingPipeline that uploaded this Model, if any.</summary>
    [JsonPropertyName("trainingPipeline")]
    public string? TrainingPipeline { get; set; }

    /// <summary>Output only. Timestamp when this Model was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. Timestamp when this version was created.</summary>
    [JsonPropertyName("versionCreateTime")]
    public string? VersionCreateTime { get; set; }

    /// <summary>Output only. Immutable. The version ID of the model. A new version is committed when a new model version is uploaded or trained under an existing model id. It is an auto-incrementing decimal number in string representation.</summary>
    [JsonPropertyName("versionID")]
    public string? VersionID { get; set; }

    /// <summary>Output only. Timestamp when this version was most recently updated.</summary>
    [JsonPropertyName("versionUpdateTime")]
    public string? VersionUpdateTime { get; set; }
}

/// <summary>AIPlatformModelStatus defines the config connector machine state of AIPlatformModel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIPlatformModelStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AIPlatformModelStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AIPlatformModel resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AIPlatformModelStatusObservedState? ObservedState { get; set; }
}

/// <summary>AIPlatformModel is the Schema for the AIPlatformModel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AIPlatformModel : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AIPlatformModelSpec>, IStatus<V1alpha1AIPlatformModelStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AIPlatformModel";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "aiplatformmodels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AIPlatformModelSpec defines the desired state of AIPlatformModel</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AIPlatformModelSpec Spec { get; set; }

    /// <summary>AIPlatformModelStatus defines the config connector machine state of AIPlatformModel</summary>
    [JsonPropertyName("status")]
    public V1alpha1AIPlatformModelStatus? Status { get; set; }
}

/// <summary>AIPlatformModel is the Schema for the AIPlatformModel API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AIPlatformModelList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AIPlatformModel>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AIPlatformModelList";
    public const string KubeGroup = "aiplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "aiplatformmodels";
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
    public IList<V1alpha1AIPlatformModel> Items { get; set; }
}