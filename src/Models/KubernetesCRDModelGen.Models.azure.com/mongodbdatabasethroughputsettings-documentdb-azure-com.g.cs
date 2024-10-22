using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/MongodbDatabase resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.ThroughputPolicyResource Cosmos DB resource throughput policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoUpgradePolicyResource Cosmos DB resource auto-upgrade policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ThroughputPolicyResource Cosmos DB resource throughput policy</summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoscaleSettingsResource Cosmos DB provisioned throughput settings object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoUpgradePolicyResource Cosmos DB resource auto-upgrade policy</summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.ThroughputSettingsResource Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpecResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettingsResource Cosmos DB provisioned throughput settings object</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpecResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseThroughputSetting_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/MongodbDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231115.ThroughputSettingsResource Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both.</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpecResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatusConditions
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

/// <summary>Storage version of v1api20231115.ThroughputPolicyResource_STATUS Cosmos DB resource throughput policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoUpgradePolicyResource_STATUS Cosmos DB resource auto-upgrade policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ThroughputPolicyResource_STATUS Cosmos DB resource throughput policy</summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoscaleSettingsResource_STATUS Cosmos DB provisioned throughput settings object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoUpgradePolicyResource_STATUS Cosmos DB resource auto-upgrade policy</summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetMaxThroughput")]
    public int? TargetMaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.ThroughputSettingsGetProperties_Resource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatusResource
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

    /// <summary>Storage version of v1api20231115.AutoscaleSettingsResource_STATUS Cosmos DB provisioned throughput settings object</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseThroughputSettingStatusResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instantMaximumThroughput")]
    public string? InstantMaximumThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumThroughput")]
    public string? MinimumThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offerReplacePending")]
    public string? OfferReplacePending { get; set; }

    /// <summary></summary>
    [JsonPropertyName("softAllowedMaximumThroughput")]
    public string? SoftAllowedMaximumThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseThroughputSetting_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseThroughputSettingStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageMongodbDatabaseThroughputSettingStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231115.ThroughputSettingsGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseThroughputSettingStatusResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseThroughputSetting Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2023-11-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageMongodbDatabaseThroughputSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageMongodbDatabaseThroughputSettingSpec>, IStatus<V1api20231115storageMongodbDatabaseThroughputSettingStatus>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabaseThroughputSetting";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasethroughputsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseThroughputSetting_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageMongodbDatabaseThroughputSettingSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseThroughputSetting_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageMongodbDatabaseThroughputSettingStatus? Status { get; set; }
}