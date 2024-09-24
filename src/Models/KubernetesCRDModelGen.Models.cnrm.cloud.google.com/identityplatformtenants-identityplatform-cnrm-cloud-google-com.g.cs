using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.cnrm.cloud.google.com;
public partial class V1beta1IdentityPlatformTenantSpecMfaConfig
{
    /// <summary>A list of usable second factors for this project.</summary>
    [JsonPropertyName("enabledProviders")]
    public IList<string>? EnabledProviders { get; set; }

    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values: STATE_UNSPECIFIED, DISABLED, ENABLED, MANDATORY</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1IdentityPlatformTenantSpec
{
    /// <summary>Whether to allow email/password user authentication.</summary>
    [JsonPropertyName("allowPasswordSignup")]
    public bool? AllowPasswordSignup { get; set; }

    /// <summary>Whether authentication is disabled for the tenant. If true, the users under the disabled tenant are not allowed to sign-in. Admins of the disabled tenant are not able to manage its users.</summary>
    [JsonPropertyName("disableAuth")]
    public bool? DisableAuth { get; set; }

    /// <summary>Display name of the tenant.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to enable anonymous user authentication.</summary>
    [JsonPropertyName("enableAnonymousUser")]
    public bool? EnableAnonymousUser { get; set; }

    /// <summary>Whether to enable email link user authentication.</summary>
    [JsonPropertyName("enableEmailLinkSignin")]
    public bool? EnableEmailLinkSignin { get; set; }

    /// <summary>The tenant-level configuration of MFA options.</summary>
    [JsonPropertyName("mfaConfig")]
    public V1beta1IdentityPlatformTenantSpecMfaConfig? MfaConfig { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A map of <test phone number, fake code> pairs that can be used for MFA. The phone number should be in E.164 format (https://www.itu.int/rec/T-REC-E.164/) and a maximum of 10 pairs can be added (error will be thrown once exceeded).</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

public partial class V1beta1IdentityPlatformTenantStatusConditions
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

public partial class V1beta1IdentityPlatformTenantStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IdentityPlatformTenantStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IdentityPlatformTenant : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IdentityPlatformTenantSpec>, IStatus<V1beta1IdentityPlatformTenantStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IdentityPlatformTenant";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformtenants";
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
    public V1beta1IdentityPlatformTenantSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IdentityPlatformTenantStatus? Status { get; set; }
}