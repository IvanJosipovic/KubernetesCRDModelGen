using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
/// <summary>Immutable. The dataset this entry applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessSpecDatasetDataset
{
    /// <summary>Immutable. The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>Immutable. The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }
}

/// <summary>Immutable. Grants all resources of particular types in a particular dataset read access to the current dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessSpecDataset
{
    /// <summary>Immutable. The dataset this entry applies to.</summary>
    [JsonPropertyName("dataset")]
    public V1alpha1BigQueryDatasetAccessSpecDatasetDataset Dataset { get; set; }

    /// <summary>Immutable. Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string> TargetTypes { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessSpecProjectRef
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

/// <summary>Immutable. A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessSpecView
{
    /// <summary>Immutable. The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>Immutable. The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }

    /// <summary>Immutable. The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessSpec
{
    /// <summary>Immutable. Grants all resources of particular types in a particular dataset read access to the current dataset.</summary>
    [JsonPropertyName("dataset")]
    public V1alpha1BigQueryDatasetAccessSpecDataset? Dataset { get; set; }

    /// <summary>Immutable. A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>Immutable. A domain to grant access to. Any users signed in with the domain specified will be granted the specified access.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Immutable. An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Immutable. Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: 'allUsers'.</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryDatasetAccessSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The routine of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts, and will show a diff post-create. See [official docs](https://cloud.google.com/bigquery/docs/access-control).</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Immutable. A special group to grant access to. Possible values include:   * 'projectOwners': Owners of the enclosing project.   * 'projectReaders': Readers of the enclosing project.   * 'projectWriters': Writers of the enclosing project.   * 'allAuthenticatedUsers': All authenticated BigQuery users.</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>Immutable. An email address of a user to grant access to. For example: fred@example.com.</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>Immutable. A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation.</summary>
    [JsonPropertyName("view")]
    public V1alpha1BigQueryDatasetAccessSpecView? View { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDatasetAccessStatus
{
    /// <summary>If true, represents that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type.</summary>
    [JsonPropertyName("apiUpdatedMember")]
    public bool? ApiUpdatedMember { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryDatasetAccessStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDatasetAccess : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryDatasetAccessSpec>, IStatus<V1alpha1BigQueryDatasetAccessStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDatasetAccess";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatasetaccesses";
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
    public V1alpha1BigQueryDatasetAccessSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryDatasetAccessStatus? Status { get; set; }
}