using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.cnrm.cloud.google.com;
public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpecIdpConfigIdpCertificates
{
    /// <summary>The IdP's x509 certificate.</summary>
    [JsonPropertyName("x509Certificate")]
    public string? X509Certificate { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpecIdpConfig
{
    /// <summary>The IdP's certificate data to verify the signature in the SAMLResponse issued by the IDP.</summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1alpha1IdentityPlatformInboundSAMLConfigSpecIdpConfigIdpCertificates> IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("idpEntityId")]
    public string IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string SsoUrl { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpecSpConfigSpCertificates
{
    /// <summary>The x509 certificate.</summary>
    [JsonPropertyName("x509Certificate")]
    public string? X509Certificate { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpecSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with 'https://'.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>The IDP's certificate data to verify the signature in the SAMLResponse issued by the IDP.</summary>
    [JsonPropertyName("spCertificates")]
    public IList<V1alpha1IdentityPlatformInboundSAMLConfigSpecSpConfigSpCertificates>? SpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigSpec
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>SAML IdP configuration when the project acts as the relying party.</summary>
    [JsonPropertyName("idpConfig")]
    public V1alpha1IdentityPlatformInboundSAMLConfigSpecIdpConfig IdpConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1IdentityPlatformInboundSAMLConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>SAML SP (Service Provider) configuration when the project acts as the relying party to receive and accept an authentication assertion issued by a SAML identity provider.</summary>
    [JsonPropertyName("spConfig")]
    public V1alpha1IdentityPlatformInboundSAMLConfigSpecSpConfig SpConfig { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1alpha1IdentityPlatformInboundSAMLConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IdentityPlatformInboundSAMLConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IdentityPlatformInboundSAMLConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IdentityPlatformInboundSAMLConfigSpec>, IStatus<V1alpha1IdentityPlatformInboundSAMLConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IdentityPlatformInboundSAMLConfig";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatforminboundsamlconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1IdentityPlatformInboundSAMLConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1IdentityPlatformInboundSAMLConfigStatus? Status { get; set; }
}