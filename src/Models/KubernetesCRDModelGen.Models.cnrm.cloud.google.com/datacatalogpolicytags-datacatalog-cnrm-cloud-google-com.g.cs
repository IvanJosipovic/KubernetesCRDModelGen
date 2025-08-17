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
/// <summary>DataCatalogPolicyTag is the Schema for the DataCatalogPolicyTag API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataCatalogPolicyTagList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataCatalogPolicyTag>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataCatalogPolicyTagList";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogpolicytags";
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
    public IList<V1beta1DataCatalogPolicyTag> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PolicyTagRef defines the resource reference to DataCatalogPolicyTag, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagSpecParentPolicyTagRef
{
    /// <summary>A reference to an externally managed DataCatalogPolicyTag resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/taxonomies/{{taxonomyID}}/policytags/{{policytagID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogPolicyTag resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogPolicyTag resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TaxonomyRef defines the resource reference to DataCatalogTaxonomy, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagSpecTaxonomyRef
{
    /// <summary>A reference to an externally managed DataCatalogTaxonomy resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/taxonomies/{{taxonomyID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogTaxonomy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogTaxonomy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogPolicyTagSpec defines the desired state of DataCatalogPolicyTag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagSpec
{
    /// <summary>Description of this policy tag. It must: contain only unicode characters, tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes long when encoded in UTF-8. If not set, defaults to an empty description. If not set, defaults to an empty description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User defined name of this policy tag. It must: be unique within the parent taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces; not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>PolicyTagRef defines the resource reference to DataCatalogPolicyTag, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("parentPolicyTagRef")]
    public V1beta1DataCatalogPolicyTagSpecParentPolicyTagRef? ParentPolicyTagRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>TaxonomyRef defines the resource reference to DataCatalogTaxonomy, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("taxonomyRef")]
    public V1beta1DataCatalogPolicyTagSpecTaxonomyRef TaxonomyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagStatusObservedState
{
}
#nullable disable

#nullable enable
/// <summary>DataCatalogPolicyTagStatus defines the config connector machine state of DataCatalogPolicyTag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogPolicyTagStatus
{
    /// <summary>Resource names of child policy tags of this policy tag.</summary>
    [JsonPropertyName("childPolicyTags")]
    public IList<string>? ChildPolicyTags { get; set; }

    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataCatalogPolicyTagStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataCatalogPolicyTag resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Resource name of this policy tag, whose format is: "projects/{project}/locations/{region}/taxonomies/{taxonomy}/policyTags/{policytag}".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1DataCatalogPolicyTagStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogPolicyTag is the Schema for the DataCatalogPolicyTag API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataCatalogPolicyTag : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataCatalogPolicyTagSpec>, IStatus<V1beta1DataCatalogPolicyTagStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataCatalogPolicyTag";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogpolicytags";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataCatalogPolicyTagSpec defines the desired state of DataCatalogPolicyTag</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataCatalogPolicyTagSpec Spec { get; set; }

    /// <summary>DataCatalogPolicyTagStatus defines the config connector machine state of DataCatalogPolicyTag</summary>
    [JsonPropertyName("status")]
    public V1beta1DataCatalogPolicyTagStatus? Status { get; set; }
}
#nullable disable
