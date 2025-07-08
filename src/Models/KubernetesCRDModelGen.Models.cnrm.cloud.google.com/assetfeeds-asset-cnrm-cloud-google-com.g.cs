using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.asset.cnrm.cloud.google.com;
/// <summary>A condition which determines whether an asset update should be published.  If specified, an asset will be returned only when the expression evaluates  to true.  When set, `expression` field in the `Expr` must be a valid [CEL expression]  (https://github.com/google/cel-spec) on a TemporalAsset with name  `temporal_asset`. Example: a Feed with expression ("temporal_asset.deleted  == true") will only publish Asset deletions. Other fields of `Expr` are  optional.   See our [user  guide](https://cloud.google.com/asset-inventory/docs/monitoring-asset-changes-with-condition)  for detailed instructions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>The name of the Pub/Sub topic to publish to. Example: `projects/PROJECT_ID/topics/TOPIC_ID`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecFeedOutputConfigPubsubDestinationTopicRef
{
    /// <summary>A reference to an externally managed PubSubTopic resource. Should be in the format "projects/{{projectID}}/topics/{{topicID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PubSubTopic resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PubSubTopic resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Destination on Pub/Sub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecFeedOutputConfigPubsubDestination
{
    /// <summary>The name of the Pub/Sub topic to publish to. Example: `projects/PROJECT_ID/topics/TOPIC_ID`.</summary>
    [JsonPropertyName("topicRef")]
    public V1alpha1AssetFeedSpecFeedOutputConfigPubsubDestinationTopicRef? TopicRef { get; set; }
}

/// <summary>Required. Feed output configuration defining where the asset updates are published to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecFeedOutputConfig
{
    /// <summary>Destination on Pub/Sub.</summary>
    [JsonPropertyName("pubsubDestination")]
    public V1alpha1AssetFeedSpecFeedOutputConfigPubsubDestination? PubsubDestination { get; set; }
}

/// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecFolderRef
{
    /// <summary>The 'name' field of a folder, when not managed by Config Connector. This field must be set when 'name' field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The 'name' field of a 'Folder' resource. This field must be set when 'external' field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The 'namespace' field of a 'Folder' resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>AssetFeedSpec defines the desired state of AssetFeed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedSpec
{
    /// <summary>A list of the full names of the assets to receive updates. You must specify either or both of asset_names and asset_types. Only asset updates matching specified asset_names or asset_types are exported to the feed. Example: `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. For a list of the full names for supported asset types, see [Resource name format](/asset-inventory/docs/resource-name-format).</summary>
    [JsonPropertyName("assetNames")]
    public IList<string>? AssetNames { get; set; }

    /// <summary>A list of types of the assets to receive updates. You must specify either  or both of asset_names and asset_types. Only asset updates matching  specified asset_names or asset_types are exported to the feed.  Example: `"compute.googleapis.com/Disk"`   For a list of all supported asset types, see  [Supported asset types](/asset-inventory/docs/supported-asset-types).</summary>
    [JsonPropertyName("assetTypes")]
    public IList<string>? AssetTypes { get; set; }

    /// <summary>A condition which determines whether an asset update should be published.  If specified, an asset will be returned only when the expression evaluates  to true.  When set, `expression` field in the `Expr` must be a valid [CEL expression]  (https://github.com/google/cel-spec) on a TemporalAsset with name  `temporal_asset`. Example: a Feed with expression ("temporal_asset.deleted  == true") will only publish Asset deletions. Other fields of `Expr` are  optional.   See our [user  guide](https://cloud.google.com/asset-inventory/docs/monitoring-asset-changes-with-condition)  for detailed instructions.</summary>
    [JsonPropertyName("condition")]
    public V1alpha1AssetFeedSpecCondition? Condition { get; set; }

    /// <summary>Asset content type. If not specified, no content but the asset name and type will be returned.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Required. Feed output configuration defining where the asset updates are published to.</summary>
    [JsonPropertyName("feedOutputConfig")]
    public V1alpha1AssetFeedSpecFeedOutputConfig FeedOutputConfig { get; set; }

    /// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1AssetFeedSpecFolderRef? FolderRef { get; set; }

    /// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1AssetFeedSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AssetFeedSpecProjectRef? ProjectRef { get; set; }

    /// <summary>A list of relationship types to output, for example: `INSTANCE_TO_INSTANCEGROUP`. This field should only be specified if content_type=RELATIONSHIP. * If specified: it outputs specified relationship updates on the [asset_names] or the [asset_types]. It returns an error if any of the [relationship_types] doesn't belong to the supported relationship types of the [asset_names] or [asset_types], or any of the [asset_names] or the [asset_types] doesn't belong to the source types of the [relationship_types]. * Otherwise: it outputs the supported relationships of the types of [asset_names] and [asset_types] or returns an error if any of the [asset_names] or the [asset_types] has no replationship support. See [Introduction to Cloud Asset Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and relationship types.</summary>
    [JsonPropertyName("relationshipTypes")]
    public IList<string>? RelationshipTypes { get; set; }

    /// <summary>The AssetFeed name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedStatusConditions
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

/// <summary>AssetFeedStatus defines the config connector machine state of AssetFeed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetFeedStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AssetFeedStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AssetFeed resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AssetFeed is the Schema for the AssetFeed API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssetFeed : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AssetFeedSpec>, IStatus<V1alpha1AssetFeedStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssetFeed";
    public const string KubeGroup = "asset.cnrm.cloud.google.com";
    public const string KubePluralName = "assetfeeds";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AssetFeedSpec defines the desired state of AssetFeed</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AssetFeedSpec Spec { get; set; }

    /// <summary>AssetFeedStatus defines the config connector machine state of AssetFeed</summary>
    [JsonPropertyName("status")]
    public V1alpha1AssetFeedStatus? Status { get; set; }
}

/// <summary>AssetFeed is the Schema for the AssetFeed API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssetFeedList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AssetFeed>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssetFeedList";
    public const string KubeGroup = "asset.cnrm.cloud.google.com";
    public const string KubePluralName = "assetfeeds";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1AssetFeed> Items { get; set; }
}