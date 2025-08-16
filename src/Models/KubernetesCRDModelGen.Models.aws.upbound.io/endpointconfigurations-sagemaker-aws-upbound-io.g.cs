using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>EndpointConfiguration is the Schema for the EndpointConfigurations API. Provides a SageMaker AI Endpoint Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EndpointConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EndpointConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointConfigurationList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
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
    public IList<V1beta1EndpointConfiguration> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig
{
    /// <summary>The maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, Amazon SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>Amazon SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>The Amazon SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>Amazon SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that Amazon SageMaker AI uses to encrypt the asynchronous inference output in Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Specifies the configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The Amazon S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>The Amazon S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by Amazon SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig>? ClientConfig { get; set; }

    /// <summary>Specifies the configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig>? OutputConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>The CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Specifies the data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfig
{
    /// <summary>The content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public IList<V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader>? CaptureContentTypeHeader { get; set; }

    /// <summary>Specifies what data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>The URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt the captured data on Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProvider
{
    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfig>? AsyncInferenceConfig { get; set; }

    /// <summary>Specifies the parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderDataCaptureConfig>? DataCaptureConfig { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>An list of ProductionVariant objects, one for each model that you want to host at this endpoint. Fields are documented below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Array of ProductionVariant objects. There is one for each model that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on ProductionVariants. If you use this field, you can only specify one variant for ProductionVariants and one variant for ShadowProductionVariants. Fields are documented below.</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig
{
    /// <summary>The maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, Amazon SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>Amazon SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>The Amazon SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>Amazon SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that Amazon SageMaker AI uses to encrypt the asynchronous inference output in Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Specifies the configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The Amazon S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>The Amazon S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by Amazon SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig>? ClientConfig { get; set; }

    /// <summary>Specifies the configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig>? OutputConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>The CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Specifies the data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfig
{
    /// <summary>The content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader>? CaptureContentTypeHeader { get; set; }

    /// <summary>Specifies what data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>The URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt the captured data on Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProvider
{
    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfig>? AsyncInferenceConfig { get; set; }

    /// <summary>Specifies the parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfig>? DataCaptureConfig { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>An list of ProductionVariant objects, one for each model that you want to host at this endpoint. Fields are documented below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>Array of ProductionVariant objects. There is one for each model that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on ProductionVariants. If you use this field, you can only specify one variant for ProductionVariants and one variant for ShadowProductionVariants. Fields are documented below.</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1EndpointConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EndpointConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EndpointConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EndpointConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EndpointConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig
{
    /// <summary>The maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, Amazon SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>Amazon SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>The Amazon SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>Amazon SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that Amazon SageMaker AI uses to encrypt the asynchronous inference output in Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Specifies the configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The Amazon S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>The Amazon S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by Amazon SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig>? ClientConfig { get; set; }

    /// <summary>Specifies the configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig>? OutputConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>The CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Specifies the data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfig
{
    /// <summary>The content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader>? CaptureContentTypeHeader { get; set; }

    /// <summary>Specifies what data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>The URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt the captured data on Amazon S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>The Amazon S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that SageMaker AI uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>The maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Indicates whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>Sets how the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>The maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>The memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>The amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariants
{
    /// <summary>The size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Specifies configuration for a core dump from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig>? CoreDumpConfig { get; set; }

    /// <summary>You can use this parameter to turn on native Amazon Web Services Systems Manager (SSM) access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind an endpoints.</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Specifies an option from a collection of preconfigured Amazon Machine Image (AMI) images. Each image is configured by Amazon Web Services with a set of software and driver versions. Amazon Web Services optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Determines initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, it defaults to 1.0.</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>The type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Settings that control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling>? ManagedInstanceScaling { get; set; }

    /// <summary>The timeout value, in seconds, to download and extract the model that you want to host from Amazon S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>The name of the model to use.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Sets how the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig>? ServerlessConfig { get; set; }

    /// <summary>The name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>The size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this endpoint configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies configuration for how an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfig>? AsyncInferenceConfig { get; set; }

    /// <summary>Specifies the parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfig>? DataCaptureConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>An list of ProductionVariant objects, one for each model that you want to host at this endpoint. Fields are documented below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Array of ProductionVariant objects. There is one for each model that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on ProductionVariants. If you use this field, you can only specify one variant for ProductionVariants and one variant for ShadowProductionVariants. Fields are documented below.</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusConditions
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

/// <summary>EndpointConfigurationStatus defines the observed state of EndpointConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EndpointConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EndpointConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EndpointConfiguration is the Schema for the EndpointConfigurations API. Provides a SageMaker AI Endpoint Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EndpointConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EndpointConfigurationSpec>, IStatus<V1beta1EndpointConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointConfiguration";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1EndpointConfigurationSpec Spec { get; set; }

    /// <summary>EndpointConfigurationStatus defines the observed state of EndpointConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1EndpointConfigurationStatus? Status { get; set; }
}