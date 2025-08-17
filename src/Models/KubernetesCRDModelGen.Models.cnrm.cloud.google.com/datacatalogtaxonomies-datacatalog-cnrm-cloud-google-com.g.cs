using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
#nullable enable
/// <summary>DataCatalogTaxonomy is the Schema for the datacatalog API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataCatalogTaxonomyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataCatalogTaxonomy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataCatalogTaxonomyList";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogtaxonomies";
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
    public IList<V1beta1DataCatalogTaxonomy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomySpecProjectRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomySpec
{
    /// <summary>A list of policy types that are activated for this taxonomy. If not set, defaults to an empty list. Possible values: ["POLICY_TYPE_UNSPECIFIED", "FINE_GRAINED_ACCESS_CONTROL"].</summary>
    [JsonPropertyName("activatedPolicyTypes")]
    public IList<string>? ActivatedPolicyTypes { get; set; }

    /// <summary>Description of this taxonomy. It must: contain only unicode characters, tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes long when encoded in UTF-8. If not set, defaults to an empty description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User defined name of this taxonomy. It must: contain only unicode letters, numbers, underscores, dashes and spaces; not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DataCatalogTaxonomySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Taxonomy location region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomyStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Output only. Identity of the service which owns the Taxonomy. This field is only populated when the taxonomy is created by a Google Cloud service. Currently only 'DATAPLEX' is supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomyStatusObservedStateService
{
    /// <summary>The service agent for the service.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The Google Cloud service name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Creation and modification timestamps of this taxonomy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomyStatusObservedStateTaxonomyTimestamps
{
    /// <summary>Creation timestamp of the resource within the given system.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Expiration timestamp of the resource within the given system.  Currently only applicable to BigQuery resources.</summary>
    [JsonPropertyName("expiredTime")]
    public string? ExpiredTime { get; set; }

    /// <summary>Timestamp of the last modification of the resource or its metadata within  a given system.   Note: Depending on the source system, not every modification updates this  timestamp.  For example, BigQuery timestamps every metadata modification but not data  or permission changes.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomyStatusObservedState
{
    /// <summary>Output only. Number of policy tags in this taxonomy.</summary>
    [JsonPropertyName("policyTagCount")]
    public int? PolicyTagCount { get; set; }

    /// <summary>Output only. Identity of the service which owns the Taxonomy. This field is only populated when the taxonomy is created by a Google Cloud service. Currently only 'DATAPLEX' is supported.</summary>
    [JsonPropertyName("service")]
    public V1beta1DataCatalogTaxonomyStatusObservedStateService? Service { get; set; }

    /// <summary>Output only. Creation and modification timestamps of this taxonomy.</summary>
    [JsonPropertyName("taxonomyTimestamps")]
    public V1beta1DataCatalogTaxonomyStatusObservedStateTaxonomyTimestamps? TaxonomyTimestamps { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogTaxonomyStatus
{
    /// <summary>Conditions represent the latest available observations of the DataCatalogTaxonomy's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataCatalogTaxonomyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataCatalogTaxonomy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Resource name of this taxonomy, whose format is: "projects/{project}/locations/{region}/taxonomies/{taxonomy}".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1DataCatalogTaxonomyStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogTaxonomy is the Schema for the datacatalog API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataCatalogTaxonomy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataCatalogTaxonomySpec>, IStatus<V1beta1DataCatalogTaxonomyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataCatalogTaxonomy";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogtaxonomies";
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
    public V1beta1DataCatalogTaxonomySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DataCatalogTaxonomyStatus? Status { get; set; }
}
#nullable disable
