using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudasset.cnrm.cloud.google.com;
public partial class V1alpha1CloudAssetProjectFeedSpecCondition
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string Expression { get; set; }

    /// <summary>String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

public partial class V1alpha1CloudAssetProjectFeedSpecFeedOutputConfigPubsubDestination
{
    /// <summary>Destination on Cloud Pubsub topic.</summary>
    [JsonPropertyName("topic")]
    public string Topic { get; set; }
}

public partial class V1alpha1CloudAssetProjectFeedSpecFeedOutputConfig
{
    /// <summary>Destination on Cloud Pubsub.</summary>
    [JsonPropertyName("pubsubDestination")]
    public V1alpha1CloudAssetProjectFeedSpecFeedOutputConfigPubsubDestination PubsubDestination { get; set; }
}

public partial class V1alpha1CloudAssetProjectFeedSpecProjectRef
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

public partial class V1alpha1CloudAssetProjectFeedSpec
{
    /// <summary>A list of the full names of the assets to receive updates. You must specify either or both of assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to the feed. For example: //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1. See https://cloud.google.com/apis/design/resourceNames#fullResourceName for more info.</summary>
    [JsonPropertyName("assetNames")]
    public IList<string>? AssetNames { get; set; }

    /// <summary>A list of types of the assets to receive updates. You must specify either or both of assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to the feed. For example: "compute.googleapis.com/Disk" See https://cloud.google.com/asset-inventory/docs/supported-asset-types for a list of all supported asset types.</summary>
    [JsonPropertyName("assetTypes")]
    public IList<string>? AssetTypes { get; set; }

    /// <summary>Immutable. The project whose identity will be used when sending messages to the destination pubsub topic. It also specifies the project for API enablement check, quota, and billing. If not specified, the resource's project will be used.</summary>
    [JsonPropertyName("billingProject")]
    public string? BillingProject { get; set; }

    /// <summary>A condition which determines whether an asset update should be published. If specified, an asset will be returned only when the expression evaluates to true. When set, expression field must be a valid CEL expression on a TemporalAsset with name temporal_asset. Example: a Feed with expression "temporal_asset.deleted == true" will only publish Asset deletions. Other fields of condition are optional.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudAssetProjectFeedSpecCondition? Condition { get; set; }

    /// <summary>Asset content type. If not specified, no content but the asset name and type will be returned. Possible values: ["CONTENT_TYPE_UNSPECIFIED", "RESOURCE", "IAM_POLICY", "ORG_POLICY", "OS_INVENTORY", "ACCESS_POLICY"].</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Immutable. This is the client-assigned asset feed identifier and it needs to be unique under a specific parent.</summary>
    [JsonPropertyName("feedId")]
    public string FeedId { get; set; }

    /// <summary>Output configuration for asset feed destination.</summary>
    [JsonPropertyName("feedOutputConfig")]
    public V1alpha1CloudAssetProjectFeedSpecFeedOutputConfig FeedOutputConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudAssetProjectFeedSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1CloudAssetProjectFeedStatusConditions
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

public partial class V1alpha1CloudAssetProjectFeedStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudAssetProjectFeedStatusConditions>? Conditions { get; set; }

    /// <summary>The format will be projects/{projectNumber}/feeds/{client-assigned_feed_identifier}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudAssetProjectFeed : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudAssetProjectFeedSpec>, IStatus<V1alpha1CloudAssetProjectFeedStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudAssetProjectFeed";
    public const string KubeGroup = "cloudasset.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudassetprojectfeeds";
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
    public V1alpha1CloudAssetProjectFeedSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudAssetProjectFeedStatus? Status { get; set; }
}