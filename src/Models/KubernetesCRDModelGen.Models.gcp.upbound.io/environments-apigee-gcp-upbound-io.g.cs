using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.gcp.upbound.io;
public enum V1beta1EnvironmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1EnvironmentSpecForProviderNodeConfig
{
    /// <summary>The maximum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended maximum number of nodes for that gateway.</summary>
    [JsonPropertyName("maxNodeCount")]
    public string? MaxNodeCount { get; set; }

    /// <summary>The minimum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended minimum number of nodes for that gateway.</summary>
    [JsonPropertyName("minNodeCount")]
    public string? MinNodeCount { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderOrgIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderOrgIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderOrgIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderOrgIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderOrgIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderOrgIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecForProvider
{
    /// <summary>Optional. API Proxy type supported by the environment. The type can be set when creating the Environment and cannot be changed. Possible values are: API_PROXY_TYPE_UNSPECIFIED, PROGRAMMABLE, CONFIGURABLE.</summary>
    [JsonPropertyName("apiProxyType")]
    public string? ApiProxyType { get; set; }

    /// <summary>Optional. Deployment type supported by the environment. The deployment type can be set when creating the environment and cannot be changed. When you enable archive deployment, you will be prevented from performing a subset of actions within the environment, including: Managing the deployment of API proxy or shared flow revisions; Creating, updating, or deleting resource files; Creating, updating, or deleting target servers. Possible values are: DEPLOYMENT_TYPE_UNSPECIFIED, PROXY, ARCHIVE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>Description of the environment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name of the environment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of "http" or "https", and the port must be supplied.</summary>
    [JsonPropertyName("forwardProxyUri")]
    public string? ForwardProxyUri { get; set; }

    /// <summary>NodeConfig for setting the min/max number of nodes associated with the environment. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentSpecForProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>The Apigee Organization associated with the Apigee environment, in the format organizations/{{org_name}}.</summary>
    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>Reference to a Organization in apigee to populate orgId.</summary>
    [JsonPropertyName("orgIdRef")]
    public V1beta1EnvironmentSpecForProviderOrgIdRef? OrgIdRef { get; set; }

    /// <summary>Selector for a Organization in apigee to populate orgId.</summary>
    [JsonPropertyName("orgIdSelector")]
    public V1beta1EnvironmentSpecForProviderOrgIdSelector? OrgIdSelector { get; set; }

    /// <summary>Types that can be selected for an Environment. Each of the types are limited by capability and capacity. Refer to Apigee's public documentation to understand about each of these types in details. An Apigee org can support heterogeneous Environments. Possible values are: ENVIRONMENT_TYPE_UNSPECIFIED, BASE, INTERMEDIATE, COMPREHENSIVE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderNodeConfig
{
    /// <summary>The maximum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended maximum number of nodes for that gateway.</summary>
    [JsonPropertyName("maxNodeCount")]
    public string? MaxNodeCount { get; set; }

    /// <summary>The minimum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended minimum number of nodes for that gateway.</summary>
    [JsonPropertyName("minNodeCount")]
    public string? MinNodeCount { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProvider
{
    /// <summary>Optional. API Proxy type supported by the environment. The type can be set when creating the Environment and cannot be changed. Possible values are: API_PROXY_TYPE_UNSPECIFIED, PROGRAMMABLE, CONFIGURABLE.</summary>
    [JsonPropertyName("apiProxyType")]
    public string? ApiProxyType { get; set; }

    /// <summary>Optional. Deployment type supported by the environment. The deployment type can be set when creating the environment and cannot be changed. When you enable archive deployment, you will be prevented from performing a subset of actions within the environment, including: Managing the deployment of API proxy or shared flow revisions; Creating, updating, or deleting resource files; Creating, updating, or deleting target servers. Possible values are: DEPLOYMENT_TYPE_UNSPECIFIED, PROXY, ARCHIVE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>Description of the environment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name of the environment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of "http" or "https", and the port must be supplied.</summary>
    [JsonPropertyName("forwardProxyUri")]
    public string? ForwardProxyUri { get; set; }

    /// <summary>NodeConfig for setting the min/max number of nodes associated with the environment. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>Types that can be selected for an Environment. Each of the types are limited by capability and capacity. Refer to Apigee's public documentation to understand about each of these types in details. An Apigee org can support heterogeneous Environments. Possible values are: ENVIRONMENT_TYPE_UNSPECIFIED, BASE, INTERMEDIATE, COMPREHENSIVE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1EnvironmentSpecManagementPoliciesEnum
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

public enum V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1EnvironmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1EnvironmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecDeletionPolicyEnum>))]
    public V1beta1EnvironmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EnvironmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EnvironmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderNodeConfig
{
    /// <summary>(Output) The current total number of gateway nodes that each environment currently has across all instances.</summary>
    [JsonPropertyName("currentAggregateNodeCount")]
    public string? CurrentAggregateNodeCount { get; set; }

    /// <summary>The maximum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended maximum number of nodes for that gateway.</summary>
    [JsonPropertyName("maxNodeCount")]
    public string? MaxNodeCount { get; set; }

    /// <summary>The minimum total number of gateway nodes that the is reserved for all instances that has the specified environment. If not specified, the default is determined by the recommended minimum number of nodes for that gateway.</summary>
    [JsonPropertyName("minNodeCount")]
    public string? MinNodeCount { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProvider
{
    /// <summary>Optional. API Proxy type supported by the environment. The type can be set when creating the Environment and cannot be changed. Possible values are: API_PROXY_TYPE_UNSPECIFIED, PROGRAMMABLE, CONFIGURABLE.</summary>
    [JsonPropertyName("apiProxyType")]
    public string? ApiProxyType { get; set; }

    /// <summary>Optional. Deployment type supported by the environment. The deployment type can be set when creating the environment and cannot be changed. When you enable archive deployment, you will be prevented from performing a subset of actions within the environment, including: Managing the deployment of API proxy or shared flow revisions; Creating, updating, or deleting resource files; Creating, updating, or deleting target servers. Possible values are: DEPLOYMENT_TYPE_UNSPECIFIED, PROXY, ARCHIVE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>Description of the environment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name of the environment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of "http" or "https", and the port must be supplied.</summary>
    [JsonPropertyName("forwardProxyUri")]
    public string? ForwardProxyUri { get; set; }

    /// <summary>an identifier for the resource with format {{org_id}}/environments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>NodeConfig for setting the min/max number of nodes associated with the environment. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>The Apigee Organization associated with the Apigee environment, in the format organizations/{{org_name}}.</summary>
    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>Types that can be selected for an Environment. Each of the types are limited by capability and capacity. Refer to Apigee's public documentation to understand about each of these types in details. An Apigee org can support heterogeneous Environments. Possible values are: ENVIRONMENT_TYPE_UNSPECIFIED, BASE, INTERMEDIATE, COMPREHENSIVE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EnvironmentStatusConditions
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

public partial class V1beta1EnvironmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Environment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvironmentSpec>, IStatus<V1beta1EnvironmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Environment";
    public const string KubeGroup = "apigee.gcp.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentSpec defines the desired state of Environment</summary>
    [JsonPropertyName("spec")]
    public V1beta1EnvironmentSpec Spec { get; set; }

    /// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvironmentStatus? Status { get; set; }
}