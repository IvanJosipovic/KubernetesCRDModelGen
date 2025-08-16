using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>Storage version of v1api20240401.Workspace Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401storageWorkspace>
{
    public const string KubeApiVersion = "v1api20240401storage";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
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
    public IList<V1api20240401storageWorkspace> Items { get; set; }
}

/// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecApplicationInsightsReference
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

/// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecContainerRegistryReference
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

/// <summary>UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed key vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryptionIdentityUserAssignedIdentityReference
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

/// <summary>Storage version of v1api20240401.IdentityForCmk Identity that will be used to access key vault for encryption at rest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed key vault</summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20240401storageWorkspaceSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryptionKeyVaultPropertiesIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference
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

/// <summary>Storage version of v1api20240401.EncryptionKeyVaultProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("identityClientIdFromConfig")]
    public V1api20240401storageWorkspaceSpecEncryptionKeyVaultPropertiesIdentityClientIdFromConfig? IdentityClientIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmReference")]
    public V1api20240401storageWorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference KeyVaultArmReference { get; set; }
}

/// <summary>Storage version of v1api20240401.EncryptionProperty</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.IdentityForCmk Identity that will be used to access key vault for encryption at rest</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspaceSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20240401.EncryptionKeyVaultProperties</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20240401storageWorkspaceSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>Storage version of v1api20240401.ComputeRuntimeDto Compute runtime config for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecFeatureStoreSettingsComputeRuntime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkRuntimeVersion")]
    public string? SparkRuntimeVersion { get; set; }
}

/// <summary>Storage version of v1api20240401.FeatureStoreSettings Settings for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecFeatureStoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeRuntimeDto Compute runtime config for feature store type workspace.</summary>
    [JsonPropertyName("computeRuntime")]
    public V1api20240401storageWorkspaceSpecFeatureStoreSettingsComputeRuntime? ComputeRuntime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offlineStoreConnectionName")]
    public string? OfflineStoreConnectionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onlineStoreConnectionName")]
    public string? OnlineStoreConnectionName { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecHubResourceReference
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
public partial class V1api20240401storageWorkspaceSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20240401.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240401storageWorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedServiceIdentity Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240401storageWorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecKeyVaultReference
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

/// <summary>Storage version of v1api20240401.FqdnOutboundRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesFqdn
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationServiceResourceReference
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
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSubresourceTargetReference
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

/// <summary>Storage version of v1api20240401.PrivateEndpointDestination Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("serviceResourceReference")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationServiceResourceReference? ServiceResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnabled")]
    public bool? SparkEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkStatus")]
    public string? SparkStatus { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("subresourceTargetReference")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSubresourceTargetReference? SubresourceTargetReference { get; set; }
}

/// <summary>Storage version of v1api20240401.PrivateEndpointOutboundRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpoint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.PrivateEndpointDestination Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("destination")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceTagDestination Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesServiceTagDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRanges")]
    public string? PortRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceTagOutboundRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesServiceTag
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceTagDestination Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("destination")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesServiceTagDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.OutboundRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkOutboundRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.FqdnOutboundRule</summary>
    [JsonPropertyName("fqdn")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesFqdn? Fqdn { get; set; }

    /// <summary>Storage version of v1api20240401.PrivateEndpointOutboundRule</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceTagOutboundRule</summary>
    [JsonPropertyName("serviceTag")]
    public V1api20240401storageWorkspaceSpecManagedNetworkOutboundRulesServiceTag? ServiceTag { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedNetworkProvisionStatus Status of the Provisioning for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetworkStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkReady")]
    public bool? SparkReady { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedNetworkSettings Managed Network settings for a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecManagedNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundRules")]
    public IDictionary<string, V1api20240401storageWorkspaceSpecManagedNetworkOutboundRules>? OutboundRules { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedNetworkProvisionStatus Status of the Provisioning for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401storageWorkspaceSpecManagedNetworkStatus? Status { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryUserName
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey
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
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecretsUserStorageKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("appInsightsInstrumentationKey")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey? AppInsightsInstrumentationKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("containerRegistryPassword")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword? ContainerRegistryPassword { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("containerRegistryPassword2")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2? ContainerRegistryPassword2 { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("containerRegistryUserName")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsContainerRegistryUserName? ContainerRegistryUserName { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryNotebookAccessKey")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey? PrimaryNotebookAccessKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryNotebookAccessKey")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey? SecondaryNotebookAccessKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("userStorageKey")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecretsUserStorageKey? UserStorageKey { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401storageWorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401storageWorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20240401storageWorkspaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecPrimaryUserAssignedIdentityReference
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

/// <summary>ServerlessComputeCustomSubnetReference: The resource ID of an existing virtual network subnet in which serverless compute nodes should be deployed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecServerlessComputeSettingsServerlessComputeCustomSubnetReference
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

/// <summary>Storage version of v1api20240401.ServerlessComputeSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecServerlessComputeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ServerlessComputeCustomSubnetReference: The resource ID of an existing virtual network subnet in which serverless compute nodes should be deployed</summary>
    [JsonPropertyName("serverlessComputeCustomSubnetReference")]
    public V1api20240401storageWorkspaceSpecServerlessComputeSettingsServerlessComputeCustomSubnetReference? ServerlessComputeCustomSubnetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverlessComputeNoPublicIP")]
    public bool? ServerlessComputeNoPublicIP { get; set; }
}

/// <summary>Storage version of v1api20240401.CosmosDbSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceManagedResourcesSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecServiceManagedResourcesSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.CosmosDbSettings</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240401storageWorkspaceSpecServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference
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

/// <summary>Storage version of v1api20240401.SharedPrivateLinkResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20240401storageWorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.Sku The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecSku
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

/// <summary>StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecStorageAccountReference
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

/// <summary>Storage version of v1api20240401.WorkspaceHubConfig WorkspaceHub's configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpecWorkspaceHubConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalWorkspaceStorageAccounts")]
    public IList<string>? AdditionalWorkspaceStorageAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultWorkspaceResourceGroup")]
    public string? DefaultWorkspaceResourceGroup { get; set; }
}

/// <summary>Storage version of v1api20240401.Workspace_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace.</summary>
    [JsonPropertyName("applicationInsightsReference")]
    public V1api20240401storageWorkspaceSpecApplicationInsightsReference? ApplicationInsightsReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatedWorkspaces")]
    public IList<string>? AssociatedWorkspaces { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace.</summary>
    [JsonPropertyName("containerRegistryReference")]
    public V1api20240401storageWorkspaceSpecContainerRegistryReference? ContainerRegistryReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDataIsolation")]
    public bool? EnableDataIsolation { get; set; }

    /// <summary>Storage version of v1api20240401.EncryptionProperty</summary>
    [JsonPropertyName("encryption")]
    public V1api20240401storageWorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20240401.FeatureStoreSettings Settings for feature store type workspace.</summary>
    [JsonPropertyName("featureStoreSettings")]
    public V1api20240401storageWorkspaceSpecFeatureStoreSettings? FeatureStoreSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("hubResourceReference")]
    public V1api20240401storageWorkspaceSpecHubResourceReference? HubResourceReference { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedServiceIdentity Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspaceSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20240401storageWorkspaceSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedNetworkSettings Managed Network settings for a machine learning workspace.</summary>
    [JsonPropertyName("managedNetwork")]
    public V1api20240401storageWorkspaceSpecManagedNetwork? ManagedNetwork { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401storageWorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240401storageWorkspaceSpecOwner Owner { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20240401storageWorkspaceSpecPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20240401.ServerlessComputeSettings</summary>
    [JsonPropertyName("serverlessComputeSettings")]
    public V1api20240401storageWorkspaceSpecServerlessComputeSettings? ServerlessComputeSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceManagedResourcesSettings</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20240401storageWorkspaceSpecServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240401storageWorkspaceSpecSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20240401.Sku The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20240401storageWorkspaceSpecSku? Sku { get; set; }

    /// <summary>StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("storageAccountReference")]
    public V1api20240401storageWorkspaceSpecStorageAccountReference? StorageAccountReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("v1LegacyMode")]
    public bool? V1LegacyMode { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceHubConfig WorkspaceHub's configuration object.</summary>
    [JsonPropertyName("workspaceHubConfig")]
    public V1api20240401storageWorkspaceSpecWorkspaceHubConfig? WorkspaceHubConfig { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusConditions
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

/// <summary>Storage version of v1api20240401.IdentityForCmk_STATUS Identity that will be used to access key vault for encryption at rest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Storage version of v1api20240401.EncryptionKeyVaultProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultArmId")]
    public string? KeyVaultArmId { get; set; }
}

/// <summary>Storage version of v1api20240401.EncryptionProperty_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.IdentityForCmk_STATUS Identity that will be used to access key vault for encryption at rest</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspaceStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20240401.EncryptionKeyVaultProperties_STATUS</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20240401storageWorkspaceStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.ComputeRuntimeDto_STATUS Compute runtime config for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusFeatureStoreSettingsComputeRuntime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkRuntimeVersion")]
    public string? SparkRuntimeVersion { get; set; }
}

/// <summary>Storage version of v1api20240401.FeatureStoreSettings_STATUS Settings for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusFeatureStoreSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.ComputeRuntimeDto_STATUS Compute runtime config for feature store type workspace.</summary>
    [JsonPropertyName("computeRuntime")]
    public V1api20240401storageWorkspaceStatusFeatureStoreSettingsComputeRuntime? ComputeRuntime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offlineStoreConnectionName")]
    public string? OfflineStoreConnectionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onlineStoreConnectionName")]
    public string? OnlineStoreConnectionName { get; set; }
}

/// <summary>Storage version of v1api20240401.UserAssignedIdentity_STATUS User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20240401.ManagedServiceIdentity_STATUS Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusIdentity
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
    public IDictionary<string, V1api20240401storageWorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20240401.FqdnOutboundRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesFqdn
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.PrivateEndpointDestination_STATUS Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesPrivateEndpointDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceResourceId")]
    public string? ServiceResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnabled")]
    public bool? SparkEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkStatus")]
    public string? SparkStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subresourceTarget")]
    public string? SubresourceTarget { get; set; }
}

/// <summary>Storage version of v1api20240401.PrivateEndpointOutboundRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesPrivateEndpoint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.PrivateEndpointDestination_STATUS Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("destination")]
    public V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesPrivateEndpointDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceTagDestination_STATUS Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesServiceTagDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRanges")]
    public string? PortRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceTagOutboundRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesServiceTag
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceTagDestination_STATUS Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("destination")]
    public V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesServiceTagDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.OutboundRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkOutboundRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.FqdnOutboundRule_STATUS</summary>
    [JsonPropertyName("fqdn")]
    public V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesFqdn? Fqdn { get; set; }

    /// <summary>Storage version of v1api20240401.PrivateEndpointOutboundRule_STATUS</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceTagOutboundRule_STATUS</summary>
    [JsonPropertyName("serviceTag")]
    public V1api20240401storageWorkspaceStatusManagedNetworkOutboundRulesServiceTag? ServiceTag { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedNetworkProvisionStatus_STATUS Status of the Provisioning for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetworkStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkReady")]
    public bool? SparkReady { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedNetworkSettings_STATUS Managed Network settings for a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusManagedNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundRules")]
    public IDictionary<string, V1api20240401storageWorkspaceStatusManagedNetworkOutboundRules>? OutboundRules { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedNetworkProvisionStatus_STATUS Status of the Provisioning for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401storageWorkspaceStatusManagedNetworkStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.NotebookPreparationError_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusNotebookInfoNotebookPreparationError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>Storage version of v1api20240401.NotebookResourceInfo_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusNotebookInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Storage version of v1api20240401.NotebookPreparationError_STATUS</summary>
    [JsonPropertyName("notebookPreparationError")]
    public V1api20240401storageWorkspaceStatusNotebookInfoNotebookPreparationError? NotebookPreparationError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240401.PrivateEndpointConnection_STATUS The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240401.ServerlessComputeSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusServerlessComputeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverlessComputeCustomSubnet")]
    public string? ServerlessComputeCustomSubnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverlessComputeNoPublicIP")]
    public bool? ServerlessComputeNoPublicIP { get; set; }
}

/// <summary>Storage version of v1api20240401.CosmosDbSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>Storage version of v1api20240401.ServiceManagedResourcesSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusServiceManagedResourcesSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.CosmosDbSettings_STATUS</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240401storageWorkspaceStatusServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>Storage version of v1api20240401.SharedPrivateLinkResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20240401.Sku_STATUS The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusSku
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

/// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusSystemData
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

/// <summary>Storage version of v1api20240401.WorkspaceHubConfig_STATUS WorkspaceHub's configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatusWorkspaceHubConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalWorkspaceStorageAccounts")]
    public IList<string>? AdditionalWorkspaceStorageAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultWorkspaceResourceGroup")]
    public string? DefaultWorkspaceResourceGroup { get; set; }
}

/// <summary>Storage version of v1api20240401.Workspace_STATUS An object that represents a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspaceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationInsights")]
    public string? ApplicationInsights { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatedWorkspaces")]
    public IList<string>? AssociatedWorkspaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401storageWorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerRegistry")]
    public string? ContainerRegistry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDataIsolation")]
    public bool? EnableDataIsolation { get; set; }

    /// <summary>Storage version of v1api20240401.EncryptionProperty_STATUS</summary>
    [JsonPropertyName("encryption")]
    public V1api20240401storageWorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20240401.FeatureStoreSettings_STATUS Settings for feature store type workspace.</summary>
    [JsonPropertyName("featureStoreSettings")]
    public V1api20240401storageWorkspaceStatusFeatureStoreSettings? FeatureStoreSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hubResourceId")]
    public string? HubResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedServiceIdentity_STATUS Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401storageWorkspaceStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVault")]
    public string? KeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedNetworkSettings_STATUS Managed Network settings for a machine learning workspace.</summary>
    [JsonPropertyName("managedNetwork")]
    public V1api20240401storageWorkspaceStatusManagedNetwork? ManagedNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mlFlowTrackingUri")]
    public string? MlFlowTrackingUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240401.NotebookResourceInfo_STATUS</summary>
    [JsonPropertyName("notebookInfo")]
    public V1api20240401storageWorkspaceStatusNotebookInfo? NotebookInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryUserAssignedIdentity")]
    public string? PrimaryUserAssignedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240401storageWorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkCount")]
    public int? PrivateLinkCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20240401.ServerlessComputeSettings_STATUS</summary>
    [JsonPropertyName("serverlessComputeSettings")]
    public V1api20240401storageWorkspaceStatusServerlessComputeSettings? ServerlessComputeSettings { get; set; }

    /// <summary>Storage version of v1api20240401.ServiceManagedResourcesSettings_STATUS</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20240401storageWorkspaceStatusServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceProvisionedResourceGroup")]
    public string? ServiceProvisionedResourceGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240401storageWorkspaceStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20240401.Sku_STATUS The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20240401storageWorkspaceStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageHnsEnabled")]
    public bool? StorageHnsEnabled { get; set; }

    /// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401storageWorkspaceStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("v1LegacyMode")]
    public bool? V1LegacyMode { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceHubConfig_STATUS WorkspaceHub's configuration object.</summary>
    [JsonPropertyName("workspaceHubConfig")]
    public V1api20240401storageWorkspaceStatusWorkspaceHubConfig? WorkspaceHubConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Storage version of v1api20240401.Workspace Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401storageWorkspaceSpec>, IStatus<V1api20240401storageWorkspaceStatus>
{
    public const string KubeApiVersion = "v1api20240401storage";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240401.Workspace_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240401storageWorkspaceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240401.Workspace_STATUS An object that represents a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401storageWorkspaceStatus? Status { get; set; }
}