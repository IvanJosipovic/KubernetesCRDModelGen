using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.botservice.azure.upbound.io;
public enum V1beta1BotChannelDirectLineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BotChannelsRegistration in botservice to populate botName.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BotChannelsRegistration in botservice to populate botName.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BotChannelDirectLineSpecForProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary></summary>
public partial class V1beta1BotChannelDirectLineSpecForProvider
{
    /// <summary>The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>Reference to a BotChannelsRegistration in botservice to populate botName.</summary>
    [JsonPropertyName("botNameRef")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRef? BotNameRef { get; set; }

    /// <summary>Selector for a BotChannelsRegistration in botservice to populate botName.</summary>
    [JsonPropertyName("botNameSelector")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelector? BotNameSelector { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineSpecForProviderSite>? Site { get; set; }
}

/// <summary></summary>
public partial class V1beta1BotChannelDirectLineSpecInitProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BotChannelDirectLineSpecInitProvider
{
    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineSpecInitProviderSite>? Site { get; set; }
}

public enum V1beta1BotChannelDirectLineSpecManagementPoliciesEnum
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

public enum V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BotChannelDirectLineSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BotChannelDirectLineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BotChannelDirectLineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BotChannelDirectLineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BotChannelDirectLineSpec defines the desired state of BotChannelDirectLine</summary>
public partial class V1beta1BotChannelDirectLineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotChannelDirectLineSpecDeletionPolicyEnum>))]
    public V1beta1BotChannelDirectLineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BotChannelDirectLineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BotChannelDirectLineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BotChannelDirectLineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BotChannelDirectLineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BotChannelDirectLineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BotChannelDirectLineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BotChannelDirectLineStatusAtProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>Id for the site</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary></summary>
public partial class V1beta1BotChannelDirectLineStatusAtProvider
{
    /// <summary>The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>The Bot Channel ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineStatusAtProviderSite>? Site { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BotChannelDirectLineStatusConditions
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

/// <summary>BotChannelDirectLineStatus defines the observed state of BotChannelDirectLine.</summary>
public partial class V1beta1BotChannelDirectLineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BotChannelDirectLineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BotChannelDirectLineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BotChannelDirectLine is the Schema for the BotChannelDirectLines API. Manages an Directline integration for a Bot Channel</summary>
public partial class V1beta1BotChannelDirectLine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BotChannelDirectLineSpec>, IStatus<V1beta1BotChannelDirectLineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotChannelDirectLine";
    public const string KubeGroup = "botservice.azure.upbound.io";
    public const string KubePluralName = "botchanneldirectlines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BotChannelDirectLineSpec defines the desired state of BotChannelDirectLine</summary>
    [JsonPropertyName("spec")]
    public V1beta1BotChannelDirectLineSpec Spec { get; set; }

    /// <summary>BotChannelDirectLineStatus defines the observed state of BotChannelDirectLine.</summary>
    [JsonPropertyName("status")]
    public V1beta1BotChannelDirectLineStatus? Status { get; set; }
}