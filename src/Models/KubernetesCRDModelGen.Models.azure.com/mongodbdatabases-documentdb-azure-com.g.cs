using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
public partial class V1api20231115storageMongodbDatabaseSpecOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
public partial class V1api20231115storageMongodbDatabaseSpecOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/DatabaseAccount resource</summary>
public partial class V1api20231115storageMongodbDatabaseSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
public partial class V1api20231115storageMongodbDatabaseSpecResourceRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

/// <summary>Storage version of v1api20231115.MongoDBDatabaseResource Cosmos DB MongoDB database resource object</summary>
public partial class V1api20231115storageMongodbDatabaseSpecResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageMongodbDatabaseSpecResourceRestoreParameters? RestoreParameters { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccounts_MongodbDatabase_Spec</summary>
public partial class V1api20231115storageMongodbDatabaseSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20231115.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseSpecOptions? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/DatabaseAccount resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231115storageMongodbDatabaseSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231115.MongoDBDatabaseResource Cosmos DB MongoDB database resource object</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseSpecResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20231115storageMongodbDatabaseStatusConditions
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

/// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
public partial class V1api20231115storageMongodbDatabaseStatusOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.OptionsResource_STATUS Cosmos DB options resource object</summary>
public partial class V1api20231115storageMongodbDatabaseStatusOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
public partial class V1api20231115storageMongodbDatabaseStatusResourceRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

/// <summary>Storage version of v1api20231115.MongoDBDatabaseGetProperties_Resource_STATUS</summary>
public partial class V1api20231115storageMongodbDatabaseStatusResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_etag")]
    public string? etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_rid")]
    public string? rid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_ts")]
    public double? ts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageMongodbDatabaseStatusResourceRestoreParameters? RestoreParameters { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccounts_MongodbDatabase_STATUS</summary>
public partial class V1api20231115storageMongodbDatabaseStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageMongodbDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231115.OptionsResource_STATUS Cosmos DB options resource object</summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseStatusOptions? Options { get; set; }

    /// <summary>Storage version of v1api20231115.MongoDBDatabaseGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseStatusResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20231115.MongodbDatabase Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2023-11-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</summary>
public partial class V1api20231115storageMongodbDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageMongodbDatabaseSpec>, IStatus<V1api20231115storageMongodbDatabaseStatus>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabase";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccounts_MongodbDatabase_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageMongodbDatabaseSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccounts_MongodbDatabase_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageMongodbDatabaseStatus? Status { get; set; }
}