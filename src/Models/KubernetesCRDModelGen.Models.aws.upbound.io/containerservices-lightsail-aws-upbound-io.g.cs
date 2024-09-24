using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lightsail.aws.upbound.io;
public enum V1beta1ContainerServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecForProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>A Boolean value that indicates whether to activate the role. The default is false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecForProviderPrivateRegistryAccess
{
    /// <summary>Describes a request to configure an Amazon Lightsail container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See ECR Image Puller Role below for more details.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceSpecForProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecForProviderPublicDomainNamesCertificate
{
    /// <summary>The name for the container service. Names must be of length 1 to 63, and be unique within each AWS Region in your Lightsail account.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecForProviderPublicDomainNames
{
    /// <summary></summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceSpecForProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecForProvider
{
    /// <summary>A Boolean value indicating whether the container service is disabled. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>The power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>An object to describe the configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See Private Registry Access below for more details.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceSpecForProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>The public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. Defined below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceSpecForProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>A Boolean value that indicates whether to activate the role. The default is false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccess
{
    /// <summary>Describes a request to configure an Amazon Lightsail container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See ECR Image Puller Role below for more details.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecInitProviderPublicDomainNamesCertificate
{
    /// <summary>The name for the container service. Names must be of length 1 to 63, and be unique within each AWS Region in your Lightsail account.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceSpecInitProviderPublicDomainNames
{
    /// <summary></summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceSpecInitProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ContainerServiceSpecInitProvider
{
    /// <summary>A Boolean value indicating whether the container service is disabled. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>The power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>An object to describe the configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See Private Registry Access below for more details.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>The public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. Defined below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceSpecInitProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>The scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ContainerServiceSpecManagementPoliciesEnum
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

public enum V1beta1ContainerServiceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContainerServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContainerServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ContainerServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ContainerServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ContainerServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ContainerServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ContainerServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ContainerServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ContainerServiceSpec defines the desired state of ContainerService</summary>
public partial class V1beta1ContainerServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerServiceSpecDeletionPolicyEnum>))]
    public V1beta1ContainerServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContainerServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContainerServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ContainerServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ContainerServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>A Boolean value that indicates whether to activate the role. The default is false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    /// <summary>The principal ARN of the container service. The principal ARN can be used to create a trust relationship between your standard AWS account and your Lightsail container service. This allows you to give your service permission to access resources in your standard AWS account.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccess
{
    /// <summary>Describes a request to configure an Amazon Lightsail container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See ECR Image Puller Role below for more details.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceStatusAtProviderPublicDomainNamesCertificate
{
    /// <summary>The name for the container service. Names must be of length 1 to 63, and be unique within each AWS Region in your Lightsail account.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceStatusAtProviderPublicDomainNames
{
    /// <summary></summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceStatusAtProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContainerServiceStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the container service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Availability Zone. Follows the format us-east-2a (case-sensitive).</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A Boolean value indicating whether the container service is disabled. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>The power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>The ID of the power of the container service.</summary>
    [JsonPropertyName("powerId")]
    public string? PowerId { get; set; }

    /// <summary>The principal ARN of the container service. The principal ARN can be used to create a trust relationship between your standard AWS account and your Lightsail container service. This allows you to give your service permission to access resources in your standard AWS account.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }

    /// <summary>The private domain name of the container service. The private domain name is accessible only by other resources within the default virtual private cloud (VPC) of your Lightsail account.</summary>
    [JsonPropertyName("privateDomainName")]
    public string? PrivateDomainName { get; set; }

    /// <summary>An object to describe the configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See Private Registry Access below for more details.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>The public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. Defined below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceStatusAtProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>The Lightsail resource type of the container service (i.e., ContainerService).</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>The scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>The current state of the container service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The publicly accessible URL of the container service. If no public endpoint is specified in the currentDeployment, this URL returns a 404 response.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ContainerServiceStatusConditions
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

/// <summary>ContainerServiceStatus defines the observed state of ContainerService.</summary>
public partial class V1beta1ContainerServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ContainerServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ContainerService is the Schema for the ContainerServices API. Provides a resource to manage Lightsail container service</summary>
public partial class V1beta1ContainerService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerServiceSpec>, IStatus<V1beta1ContainerServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerService";
    public const string KubeGroup = "lightsail.aws.upbound.io";
    public const string KubePluralName = "containerservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerServiceSpec defines the desired state of ContainerService</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContainerServiceSpec Spec { get; set; }

    /// <summary>ContainerServiceStatus defines the observed state of ContainerService.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerServiceStatus? Status { get; set; }
}