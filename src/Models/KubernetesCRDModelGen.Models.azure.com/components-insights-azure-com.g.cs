using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20200202storageComponentSpecOperatorSpecConfigMapsConnectionString
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap being referenced. The ConfigMap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20200202storageComponentSpecOperatorSpecConfigMapsInstrumentationKey
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap being referenced. The ConfigMap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20200202.ComponentOperatorConfigMaps</summary>
public partial class V1api20200202storageComponentSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("connectionString")]
    public V1api20200202storageComponentSpecOperatorSpecConfigMapsConnectionString? ConnectionString { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("instrumentationKey")]
    public V1api20200202storageComponentSpecOperatorSpecConfigMapsInstrumentationKey? InstrumentationKey { get; set; }
}

/// <summary>Storage version of v1api20200202.ComponentOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
public partial class V1api20200202storageComponentSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200202.ComponentOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20200202storageComponentSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20200202storageComponentSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>WorkspaceResourceReference: Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an application with this API version. Applications from older versions will not have this property.</summary>
public partial class V1api20200202storageComponentSpecWorkspaceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20200202.Component_Spec</summary>
public partial class V1api20200202storageComponentSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Application_Type")]
    public string? ApplicationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DisableIpMasking")]
    public bool? DisableIpMasking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DisableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Flow_Type")]
    public string? FlowType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ForceCustomerStorageForProfiler")]
    public bool? ForceCustomerStorageForProfiler { get; set; }

    /// <summary></summary>
    [JsonPropertyName("HockeyAppId")]
    public string? HockeyAppId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ImmediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IngestionMode")]
    public string? IngestionMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Request_Source")]
    public string? RequestSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RetentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SamplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20200202.ComponentOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200202storageComponentSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20200202storageComponentSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public string? PublicNetworkAccessForIngestion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public string? PublicNetworkAccessForQuery { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>WorkspaceResourceReference: Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an application with this API version. Applications from older versions will not have this property.</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20200202storageComponentSpecWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>Storage version of v1api20200202.PrivateLinkScopedResource_STATUS The private link scope resource reference.</summary>
public partial class V1api20200202storageComponentStatusPrivateLinkScopedResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ResourceId")]
    public string? ResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ScopeId")]
    public string? ScopeId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20200202storageComponentStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20200202.Component_STATUS</summary>
public partial class V1api20200202storageComponentStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("AppId")]
    public string? AppId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Application_Type")]
    public string? ApplicationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ConnectionString")]
    public string? ConnectionString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("CreationDate")]
    public string? CreationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DisableIpMasking")]
    public bool? DisableIpMasking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DisableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Flow_Type")]
    public string? FlowType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ForceCustomerStorageForProfiler")]
    public bool? ForceCustomerStorageForProfiler { get; set; }

    /// <summary></summary>
    [JsonPropertyName("HockeyAppId")]
    public string? HockeyAppId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("HockeyAppToken")]
    public string? HockeyAppToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ImmediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IngestionMode")]
    public string? IngestionMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("InstrumentationKey")]
    public string? InstrumentationKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("LaMigrationDate")]
    public string? LaMigrationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("PrivateLinkScopedResources")]
    public IList<V1api20200202storageComponentStatusPrivateLinkScopedResources>? PrivateLinkScopedResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Request_Source")]
    public string? RequestSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RetentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SamplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("TenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("WorkspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200202storageComponentStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public string? PublicNetworkAccessForIngestion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public string? PublicNetworkAccessForQuery { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20200202.Component Generator information: - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/stable/2020-02-02/components_API.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/components/{resourceName}</summary>
public partial class V1api20200202storageComponent : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200202storageComponentSpec>, IStatus<V1api20200202storageComponentStatus>
{
    public const string KubeApiVersion = "v1api20200202storage";
    public const string KubeKind = "Component";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "components";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20200202.Component_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20200202storageComponentSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20200202.Component_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20200202storageComponentStatus? Status { get; set; }
}