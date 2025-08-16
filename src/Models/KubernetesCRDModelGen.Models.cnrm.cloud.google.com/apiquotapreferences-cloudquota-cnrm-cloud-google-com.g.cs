using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudquota.cnrm.cloud.google.com;
/// <summary>APIQuotaPreference is the Schema for the APIQuotaPreference API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIQuotaPreferenceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIQuotaPreference>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIQuotaPreferenceList";
    public const string KubeGroup = "cloudquota.cnrm.cloud.google.com";
    public const string KubePluralName = "apiquotapreferences";
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
    public IList<V1alpha1APIQuotaPreference> Items { get; set; }
}

/// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceSpecFolderRef
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
public partial class V1alpha1APIQuotaPreferenceSpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceSpecProjectRef
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

/// <summary>Required. Preferred quota configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceSpecQuotaConfig
{
    /// <summary>Optional. The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Required. The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is "unlimited".</summary>
    [JsonPropertyName("preferredValue")]
    public long? PreferredValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceSpec
{
    /// <summary>Input only. An email address that can be used to contact the the user, in  case Google Cloud needs more information to make a decision before  additional quota can be granted.   When requesting a quota increase, the email address is required.  When requesting a quota decrease, the email address is optional.  For example, the email address is optional when the  `QuotaConfig.preferred_value` is smaller than the  `QuotaDetails.reset_value`.</summary>
    [JsonPropertyName("contactEmail")]
    public string? ContactEmail { get; set; }

    /// <summary>Immutable. The dimensions that this quota preference applies to. The key of  the map entry is the name of a dimension, such as "region", "zone",  "network_id", and the value of the map entry is the dimension value.   If a dimension is missing from the map of dimensions, the quota preference  applies to all the dimension values except for those that have other quota  preferences configured for the specific value.   NOTE: QuotaPreferences can only be applied across all values of "user" and  "resource" dimension. Do not set values for "user" or "resource" in the  dimension map.   Example: {"provider", "Foo Inc"} where "provider" is a service specific  dimension.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1APIQuotaPreferenceSpecFolderRef? FolderRef { get; set; }

    /// <summary>The reason / justification for this quota preference.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1APIQuotaPreferenceSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1APIQuotaPreferenceSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Required. Preferred quota configuration.</summary>
    [JsonPropertyName("quotaConfig")]
    public V1alpha1APIQuotaPreferenceSpecQuotaConfig QuotaConfig { get; set; }

    /// <summary>Required. The id of the quota to which the quota preference is applied. A quota name is unique in the service. Example: `CpusPerProjectPerRegion`</summary>
    [JsonPropertyName("quotaID")]
    public string QuotaID { get; set; }

    /// <summary>The APIQuotaPreference name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The name of the service to which the quota preference is applied.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceStatusConditions
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

/// <summary>Required. Preferred quota configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceStatusObservedStateQuotaConfig
{
    /// <summary>Output only. Granted quota value.</summary>
    [JsonPropertyName("grantedValue")]
    public long? GrantedValue { get; set; }

    /// <summary>Output only. The origin of the quota preference request.</summary>
    [JsonPropertyName("requestOrigin")]
    public string? RequestOrigin { get; set; }

    /// <summary>Output only. Optional details about the state of this quota preference.</summary>
    [JsonPropertyName("stateDetail")]
    public string? StateDetail { get; set; }

    /// <summary>Output only. The trace id that the Google Cloud uses to provision the requested quota. This trace id may be used by the client to contact Cloud support to track the state of a quota preference request. The trace id is only produced for increase requests and is unique for each request. The quota decrease requests do not have a trace id.</summary>
    [JsonPropertyName("traceID")]
    public string? TraceID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceStatusObservedState
{
    /// <summary>Output only. Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The current etag of the quota preference. If an etag is provided on update and does not match the current server's etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Required. Preferred quota configuration.</summary>
    [JsonPropertyName("quotaConfig")]
    public V1alpha1APIQuotaPreferenceStatusObservedStateQuotaConfig? QuotaConfig { get; set; }

    /// <summary>Output only. Is the quota preference pending Google Cloud approval and fulfillment.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>APIQuotaPreferenceStatus defines the config connector machine state of APIQuotaPreference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaPreferenceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIQuotaPreferenceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIQuotaPreference resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIQuotaPreferenceStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIQuotaPreference is the Schema for the APIQuotaPreference API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIQuotaPreference : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIQuotaPreferenceSpec>, IStatus<V1alpha1APIQuotaPreferenceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIQuotaPreference";
    public const string KubeGroup = "cloudquota.cnrm.cloud.google.com";
    public const string KubePluralName = "apiquotapreferences";
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
    public V1alpha1APIQuotaPreferenceSpec Spec { get; set; }

    /// <summary>APIQuotaPreferenceStatus defines the config connector machine state of APIQuotaPreference</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIQuotaPreferenceStatus? Status { get; set; }
}