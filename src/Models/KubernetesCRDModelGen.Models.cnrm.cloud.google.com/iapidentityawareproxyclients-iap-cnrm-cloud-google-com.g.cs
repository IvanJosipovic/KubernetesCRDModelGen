using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iap.cnrm.cloud.google.com;
/// <summary>Immutable.</summary>
public partial class V1beta1IAPIdentityAwareProxyClientSpecBrandRef
{
    /// <summary>The brand for the resource  Allowed value: The Google Cloud resource name of an `IAPBrand` resource (format: `projects/{{project}}/brands/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1IAPIdentityAwareProxyClientSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("brandRef")]
    public V1beta1IAPIdentityAwareProxyClientSpecBrandRef BrandRef { get; set; }

    /// <summary>Immutable. Human-friendly name given to the OAuth client.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1beta1IAPIdentityAwareProxyClientStatusConditions
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

/// <summary></summary>
public partial class V1beta1IAPIdentityAwareProxyClientStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAPIdentityAwareProxyClientStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Client secret of the OAuth client.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1IAPIdentityAwareProxyClient : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAPIdentityAwareProxyClientSpec>, IStatus<V1beta1IAPIdentityAwareProxyClientStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAPIdentityAwareProxyClient";
    public const string KubeGroup = "iap.cnrm.cloud.google.com";
    public const string KubePluralName = "iapidentityawareproxyclients";
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
    public V1beta1IAPIdentityAwareProxyClientSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IAPIdentityAwareProxyClientStatus? Status { get; set; }
}