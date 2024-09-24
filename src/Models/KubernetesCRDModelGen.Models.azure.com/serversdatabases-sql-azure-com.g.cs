using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecElasticPoolReference
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20211101.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20211101.DatabaseIdentity Azure Active Directory identity configuration for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with create operation of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecLongTermRetentionBackupResourceReference
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

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a sql.azure.com/Server resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecRecoverableDatabaseReference
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

/// <summary>RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecRecoveryServicesRecoveryPointReference
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

/// <summary>RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create operation of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecRestorableDroppedDatabaseReference
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

/// <summary>Storage version of v1api20211101.Sku An ARM Resource SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SourceDatabaseReference: The resource identifier of the source database associated with create operation of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecSourceDatabaseReference
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

/// <summary>SourceResourceReference: The resource identifier of the source associated with the create operation of this database. This property is only supported for DataWarehouse edition and allows to restore across subscriptions. When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover. When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of the existing database or existing sql pool, and restorePointInTime must be specified. When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable dropped sql pool. When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool. When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary” header must contain authentication token for the source tenant. For more details about “x-ms-authorization-auxiliary” header see https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecSourceResourceReference
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

/// <summary>Storage version of v1api20211101.Servers_Database_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolReference")]
    public V1api20211101storageServersDatabaseSpecElasticPoolReference? ElasticPoolReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>Storage version of v1api20211101.DatabaseIdentity Azure Active Directory identity configuration for a resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101storageServersDatabaseSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with create operation of this database.</summary>
    [JsonPropertyName("longTermRetentionBackupResourceReference")]
    public V1api20211101storageServersDatabaseSpecLongTermRetentionBackupResourceReference? LongTermRetentionBackupResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a sql.azure.com/Server resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211101storageServersDatabaseSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readScale")]
    public string? ReadScale { get; set; }

    /// <summary>RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of this database.</summary>
    [JsonPropertyName("recoverableDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecRecoverableDatabaseReference? RecoverableDatabaseReference { get; set; }

    /// <summary>RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation of this database.</summary>
    [JsonPropertyName("recoveryServicesRecoveryPointReference")]
    public V1api20211101storageServersDatabaseSpecRecoveryServicesRecoveryPointReference? RecoveryServicesRecoveryPointReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public string? RequestedBackupStorageRedundancy { get; set; }

    /// <summary>RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create operation of this database.</summary>
    [JsonPropertyName("restorableDroppedDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecRestorableDroppedDatabaseReference? RestorableDroppedDatabaseReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>Storage version of v1api20211101.Sku An ARM Resource SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20211101storageServersDatabaseSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary>SourceDatabaseReference: The resource identifier of the source database associated with create operation of this database.</summary>
    [JsonPropertyName("sourceDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecSourceDatabaseReference? SourceDatabaseReference { get; set; }

    /// <summary>SourceResourceReference: The resource identifier of the source associated with the create operation of this database. This property is only supported for DataWarehouse edition and allows to restore across subscriptions. When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover. When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of the existing database or existing sql pool, and restorePointInTime must be specified. When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable dropped sql pool. When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool. When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary” header must contain authentication token for the source tenant. For more details about “x-ms-authorization-auxiliary” header see https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20211101storageServersDatabaseSpecSourceResourceReference? SourceResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusConditions
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

/// <summary>Storage version of v1api20211101.Sku_STATUS An ARM Resource SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusCurrentSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20211101.DatabaseUserIdentity_STATUS Azure Active Directory identity configuration for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20211101.DatabaseIdentity_STATUS Azure Active Directory identity configuration for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211101storageServersDatabaseStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20211101.Sku_STATUS An ARM Resource SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20211101.Servers_Database_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageServersDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentBackupStorageRedundancy")]
    public string? CurrentBackupStorageRedundancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentServiceObjectiveName")]
    public string? CurrentServiceObjectiveName { get; set; }

    /// <summary>Storage version of v1api20211101.Sku_STATUS An ARM Resource SKU.</summary>
    [JsonPropertyName("currentSku")]
    public V1api20211101storageServersDatabaseStatusCurrentSku? CurrentSku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseId")]
    public string? DatabaseId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSecondaryLocation")]
    public string? DefaultSecondaryLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20211101.DatabaseIdentity_STATUS Azure Active Directory identity configuration for a resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101storageServersDatabaseStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isInfraEncryptionEnabled")]
    public bool? IsInfraEncryptionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("longTermRetentionBackupResourceId")]
    public string? LongTermRetentionBackupResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxLogSizeBytes")]
    public int? MaxLogSizeBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pausedDate")]
    public string? PausedDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readScale")]
    public string? ReadScale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recoverableDatabaseId")]
    public string? RecoverableDatabaseId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recoveryServicesRecoveryPointId")]
    public string? RecoveryServicesRecoveryPointId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public string? RequestedBackupStorageRedundancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestedServiceObjectiveName")]
    public string? RequestedServiceObjectiveName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restorableDroppedDatabaseId")]
    public string? RestorableDroppedDatabaseId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resumedDate")]
    public string? ResumedDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>Storage version of v1api20211101.Sku_STATUS An ARM Resource SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20211101storageServersDatabaseStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Storage version of v1api20211101.ServersDatabase Generator information: - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Databases.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageServersDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageServersDatabaseSpec>, IStatus<V1api20211101storageServersDatabaseStatus>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "ServersDatabase";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Database_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageServersDatabaseSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.Servers_Database_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageServersDatabaseStatus? Status { get; set; }
}