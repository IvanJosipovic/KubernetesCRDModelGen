using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecForProviderDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecForProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecForProviderDomainIdRefPolicyResolutionEnum>))]
    public V1beta1SpaceSpecForProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecForProviderDomainIdRefPolicyResolveEnum>))]
    public V1beta1SpaceSpecForProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecForProviderDomainIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecForProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
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
    /// <summary>A custom file system in Amazon EFS. see EFS File System below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystemEfsFileSystem>? EfsFileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsStorageSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings>? EbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecForProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker Domain. See Custom File System below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }
}

/// <summary></summary>
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

    /// <summary>A collection of ownership settings. See Ownership Settings below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public IList<V1beta1SpaceSpecForProviderOwnershipSettings>? OwnershipSettings { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the space that appears in the SageMaker Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See Space Settings below.</summary>
    [JsonPropertyName("spaceSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSettings>? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. See Space Sharing Settings below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public IList<V1beta1SpaceSpecForProviderSpaceSharingSettings>? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum>))]
    public V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolveEnum>))]
    public V1beta1SpaceSpecInitProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecInitProviderDomainIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecInitProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
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
    /// <summary>A custom file system in Amazon EFS. see EFS File System below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystemEfsFileSystem>? EfsFileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsStorageSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings>? EbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecInitProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker Domain. See Custom File System below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }
}

/// <summary></summary>
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

    /// <summary>A collection of ownership settings. See Ownership Settings below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public IList<V1beta1SpaceSpecInitProviderOwnershipSettings>? OwnershipSettings { get; set; }

    /// <summary>The name of the space that appears in the SageMaker Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See Space Settings below.</summary>
    [JsonPropertyName("spaceSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSettings>? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. See Space Sharing Settings below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public IList<V1beta1SpaceSpecInitProviderSpaceSharingSettings>? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SpaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpaceSpec defines the desired state of Space</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpaceSpecDeletionPolicyEnum>))]
    public V1beta1SpaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
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
    /// <summary>A custom file system in Amazon EFS. see EFS File System below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystemEfsFileSystem>? EfsFileSystem { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker image created on the instance.</summary>
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
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec>? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary></summary>
    [JsonPropertyName("ebsStorageSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings>? EbsStorageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpaceStatusAtProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings>? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker Domain. See Custom File System below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings>? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server's app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings>? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings>? KernelGatewayAppSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spaceStorageSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings>? SpaceStorageSettings { get; set; }
}

/// <summary></summary>
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

    /// <summary>A collection of ownership settings. See Ownership Settings below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public IList<V1beta1SpaceStatusAtProviderOwnershipSettings>? OwnershipSettings { get; set; }

    /// <summary>The name of the space that appears in the SageMaker Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See Space Settings below.</summary>
    [JsonPropertyName("spaceSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSettings>? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. See Space Sharing Settings below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public IList<V1beta1SpaceStatusAtProviderSpaceSharingSettings>? SpaceSharingSettings { get; set; }

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

/// <summary>Space is the Schema for the Spaces API. Provides a SageMaker Space resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Space : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpaceSpec>, IStatus<V1beta1SpaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Space";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
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