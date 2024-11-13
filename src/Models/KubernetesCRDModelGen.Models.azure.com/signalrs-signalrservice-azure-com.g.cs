using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.com;
/// <summary>Storage version of v1api20211001.SignalRCorsSettings Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalRFeature Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecFeatures
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20211001.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211001storageSignalRSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20211001.ManagedIdentity A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211001storageSignalRSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20211001.PrivateEndpointACL ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecNetworkACLsPrivateEndpoints
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

/// <summary>Storage version of v1api20211001.NetworkACL Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecNetworkACLsPublicNetwork
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

/// <summary>Storage version of v1api20211001.SignalRNetworkACLs Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecNetworkACLs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20211001storageSignalRSpecNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>Storage version of v1api20211001.NetworkACL Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20211001storageSignalRSpecNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211001storageSignalRSpecOperatorSpecSecretExpressions
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
public partial class V1api20211001storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString
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
public partial class V1api20211001storageSignalRSpecOperatorSpecSecretsPrimaryKey
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
public partial class V1api20211001storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString
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
public partial class V1api20211001storageSignalRSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalROperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20211001storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryKey")]
    public V1api20211001storageSignalRSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20211001storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20211001storageSignalRSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalROperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211001storageSignalRSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211001storageSignalRSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20211001.SignalROperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20211001storageSignalRSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20211001.ResourceLogCategory Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecResourceLogConfigurationCategories
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

/// <summary>Storage version of v1api20211001.ResourceLogConfiguration Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecResourceLogConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20211001storageSignalRSpecResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>Storage version of v1api20211001.ResourceSku The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecSku
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

/// <summary>Storage version of v1api20211001.SignalRTlsSettings TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecTls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>Storage version of v1api20211001.ManagedIdentitySettings Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Storage version of v1api20211001.UpstreamAuthSettings Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecUpstreamTemplatesAuth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ManagedIdentitySettings Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20211001storageSignalRSpecUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20211001.UpstreamTemplate Upstream template item settings. It defines the Upstream URL of the incoming requests. The template defines the pattern of the event, the hub or the category of the incoming request that matches current URL template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecUpstreamTemplates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.UpstreamAuthSettings Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20211001storageSignalRSpecUpstreamTemplatesAuth? Auth { get; set; }

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

/// <summary>Storage version of v1api20211001.ServerlessUpstreamSettings The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpecUpstream
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1api20211001storageSignalRSpecUpstreamTemplates>? Templates { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalR_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRCorsSettings Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20211001storageSignalRSpecCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("features")]
    public IList<V1api20211001storageSignalRSpecFeatures>? Features { get; set; }

    /// <summary>Storage version of v1api20211001.ManagedIdentity A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20211001storageSignalRSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRNetworkACLs Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20211001storageSignalRSpecNetworkACLs? NetworkACLs { get; set; }

    /// <summary>Storage version of v1api20211001.SignalROperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211001storageSignalRSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211001storageSignalRSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceLogConfiguration Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20211001storageSignalRSpecResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceSku The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20211001storageSignalRSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRTlsSettings TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20211001storageSignalRSpecTls? Tls { get; set; }

    /// <summary>Storage version of v1api20211001.ServerlessUpstreamSettings The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20211001storageSignalRSpecUpstream? Upstream { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusConditions
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

/// <summary>Storage version of v1api20211001.SignalRCorsSettings_STATUS Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalRFeature_STATUS Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusFeatures
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

/// <summary>Storage version of v1api20211001.UserAssignedIdentityProperty_STATUS Properties of user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20211001.ManagedIdentity_STATUS A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusIdentity
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
    public IDictionary<string, V1api20211001storageSignalRStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20211001.PrivateEndpointACL_STATUS ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusNetworkACLsPrivateEndpoints
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

/// <summary>Storage version of v1api20211001.NetworkACL_STATUS Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusNetworkACLsPublicNetwork
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

/// <summary>Storage version of v1api20211001.SignalRNetworkACLs_STATUS Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusNetworkACLs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20211001storageSignalRStatusNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>Storage version of v1api20211001.NetworkACL_STATUS Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20211001storageSignalRStatusNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>Storage version of v1api20211001.PrivateEndpointConnection_STATUS_SignalR_SubResourceEmbedded A private endpoint connection to an azure resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20211001.ResourceLogCategory_STATUS Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusResourceLogConfigurationCategories
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

/// <summary>Storage version of v1api20211001.ResourceLogConfiguration_STATUS Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusResourceLogConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("categories")]
    public IList<V1api20211001storageSignalRStatusResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>Storage version of v1api20211001.SharedPrivateLinkResource_STATUS_SignalR_SubResourceEmbedded Describes a Shared Private Link Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20211001.ResourceSku_STATUS The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusSku
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

/// <summary>Storage version of v1api20211001.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusSystemData
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

/// <summary>Storage version of v1api20211001.SignalRTlsSettings_STATUS TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusTls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>Storage version of v1api20211001.ManagedIdentitySettings_STATUS Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Storage version of v1api20211001.UpstreamAuthSettings_STATUS Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusUpstreamTemplatesAuth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.ManagedIdentitySettings_STATUS Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20211001storageSignalRStatusUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20211001.UpstreamTemplate_STATUS Upstream template item settings. It defines the Upstream URL of the incoming requests. The template defines the pattern of the event, the hub or the category of the incoming request that matches current URL template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusUpstreamTemplates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211001.UpstreamAuthSettings_STATUS Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20211001storageSignalRStatusUpstreamTemplatesAuth? Auth { get; set; }

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

/// <summary>Storage version of v1api20211001.ServerlessUpstreamSettings_STATUS The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatusUpstream
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1api20211001storageSignalRStatusUpstreamTemplates>? Templates { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalR_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001storageSignalRStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211001storageSignalRStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRCorsSettings_STATUS Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20211001storageSignalRStatusCors? Cors { get; set; }

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
    public IList<V1api20211001storageSignalRStatusFeatures>? Features { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostNamePrefix")]
    public string? HostNamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20211001.ManagedIdentity_STATUS A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20211001storageSignalRStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRNetworkACLs_STATUS Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20211001storageSignalRStatusNetworkACLs? NetworkACLs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20211001storageSignalRStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicPort")]
    public int? PublicPort { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceLogConfiguration_STATUS Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20211001storageSignalRStatusResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20211001storageSignalRStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20211001.ResourceSku_STATUS The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20211001storageSignalRStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20211001.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211001storageSignalRStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20211001.SignalRTlsSettings_STATUS TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20211001storageSignalRStatusTls? Tls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20211001.ServerlessUpstreamSettings_STATUS The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20211001storageSignalRStatusUpstream? Upstream { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Storage version of v1api20211001.SignalR Generator information: - Generated from: /signalr/resource-manager/Microsoft.SignalRService/stable/2021-10-01/signalr.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001storageSignalR : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211001storageSignalRSpec>, IStatus<V1api20211001storageSignalRStatus>
{
    public const string KubeApiVersion = "v1api20211001storage";
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

    /// <summary>Storage version of v1api20211001.SignalR_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211001storageSignalRSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211001.SignalR_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211001storageSignalRStatus? Status { get; set; }
}