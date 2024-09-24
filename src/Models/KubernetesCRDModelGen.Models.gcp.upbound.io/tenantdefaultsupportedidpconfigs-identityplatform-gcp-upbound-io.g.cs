using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.gcp.upbound.io;
public enum V1beta1TenantDefaultSupportedIdPConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderClientIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecForProvider
{
    /// <summary>OAuth client ID</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>OAuth client secret</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>If this IDP allows the user to sign in</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the IDP. Possible values include:</summary>
    [JsonPropertyName("idpId")]
    public string? IdpId { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the tenant where this DefaultSupportedIdpConfig resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProviderTenantSelector? TenantSelector { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderClientIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecInitProvider
{
    /// <summary>OAuth client ID</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderClientIdSecretRef ClientIdSecretRef { get; set; }

    /// <summary>OAuth client secret</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>If this IDP allows the user to sign in</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the IDP. Possible values include:</summary>
    [JsonPropertyName("idpId")]
    public string? IdpId { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the tenant where this DefaultSupportedIdpConfig resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProviderTenantSelector? TenantSelector { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecManagementPoliciesEnum
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

public enum V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantDefaultSupportedIdPConfigSpecDeletionPolicyEnum>))]
    public V1beta1TenantDefaultSupportedIdPConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TenantDefaultSupportedIdPConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TenantDefaultSupportedIdPConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigStatusAtProvider
{
    /// <summary>If this IDP allows the user to sign in</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/tenants/{{tenant}}/defaultSupportedIdpConfigs/{{idp_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ID of the IDP. Possible values include:</summary>
    [JsonPropertyName("idpId")]
    public string? IdpId { get; set; }

    /// <summary>The name of the default supported IDP config resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the tenant where this DefaultSupportedIdpConfig resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

public partial class V1beta1TenantDefaultSupportedIdPConfigStatusConditions
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

public partial class V1beta1TenantDefaultSupportedIdPConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TenantDefaultSupportedIdPConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TenantDefaultSupportedIdPConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TenantDefaultSupportedIdPConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TenantDefaultSupportedIdPConfigSpec>, IStatus<V1beta1TenantDefaultSupportedIdPConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TenantDefaultSupportedIdPConfig";
    public const string KubeGroup = "identityplatform.gcp.upbound.io";
    public const string KubePluralName = "tenantdefaultsupportedidpconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TenantDefaultSupportedIdPConfigSpec defines the desired state of TenantDefaultSupportedIdPConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1TenantDefaultSupportedIdPConfigSpec Spec { get; set; }

    /// <summary>TenantDefaultSupportedIdPConfigStatus defines the observed state of TenantDefaultSupportedIdPConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1TenantDefaultSupportedIdPConfigStatus? Status { get; set; }
}