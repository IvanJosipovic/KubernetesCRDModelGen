using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.discoveryengine.cnrm.cloud.google.com;
/// <summary>The ID of the project in which the resource belongs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreSpecProjectRef
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

/// <summary>Config to store data store type configuration for workspace data. This must be set when [DataStore.content_config][google.cloud.discoveryengine.v1.DataStore.content_config] is set as [DataStore.ContentConfig.GOOGLE_WORKSPACE][google.cloud.discoveryengine.v1.DataStore.ContentConfig.GOOGLE_WORKSPACE].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreSpecWorkspaceConfig
{
    /// <summary>Obfuscated Dasher customer ID.</summary>
    [JsonPropertyName("dasherCustomerID")]
    public string? DasherCustomerID { get; set; }

    /// <summary>Optional. The super admin email address for the workspace that will be used for access token generation. For now we only use it for Native Google Drive connector data ingestion.</summary>
    [JsonPropertyName("superAdminEmailAddress")]
    public string? SuperAdminEmailAddress { get; set; }

    /// <summary>Optional. The super admin service account for the workspace that will be used for access token generation. For now we only use it for Native Google Drive connector data ingestion.</summary>
    [JsonPropertyName("superAdminServiceAccount")]
    public string? SuperAdminServiceAccount { get; set; }

    /// <summary>The Google Workspace data source.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DiscoveryEngineDataStoreSpec defines the desired state of DiscoveryEngineDataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreSpec
{
    /// <summary>Immutable. The collection for the DataStore.</summary>
    [JsonPropertyName("collection")]
    public string Collection { get; set; }

    /// <summary>Immutable. The content config of the data store. If this field is unset, the server behavior defaults to [ContentConfig.NO_CONTENT][google.cloud.discoveryengine.v1.DataStore.ContentConfig.NO_CONTENT].</summary>
    [JsonPropertyName("contentConfig")]
    public string? ContentConfig { get; set; }

    /// <summary>Required. The data store display name.  This field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The industry vertical that the data store registers.</summary>
    [JsonPropertyName("industryVertical")]
    public string? IndustryVertical { get; set; }

    /// <summary>Immutable. The location for the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DiscoveryEngineDataStoreSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The DiscoveryEngineDataStore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The solutions that the data store enrolls. Available solutions for each [industry_vertical][google.cloud.discoveryengine.v1.DataStore.industry_vertical]:  * `MEDIA`: `SOLUTION_TYPE_RECOMMENDATION` and `SOLUTION_TYPE_SEARCH`. * `SITE_SEARCH`: `SOLUTION_TYPE_SEARCH` is automatically enrolled. Other   solutions cannot be enrolled.</summary>
    [JsonPropertyName("solutionTypes")]
    public IList<string>? SolutionTypes { get; set; }

    /// <summary>Config to store data store type configuration for workspace data. This must be set when [DataStore.content_config][google.cloud.discoveryengine.v1.DataStore.content_config] is set as [DataStore.ContentConfig.GOOGLE_WORKSPACE][google.cloud.discoveryengine.v1.DataStore.ContentConfig.GOOGLE_WORKSPACE].</summary>
    [JsonPropertyName("workspaceConfig")]
    public V1alpha1DiscoveryEngineDataStoreSpecWorkspaceConfig? WorkspaceConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreStatusConditions
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

/// <summary>Output only. Data size estimation for billing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreStatusObservedStateBillingEstimation
{
    /// <summary>Data size for structured data in terms of bytes.</summary>
    [JsonPropertyName("structuredDataSize")]
    public long? StructuredDataSize { get; set; }

    /// <summary>Last updated timestamp for structured data.</summary>
    [JsonPropertyName("structuredDataUpdateTime")]
    public string? StructuredDataUpdateTime { get; set; }

    /// <summary>Data size for unstructured data in terms of bytes.</summary>
    [JsonPropertyName("unstructuredDataSize")]
    public long? UnstructuredDataSize { get; set; }

    /// <summary>Last updated timestamp for unstructured data.</summary>
    [JsonPropertyName("unstructuredDataUpdateTime")]
    public string? UnstructuredDataUpdateTime { get; set; }

    /// <summary>Data size for websites in terms of bytes.</summary>
    [JsonPropertyName("websiteDataSize")]
    public long? WebsiteDataSize { get; set; }

    /// <summary>Last updated timestamp for websites.</summary>
    [JsonPropertyName("websiteDataUpdateTime")]
    public string? WebsiteDataUpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreStatusObservedState
{
    /// <summary>Output only. Data size estimation for billing.</summary>
    [JsonPropertyName("billingEstimation")]
    public V1alpha1DiscoveryEngineDataStoreStatusObservedStateBillingEstimation? BillingEstimation { get; set; }

    /// <summary>Output only. Timestamp the [DataStore][google.cloud.discoveryengine.v1.DataStore] was created at.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The id of the default [Schema][google.cloud.discoveryengine.v1.Schema] asscociated to this data store.</summary>
    [JsonPropertyName("defaultSchemaID")]
    public string? DefaultSchemaID { get; set; }
}

/// <summary>DiscoveryEngineDataStoreStatus defines the config connector machine state of DiscoveryEngineDataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineDataStoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineDataStore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineDataStoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineDataStore is the Schema for the DiscoveryEngineDataStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineDataStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineDataStoreSpec>, IStatus<V1alpha1DiscoveryEngineDataStoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineDataStore";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryenginedatastores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineDataStoreSpec defines the desired state of DiscoveryEngineDataStore</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DiscoveryEngineDataStoreSpec Spec { get; set; }

    /// <summary>DiscoveryEngineDataStoreStatus defines the config connector machine state of DiscoveryEngineDataStore</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineDataStoreStatus? Status { get; set; }
}