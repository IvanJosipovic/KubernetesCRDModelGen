using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryanalyticshub.cnrm.cloud.google.com;
/// <summary>Shared dataset i.e. BigQuery dataset source.</summary>
public partial class V1alpha1BigQueryAnalyticsHubListingSpecBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123.</summary>
    [JsonPropertyName("dataset")]
    public string Dataset { get; set; }
}

/// <summary>Details of the data provider who owns the source data.</summary>
public partial class V1alpha1BigQueryAnalyticsHubListingSpecDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1BigQueryAnalyticsHubListingSpecProjectRef
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

/// <summary>Details of the publisher who owns the listing and who can share the source data.</summary>
public partial class V1alpha1BigQueryAnalyticsHubListingSpecPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary></summary>
public partial class V1alpha1BigQueryAnalyticsHubListingSpec
{
    /// <summary>Shared dataset i.e. BigQuery dataset source.</summary>
    [JsonPropertyName("bigqueryDataset")]
    public V1alpha1BigQueryAnalyticsHubListingSpecBigqueryDataset BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>Immutable. The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string DataExchangeId { get; set; }

    /// <summary>Details of the data provider who owns the source data.</summary>
    [JsonPropertyName("dataProvider")]
    public V1alpha1BigQueryAnalyticsHubListingSpecDataProvider? DataProvider { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can't start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>Immutable. The name of the location this data exchange listing.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Email or URL of the primary point of contact of the listing.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryAnalyticsHubListingSpecProjectRef ProjectRef { get; set; }

    /// <summary>Details of the publisher who owns the listing and who can share the source data.</summary>
    [JsonPropertyName("publisher")]
    public V1alpha1BigQueryAnalyticsHubListingSpecPublisher? Publisher { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>Immutable. Optional. The listingId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1alpha1BigQueryAnalyticsHubListingStatusConditions
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
public partial class V1alpha1BigQueryAnalyticsHubListingStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryAnalyticsHubListingStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of the listing. e.g. "projects/myproject/locations/US/dataExchanges/123/listings/456".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1BigQueryAnalyticsHubListing : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryAnalyticsHubListingSpec>, IStatus<V1alpha1BigQueryAnalyticsHubListingStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryAnalyticsHubListing";
    public const string KubeGroup = "bigqueryanalyticshub.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryanalyticshublistings";
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
    public V1alpha1BigQueryAnalyticsHubListingSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryAnalyticsHubListingStatus? Status { get; set; }
}