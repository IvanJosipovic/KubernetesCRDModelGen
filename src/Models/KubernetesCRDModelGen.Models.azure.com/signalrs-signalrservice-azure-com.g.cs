using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.com;
#nullable enable
/// <summary>Storage version of v1api20240301.SignalR Generator information: - Generated from: /signalr/resource-manager/Microsoft.SignalRService/stable/2024-03-01/signalr.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageSignalRList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageSignalR>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "SignalRList";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
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
    public IList<V1api20240301storageSignalR> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRCorsSettings Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRFeature Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecFeatures
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flag")]
    public string? Flag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentityUserAssignedIdentitiesReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageSignalRSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ManagedIdentity A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240301storageSignalRSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.LiveTraceCategory Live trace category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecLiveTraceConfigurationCategories
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.LiveTraceConfiguration Live trace configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecLiveTraceConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRSpecLiveTraceConfigurationCategories>? Categories { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.IPRule An IP rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.PrivateEndpointACL ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsPrivateEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.NetworkACL Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsPublicNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRNetworkACLs Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20240301storageSignalRSpecNetworkACLsIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20240301storageSignalRSpecNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkACL Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20240301storageSignalRSpecNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecConfigMapExpressions
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
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretExpressions
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
#nullable disable

#nullable enable
/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalROperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryKey")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalROperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageSignalRSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageSignalRSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20240301.SignalROperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20240301storageSignalRSpecOperatorSpecSecrets? Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceLogCategory Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecResourceLogConfigurationCategories
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceLogConfiguration Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecResourceLogConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRSpecResourceLogConfigurationCategories>? Categories { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ServerlessSettings Serverless settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecServerless
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionTimeoutInSeconds")]
    public int? ConnectionTimeoutInSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceSku The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRTlsSettings TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecTls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ManagedIdentitySettings Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UpstreamAuthSettings Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplatesAuth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedIdentitySettings Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240301storageSignalRSpecUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UpstreamTemplate Upstream template item settings. It defines the Upstream URL of the incoming requests. The template defines the pattern of the event, the hub or the category of the incoming request that matches current URL template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.UpstreamAuthSettings Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20240301storageSignalRSpecUpstreamTemplatesAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ServerlessUpstreamSettings The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstream
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1api20240301storageSignalRSpecUpstreamTemplates>? Templates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalR_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRCorsSettings Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20240301storageSignalRSpecCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("features")]
    public IList<V1api20240301storageSignalRSpecFeatures>? Features { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedIdentity A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageSignalRSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Storage version of v1api20240301.LiveTraceConfiguration Live trace configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("liveTraceConfiguration")]
    public V1api20240301storageSignalRSpecLiveTraceConfiguration? LiveTraceConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRNetworkACLs Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20240301storageSignalRSpecNetworkACLs? NetworkACLs { get; set; }

    /// <summary>Storage version of v1api20240301.SignalROperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageSignalRSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240301storageSignalRSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionEndpointEnabled")]
    public string? RegionEndpointEnabled { get; set; }

    /// <summary>Storage version of v1api20240301.ResourceLogConfiguration Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20240301storageSignalRSpecResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceStopped")]
    public string? ResourceStopped { get; set; }

    /// <summary>Storage version of v1api20240301.ServerlessSettings Serverless settings.</summary>
    [JsonPropertyName("serverless")]
    public V1api20240301storageSignalRSpecServerless? Serverless { get; set; }

    /// <summary>Storage version of v1api20240301.ResourceSku The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageSignalRSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRTlsSettings TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20240301storageSignalRSpecTls? Tls { get; set; }

    /// <summary>Storage version of v1api20240301.ServerlessUpstreamSettings The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20240301storageSignalRSpecUpstream? Upstream { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRCorsSettings_STATUS Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRFeature_STATUS Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusFeatures
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flag")]
    public string? Flag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UserAssignedIdentityProperty_STATUS Properties of user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusIdentityUserAssignedIdentities
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ManagedIdentity_STATUS A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusIdentity
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
    public IDictionary<string, V1api20240301storageSignalRStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.LiveTraceCategory_STATUS Live trace category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusLiveTraceConfigurationCategories
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.LiveTraceConfiguration_STATUS Live trace configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusLiveTraceConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRStatusLiveTraceConfigurationCategories>? Categories { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.IPRule_STATUS An IP rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.PrivateEndpointACL_STATUS ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsPrivateEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.NetworkACL_STATUS Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsPublicNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRNetworkACLs_STATUS Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20240301storageSignalRStatusNetworkACLsIpRules>? IpRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20240301storageSignalRStatusNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkACL_STATUS Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20240301storageSignalRStatusNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.PrivateEndpointConnection_STATUS_SignalR_SubResourceEmbedded A private endpoint connection to an azure resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceLogCategory_STATUS Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusResourceLogConfigurationCategories
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceLogConfiguration_STATUS Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusResourceLogConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRStatusResourceLogConfigurationCategories>? Categories { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ServerlessSettings_STATUS Serverless settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusServerless
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionTimeoutInSeconds")]
    public int? ConnectionTimeoutInSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SharedPrivateLinkResource_STATUS_SignalR_SubResourceEmbedded Describes a Shared Private Link Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ResourceSku_STATUS The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSku
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSystemData
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalRTlsSettings_STATUS TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusTls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ManagedIdentitySettings_STATUS Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UpstreamAuthSettings_STATUS Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplatesAuth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedIdentitySettings_STATUS Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240301storageSignalRStatusUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.UpstreamTemplate_STATUS Upstream template item settings. It defines the Upstream URL of the incoming requests. The template defines the pattern of the event, the hub or the category of the incoming request that matches current URL template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.UpstreamAuthSettings_STATUS Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20240301storageSignalRStatusUpstreamTemplatesAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.ServerlessUpstreamSettings_STATUS The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstream
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1api20240301storageSignalRStatusUpstreamTemplates>? Templates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalR_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageSignalRStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRCorsSettings_STATUS Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20240301storageSignalRStatusCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("features")]
    public IList<V1api20240301storageSignalRStatusFeatures>? Features { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostNamePrefix")]
    public string? HostNamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedIdentity_STATUS A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageSignalRStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Storage version of v1api20240301.LiveTraceConfiguration_STATUS Live trace configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("liveTraceConfiguration")]
    public V1api20240301storageSignalRStatusLiveTraceConfiguration? LiveTraceConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRNetworkACLs_STATUS Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20240301storageSignalRStatusNetworkACLs? NetworkACLs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240301storageSignalRStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicPort")]
    public int? PublicPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionEndpointEnabled")]
    public string? RegionEndpointEnabled { get; set; }

    /// <summary>Storage version of v1api20240301.ResourceLogConfiguration_STATUS Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20240301storageSignalRStatusResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceStopped")]
    public string? ResourceStopped { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary>Storage version of v1api20240301.ServerlessSettings_STATUS Serverless settings.</summary>
    [JsonPropertyName("serverless")]
    public V1api20240301storageSignalRStatusServerless? Serverless { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240301storageSignalRStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20240301.ResourceSku_STATUS The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageSignalRStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240301.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240301storageSignalRStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20240301.SignalRTlsSettings_STATUS TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20240301storageSignalRStatusTls? Tls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240301.ServerlessUpstreamSettings_STATUS The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20240301storageSignalRStatusUpstream? Upstream { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SignalR Generator information: - Generated from: /signalr/resource-manager/Microsoft.SignalRService/stable/2024-03-01/signalr.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageSignalR : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageSignalRSpec>, IStatus<V1api20240301storageSignalRStatus>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "SignalR";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.SignalR_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageSignalRSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.SignalR_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageSignalRStatus? Status { get; set; }
}
#nullable disable
