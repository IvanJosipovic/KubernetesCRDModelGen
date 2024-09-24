using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
public partial class V1api20231101storageBackupVaultSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20231101.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
public partial class V1api20231101storageBackupVaultSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20231101storageBackupVaultSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20231101.DppIdentityDetails Identity details</summary>
public partial class V1api20231101storageBackupVaultSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20231101storageBackupVaultSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20231101storageBackupVaultSpecOperatorSpecConfigMapsPrincipalId
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap being referenced. The ConfigMap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultOperatorConfigMaps</summary>
public partial class V1api20231101storageBackupVaultSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("principalId")]
    public V1api20231101storageBackupVaultSpecOperatorSpecConfigMapsPrincipalId? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
public partial class V1api20231101storageBackupVaultSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20231101storageBackupVaultSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20231101storageBackupVaultSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231101.CrossRegionRestoreSettings</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.CrossSubscriptionRestoreSettings CrossSubscriptionRestore Settings</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.FeatureSettings Class containing feature settings of vault</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesFeatureSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CrossRegionRestoreSettings</summary>
    [JsonPropertyName("crossRegionRestoreSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettings? CrossRegionRestoreSettings { get; set; }

    /// <summary>Storage version of v1api20231101.CrossSubscriptionRestoreSettings CrossSubscriptionRestore Settings</summary>
    [JsonPropertyName("crossSubscriptionRestoreSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettings? CrossSubscriptionRestoreSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureMonitorAlertSettings Settings for Azure Monitor based alerts</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertsForAllJobFailures")]
    public string? AlertsForAllJobFailures { get; set; }
}

/// <summary>Storage version of v1api20231101.MonitoringSettings Monitoring Settings</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesMonitoringSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureMonitorAlertSettings Settings for Azure Monitor based alerts</summary>
    [JsonPropertyName("azureMonitorAlertSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettings? AzureMonitorAlertSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.ImmutabilitySettings Immutability Settings at vault level</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesSecuritySettingsImmutabilitySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.SoftDeleteSettings Soft delete related settings</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionDurationInDays")]
    public double? RetentionDurationInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.SecuritySettings Class containing security settings of vault</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesSecuritySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.ImmutabilitySettings Immutability Settings at vault level</summary>
    [JsonPropertyName("immutabilitySettings")]
    public V1api20231101storageBackupVaultSpecPropertiesSecuritySettingsImmutabilitySettings? ImmutabilitySettings { get; set; }

    /// <summary>Storage version of v1api20231101.SoftDeleteSettings Soft delete related settings</summary>
    [JsonPropertyName("softDeleteSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettings? SoftDeleteSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.StorageSetting Storage setting</summary>
public partial class V1api20231101storageBackupVaultSpecPropertiesStorageSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datastoreType")]
    public string? DatastoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultSpec Backup Vault</summary>
public partial class V1api20231101storageBackupVaultSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.FeatureSettings Class containing feature settings of vault</summary>
    [JsonPropertyName("featureSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesFeatureSettings? FeatureSettings { get; set; }

    /// <summary>Storage version of v1api20231101.MonitoringSettings Monitoring Settings</summary>
    [JsonPropertyName("monitoringSettings")]
    public V1api20231101storageBackupVaultSpecPropertiesMonitoringSettings? MonitoringSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicatedRegions")]
    public IList<string>? ReplicatedRegions { get; set; }

    /// <summary>Storage version of v1api20231101.SecuritySettings Class containing security settings of vault</summary>
    [JsonPropertyName("securitySettings")]
    public V1api20231101storageBackupVaultSpecPropertiesSecuritySettings? SecuritySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageSettings")]
    public IList<V1api20231101storageBackupVaultSpecPropertiesStorageSettings>? StorageSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVault_Spec</summary>
public partial class V1api20231101storageBackupVaultSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20231101.DppIdentityDetails Identity details</summary>
    [JsonPropertyName("identity")]
    public V1api20231101storageBackupVaultSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101storageBackupVaultSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231101storageBackupVaultSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultSpec Backup Vault</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultSpecProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20231101storageBackupVaultStatusConditions
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

/// <summary>Storage version of v1api20231101.UserAssignedIdentity_STATUS User assigned identity properties</summary>
public partial class V1api20231101storageBackupVaultStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20231101.DppIdentityDetails_STATUS Identity details</summary>
public partial class V1api20231101storageBackupVaultStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20231101storageBackupVaultStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20231101.CrossRegionRestoreSettings_STATUS</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesFeatureSettingsCrossRegionRestoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.CrossSubscriptionRestoreSettings_STATUS CrossSubscriptionRestore Settings</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesFeatureSettingsCrossSubscriptionRestoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.FeatureSettings_STATUS Class containing feature settings of vault</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesFeatureSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CrossRegionRestoreSettings_STATUS</summary>
    [JsonPropertyName("crossRegionRestoreSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesFeatureSettingsCrossRegionRestoreSettings? CrossRegionRestoreSettings { get; set; }

    /// <summary>Storage version of v1api20231101.CrossSubscriptionRestoreSettings_STATUS CrossSubscriptionRestore Settings</summary>
    [JsonPropertyName("crossSubscriptionRestoreSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesFeatureSettingsCrossSubscriptionRestoreSettings? CrossSubscriptionRestoreSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureMonitorAlertSettings_STATUS Settings for Azure Monitor based alerts</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesMonitoringSettingsAzureMonitorAlertSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertsForAllJobFailures")]
    public string? AlertsForAllJobFailures { get; set; }
}

/// <summary>Storage version of v1api20231101.MonitoringSettings_STATUS Monitoring Settings</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesMonitoringSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureMonitorAlertSettings_STATUS Settings for Azure Monitor based alerts</summary>
    [JsonPropertyName("azureMonitorAlertSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesMonitoringSettingsAzureMonitorAlertSettings? AzureMonitorAlertSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.ResourceMoveDetails_STATUS ResourceMoveDetails will be returned in response to GetResource call from ARM</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesResourceMoveDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completionTimeUtc")]
    public string? CompletionTimeUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationId")]
    public string? OperationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceResourcePath")]
    public string? SourceResourcePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTimeUtc")]
    public string? StartTimeUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetResourcePath")]
    public string? TargetResourcePath { get; set; }
}

/// <summary>Storage version of v1api20231101.ImmutabilitySettings_STATUS Immutability Settings at vault level</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesSecuritySettingsImmutabilitySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.SoftDeleteSettings_STATUS Soft delete related settings</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesSecuritySettingsSoftDeleteSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionDurationInDays")]
    public double? RetentionDurationInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20231101.SecuritySettings_STATUS Class containing security settings of vault</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesSecuritySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.ImmutabilitySettings_STATUS Immutability Settings at vault level</summary>
    [JsonPropertyName("immutabilitySettings")]
    public V1api20231101storageBackupVaultStatusPropertiesSecuritySettingsImmutabilitySettings? ImmutabilitySettings { get; set; }

    /// <summary>Storage version of v1api20231101.SoftDeleteSettings_STATUS Soft delete related settings</summary>
    [JsonPropertyName("softDeleteSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesSecuritySettingsSoftDeleteSettings? SoftDeleteSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.StorageSetting_STATUS Storage setting</summary>
public partial class V1api20231101storageBackupVaultStatusPropertiesStorageSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datastoreType")]
    public string? DatastoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVault_STATUS Backup Vault</summary>
public partial class V1api20231101storageBackupVaultStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.FeatureSettings_STATUS Class containing feature settings of vault</summary>
    [JsonPropertyName("featureSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesFeatureSettings? FeatureSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isVaultProtectedByResourceGuard")]
    public bool? IsVaultProtectedByResourceGuard { get; set; }

    /// <summary>Storage version of v1api20231101.MonitoringSettings_STATUS Monitoring Settings</summary>
    [JsonPropertyName("monitoringSettings")]
    public V1api20231101storageBackupVaultStatusPropertiesMonitoringSettings? MonitoringSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicatedRegions")]
    public IList<string>? ReplicatedRegions { get; set; }

    /// <summary>Storage version of v1api20231101.ResourceMoveDetails_STATUS ResourceMoveDetails will be returned in response to GetResource call from ARM</summary>
    [JsonPropertyName("resourceMoveDetails")]
    public V1api20231101storageBackupVaultStatusPropertiesResourceMoveDetails? ResourceMoveDetails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceMoveState")]
    public string? ResourceMoveState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secureScore")]
    public string? SecureScore { get; set; }

    /// <summary>Storage version of v1api20231101.SecuritySettings_STATUS Class containing security settings of vault</summary>
    [JsonPropertyName("securitySettings")]
    public V1api20231101storageBackupVaultStatusPropertiesSecuritySettings? SecuritySettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageSettings")]
    public IList<V1api20231101storageBackupVaultStatusPropertiesStorageSettings>? StorageSettings { get; set; }
}

/// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
public partial class V1api20231101storageBackupVaultStatusSystemData
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

/// <summary>Storage version of v1api20231101.BackupVaultResource_STATUS Backup Vault Resource</summary>
public partial class V1api20231101storageBackupVaultStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101storageBackupVaultStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231101.DppIdentityDetails_STATUS Identity details</summary>
    [JsonPropertyName("identity")]
    public V1api20231101storageBackupVaultStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVault_STATUS Backup Vault</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101storageBackupVaultStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20231101.BackupVault Generator information: - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/stable/2023-11-01/dataprotection.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</summary>
public partial class V1api20231101storageBackupVault : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101storageBackupVaultSpec>, IStatus<V1api20231101storageBackupVaultStatus>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVault";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaults";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVault_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231101storageBackupVaultSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultResource_STATUS Backup Vault Resource</summary>
    [JsonPropertyName("status")]
    public V1api20231101storageBackupVaultStatus? Status { get; set; }
}