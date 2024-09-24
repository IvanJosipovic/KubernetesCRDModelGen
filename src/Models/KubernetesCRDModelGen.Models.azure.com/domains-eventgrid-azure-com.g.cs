using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.com;
public partial class V1api20200601storageDomainSpecInboundIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonDataVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonEventTime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonEventType
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonId
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonSubject
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonTopic
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMappingJson
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("eventType")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("id")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonId? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("subject")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("topic")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

public partial class V1api20200601storageDomainSpecInputSchemaMapping
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonInputSchemaMapping</summary>
    [JsonPropertyName("json")]
    public V1api20200601storageDomainSpecInputSchemaMappingJson? Json { get; set; }
}

public partial class V1api20200601storageDomainSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20200601storageDomainSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601storageDomainSpecInboundIpRules>? InboundIpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v1api20200601.InputSchemaMapping</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601storageDomainSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20200601storageDomainSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1api20200601storageDomainStatusConditions
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

public partial class V1api20200601storageDomainStatusInboundIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonDataVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonEventTime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonEventType
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonId
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonSubject
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonTopic
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMappingJson
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("eventType")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("id")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonId? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>Storage version of v1api20200601.JsonFieldWithDefault_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'subject', 'eventtype' and 'dataversion' properties. This represents a field in the input event schema along with a default value to be used, and at least one of these two properties should be provided.</summary>
    [JsonPropertyName("subject")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Storage version of v1api20200601.JsonField_STATUS This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema. This is currently used in the mappings for the 'id', 'topic' and 'eventtime' properties. This represents a field in the input event schema.</summary>
    [JsonPropertyName("topic")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

public partial class V1api20200601storageDomainStatusInputSchemaMapping
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonInputSchemaMapping_STATUS</summary>
    [JsonPropertyName("json")]
    public V1api20200601storageDomainStatusInputSchemaMappingJson? Json { get; set; }
}

public partial class V1api20200601storageDomainStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20200601storageDomainStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

public partial class V1api20200601storageDomainStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200601storageDomainStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601storageDomainStatusInboundIpRules>? InboundIpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v1api20200601.InputSchemaMapping_STATUS</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601storageDomainStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20200601storageDomainStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20200601.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20200601storageDomainStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601storageDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601storageDomainSpec>, IStatus<V1api20200601storageDomainStatus>
{
    public const string KubeApiVersion = "v1api20200601storage";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20200601.Domain_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20200601storageDomainSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20200601.Domain_STATUS EventGrid Domain.</summary>
    [JsonPropertyName("status")]
    public V1api20200601storageDomainStatus? Status { get; set; }
}