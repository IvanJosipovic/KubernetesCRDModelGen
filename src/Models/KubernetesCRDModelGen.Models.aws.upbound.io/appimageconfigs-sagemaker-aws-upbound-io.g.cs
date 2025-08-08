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
public partial class V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderJupyterLabImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderJupyterLabImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfigFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecForProvider
{
    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderCodeEditorAppImageConfig>? CodeEditorAppImageConfig { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderJupyterLabImageConfig>? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public IList<V1beta1AppImageConfigSpecForProviderKernelGatewayImageConfig>? KernelGatewayImageConfig { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfigFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecInitProvider
{
    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderCodeEditorAppImageConfig>? CodeEditorAppImageConfig { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderJupyterLabImageConfig>? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public IList<V1beta1AppImageConfigSpecInitProviderKernelGatewayImageConfig>? KernelGatewayImageConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecProviderConfigRefPolicy
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
public partial class V1beta1AppImageConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppImageConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AppImageConfigSpec defines the desired state of AppImageConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppImageConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppImageConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppImageConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppImageConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you're running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfigContainerConfig>? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfigFileSystemConfig>? FileSystemConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user's EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfigFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this App Image Config.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderCodeEditorAppImageConfig>? CodeEditorAppImageConfig { get; set; }

    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderJupyterLabImageConfig>? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public IList<V1beta1AppImageConfigStatusAtProviderKernelGatewayImageConfig>? KernelGatewayImageConfig { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatusConditions
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

/// <summary>AppImageConfigStatus defines the observed state of AppImageConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppImageConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppImageConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppImageConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AppImageConfig is the Schema for the AppImageConfigs API. Provides a SageMaker AI App Image Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppImageConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppImageConfigSpec>, IStatus<V1beta1AppImageConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppImageConfig";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "appimageconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppImageConfigSpec defines the desired state of AppImageConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppImageConfigSpec Spec { get; set; }

    /// <summary>AppImageConfigStatus defines the observed state of AppImageConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppImageConfigStatus? Status { get; set; }
}

/// <summary>AppImageConfig is the Schema for the AppImageConfigs API. Provides a SageMaker AI App Image Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppImageConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AppImageConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppImageConfigList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "appimageconfigs";
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
    public IList<V1beta1AppImageConfig> Items { get; set; }
}