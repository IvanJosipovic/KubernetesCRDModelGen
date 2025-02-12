using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notificationhubs.azure.com;
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpecConfigMapExpressions
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

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to: SecretDestination in secrets.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpecConfigMapsServiceBusEndpoint
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap to write to. The ConfigMap will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.NamespaceOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to: SecretDestination in secrets.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("serviceBusEndpoint")]
    public V1api20230901storageNamespaceSpecOperatorSpecConfigMapsServiceBusEndpoint? ServiceBusEndpoint { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecretExpressions
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
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecretsPrimaryConnectionString
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
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecretsPrimaryKey
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
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecretsSecondaryConnectionString
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
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.NamespaceOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20230901storageNamespaceSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("primaryKey")]
    public V1api20230901storageNamespaceSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20230901storageNamespaceSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20230901storageNamespaceSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>Storage version of v1api20230901.NamespaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230901storageNamespaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v1api20230901.NamespaceOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20230901storageNamespaceSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230901storageNamespaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20230901.NamespaceOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20230901storageNamespaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230901.IpRule A network authorization rule that filters traffic based on IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesNetworkAclsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>Storage version of v1api20230901.PublicInternetAuthorizationRule A default (public Internet) network authorization rule, which contains rights if no other network rule matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesNetworkAclsPublicNetworkRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>Storage version of v1api20230901.NetworkAcls A collection of network authorization rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesNetworkAcls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230901storageNamespaceSpecPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>Storage version of v1api20230901.PublicInternetAuthorizationRule A default (public Internet) network authorization rule, which contains rights if no other network rule matches.</summary>
    [JsonPropertyName("publicNetworkRule")]
    public V1api20230901storageNamespaceSpecPropertiesNetworkAclsPublicNetworkRule? PublicNetworkRule { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesAuthTokenUrl
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientId
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.AdmCredentialProperties Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("authTokenUrl")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesAuthTokenUrl? AuthTokenUrl { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("clientId")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientId? ClientId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientSecret? ClientSecret { get; set; }
}

/// <summary>Storage version of v1api20230901.AdmCredential Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.AdmCredentialProperties Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesApnsCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppId
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppName
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesCertificateKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesEndpoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesKeyId
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesThumbprint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.ApnsCredentialProperties Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("apnsCertificate")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesApnsCertificate? ApnsCertificate { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("appId")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppId? AppId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("appName")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppName? AppName { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("endpoint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesEndpoint? Endpoint { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("keyId")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesKeyId? KeyId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("thumbprint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesThumbprint? Thumbprint { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("token")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesToken? Token { get; set; }
}

/// <summary>Storage version of v1api20230901.ApnsCredential Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.ApnsCredentialProperties Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduApiKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduEndPoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduSecretKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.BaiduCredentialProperties Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("baiduApiKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduApiKey? BaiduApiKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("baiduEndPoint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduEndPoint? BaiduEndPoint { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("baiduSecretKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduSecretKey? BaiduSecretKey { get; set; }
}

/// <summary>Storage version of v1api20230901.BaiduCredential Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.BaiduCredentialProperties Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesSubject
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPrivateKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPublicKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.BrowserCredentialProperties Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("subject")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesSubject? Subject { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("vapidPrivateKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPrivateKey? VapidPrivateKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("vapidPublicKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPublicKey? VapidPublicKey { get; set; }
}

/// <summary>Storage version of v1api20230901.BrowserCredential Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.BrowserCredentialProperties Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGcmEndpoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGoogleApiKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.GcmCredentialProperties Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("gcmEndpoint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGcmEndpoint? GcmEndpoint { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("googleApiKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGoogleApiKey? GoogleApiKey { get; set; }
}

/// <summary>Storage version of v1api20230901.GcmCredential Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.GcmCredentialProperties Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesCertificateKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesMpnsCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesThumbprint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.MpnsCredentialProperties Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("mpnsCertificate")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesMpnsCertificate? MpnsCertificate { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("thumbprint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesThumbprint? Thumbprint { get; set; }
}

/// <summary>Storage version of v1api20230901.MpnsCredential Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.MpnsCredentialProperties Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesCertificateKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesPackageSid
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesSecretKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWindowsLiveEndpoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWnsCertificate
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.WnsCredentialProperties Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("packageSid")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesPackageSid? PackageSid { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("secretKey")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesSecretKey? SecretKey { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("windowsLiveEndpoint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWindowsLiveEndpoint? WindowsLiveEndpoint { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("wnsCertificate")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWnsCertificate? WnsCertificate { get; set; }
}

/// <summary>Storage version of v1api20230901.WnsCredential Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.WnsCredentialProperties Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredentialProperties? Properties { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesAppSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesEndpoint
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20230901.XiaomiCredentialProperties Description of a NotificationHub XiaomiCredentialProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("appSecret")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesAppSecret? AppSecret { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("endpoint")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesEndpoint? Endpoint { get; set; }
}

/// <summary>Storage version of v1api20230901.XiaomiCredential Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.XiaomiCredentialProperties Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.PnsCredentials Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecPropertiesPnsCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.AdmCredential Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsAdmCredential? AdmCredential { get; set; }

    /// <summary>Storage version of v1api20230901.ApnsCredential Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsApnsCredential? ApnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.BaiduCredential Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBaiduCredential? BaiduCredential { get; set; }

    /// <summary>Storage version of v1api20230901.BrowserCredential Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsBrowserCredential? BrowserCredential { get; set; }

    /// <summary>Storage version of v1api20230901.GcmCredential Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsGcmCredential? GcmCredential { get; set; }

    /// <summary>Storage version of v1api20230901.MpnsCredential Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsMpnsCredential? MpnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.WnsCredential Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsWnsCredential? WnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.XiaomiCredential Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentialsXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>Storage version of v1api20230901.NamespaceProperties Represents namespace properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataCenter")]
    public string? DataCenter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Storage version of v1api20230901.NetworkAcls A collection of network authorization rules.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230901storageNamespaceSpecPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>Storage version of v1api20230901.PnsCredentials Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
    [JsonPropertyName("pnsCredentials")]
    public V1api20230901storageNamespaceSpecPropertiesPnsCredentials? PnsCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicationRegion")]
    public string? ReplicationRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleUnit")]
    public string? ScaleUnit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundancy")]
    public string? ZoneRedundancy { get; set; }
}

/// <summary>Storage version of v1api20230901.Sku The Sku description for a namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpecSku
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

/// <summary>Storage version of v1api20230901.Namespace_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceSpec
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

    /// <summary>Storage version of v1api20230901.NamespaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230901storageNamespaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230901storageNamespaceSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230901.NamespaceProperties Represents namespace properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceSpecProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20230901.Sku The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public V1api20230901storageNamespaceSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusConditions
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

/// <summary>Storage version of v1api20230901.IpRule_STATUS A network authorization rule that filters traffic based on IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesNetworkAclsIpRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>Storage version of v1api20230901.PublicInternetAuthorizationRule_STATUS A default (public Internet) network authorization rule, which contains rights if no other network rule matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesNetworkAclsPublicNetworkRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>Storage version of v1api20230901.NetworkAcls_STATUS A collection of network authorization rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesNetworkAcls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230901storageNamespaceStatusPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>Storage version of v1api20230901.PublicInternetAuthorizationRule_STATUS A default (public Internet) network authorization rule, which contains rights if no other network rule matches.</summary>
    [JsonPropertyName("publicNetworkRule")]
    public V1api20230901storageNamespaceStatusPropertiesNetworkAclsPublicNetworkRule? PublicNetworkRule { get; set; }
}

/// <summary>Storage version of v1api20230901.AdmCredentialProperties_STATUS Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsAdmCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.AdmCredential_STATUS Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsAdmCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.AdmCredentialProperties_STATUS Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsAdmCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.ApnsCredentialProperties_STATUS Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsApnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.ApnsCredential_STATUS Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsApnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.ApnsCredentialProperties_STATUS Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsApnsCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.BaiduCredentialProperties_STATUS Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBaiduCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.BaiduCredential_STATUS Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBaiduCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.BaiduCredentialProperties_STATUS Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBaiduCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.BrowserCredentialProperties_STATUS Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBrowserCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.BrowserCredential_STATUS Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBrowserCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.BrowserCredentialProperties_STATUS Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBrowserCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.GcmCredentialProperties_STATUS Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsGcmCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.GcmCredential_STATUS Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsGcmCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.GcmCredentialProperties_STATUS Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsGcmCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.MpnsCredentialProperties_STATUS Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsMpnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.MpnsCredential_STATUS Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsMpnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.MpnsCredentialProperties_STATUS Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsMpnsCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.WnsCredentialProperties_STATUS Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsWnsCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.WnsCredential_STATUS Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsWnsCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.WnsCredentialProperties_STATUS Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsWnsCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.XiaomiCredentialProperties_STATUS Description of a NotificationHub XiaomiCredentialProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsXiaomiCredentialProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }
}

/// <summary>Storage version of v1api20230901.XiaomiCredential_STATUS Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentialsXiaomiCredential
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.XiaomiCredentialProperties_STATUS Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsXiaomiCredentialProperties? Properties { get; set; }
}

/// <summary>Storage version of v1api20230901.PnsCredentials_STATUS Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPnsCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230901.AdmCredential_STATUS Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsAdmCredential? AdmCredential { get; set; }

    /// <summary>Storage version of v1api20230901.ApnsCredential_STATUS Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsApnsCredential? ApnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.BaiduCredential_STATUS Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBaiduCredential? BaiduCredential { get; set; }

    /// <summary>Storage version of v1api20230901.BrowserCredential_STATUS Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsBrowserCredential? BrowserCredential { get; set; }

    /// <summary>Storage version of v1api20230901.GcmCredential_STATUS Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsGcmCredential? GcmCredential { get; set; }

    /// <summary>Storage version of v1api20230901.MpnsCredential_STATUS Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsMpnsCredential? MpnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.WnsCredential_STATUS Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsWnsCredential? WnsCredential { get; set; }

    /// <summary>Storage version of v1api20230901.XiaomiCredential_STATUS Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentialsXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>Storage version of v1api20230901.PrivateEndpointConnectionResource_STATUS Represents a Private Endpoint Connection ARM resource - a sub-resource of Notification Hubs namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusPropertiesPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230901.NamespaceProperties_STATUS Represents namespace properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataCenter")]
    public string? DataCenter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricId")]
    public string? MetricId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>Storage version of v1api20230901.NetworkAcls_STATUS A collection of network authorization rules.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230901storageNamespaceStatusPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>Storage version of v1api20230901.PnsCredentials_STATUS Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
    [JsonPropertyName("pnsCredentials")]
    public V1api20230901storageNamespaceStatusPropertiesPnsCredentials? PnsCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230901storageNamespaceStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicationRegion")]
    public string? ReplicationRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleUnit")]
    public string? ScaleUnit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceBusEndpoint")]
    public string? ServiceBusEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneRedundancy")]
    public string? ZoneRedundancy { get; set; }
}

/// <summary>Storage version of v1api20230901.Sku_STATUS The Sku description for a namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusSku
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

/// <summary>Storage version of v1api20230901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatusSystemData
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

/// <summary>Storage version of v1api20230901.Namespace_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901storageNamespaceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230901storageNamespaceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230901.NamespaceProperties_STATUS Represents namespace properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901storageNamespaceStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20230901.Sku_STATUS The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public V1api20230901storageNamespaceStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20230901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230901storageNamespaceStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230901.Namespace Generator information: - Generated from: /notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2023-09-01/notificationhubs.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230901storageNamespace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230901storageNamespaceSpec>, IStatus<V1api20230901storageNamespaceStatus>
{
    public const string KubeApiVersion = "v1api20230901storage";
    public const string KubeKind = "Namespace";
    public const string KubeGroup = "notificationhubs.azure.com";
    public const string KubePluralName = "namespaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230901.Namespace_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230901storageNamespaceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230901.Namespace_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230901storageNamespaceStatus? Status { get; set; }
}