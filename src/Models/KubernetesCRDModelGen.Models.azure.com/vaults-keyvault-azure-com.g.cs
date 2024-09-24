using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyvault.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesAccessPoliciesApplicationIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesAccessPoliciesObjectIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230701.Permissions Permissions the identity has for keys, secrets, certificates and storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesAccessPoliciesPermissions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storage")]
    public IList<string>? Storage { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesAccessPoliciesTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230701.AccessPolicyEntry An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesAccessPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("applicationIdFromConfig")]
    public V1api20230701storageVaultSpecPropertiesAccessPoliciesApplicationIdFromConfig? ApplicationIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20230701storageVaultSpecPropertiesAccessPoliciesObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>Storage version of v1api20230701.Permissions Permissions the identity has for keys, secrets, certificates and storage.</summary>
    [JsonPropertyName("permissions")]
    public V1api20230701storageVaultSpecPropertiesAccessPoliciesPermissions? Permissions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20230701storageVaultSpecPropertiesAccessPoliciesTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>Storage version of v1api20230701.IPRule A rule governing the accessibility of a vault from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesNetworkAclsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Reference: Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesNetworkAclsVirtualNetworkRulesReference
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

/// <summary>Storage version of v1api20230701.VirtualNetworkRule A rule governing the accessibility of a vault from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>Reference: Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'.</summary>
    [JsonPropertyName("reference")]
    public V1api20230701storageVaultSpecPropertiesNetworkAclsVirtualNetworkRulesReference Reference { get; set; }
}

/// <summary>Storage version of v1api20230701.NetworkRuleSet A set of rules governing the network accessibility of a vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesNetworkAcls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230701storageVaultSpecPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20230701storageVaultSpecPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>Storage version of v1api20230701.Sku SKU details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecPropertiesTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230701.VaultProperties Properties of the vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessPolicies")]
    public IList<V1api20230701storageVaultSpecPropertiesAccessPolicies>? AccessPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRbacAuthorization")]
    public bool? EnableRbacAuthorization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSoftDelete")]
    public bool? EnableSoftDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForDeployment")]
    public bool? EnabledForDeployment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForDiskEncryption")]
    public bool? EnabledForDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForTemplateDeployment")]
    public bool? EnabledForTemplateDeployment { get; set; }

    /// <summary>Storage version of v1api20230701.NetworkRuleSet A set of rules governing the network accessibility of a vault.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230701storageVaultSpecPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20230701.Sku SKU details</summary>
    [JsonPropertyName("sku")]
    public V1api20230701storageVaultSpecPropertiesSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20230701storageVaultSpecPropertiesTenantIdFromConfig? TenantIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultUri")]
    public string? VaultUri { get; set; }
}

/// <summary>Storage version of v1api20230701.Vault_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultSpec
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

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230701storageVaultSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230701.VaultProperties Properties of the vault</summary>
    [JsonPropertyName("properties")]
    public V1api20230701storageVaultSpecProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusConditions
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

/// <summary>Storage version of v1api20230701.Permissions_STATUS Permissions the identity has for keys, secrets, certificates and storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesAccessPoliciesPermissions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storage")]
    public IList<string>? Storage { get; set; }
}

/// <summary>Storage version of v1api20230701.AccessPolicyEntry_STATUS An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesAccessPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Storage version of v1api20230701.Permissions_STATUS Permissions the identity has for keys, secrets, certificates and storage.</summary>
    [JsonPropertyName("permissions")]
    public V1api20230701storageVaultStatusPropertiesAccessPoliciesPermissions? Permissions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20230701.IPRule_STATUS A rule governing the accessibility of a vault from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesNetworkAclsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20230701.VirtualNetworkRule_STATUS A rule governing the accessibility of a vault from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
}

/// <summary>Storage version of v1api20230701.NetworkRuleSet_STATUS A set of rules governing the network accessibility of a vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesNetworkAcls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230701storageVaultStatusPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20230701storageVaultStatusPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>Storage version of v1api20230701.PrivateEndpoint_STATUS Private endpoint object properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesPrivateEndpointConnectionsPrivateEndpoint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230701.PrivateLinkServiceConnectionState_STATUS An object that represents the approval state of the private link connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesPrivateEndpointConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20230701.PrivateEndpointConnectionItem_STATUS Private endpoint connection item.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20230701.PrivateEndpoint_STATUS Private endpoint object properties.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20230701storageVaultStatusPropertiesPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Storage version of v1api20230701.PrivateLinkServiceConnectionState_STATUS An object that represents the approval state of the private link connection.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20230701storageVaultStatusPropertiesPrivateEndpointConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20230701.Sku_STATUS SKU details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusPropertiesSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230701.VaultProperties_STATUS Properties of the vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessPolicies")]
    public IList<V1api20230701storageVaultStatusPropertiesAccessPolicies>? AccessPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRbacAuthorization")]
    public bool? EnableRbacAuthorization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSoftDelete")]
    public bool? EnableSoftDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForDeployment")]
    public bool? EnabledForDeployment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForDiskEncryption")]
    public bool? EnabledForDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledForTemplateDeployment")]
    public bool? EnabledForTemplateDeployment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hsmPoolResourceId")]
    public string? HsmPoolResourceId { get; set; }

    /// <summary>Storage version of v1api20230701.NetworkRuleSet_STATUS A set of rules governing the network accessibility of a vault.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230701storageVaultStatusPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230701storageVaultStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20230701.Sku_STATUS SKU details</summary>
    [JsonPropertyName("sku")]
    public V1api20230701storageVaultStatusPropertiesSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultUri")]
    public string? VaultUri { get; set; }
}

/// <summary>Storage version of v1api20230701.SystemData_STATUS Metadata pertaining to creation and last modification of the key vault resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatusSystemData
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

/// <summary>Storage version of v1api20230701.Vault_STATUS Resource information with extended details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230701storageVaultStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230701storageVaultStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230701.VaultProperties_STATUS Properties of the vault</summary>
    [JsonPropertyName("properties")]
    public V1api20230701storageVaultStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20230701.SystemData_STATUS Metadata pertaining to creation and last modification of the key vault resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230701storageVaultStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230701.Vault Generator information: - Generated from: /keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/keyvault.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230701storageVault : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230701storageVaultSpec>, IStatus<V1api20230701storageVaultStatus>
{
    public const string KubeApiVersion = "v1api20230701storage";
    public const string KubeKind = "Vault";
    public const string KubeGroup = "keyvault.azure.com";
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

    /// <summary>Storage version of v1api20230701.Vault_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230701storageVaultSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230701.Vault_STATUS Resource information with extended details.</summary>
    [JsonPropertyName("status")]
    public V1api20230701storageVaultStatus? Status { get; set; }
}