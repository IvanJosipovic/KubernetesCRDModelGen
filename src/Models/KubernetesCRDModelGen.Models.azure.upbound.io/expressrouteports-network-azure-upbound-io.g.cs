using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1ExpressRoutePortSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecForProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecForProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecForProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortSpecForProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortSpecForProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>The name of the Resource Group where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecInitProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortSpecInitProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ExpressRoutePortSpecInitProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ExpressRoutePortSpecManagementPoliciesEnum
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

public enum V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ExpressRoutePortSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ExpressRoutePortSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ExpressRoutePortSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ExpressRoutePortSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ExpressRoutePortSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ExpressRoutePortSpec defines the desired state of ExpressRoutePort</summary>
public partial class V1beta1ExpressRoutePortSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecDeletionPolicyEnum>))]
    public V1beta1ExpressRoutePortSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ExpressRoutePortSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ExpressRoutePortSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ExpressRoutePortSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExpressRoutePortSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ExpressRoutePortSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExpressRoutePortSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortStatusAtProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The connector type of the Express Route Port Link.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>The ID of this Express Route Port Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The interface name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }

    /// <summary>The ID that maps from the Express Route Port Link to the patch panel port.</summary>
    [JsonPropertyName("patchPanelId")]
    public string? PatchPanelId { get; set; }

    /// <summary>The ID that maps from the patch panel port to the rack.</summary>
    [JsonPropertyName("rackId")]
    public string? RackId { get; set; }

    /// <summary>The name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("routerName")]
    public string? RouterName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortStatusAtProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The connector type of the Express Route Port Link.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>The ID of this Express Route Port Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The interface name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }

    /// <summary>The ID that maps from the Express Route Port Link to the patch panel port.</summary>
    [JsonPropertyName("patchPanelId")]
    public string? PatchPanelId { get; set; }

    /// <summary>The ID that maps from the patch panel port to the rack.</summary>
    [JsonPropertyName("rackId")]
    public string? RackId { get; set; }

    /// <summary>The name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("routerName")]
    public string? RouterName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ExpressRoutePortStatusAtProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>The EtherType of the Express Route Port.</summary>
    [JsonPropertyName("ethertype")]
    public string? Ethertype { get; set; }

    /// <summary>The resource GUID of the Express Route Port.</summary>
    [JsonPropertyName("guid")]
    public string? Guid { get; set; }

    /// <summary>The ID of the Express Route Port.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum transmission unit of the Express Route Port.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>The name of the Resource Group where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ExpressRoutePortStatusConditions
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

/// <summary>ExpressRoutePortStatus defines the observed state of ExpressRoutePort.</summary>
public partial class V1beta1ExpressRoutePortStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ExpressRoutePortStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExpressRoutePortStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ExpressRoutePort is the Schema for the ExpressRoutePorts API. Manages a Express Route Port.</summary>
public partial class V1beta1ExpressRoutePort : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExpressRoutePortSpec>, IStatus<V1beta1ExpressRoutePortStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRoutePort";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressrouteports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRoutePortSpec defines the desired state of ExpressRoutePort</summary>
    [JsonPropertyName("spec")]
    public V1beta1ExpressRoutePortSpec Spec { get; set; }

    /// <summary>ExpressRoutePortStatus defines the observed state of ExpressRoutePort.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExpressRoutePortStatus? Status { get; set; }
}