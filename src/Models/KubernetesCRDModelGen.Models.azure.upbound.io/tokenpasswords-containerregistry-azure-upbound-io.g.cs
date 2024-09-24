using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerregistry.azure.upbound.io;
public enum V1beta1TokenPasswordSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordSpecForProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordSpecForProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordSpecForProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdRef")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRef? ContainerRegistryTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdSelector")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelector? ContainerRegistryTokenIdSelector { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public IList<V1beta1TokenPasswordSpecForProviderPassword1>? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public IList<V1beta1TokenPasswordSpecForProviderPassword2>? Password2 { get; set; }
}

public enum V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordSpecInitProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordSpecInitProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1TokenPasswordSpecInitProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdRef")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRef? ContainerRegistryTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdSelector")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelector? ContainerRegistryTokenIdSelector { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public IList<V1beta1TokenPasswordSpecInitProviderPassword1>? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public IList<V1beta1TokenPasswordSpecInitProviderPassword2>? Password2 { get; set; }
}

public enum V1beta1TokenPasswordSpecManagementPoliciesEnum
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

public enum V1beta1TokenPasswordSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1TokenPasswordSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1TokenPasswordSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1TokenPasswordSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TokenPasswordSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1TokenPasswordSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TokenPasswordSpec defines the desired state of TokenPassword</summary>
public partial class V1beta1TokenPasswordSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TokenPasswordSpecDeletionPolicyEnum>))]
    public V1beta1TokenPasswordSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TokenPasswordSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TokenPasswordSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TokenPasswordSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TokenPasswordSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TokenPasswordSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TokenPasswordSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordStatusAtProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordStatusAtProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}

/// <summary></summary>
public partial class V1beta1TokenPasswordStatusAtProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>The ID of the Container Registry Token Password.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public IList<V1beta1TokenPasswordStatusAtProviderPassword1>? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public IList<V1beta1TokenPasswordStatusAtProviderPassword2>? Password2 { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1TokenPasswordStatusConditions
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

/// <summary>TokenPasswordStatus defines the observed state of TokenPassword.</summary>
public partial class V1beta1TokenPasswordStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TokenPasswordStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TokenPasswordStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>TokenPassword is the Schema for the TokenPasswords API. Manages a Container Registry Token Password.</summary>
public partial class V1beta1TokenPassword : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TokenPasswordSpec>, IStatus<V1beta1TokenPasswordStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TokenPassword";
    public const string KubeGroup = "containerregistry.azure.upbound.io";
    public const string KubePluralName = "tokenpasswords";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TokenPasswordSpec defines the desired state of TokenPassword</summary>
    [JsonPropertyName("spec")]
    public V1beta1TokenPasswordSpec Spec { get; set; }

    /// <summary>TokenPasswordStatus defines the observed state of TokenPassword.</summary>
    [JsonPropertyName("status")]
    public V1beta1TokenPasswordStatus? Status { get; set; }
}