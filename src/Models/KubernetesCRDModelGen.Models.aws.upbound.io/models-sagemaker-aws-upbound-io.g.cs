using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelSpecForProviderContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelSpecForProviderContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelSpecForProviderContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelSpecForProviderContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderInferenceExecutionConfig
{
    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderVpcConfig
{
    /// <summary></summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelSpecForProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. see Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public IList<V1beta1ModelSpecForProviderInferenceExecutionConfig>? InferenceExecutionConfig { get; set; }

    /// <summary>The primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainer>? PrimaryContainer { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. VpcConfig is used in hosting services and in batch transform.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ModelSpecForProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelSpecInitProviderContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelSpecInitProviderContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelSpecInitProviderContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderInferenceExecutionConfig
{
    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderVpcConfig
{
    /// <summary></summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelSpecInitProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. see Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public IList<V1beta1ModelSpecInitProviderInferenceExecutionConfig>? InferenceExecutionConfig { get; set; }

    /// <summary>The primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainer>? PrimaryContainer { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. VpcConfig is used in hosting services and in batch transform.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ModelSpecInitProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ModelSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ModelSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ModelSpec defines the desired state of Model</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ModelSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ModelSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ModelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ModelSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ModelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelStatusAtProviderContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelStatusAtProviderContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelStatusAtProviderContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderInferenceExecutionConfig
{
    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig>? RepositoryAuthConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The AcceptEula value must be explicitly defined as true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. see Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig>? ModelAccessConfig { get; set; }

    /// <summary>The type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSource
{
    /// <summary>The S3 location of model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainer
{
    /// <summary>The DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container. A list of key value pairs.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>The registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerImageConfig>? ImageConfig { get; set; }

    /// <summary>The inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>The container hosts value SingleModel/MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerModelDataSource>? ModelDataSource { get; set; }

    /// <summary>The URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the model package to use to create the model.</summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerMultiModelConfig>? MultiModelConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderVpcConfig
{
    /// <summary></summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this model.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelStatusAtProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. see Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public IList<V1beta1ModelStatusAtProviderInferenceExecutionConfig>? InferenceExecutionConfig { get; set; }

    /// <summary>The primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainer>? PrimaryContainer { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. VpcConfig is used in hosting services and in batch transform.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ModelStatusAtProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusConditions
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

/// <summary>ModelStatus defines the observed state of Model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ModelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ModelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Model is the Schema for the Models API. Provides a SageMaker model resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Model : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ModelSpec>, IStatus<V1beta1ModelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Model";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "models";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelSpec defines the desired state of Model</summary>
    [JsonPropertyName("spec")]
    public V1beta1ModelSpec Spec { get; set; }

    /// <summary>ModelStatus defines the observed state of Model.</summary>
    [JsonPropertyName("status")]
    public V1beta1ModelStatus? Status { get; set; }
}