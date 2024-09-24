using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a sql.azure.com/ServersDatabase resource</summary>
public partial class V1api20211101storageServersDatabasesAuditingSettingSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
public partial class V1api20211101storageServersDatabasesAuditingSettingSpecStorageAccountAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20211101.Servers_Databases_AuditingSetting_Spec</summary>
public partial class V1api20211101storageServersDatabasesAuditingSettingSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("auditActionsAndGroups")]
    public IList<string>? AuditActionsAndGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAzureMonitorTargetEnabled")]
    public bool? IsAzureMonitorTargetEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isManagedIdentityInUse")]
    public bool? IsManagedIdentityInUse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isStorageSecondaryKeyInUse")]
    public bool? IsStorageSecondaryKeyInUse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a sql.azure.com/ServersDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211101storageServersDatabasesAuditingSettingSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queueDelayMs")]
    public int? QueueDelayMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("storageAccountAccessKey")]
    public V1api20211101storageServersDatabasesAuditingSettingSpecStorageAccountAccessKey? StorageAccountAccessKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20211101storageServersDatabasesAuditingSettingStatusConditions
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

/// <summary>Storage version of v1api20211101.Servers_Databases_AuditingSetting_STATUS</summary>
public partial class V1api20211101storageServersDatabasesAuditingSettingStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("auditActionsAndGroups")]
    public IList<string>? AuditActionsAndGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageServersDatabasesAuditingSettingStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAzureMonitorTargetEnabled")]
    public bool? IsAzureMonitorTargetEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isManagedIdentityInUse")]
    public bool? IsManagedIdentityInUse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isStorageSecondaryKeyInUse")]
    public bool? IsStorageSecondaryKeyInUse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queueDelayMs")]
    public int? QueueDelayMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20211101.ServersDatabasesAuditingSetting Generator information: - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/BlobAuditing.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/auditingSettings/default</summary>
public partial class V1api20211101storageServersDatabasesAuditingSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageServersDatabasesAuditingSettingSpec>, IStatus<V1api20211101storageServersDatabasesAuditingSettingStatus>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "ServersDatabasesAuditingSetting";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabasesauditingsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Databases_AuditingSetting_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageServersDatabasesAuditingSettingSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Databases_AuditingSetting_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageServersDatabasesAuditingSettingStatus? Status { get; set; }
}