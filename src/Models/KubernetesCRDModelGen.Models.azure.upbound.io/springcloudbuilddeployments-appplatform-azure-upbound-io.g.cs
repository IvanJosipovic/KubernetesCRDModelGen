using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
public enum V1beta1SpringCloudBuildDeploymentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public enum V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecForProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Build Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>The ID of the Spring Cloud Build Result.</summary>
    [JsonPropertyName("buildResultId")]
    public string? BuildResultId { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudBuildDeploymentSpecForProviderQuota>? Quota { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Build Deployment to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }

    /// <summary>Reference to a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdRef")]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdRef? SpringCloudAppIdRef { get; set; }

    /// <summary>Selector for a SpringCloudApp in appplatform to populate springCloudAppId.</summary>
    [JsonPropertyName("springCloudAppIdSelector")]
    public V1beta1SpringCloudBuildDeploymentSpecForProviderSpringCloudAppIdSelector? SpringCloudAppIdSelector { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecInitProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecInitProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Build Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>The ID of the Spring Cloud Build Result.</summary>
    [JsonPropertyName("buildResultId")]
    public string? BuildResultId { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudBuildDeploymentSpecInitProviderQuota>? Quota { get; set; }
}

public enum V1beta1SpringCloudBuildDeploymentSpecManagementPoliciesEnum
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

public enum V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudBuildDeploymentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudBuildDeploymentSpecDeletionPolicyEnum>))]
    public V1beta1SpringCloudBuildDeploymentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudBuildDeploymentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudBuildDeploymentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudBuildDeploymentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudBuildDeploymentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpringCloudBuildDeploymentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudBuildDeploymentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentStatusAtProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 1Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentStatusAtProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Build Deployment.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>The ID of the Spring Cloud Build Result.</summary>
    [JsonPropertyName("buildResultId")]
    public string? BuildResultId { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Deployment as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>The ID of the Spring Cloud Build Deployment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Deployment. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudBuildDeploymentStatusAtProviderQuota>? Quota { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Build Deployment to be created.</summary>
    [JsonPropertyName("springCloudAppId")]
    public string? SpringCloudAppId { get; set; }
}

public partial class V1beta1SpringCloudBuildDeploymentStatusConditions
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

public partial class V1beta1SpringCloudBuildDeploymentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudBuildDeploymentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudBuildDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudBuildDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudBuildDeploymentSpec>, IStatus<V1beta1SpringCloudBuildDeploymentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudBuildDeployment";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudbuilddeployments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudBuildDeploymentSpec defines the desired state of SpringCloudBuildDeployment</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudBuildDeploymentSpec Spec { get; set; }

    /// <summary>SpringCloudBuildDeploymentStatus defines the observed state of SpringCloudBuildDeployment.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudBuildDeploymentStatus? Status { get; set; }
}