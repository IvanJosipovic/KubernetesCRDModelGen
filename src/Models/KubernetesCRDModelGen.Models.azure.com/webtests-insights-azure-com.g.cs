using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>Storage version of v1api20220615.WebTestProperties_Configuration</summary>
public partial class V1api20220615storageWebtestSpecConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("WebTest")]
    public string? WebTest { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestGeolocation Geo-physical location to run a WebTest from. You must specify one or more locations for the test to run from.</summary>
public partial class V1api20220615storageWebtestSpecLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220615.HeaderField A header to add to the WebTest.</summary>
public partial class V1api20220615storageWebtestSpecRequestHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_Request</summary>
public partial class V1api20220615storageWebtestSpecRequest
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("FollowRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Headers")]
    public IList<V1api20220615storageWebtestSpecRequestHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("HttpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ParseDependentRequests")]
    public bool? ParseDependentRequests { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RequestBody")]
    public string? RequestBody { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RequestUrl")]
    public string? RequestUrl { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_ContentValidation</summary>
public partial class V1api20220615storageWebtestSpecValidationRulesContentValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ContentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IgnoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("PassIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules</summary>
public partial class V1api20220615storageWebtestSpecValidationRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_ContentValidation</summary>
    [JsonPropertyName("ContentValidation")]
    public V1api20220615storageWebtestSpecValidationRulesContentValidation? ContentValidation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ExpectedHttpStatusCode")]
    public int? ExpectedHttpStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IgnoreHttpStatusCode")]
    public bool? IgnoreHttpStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SSLCertRemainingLifetimeCheck")]
    public int? SSLCertRemainingLifetimeCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SSLCheck")]
    public bool? SSLCheck { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20220615storageWebtestSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220615.Webtest_Spec</summary>
public partial class V1api20220615storageWebtestSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_Configuration</summary>
    [JsonPropertyName("Configuration")]
    public V1api20220615storageWebtestSpecConfiguration? Configuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Frequency")]
    public int? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Locations")]
    public IList<V1api20220615storageWebtestSpecLocations>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_Request</summary>
    [JsonPropertyName("Request")]
    public V1api20220615storageWebtestSpecRequest? Request { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RetryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SyntheticMonitorId")]
    public string? SyntheticMonitorId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Timeout")]
    public int? Timeout { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules</summary>
    [JsonPropertyName("ValidationRules")]
    public V1api20220615storageWebtestSpecValidationRules? ValidationRules { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220615storageWebtestSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_Configuration_STATUS</summary>
public partial class V1api20220615storageWebtestStatusConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("WebTest")]
    public string? WebTest { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestGeolocation_STATUS Geo-physical location to run a WebTest from. You must specify one or more locations for the test to run from.</summary>
public partial class V1api20220615storageWebtestStatusLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220615.HeaderField_STATUS A header to add to the WebTest.</summary>
public partial class V1api20220615storageWebtestStatusRequestHeaders
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_Request_STATUS</summary>
public partial class V1api20220615storageWebtestStatusRequest
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("FollowRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Headers")]
    public IList<V1api20220615storageWebtestStatusRequestHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("HttpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ParseDependentRequests")]
    public bool? ParseDependentRequests { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RequestBody")]
    public string? RequestBody { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RequestUrl")]
    public string? RequestUrl { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_ContentValidation_STATUS</summary>
public partial class V1api20220615storageWebtestStatusValidationRulesContentValidation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ContentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IgnoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("PassIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_STATUS</summary>
public partial class V1api20220615storageWebtestStatusValidationRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_ContentValidation_STATUS</summary>
    [JsonPropertyName("ContentValidation")]
    public V1api20220615storageWebtestStatusValidationRulesContentValidation? ContentValidation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ExpectedHttpStatusCode")]
    public int? ExpectedHttpStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("IgnoreHttpStatusCode")]
    public bool? IgnoreHttpStatusCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SSLCertRemainingLifetimeCheck")]
    public int? SSLCertRemainingLifetimeCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SSLCheck")]
    public bool? SSLCheck { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20220615storageWebtestStatusConditions
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

/// <summary>Storage version of v1api20220615.Webtest_STATUS</summary>
public partial class V1api20220615storageWebtestStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_Configuration_STATUS</summary>
    [JsonPropertyName("Configuration")]
    public V1api20220615storageWebtestStatusConfiguration? Configuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Frequency")]
    public int? Frequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Locations")]
    public IList<V1api20220615storageWebtestStatusLocations>? Locations { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_Request_STATUS</summary>
    [JsonPropertyName("Request")]
    public V1api20220615storageWebtestStatusRequest? Request { get; set; }

    /// <summary></summary>
    [JsonPropertyName("RetryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SyntheticMonitorId")]
    public string? SyntheticMonitorId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Timeout")]
    public int? Timeout { get; set; }

    /// <summary>Storage version of v1api20220615.WebTestProperties_ValidationRules_STATUS</summary>
    [JsonPropertyName("ValidationRules")]
    public V1api20220615storageWebtestStatusValidationRules? ValidationRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220615storageWebtestStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20220615.Webtest Generator information: - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/stable/2022-06-15/webTests_API.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</summary>
public partial class V1api20220615storageWebtest : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220615storageWebtestSpec>, IStatus<V1api20220615storageWebtestStatus>
{
    public const string KubeApiVersion = "v1api20220615storage";
    public const string KubeKind = "Webtest";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "webtests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220615.Webtest_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220615storageWebtestSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220615.Webtest_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220615storageWebtestStatus? Status { get; set; }
}