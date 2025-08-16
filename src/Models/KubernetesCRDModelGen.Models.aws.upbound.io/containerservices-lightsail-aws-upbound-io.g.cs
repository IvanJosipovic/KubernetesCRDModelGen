using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lightsail.aws.upbound.io;
/// <summary>ContainerService is the Schema for the ContainerServices API. Manages a Lightsail container service for running containerized applications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerServiceList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ContainerService> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecForProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>Whether to activate the role. Defaults to false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecForProviderPrivateRegistryAccess
{
    /// <summary>Configuration to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceSpecForProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecForProviderPublicDomainNamesCertificate
{
    /// <summary>Name of the certificate.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>List of domain names for the certificate.</summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecForProviderPublicDomainNames
{
    /// <summary>Set of certificate configurations for the public domain names. Each element contains the following attributes:</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceSpecForProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecForProvider
{
    /// <summary>Whether to disable the container service. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>Power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>Configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceSpecForProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>Public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. See below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceSpecForProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>Whether to activate the role. Defaults to false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccess
{
    /// <summary>Configuration to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecInitProviderPublicDomainNamesCertificate
{
    /// <summary>Name of the certificate.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>List of domain names for the certificate.</summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecInitProviderPublicDomainNames
{
    /// <summary>Set of certificate configurations for the public domain names. Each element contains the following attributes:</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceSpecInitProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecInitProvider
{
    /// <summary>Whether to disable the container service. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>Power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>Configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceSpecInitProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>Public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. See below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceSpecInitProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>Scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpecProviderConfigRefPolicy
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
public partial class V1beta1ContainerServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContainerServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContainerServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccessEcrImagePullerRole
{
    /// <summary>Whether to activate the role. Defaults to false.</summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    /// <summary>Principal ARN of the container service. The principal ARN can be used to create a trust relationship between your standard AWS account and your Lightsail container service. This allows you to give your service permission to access resources in your standard AWS account.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccess
{
    /// <summary>Configuration to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("ecrImagePullerRole")]
    public IList<V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccessEcrImagePullerRole>? EcrImagePullerRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceStatusAtProviderPublicDomainNamesCertificate
{
    /// <summary>Name of the certificate.</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>List of domain names for the certificate.</summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceStatusAtProviderPublicDomainNames
{
    /// <summary>Set of certificate configurations for the public domain names. Each element contains the following attributes:</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ContainerServiceStatusAtProviderPublicDomainNamesCertificate>? Certificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerServiceStatusAtProvider
{
    /// <summary>ARN of the container service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Availability Zone. Follows the format us-east-2a (case-sensitive).</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Date and time when the container service was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to disable the container service. Defaults to false.</summary>
    [JsonPropertyName("isDisabled")]
    public bool? IsDisabled { get; set; }

    /// <summary>Power specification for the container service. The power specifies the amount of memory, the number of vCPUs, and the monthly price of each node of the container service. Possible values: nano, micro, small, medium, large, xlarge.</summary>
    [JsonPropertyName("power")]
    public string? Power { get; set; }

    /// <summary>Power ID of the container service.</summary>
    [JsonPropertyName("powerId")]
    public string? PowerId { get; set; }

    /// <summary>Principal ARN of the container service. The principal ARN can be used to create a trust relationship between your standard AWS account and your Lightsail container service. This allows you to give your service permission to access resources in your standard AWS account.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }

    /// <summary>Private domain name of the container service. The private domain name is accessible only by other resources within the default virtual private cloud (VPC) of your Lightsail account.</summary>
    [JsonPropertyName("privateDomainName")]
    public string? PrivateDomainName { get; set; }

    /// <summary>Configuration for the container service to access private container image repositories, such as Amazon Elastic Container Registry (Amazon ECR) private repositories. See below.</summary>
    [JsonPropertyName("privateRegistryAccess")]
    public IList<V1beta1ContainerServiceStatusAtProviderPrivateRegistryAccess>? PrivateRegistryAccess { get; set; }

    /// <summary>Public domain names to use with the container service, such as example.com and www.example.com. You can specify up to four public domain names for a container service. The domain names that you specify are used when you create a deployment with a container configured as the public endpoint of your container service. If you don't specify public domain names, then you can use the default domain of the container service. See below.</summary>
    [JsonPropertyName("publicDomainNames")]
    public IList<V1beta1ContainerServiceStatusAtProviderPublicDomainNames>? PublicDomainNames { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Lightsail resource type of the container service (i.e., ContainerService).</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scale specification for the container service. The scale specifies the allocated compute nodes of the container service.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }

    /// <summary>Current state of the container service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Publicly accessible URL of the container service. If no public endpoint is specified in the currentDeployment, this URL returns a 404 response.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>ContainerService is the Schema for the ContainerServices API. Manages a Lightsail container service for running containerized applications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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