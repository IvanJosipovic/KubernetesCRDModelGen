using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
public enum V1beta1SpringCloudAPIPortalCustomDomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecForProvider
{
    /// <summary>The name which should be used for this Spring Cloud API Portal Domain. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Spring Cloud API Portal. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("springCloudApiPortalId")]
    public string? SpringCloudApiPortalId { get; set; }

    /// <summary>Reference to a SpringCloudAPIPortal in appplatform to populate springCloudApiPortalId.</summary>
    [JsonPropertyName("springCloudApiPortalIdRef")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdRef? SpringCloudApiPortalIdRef { get; set; }

    /// <summary>Selector for a SpringCloudAPIPortal in appplatform to populate springCloudApiPortalId.</summary>
    [JsonPropertyName("springCloudApiPortalIdSelector")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProviderSpringCloudApiPortalIdSelector? SpringCloudApiPortalIdSelector { get; set; }

    /// <summary>Specifies the thumbprint of the Spring Cloud Certificate that binds to the Spring Cloud API Portal Domain.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecInitProvider
{
    /// <summary>The name which should be used for this Spring Cloud API Portal Domain. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Spring Cloud API Portal. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("springCloudApiPortalId")]
    public string? SpringCloudApiPortalId { get; set; }

    /// <summary>Reference to a SpringCloudAPIPortal in appplatform to populate springCloudApiPortalId.</summary>
    [JsonPropertyName("springCloudApiPortalIdRef")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdRef? SpringCloudApiPortalIdRef { get; set; }

    /// <summary>Selector for a SpringCloudAPIPortal in appplatform to populate springCloudApiPortalId.</summary>
    [JsonPropertyName("springCloudApiPortalIdSelector")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProviderSpringCloudApiPortalIdSelector? SpringCloudApiPortalIdSelector { get; set; }

    /// <summary>Specifies the thumbprint of the Spring Cloud Certificate that binds to the Spring Cloud API Portal Domain.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecManagementPoliciesEnum
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

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudAPIPortalCustomDomainSpecDeletionPolicyEnum>))]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudAPIPortalCustomDomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainStatusAtProvider
{
    /// <summary>The ID of the Spring Cloud API Portal Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name which should be used for this Spring Cloud API Portal Domain. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Spring Cloud API Portal. Changing this forces a new Spring Cloud API Portal Domain to be created.</summary>
    [JsonPropertyName("springCloudApiPortalId")]
    public string? SpringCloudApiPortalId { get; set; }

    /// <summary>Specifies the thumbprint of the Spring Cloud Certificate that binds to the Spring Cloud API Portal Domain.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1SpringCloudAPIPortalCustomDomainStatusConditions
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

public partial class V1beta1SpringCloudAPIPortalCustomDomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudAPIPortalCustomDomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudAPIPortalCustomDomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudAPIPortalCustomDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudAPIPortalCustomDomainSpec>, IStatus<V1beta1SpringCloudAPIPortalCustomDomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAPIPortalCustomDomain";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudapiportalcustomdomains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudAPIPortalCustomDomainSpec defines the desired state of SpringCloudAPIPortalCustomDomain</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudAPIPortalCustomDomainSpec Spec { get; set; }

    /// <summary>SpringCloudAPIPortalCustomDomainStatus defines the observed state of SpringCloudAPIPortalCustomDomain.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudAPIPortalCustomDomainStatus? Status { get; set; }
}