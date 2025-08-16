using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudquota.cnrm.cloud.google.com;
/// <summary>APIQuotaAdjusterSettings is the Schema for the APIQuotaAdjusterSettings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIQuotaAdjusterSettingsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIQuotaAdjusterSettings>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIQuotaAdjusterSettingsList";
    public const string KubeGroup = "cloudquota.cnrm.cloud.google.com";
    public const string KubePluralName = "apiquotaadjustersettings";
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
    public IList<V1alpha1APIQuotaAdjusterSettings> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaAdjusterSettingsSpecProjectRef
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

/// <summary>APIQuotaAdjusterSettingsSpec defines the desired state of APIQuotaAdjusterSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaAdjusterSettingsSpec
{
    /// <summary>Required. The configured value of the enablement at the given resource.</summary>
    [JsonPropertyName("enablement")]
    public string Enablement { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1APIQuotaAdjusterSettingsSpecProjectRef ProjectRef { get; set; }

    /// <summary>The APIQuotaAdjusterSettings name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaAdjusterSettingsStatusConditions
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
public partial class V1alpha1APIQuotaAdjusterSettingsStatusObservedState
{
    /// <summary>Optional. The current etag of the QuotaAdjusterSettings. If an etag is provided on update and does not match the current server's etag of the QuotaAdjusterSettings, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The timestamp when the QuotaAdjusterSettings was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>APIQuotaAdjusterSettingsStatus defines the config connector machine state of APIQuotaAdjusterSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIQuotaAdjusterSettingsStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIQuotaAdjusterSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIQuotaAdjusterSettings resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIQuotaAdjusterSettingsStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIQuotaAdjusterSettings is the Schema for the APIQuotaAdjusterSettings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIQuotaAdjusterSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIQuotaAdjusterSettingsSpec>, IStatus<V1alpha1APIQuotaAdjusterSettingsStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIQuotaAdjusterSettings";
    public const string KubeGroup = "cloudquota.cnrm.cloud.google.com";
    public const string KubePluralName = "apiquotaadjustersettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIQuotaAdjusterSettingsSpec defines the desired state of APIQuotaAdjusterSettings</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIQuotaAdjusterSettingsSpec Spec { get; set; }

    /// <summary>APIQuotaAdjusterSettingsStatus defines the config connector machine state of APIQuotaAdjusterSettings</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIQuotaAdjusterSettingsStatus? Status { get; set; }
}