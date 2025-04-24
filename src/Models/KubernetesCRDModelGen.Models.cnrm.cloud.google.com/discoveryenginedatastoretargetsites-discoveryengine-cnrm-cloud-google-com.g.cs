using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.discoveryengine.cnrm.cloud.google.com;
/// <summary>The DataStore this target site should be part of.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteSpecDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DiscoveryEngineDataStoreTargetSiteSpec defines the desired state of DiscoveryEngineDataStoreTargetSite</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteSpec
{
    /// <summary>The DataStore this target site should be part of.</summary>
    [JsonPropertyName("dataStoreRef")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteSpecDataStoreRef? DataStoreRef { get; set; }

    /// <summary>Input only. If set to false, a uri_pattern is generated to include all pages whose address contains the provided_uri_pattern. If set to true, an uri_pattern is generated to try to be an exact match of the provided_uri_pattern or just the specific page if the provided_uri_pattern is a specific one. provided_uri_pattern is always normalized to generate the URI pattern to be used by the search engine.</summary>
    [JsonPropertyName("exactMatch")]
    public bool? ExactMatch { get; set; }

    /// <summary>Required. Input only. The user provided URI pattern from which the `generated_uri_pattern` is generated.</summary>
    [JsonPropertyName("providedURIPattern")]
    public string? ProvidedURIPattern { get; set; }

    /// <summary>The type of the target site, e.g., whether the site is to be included or excluded.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatusConditions
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

/// <summary>Failed due to insufficient quota.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateFailureReasonQuotaFailure
{
    /// <summary>This number is an estimation on how much total quota this project needs to successfully complete indexing.</summary>
    [JsonPropertyName("totalRequiredQuota")]
    public long? TotalRequiredQuota { get; set; }
}

/// <summary>Output only. Failure reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateFailureReason
{
    /// <summary>Failed due to insufficient quota.</summary>
    [JsonPropertyName("quotaFailure")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateFailureReasonQuotaFailure? QuotaFailure { get; set; }
}

/// <summary>Output only. Site ownership and validity verification status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateSiteVerificationInfo
{
    /// <summary>Site verification state indicating the ownership and validity.</summary>
    [JsonPropertyName("siteVerificationState")]
    public string? SiteVerificationState { get; set; }

    /// <summary>Latest site verification time.</summary>
    [JsonPropertyName("verifyTime")]
    public string? VerifyTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedState
{
    /// <summary>Output only. Failure reason.</summary>
    [JsonPropertyName("failureReason")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateFailureReason? FailureReason { get; set; }

    /// <summary>Output only. This is system-generated based on the provided_uri.</summary>
    [JsonPropertyName("generatedURIPattern")]
    public string? GeneratedURIPattern { get; set; }

    /// <summary>Output only. Indexing status.</summary>
    [JsonPropertyName("indexingStatus")]
    public string? IndexingStatus { get; set; }

    /// <summary>Output only. Root domain of the provided_uri.</summary>
    [JsonPropertyName("rootDomainURI")]
    public string? RootDomainURI { get; set; }

    /// <summary>Output only. Site ownership and validity verification status.</summary>
    [JsonPropertyName("siteVerificationInfo")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedStateSiteVerificationInfo? SiteVerificationInfo { get; set; }

    /// <summary>Output only. The target site's last updated time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DiscoveryEngineDataStoreTargetSiteStatus defines the config connector machine state of DiscoveryEngineDataStoreTargetSite</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineDataStoreTargetSiteStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineDataStoreTargetSite resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineDataStoreTargetSite is the Schema for the DiscoveryEngineDataStoreTargetSite API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSite : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineDataStoreTargetSiteSpec>, IStatus<V1alpha1DiscoveryEngineDataStoreTargetSiteStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineDataStoreTargetSite";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryenginedatastoretargetsites";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineDataStoreTargetSiteSpec defines the desired state of DiscoveryEngineDataStoreTargetSite</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteSpec Spec { get; set; }

    /// <summary>DiscoveryEngineDataStoreTargetSiteStatus defines the config connector machine state of DiscoveryEngineDataStoreTargetSite</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineDataStoreTargetSiteStatus? Status { get; set; }
}

/// <summary>DiscoveryEngineDataStoreTargetSite is the Schema for the DiscoveryEngineDataStoreTargetSite API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineDataStoreTargetSiteList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DiscoveryEngineDataStoreTargetSite>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineDataStoreTargetSiteList";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryenginedatastoretargetsites";
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
    public IList<V1alpha1DiscoveryEngineDataStoreTargetSite> Items { get; set; }
}