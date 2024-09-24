using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firebasehosting.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1alpha1FirebaseHostingChannelSpec
{
    /// <summary>The time at which the channel will be automatically deleted. If null, the channel will not be automatically deleted. This field is present in the output whether it's set directly or via the 'ttl' field.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Immutable. Optional. The channelId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The number of previous releases to retain on the channel for rollback or other purposes. Must be a number between 1-100. Defaults to 10 for new channels.</summary>
    [JsonPropertyName("retainedReleaseCount")]
    public int? RetainedReleaseCount { get; set; }

    /// <summary>Immutable. Required. The ID of the site in which to create this channel.</summary>
    [JsonPropertyName("siteId")]
    public string SiteId { get; set; }

    /// <summary>Immutable. Input only. A time-to-live for this channel. Sets 'expire_time' to the provided duration past the time of the request. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "86400s" (one day).</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary></summary>
public partial class V1alpha1FirebaseHostingChannelStatusConditions
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
public partial class V1alpha1FirebaseHostingChannelStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirebaseHostingChannelStatusConditions>? Conditions { get; set; }

    /// <summary>The fully-qualified resource name for the channel, in the format: sites/SITE_ID/channels/CHANNEL_ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1FirebaseHostingChannel : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirebaseHostingChannelSpec>, IStatus<V1alpha1FirebaseHostingChannelStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirebaseHostingChannel";
    public const string KubeGroup = "firebasehosting.cnrm.cloud.google.com";
    public const string KubePluralName = "firebasehostingchannels";
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
    public V1alpha1FirebaseHostingChannelSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1FirebaseHostingChannelStatus? Status { get; set; }
}