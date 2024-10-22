using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>Storage version of v1api20231115.AnalyticalStorageConfiguration Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecAnalyticalStorageConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>Storage version of v1api20231115.ApiProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecApiProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>Storage version of v1api20231115.ContinuousModeProperties Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicyMigrationState The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyContinuousMigrationState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20231115.ContinuousModeBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyContinuous
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ContinuousModeProperties Configuration values for periodic mode backup</summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicyMigrationState The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicyMigrationState The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodicMigrationState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20231115.PeriodicModeProperties Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupStorageRedundancy")]
    public string? BackupStorageRedundancy { get; set; }
}

/// <summary>Storage version of v1api20231115.PeriodicModeBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodic
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicyMigrationState The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>Storage version of v1api20231115.PeriodicModeProperties Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecBackupPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ContinuousModeBackupPolicy</summary>
    [JsonPropertyName("continuous")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Storage version of v1api20231115.PeriodicModeBackupPolicy</summary>
    [JsonPropertyName("periodic")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Storage version of v1api20231115.Capability Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.Capacity The object that represents all properties related to capacity enforcement on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>Storage version of v1api20231115.ConsistencyPolicy The consistency policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecConsistencyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>Storage version of v1api20231115.CorsPolicy The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20231115.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20231115storageDatabaseAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20231115.ManagedServiceIdentity Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20231115storageDatabaseAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20231115.IpAddressOrRange IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>Storage version of v1api20231115.Location A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecNetworkAclBypassResourceReferences
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

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccountOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("documentEndpoint")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint? DocumentEndpoint { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccountOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccountOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseRestoreResource Specific Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecRestoreParametersDatabasesToRestore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Storage version of v1api20231115.GremlinDatabaseRestoreResource Specific Gremlin Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>Storage version of v1api20231115.RestoreParameters Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20231115storageDatabaseAccountSpecRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20231115storageDatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreMode")]
    public string? RestoreMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>Reference: Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecVirtualNetworkRulesReference
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

/// <summary>Storage version of v1api20231115.VirtualNetworkRule Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpecVirtualNetworkRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }

    /// <summary>Reference: Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.</summary>
    [JsonPropertyName("reference")]
    public V1api20231115storageDatabaseAccountSpecVirtualNetworkRulesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccount_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AnalyticalStorageConfiguration Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20231115storageDatabaseAccountSpecAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>Storage version of v1api20231115.ApiProperties</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20231115storageDatabaseAccountSpecApiProperties? ApiProperties { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicy</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231115storageDatabaseAccountSpecBackupPolicy? BackupPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20231115storageDatabaseAccountSpecCapabilities>? Capabilities { get; set; }

    /// <summary>Storage version of v1api20231115.Capacity The object that represents all properties related to capacity enforcement on an account.</summary>
    [JsonPropertyName("capacity")]
    public V1api20231115storageDatabaseAccountSpecCapacity? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>Storage version of v1api20231115.ConsistencyPolicy The consistency policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20231115storageDatabaseAccountSpecConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cors")]
    public IList<V1api20231115storageDatabaseAccountSpecCors>? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerManagedKeyStatus")]
    public string? CustomerManagedKeyStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    /// <summary>Storage version of v1api20231115.ManagedServiceIdentity Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231115storageDatabaseAccountSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231115storageDatabaseAccountSpecIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<V1api20231115storageDatabaseAccountSpecLocations>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAclBypassResourceReferences")]
    public IList<V1api20231115storageDatabaseAccountSpecNetworkAclBypassResourceReferences>? NetworkAclBypassResourceReferences { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccountOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115storageDatabaseAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231115storageDatabaseAccountSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParameters Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageDatabaseAccountSpecRestoreParameters? RestoreParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20231115storageDatabaseAccountSpecVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>Storage version of v1api20231115.AnalyticalStorageConfiguration_STATUS Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusAnalyticalStorageConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>Storage version of v1api20231115.ApiProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusApiProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>Storage version of v1api20231115.ContinuousModeProperties_STATUS Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicyMigrationState_STATUS The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyContinuousMigrationState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20231115.ContinuousModeBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyContinuous
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ContinuousModeProperties_STATUS Configuration values for periodic mode backup</summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicyMigrationState_STATUS The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicyMigrationState_STATUS The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodicMigrationState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20231115.PeriodicModeProperties_STATUS Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupStorageRedundancy")]
    public string? BackupStorageRedundancy { get; set; }
}

/// <summary>Storage version of v1api20231115.PeriodicModeBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodic
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicyMigrationState_STATUS The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>Storage version of v1api20231115.PeriodicModeProperties_STATUS Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.BackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusBackupPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.ContinuousModeBackupPolicy_STATUS</summary>
    [JsonPropertyName("continuous")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Storage version of v1api20231115.PeriodicModeBackupPolicy_STATUS</summary>
    [JsonPropertyName("periodic")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Storage version of v1api20231115.Capability_STATUS Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.Capacity_STATUS The object that represents all properties related to capacity enforcement on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusConditions
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

/// <summary>Storage version of v1api20231115.ConsistencyPolicy_STATUS The consistency policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusConsistencyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>Storage version of v1api20231115.CorsPolicy_STATUS The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>Storage version of v1api20231115.FailoverPolicy_STATUS The failover policy for a given region of a database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusFailoverPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>Storage version of v1api20231115.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20231115.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusIdentity
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
    public IDictionary<string, V1api20231115storageDatabaseAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20231115.IpAddressOrRange_STATUS IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusKeysMetadataPrimaryMasterKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusKeysMetadataSecondaryMasterKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccountKeysMetadata_STATUS The metadata related to each access key for the given Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusKeysMetadata
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20231115storageDatabaseAccountStatusKeysMetadataPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20231115storageDatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20231115storageDatabaseAccountStatusKeysMetadataSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>Storage version of v1api20231115.AccountKeyMetadata_STATUS The metadata related to an access key for a given database account.</summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20231115storageDatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>Storage version of v1api20231115.Location_STATUS A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20231115.PrivateEndpointConnection_STATUS A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20231115.Location_STATUS A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusReadLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseRestoreResource_STATUS Specific Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusRestoreParametersDatabasesToRestore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Storage version of v1api20231115.GremlinDatabaseRestoreResource_STATUS Specific Gremlin Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>Storage version of v1api20231115.RestoreParameters_STATUS Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20231115storageDatabaseAccountStatusRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20231115storageDatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreMode")]
    public string? RestoreMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>Storage version of v1api20231115.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusSystemData
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

/// <summary>Storage version of v1api20231115.VirtualNetworkRule_STATUS Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusVirtualNetworkRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
}

/// <summary>Storage version of v1api20231115.Location_STATUS A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatusWriteLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccount_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageDatabaseAccountStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AnalyticalStorageConfiguration_STATUS Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20231115storageDatabaseAccountStatusAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>Storage version of v1api20231115.ApiProperties_STATUS</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20231115storageDatabaseAccountStatusApiProperties? ApiProperties { get; set; }

    /// <summary>Storage version of v1api20231115.BackupPolicy_STATUS</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231115storageDatabaseAccountStatusBackupPolicy? BackupPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20231115storageDatabaseAccountStatusCapabilities>? Capabilities { get; set; }

    /// <summary>Storage version of v1api20231115.Capacity_STATUS The object that represents all properties related to capacity enforcement on an account.</summary>
    [JsonPropertyName("capacity")]
    public V1api20231115storageDatabaseAccountStatusCapacity? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageDatabaseAccountStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>Storage version of v1api20231115.ConsistencyPolicy_STATUS The consistency policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20231115storageDatabaseAccountStatusConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cors")]
    public IList<V1api20231115storageDatabaseAccountStatusCors>? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerManagedKeyStatus")]
    public string? CustomerManagedKeyStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failoverPolicies")]
    public IList<V1api20231115storageDatabaseAccountStatusFailoverPolicies>? FailoverPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231115.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231115storageDatabaseAccountStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231115storageDatabaseAccountStatusIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccountKeysMetadata_STATUS The metadata related to each access key for the given Cosmos DB database account.</summary>
    [JsonPropertyName("keysMetadata")]
    public V1api20231115storageDatabaseAccountStatusKeysMetadata? KeysMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<V1api20231115storageDatabaseAccountStatusLocations>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkAclBypassResourceIds")]
    public IList<string>? NetworkAclBypassResourceIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20231115storageDatabaseAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readLocations")]
    public IList<V1api20231115storageDatabaseAccountStatusReadLocations>? ReadLocations { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParameters_STATUS Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageDatabaseAccountStatusRestoreParameters? RestoreParameters { get; set; }

    /// <summary>Storage version of v1api20231115.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231115storageDatabaseAccountStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20231115storageDatabaseAccountStatusVirtualNetworkRules>? VirtualNetworkRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeLocations")]
    public IList<V1api20231115storageDatabaseAccountStatusWriteLocations>? WriteLocations { get; set; }
}

/// <summary>Storage version of v1api20231115.DatabaseAccount Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2023-11-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageDatabaseAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageDatabaseAccountSpec>, IStatus<V1api20231115storageDatabaseAccountStatus>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "DatabaseAccount";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageDatabaseAccountSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.DatabaseAccount_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageDatabaseAccountStatus? Status { get; set; }
}