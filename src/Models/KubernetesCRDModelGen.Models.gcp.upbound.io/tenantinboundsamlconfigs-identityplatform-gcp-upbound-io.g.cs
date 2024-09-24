using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.gcp.upbound.io;
public enum V1beta1TenantInboundSAMLConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificatesX509CertificateSecretRef
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

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificates
{
    /// <summary>(Output) The x509 certificate</summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfig
{
    /// <summary>The IDP's certificate data to verify the signature in the SAMLResponse issued by the IDP. Structure is documented below.</summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecForProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>SAML IdP configuration when the project acts as the relying party Structure is documented below.</summary>
    [JsonPropertyName("idpConfig")]
    public IList<V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfig>? IdpConfig { get; set; }

    /// <summary>The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters, hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an alphanumeric character, and have at least 2 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SAML SP (Service Provider) configuration when the project acts as the relying party to receive and accept an authentication assertion issued by a SAML identity provider. Structure is documented below.</summary>
    [JsonPropertyName("spConfig")]
    public IList<V1beta1TenantInboundSAMLConfigSpecForProviderSpConfig>? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelector? TenantSelector { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificatesX509CertificateSecretRef
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

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificates
{
    /// <summary>(Output) The x509 certificate</summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfig
{
    /// <summary>The IDP's certificate data to verify the signature in the SAMLResponse issued by the IDP. Structure is documented below.</summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecInitProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>SAML IdP configuration when the project acts as the relying party Structure is documented below.</summary>
    [JsonPropertyName("idpConfig")]
    public IList<V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfig>? IdpConfig { get; set; }

    /// <summary>The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters, hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an alphanumeric character, and have at least 2 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SAML SP (Service Provider) configuration when the project acts as the relying party to receive and accept an authentication assertion issued by a SAML identity provider. Structure is documented below.</summary>
    [JsonPropertyName("spConfig")]
    public IList<V1beta1TenantInboundSAMLConfigSpecInitProviderSpConfig>? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelector? TenantSelector { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecManagementPoliciesEnum
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

public enum V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecDeletionPolicyEnum>))]
    public V1beta1TenantInboundSAMLConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TenantInboundSAMLConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TenantInboundSAMLConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TenantInboundSAMLConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TenantInboundSAMLConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TenantInboundSAMLConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TenantInboundSAMLConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificatesX509CertificateSecretRef
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

public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificates
{
    /// <summary>(Output) The x509 certificate</summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfig
{
    /// <summary>The IDP's certificate data to verify the signature in the SAMLResponse issued by the IDP. Structure is documented below.</summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfigSpCertificates
{
    /// <summary>(Output) The x509 certificate</summary>
    [JsonPropertyName("x509Certificate")]
    public string? X509Certificate { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>(Output) The IDP's certificate data to verify the signature in the SAMLResponse issued by the IDP. Structure is documented below.</summary>
    [JsonPropertyName("spCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfigSpCertificates>? SpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusAtProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/tenants/{{tenant}}/inboundSamlConfigs/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SAML IdP configuration when the project acts as the relying party Structure is documented below.</summary>
    [JsonPropertyName("idpConfig")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfig>? IdpConfig { get; set; }

    /// <summary>The name of the InboundSamlConfig resource. Must start with 'saml.' and can only have alphanumeric characters, hyphens, underscores or periods. The part after 'saml.' must also start with a lowercase letter, end with an alphanumeric character, and have at least 2 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SAML SP (Service Provider) configuration when the project acts as the relying party to receive and accept an authentication assertion issued by a SAML identity provider. Structure is documented below.</summary>
    [JsonPropertyName("spConfig")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfig>? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

public partial class V1beta1TenantInboundSAMLConfigStatusConditions
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

public partial class V1beta1TenantInboundSAMLConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TenantInboundSAMLConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TenantInboundSAMLConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TenantInboundSAMLConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TenantInboundSAMLConfigSpec>, IStatus<V1beta1TenantInboundSAMLConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TenantInboundSAMLConfig";
    public const string KubeGroup = "identityplatform.gcp.upbound.io";
    public const string KubePluralName = "tenantinboundsamlconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TenantInboundSAMLConfigSpec defines the desired state of TenantInboundSAMLConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1TenantInboundSAMLConfigSpec Spec { get; set; }

    /// <summary>TenantInboundSAMLConfigStatus defines the observed state of TenantInboundSAMLConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1TenantInboundSAMLConfigStatus? Status { get; set; }
}