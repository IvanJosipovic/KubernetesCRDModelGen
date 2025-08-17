using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGateway Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2022-07-01/applicationGateway.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220701storageApplicationGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1api20220701storageApplicationGateway>
{
    public const string KubeApiVersion = "v1api20220701storage";
    public const string KubeKind = "ApplicationGatewayList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "applicationgateways";
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
    public IList<V1api20220701storageApplicationGateway> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecAuthenticationCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayAuthenticationCertificate Authentication certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecAuthenticationCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("data")]
    public V1api20220701storageApplicationGatewaySpecAuthenticationCertificatesData? Data { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayAutoscaleConfiguration Application Gateway autoscale configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecAutoscaleConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCapacity")]
    public int? MinCapacity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendAddress Backend address of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendAddressPoolsBackendAddresses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendAddressPool Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendAddresses")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendAddressPoolsBackendAddresses>? BackendAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificatesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificatesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayConnectionDraining Connection draining allows open connections to a backend server to be active for a specified time after the backend server got removed from the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionConnectionDraining
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drainTimeoutInSec")]
    public int? DrainTimeoutInSec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionProbeReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionProbeReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificatesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificatesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendHttpSettings Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayConnectionDraining Connection draining allows open connections to a backend server to be active for a specified time after the backend server got removed from the configuration.</summary>
    [JsonPropertyName("connectionDraining")]
    public V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionConnectionDraining? ConnectionDraining { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("probe")]
    public V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionProbe? Probe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeEnabled")]
    public bool? ProbeEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestTimeout")]
    public int? RequestTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificates>? TrustedRootCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionProbeReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionProbeReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificatesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificatesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendSettings Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecBackendSettingsCollection
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("probe")]
    public V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionProbe? Probe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificates>? TrustedRootCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayCustomError Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecCustomErrorConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFirewallPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFirewallPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecFirewallPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddressReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddressReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsSubnetReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsSubnetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayFrontendIPConfiguration Frontend IP configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendIPConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701storageApplicationGatewaySpecFrontendIPConfigurationsSubnet? Subnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayFrontendPort Frontend port of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecFrontendPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecGatewayIPConfigurationsSubnetReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecGatewayIPConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecGatewayIPConfigurationsSubnetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayIPConfiguration_ApplicationGateway_SubResourceEmbedded IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecGatewayIPConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701storageApplicationGatewaySpecGatewayIPConfigurationsSubnet? Subnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayGlobalConfiguration Application Gateway global configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecGlobalConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRequestBuffering")]
    public bool? EnableRequestBuffering { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResponseBuffering")]
    public bool? EnableResponseBuffering { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayCustomError Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersCustomErrorConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFirewallPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFirewallPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFirewallPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFrontendIPConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFrontendIPConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFrontendIPConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFrontendPortReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersFrontendPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFrontendPortReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersSslCertificateReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersSslCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersSslCertificateReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersSslProfileReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListenersSslProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersSslProfileReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayHttpListener Http listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecHttpListeners
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecHttpListenersCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("frontendPort")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersFrontendPort? FrontendPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireServerNameIndication")]
    public bool? RequireServerNameIndication { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("sslCertificate")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersSslCertificate? SslCertificate { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("sslProfile")]
    public V1api20220701storageApplicationGatewaySpecHttpListenersSslProfile? SslProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecIdentityUserAssignedIdentitiesReference
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
/// <summary>Storage version of v1api20220701.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ManagedServiceIdentity Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220701storageApplicationGatewaySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersFrontendIPConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersFrontendIPConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecListenersFrontendIPConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersFrontendPortReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersFrontendPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecListenersFrontendPortReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersSslCertificateReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersSslCertificate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecListenersSslCertificateReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersSslProfileReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListenersSslProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecListenersSslProfileReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayListener Listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecListeners
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20220701storageApplicationGatewaySpecListenersFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("frontendPort")]
    public V1api20220701storageApplicationGatewaySpecListenersFrontendPort? FrontendPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("sslCertificate")]
    public V1api20220701storageApplicationGatewaySpecListenersSslCertificate? SslCertificate { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("sslProfile")]
    public V1api20220701storageApplicationGatewaySpecListenersSslProfile? SslProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargetsReference
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayLoadDistributionTarget Load Distribution Target of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargetsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayLoadDistributionPolicy Load Distribution Policy of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecLoadDistributionPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadDistributionAlgorithm")]
    public string? LoadDistributionAlgorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadDistributionTargets")]
    public IList<V1api20220701storageApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargets>? LoadDistributionTargets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220701storageApplicationGatewaySpecOperatorSpecSecretExpressions
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220701storageApplicationGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220701storageApplicationGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecOwner
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
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurationsReference
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayPrivateLinkIpConfiguration The application gateway private link ip configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurationsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayPrivateLinkConfiguration Private Link Configuration on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayProbeHealthResponseMatch Application gateway probe health response match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecProbesMatch
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCodes")]
    public IList<string>? StatusCodes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayProbe Probe of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecProbes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayProbeHealthResponseMatch Application gateway probe health response match.</summary>
    [JsonPropertyName("match")]
    public V1api20220701storageApplicationGatewaySpecProbesMatch? Match { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minServers")]
    public int? MinServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pickHostNameFromBackendSettings")]
    public bool? PickHostNameFromBackendSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unhealthyThreshold")]
    public int? UnhealthyThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsPathRulesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsPathRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRedirectConfigurationsPathRulesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsRequestRoutingRulesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsRequestRoutingRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRedirectConfigurationsRequestRoutingRulesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsTargetListenerReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsTargetListener
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRedirectConfigurationsTargetListenerReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsUrlPathMapsReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurationsUrlPathMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRedirectConfigurationsUrlPathMapsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRedirectConfiguration Redirect configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRedirectConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathRules")]
    public IList<V1api20220701storageApplicationGatewaySpecRedirectConfigurationsPathRules>? PathRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701storageApplicationGatewaySpecRedirectConfigurationsRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("targetListener")]
    public V1api20220701storageApplicationGatewaySpecRedirectConfigurationsTargetListener? TargetListener { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701storageApplicationGatewaySpecRedirectConfigurationsUrlPathMaps>? UrlPathMaps { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendAddressPoolReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendAddressPoolReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendHttpSettingsReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendHttpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendHttpSettingsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesHttpListenerReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesHttpListener
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesHttpListenerReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRedirectConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRedirectConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRedirectConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRewriteRuleSetReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRewriteRuleSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRewriteRuleSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesUrlPathMapReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRulesUrlPathMap
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesUrlPathMapReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRequestRoutingRule Request routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRequestRoutingRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesBackendHttpSettings? BackendHttpSettings { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("httpListener")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesHttpListener? HttpListener { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("loadDistributionPolicy")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicy? LoadDistributionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRedirectConfiguration? RedirectConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesRewriteRuleSet? RewriteRuleSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("urlPathMap")]
    public V1api20220701storageApplicationGatewaySpecRequestRoutingRulesUrlPathMap? UrlPathMap { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayHeaderConfiguration Header configuration of the Actions set in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetRequestHeaderConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayHeaderConfiguration Header configuration of the Actions set in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetResponseHeaderConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayUrlConfiguration Url configuration of the Actions set in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetUrlConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedPath")]
    public string? ModifiedPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("modifiedQueryString")]
    public string? ModifiedQueryString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRuleActionSet Set of actions in the Rewrite Rule in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestHeaderConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetRequestHeaderConfigurations>? RequestHeaderConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("responseHeaderConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetResponseHeaderConfigurations>? ResponseHeaderConfigurations { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayUrlConfiguration Url configuration of the Actions set in Application Gateway.</summary>
    [JsonPropertyName("urlConfiguration")]
    public V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetUrlConfiguration? UrlConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRuleCondition Set of conditions in the Rewrite Rule in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRule Rewrite rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRuleActionSet Set of actions in the Rewrite Rule in Application Gateway.</summary>
    [JsonPropertyName("actionSet")]
    public V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSet? ActionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRulesConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSequence")]
    public int? RuleSequence { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRuleSet Rewrite rule set of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRewriteRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rewriteRules")]
    public IList<V1api20220701storageApplicationGatewaySpecRewriteRuleSetsRewriteRules>? RewriteRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesBackendAddressPoolReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesBackendAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesBackendAddressPoolReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesBackendSettingsReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesBackendSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesBackendSettingsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesListenerReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRulesListener
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesListenerReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayRoutingRule Routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecRoutingRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendSettings")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesBackendSettings? BackendSettings { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("listener")]
    public V1api20220701storageApplicationGatewaySpecRoutingRulesListener? Listener { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySku SKU of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSku
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
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslCertificatesPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslCertificate SSL certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("data")]
    public V1api20220701storageApplicationGatewaySpecSslCertificatesData? Data { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("password")]
    public V1api20220701storageApplicationGatewaySpecSslCertificatesPassword? Password { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy Application Gateway Ssl policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<string>? DisabledSslProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayClientAuthConfiguration Application gateway client authentication configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslProfilesClientAuthConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("verifyClientCertIssuerDN")]
    public bool? VerifyClientCertIssuerDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("verifyClientRevocation")]
    public string? VerifyClientRevocation { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy Application Gateway Ssl policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslProfilesSslPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<string>? DisabledSslProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslProfilesTrustedClientCertificatesReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslProfilesTrustedClientCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecSslProfilesTrustedClientCertificatesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslProfile SSL profile of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecSslProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayClientAuthConfiguration Application gateway client authentication configuration.</summary>
    [JsonPropertyName("clientAuthConfiguration")]
    public V1api20220701storageApplicationGatewaySpecSslProfilesClientAuthConfiguration? ClientAuthConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy Application Gateway Ssl policy.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701storageApplicationGatewaySpecSslProfilesSslPolicy? SslPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecSslProfilesTrustedClientCertificates>? TrustedClientCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecTrustedClientCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayTrustedClientCertificate Trusted client certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecTrustedClientCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("data")]
    public V1api20220701storageApplicationGatewaySpecTrustedClientCertificatesData? Data { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecTrustedRootCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayTrustedRootCertificate Trusted Root certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecTrustedRootCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("data")]
    public V1api20220701storageApplicationGatewaySpecTrustedRootCertificatesData? Data { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPoolReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPoolReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettingsReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettingsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRedirectConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRedirectConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRedirectConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSetReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPoolReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPoolReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettingsReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettingsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicyReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicyReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfigurationReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSetReference
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
/// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayPathRule Path rule of URL path map of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettings? BackendHttpSettings { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("loadDistributionPolicy")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicy? LoadDistributionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfiguration? RedirectConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSet? RewriteRuleSet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayUrlPathMap UrlPathMaps give a url path to the backend mapping information for PathBasedRouting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecUrlPathMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("defaultBackendAddressPool")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPool? DefaultBackendAddressPool { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("defaultBackendHttpSettings")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettings? DefaultBackendHttpSettings { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("defaultLoadDistributionPolicy")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicy? DefaultLoadDistributionPolicy { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("defaultRedirectConfiguration")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRedirectConfiguration? DefaultRedirectConfiguration { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("defaultRewriteRuleSet")]
    public V1api20220701storageApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSet? DefaultRewriteRuleSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathRules")]
    public IList<V1api20220701storageApplicationGatewaySpecUrlPathMapsPathRules>? PathRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayFirewallDisabledRuleGroup Allows to disable rules within a rule group or an entire rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfigurationDisabledRuleGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<int>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayFirewallExclusion Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfigurationExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayWebApplicationFirewallConfiguration Application gateway web application firewall configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabledRuleGroups")]
    public IList<V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfigurationDisabledRuleGroups>? DisabledRuleGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfigurationExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySize")]
    public int? MaxRequestBodySize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGateway_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewaySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayAutoscaleConfiguration Application Gateway autoscale configuration.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1api20220701storageApplicationGatewaySpecAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendHttpSettingsCollection")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendHttpSettingsCollection>? BackendHttpSettingsCollection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendSettingsCollection")]
    public IList<V1api20220701storageApplicationGatewaySpecBackendSettingsCollection>? BackendSettingsCollection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFips")]
    public bool? EnableFips { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource Reference to another ARM resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701storageApplicationGatewaySpecFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendPorts")]
    public IList<V1api20220701storageApplicationGatewaySpecFrontendPorts>? FrontendPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayIPConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecGatewayIPConfigurations>? GatewayIPConfigurations { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayGlobalConfiguration Application Gateway global configuration.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1api20220701storageApplicationGatewaySpecGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20220701storageApplicationGatewaySpecHttpListeners>? HttpListeners { get; set; }

    /// <summary>Storage version of v1api20220701.ManagedServiceIdentity Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220701storageApplicationGatewaySpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220701storageApplicationGatewaySpecListeners>? Listeners { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadDistributionPolicies")]
    public IList<V1api20220701storageApplicationGatewaySpecLoadDistributionPolicies>? LoadDistributionPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220701storageApplicationGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220701storageApplicationGatewaySpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecPrivateLinkConfigurations>? PrivateLinkConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probes")]
    public IList<V1api20220701storageApplicationGatewaySpecProbes>? Probes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectConfigurations")]
    public IList<V1api20220701storageApplicationGatewaySpecRedirectConfigurations>? RedirectConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701storageApplicationGatewaySpecRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rewriteRuleSets")]
    public IList<V1api20220701storageApplicationGatewaySpecRewriteRuleSets>? RewriteRuleSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routingRules")]
    public IList<V1api20220701storageApplicationGatewaySpecRoutingRules>? RoutingRules { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewaySku SKU of an application gateway.</summary>
    [JsonPropertyName("sku")]
    public V1api20220701storageApplicationGatewaySpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecSslCertificates>? SslCertificates { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy Application Gateway Ssl policy.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701storageApplicationGatewaySpecSslPolicy? SslPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslProfiles")]
    public IList<V1api20220701storageApplicationGatewaySpecSslProfiles>? SslProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecTrustedClientCertificates>? TrustedClientCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701storageApplicationGatewaySpecTrustedRootCertificates>? TrustedRootCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701storageApplicationGatewaySpecUrlPathMaps>? UrlPathMaps { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayWebApplicationFirewallConfiguration Application gateway web application firewall configuration.</summary>
    [JsonPropertyName("webApplicationFirewallConfiguration")]
    public V1api20220701storageApplicationGatewaySpecWebApplicationFirewallConfiguration? WebApplicationFirewallConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayAuthenticationCertificate_STATUS Authentication certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusAuthenticationCertificates
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayAutoscaleConfiguration_STATUS Application Gateway autoscale configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusAutoscaleConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCapacity")]
    public int? MinCapacity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendAddressPool_STATUS Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusBackendAddressPools
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendHttpSettings_STATUS Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusBackendHttpSettingsCollection
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayBackendSettings_STATUS Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusBackendSettingsCollection
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
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusConditions
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayCustomError_STATUS Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusCustomErrorConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.SubResource_STATUS Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusFirewallPolicy
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayFrontendIPConfiguration_STATUS Frontend IP configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusFrontendIPConfigurations
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayFrontendPort_STATUS Frontend port of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusFrontendPorts
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayIPConfiguration_STATUS_ApplicationGateway_SubResourceEmbedded IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusGatewayIPConfigurations
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayGlobalConfiguration_STATUS Application Gateway global configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusGlobalConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRequestBuffering")]
    public bool? EnableRequestBuffering { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableResponseBuffering")]
    public bool? EnableResponseBuffering { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayHttpListener_STATUS Http listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusHttpListeners
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
/// <summary>Storage version of v1api20220701.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusIdentityUserAssignedIdentities
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
/// <summary>Storage version of v1api20220701.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusIdentity
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
    public IDictionary<string, V1api20220701storageApplicationGatewayStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayListener_STATUS Listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusListeners
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayLoadDistributionPolicy_STATUS Load Distribution Policy of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusLoadDistributionPolicies
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayPrivateEndpointConnection_STATUS Private Endpoint connection on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusPrivateEndpointConnections
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayPrivateLinkConfiguration_STATUS Private Link Configuration on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusPrivateLinkConfigurations
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayProbe_STATUS Probe of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusProbes
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayRedirectConfiguration_STATUS Redirect configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusRedirectConfigurations
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayRequestRoutingRule_STATUS Request routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusRequestRoutingRules
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayRewriteRuleSet_STATUS Rewrite rule set of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusRewriteRuleSets
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayRoutingRule_STATUS Routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusRoutingRules
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
/// <summary>Storage version of v1api20220701.ApplicationGatewaySku_STATUS SKU of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusSku
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
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslCertificate_STATUS SSL certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusSslCertificates
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
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy_STATUS Application Gateway Ssl policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusSslPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<string>? DisabledSslProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewaySslProfile_STATUS SSL profile of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusSslProfiles
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayTrustedClientCertificate_STATUS Trusted client certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusTrustedClientCertificates
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayTrustedRootCertificate_STATUS Trusted Root certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusTrustedRootCertificates
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayUrlPathMap_STATUS UrlPathMaps give a url path to the backend mapping information for PathBasedRouting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusUrlPathMaps
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
/// <summary>Storage version of v1api20220701.ApplicationGatewayFirewallDisabledRuleGroup_STATUS Allows to disable rules within a rule group or an entire rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfigurationDisabledRuleGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<int>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayFirewallExclusion_STATUS Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfigurationExclusions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGatewayWebApplicationFirewallConfiguration_STATUS Application gateway web application firewall configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disabledRuleGroups")]
    public IList<V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfigurationDisabledRuleGroups>? DisabledRuleGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfigurationExclusions>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySize")]
    public int? MaxRequestBodySize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGateway_STATUS_ApplicationGateway_SubResourceEmbedded Application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701storageApplicationGatewayStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701storageApplicationGatewayStatusAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayAutoscaleConfiguration_STATUS Application Gateway autoscale configuration.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1api20220701storageApplicationGatewayStatusAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20220701storageApplicationGatewayStatusBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendHttpSettingsCollection")]
    public IList<V1api20220701storageApplicationGatewayStatusBackendHttpSettingsCollection>? BackendHttpSettingsCollection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendSettingsCollection")]
    public IList<V1api20220701storageApplicationGatewayStatusBackendSettingsCollection>? BackendSettingsCollection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220701storageApplicationGatewayStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701storageApplicationGatewayStatusCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFips")]
    public bool? EnableFips { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Storage version of v1api20220701.SubResource_STATUS Reference to another ARM resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701storageApplicationGatewayStatusFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20220701storageApplicationGatewayStatusFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendPorts")]
    public IList<V1api20220701storageApplicationGatewayStatusFrontendPorts>? FrontendPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayIPConfigurations")]
    public IList<V1api20220701storageApplicationGatewayStatusGatewayIPConfigurations>? GatewayIPConfigurations { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayGlobalConfiguration_STATUS Application Gateway global configuration.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1api20220701storageApplicationGatewayStatusGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20220701storageApplicationGatewayStatusHttpListeners>? HttpListeners { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220701.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20220701storageApplicationGatewayStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220701storageApplicationGatewayStatusListeners>? Listeners { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadDistributionPolicies")]
    public IList<V1api20220701storageApplicationGatewayStatusLoadDistributionPolicies>? LoadDistributionPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationalState")]
    public string? OperationalState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20220701storageApplicationGatewayStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkConfigurations")]
    public IList<V1api20220701storageApplicationGatewayStatusPrivateLinkConfigurations>? PrivateLinkConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probes")]
    public IList<V1api20220701storageApplicationGatewayStatusProbes>? Probes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectConfigurations")]
    public IList<V1api20220701storageApplicationGatewayStatusRedirectConfigurations>? RedirectConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701storageApplicationGatewayStatusRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rewriteRuleSets")]
    public IList<V1api20220701storageApplicationGatewayStatusRewriteRuleSets>? RewriteRuleSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routingRules")]
    public IList<V1api20220701storageApplicationGatewayStatusRoutingRules>? RoutingRules { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewaySku_STATUS SKU of an application gateway.</summary>
    [JsonPropertyName("sku")]
    public V1api20220701storageApplicationGatewayStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslCertificates")]
    public IList<V1api20220701storageApplicationGatewayStatusSslCertificates>? SslCertificates { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewaySslPolicy_STATUS Application Gateway Ssl policy.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701storageApplicationGatewayStatusSslPolicy? SslPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslProfiles")]
    public IList<V1api20220701storageApplicationGatewayStatusSslProfiles>? SslProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701storageApplicationGatewayStatusTrustedClientCertificates>? TrustedClientCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701storageApplicationGatewayStatusTrustedRootCertificates>? TrustedRootCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701storageApplicationGatewayStatusUrlPathMaps>? UrlPathMaps { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGatewayWebApplicationFirewallConfiguration_STATUS Application gateway web application firewall configuration.</summary>
    [JsonPropertyName("webApplicationFirewallConfiguration")]
    public V1api20220701storageApplicationGatewayStatusWebApplicationFirewallConfiguration? WebApplicationFirewallConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220701.ApplicationGateway Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2022-07-01/applicationGateway.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220701storageApplicationGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220701storageApplicationGatewaySpec>, IStatus<V1api20220701storageApplicationGatewayStatus>
{
    public const string KubeApiVersion = "v1api20220701storage";
    public const string KubeKind = "ApplicationGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "applicationgateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGateway_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220701storageApplicationGatewaySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220701.ApplicationGateway_STATUS_ApplicationGateway_SubResourceEmbedded Application gateway resource.</summary>
    [JsonPropertyName("status")]
    public V1api20220701storageApplicationGatewayStatus? Status { get; set; }
}
#nullable disable
