using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecForProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderDomainIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecForProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProviderUserSettings
{
    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsStudioWebPortalSettings>? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecForProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta1UserProfileSpecForProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta1UserProfileSpecForProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain's AuthMode is SSO, this field is required. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain's AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1UserProfileSpecForProviderUserSettings>? UserSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecInitProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderDomainIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecInitProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProviderUserSettings
{
    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsStudioWebPortalSettings>? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecInitProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta1UserProfileSpecInitProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta1UserProfileSpecInitProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain's AuthMode is SSO, this field is required. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain's AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1UserProfileSpecInitProviderUserSettings>? UserSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecProviderConfigRefPolicy
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
public partial class V1beta1UserProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1UserProfileSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserProfileSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1UserProfileSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UserProfileSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UserProfileSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>UserProfileSpec defines the desired state of UserProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UserProfileSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProviderUserSettings
{
    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsStudioWebPortalSettings>? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusAtProvider
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>The ID of the user's profile in the Amazon Elastic File System (EFS) volume.</summary>
    [JsonPropertyName("homeEfsFileSystemUid")]
    public string? HomeEfsFileSystemUid { get; set; }

    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain's AuthMode is SSO, this field is required. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain's AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain's AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public IList<V1beta1UserProfileStatusAtProviderUserSettings>? UserSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatusConditions
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

/// <summary>UserProfileStatus defines the observed state of UserProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UserProfile is the Schema for the UserProfiles API. Provides a SageMaker User Profile resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserProfileSpec>, IStatus<V1beta1UserProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserProfile";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "userprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserProfileSpec defines the desired state of UserProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserProfileSpec Spec { get; set; }

    /// <summary>UserProfileStatus defines the observed state of UserProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserProfileStatus? Status { get; set; }
}