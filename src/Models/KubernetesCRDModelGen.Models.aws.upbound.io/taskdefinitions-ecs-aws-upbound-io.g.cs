using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderExecutionRoleArnRefPolicy
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
public partial class V1beta1TaskDefinitionSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskDefinitionSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicy
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
public partial class V1beta1TaskDefinitionSpecForProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolumeEfsVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolumeDockerVolumeConfiguration>? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolumeEfsVolumeConfiguration>? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfiguration>? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>Name of the volume. This name is referenced in the sourceVolume parameter of container definition in the mountPoints section.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecForProvider
{
    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task's containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1TaskDefinitionSpecForProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1TaskDefinitionSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1TaskDefinitionSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task The valid values are host, task, and none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values are none, bridge, awsvpc, and host.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. The valid values are host and task.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1TaskDefinitionSpecForProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1TaskDefinitionSpecForProviderProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Set of launch types required by the task. The valid values are EC2 and FARGATE.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public IList<V1beta1TaskDefinitionSpecForProviderRuntimePlatform>? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1TaskDefinitionSpecForProviderVolume>? Volume { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicy
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
public partial class V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicy
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
public partial class V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolumeEfsVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolumeDockerVolumeConfiguration>? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolumeEfsVolumeConfiguration>? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfiguration>? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>Name of the volume. This name is referenced in the sourceVolume parameter of container definition in the mountPoints section.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecInitProvider
{
    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task's containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1TaskDefinitionSpecInitProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1TaskDefinitionSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task The valid values are host, task, and none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values are none, bridge, awsvpc, and host.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. The valid values are host and task.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1TaskDefinitionSpecInitProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1TaskDefinitionSpecInitProviderProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>Set of launch types required by the task. The valid values are EC2 and FARGATE.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public IList<V1beta1TaskDefinitionSpecInitProviderRuntimePlatform>? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1TaskDefinitionSpecInitProviderVolume>? Volume { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecProviderConfigRefPolicy
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
public partial class V1beta1TaskDefinitionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskDefinitionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TaskDefinitionSpec defines the desired state of TaskDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TaskDefinitionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TaskDefinitionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TaskDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TaskDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolumeEfsVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolumeDockerVolumeConfiguration>? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolumeEfsVolumeConfiguration>? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfiguration>? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>Name of the volume. This name is referenced in the sourceVolume parameter of container definition in the mountPoints section.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusAtProvider
{
    /// <summary>Full ARN of the Task Definition (including both family and revision).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the Task Definition with the trailing revision removed. This may be useful for situations where the latest task definition is always desired. If a revision isn't specified, the latest ACTIVE revision is used. See the AWS documentation for details.</summary>
    [JsonPropertyName("arnWithoutRevision")]
    public string? ArnWithoutRevision { get; set; }

    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task's containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1TaskDefinitionStatusAtProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task The valid values are host, task, and none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values are none, bridge, awsvpc, and host.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. The valid values are host and task.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1TaskDefinitionStatusAtProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public IList<V1beta1TaskDefinitionStatusAtProviderProxyConfiguration>? ProxyConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Set of launch types required by the task. The valid values are EC2 and FARGATE.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Revision of the task in a particular family.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public IList<V1beta1TaskDefinitionStatusAtProviderRuntimePlatform>? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1TaskDefinitionStatusAtProviderVolume>? Volume { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatusConditions
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

/// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskDefinitionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TaskDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TaskDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TaskDefinition is the Schema for the TaskDefinitions API. Manages a revision of an ECS task definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TaskDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TaskDefinitionSpec>, IStatus<V1beta1TaskDefinitionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TaskDefinition";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "taskdefinitions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TaskDefinitionSpec defines the desired state of TaskDefinition</summary>
    [JsonPropertyName("spec")]
    public V1beta1TaskDefinitionSpec Spec { get; set; }

    /// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta1TaskDefinitionStatus? Status { get; set; }
}

/// <summary>TaskDefinition is the Schema for the TaskDefinitions API. Manages a revision of an ECS task definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TaskDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TaskDefinition>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TaskDefinitionList";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "taskdefinitions";
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
    public IList<V1beta1TaskDefinition> Items { get; set; }
}