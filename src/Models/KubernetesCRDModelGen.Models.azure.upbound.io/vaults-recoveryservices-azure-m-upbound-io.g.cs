using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recoveryservices.azure.m.upbound.io;
/// <summary>An encryption block as defined below. Required with identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProviderEncryption
{
    /// <summary>Enabling/Disabling the Double Encryption state.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>The Key Vault key id used to encrypt this vault. Key managed by Vault Managed Hardware Security Module is also supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Indicate that system assigned identity should be used or not. Defaults to true. Must be set to false when user_assigned_identity_id is set.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>Specifies the user assigned identity ID to be used.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this App Configuration.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Recovery Services Vault. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A monitoring block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProviderMonitoring
{
    /// <summary>Enabling/Disabling built-in Azure Monitor alerts for security scenarios and job failure scenarios. Defaults to true.</summary>
    [JsonPropertyName("alertsForAllJobFailuresEnabled")]
    public bool? AlertsForAllJobFailuresEnabled { get; set; }

    /// <summary>Enabling/Disabling alerts from the older (classic alerts) solution. Defaults to true. More details could be found here.</summary>
    [JsonPropertyName("alertsForCriticalOperationFailuresEnabled")]
    public bool? AlertsForCriticalOperationFailuresEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1VaultSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VaultSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1VaultSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VaultSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecForProvider
{
    /// <summary>Whether to enable the Classic experience for VMware replication. If set to false VMware machines will be protected using the new stateless ASR replication appliance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("classicVmwareReplicationEnabled")]
    public bool? ClassicVmwareReplicationEnabled { get; set; }

    /// <summary>Is cross region restore enabled for this Vault? Only can be true, when storage_mode_type is GeoRedundant. Defaults to false.</summary>
    [JsonPropertyName("crossRegionRestoreEnabled")]
    public bool? CrossRegionRestoreEnabled { get; set; }

    /// <summary>An encryption block as defined below. Required with identity.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1VaultSpecForProviderEncryption? Encryption { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1VaultSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Immutability Settings of vault, possible values include: Locked, Unlocked and Disabled.</summary>
    [JsonPropertyName("immutability")]
    public string? Immutability { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A monitoring block as defined below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1VaultSpecForProviderMonitoring? Monitoring { get; set; }

    /// <summary>Is it enabled to access the vault from public networks. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Recovery Services Vault. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VaultSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VaultSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Sets the vault's SKU. Possible values include: Standard, RS0.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is soft delete enable for this Vault? Defaults to true.</summary>
    [JsonPropertyName("softDeleteEnabled")]
    public bool? SoftDeleteEnabled { get; set; }

    /// <summary>The storage type of the Recovery Services Vault. Possible values are GeoRedundant, LocallyRedundant and ZoneRedundant. Defaults to GeoRedundant.</summary>
    [JsonPropertyName("storageModeType")]
    public string? StorageModeType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An encryption block as defined below. Required with identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecInitProviderEncryption
{
    /// <summary>Enabling/Disabling the Double Encryption state.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>The Key Vault key id used to encrypt this vault. Key managed by Vault Managed Hardware Security Module is also supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Indicate that system assigned identity should be used or not. Defaults to true. Must be set to false when user_assigned_identity_id is set.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>Specifies the user assigned identity ID to be used.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this App Configuration.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Recovery Services Vault. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A monitoring block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecInitProviderMonitoring
{
    /// <summary>Enabling/Disabling built-in Azure Monitor alerts for security scenarios and job failure scenarios. Defaults to true.</summary>
    [JsonPropertyName("alertsForAllJobFailuresEnabled")]
    public bool? AlertsForAllJobFailuresEnabled { get; set; }

    /// <summary>Enabling/Disabling alerts from the older (classic alerts) solution. Defaults to true. More details could be found here.</summary>
    [JsonPropertyName("alertsForCriticalOperationFailuresEnabled")]
    public bool? AlertsForCriticalOperationFailuresEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecInitProvider
{
    /// <summary>Whether to enable the Classic experience for VMware replication. If set to false VMware machines will be protected using the new stateless ASR replication appliance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("classicVmwareReplicationEnabled")]
    public bool? ClassicVmwareReplicationEnabled { get; set; }

    /// <summary>Is cross region restore enabled for this Vault? Only can be true, when storage_mode_type is GeoRedundant. Defaults to false.</summary>
    [JsonPropertyName("crossRegionRestoreEnabled")]
    public bool? CrossRegionRestoreEnabled { get; set; }

    /// <summary>An encryption block as defined below. Required with identity.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1VaultSpecInitProviderEncryption? Encryption { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1VaultSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Immutability Settings of vault, possible values include: Locked, Unlocked and Disabled.</summary>
    [JsonPropertyName("immutability")]
    public string? Immutability { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A monitoring block as defined below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1VaultSpecInitProviderMonitoring? Monitoring { get; set; }

    /// <summary>Is it enabled to access the vault from public networks. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Sets the vault's SKU. Possible values include: Standard, RS0.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is soft delete enable for this Vault? Defaults to true.</summary>
    [JsonPropertyName("softDeleteEnabled")]
    public bool? SoftDeleteEnabled { get; set; }

    /// <summary>The storage type of the Recovery Services Vault. Possible values are GeoRedundant, LocallyRedundant and ZoneRedundant. Defaults to GeoRedundant.</summary>
    [JsonPropertyName("storageModeType")]
    public string? StorageModeType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VaultSpec defines the desired state of Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VaultSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VaultSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VaultSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VaultSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An encryption block as defined below. Required with identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatusAtProviderEncryption
{
    /// <summary>Enabling/Disabling the Double Encryption state.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>The Key Vault key id used to encrypt this vault. Key managed by Vault Managed Hardware Security Module is also supported.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Indicate that system assigned identity should be used or not. Defaults to true. Must be set to false when user_assigned_identity_id is set.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>Specifies the user assigned identity ID to be used.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this App Configuration.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Recovery Services Vault. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A monitoring block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatusAtProviderMonitoring
{
    /// <summary>Enabling/Disabling built-in Azure Monitor alerts for security scenarios and job failure scenarios. Defaults to true.</summary>
    [JsonPropertyName("alertsForAllJobFailuresEnabled")]
    public bool? AlertsForAllJobFailuresEnabled { get; set; }

    /// <summary>Enabling/Disabling alerts from the older (classic alerts) solution. Defaults to true. More details could be found here.</summary>
    [JsonPropertyName("alertsForCriticalOperationFailuresEnabled")]
    public bool? AlertsForCriticalOperationFailuresEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatusAtProvider
{
    /// <summary>Whether to enable the Classic experience for VMware replication. If set to false VMware machines will be protected using the new stateless ASR replication appliance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("classicVmwareReplicationEnabled")]
    public bool? ClassicVmwareReplicationEnabled { get; set; }

    /// <summary>Is cross region restore enabled for this Vault? Only can be true, when storage_mode_type is GeoRedundant. Defaults to false.</summary>
    [JsonPropertyName("crossRegionRestoreEnabled")]
    public bool? CrossRegionRestoreEnabled { get; set; }

    /// <summary>An encryption block as defined below. Required with identity.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1VaultStatusAtProviderEncryption? Encryption { get; set; }

    /// <summary>The ID of the Recovery Services Vault.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1VaultStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Immutability Settings of vault, possible values include: Locked, Unlocked and Disabled.</summary>
    [JsonPropertyName("immutability")]
    public string? Immutability { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A monitoring block as defined below.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1VaultStatusAtProviderMonitoring? Monitoring { get; set; }

    /// <summary>Is it enabled to access the vault from public networks. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Recovery Services Vault. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Sets the vault's SKU. Possible values include: Standard, RS0.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is soft delete enable for this Vault? Defaults to true.</summary>
    [JsonPropertyName("softDeleteEnabled")]
    public bool? SoftDeleteEnabled { get; set; }

    /// <summary>The storage type of the Recovery Services Vault. Possible values are GeoRedundant, LocallyRedundant and ZoneRedundant. Defaults to GeoRedundant.</summary>
    [JsonPropertyName("storageModeType")]
    public string? StorageModeType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatusConditions
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

/// <summary>VaultStatus defines the observed state of Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VaultStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VaultStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VaultStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Vault is the Schema for the Vaults API. Manages a Recovery Services Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Vault : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VaultSpec>, IStatus<V1beta1VaultStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Vault";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "vaults";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VaultSpec defines the desired state of Vault</summary>
    [JsonPropertyName("spec")]
    public V1beta1VaultSpec Spec { get; set; }

    /// <summary>VaultStatus defines the observed state of Vault.</summary>
    [JsonPropertyName("status")]
    public V1beta1VaultStatus? Status { get; set; }
}

/// <summary>Vault is the Schema for the Vaults API. Manages a Recovery Services Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VaultList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Vault>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VaultList";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "vaults";
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
    public IList<V1beta1Vault> Items { get; set; }
}