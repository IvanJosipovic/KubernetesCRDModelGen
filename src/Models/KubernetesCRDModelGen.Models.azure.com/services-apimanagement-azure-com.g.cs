using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>Storage version of v1api20220801.Service Generator information: - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/apimdeployment.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220801storageServiceList : IKubernetesObject<V1ListMeta>, IItems<V1api20220801storageService>
{
    public const string KubeApiVersion = "v1api20220801storage";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "services";
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
    public IList<V1api20220801storageService> Items { get; set; }
}

/// <summary>PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the location. Supported only for Premium SKU being deployed in Virtual Network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecAdditionalLocationsPublicIpAddressReference
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

/// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties API Management service resource SKU properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecAdditionalLocationsSku
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
}

/// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecAdditionalLocationsVirtualNetworkConfigurationSubnetResourceReference
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

/// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration Configuration of a virtual network to which API Management service is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecAdditionalLocationsVirtualNetworkConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceReference")]
    public V1api20220801storageServiceSpecAdditionalLocationsVirtualNetworkConfigurationSubnetResourceReference? SubnetResourceReference { get; set; }
}

/// <summary>Storage version of v1api20220801.AdditionalLocation Description of an additional API Management resource location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecAdditionalLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary>PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the location. Supported only for Premium SKU being deployed in Virtual Network.</summary>
    [JsonPropertyName("publicIpAddressReference")]
    public V1api20220801storageServiceSpecAdditionalLocationsPublicIpAddressReference? PublicIpAddressReference { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties API Management service resource SKU properties.</summary>
    [JsonPropertyName("sku")]
    public V1api20220801storageServiceSpecAdditionalLocationsSku? Sku { get; set; }

    /// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration Configuration of a virtual network to which API Management service is deployed.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20220801storageServiceSpecAdditionalLocationsVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiVersionConstraint Control Plane Apis version constraint for the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecApiVersionConstraint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecCertificatesCertificateExpiryFromConfig
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
public partial class V1api20220801storageServiceSpecCertificatesCertificateSubjectFromConfig
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
public partial class V1api20220801storageServiceSpecCertificatesCertificateThumbprintFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220801.CertificateInformation SSL certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecCertificatesCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("expiryFromConfig")]
    public V1api20220801storageServiceSpecCertificatesCertificateExpiryFromConfig? ExpiryFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("subjectFromConfig")]
    public V1api20220801storageServiceSpecCertificatesCertificateSubjectFromConfig? SubjectFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("thumbprintFromConfig")]
    public V1api20220801storageServiceSpecCertificatesCertificateThumbprintFromConfig? ThumbprintFromConfig { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecCertificatesCertificatePassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220801.CertificateConfiguration Certificate configuration which consist of non-trusted intermediates and root certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.CertificateInformation SSL certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20220801storageServiceSpecCertificatesCertificate? Certificate { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("certificatePassword")]
    public V1api20220801storageServiceSpecCertificatesCertificatePassword? CertificatePassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecHostnameConfigurationsCertificateExpiryFromConfig
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
public partial class V1api20220801storageServiceSpecHostnameConfigurationsCertificateSubjectFromConfig
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
public partial class V1api20220801storageServiceSpecHostnameConfigurationsCertificateThumbprintFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220801.CertificateInformation SSL certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecHostnameConfigurationsCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("expiryFromConfig")]
    public V1api20220801storageServiceSpecHostnameConfigurationsCertificateExpiryFromConfig? ExpiryFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("subjectFromConfig")]
    public V1api20220801storageServiceSpecHostnameConfigurationsCertificateSubjectFromConfig? SubjectFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("thumbprintFromConfig")]
    public V1api20220801storageServiceSpecHostnameConfigurationsCertificateThumbprintFromConfig? ThumbprintFromConfig { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecHostnameConfigurationsCertificatePassword
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
public partial class V1api20220801storageServiceSpecHostnameConfigurationsIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220801.HostnameConfiguration Custom hostname configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecHostnameConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.CertificateInformation SSL certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20220801storageServiceSpecHostnameConfigurationsCertificate? Certificate { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("certificatePassword")]
    public V1api20220801storageServiceSpecHostnameConfigurationsCertificatePassword? CertificatePassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("identityClientIdFromConfig")]
    public V1api20220801storageServiceSpecHostnameConfigurationsIdentityClientIdFromConfig? IdentityClientIdFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20220801.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220801storageServiceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiManagementServiceIdentity Identity properties of the Api Management service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220801storageServiceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220801storageServiceSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20220801.ServiceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220801storageServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220801storageServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecPublicIpAddressReference
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

/// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties API Management service resource SKU properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecSku
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
}

/// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecVirtualNetworkConfigurationSubnetResourceReference
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

/// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration Configuration of a virtual network to which API Management service is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpecVirtualNetworkConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceReference")]
    public V1api20220801storageServiceSpecVirtualNetworkConfigurationSubnetResourceReference? SubnetResourceReference { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalLocations")]
    public IList<V1api20220801storageServiceSpecAdditionalLocations>? AdditionalLocations { get; set; }

    /// <summary>Storage version of v1api20220801.ApiVersionConstraint Control Plane Apis version constraint for the API Management service.</summary>
    [JsonPropertyName("apiVersionConstraint")]
    public V1api20220801storageServiceSpecApiVersionConstraint? ApiVersionConstraint { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificates")]
    public IList<V1api20220801storageServiceSpecCertificates>? Certificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableClientCertificate")]
    public bool? EnableClientCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostnameConfigurations")]
    public IList<V1api20220801storageServiceSpecHostnameConfigurations>? HostnameConfigurations { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceIdentity Identity properties of the Api Management service resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220801storageServiceSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>Storage version of v1api20220801.ServiceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220801storageServiceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220801storageServiceSpecOwner Owner { get; set; }

    /// <summary>PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network.</summary>
    [JsonPropertyName("publicIpAddressReference")]
    public V1api20220801storageServiceSpecPublicIpAddressReference? PublicIpAddressReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties API Management service resource SKU properties.</summary>
    [JsonPropertyName("sku")]
    public V1api20220801storageServiceSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration Configuration of a virtual network to which API Management service is deployed.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20220801storageServiceSpecVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties_STATUS API Management service resource SKU properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusAdditionalLocationsSku
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
}

/// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration_STATUS Configuration of a virtual network to which API Management service is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusAdditionalLocationsVirtualNetworkConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetname")]
    public string? Subnetname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vnetid")]
    public string? Vnetid { get; set; }
}

/// <summary>Storage version of v1api20220801.AdditionalLocation_STATUS Description of an additional API Management resource location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusAdditionalLocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundPublicIPAddresses")]
    public IList<string>? OutboundPublicIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddresses")]
    public IList<string>? PrivateIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddresses")]
    public IList<string>? PublicIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties_STATUS API Management service resource SKU properties.</summary>
    [JsonPropertyName("sku")]
    public V1api20220801storageServiceStatusAdditionalLocationsSku? Sku { get; set; }

    /// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration_STATUS Configuration of a virtual network to which API Management service is deployed.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20220801storageServiceStatusAdditionalLocationsVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiVersionConstraint_STATUS Control Plane Apis version constraint for the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusApiVersionConstraint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }
}

/// <summary>Storage version of v1api20220801.CertificateInformation_STATUS SSL certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusCertificatesCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Storage version of v1api20220801.CertificateConfiguration_STATUS Certificate configuration which consist of non-trusted intermediates and root certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.CertificateInformation_STATUS SSL certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20220801storageServiceStatusCertificatesCertificate? Certificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusConditions
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

/// <summary>Storage version of v1api20220801.CertificateInformation_STATUS SSL certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusHostnameConfigurationsCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Storage version of v1api20220801.HostnameConfiguration_STATUS Custom hostname configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusHostnameConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.CertificateInformation_STATUS SSL certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20220801storageServiceStatusHostnameConfigurationsCertificate? Certificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220801.UserIdentityProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20220801.ApiManagementServiceIdentity_STATUS Identity properties of the Api Management service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusIdentity
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
    public IDictionary<string, V1api20220801storageServiceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20220801.ArmIdWrapper_STATUS A wrapper for an ARM resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusPrivateEndpointConnectionsPrivateEndpoint
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220801.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusPrivateEndpointConnectionsPrivateLinkServiceConnectionState
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

/// <summary>Storage version of v1api20220801.RemotePrivateEndpointConnectionWrapper_STATUS Remote Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220801.ArmIdWrapper_STATUS A wrapper for an ARM resource id</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20220801storageServiceStatusPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Storage version of v1api20220801.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20220801storageServiceStatusPrivateEndpointConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties_STATUS API Management service resource SKU properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusSku
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
}

/// <summary>Storage version of v1api20220801.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusSystemData
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

/// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration_STATUS Configuration of a virtual network to which API Management service is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatusVirtualNetworkConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetname")]
    public string? Subnetname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vnetid")]
    public string? Vnetid { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageServiceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalLocations")]
    public IList<V1api20220801storageServiceStatusAdditionalLocations>? AdditionalLocations { get; set; }

    /// <summary>Storage version of v1api20220801.ApiVersionConstraint_STATUS Control Plane Apis version constraint for the API Management service.</summary>
    [JsonPropertyName("apiVersionConstraint")]
    public V1api20220801storageServiceStatusApiVersionConstraint? ApiVersionConstraint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificates")]
    public IList<V1api20220801storageServiceStatusCertificates>? Certificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220801storageServiceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAtUtc")]
    public string? CreatedAtUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("developerPortalUrl")]
    public string? DeveloperPortalUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableClientCertificate")]
    public bool? EnableClientCertificate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayUrl")]
    public string? GatewayUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostnameConfigurations")]
    public IList<V1api20220801storageServiceStatusHostnameConfigurations>? HostnameConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceIdentity_STATUS Identity properties of the Api Management service resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220801storageServiceStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managementApiUrl")]
    public string? ManagementApiUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundPublicIPAddresses")]
    public IList<string>? OutboundPublicIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portalUrl")]
    public string? PortalUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20220801storageServiceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddresses")]
    public IList<string>? PrivateIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddresses")]
    public IList<string>? PublicIPAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmUrl")]
    public string? ScmUrl { get; set; }

    /// <summary>Storage version of v1api20220801.ApiManagementServiceSkuProperties_STATUS API Management service resource SKU properties.</summary>
    [JsonPropertyName("sku")]
    public V1api20220801storageServiceStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20220801.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20220801storageServiceStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetProvisioningState")]
    public string? TargetProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20220801.VirtualNetworkConfiguration_STATUS Configuration of a virtual network to which API Management service is deployed.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20220801storageServiceStatusVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Storage version of v1api20220801.Service Generator information: - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/apimdeployment.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220801storageService : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220801storageServiceSpec>, IStatus<V1api20220801storageServiceStatus>
{
    public const string KubeApiVersion = "v1api20220801storage";
    public const string KubeKind = "Service";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220801.Service_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220801storageServiceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220801.Service_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220801storageServiceStatus? Status { get; set; }
}