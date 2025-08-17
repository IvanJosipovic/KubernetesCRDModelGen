using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
#nullable enable
/// <summary>BigtableAuthorizedView is the Schema for the BigtableAuthorizedView API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableAuthorizedViewList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigtableAuthorizedView>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableAuthorizedViewList";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableauthorizedviews";
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
    public IList<V1alpha1BigtableAuthorizedView> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An AuthorizedView permitting access to an explicit subset of a Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableAuthorizedViewSpecSubsetView
{
    /// <summary>Row prefixes to be included in the AuthorizedView. To provide access to all rows, include the empty string as a prefix ("").</summary>
    [JsonPropertyName("rowPrefixes")]
    public IList<string>? RowPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TableRef defines the resource reference to BigtableTable, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableAuthorizedViewSpecTableRef
{
    /// <summary>A reference to an externally managed BigtableTable resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableAuthorizedViewSpec defines the desired state of BigtableAuthorizedView</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableAuthorizedViewSpec
{
    /// <summary>Set to true to make the AuthorizedView protected against deletion. The parent Table and containing Instance cannot be deleted if an AuthorizedView has this bit set.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The etag for this AuthorizedView. If this is provided on update, it must match the server's etag. The server returns ABORTED error on a mismatched etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The BigtableAuthorizedView name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>An AuthorizedView permitting access to an explicit subset of a Table.</summary>
    [JsonPropertyName("subsetView")]
    public V1alpha1BigtableAuthorizedViewSpecSubsetView? SubsetView { get; set; }

    /// <summary>TableRef defines the resource reference to BigtableTable, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("tableRef")]
    public V1alpha1BigtableAuthorizedViewSpecTableRef TableRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableAuthorizedViewStatusConditions
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
public partial class V1alpha1BigtableAuthorizedViewStatusObservedState
{
}
#nullable disable

#nullable enable
/// <summary>BigtableAuthorizedViewStatus defines the config connector machine state of BigtableAuthorizedView</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableAuthorizedViewStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigtableAuthorizedViewStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigtableAuthorizedView resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigtableAuthorizedViewStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableAuthorizedView is the Schema for the BigtableAuthorizedView API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableAuthorizedView : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigtableAuthorizedViewSpec>, IStatus<V1alpha1BigtableAuthorizedViewStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableAuthorizedView";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableauthorizedviews";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableAuthorizedViewSpec defines the desired state of BigtableAuthorizedView</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigtableAuthorizedViewSpec Spec { get; set; }

    /// <summary>BigtableAuthorizedViewStatus defines the config connector machine state of BigtableAuthorizedView</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigtableAuthorizedViewStatus? Status { get; set; }
}
#nullable disable
