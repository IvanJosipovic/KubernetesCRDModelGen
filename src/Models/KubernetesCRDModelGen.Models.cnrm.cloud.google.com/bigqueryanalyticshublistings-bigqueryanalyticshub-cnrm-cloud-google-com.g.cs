using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryanalyticshub.cnrm.cloud.google.com;
/// <summary>BigQueryAnalyticsHubDataExchangeRef defines the resource reference to BigQueryAnalyticsHubDataExchange, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecDataExchangeRef
{
    /// <summary>A reference to an externally managed BigQueryAnalyticsHubDataExchange resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/dataexchanges/{{dataexchangeID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryAnalyticsHubDataExchange resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryAnalyticsHubDataExchange resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Details of the data provider who owns the source data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecDataProvider
{
    /// <summary>Optional. Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Email or URL of the data provider. Max Length: 1000 bytes.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecProjectRef
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

/// <summary>Optional. Details of the publisher who owns the listing and who can share the source data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecPublisher
{
    /// <summary>Optional. Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Email or URL of the listing publisher. Max Length: 1000 bytes.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>Resource name of the dataset source for this listing. e.g. `projects/myproject/datasets/123`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceDatasetRef
{
    /// <summary>If provided must be in the format `projects/[project_id]/datasets/[dataset_id]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. If set, restricted export policy will be propagated and enforced on the linked dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceRestrictedExportPolicy
{
    /// <summary>Optional. If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. If true, restrict direct table access (read api/tabledata.list) on linked table.</summary>
    [JsonPropertyName("restrictDirectTableAccess")]
    public bool? RestrictDirectTableAccess { get; set; }

    /// <summary>Optional. If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

/// <summary>Optional. A reference to a BigQueryTable. Format: `projects/{projectId}/datasets/{datasetId}/tables/{tableId}` Example:"projects/test_project/datasets/test_dataset/tables/test_table"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceSelectedResourcesTableRef
{
    /// <summary>If provided must be in the format `projects/{projectId}/datasets/{datasetId}/tables/{tableId}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceSelectedResources
{
    /// <summary>Optional. A reference to a BigQueryTable. Format: `projects/{projectId}/datasets/{datasetId}/tables/{tableId}` Example:"projects/test_project/datasets/test_dataset/tables/test_table"</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceSelectedResourcesTableRef? TableRef { get; set; }
}

/// <summary>One of the following fields must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSource
{
    /// <summary>Resource name of the dataset source for this listing. e.g. `projects/myproject/datasets/123`</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceDatasetRef DatasetRef { get; set; }

    /// <summary>Optional. If set, restricted export policy will be propagated and enforced on the linked dataset.</summary>
    [JsonPropertyName("restrictedExportPolicy")]
    public V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceRestrictedExportPolicy? RestrictedExportPolicy { get; set; }

    /// <summary>Optional. Resources in this dataset that are selectively shared. If this field is empty, then the entire dataset (all resources) are shared. This field is only valid for data clean room exchanges.</summary>
    [JsonPropertyName("selectedResources")]
    public IList<V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSourceSelectedResources>? SelectedResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpecSource
{
    /// <summary>One of the following fields must be set.</summary>
    [JsonPropertyName("bigQueryDatasetSource")]
    public V1beta1BigQueryAnalyticsHubListingSpecSourceBigQueryDatasetSource? BigQueryDatasetSource { get; set; }
}

/// <summary>BigQueryAnalyticsHubListingSpec defines the desired state of BigQueryAnalyticsHubDataExchangeListing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingSpec
{
    /// <summary>Optional. Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>BigQueryAnalyticsHubDataExchangeRef defines the resource reference to BigQueryAnalyticsHubDataExchange, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("dataExchangeRef")]
    public V1beta1BigQueryAnalyticsHubListingSpecDataExchangeRef DataExchangeRef { get; set; }

    /// <summary>Optional. Details of the data provider who owns the source data.</summary>
    [JsonPropertyName("dataProvider")]
    public V1beta1BigQueryAnalyticsHubListingSpecDataProvider? DataProvider { get; set; }

    /// <summary>Optional. Short description of the listing. The description must contain only Unicode characters or tabs  (HT), new lines (LF), carriage returns (CR), and page breaks (FF). Default value is an empty string. Max length: 2000 bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Type of discovery of the listing on the discovery page.</summary>
    [JsonPropertyName("discoveryType")]
    public string? DiscoveryType { get; set; }

    /// <summary>Required. Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can't start or end with spaces. Default value is an empty string. Max length: 63 bytes.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Optional. Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Immutable. The name of the location this data exchange.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Email or URL of the primary point of contact of the listing. Max Length: 1000 bytes.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1BigQueryAnalyticsHubListingSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Details of the publisher who owns the listing and who can share the source data.</summary>
    [JsonPropertyName("publisher")]
    public V1beta1BigQueryAnalyticsHubListingSpecPublisher? Publisher { get; set; }

    /// <summary>Optional. Email or URL of the request access of the listing. Subscribers can use this reference to request access. Max Length: 1000 bytes.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>Immutable. The BigQueryAnalyticsHubDataExchangeListing name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1beta1BigQueryAnalyticsHubListingSpecSource Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingStatusObservedState
{
    /// <summary>Output only. Current state of the listing.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>BigQueryAnalyticsHubListingStatus defines the config connector machine state of BigQueryAnalyticsHubDataExchangeListing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryAnalyticsHubListingStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryAnalyticsHubListingStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryAnalyticsHubDataExchangeListing resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BigQueryAnalyticsHubListingStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryAnalyticsHubListing is the Schema for the BigQueryAnalyticsHubListing API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryAnalyticsHubListing : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigQueryAnalyticsHubListingSpec>, IStatus<V1beta1BigQueryAnalyticsHubListingStatus>
{
    public const string KubeApiVersion = "v1beta1";
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

    /// <summary>BigQueryAnalyticsHubListingSpec defines the desired state of BigQueryAnalyticsHubDataExchangeListing</summary>
    [JsonPropertyName("spec")]
    public V1beta1BigQueryAnalyticsHubListingSpec? Spec { get; set; }

    /// <summary>BigQueryAnalyticsHubListingStatus defines the config connector machine state of BigQueryAnalyticsHubDataExchangeListing</summary>
    [JsonPropertyName("status")]
    public V1beta1BigQueryAnalyticsHubListingStatus? Status { get; set; }
}