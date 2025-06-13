using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.cnrm.cloud.google.com;
/// <summary>Authorization contains constraints on the visibility of Entries that conform to the EntryType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeSpecAuthorization
{
    /// <summary>Immutable. The IAM permission grantable on the Entry Group to allow access to instantiate Entries of Dataplex owned Entry Types, only settable for Dataplex owned Types.</summary>
    [JsonPropertyName("alternateUsePermission")]
    public string? AlternateUsePermission { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeSpecProjectRef
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

/// <summary>Required aspect type for the entry type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeSpecRequiredAspectsTypeRef
{
    /// <summary>A reference to an externally managed DataplexAspectType resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/aspectTypes/{{aspecttypeID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeSpecRequiredAspects
{
    /// <summary>Required aspect type for the entry type.</summary>
    [JsonPropertyName("typeRef")]
    public V1alpha1DataplexEntryTypeSpecRequiredAspectsTypeRef TypeRef { get; set; }
}

/// <summary>DataplexEntryTypeSpec defines the desired state of DataplexEntryType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeSpec
{
    /// <summary>Authorization contains constraints on the visibility of Entries that conform to the EntryType.</summary>
    [JsonPropertyName("authorization")]
    public V1alpha1DataplexEntryTypeSpecAuthorization? Authorization { get; set; }

    /// <summary>Optional. Description of the EntryType.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User-defined labels for the EntryType.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. The platform that Entries of this type belongs to.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataplexEntryTypeSpecProjectRef ProjectRef { get; set; }

    /// <summary>AspectInfo contains overriding configuration for aspects.</summary>
    [JsonPropertyName("requiredAspects")]
    public IList<V1alpha1DataplexEntryTypeSpecRequiredAspects>? RequiredAspects { get; set; }

    /// <summary>The DataplexEntryType name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The system that Entries of this type belongs to. Examples include CloudSQL, MariaDB etc</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>Optional. Indicates the classes this Entry Type belongs to, for example, TABLE, DATABASE, MODEL.</summary>
    [JsonPropertyName("typeAliases")]
    public IList<string>? TypeAliases { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeStatusConditions
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
public partial class V1alpha1DataplexEntryTypeStatusObservedState
{
    /// <summary>Output only. The time when the EntryType was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. This checksum is computed by the service, and might be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. System generated globally unique ID for the EntryType. This ID will be different if the EntryType is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the EntryType was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DataplexEntryTypeStatus defines the config connector machine state of DataplexEntryType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexEntryTypeStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexEntryTypeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexEntryType resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexEntryTypeStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataplexEntryType is the Schema for the DataplexEntryType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexEntryType : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexEntryTypeSpec>, IStatus<V1alpha1DataplexEntryTypeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexEntryType";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexentrytypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexEntryTypeSpec defines the desired state of DataplexEntryType</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataplexEntryTypeSpec Spec { get; set; }

    /// <summary>DataplexEntryTypeStatus defines the config connector machine state of DataplexEntryType</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexEntryTypeStatus? Status { get; set; }
}

/// <summary>DataplexEntryType is the Schema for the DataplexEntryType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexEntryTypeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexEntryType>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexEntryTypeList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplexentrytypes";
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
    public IList<V1alpha1DataplexEntryType> Items { get; set; }
}