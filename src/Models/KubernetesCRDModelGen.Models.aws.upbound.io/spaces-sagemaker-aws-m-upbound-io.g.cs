using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderDomainIdRefPolicy
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
public partial class V1beta1SpaceSpecForProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecForProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderDomainIdSelectorPolicy
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
public partial class V1beta1SpaceSpecForProviderDomainIdSelector
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
    public V1beta1SpaceSpecForProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta1SpaceSpecForProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta1SpaceSpecForProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta1SpaceSpecForProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta1SpaceSpecForProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta1SpaceSpecForProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderDomainIdRefPolicy
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
public partial class V1beta1SpaceSpecInitProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecInitProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderDomainIdSelectorPolicy
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
public partial class V1beta1SpaceSpecInitProviderDomainIdSelector
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
    public V1beta1SpaceSpecInitProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta1SpaceSpecInitProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta1SpaceSpecInitProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta1SpaceSpecInitProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta1SpaceSpecInitProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecProviderConfigRef
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
public partial class V1beta1SpaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SpaceSpec defines the desired state of Space</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProvider
{
    /// <summary>The space's Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>The ID of the space's profile in the Amazon Elastic File System volume.</summary>
    [JsonPropertyName("homeEfsFileSystemUid")]
    public string? HomeEfsFileSystemUid { get; set; }

    /// <summary>The space's Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta1SpaceStatusAtProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta1SpaceStatusAtProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Returns the URL of the space. If the space is created with Amazon Web Services IAM Identity Center (Successor to Amazon Web Services Single Sign-On) authentication, users can navigate to the URL after appending the respective redirect parameter for the application type to be federated through Amazon Web Services IAM Identity Center.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusConditions
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

/// <summary>SpaceStatus defines the observed state of Space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Space is the Schema for the Spaces API. Provides a SageMaker AI Space resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Space : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpaceSpec>, IStatus<V1beta1SpaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Space";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "spaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpaceSpec defines the desired state of Space</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpaceSpec Spec { get; set; }

    /// <summary>SpaceStatus defines the observed state of Space.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpaceStatus? Status { get; set; }
}

/// <summary>Space is the Schema for the Spaces API. Provides a SageMaker AI Space resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpaceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Space>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpaceList";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "spaces";
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
    public IList<V1beta1Space> Items { get; set; }
}