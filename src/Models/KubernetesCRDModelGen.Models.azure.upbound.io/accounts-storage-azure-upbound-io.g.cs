using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderAzureFilesAuthenticationActiveDirectory
{
    /// <summary>Specifies the domain GUID.</summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>Specifies the primary domain that the AD DNS server is authoritative for.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the security identifier (SID). This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>Specifies the Active Directory forest. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>Specifies the NetBIOS domain name. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("netbiosDomainName")]
    public string? NetbiosDomainName { get; set; }

    /// <summary>Specifies the security identifier (SID) for Azure Storage. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("storageSid")]
    public string? StorageSid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderAzureFilesAuthentication
{
    /// <summary>A active_directory block as defined below. Required when directory_type is AD.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1AccountSpecForProviderAzureFilesAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies the default share level permissions applied to all users. Possible values are StorageFileDataSmbShareReader, StorageFileDataSmbShareContributor, StorageFileDataSmbShareElevatedContributor, or None.</summary>
    [JsonPropertyName("defaultShareLevelPermission")]
    public string? DefaultShareLevelPermission { get; set; }

    /// <summary>Specifies the directory service used. Possible values are AADDS, AD and AADKERB.</summary>
    [JsonPropertyName("directoryType")]
    public string? DirectoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBlobPropertiesContainerDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBlobPropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBlobPropertiesDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether permanent deletion of the soft deleted blob versions and snapshots is allowed. Defaults to false.</summary>
    [JsonPropertyName("permanentDeleteEnabled")]
    public bool? PermanentDeleteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBlobPropertiesRestorePolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBlobProperties
{
    /// <summary>Is the blob service properties for change feed events enabled? Default to false.</summary>
    [JsonPropertyName("changeFeedEnabled")]
    public bool? ChangeFeedEnabled { get; set; }

    /// <summary>The duration of change feed events retention in days. The possible values are between 1 and 146000 days (400 years). Setting this to null (or omit this in the configuration file) indicates an infinite retention of the change feed.</summary>
    [JsonPropertyName("changeFeedRetentionInDays")]
    public double? ChangeFeedRetentionInDays { get; set; }

    /// <summary>A container_delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public IList<V1beta1AccountSpecForProviderBlobPropertiesContainerDeleteRetentionPolicy>? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecForProviderBlobPropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>The API Version which should be used by default for requests to the Data Plane API if an incoming request doesn't specify an API Version.</summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>A delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public IList<V1beta1AccountSpecForProviderBlobPropertiesDeleteRetentionPolicy>? DeleteRetentionPolicy { get; set; }

    /// <summary>Is the last access time based tracking enabled? Default to false.</summary>
    [JsonPropertyName("lastAccessTimeEnabled")]
    public bool? LastAccessTimeEnabled { get; set; }

    /// <summary>A restore_policy block as defined below. This must be used together with delete_retention_policy set, versioning_enabled and change_feed_enabled set to true.</summary>
    [JsonPropertyName("restorePolicy")]
    public IList<V1beta1AccountSpecForProviderBlobPropertiesRestorePolicy>? RestorePolicy { get; set; }

    /// <summary>Is versioning enabled? Default to false.</summary>
    [JsonPropertyName("versioningEnabled")]
    public bool? VersioningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderCustomDomain
{
    /// <summary>The Custom Domain Name to use for the Storage Account, which will be validated by Azure.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Should the Custom Domain Name be validated by using indirect CNAME validation?</summary>
    [JsonPropertyName("useSubdomain")]
    public bool? UseSubdomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderCustomerManagedKey
{
    /// <summary>The ID of the Key Vault Key, supplying a version-less key ID will enable auto-rotation of this key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>The ID of the managed HSM Key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }

    /// <summary>The ID of a user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Storage Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Storage Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderImmutabilityPolicy
{
    /// <summary>When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted.</summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>The immutability period for the blobs in the container since the policy creation, in days.</summary>
    [JsonPropertyName("periodSinceCreationInDays")]
    public double? PeriodSinceCreationInDays { get; set; }

    /// <summary>Defines the mode of the policy. Disabled state disables the policy, Unlocked state allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which cannot be reverted. Changing from Locked forces a new resource to be created.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRulesPrivateLinkAccess
{
    /// <summary>The ID of the Azure resource that should be allowed access to the target storage account.</summary>
    [JsonPropertyName("endpointResourceId")]
    public string? EndpointResourceId { get; set; }

    /// <summary>The tenant id of the resource of the resource access rule to be granted access. Defaults to the current tenant id.</summary>
    [JsonPropertyName("endpointTenantId")]
    public string? EndpointTenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in network to populate virtualNetworkSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderNetworkRules
{
    /// <summary>Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Valid options are any combination of Logging, Metrics, AzureServices, or None.</summary>
    [JsonPropertyName("bypass")]
    public IList<string>? Bypass { get; set; }

    /// <summary>Specifies the default action of allow or deny when no other rules match. Valid options are Deny or Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>List of public IP or IP ranges in CIDR Format. Only IPv4 addresses are allowed. /31 CIDRs, /32 CIDRs, and Private IP address ranges (as defined in RFC 1918), are not allowed.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>One or more private_link_access block as defined below.</summary>
    [JsonPropertyName("privateLinkAccess")]
    public IList<V1beta1AccountSpecForProviderNetworkRulesPrivateLinkAccess>? PrivateLinkAccess { get; set; }

    /// <summary>A list of resource ids for subnets.</summary>
    [JsonPropertyName("virtualNetworkSubnetIds")]
    public IList<string>? VirtualNetworkSubnetIds { get; set; }

    /// <summary>References to Subnet in network to populate virtualNetworkSubnetIds.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdsRefs")]
    public IList<V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsRefs>? VirtualNetworkSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in network to populate virtualNetworkSubnetIds.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdsSelector")]
    public V1beta1AccountSpecForProviderNetworkRulesVirtualNetworkSubnetIdsSelector? VirtualNetworkSubnetIdsSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderQueuePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderQueuePropertiesHourMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderQueuePropertiesLogging
{
    /// <summary>(Defaults to 1 hour) Used when deleting the Storage Account.</summary>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }

    /// <summary>(Defaults to 5 minutes) Used when retrieving the Storage Account.</summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Indicates whether all write requests should be logged.</summary>
    [JsonPropertyName("write")]
    public bool? Write { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderQueuePropertiesMinuteMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderQueueProperties
{
    /// <summary>A cors_rule block as defined above.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecForProviderQueuePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A hour_metrics block as defined below.</summary>
    [JsonPropertyName("hourMetrics")]
    public IList<V1beta1AccountSpecForProviderQueuePropertiesHourMetrics>? HourMetrics { get; set; }

    /// <summary>A logging block as defined below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1AccountSpecForProviderQueuePropertiesLogging>? Logging { get; set; }

    /// <summary>A minute_metrics block as defined below.</summary>
    [JsonPropertyName("minuteMetrics")]
    public IList<V1beta1AccountSpecForProviderQueuePropertiesMinuteMetrics>? MinuteMetrics { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1AccountSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1AccountSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRouting
{
    /// <summary>Specifies the kind of network routing opted by the user. Possible values are InternetRouting and MicrosoftRouting. Defaults to MicrosoftRouting.</summary>
    [JsonPropertyName("choice")]
    public string? Choice { get; set; }

    /// <summary>Should internet routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>Should Microsoft routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderSasPolicy
{
    /// <summary>The SAS expiration action. The only possible value is Log at this moment. Defaults to Log.</summary>
    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    /// <summary>The SAS expiration period in format of DD.HH:MM:SS.</summary>
    [JsonPropertyName("expirationPeriod")]
    public string? ExpirationPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderSharePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderSharePropertiesRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderSharePropertiesSmb
{
    /// <summary>A set of SMB authentication methods. Possible values are NTLMv2, and Kerberos.</summary>
    [JsonPropertyName("authenticationTypes")]
    public IList<string>? AuthenticationTypes { get; set; }

    /// <summary>A set of SMB channel encryption. Possible values are AES-128-CCM, AES-128-GCM, and AES-256-GCM.</summary>
    [JsonPropertyName("channelEncryptionType")]
    public IList<string>? ChannelEncryptionType { get; set; }

    /// <summary>A set of Kerberos ticket encryption. Possible values are RC4-HMAC, and AES-256.</summary>
    [JsonPropertyName("kerberosTicketEncryptionType")]
    public IList<string>? KerberosTicketEncryptionType { get; set; }

    /// <summary>Indicates whether multichannel is enabled. Defaults to false. This is only supported on Premium storage accounts.</summary>
    [JsonPropertyName("multichannelEnabled")]
    public bool? MultichannelEnabled { get; set; }

    /// <summary>A set of SMB protocol versions. Possible values are SMB2.1, SMB3.0, and SMB3.1.1.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderShareProperties
{
    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecForProviderSharePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A retention_policy block as defined below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1AccountSpecForProviderSharePropertiesRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>A smb block as defined below.</summary>
    [JsonPropertyName("smb")]
    public IList<V1beta1AccountSpecForProviderSharePropertiesSmb>? Smb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderStaticWebsite
{
    /// <summary>The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.</summary>
    [JsonPropertyName("error404Document")]
    public string? Error404Document { get; set; }

    /// <summary>The webpage that Azure Storage serves for requests to the root of a website or any subfolder. For example, index.html. The value is case-sensitive.</summary>
    [JsonPropertyName("indexDocument")]
    public string? IndexDocument { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProvider
{
    /// <summary>Defines the access tier for BlobStorage, FileStorage and StorageV2 accounts. Valid options are Hot, Cool, Cold and Premium. Defaults to Hot.</summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>Defines the Kind of account. Valid options are BlobStorage, BlockBlobStorage, FileStorage, Storage and StorageV2. Defaults to StorageV2.</summary>
    [JsonPropertyName("accountKind")]
    public string? AccountKind { get; set; }

    /// <summary>Defines the type of replication to use for this storage account. Valid options are LRS, GRS, RAGRS, ZRS, GZRS and RAGZRS. Changing this forces a new resource to be created when types LRS, GRS and RAGRS are changed to ZRS, GZRS or RAGZRS and vice versa.</summary>
    [JsonPropertyName("accountReplicationType")]
    public string? AccountReplicationType { get; set; }

    /// <summary>Defines the Tier to use for this storage account. Valid options are Standard and Premium. For BlockBlobStorage and FileStorage accounts only Premium is valid. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountTier")]
    public string? AccountTier { get; set; }

    /// <summary>Allow or disallow nested items within this Account to opt into being public. Defaults to true.</summary>
    [JsonPropertyName("allowNestedItemsToBePublic")]
    public bool? AllowNestedItemsToBePublic { get; set; }

    /// <summary>Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. Possible values are AAD and PrivateLink.</summary>
    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>A azure_files_authentication block as defined below.</summary>
    [JsonPropertyName("azureFilesAuthentication")]
    public IList<V1beta1AccountSpecForProviderAzureFilesAuthentication>? AzureFilesAuthentication { get; set; }

    /// <summary>A blob_properties block as defined below.</summary>
    [JsonPropertyName("blobProperties")]
    public IList<V1beta1AccountSpecForProviderBlobProperties>? BlobProperties { get; set; }

    /// <summary>Should cross Tenant replication be enabled? Defaults to false.</summary>
    [JsonPropertyName("crossTenantReplicationEnabled")]
    public bool? CrossTenantReplicationEnabled { get; set; }

    /// <summary>A custom_domain block as documented below.</summary>
    [JsonPropertyName("customDomain")]
    public IList<V1beta1AccountSpecForProviderCustomDomain>? CustomDomain { get; set; }

    /// <summary>A customer_managed_key block as documented below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1AccountSpecForProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Default to Azure Active Directory authorization in the Azure portal when accessing the Storage Account. The default value is false</summary>
    [JsonPropertyName("defaultToOauthAuthentication")]
    public bool? DefaultToOauthAuthentication { get; set; }

    /// <summary>Specifies which DNS endpoint type to use. Possible values are Standard and AzureDnsZone. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Storage Account should exist. Changing this forces a new Storage Account to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Boolean flag which forces HTTPS if enabled, see here for more information. Defaults to true.</summary>
    [JsonPropertyName("httpsTrafficOnlyEnabled")]
    public bool? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>An immutability_policy block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("immutabilityPolicy")]
    public IList<V1beta1AccountSpecForProviderImmutabilityPolicy>? ImmutabilityPolicy { get; set; }

    /// <summary>Is infrastructure encryption enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 (see here for more information). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>Are Large File Shares Enabled? Defaults to false.</summary>
    [JsonPropertyName("largeFileShareEnabled")]
    public bool? LargeFileShareEnabled { get; set; }

    /// <summary>Is Local User Enabled? Defaults to true.</summary>
    [JsonPropertyName("localUserEnabled")]
    public bool? LocalUserEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum supported TLS version for the storage account. Possible values are TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2 for new storage accounts.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rules block as documented below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1AccountSpecForProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Is NFSv3 protocol enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("nfsv3Enabled")]
    public bool? Nfsv3Enabled { get; set; }

    /// <summary>Whether the public network access is enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The encryption type of the queue service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("queueEncryptionKeyType")]
    public string? QueueEncryptionKeyType { get; set; }

    /// <summary>A queue_properties block as defined below.</summary>
    [JsonPropertyName("queueProperties")]
    public IList<V1beta1AccountSpecForProviderQueueProperties>? QueueProperties { get; set; }

    /// <summary>The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AccountSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AccountSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1AccountSpecForProviderRouting>? Routing { get; set; }

    /// <summary>A sas_policy block as defined below.</summary>
    [JsonPropertyName("sasPolicy")]
    public IList<V1beta1AccountSpecForProviderSasPolicy>? SasPolicy { get; set; }

    /// <summary>Boolean, enable SFTP for the storage account</summary>
    [JsonPropertyName("sftpEnabled")]
    public bool? SftpEnabled { get; set; }

    /// <summary>A share_properties block as defined below.</summary>
    [JsonPropertyName("shareProperties")]
    public IList<V1beta1AccountSpecForProviderShareProperties>? ShareProperties { get; set; }

    /// <summary>Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). Defaults to true.</summary>
    [JsonPropertyName("sharedAccessKeyEnabled")]
    public bool? SharedAccessKeyEnabled { get; set; }

    /// <summary>A static_website block as defined below.</summary>
    [JsonPropertyName("staticWebsite")]
    public IList<V1beta1AccountSpecForProviderStaticWebsite>? StaticWebsite { get; set; }

    /// <summary>The encryption type of the table service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("tableEncryptionKeyType")]
    public string? TableEncryptionKeyType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderAzureFilesAuthenticationActiveDirectory
{
    /// <summary>Specifies the domain GUID.</summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>Specifies the primary domain that the AD DNS server is authoritative for.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the security identifier (SID). This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>Specifies the Active Directory forest. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>Specifies the NetBIOS domain name. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("netbiosDomainName")]
    public string? NetbiosDomainName { get; set; }

    /// <summary>Specifies the security identifier (SID) for Azure Storage. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("storageSid")]
    public string? StorageSid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderAzureFilesAuthentication
{
    /// <summary>A active_directory block as defined below. Required when directory_type is AD.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1AccountSpecInitProviderAzureFilesAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies the default share level permissions applied to all users. Possible values are StorageFileDataSmbShareReader, StorageFileDataSmbShareContributor, StorageFileDataSmbShareElevatedContributor, or None.</summary>
    [JsonPropertyName("defaultShareLevelPermission")]
    public string? DefaultShareLevelPermission { get; set; }

    /// <summary>Specifies the directory service used. Possible values are AADDS, AD and AADKERB.</summary>
    [JsonPropertyName("directoryType")]
    public string? DirectoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBlobPropertiesContainerDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBlobPropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBlobPropertiesDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether permanent deletion of the soft deleted blob versions and snapshots is allowed. Defaults to false.</summary>
    [JsonPropertyName("permanentDeleteEnabled")]
    public bool? PermanentDeleteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBlobPropertiesRestorePolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBlobProperties
{
    /// <summary>Is the blob service properties for change feed events enabled? Default to false.</summary>
    [JsonPropertyName("changeFeedEnabled")]
    public bool? ChangeFeedEnabled { get; set; }

    /// <summary>The duration of change feed events retention in days. The possible values are between 1 and 146000 days (400 years). Setting this to null (or omit this in the configuration file) indicates an infinite retention of the change feed.</summary>
    [JsonPropertyName("changeFeedRetentionInDays")]
    public double? ChangeFeedRetentionInDays { get; set; }

    /// <summary>A container_delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public IList<V1beta1AccountSpecInitProviderBlobPropertiesContainerDeleteRetentionPolicy>? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecInitProviderBlobPropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>The API Version which should be used by default for requests to the Data Plane API if an incoming request doesn't specify an API Version.</summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>A delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public IList<V1beta1AccountSpecInitProviderBlobPropertiesDeleteRetentionPolicy>? DeleteRetentionPolicy { get; set; }

    /// <summary>Is the last access time based tracking enabled? Default to false.</summary>
    [JsonPropertyName("lastAccessTimeEnabled")]
    public bool? LastAccessTimeEnabled { get; set; }

    /// <summary>A restore_policy block as defined below. This must be used together with delete_retention_policy set, versioning_enabled and change_feed_enabled set to true.</summary>
    [JsonPropertyName("restorePolicy")]
    public IList<V1beta1AccountSpecInitProviderBlobPropertiesRestorePolicy>? RestorePolicy { get; set; }

    /// <summary>Is versioning enabled? Default to false.</summary>
    [JsonPropertyName("versioningEnabled")]
    public bool? VersioningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderCustomDomain
{
    /// <summary>The Custom Domain Name to use for the Storage Account, which will be validated by Azure.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Should the Custom Domain Name be validated by using indirect CNAME validation?</summary>
    [JsonPropertyName("useSubdomain")]
    public bool? UseSubdomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderCustomerManagedKey
{
    /// <summary>The ID of the Key Vault Key, supplying a version-less key ID will enable auto-rotation of this key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>The ID of the managed HSM Key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }

    /// <summary>The ID of a user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Storage Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Storage Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderImmutabilityPolicy
{
    /// <summary>When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted.</summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>The immutability period for the blobs in the container since the policy creation, in days.</summary>
    [JsonPropertyName("periodSinceCreationInDays")]
    public double? PeriodSinceCreationInDays { get; set; }

    /// <summary>Defines the mode of the policy. Disabled state disables the policy, Unlocked state allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which cannot be reverted. Changing from Locked forces a new resource to be created.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRulesPrivateLinkAccess
{
    /// <summary>The ID of the Azure resource that should be allowed access to the target storage account.</summary>
    [JsonPropertyName("endpointResourceId")]
    public string? EndpointResourceId { get; set; }

    /// <summary>The tenant id of the resource of the resource access rule to be granted access. Defaults to the current tenant id.</summary>
    [JsonPropertyName("endpointTenantId")]
    public string? EndpointTenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in network to populate virtualNetworkSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderNetworkRules
{
    /// <summary>Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Valid options are any combination of Logging, Metrics, AzureServices, or None.</summary>
    [JsonPropertyName("bypass")]
    public IList<string>? Bypass { get; set; }

    /// <summary>Specifies the default action of allow or deny when no other rules match. Valid options are Deny or Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>List of public IP or IP ranges in CIDR Format. Only IPv4 addresses are allowed. /31 CIDRs, /32 CIDRs, and Private IP address ranges (as defined in RFC 1918), are not allowed.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>One or more private_link_access block as defined below.</summary>
    [JsonPropertyName("privateLinkAccess")]
    public IList<V1beta1AccountSpecInitProviderNetworkRulesPrivateLinkAccess>? PrivateLinkAccess { get; set; }

    /// <summary>A list of resource ids for subnets.</summary>
    [JsonPropertyName("virtualNetworkSubnetIds")]
    public IList<string>? VirtualNetworkSubnetIds { get; set; }

    /// <summary>References to Subnet in network to populate virtualNetworkSubnetIds.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdsRefs")]
    public IList<V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsRefs>? VirtualNetworkSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in network to populate virtualNetworkSubnetIds.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdsSelector")]
    public V1beta1AccountSpecInitProviderNetworkRulesVirtualNetworkSubnetIdsSelector? VirtualNetworkSubnetIdsSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderQueuePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderQueuePropertiesHourMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderQueuePropertiesLogging
{
    /// <summary>(Defaults to 1 hour) Used when deleting the Storage Account.</summary>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }

    /// <summary>(Defaults to 5 minutes) Used when retrieving the Storage Account.</summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Indicates whether all write requests should be logged.</summary>
    [JsonPropertyName("write")]
    public bool? Write { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderQueuePropertiesMinuteMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderQueueProperties
{
    /// <summary>A cors_rule block as defined above.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecInitProviderQueuePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A hour_metrics block as defined below.</summary>
    [JsonPropertyName("hourMetrics")]
    public IList<V1beta1AccountSpecInitProviderQueuePropertiesHourMetrics>? HourMetrics { get; set; }

    /// <summary>A logging block as defined below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1AccountSpecInitProviderQueuePropertiesLogging>? Logging { get; set; }

    /// <summary>A minute_metrics block as defined below.</summary>
    [JsonPropertyName("minuteMetrics")]
    public IList<V1beta1AccountSpecInitProviderQueuePropertiesMinuteMetrics>? MinuteMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRouting
{
    /// <summary>Specifies the kind of network routing opted by the user. Possible values are InternetRouting and MicrosoftRouting. Defaults to MicrosoftRouting.</summary>
    [JsonPropertyName("choice")]
    public string? Choice { get; set; }

    /// <summary>Should internet routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>Should Microsoft routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderSasPolicy
{
    /// <summary>The SAS expiration action. The only possible value is Log at this moment. Defaults to Log.</summary>
    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    /// <summary>The SAS expiration period in format of DD.HH:MM:SS.</summary>
    [JsonPropertyName("expirationPeriod")]
    public string? ExpirationPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderSharePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderSharePropertiesRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderSharePropertiesSmb
{
    /// <summary>A set of SMB authentication methods. Possible values are NTLMv2, and Kerberos.</summary>
    [JsonPropertyName("authenticationTypes")]
    public IList<string>? AuthenticationTypes { get; set; }

    /// <summary>A set of SMB channel encryption. Possible values are AES-128-CCM, AES-128-GCM, and AES-256-GCM.</summary>
    [JsonPropertyName("channelEncryptionType")]
    public IList<string>? ChannelEncryptionType { get; set; }

    /// <summary>A set of Kerberos ticket encryption. Possible values are RC4-HMAC, and AES-256.</summary>
    [JsonPropertyName("kerberosTicketEncryptionType")]
    public IList<string>? KerberosTicketEncryptionType { get; set; }

    /// <summary>Indicates whether multichannel is enabled. Defaults to false. This is only supported on Premium storage accounts.</summary>
    [JsonPropertyName("multichannelEnabled")]
    public bool? MultichannelEnabled { get; set; }

    /// <summary>A set of SMB protocol versions. Possible values are SMB2.1, SMB3.0, and SMB3.1.1.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderShareProperties
{
    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecInitProviderSharePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A retention_policy block as defined below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1AccountSpecInitProviderSharePropertiesRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>A smb block as defined below.</summary>
    [JsonPropertyName("smb")]
    public IList<V1beta1AccountSpecInitProviderSharePropertiesSmb>? Smb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderStaticWebsite
{
    /// <summary>The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.</summary>
    [JsonPropertyName("error404Document")]
    public string? Error404Document { get; set; }

    /// <summary>The webpage that Azure Storage serves for requests to the root of a website or any subfolder. For example, index.html. The value is case-sensitive.</summary>
    [JsonPropertyName("indexDocument")]
    public string? IndexDocument { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProvider
{
    /// <summary>Defines the access tier for BlobStorage, FileStorage and StorageV2 accounts. Valid options are Hot, Cool, Cold and Premium. Defaults to Hot.</summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>Defines the Kind of account. Valid options are BlobStorage, BlockBlobStorage, FileStorage, Storage and StorageV2. Defaults to StorageV2.</summary>
    [JsonPropertyName("accountKind")]
    public string? AccountKind { get; set; }

    /// <summary>Defines the type of replication to use for this storage account. Valid options are LRS, GRS, RAGRS, ZRS, GZRS and RAGZRS. Changing this forces a new resource to be created when types LRS, GRS and RAGRS are changed to ZRS, GZRS or RAGZRS and vice versa.</summary>
    [JsonPropertyName("accountReplicationType")]
    public string? AccountReplicationType { get; set; }

    /// <summary>Defines the Tier to use for this storage account. Valid options are Standard and Premium. For BlockBlobStorage and FileStorage accounts only Premium is valid. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountTier")]
    public string? AccountTier { get; set; }

    /// <summary>Allow or disallow nested items within this Account to opt into being public. Defaults to true.</summary>
    [JsonPropertyName("allowNestedItemsToBePublic")]
    public bool? AllowNestedItemsToBePublic { get; set; }

    /// <summary>Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. Possible values are AAD and PrivateLink.</summary>
    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>A azure_files_authentication block as defined below.</summary>
    [JsonPropertyName("azureFilesAuthentication")]
    public IList<V1beta1AccountSpecInitProviderAzureFilesAuthentication>? AzureFilesAuthentication { get; set; }

    /// <summary>A blob_properties block as defined below.</summary>
    [JsonPropertyName("blobProperties")]
    public IList<V1beta1AccountSpecInitProviderBlobProperties>? BlobProperties { get; set; }

    /// <summary>Should cross Tenant replication be enabled? Defaults to false.</summary>
    [JsonPropertyName("crossTenantReplicationEnabled")]
    public bool? CrossTenantReplicationEnabled { get; set; }

    /// <summary>A custom_domain block as documented below.</summary>
    [JsonPropertyName("customDomain")]
    public IList<V1beta1AccountSpecInitProviderCustomDomain>? CustomDomain { get; set; }

    /// <summary>A customer_managed_key block as documented below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1AccountSpecInitProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Default to Azure Active Directory authorization in the Azure portal when accessing the Storage Account. The default value is false</summary>
    [JsonPropertyName("defaultToOauthAuthentication")]
    public bool? DefaultToOauthAuthentication { get; set; }

    /// <summary>Specifies which DNS endpoint type to use. Possible values are Standard and AzureDnsZone. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Storage Account should exist. Changing this forces a new Storage Account to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Boolean flag which forces HTTPS if enabled, see here for more information. Defaults to true.</summary>
    [JsonPropertyName("httpsTrafficOnlyEnabled")]
    public bool? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>An immutability_policy block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("immutabilityPolicy")]
    public IList<V1beta1AccountSpecInitProviderImmutabilityPolicy>? ImmutabilityPolicy { get; set; }

    /// <summary>Is infrastructure encryption enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 (see here for more information). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>Are Large File Shares Enabled? Defaults to false.</summary>
    [JsonPropertyName("largeFileShareEnabled")]
    public bool? LargeFileShareEnabled { get; set; }

    /// <summary>Is Local User Enabled? Defaults to true.</summary>
    [JsonPropertyName("localUserEnabled")]
    public bool? LocalUserEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum supported TLS version for the storage account. Possible values are TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2 for new storage accounts.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rules block as documented below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1AccountSpecInitProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Is NFSv3 protocol enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("nfsv3Enabled")]
    public bool? Nfsv3Enabled { get; set; }

    /// <summary>Whether the public network access is enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The encryption type of the queue service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("queueEncryptionKeyType")]
    public string? QueueEncryptionKeyType { get; set; }

    /// <summary>A queue_properties block as defined below.</summary>
    [JsonPropertyName("queueProperties")]
    public IList<V1beta1AccountSpecInitProviderQueueProperties>? QueueProperties { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1AccountSpecInitProviderRouting>? Routing { get; set; }

    /// <summary>A sas_policy block as defined below.</summary>
    [JsonPropertyName("sasPolicy")]
    public IList<V1beta1AccountSpecInitProviderSasPolicy>? SasPolicy { get; set; }

    /// <summary>Boolean, enable SFTP for the storage account</summary>
    [JsonPropertyName("sftpEnabled")]
    public bool? SftpEnabled { get; set; }

    /// <summary>A share_properties block as defined below.</summary>
    [JsonPropertyName("shareProperties")]
    public IList<V1beta1AccountSpecInitProviderShareProperties>? ShareProperties { get; set; }

    /// <summary>Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). Defaults to true.</summary>
    [JsonPropertyName("sharedAccessKeyEnabled")]
    public bool? SharedAccessKeyEnabled { get; set; }

    /// <summary>A static_website block as defined below.</summary>
    [JsonPropertyName("staticWebsite")]
    public IList<V1beta1AccountSpecInitProviderStaticWebsite>? StaticWebsite { get; set; }

    /// <summary>The encryption type of the table service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("tableEncryptionKeyType")]
    public string? TableEncryptionKeyType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecProviderConfigRefPolicy
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
public partial class V1beta1AccountSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccountSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccountSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccountSpec defines the desired state of Account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccountSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccountSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccountSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderAzureFilesAuthenticationActiveDirectory
{
    /// <summary>Specifies the domain GUID.</summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>Specifies the primary domain that the AD DNS server is authoritative for.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the security identifier (SID). This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>Specifies the Active Directory forest. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>Specifies the NetBIOS domain name. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("netbiosDomainName")]
    public string? NetbiosDomainName { get; set; }

    /// <summary>Specifies the security identifier (SID) for Azure Storage. This is required when directory_type is set to AD.</summary>
    [JsonPropertyName("storageSid")]
    public string? StorageSid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderAzureFilesAuthentication
{
    /// <summary>A active_directory block as defined below. Required when directory_type is AD.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1AccountStatusAtProviderAzureFilesAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>Specifies the default share level permissions applied to all users. Possible values are StorageFileDataSmbShareReader, StorageFileDataSmbShareContributor, StorageFileDataSmbShareElevatedContributor, or None.</summary>
    [JsonPropertyName("defaultShareLevelPermission")]
    public string? DefaultShareLevelPermission { get; set; }

    /// <summary>Specifies the directory service used. Possible values are AADDS, AD and AADKERB.</summary>
    [JsonPropertyName("directoryType")]
    public string? DirectoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBlobPropertiesContainerDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBlobPropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBlobPropertiesDeleteRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether permanent deletion of the soft deleted blob versions and snapshots is allowed. Defaults to false.</summary>
    [JsonPropertyName("permanentDeleteEnabled")]
    public bool? PermanentDeleteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBlobPropertiesRestorePolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBlobProperties
{
    /// <summary>Is the blob service properties for change feed events enabled? Default to false.</summary>
    [JsonPropertyName("changeFeedEnabled")]
    public bool? ChangeFeedEnabled { get; set; }

    /// <summary>The duration of change feed events retention in days. The possible values are between 1 and 146000 days (400 years). Setting this to null (or omit this in the configuration file) indicates an infinite retention of the change feed.</summary>
    [JsonPropertyName("changeFeedRetentionInDays")]
    public double? ChangeFeedRetentionInDays { get; set; }

    /// <summary>A container_delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public IList<V1beta1AccountStatusAtProviderBlobPropertiesContainerDeleteRetentionPolicy>? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountStatusAtProviderBlobPropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>The API Version which should be used by default for requests to the Data Plane API if an incoming request doesn't specify an API Version.</summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>A delete_retention_policy block as defined below.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public IList<V1beta1AccountStatusAtProviderBlobPropertiesDeleteRetentionPolicy>? DeleteRetentionPolicy { get; set; }

    /// <summary>Is the last access time based tracking enabled? Default to false.</summary>
    [JsonPropertyName("lastAccessTimeEnabled")]
    public bool? LastAccessTimeEnabled { get; set; }

    /// <summary>A restore_policy block as defined below. This must be used together with delete_retention_policy set, versioning_enabled and change_feed_enabled set to true.</summary>
    [JsonPropertyName("restorePolicy")]
    public IList<V1beta1AccountStatusAtProviderBlobPropertiesRestorePolicy>? RestorePolicy { get; set; }

    /// <summary>Is versioning enabled? Default to false.</summary>
    [JsonPropertyName("versioningEnabled")]
    public bool? VersioningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderCustomDomain
{
    /// <summary>The Custom Domain Name to use for the Storage Account, which will be validated by Azure.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Should the Custom Domain Name be validated by using indirect CNAME validation?</summary>
    [JsonPropertyName("useSubdomain")]
    public bool? UseSubdomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderCustomerManagedKey
{
    /// <summary>The ID of the Key Vault Key, supplying a version-less key ID will enable auto-rotation of this key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>The ID of the managed HSM Key. Exactly one of key_vault_key_id and managed_hsm_key_id may be specified.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }

    /// <summary>The ID of a user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Storage Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Identity of this Storage Account.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Identity of this Storage Account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Storage Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderImmutabilityPolicy
{
    /// <summary>When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted.</summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>The immutability period for the blobs in the container since the policy creation, in days.</summary>
    [JsonPropertyName("periodSinceCreationInDays")]
    public double? PeriodSinceCreationInDays { get; set; }

    /// <summary>Defines the mode of the policy. Disabled state disables the policy, Unlocked state allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which cannot be reverted. Changing from Locked forces a new resource to be created.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderNetworkRulesPrivateLinkAccess
{
    /// <summary>The ID of the Azure resource that should be allowed access to the target storage account.</summary>
    [JsonPropertyName("endpointResourceId")]
    public string? EndpointResourceId { get; set; }

    /// <summary>The tenant id of the resource of the resource access rule to be granted access. Defaults to the current tenant id.</summary>
    [JsonPropertyName("endpointTenantId")]
    public string? EndpointTenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderNetworkRules
{
    /// <summary>Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Valid options are any combination of Logging, Metrics, AzureServices, or None.</summary>
    [JsonPropertyName("bypass")]
    public IList<string>? Bypass { get; set; }

    /// <summary>Specifies the default action of allow or deny when no other rules match. Valid options are Deny or Allow.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>List of public IP or IP ranges in CIDR Format. Only IPv4 addresses are allowed. /31 CIDRs, /32 CIDRs, and Private IP address ranges (as defined in RFC 1918), are not allowed.</summary>
    [JsonPropertyName("ipRules")]
    public IList<string>? IpRules { get; set; }

    /// <summary>One or more private_link_access block as defined below.</summary>
    [JsonPropertyName("privateLinkAccess")]
    public IList<V1beta1AccountStatusAtProviderNetworkRulesPrivateLinkAccess>? PrivateLinkAccess { get; set; }

    /// <summary>A list of resource ids for subnets.</summary>
    [JsonPropertyName("virtualNetworkSubnetIds")]
    public IList<string>? VirtualNetworkSubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderQueuePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderQueuePropertiesHourMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderQueuePropertiesLogging
{
    /// <summary>(Defaults to 1 hour) Used when deleting the Storage Account.</summary>
    [JsonPropertyName("delete")]
    public bool? Delete { get; set; }

    /// <summary>(Defaults to 5 minutes) Used when retrieving the Storage Account.</summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Indicates whether all write requests should be logged.</summary>
    [JsonPropertyName("write")]
    public bool? Write { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderQueuePropertiesMinuteMetrics
{
    /// <summary>Indicates whether minute metrics are enabled for the Queue service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether metrics should generate summary statistics for called API operations.</summary>
    [JsonPropertyName("includeApis")]
    public bool? IncludeApis { get; set; }

    /// <summary>Specifies the number of days that logs will be retained.</summary>
    [JsonPropertyName("retentionPolicyDays")]
    public double? RetentionPolicyDays { get; set; }

    /// <summary>The version of storage analytics to configure.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderQueueProperties
{
    /// <summary>A cors_rule block as defined above.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountStatusAtProviderQueuePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A hour_metrics block as defined below.</summary>
    [JsonPropertyName("hourMetrics")]
    public IList<V1beta1AccountStatusAtProviderQueuePropertiesHourMetrics>? HourMetrics { get; set; }

    /// <summary>A logging block as defined below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1AccountStatusAtProviderQueuePropertiesLogging>? Logging { get; set; }

    /// <summary>A minute_metrics block as defined below.</summary>
    [JsonPropertyName("minuteMetrics")]
    public IList<V1beta1AccountStatusAtProviderQueuePropertiesMinuteMetrics>? MinuteMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderRouting
{
    /// <summary>Specifies the kind of network routing opted by the user. Possible values are InternetRouting and MicrosoftRouting. Defaults to MicrosoftRouting.</summary>
    [JsonPropertyName("choice")]
    public string? Choice { get; set; }

    /// <summary>Should internet routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>Should Microsoft routing storage endpoints be published? Defaults to false.</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderSasPolicy
{
    /// <summary>The SAS expiration action. The only possible value is Log at this moment. Defaults to Log.</summary>
    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    /// <summary>The SAS expiration period in format of DD.HH:MM:SS.</summary>
    [JsonPropertyName("expirationPeriod")]
    public string? ExpirationPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderSharePropertiesCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP methods that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderSharePropertiesRetentionPolicy
{
    /// <summary>Specifies the number of days that the azurerm_storage_share should be retained, between 1 and 365 days. Defaults to 7.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderSharePropertiesSmb
{
    /// <summary>A set of SMB authentication methods. Possible values are NTLMv2, and Kerberos.</summary>
    [JsonPropertyName("authenticationTypes")]
    public IList<string>? AuthenticationTypes { get; set; }

    /// <summary>A set of SMB channel encryption. Possible values are AES-128-CCM, AES-128-GCM, and AES-256-GCM.</summary>
    [JsonPropertyName("channelEncryptionType")]
    public IList<string>? ChannelEncryptionType { get; set; }

    /// <summary>A set of Kerberos ticket encryption. Possible values are RC4-HMAC, and AES-256.</summary>
    [JsonPropertyName("kerberosTicketEncryptionType")]
    public IList<string>? KerberosTicketEncryptionType { get; set; }

    /// <summary>Indicates whether multichannel is enabled. Defaults to false. This is only supported on Premium storage accounts.</summary>
    [JsonPropertyName("multichannelEnabled")]
    public bool? MultichannelEnabled { get; set; }

    /// <summary>A set of SMB protocol versions. Possible values are SMB2.1, SMB3.0, and SMB3.1.1.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderShareProperties
{
    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountStatusAtProviderSharePropertiesCorsRule>? CorsRule { get; set; }

    /// <summary>A retention_policy block as defined below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1AccountStatusAtProviderSharePropertiesRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>A smb block as defined below.</summary>
    [JsonPropertyName("smb")]
    public IList<V1beta1AccountStatusAtProviderSharePropertiesSmb>? Smb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderStaticWebsite
{
    /// <summary>The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.</summary>
    [JsonPropertyName("error404Document")]
    public string? Error404Document { get; set; }

    /// <summary>The webpage that Azure Storage serves for requests to the root of a website or any subfolder. For example, index.html. The value is case-sensitive.</summary>
    [JsonPropertyName("indexDocument")]
    public string? IndexDocument { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProvider
{
    /// <summary>Defines the access tier for BlobStorage, FileStorage and StorageV2 accounts. Valid options are Hot, Cool, Cold and Premium. Defaults to Hot.</summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>Defines the Kind of account. Valid options are BlobStorage, BlockBlobStorage, FileStorage, Storage and StorageV2. Defaults to StorageV2.</summary>
    [JsonPropertyName("accountKind")]
    public string? AccountKind { get; set; }

    /// <summary>Defines the type of replication to use for this storage account. Valid options are LRS, GRS, RAGRS, ZRS, GZRS and RAGZRS. Changing this forces a new resource to be created when types LRS, GRS and RAGRS are changed to ZRS, GZRS or RAGZRS and vice versa.</summary>
    [JsonPropertyName("accountReplicationType")]
    public string? AccountReplicationType { get; set; }

    /// <summary>Defines the Tier to use for this storage account. Valid options are Standard and Premium. For BlockBlobStorage and FileStorage accounts only Premium is valid. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountTier")]
    public string? AccountTier { get; set; }

    /// <summary>Allow or disallow nested items within this Account to opt into being public. Defaults to true.</summary>
    [JsonPropertyName("allowNestedItemsToBePublic")]
    public bool? AllowNestedItemsToBePublic { get; set; }

    /// <summary>Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. Possible values are AAD and PrivateLink.</summary>
    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>A azure_files_authentication block as defined below.</summary>
    [JsonPropertyName("azureFilesAuthentication")]
    public IList<V1beta1AccountStatusAtProviderAzureFilesAuthentication>? AzureFilesAuthentication { get; set; }

    /// <summary>A blob_properties block as defined below.</summary>
    [JsonPropertyName("blobProperties")]
    public IList<V1beta1AccountStatusAtProviderBlobProperties>? BlobProperties { get; set; }

    /// <summary>Should cross Tenant replication be enabled? Defaults to false.</summary>
    [JsonPropertyName("crossTenantReplicationEnabled")]
    public bool? CrossTenantReplicationEnabled { get; set; }

    /// <summary>A custom_domain block as documented below.</summary>
    [JsonPropertyName("customDomain")]
    public IList<V1beta1AccountStatusAtProviderCustomDomain>? CustomDomain { get; set; }

    /// <summary>A customer_managed_key block as documented below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1AccountStatusAtProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Default to Azure Active Directory authorization in the Azure portal when accessing the Storage Account. The default value is false</summary>
    [JsonPropertyName("defaultToOauthAuthentication")]
    public bool? DefaultToOauthAuthentication { get; set; }

    /// <summary>Specifies which DNS endpoint type to use. Possible values are Standard and AzureDnsZone. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Storage Account should exist. Changing this forces a new Storage Account to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Boolean flag which forces HTTPS if enabled, see here for more information. Defaults to true.</summary>
    [JsonPropertyName("httpsTrafficOnlyEnabled")]
    public bool? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>The ID of the Storage Account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>An immutability_policy block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("immutabilityPolicy")]
    public IList<V1beta1AccountStatusAtProviderImmutabilityPolicy>? ImmutabilityPolicy { get; set; }

    /// <summary>Is infrastructure encryption enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 (see here for more information). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>Are Large File Shares Enabled? Defaults to false.</summary>
    [JsonPropertyName("largeFileShareEnabled")]
    public bool? LargeFileShareEnabled { get; set; }

    /// <summary>Is Local User Enabled? Defaults to true.</summary>
    [JsonPropertyName("localUserEnabled")]
    public bool? LocalUserEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum supported TLS version for the storage account. Possible values are TLS1_0, TLS1_1, and TLS1_2. Defaults to TLS1_2 for new storage accounts.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rules block as documented below.</summary>
    [JsonPropertyName("networkRules")]
    public IList<V1beta1AccountStatusAtProviderNetworkRules>? NetworkRules { get; set; }

    /// <summary>Is NFSv3 protocol enabled? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("nfsv3Enabled")]
    public bool? Nfsv3Enabled { get; set; }

    /// <summary>The endpoint URL for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobEndpoint")]
    public string? PrimaryBlobEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobHost")]
    public string? PrimaryBlobHost { get; set; }

    /// <summary>The internet routing endpoint URL for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobInternetEndpoint")]
    public string? PrimaryBlobInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobInternetHost")]
    public string? PrimaryBlobInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobMicrosoftEndpoint")]
    public string? PrimaryBlobMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for blob storage in the primary location.</summary>
    [JsonPropertyName("primaryBlobMicrosoftHost")]
    public string? PrimaryBlobMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsEndpoint")]
    public string? PrimaryDfsEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsHost")]
    public string? PrimaryDfsHost { get; set; }

    /// <summary>The internet routing endpoint URL for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsInternetEndpoint")]
    public string? PrimaryDfsInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsInternetHost")]
    public string? PrimaryDfsInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsMicrosoftEndpoint")]
    public string? PrimaryDfsMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for DFS storage in the primary location.</summary>
    [JsonPropertyName("primaryDfsMicrosoftHost")]
    public string? PrimaryDfsMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileEndpoint")]
    public string? PrimaryFileEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileHost")]
    public string? PrimaryFileHost { get; set; }

    /// <summary>The internet routing endpoint URL for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileInternetEndpoint")]
    public string? PrimaryFileInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileInternetHost")]
    public string? PrimaryFileInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileMicrosoftEndpoint")]
    public string? PrimaryFileMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for file storage in the primary location.</summary>
    [JsonPropertyName("primaryFileMicrosoftHost")]
    public string? PrimaryFileMicrosoftHost { get; set; }

    /// <summary>The primary location of the storage account.</summary>
    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    /// <summary>The endpoint URL for queue storage in the primary location.</summary>
    [JsonPropertyName("primaryQueueEndpoint")]
    public string? PrimaryQueueEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for queue storage in the primary location.</summary>
    [JsonPropertyName("primaryQueueHost")]
    public string? PrimaryQueueHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for queue storage in the primary location.</summary>
    [JsonPropertyName("primaryQueueMicrosoftEndpoint")]
    public string? PrimaryQueueMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for queue storage in the primary location.</summary>
    [JsonPropertyName("primaryQueueMicrosoftHost")]
    public string? PrimaryQueueMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for table storage in the primary location.</summary>
    [JsonPropertyName("primaryTableEndpoint")]
    public string? PrimaryTableEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for table storage in the primary location.</summary>
    [JsonPropertyName("primaryTableHost")]
    public string? PrimaryTableHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for table storage in the primary location.</summary>
    [JsonPropertyName("primaryTableMicrosoftEndpoint")]
    public string? PrimaryTableMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for table storage in the primary location.</summary>
    [JsonPropertyName("primaryTableMicrosoftHost")]
    public string? PrimaryTableMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebEndpoint")]
    public string? PrimaryWebEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebHost")]
    public string? PrimaryWebHost { get; set; }

    /// <summary>The internet routing endpoint URL for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebInternetEndpoint")]
    public string? PrimaryWebInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebInternetHost")]
    public string? PrimaryWebInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebMicrosoftEndpoint")]
    public string? PrimaryWebMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for web storage in the primary location.</summary>
    [JsonPropertyName("primaryWebMicrosoftHost")]
    public string? PrimaryWebMicrosoftHost { get; set; }

    /// <summary>Whether the public network access is enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The encryption type of the queue service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("queueEncryptionKeyType")]
    public string? QueueEncryptionKeyType { get; set; }

    /// <summary>A queue_properties block as defined below.</summary>
    [JsonPropertyName("queueProperties")]
    public IList<V1beta1AccountStatusAtProviderQueueProperties>? QueueProperties { get; set; }

    /// <summary>The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1AccountStatusAtProviderRouting>? Routing { get; set; }

    /// <summary>A sas_policy block as defined below.</summary>
    [JsonPropertyName("sasPolicy")]
    public IList<V1beta1AccountStatusAtProviderSasPolicy>? SasPolicy { get; set; }

    /// <summary>The endpoint URL for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobEndpoint")]
    public string? SecondaryBlobEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobHost")]
    public string? SecondaryBlobHost { get; set; }

    /// <summary>The internet routing endpoint URL for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobInternetEndpoint")]
    public string? SecondaryBlobInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobInternetHost")]
    public string? SecondaryBlobInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobMicrosoftEndpoint")]
    public string? SecondaryBlobMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for blob storage in the secondary location.</summary>
    [JsonPropertyName("secondaryBlobMicrosoftHost")]
    public string? SecondaryBlobMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsEndpoint")]
    public string? SecondaryDfsEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsHost")]
    public string? SecondaryDfsHost { get; set; }

    /// <summary>The internet routing endpoint URL for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsInternetEndpoint")]
    public string? SecondaryDfsInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsInternetHost")]
    public string? SecondaryDfsInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsMicrosoftEndpoint")]
    public string? SecondaryDfsMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for DFS storage in the secondary location.</summary>
    [JsonPropertyName("secondaryDfsMicrosoftHost")]
    public string? SecondaryDfsMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileEndpoint")]
    public string? SecondaryFileEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileHost")]
    public string? SecondaryFileHost { get; set; }

    /// <summary>The internet routing endpoint URL for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileInternetEndpoint")]
    public string? SecondaryFileInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileInternetHost")]
    public string? SecondaryFileInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileMicrosoftEndpoint")]
    public string? SecondaryFileMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for file storage in the secondary location.</summary>
    [JsonPropertyName("secondaryFileMicrosoftHost")]
    public string? SecondaryFileMicrosoftHost { get; set; }

    /// <summary>The secondary location of the storage account.</summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>The endpoint URL for queue storage in the secondary location.</summary>
    [JsonPropertyName("secondaryQueueEndpoint")]
    public string? SecondaryQueueEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for queue storage in the secondary location.</summary>
    [JsonPropertyName("secondaryQueueHost")]
    public string? SecondaryQueueHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for queue storage in the secondary location.</summary>
    [JsonPropertyName("secondaryQueueMicrosoftEndpoint")]
    public string? SecondaryQueueMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for queue storage in the secondary location.</summary>
    [JsonPropertyName("secondaryQueueMicrosoftHost")]
    public string? SecondaryQueueMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for table storage in the secondary location.</summary>
    [JsonPropertyName("secondaryTableEndpoint")]
    public string? SecondaryTableEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for table storage in the secondary location.</summary>
    [JsonPropertyName("secondaryTableHost")]
    public string? SecondaryTableHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for table storage in the secondary location.</summary>
    [JsonPropertyName("secondaryTableMicrosoftEndpoint")]
    public string? SecondaryTableMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for table storage in the secondary location.</summary>
    [JsonPropertyName("secondaryTableMicrosoftHost")]
    public string? SecondaryTableMicrosoftHost { get; set; }

    /// <summary>The endpoint URL for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebEndpoint")]
    public string? SecondaryWebEndpoint { get; set; }

    /// <summary>The hostname with port if applicable for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebHost")]
    public string? SecondaryWebHost { get; set; }

    /// <summary>The internet routing endpoint URL for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebInternetEndpoint")]
    public string? SecondaryWebInternetEndpoint { get; set; }

    /// <summary>The internet routing hostname with port if applicable for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebInternetHost")]
    public string? SecondaryWebInternetHost { get; set; }

    /// <summary>The microsoft routing endpoint URL for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebMicrosoftEndpoint")]
    public string? SecondaryWebMicrosoftEndpoint { get; set; }

    /// <summary>The microsoft routing hostname with port if applicable for web storage in the secondary location.</summary>
    [JsonPropertyName("secondaryWebMicrosoftHost")]
    public string? SecondaryWebMicrosoftHost { get; set; }

    /// <summary>Boolean, enable SFTP for the storage account</summary>
    [JsonPropertyName("sftpEnabled")]
    public bool? SftpEnabled { get; set; }

    /// <summary>A share_properties block as defined below.</summary>
    [JsonPropertyName("shareProperties")]
    public IList<V1beta1AccountStatusAtProviderShareProperties>? ShareProperties { get; set; }

    /// <summary>Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). Defaults to true.</summary>
    [JsonPropertyName("sharedAccessKeyEnabled")]
    public bool? SharedAccessKeyEnabled { get; set; }

    /// <summary>A static_website block as defined below.</summary>
    [JsonPropertyName("staticWebsite")]
    public IList<V1beta1AccountStatusAtProviderStaticWebsite>? StaticWebsite { get; set; }

    /// <summary>The encryption type of the table service. Possible values are Service and Account. Changing this forces a new resource to be created. Default value is Service.</summary>
    [JsonPropertyName("tableEncryptionKeyType")]
    public string? TableEncryptionKeyType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusConditions
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

/// <summary>AccountStatus defines the observed state of Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Account is the Schema for the Accounts API. Manages a Azure Storage Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Account : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountSpec>, IStatus<V1beta1AccountStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Account";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "accounts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountSpec defines the desired state of Account</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccountSpec Spec { get; set; }

    /// <summary>AccountStatus defines the observed state of Account.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountStatus? Status { get; set; }
}

/// <summary>Account is the Schema for the Accounts API. Manages a Azure Storage Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Account>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountList";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "accounts";
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
    public IList<V1beta1Account> Items { get; set; }
}