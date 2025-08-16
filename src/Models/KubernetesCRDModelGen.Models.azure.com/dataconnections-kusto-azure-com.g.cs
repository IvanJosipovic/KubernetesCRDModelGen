using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kusto.azure.com;
/// <summary>Storage version of v1api20230815.DataConnection Generator information: - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/kusto.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230815storageDataConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20230815storageDataConnection>
{
    public const string KubeApiVersion = "v1api20230815storage";
    public const string KubeKind = "DataConnectionList";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
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
    public IList<V1api20230815storageDataConnection> Items { get; set; }
}

/// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference
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

/// <summary>ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to authenticate with Cosmos DB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference
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

/// <summary>Storage version of v1api20230815.CosmosDbDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecCosmosDbDataConnection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
    [JsonPropertyName("cosmosDbAccountResourceReference")]
    public V1api20230815storageDataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference CosmosDbAccountResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cosmosDbContainer")]
    public string? CosmosDbContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cosmosDbDatabase")]
    public string? CosmosDbDatabase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to authenticate with Cosmos DB.</summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20230815storageDataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference ManagedIdentityResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventGridDataConnectionEventGridResourceReference
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

/// <summary>EventHubResourceReference: The resource ID where the event grid is configured to send events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventGridDataConnectionEventHubResourceReference
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

/// <summary>ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference
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

/// <summary>StorageAccountResourceReference: The resource ID of the storage account where the data resides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventGridDataConnectionStorageAccountResourceReference
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

/// <summary>Storage version of v1api20230815.EventGridDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventGridDataConnection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobStorageEventType")]
    public string? BlobStorageEventType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
    [JsonPropertyName("eventGridResourceReference")]
    public V1api20230815storageDataConnectionSpecEventGridDataConnectionEventGridResourceReference? EventGridResourceReference { get; set; }

    /// <summary>EventHubResourceReference: The resource ID where the event grid is configured to send events.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20230815storageDataConnectionSpecEventGridDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage account.</summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20230815storageDataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account where the data resides.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20230815storageDataConnectionSpecEventGridDataConnectionStorageAccountResourceReference StorageAccountResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventHubDataConnectionEventHubResourceReference
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

/// <summary>ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference
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

/// <summary>Storage version of v1api20230815.EventHubDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecEventHubDataConnection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20230815storageDataConnectionSpecEventHubDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.</summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20230815storageDataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecIotHubDataConnectionIotHubResourceReference
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

/// <summary>Storage version of v1api20230815.IotHubDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecIotHubDataConnection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
    [JsonPropertyName("iotHubResourceReference")]
    public V1api20230815storageDataConnectionSpecIotHubDataConnectionIotHubResourceReference IotHubResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230815storageDataConnectionSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20230815.DataConnectionOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230815storageDataConnectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230815storageDataConnectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a kusto.azure.com/Database resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230815.DataConnection_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20230815.CosmosDbDataConnection</summary>
    [JsonPropertyName("cosmosDbDataConnection")]
    public V1api20230815storageDataConnectionSpecCosmosDbDataConnection? CosmosDbDataConnection { get; set; }

    /// <summary>Storage version of v1api20230815.EventGridDataConnection</summary>
    [JsonPropertyName("eventGridDataConnection")]
    public V1api20230815storageDataConnectionSpecEventGridDataConnection? EventGridDataConnection { get; set; }

    /// <summary>Storage version of v1api20230815.EventHubDataConnection</summary>
    [JsonPropertyName("eventHubDataConnection")]
    public V1api20230815storageDataConnectionSpecEventHubDataConnection? EventHubDataConnection { get; set; }

    /// <summary>Storage version of v1api20230815.IotHubDataConnection</summary>
    [JsonPropertyName("iotHubDataConnection")]
    public V1api20230815storageDataConnectionSpecIotHubDataConnection? IotHubDataConnection { get; set; }

    /// <summary>Storage version of v1api20230815.DataConnectionOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230815storageDataConnectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a kusto.azure.com/Database resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230815storageDataConnectionSpecOwner Owner { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatusConditions
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

/// <summary>Storage version of v1api20230815.CosmosDbDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatusCosmosDb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cosmosDbAccountResourceId")]
    public string? CosmosDbAccountResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cosmosDbContainer")]
    public string? CosmosDbContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cosmosDbDatabase")]
    public string? CosmosDbDatabase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230815.EventGridDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatusEventGrid
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobStorageEventType")]
    public string? BlobStorageEventType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventGridResourceId")]
    public string? EventGridResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230815.EventHubDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatusEventHub
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230815.IotHubDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatusIotHub
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotHubResourceId")]
    public string? IotHubResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230815.DataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815storageDataConnectionStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230815storageDataConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20230815.CosmosDbDataConnection_STATUS</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20230815storageDataConnectionStatusCosmosDb? CosmosDb { get; set; }

    /// <summary>Storage version of v1api20230815.EventGridDataConnection_STATUS</summary>
    [JsonPropertyName("eventGrid")]
    public V1api20230815storageDataConnectionStatusEventGrid? EventGrid { get; set; }

    /// <summary>Storage version of v1api20230815.EventHubDataConnection_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V1api20230815storageDataConnectionStatusEventHub? EventHub { get; set; }

    /// <summary>Storage version of v1api20230815.IotHubDataConnection_STATUS</summary>
    [JsonPropertyName("iotHub")]
    public V1api20230815storageDataConnectionStatusIotHub? IotHub { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230815.DataConnection Generator information: - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/kusto.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230815storageDataConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230815storageDataConnectionSpec>, IStatus<V1api20230815storageDataConnectionStatus>
{
    public const string KubeApiVersion = "v1api20230815storage";
    public const string KubeKind = "DataConnection";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230815.DataConnection_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230815storageDataConnectionSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230815.DataConnection_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230815storageDataConnectionStatus? Status { get; set; }
}