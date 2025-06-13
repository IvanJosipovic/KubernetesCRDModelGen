using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.metastore.cnrm.cloud.google.com;
/// <summary>The relative resource name of the metastore that is being federated.  The formats of the relative resource names for the currently supported  metastores are listed below:   * BigQuery      * `projects/{project_id}`  * Dataproc Metastore      * `projects/{project_id}/locations/{location}/services/{service_id}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationSpecBackendMetastoresServiceRef
{
    /// <summary>A reference to an externally managed MetastoreService resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/services/{{serviceID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MetastoreService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MetastoreService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationSpecBackendMetastores
{
    /// <summary>The type of the backend metastore.</summary>
    [JsonPropertyName("metastoreType")]
    public string? MetastoreType { get; set; }

    /// <summary>The relative resource name of the metastore that is being federated.  The formats of the relative resource names for the currently supported  metastores are listed below:   * BigQuery      * `projects/{project_id}`  * Dataproc Metastore      * `projects/{project_id}/locations/{location}/services/{service_id}`</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1MetastoreFederationSpecBackendMetastoresServiceRef? ServiceRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationSpecProjectRef
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

/// <summary>MetastoreFederationSpec defines the desired state of MetastoreFederation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationSpec
{
    /// <summary>map type with key int32 as string and value as BackendMetastore</summary>
    [JsonPropertyName("backendMetastores")]
    public IDictionary<string, V1alpha1MetastoreFederationSpecBackendMetastores>? BackendMetastores { get; set; }

    /// <summary>User-defined labels for the metastore federation.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1MetastoreFederationSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The MetastoreFederation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The Apache Hive metastore version of the federation. All backend metastore versions must be compatible with the federation version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationStatusConditions
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
public partial class V1alpha1MetastoreFederationStatusObservedState
{
    /// <summary>Output only. The time when the metastore federation was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The federation endpoint.</summary>
    [JsonPropertyName("endpointURI")]
    public string? EndpointURI { get; set; }

    /// <summary>Output only. The current state of the federation.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the current state of the metastore federation, if available.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The globally unique resource identifier of the metastore federation.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the metastore federation was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>MetastoreFederationStatus defines the config connector machine state of MetastoreFederation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreFederationStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetastoreFederationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the MetastoreFederation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1MetastoreFederationStatusObservedState? ObservedState { get; set; }
}

/// <summary>MetastoreFederation is the Schema for the MetastoreFederation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreFederation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetastoreFederationSpec>, IStatus<V1alpha1MetastoreFederationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreFederation";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorefederations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreFederationSpec defines the desired state of MetastoreFederation</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MetastoreFederationSpec Spec { get; set; }

    /// <summary>MetastoreFederationStatus defines the config connector machine state of MetastoreFederation</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetastoreFederationStatus? Status { get; set; }
}

/// <summary>MetastoreFederation is the Schema for the MetastoreFederation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreFederationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetastoreFederation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreFederationList";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorefederations";
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
    public IList<V1alpha1MetastoreFederation> Items { get; set; }
}