using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.emrserverless.aws.upbound.io;
public enum V1beta1ApplicationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1ApplicationSpecForProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfigWorkerConfiguration>? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public IList<V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfig>? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationSpecForProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>–  The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>–  The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderAutoStartConfiguration>? AutoStartConfiguration { get; set; }

    /// <summary>–  The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderAutoStopConfiguration>? AutoStopConfiguration { get; set; }

    /// <summary>–  The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>–  The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationSpecForProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>–  The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public IList<V1beta1ApplicationSpecForProviderMaximumCapacity>? MaximumCapacity { get; set; }

    /// <summary>–  The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>–  The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>–  The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>–  The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfigWorkerConfiguration>? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public IList<V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfig>? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationSpecInitProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>–  The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>–  The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderAutoStartConfiguration>? AutoStartConfiguration { get; set; }

    /// <summary>–  The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderAutoStopConfiguration>? AutoStopConfiguration { get; set; }

    /// <summary>–  The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>–  The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationSpecInitProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>–  The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public IList<V1beta1ApplicationSpecInitProviderMaximumCapacity>? MaximumCapacity { get; set; }

    /// <summary>–  The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>–  The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>–  The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>–  The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1ApplicationSpecManagementPoliciesEnum
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

public enum V1beta1ApplicationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ApplicationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ApplicationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ApplicationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ApplicationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ApplicationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ApplicationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ApplicationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ApplicationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ApplicationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecDeletionPolicyEnum>))]
    public V1beta1ApplicationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ApplicationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfigWorkerConfiguration>? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public IList<V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfig>? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1ApplicationStatusAtProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>–  The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>ARN of the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>–  The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderAutoStartConfiguration>? AutoStartConfiguration { get; set; }

    /// <summary>–  The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderAutoStopConfiguration>? AutoStopConfiguration { get; set; }

    /// <summary>The ID of the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>–  The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>–  The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationStatusAtProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>–  The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public IList<V1beta1ApplicationStatusAtProviderMaximumCapacity>? MaximumCapacity { get; set; }

    /// <summary>–  The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>–  The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>–  The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>–  The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ApplicationStatusConditions
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

public partial class V1beta1ApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "emrserverless.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}