using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>The contents of the Authentication Certificate which should be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderAuthenticationCertificateDataSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderAuthenticationCertificate
{
    /// <summary>The contents of the Authentication Certificate which should be used.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta1ApplicationGatewaySpecForProviderAuthenticationCertificateDataSecretRef DataSecretRef { get; set; }

    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderBackendAddressPool
{
    /// <summary>A list of FQDN's which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewaySpecForProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public IList<V1beta1ApplicationGatewaySpecForProviderBackendHttpSettingsConnectionDraining>? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus403 and HttpStatus502</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendIpConfiguration
{
    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderFrontendPort
{
    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGatewayIpConfiguration
{
    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderGlobal
{
    /// <summary>Whether Application Gateway's Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway's Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to 'Multi site'.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfiguration
{
    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1ApplicationGatewaySpecForProviderProbeMatch>? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRedirectConfiguration
{
    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRequestRoutingRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleUrl>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderRewriteRuleSet
{
    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Medium, WAF_Large, and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Standard, Standard_v2, WAF and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslCertificateDataSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslCertificatePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslCertificate
{
    /// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta1ApplicationGatewaySpecForProviderSslCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) the Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ApplicationGatewaySpecForProviderSslCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderSslProfile
{
    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewaySpecForProviderSslProfileSslPolicy>? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

/// <summary>The base-64 encoded certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderTrustedClientCertificateDataSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderTrustedClientCertificate
{
    /// <summary>The base-64 encoded certificate.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta1ApplicationGatewaySpecForProviderTrustedClientCertificateDataSecretRef DataSecretRef { get; set; }

    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderTrustedRootCertificateDataSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderTrustedRootCertificate
{
    /// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta1ApplicationGatewaySpecForProviderTrustedRootCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderUrlPathMapPathRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderUrlPathMap
{
    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1ApplicationGatewaySpecForProviderUrlPathMapPathRule>? PathRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta1ApplicationGatewaySpecForProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1ApplicationGatewaySpecForProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecForProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewaySpecForProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderAutoscaleConfiguration>? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta1ApplicationGatewaySpecForProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta1ApplicationGatewaySpecForProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta1ApplicationGatewaySpecForProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public IList<V1beta1ApplicationGatewaySpecForProviderGlobal>? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta1ApplicationGatewaySpecForProviderHttpListener>? HttpListener { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ApplicationGatewaySpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta1ApplicationGatewaySpecForProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>The name of the resource group in which to the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ApplicationGatewaySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta1ApplicationGatewaySpecForProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ApplicationGatewaySpecForProviderSku>? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta1ApplicationGatewaySpecForProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewaySpecForProviderSslPolicy>? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta1ApplicationGatewaySpecForProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta1ApplicationGatewaySpecForProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta1ApplicationGatewaySpecForProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta1ApplicationGatewaySpecForProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecForProviderWafConfiguration>? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderAuthenticationCertificate
{
    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderBackendAddressPool
{
    /// <summary>A list of FQDN's which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettingsConnectionDraining>? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus403 and HttpStatus502</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfiguration
{
    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderFrontendPort
{
    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfiguration
{
    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderGlobal
{
    /// <summary>Whether Application Gateway's Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway's Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to 'Multi site'.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfiguration
{
    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderProbeMatch>? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRedirectConfiguration
{
    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRequestRoutingRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleUrl>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSet
{
    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Medium, WAF_Large, and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Standard, Standard_v2, WAF and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderSslCertificate
{
    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) the Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderSslProfile
{
    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderSslProfileSslPolicy>? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderTrustedClientCertificate
{
    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderTrustedRootCertificate
{
    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderUrlPathMapPathRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderUrlPathMap
{
    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderUrlPathMapPathRule>? PathRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecInitProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderAutoscaleConfiguration>? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderGlobal>? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderHttpListener>? HttpListener { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderSku>? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderSslPolicy>? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public IList<V1beta1ApplicationGatewaySpecInitProviderWafConfiguration>? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ApplicationGatewaySpec defines the desired state of ApplicationGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationGatewaySpecDeletionPolicyEnum>))]
    public V1beta1ApplicationGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ApplicationGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ApplicationGatewaySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderAuthenticationCertificate
{
    /// <summary>The ID of the Authentication Certificate.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderBackendAddressPool
{
    /// <summary>A list of FQDN's which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>The ID of the Backend Address Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettingsConnectionDraining>? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the associated Probe.</summary>
    [JsonPropertyName("probeId")]
    public string? ProbeId { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>The ID of the Custom Error Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus403 and HttpStatus502</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderFrontendIpConfiguration
{
    /// <summary>The ID of the Frontend IP Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the associated private link configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationId")]
    public string? PrivateLinkConfigurationId { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderFrontendPort
{
    /// <summary>The ID of the Frontend Port.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderGatewayIpConfiguration
{
    /// <summary>The ID of the Gateway IP Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderGlobal
{
    /// <summary>Whether Application Gateway's Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway's Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The ID of the associated Frontend Configuration.</summary>
    [JsonPropertyName("frontendIpConfigurationId")]
    public string? FrontendIpConfigurationId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The ID of the associated Frontend Port.</summary>
    [JsonPropertyName("frontendPortId")]
    public string? FrontendPortId { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to 'Multi site'.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The ID of the HTTP Listener.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The ID of the associated SSL Certificate.</summary>
    [JsonPropertyName("sslCertificateId")]
    public string? SslCertificateId { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The ID of the associated SSL Profile.</summary>
    [JsonPropertyName("sslProfileId")]
    public string? SslProfileId { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderPrivateEndpointConnection
{
    /// <summary>The ID of the private endpoint connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the private endpoint connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The ID of the Probe.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderProbeMatch>? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRedirectConfiguration
{
    /// <summary>The ID of the Redirect Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("targetListenerId")]
    public string? TargetListenerId { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRequestRoutingRule
{
    /// <summary>The ID of the associated Backend Address Pool.</summary>
    [JsonPropertyName("backendAddressPoolId")]
    public string? BackendAddressPoolId { get; set; }

    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The ID of the associated Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("backendHttpSettingsId")]
    public string? BackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the associated HTTP Listener.</summary>
    [JsonPropertyName("httpListenerId")]
    public string? HttpListenerId { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The ID of the Request Routing Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the associated Redirect Configuration.</summary>
    [JsonPropertyName("redirectConfigurationId")]
    public string? RedirectConfigurationId { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The ID of the associated Rewrite Rule Set.</summary>
    [JsonPropertyName("rewriteRuleSetId")]
    public string? RewriteRuleSetId { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The ID of the associated URL Path Map.</summary>
    [JsonPropertyName("urlPathMapId")]
    public string? UrlPathMapId { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleUrl>? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSet
{
    /// <summary>The ID of the Rewrite Rule Set</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Medium, WAF_Large, and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Standard, Standard_v2, WAF and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderSslCertificate
{
    /// <summary>The ID of the SSL Certificate.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) the Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Certificate Data associated with the SSL Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderSslProfile
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderSslProfileSslPolicy>? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderTrustedClientCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderTrustedRootCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Secret ID of (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderUrlPathMapPathRule
{
    /// <summary>The ID of the associated Backend Address Pool.</summary>
    [JsonPropertyName("backendAddressPoolId")]
    public string? BackendAddressPoolId { get; set; }

    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The ID of the associated Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("backendHttpSettingsId")]
    public string? BackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The ID of the associated Redirect Configuration.</summary>
    [JsonPropertyName("redirectConfigurationId")]
    public string? RedirectConfigurationId { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The ID of the associated Rewrite Rule Set.</summary>
    [JsonPropertyName("rewriteRuleSetId")]
    public string? RewriteRuleSetId { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderUrlPathMap
{
    /// <summary>The ID of the Default Backend Address Pool.</summary>
    [JsonPropertyName("defaultBackendAddressPoolId")]
    public string? DefaultBackendAddressPoolId { get; set; }

    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The ID of the Default Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsId")]
    public string? DefaultBackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Default Redirect Configuration.</summary>
    [JsonPropertyName("defaultRedirectConfigurationId")]
    public string? DefaultRedirectConfigurationId { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("defaultRewriteRuleSetId")]
    public string? DefaultRewriteRuleSetId { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderUrlPathMapPathRule>? PathRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusAtProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderAutoscaleConfiguration>? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderGlobal>? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderHttpListener>? HttpListener { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of private_endpoint_connection blocks as defined below.</summary>
    [JsonPropertyName("privateEndpointConnection")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderPrivateEndpointConnection>? PrivateEndpointConnection { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>The name of the resource group in which to the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderSku>? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderSslPolicy>? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public IList<V1beta1ApplicationGatewayStatusAtProviderWafConfiguration>? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatusConditions
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

/// <summary>ApplicationGatewayStatus defines the observed state of ApplicationGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ApplicationGateway is the Schema for the ApplicationGateways API. Manages an Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationGatewaySpec>, IStatus<V1beta1ApplicationGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationGateway";
    public const string KubeGroup = "network.azure.upbound.io";
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

    /// <summary>ApplicationGatewaySpec defines the desired state of ApplicationGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationGatewaySpec Spec { get; set; }

    /// <summary>ApplicationGatewayStatus defines the observed state of ApplicationGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationGatewayStatus? Status { get; set; }
}