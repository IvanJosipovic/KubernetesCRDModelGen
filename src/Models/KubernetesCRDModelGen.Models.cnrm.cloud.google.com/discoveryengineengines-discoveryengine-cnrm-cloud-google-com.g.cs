using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.discoveryengine.cnrm.cloud.google.com;
/// <summary>The configurationt generate the Dialogflow agent that is associated to  this Engine.   Note that these configurations are one-time consumed by  and passed to Dialogflow service. It means they cannot be retrieved using  [EngineService.GetEngine][google.cloud.discoveryengine.v1.EngineService.GetEngine]  or  [EngineService.ListEngines][google.cloud.discoveryengine.v1.EngineService.ListEngines]  API after engine creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecChatEngineConfigAgentCreationConfig
{
    /// <summary>Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.</summary>
    [JsonPropertyName("business")]
    public string? Business { get; set; }

    /// <summary>Required. The default language of the agent as a language tag. See [Language Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported language codes.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>Agent location for Agent creation, supported values: global/us/eu. If not provided, us Engine will create Agent using us-central-1 by default; eu Engine will create Agent using eu-west-1 by default.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The time zone of the agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Configurations for the Chat Engine. Only applicable if solution_type is SOLUTION_TYPE_CHAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecChatEngineConfig
{
    /// <summary>The configurationt generate the Dialogflow agent that is associated to  this Engine.   Note that these configurations are one-time consumed by  and passed to Dialogflow service. It means they cannot be retrieved using  [EngineService.GetEngine][google.cloud.discoveryengine.v1.EngineService.GetEngine]  or  [EngineService.ListEngines][google.cloud.discoveryengine.v1.EngineService.ListEngines]  API after engine creation.</summary>
    [JsonPropertyName("agentCreationConfig")]
    public V1alpha1DiscoveryEngineEngineSpecChatEngineConfigAgentCreationConfig? AgentCreationConfig { get; set; }

    /// <summary>The resource name of an exist Dialogflow agent to link to this Chat  Engine. Customers can either provide `agent_creation_config` to create  agent or provide an agent name that links the agent with the Chat engine.   Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent  ID&gt;`.   Note that the `dialogflow_agent_to_link` are one-time consumed by and  passed to Dialogflow service. It means they cannot be retrieved using  [EngineService.GetEngine][google.cloud.discoveryengine.v1.EngineService.GetEngine]  or  [EngineService.ListEngines][google.cloud.discoveryengine.v1.EngineService.ListEngines]  API after engine creation. Use  [ChatEngineMetadata.dialogflow_agent][google.cloud.discoveryengine.v1.Engine.ChatEngineMetadata.dialogflow_agent]  for actual agent association after Engine is created.</summary>
    [JsonPropertyName("dialogflowAgentToLink")]
    public string? DialogflowAgentToLink { get; set; }
}

/// <summary>Common config spec that specifies the metadata of the engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecCommonConfig
{
    /// <summary>The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.</summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }
}

/// <summary>DiscoveryEngineDataStoreRef defines the resource reference to DiscoveryEngineDataStore, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecDataStoreRefs
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

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecProjectRef
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

/// <summary>Configurations for the Search Engine. Only applicable if solution_type is SOLUTION_TYPE_SEARCH.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpecSearchEngineConfig
{
    /// <summary>The add-on that this search engine enables.</summary>
    [JsonPropertyName("searchAddOns")]
    public IList<string>? SearchAddOns { get; set; }

    /// <summary>The search feature tier of this engine.   Different tiers might have different  pricing. To learn more, check the pricing documentation.   Defaults to  [SearchTier.SEARCH_TIER_STANDARD][google.cloud.discoveryengine.v1.SearchTier.SEARCH_TIER_STANDARD]  if not specified.</summary>
    [JsonPropertyName("searchTier")]
    public string? SearchTier { get; set; }
}

/// <summary>DiscoveryEngineEngineSpec defines the desired state of DiscoveryEngineEngine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineSpec
{
    /// <summary>Configurations for the Chat Engine. Only applicable if solution_type is SOLUTION_TYPE_CHAT.</summary>
    [JsonPropertyName("chatEngineConfig")]
    public V1alpha1DiscoveryEngineEngineSpecChatEngineConfig? ChatEngineConfig { get; set; }

    /// <summary>Immutable. The collection for the Engine.</summary>
    [JsonPropertyName("collection")]
    public string Collection { get; set; }

    /// <summary>Common config spec that specifies the metadata of the engine.</summary>
    [JsonPropertyName("commonConfig")]
    public V1alpha1DiscoveryEngineEngineSpecCommonConfig? CommonConfig { get; set; }

    /// <summary>The data stores associated with this engine. For SOLUTION_TYPE_SEARCH and SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store. If solution_type is SOLUTION_TYPE_CHAT, multiple DataStores in the same Collection can be associated here. Note that when used in CreateEngineRequest, one DataStore must be provided as the system will use it for necessary initializations.</summary>
    [JsonPropertyName("dataStoreRefs")]
    public IList<V1alpha1DiscoveryEngineEngineSpecDataStoreRefs>? DataStoreRefs { get; set; }

    /// <summary>Optional. Whether to disable analytics for searches performed on this engine.</summary>
    [JsonPropertyName("disableAnalytics")]
    public bool? DisableAnalytics { get; set; }

    /// <summary>Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to `GENERIC`. Vertical on Engine has to match vertical of the DataStore linked to the engine.</summary>
    [JsonPropertyName("industryVertical")]
    public string? IndustryVertical { get; set; }

    /// <summary>Immutable. Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DiscoveryEngineEngineSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The DiscoveryEngineChatEngine name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configurations for the Search Engine. Only applicable if solution_type is SOLUTION_TYPE_SEARCH.</summary>
    [JsonPropertyName("searchEngineConfig")]
    public V1alpha1DiscoveryEngineEngineSpecSearchEngineConfig? SearchEngineConfig { get; set; }

    /// <summary>Required. The solutions of the engine.</summary>
    [JsonPropertyName("solutionType")]
    public string SolutionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineStatusConditions
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
public partial class V1alpha1DiscoveryEngineEngineStatusObservedState
{
}

/// <summary>DiscoveryEngineEngineStatus defines the config connector machine state of DiscoveryEngineEngine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineEngineStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineEngineStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineEngine resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineEngineStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineEngine is the Schema for the DiscoveryEngineEngine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineEngine : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineEngineSpec>, IStatus<V1alpha1DiscoveryEngineEngineStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineEngine";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineengines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineEngineSpec defines the desired state of DiscoveryEngineEngine</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DiscoveryEngineEngineSpec Spec { get; set; }

    /// <summary>DiscoveryEngineEngineStatus defines the config connector machine state of DiscoveryEngineEngine</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineEngineStatus? Status { get; set; }
}

/// <summary>DiscoveryEngineEngine is the Schema for the DiscoveryEngineEngine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineEngineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DiscoveryEngineEngine>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineEngineList";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryengineengines";
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
    public IList<V1alpha1DiscoveryEngineEngine> Items { get; set; }
}