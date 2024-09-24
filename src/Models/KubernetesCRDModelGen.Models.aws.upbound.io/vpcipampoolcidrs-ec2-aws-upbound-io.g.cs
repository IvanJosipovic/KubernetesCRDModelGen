using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1VPCIpamPoolCidrSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProviderCidrAuthorizationContext
{
    /// <summary>The plain-text authorization message for the prefix and account.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The signed authorization message for the prefix and account.</summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPCIpamPoolCidrSpecForProvider
{
    /// <summary>The CIDR you want to assign to the pool. Conflicts with netmask_length.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>A signed document that proves that you are authorized to bring the specified IP address range to Amazon using BYOIP. This is not stored in the state file. See cidr_authorization_context for more information.</summary>
    [JsonPropertyName("cidrAuthorizationContext")]
    public IList<V1beta1VPCIpamPoolCidrSpecForProviderCidrAuthorizationContext>? CidrAuthorizationContext { get; set; }

    /// <summary>The ID of the pool to which you want to assign a CIDR.</summary>
    [JsonPropertyName("ipamPoolId")]
    public string? IpamPoolId { get; set; }

    /// <summary>Reference to a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
    [JsonPropertyName("ipamPoolIdRef")]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdRef? IpamPoolIdRef { get; set; }

    /// <summary>Selector for a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
    [JsonPropertyName("ipamPoolIdSelector")]
    public V1beta1VPCIpamPoolCidrSpecForProviderIpamPoolIdSelector? IpamPoolIdSelector { get; set; }

    /// <summary>If provided, the cidr provisioned into the specified pool will be the next available cidr given this declared netmask length. Conflicts with cidr.</summary>
    [JsonPropertyName("netmaskLength")]
    public double? NetmaskLength { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProviderCidrAuthorizationContext
{
    /// <summary>The plain-text authorization message for the prefix and account.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The signed authorization message for the prefix and account.</summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecInitProvider
{
    /// <summary>The CIDR you want to assign to the pool. Conflicts with netmask_length.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>A signed document that proves that you are authorized to bring the specified IP address range to Amazon using BYOIP. This is not stored in the state file. See cidr_authorization_context for more information.</summary>
    [JsonPropertyName("cidrAuthorizationContext")]
    public IList<V1beta1VPCIpamPoolCidrSpecInitProviderCidrAuthorizationContext>? CidrAuthorizationContext { get; set; }

    /// <summary>The ID of the pool to which you want to assign a CIDR.</summary>
    [JsonPropertyName("ipamPoolId")]
    public string? IpamPoolId { get; set; }

    /// <summary>Reference to a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
    [JsonPropertyName("ipamPoolIdRef")]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdRef? IpamPoolIdRef { get; set; }

    /// <summary>Selector for a VPCIpamPool in ec2 to populate ipamPoolId.</summary>
    [JsonPropertyName("ipamPoolIdSelector")]
    public V1beta1VPCIpamPoolCidrSpecInitProviderIpamPoolIdSelector? IpamPoolIdSelector { get; set; }

    /// <summary>If provided, the cidr provisioned into the specified pool will be the next available cidr given this declared netmask length. Conflicts with cidr.</summary>
    [JsonPropertyName("netmaskLength")]
    public double? NetmaskLength { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecManagementPoliciesEnum
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

public enum V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VPCIpamPoolCidrSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPCIpamPoolCidrSpec defines the desired state of VPCIpamPoolCidr</summary>
public partial class V1beta1VPCIpamPoolCidrSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCIpamPoolCidrSpecDeletionPolicyEnum>))]
    public V1beta1VPCIpamPoolCidrSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCIpamPoolCidrSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCIpamPoolCidrSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPCIpamPoolCidrSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCIpamPoolCidrSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPCIpamPoolCidrSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCIpamPoolCidrSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPCIpamPoolCidrStatusAtProviderCidrAuthorizationContext
{
    /// <summary>The plain-text authorization message for the prefix and account.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The signed authorization message for the prefix and account.</summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPCIpamPoolCidrStatusAtProvider
{
    /// <summary>The CIDR you want to assign to the pool. Conflicts with netmask_length.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>A signed document that proves that you are authorized to bring the specified IP address range to Amazon using BYOIP. This is not stored in the state file. See cidr_authorization_context for more information.</summary>
    [JsonPropertyName("cidrAuthorizationContext")]
    public IList<V1beta1VPCIpamPoolCidrStatusAtProviderCidrAuthorizationContext>? CidrAuthorizationContext { get; set; }

    /// <summary>The ID of the IPAM Pool Cidr concatenated with the IPAM Pool ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique ID generated by AWS for the pool cidr.</summary>
    [JsonPropertyName("ipamPoolCidrId")]
    public string? IpamPoolCidrId { get; set; }

    /// <summary>The ID of the pool to which you want to assign a CIDR.</summary>
    [JsonPropertyName("ipamPoolId")]
    public string? IpamPoolId { get; set; }

    /// <summary>If provided, the cidr provisioned into the specified pool will be the next available cidr given this declared netmask length. Conflicts with cidr.</summary>
    [JsonPropertyName("netmaskLength")]
    public double? NetmaskLength { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VPCIpamPoolCidrStatusConditions
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

/// <summary>VPCIpamPoolCidrStatus defines the observed state of VPCIpamPoolCidr.</summary>
public partial class V1beta1VPCIpamPoolCidrStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCIpamPoolCidrStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCIpamPoolCidrStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VPCIpamPoolCidr is the Schema for the VPCIpamPoolCidrs API. Provisions a CIDR from an IPAM address pool.</summary>
public partial class V1beta1VPCIpamPoolCidr : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCIpamPoolCidrSpec>, IStatus<V1beta1VPCIpamPoolCidrStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCIpamPoolCidr";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "vpcipampoolcidrs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCIpamPoolCidrSpec defines the desired state of VPCIpamPoolCidr</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCIpamPoolCidrSpec Spec { get; set; }

    /// <summary>VPCIpamPoolCidrStatus defines the observed state of VPCIpamPoolCidr.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCIpamPoolCidrStatus? Status { get; set; }
}