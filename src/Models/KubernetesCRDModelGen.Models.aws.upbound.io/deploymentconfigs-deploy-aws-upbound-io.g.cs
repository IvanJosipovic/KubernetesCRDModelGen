using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deploy.aws.upbound.io;
public enum V1beta1DeploymentConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecForProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public IList<V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedCanary>? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public IList<V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedLinear>? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecForProvider
{
    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public IList<V1beta1DeploymentConfigSpecForProviderMinimumHealthyHosts>? MinimumHealthyHosts { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public IList<V1beta1DeploymentConfigSpecForProviderTrafficRoutingConfig>? TrafficRoutingConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecInitProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public IList<V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedCanary>? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public IList<V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedLinear>? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DeploymentConfigSpecInitProvider
{
    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public IList<V1beta1DeploymentConfigSpecInitProviderMinimumHealthyHosts>? MinimumHealthyHosts { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public IList<V1beta1DeploymentConfigSpecInitProviderTrafficRoutingConfig>? TrafficRoutingConfig { get; set; }
}

public enum V1beta1DeploymentConfigSpecManagementPoliciesEnum
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

public enum V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DeploymentConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DeploymentConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DeploymentConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DeploymentConfigSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DeploymentConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DeploymentConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DeploymentConfigSpec defines the desired state of DeploymentConfig</summary>
public partial class V1beta1DeploymentConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeploymentConfigSpecDeletionPolicyEnum>))]
    public V1beta1DeploymentConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DeploymentConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DeploymentConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DeploymentConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DeploymentConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DeploymentConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DeploymentConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigStatusAtProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public IList<V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedCanary>? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public IList<V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedLinear>? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DeploymentConfigStatusAtProvider
{
    /// <summary>The ARN of the deployment config.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>The AWS Assigned deployment config id</summary>
    [JsonPropertyName("deploymentConfigId")]
    public string? DeploymentConfigId { get; set; }

    /// <summary>The deployment group's config name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public IList<V1beta1DeploymentConfigStatusAtProviderMinimumHealthyHosts>? MinimumHealthyHosts { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public IList<V1beta1DeploymentConfigStatusAtProviderTrafficRoutingConfig>? TrafficRoutingConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DeploymentConfigStatusConditions
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

/// <summary>DeploymentConfigStatus defines the observed state of DeploymentConfig.</summary>
public partial class V1beta1DeploymentConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DeploymentConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeploymentConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>DeploymentConfig is the Schema for the DeploymentConfigs API. Provides a CodeDeploy deployment config.</summary>
public partial class V1beta1DeploymentConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DeploymentConfigSpec>, IStatus<V1beta1DeploymentConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeploymentConfig";
    public const string KubeGroup = "deploy.aws.upbound.io";
    public const string KubePluralName = "deploymentconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeploymentConfigSpec defines the desired state of DeploymentConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1DeploymentConfigSpec Spec { get; set; }

    /// <summary>DeploymentConfigStatus defines the observed state of DeploymentConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1DeploymentConfigStatus? Status { get; set; }
}