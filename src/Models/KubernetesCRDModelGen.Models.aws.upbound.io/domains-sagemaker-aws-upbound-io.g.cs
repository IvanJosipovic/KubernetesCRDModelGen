using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
public enum V1beta1DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
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
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultSpaceSettings
{
    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRole.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRole.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameRef")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef? AppImageConfigNameRef { get; set; }

    /// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameSelector")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector? AppImageConfigNameSelector { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameRef")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef? ImageNameRef { get; set; }

    /// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameSelector")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector? ImageNameSelector { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsCustomImage
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDefaultUserSettings
{
    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleRef")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleRef? ExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleSelector")]
    public V1beta1DomainSpecForProviderDefaultUserSettingsExecutionRoleSelector? ExecutionRoleSelector { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecForProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecForProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderDomainSettings
{
    /// <summary>The configuration for attaching a SageMaker user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public IList<V1beta1DomainSpecForProviderDomainSettingsRStudioServerProDomainSettings>? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

public enum V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1DomainSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1DomainSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

public enum V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1DomainSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
public partial class V1beta1DomainSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
public partial class V1beta1DomainSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
public partial class V1beta1DomainSpecForProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultSpaceSettings>? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public IList<V1beta1DomainSpecForProviderDefaultUserSettings>? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public IList<V1beta1DomainSpecForProviderDomainSettings>? DomainSettings { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DomainSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DomainSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1DomainSpecForProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DomainSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DomainSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1DomainSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1DomainSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
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
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultSpaceSettings
{
    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRole.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRole.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameRef")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef? AppImageConfigNameRef { get; set; }

    /// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameSelector")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector? AppImageConfigNameSelector { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameRef")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef? ImageNameRef { get; set; }

    /// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameSelector")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector? ImageNameSelector { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsCustomImage
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDefaultUserSettings
{
    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleRef")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleRef? ExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleSelector")]
    public V1beta1DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelector? ExecutionRoleSelector { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
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
public partial class V1beta1DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderDomainSettings
{
    /// <summary>The configuration for attaching a SageMaker user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public IList<V1beta1DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettings>? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

public enum V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1DomainSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
public partial class V1beta1DomainSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

public enum V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1DomainSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
public partial class V1beta1DomainSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderVpcIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecInitProviderVpcIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
public partial class V1beta1DomainSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecInitProviderVpcIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
public partial class V1beta1DomainSpecInitProviderVpcIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DomainSpecInitProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultSpaceSettings>? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public IList<V1beta1DomainSpecInitProviderDefaultUserSettings>? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public IList<V1beta1DomainSpecInitProviderDomainSettings>? DomainSettings { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DomainSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DomainSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1DomainSpecInitProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DomainSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DomainSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta1DomainSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta1DomainSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}

public enum V1beta1DomainSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
public partial class V1beta1DomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecDeletionPolicyEnum>))]
    public V1beta1DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
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
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultSpaceSettings
{
    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you're connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker model registry account. Required only to register model versions created by a different SageMaker Canvas AWS account than the AWS account in which SageMaker model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings>? DirectDeploySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generativeAiSettings")]
    public V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsKendraSettings>? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings>? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings>? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings>? WorkspaceSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsCustomImage
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings>? DefaultEbsStorageSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDefaultUserSettings
{
    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCanvasAppSettings>? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsCustomPosixUserConfig>? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsRSessionAppSettings>? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsRStudioServerProAppSettings>? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsSharingSettings>? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettings>? TensorBoardAppSettings { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
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
public partial class V1beta1DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderDomainSettings
{
    /// <summary>The configuration for attaching a SageMaker user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public IList<V1beta1DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettings>? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultSpaceSettings>? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public IList<V1beta1DomainStatusAtProviderDefaultUserSettings>? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public IList<V1beta1DomainStatusAtProviderDomainSettings>? DomainSettings { get; set; }

    /// <summary>The ID of the Amazon Elastic File System (EFS) managed by this Domain.</summary>
    [JsonPropertyName("homeEfsFileSystemId")]
    public string? HomeEfsFileSystemId { get; set; }

    /// <summary>The ID of the Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1DomainStatusAtProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>The ID of the security group that authorizes traffic between the RSessionGateway apps and the RStudioServerPro app.</summary>
    [JsonPropertyName("securityGroupIdForDomainBoundary")]
    public string? SecurityGroupIdForDomainBoundary { get; set; }

    /// <summary>The ARN of the application managed by SageMaker in IAM Identity Center. This value is only returned for domains created after September 19, 2023.</summary>
    [JsonPropertyName("singleSignOnApplicationArn")]
    public string? SingleSignOnApplicationArn { get; set; }

    /// <summary>The SSO managed application instance ID.</summary>
    [JsonPropertyName("singleSignOnManagedApplicationInstanceId")]
    public string? SingleSignOnManagedApplicationInstanceId { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The domain's URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
public partial class V1beta1DomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Domain is the Schema for the Domains API. Provides a SageMaker Domain resource.</summary>
public partial class V1beta1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSpec>, IStatus<V1beta1DomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainStatus? Status { get; set; }
}