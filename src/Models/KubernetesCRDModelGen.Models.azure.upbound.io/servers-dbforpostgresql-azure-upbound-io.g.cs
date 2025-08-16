using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbforpostgresql.azure.upbound.io;
/// <summary>Server is the Schema for the Servers API. Manages a PostgreSQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Server>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServerList";
    public const string KubeGroup = "dbforpostgresql.azure.upbound.io";
    public const string KubePluralName = "servers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1Server> Items { get; set; }
}

/// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderAdministratorLoginPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Server. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values are Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration and Unsafe_Action.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered?</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public bool? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Is the policy enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta1ServerSpecForProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecForProvider
{
    /// <summary>The Administrator login for the PostgreSQL Server. Required when create_mode is Default. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta1ServerSpecForProviderAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
    [JsonPropertyName("administratorLoginPasswordWo")]
    public string? AdministratorLoginPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_login_password_wo. This property should be incremented when updating administrator_login_password_wo.</summary>
    [JsonPropertyName("administratorLoginPasswordWoVersion")]
    public double? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>Enable/Disable auto-growing of the storage. Storage auto-grow prevents your server from running out of storage and becoming read-only. If storage auto grow is enabled, the storage automatically grows without impacting the workload. Defaults to true.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>Backup retention days for the server, supported values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode. Can be used to restore or replicate existing servers. Possible values are Default, Replica, GeoRestore, and PointInTimeRestore. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>For creation modes other than Default, the source server ID to use.</summary>
    [JsonPropertyName("creationSourceServerId")]
    public string? CreationSourceServerId { get; set; }

    /// <summary>Turn Geo-redundant server backups on/off. This allows you to choose between locally redundant or geo-redundant backup storage in the General Purpose and Memory Optimized tiers. When the backups are stored in geo-redundant backup storage, they are not only stored within the region in which your server is hosted, but are also replicated to a paired data center. This provides better protection and ability to restore your server in a different region in the event of a disaster. This is not support for the Basic tier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServerSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Whether or not infrastructure is encrypted for this server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the PostgreSQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ServerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ServerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>When create_mode is PointInTimeRestore the point in time to restore from creation_source_server_id. It should be provided in RFC3339 format, e.g. 2013-11-08T22:00:40Z.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the SKU Name for this PostgreSQL Server. The name of the SKU, follows the tier + family + cores pattern (e.g. B_Gen4_1, GP_Gen5_8). For more information see the product documentation. Possible values are B_Gen4_1, B_Gen4_2, B_Gen5_1, B_Gen5_2, GP_Gen4_2, GP_Gen4_4, GP_Gen4_8, GP_Gen4_16, GP_Gen4_32, GP_Gen5_2, GP_Gen5_4, GP_Gen5_8, GP_Gen5_16, GP_Gen5_32, GP_Gen5_64, MO_Gen5_2, MO_Gen5_4, MO_Gen5_8, MO_Gen5_16 and MO_Gen5_32.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies if SSL should be enforced on connections. Possible values are true and false.</summary>
    [JsonPropertyName("sslEnforcementEnabled")]
    public bool? SslEnforcementEnabled { get; set; }

    /// <summary>The minimum TLS version to support on the sever. Possible values are TLSEnforcementDisabled, TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2.</summary>
    [JsonPropertyName("sslMinimalTlsVersionEnforced")]
    public string? SslMinimalTlsVersionEnforced { get; set; }

    /// <summary>Max storage allowed for a server. Possible values are between 5120 MB(5GB) and 1048576 MB(1TB) for the Basic SKU and between 5120 MB(5GB) and 16777216 MB(16TB) for General Purpose/Memory Optimized SKUs. For more information see the product documentation.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration, known in the API as Server Security Alerts Policy. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public IList<V1beta1ServerSpecForProviderThreatDetectionPolicy>? ThreatDetectionPolicy { get; set; }

    /// <summary>Specifies the version of PostgreSQL to use. Valid values are 9.5, 9.6, 10, 10.0, 10.2 and 11. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecInitProviderAdministratorLoginPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecInitProviderIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Server. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecInitProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecInitProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values are Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration and Unsafe_Action.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered?</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public bool? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Is the policy enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>Specifies the identifier key of the Threat Detection audit storage account.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta1ServerSpecInitProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecInitProvider
{
    /// <summary>The Administrator login for the PostgreSQL Server. Required when create_mode is Default. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta1ServerSpecInitProviderAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
    [JsonPropertyName("administratorLoginPasswordWo")]
    public string? AdministratorLoginPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_login_password_wo. This property should be incremented when updating administrator_login_password_wo.</summary>
    [JsonPropertyName("administratorLoginPasswordWoVersion")]
    public double? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>Enable/Disable auto-growing of the storage. Storage auto-grow prevents your server from running out of storage and becoming read-only. If storage auto grow is enabled, the storage automatically grows without impacting the workload. Defaults to true.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>Backup retention days for the server, supported values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode. Can be used to restore or replicate existing servers. Possible values are Default, Replica, GeoRestore, and PointInTimeRestore. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>For creation modes other than Default, the source server ID to use.</summary>
    [JsonPropertyName("creationSourceServerId")]
    public string? CreationSourceServerId { get; set; }

    /// <summary>Turn Geo-redundant server backups on/off. This allows you to choose between locally redundant or geo-redundant backup storage in the General Purpose and Memory Optimized tiers. When the backups are stored in geo-redundant backup storage, they are not only stored within the region in which your server is hosted, but are also replicated to a paired data center. This provides better protection and ability to restore your server in a different region in the event of a disaster. This is not support for the Basic tier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServerSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Whether or not infrastructure is encrypted for this server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>When create_mode is PointInTimeRestore the point in time to restore from creation_source_server_id. It should be provided in RFC3339 format, e.g. 2013-11-08T22:00:40Z.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the SKU Name for this PostgreSQL Server. The name of the SKU, follows the tier + family + cores pattern (e.g. B_Gen4_1, GP_Gen5_8). For more information see the product documentation. Possible values are B_Gen4_1, B_Gen4_2, B_Gen5_1, B_Gen5_2, GP_Gen4_2, GP_Gen4_4, GP_Gen4_8, GP_Gen4_16, GP_Gen4_32, GP_Gen5_2, GP_Gen5_4, GP_Gen5_8, GP_Gen5_16, GP_Gen5_32, GP_Gen5_64, MO_Gen5_2, MO_Gen5_4, MO_Gen5_8, MO_Gen5_16 and MO_Gen5_32.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies if SSL should be enforced on connections. Possible values are true and false.</summary>
    [JsonPropertyName("sslEnforcementEnabled")]
    public bool? SslEnforcementEnabled { get; set; }

    /// <summary>The minimum TLS version to support on the sever. Possible values are TLSEnforcementDisabled, TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2.</summary>
    [JsonPropertyName("sslMinimalTlsVersionEnforced")]
    public string? SslMinimalTlsVersionEnforced { get; set; }

    /// <summary>Max storage allowed for a server. Possible values are between 5120 MB(5GB) and 1048576 MB(1TB) for the Basic SKU and between 5120 MB(5GB) and 16777216 MB(16TB) for General Purpose/Memory Optimized SKUs. For more information see the product documentation.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration, known in the API as Server Security Alerts Policy. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public IList<V1beta1ServerSpecInitProviderThreatDetectionPolicy>? ThreatDetectionPolicy { get; set; }

    /// <summary>Specifies the version of PostgreSQL to use. Valid values are 9.5, 9.6, 10, 10.0, 10.2 and 11. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ServerSpec defines the desired state of Server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerStatusAtProviderIdentity
{
    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Server. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerStatusAtProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values are Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration and Unsafe_Action.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered?</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public bool? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Is the policy enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerStatusAtProvider
{
    /// <summary>The Administrator login for the PostgreSQL Server. Required when create_mode is Default. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Server.</summary>
    [JsonPropertyName("administratorLoginPasswordWo")]
    public string? AdministratorLoginPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_login_password_wo. This property should be incremented when updating administrator_login_password_wo.</summary>
    [JsonPropertyName("administratorLoginPasswordWoVersion")]
    public double? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>Enable/Disable auto-growing of the storage. Storage auto-grow prevents your server from running out of storage and becoming read-only. If storage auto grow is enabled, the storage automatically grows without impacting the workload. Defaults to true.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>Backup retention days for the server, supported values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode. Can be used to restore or replicate existing servers. Possible values are Default, Replica, GeoRestore, and PointInTimeRestore. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>For creation modes other than Default, the source server ID to use.</summary>
    [JsonPropertyName("creationSourceServerId")]
    public string? CreationSourceServerId { get; set; }

    /// <summary>The FQDN of the PostgreSQL Server.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Turn Geo-redundant server backups on/off. This allows you to choose between locally redundant or geo-redundant backup storage in the General Purpose and Memory Optimized tiers. When the backups are stored in geo-redundant backup storage, they are not only stored within the region in which your server is hosted, but are also replicated to a paired data center. This provides better protection and ability to restore your server in a different region in the event of a disaster. This is not support for the Basic tier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>The ID of the PostgreSQL Server.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServerStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Whether or not infrastructure is encrypted for this server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the PostgreSQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>When create_mode is PointInTimeRestore the point in time to restore from creation_source_server_id. It should be provided in RFC3339 format, e.g. 2013-11-08T22:00:40Z.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the SKU Name for this PostgreSQL Server. The name of the SKU, follows the tier + family + cores pattern (e.g. B_Gen4_1, GP_Gen5_8). For more information see the product documentation. Possible values are B_Gen4_1, B_Gen4_2, B_Gen5_1, B_Gen5_2, GP_Gen4_2, GP_Gen4_4, GP_Gen4_8, GP_Gen4_16, GP_Gen4_32, GP_Gen5_2, GP_Gen5_4, GP_Gen5_8, GP_Gen5_16, GP_Gen5_32, GP_Gen5_64, MO_Gen5_2, MO_Gen5_4, MO_Gen5_8, MO_Gen5_16 and MO_Gen5_32.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies if SSL should be enforced on connections. Possible values are true and false.</summary>
    [JsonPropertyName("sslEnforcementEnabled")]
    public bool? SslEnforcementEnabled { get; set; }

    /// <summary>The minimum TLS version to support on the sever. Possible values are TLSEnforcementDisabled, TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2.</summary>
    [JsonPropertyName("sslMinimalTlsVersionEnforced")]
    public string? SslMinimalTlsVersionEnforced { get; set; }

    /// <summary>Max storage allowed for a server. Possible values are between 5120 MB(5GB) and 1048576 MB(1TB) for the Basic SKU and between 5120 MB(5GB) and 16777216 MB(16TB) for General Purpose/Memory Optimized SKUs. For more information see the product documentation.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration, known in the API as Server Security Alerts Policy. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public IList<V1beta1ServerStatusAtProviderThreatDetectionPolicy>? ThreatDetectionPolicy { get; set; }

    /// <summary>Specifies the version of PostgreSQL to use. Valid values are 9.5, 9.6, 10, 10.0, 10.2 and 11. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ServerStatus defines the observed state of Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Server is the Schema for the Servers API. Manages a PostgreSQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Server : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServerSpec>, IStatus<V1beta1ServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Server";
    public const string KubeGroup = "dbforpostgresql.azure.upbound.io";
    public const string KubePluralName = "servers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServerSpec defines the desired state of Server</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServerSpec Spec { get; set; }

    /// <summary>ServerStatus defines the observed state of Server.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServerStatus? Status { get; set; }
}