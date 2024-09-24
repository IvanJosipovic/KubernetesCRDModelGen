using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.upbound.io;
public enum V1beta1DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

public enum V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1DomainSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1DomainSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecForProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1DomainSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1DomainSpecForProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1DomainSpecForProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1DomainSpecForProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1DomainSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1DomainSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainSpecInitProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DomainSpecInitProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1DomainSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1DomainSpecInitProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1DomainSpecInitProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1DomainSpecInitProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1DomainSpecManagementPoliciesEnum
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

public enum V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DomainSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
public partial class V1beta1DomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecDeletionPolicyEnum>))]
    public V1beta1DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
public partial class V1beta1DomainStatusAtProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>The Endpoint associated with the EventGrid Domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The ID of the EventGrid Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1DomainStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1DomainStatusAtProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1DomainStatusAtProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1DomainStatusAtProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
public partial class V1beta1DomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Domain is the Schema for the Domains API. Manages an EventGrid Domain</summary>
public partial class V1beta1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSpec>, IStatus<V1beta1DomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainStatus? Status { get; set; }
}