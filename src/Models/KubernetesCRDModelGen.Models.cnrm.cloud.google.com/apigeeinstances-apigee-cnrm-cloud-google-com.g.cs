using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
public partial class V1alpha1ApigeeInstanceSpec
{
    /// <summary>Immutable. Optional. Customer accept list represents the list of projects (id/number) on customer side that can privately connect to the service attachment. It is an optional field which the customers can provide during the instance creation. By default, the customer project associated with the Apigee organization will be included to the list.</summary>
    [JsonPropertyName("consumerAcceptList")]
    public IList<string>? ConsumerAcceptList { get; set; }

    /// <summary>Immutable. Description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only. Use the following format: 'projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)'.</summary>
    [JsonPropertyName("diskEncryptionKeyName")]
    public string? DiskEncryptionKeyName { get; set; }

    /// <summary>Immutable. Display name of the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. IP range represents the customer-provided CIDR block of length 22 that will be used for the Apigee instance creation. This optional range, if provided, should be freely available as part of larger named range the customer has allocated to the Service Networking peering. If this is not provided, Apigee will automatically request for any available /22 CIDR block from Service Networking. The customer should use this CIDR block for configuring their firewall needs to allow traffic from Apigee. Input format: "a.b.c.d/22".</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Immutable. Required. Compute Engine location where the instance resides.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Apigee Organization associated with the Apigee instance, in the format 'organizations/{{org_name}}'.</summary>
    [JsonPropertyName("orgId")]
    public string OrgId { get; set; }

    /// <summary>Immutable. The size of the CIDR block range that will be reserved by the instance. For valid values, see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.</summary>
    [JsonPropertyName("peeringCidrRange")]
    public string? PeeringCidrRange { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1ApigeeInstanceStatusConditions
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

public partial class V1alpha1ApigeeInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApigeeInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Hostname or IP address of the exposed Apigee endpoint used by clients to connect to the service.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Port number of the exposed Apigee endpoint.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Output only. Resource name of the service attachment created for the instance in the format: projects/*/regions/*/serviceAttachments/* Apigee customers can privately forward traffic to this service attachment using the PSC endpoints.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApigeeInstanceSpec>, IStatus<V1alpha1ApigeeInstanceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeInstance";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeinstances";
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
    public V1alpha1ApigeeInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ApigeeInstanceStatus? Status { get; set; }
}