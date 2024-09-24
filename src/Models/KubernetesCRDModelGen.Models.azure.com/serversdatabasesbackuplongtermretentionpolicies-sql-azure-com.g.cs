using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
public partial class V1api20211101storageServersDatabasesBackupLongTermRetentionPolicySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20211101storageServersDatabasesBackupLongTermRetentionPolicySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a sql.azure.com/ServersDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211101storageServersDatabasesBackupLongTermRetentionPolicySpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekOfYear")]
    public int? WeekOfYear { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

public partial class V1api20211101storageServersDatabasesBackupLongTermRetentionPolicyStatusConditions
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

public partial class V1api20211101storageServersDatabasesBackupLongTermRetentionPolicyStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageServersDatabasesBackupLongTermRetentionPolicyStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekOfYear")]
    public int? WeekOfYear { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageServersDatabasesBackupLongTermRetentionPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageServersDatabasesBackupLongTermRetentionPolicySpec>, IStatus<V1api20211101storageServersDatabasesBackupLongTermRetentionPolicyStatus>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "ServersDatabasesBackupLongTermRetentionPolicy";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabasesbackuplongtermretentionpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Databases_BackupLongTermRetentionPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageServersDatabasesBackupLongTermRetentionPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Databases_BackupLongTermRetentionPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageServersDatabasesBackupLongTermRetentionPolicyStatus? Status { get; set; }
}