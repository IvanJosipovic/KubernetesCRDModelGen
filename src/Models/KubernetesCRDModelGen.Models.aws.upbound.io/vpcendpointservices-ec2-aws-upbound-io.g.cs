using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1VPCEndpointServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1VPCEndpointServiceSpecForProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpecInitProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1VPCEndpointServiceSpecManagementPoliciesEnum
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

public enum V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1VPCEndpointServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1VPCEndpointServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointServiceSpecDeletionPolicyEnum>))]
    public V1beta1VPCEndpointServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCEndpointServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCEndpointServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPCEndpointServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCEndpointServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPCEndpointServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCEndpointServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1VPCEndpointServiceStatusAtProviderPrivateDnsNameConfiguration
{
    /// <summary>Name of the record subdomain the service provider needs to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The state of the VPC endpoint service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Endpoint service verification type, for example TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value the service provider adds to the private DNS name domain record before verification.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1VPCEndpointServiceStatusAtProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>The ARNs of one or more principals allowed to discover the endpoint service.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public IList<string>? AllowedPrincipals { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the VPC endpoint service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A set of Availability Zones in which the service is available.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>A set of DNS names for the service.</summary>
    [JsonPropertyName("baseEndpointDnsNames")]
    public IList<string>? BaseEndpointDnsNames { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>The ID of the VPC endpoint service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether or not the service manages its VPC endpoints - true or false.</summary>
    [JsonPropertyName("managesVpcEndpoints")]
    public bool? ManagesVpcEndpoints { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>List of objects containing information about the endpoint service private DNS name configuration.</summary>
    [JsonPropertyName("privateDnsNameConfiguration")]
    public IList<V1beta1VPCEndpointServiceStatusAtProviderPrivateDnsNameConfiguration>? PrivateDnsNameConfiguration { get; set; }

    /// <summary>The service name.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The service type, Gateway or Interface.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }

    /// <summary>The state of the VPC endpoint service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

public partial class V1beta1VPCEndpointServiceStatusConditions
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

public partial class V1beta1VPCEndpointServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCEndpointServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCEndpointServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCEndpointService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCEndpointServiceSpec>, IStatus<V1beta1VPCEndpointServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCEndpointService";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "vpcendpointservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCEndpointServiceSpec defines the desired state of VPCEndpointService</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCEndpointServiceSpec Spec { get; set; }

    /// <summary>VPCEndpointServiceStatus defines the observed state of VPCEndpointService.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCEndpointServiceStatus? Status { get; set; }
}