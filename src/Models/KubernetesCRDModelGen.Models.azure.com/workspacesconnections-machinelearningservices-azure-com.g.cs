using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>Storage version of v1api20240401.WorkspacesConnection Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspacesConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401storageWorkspacesConnection>
{
    public const string KubeApiVersion = "v1api20240401storage";
    public const string KubeKind = "WorkspacesConnectionList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacesconnections";
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
    public IList<V1api20240401storageWorkspacesConnection> Items { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240401storageWorkspacesConnectionSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20240401.WorkspacesConnectionOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401storageWorkspacesConnectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401storageWorkspacesConnectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240401.AADAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAad
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKeyCredentialsSecretAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionAccessKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("secretAccessKey")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKeyCredentialsSecretAccessKey? SecretAccessKey { get; set; }
}

/// <summary>Storage version of v1api20240401.AccessKeyAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionAccessKey</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKeyCredentialsKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionAccountKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("key")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKeyCredentialsKey? Key { get; set; }
}

/// <summary>Storage version of v1api20240401.AccountKeyAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionAccountKey</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesApiKeyCredentialsKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionApiKey Api key object for workspace connection credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesApiKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("key")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesApiKeyCredentialsKey? Key { get; set; }
}

/// <summary>Storage version of v1api20240401.ApiKeyAuthWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesApiKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionApiKey Api key object for workspace connection credential.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesApiKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeysCredentialsKeys
{
    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.CustomKeys Custom Keys credential object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeysCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("keys")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeysCredentialsKeys? Keys { get; set; }
}

/// <summary>Storage version of v1api20240401.CustomKeysWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.CustomKeys Custom Keys credential object</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeysCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentialsResourceReference
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

/// <summary>Storage version of v1api20240401.WorkspaceConnectionManagedIdentity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentialsResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedIdentityAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionManagedIdentity</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentityCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.NoneAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesNone
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsDeveloperToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsRefreshToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionOAuth2 ClientId and ClientSecret are required. Other properties are optional depending on each OAuth2 provider's implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2Credentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authUrl")]
    public string? AuthUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsClientSecret? ClientSecret { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("developerToken")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsDeveloperToken? DeveloperToken { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsPassword? Password { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("refreshToken")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsRefreshToken? RefreshToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2CredentialsTenantIdFromConfig? TenantIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20240401.OAuth2AuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionOAuth2 ClientId and ClientSecret are required. Other properties are optional depending on each OAuth2 provider's implementation.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2Credentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesPatCredentialsPat
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionPersonalAccessToken</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesPatCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("pat")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesPatCredentialsPat? Pat { get; set; }
}

/// <summary>Storage version of v1api20240401.PATAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesPat
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionPersonalAccessToken</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesPatCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesSasCredentialsSas
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionSharedAccessSignature</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesSasCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("sas")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesSasCredentialsSas? Sas { get; set; }
}

/// <summary>Storage version of v1api20240401.SASAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesSas
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionSharedAccessSignature</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesSasCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionServicePrincipal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientSecret? ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentialsTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>Storage version of v1api20240401.ServicePrincipalAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipal
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionServicePrincipal</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipalCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsSecurityToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionUsernamePassword</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsPassword? Password { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("securityToken")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsSecurityToken? SecurityToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20240401.UsernamePasswordAuthTypeWorkspaceConnectionProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePassword
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionUsernamePassword</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePasswordCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionPropertiesV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AADAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("aad")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAad? Aad { get; set; }

    /// <summary>Storage version of v1api20240401.AccessKeyAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("accessKey")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccessKey? AccessKey { get; set; }

    /// <summary>Storage version of v1api20240401.AccountKeyAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("accountKey")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesAccountKey? AccountKey { get; set; }

    /// <summary>Storage version of v1api20240401.ApiKeyAuthWorkspaceConnectionProperties</summary>
    [JsonPropertyName("apiKey")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesApiKey? ApiKey { get; set; }

    /// <summary>Storage version of v1api20240401.CustomKeysWorkspaceConnectionProperties</summary>
    [JsonPropertyName("customKeys")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesCustomKeys? CustomKeys { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedIdentityAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>Storage version of v1api20240401.NoneAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("none")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesNone? None { get; set; }

    /// <summary>Storage version of v1api20240401.OAuth2AuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesOAuth2? OAuth2 { get; set; }

    /// <summary>Storage version of v1api20240401.PATAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("pat")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesPat? Pat { get; set; }

    /// <summary>Storage version of v1api20240401.SASAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("sas")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesSas? Sas { get; set; }

    /// <summary>Storage version of v1api20240401.ServicePrincipalAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>Storage version of v1api20240401.UsernamePasswordAuthTypeWorkspaceConnectionProperties</summary>
    [JsonPropertyName("usernamePassword")]
    public V1api20240401storageWorkspacesConnectionSpecPropertiesUsernamePassword? UsernamePassword { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspacesConnection_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspacesConnectionOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401storageWorkspacesConnectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a machinelearningservices.azure.com/Workspace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240401storageWorkspacesConnectionSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionPropertiesV2</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesConnectionSpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusConditions
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

/// <summary>Storage version of v1api20240401.AADAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesAad
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionAccessKey_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesAccessKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }
}

/// <summary>Storage version of v1api20240401.AccessKeyAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesAccessKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionAccessKey_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesAccessKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionAccountKey_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesAccountKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20240401.AccountKeyAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesAccountKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionAccountKey_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesAccountKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionApiKey_STATUS Api key object for workspace connection credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesApiKeyCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20240401.ApiKeyAuthWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesApiKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionApiKey_STATUS Api key object for workspace connection credential.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesApiKeyCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.CustomKeys_STATUS Custom Keys credential object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesCustomKeysCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keys")]
    public IDictionary<string, string>? Keys { get; set; }
}

/// <summary>Storage version of v1api20240401.CustomKeysWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesCustomKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.CustomKeys_STATUS Custom Keys credential object</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesCustomKeysCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionManagedIdentity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesManagedIdentityCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240401.ManagedIdentityAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionManagedIdentity_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesManagedIdentityCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.NoneAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesNone
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionOAuth2_STATUS ClientId and ClientSecret are required. Other properties are optional depending on each OAuth2 provider's implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesOAuth2Credentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authUrl")]
    public string? AuthUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20240401.OAuth2AuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesOAuth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionOAuth2_STATUS ClientId and ClientSecret are required. Other properties are optional depending on each OAuth2 provider's implementation.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesOAuth2Credentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionPersonalAccessToken_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesPatCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20240401.PATAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesPat
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionPersonalAccessToken_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesPatCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionSharedAccessSignature_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesSasCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20240401.SASAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesSas
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionSharedAccessSignature_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesSasCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionServicePrincipal_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesServicePrincipalCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20240401.ServicePrincipalAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesServicePrincipal
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionServicePrincipal_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesServicePrincipalCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionUsernamePassword_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesUsernamePasswordCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v1api20240401.UsernamePasswordAuthTypeWorkspaceConnectionProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusPropertiesUsernamePassword
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionUsernamePassword_STATUS</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesUsernamePasswordCredentials? Credentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspaceConnectionPropertiesV2_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240401.AADAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("aad")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesAad? Aad { get; set; }

    /// <summary>Storage version of v1api20240401.AccessKeyAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("accessKey")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesAccessKey? AccessKey { get; set; }

    /// <summary>Storage version of v1api20240401.AccountKeyAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("accountKey")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesAccountKey? AccountKey { get; set; }

    /// <summary>Storage version of v1api20240401.ApiKeyAuthWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("apiKey")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesApiKey? ApiKey { get; set; }

    /// <summary>Storage version of v1api20240401.CustomKeysWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("customKeys")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesCustomKeys? CustomKeys { get; set; }

    /// <summary>Storage version of v1api20240401.ManagedIdentityAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>Storage version of v1api20240401.NoneAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("none")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesNone? None { get; set; }

    /// <summary>Storage version of v1api20240401.OAuth2AuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesOAuth2? OAuth2 { get; set; }

    /// <summary>Storage version of v1api20240401.PATAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("pat")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesPat? Pat { get; set; }

    /// <summary>Storage version of v1api20240401.SASAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("sas")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesSas? Sas { get; set; }

    /// <summary>Storage version of v1api20240401.ServicePrincipalAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>Storage version of v1api20240401.UsernamePasswordAuthTypeWorkspaceConnectionProperties_STATUS</summary>
    [JsonPropertyName("usernamePassword")]
    public V1api20240401storageWorkspacesConnectionStatusPropertiesUsernamePassword? UsernamePassword { get; set; }
}

/// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatusSystemData
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

/// <summary>Storage version of v1api20240401.WorkspacesConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401storageWorkspacesConnectionStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401storageWorkspacesConnectionStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspaceConnectionPropertiesV2_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20240401storageWorkspacesConnectionStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20240401.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401storageWorkspacesConnectionStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240401.WorkspacesConnection Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401storageWorkspacesConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401storageWorkspacesConnectionSpec>, IStatus<V1api20240401storageWorkspacesConnectionStatus>
{
    public const string KubeApiVersion = "v1api20240401storage";
    public const string KubeKind = "WorkspacesConnection";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacesconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspacesConnection_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240401storageWorkspacesConnectionSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240401.WorkspacesConnection_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240401storageWorkspacesConnectionStatus? Status { get; set; }
}