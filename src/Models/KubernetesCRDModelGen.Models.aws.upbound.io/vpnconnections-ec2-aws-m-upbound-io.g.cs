using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>VPNConnection is the Schema for the VPNConnections API. Manages a Site-to-Site VPN connection. A Site-to-Site VPN connection is an Internet Protocol security (IPsec) VPN connection between a VPC and an on-premises network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPNConnection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNConnectionList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpnconnections";
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
    public IList<V1beta1VPNConnection> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderCustomerGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CustomerGateway in ec2 to populate customerGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderCustomerGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderCustomerGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderCustomerGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CustomerGateway in ec2 to populate customerGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderCustomerGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderCustomerGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTransitGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel1LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel1LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionSpecForProviderTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary>The preshared key of the first VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel1PresharedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel2LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel2LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionSpecForProviderTunnel2LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary>The preshared key of the second VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTunnel2PresharedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CustomerGateway in ec2 to populate type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderTypeRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CustomerGateway in ec2 to populate type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderTypeSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderVpnGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderVpnGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderVpnGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderVpnGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProviderVpnGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecForProviderVpnGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecForProvider
{
    /// <summary>The ID of the customer gateway.</summary>
    [JsonPropertyName("customerGatewayId")]
    public string? CustomerGatewayId { get; set; }

    /// <summary>Reference to a CustomerGateway in ec2 to populate customerGatewayId.</summary>
    [JsonPropertyName("customerGatewayIdRef")]
    public V1beta1VPNConnectionSpecForProviderCustomerGatewayIdRef? CustomerGatewayIdRef { get; set; }

    /// <summary>Selector for a CustomerGateway in ec2 to populate customerGatewayId.</summary>
    [JsonPropertyName("customerGatewayIdSelector")]
    public V1beta1VPNConnectionSpecForProviderCustomerGatewayIdSelector? CustomerGatewayIdSelector { get; set; }

    /// <summary>Indicate whether to enable acceleration for the VPN connection. Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("enableAcceleration")]
    public bool? EnableAcceleration { get; set; }

    /// <summary>The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv4NetworkCidr")]
    public string? LocalIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv6NetworkCidr")]
    public string? LocalIpv6NetworkCidr { get; set; }

    /// <summary>Indicates if a Public S2S VPN or Private S2S VPN over AWS Direct Connect. Valid values are PublicIpv4 | PrivateIpv4</summary>
    [JsonPropertyName("outsideIpAddressType")]
    public string? OutsideIpAddressType { get; set; }

    /// <summary>Storage mode for the pre-shared key (PSK). Valid values are Standard (stored in the Site-to-Site VPN service) or SecretsManager (stored in AWS Secrets Manager).</summary>
    [JsonPropertyName("presharedKeyStorage")]
    public string? PresharedKeyStorage { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The IPv4 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv4NetworkCidr")]
    public string? RemoteIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv6NetworkCidr")]
    public string? RemoteIpv6NetworkCidr { get; set; }

    /// <summary>Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.</summary>
    [JsonPropertyName("staticRoutesOnly")]
    public bool? StaticRoutesOnly { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta1VPNConnectionSpecForProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta1VPNConnectionSpecForProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>. The attachment ID of the Transit Gateway attachment to Direct Connect Gateway. The ID is obtained through a data source only.</summary>
    [JsonPropertyName("transportTransitGatewayAttachmentId")]
    public string? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the first VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutAction")]
    public string? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the first VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutSeconds")]
    public double? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the first VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel1EnableTunnelLifecycleControl")]
    public bool? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the first VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel1IkeVersions")]
    public IList<string>? Tunnel1IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the first VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel1InsideCidr")]
    public string? Tunnel1InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the first VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel1InsideIpv6Cidr")]
    public string? Tunnel1InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel1LogOptions")]
    public V1beta1VPNConnectionSpecForProviderTunnel1LogOptions? Tunnel1LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase1DhGroupNumbers")]
    public IList<double>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel1Phase1LifetimeSeconds")]
    public double? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase2DhGroupNumbers")]
    public IList<double>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel1Phase2LifetimeSeconds")]
    public double? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>The preshared key of the first VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
    [JsonPropertyName("tunnel1PresharedKeySecretRef")]
    public V1beta1VPNConnectionSpecForProviderTunnel1PresharedKeySecretRef? Tunnel1PresharedKeySecretRef { get; set; }

    /// <summary>The percentage of the rekey window for the first VPN tunnel (determined by tunnel1_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel1RekeyFuzzPercentage")]
    public double? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the first VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel1_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel1_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel1RekeyMarginTimeSeconds")]
    public double? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the first VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel1ReplayWindowSize")]
    public double? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the first VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel1StartupAction")]
    public string? Tunnel1StartupAction { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the second VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutAction")]
    public string? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the second VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutSeconds")]
    public double? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the second VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel2EnableTunnelLifecycleControl")]
    public bool? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the second VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel2IkeVersions")]
    public IList<string>? Tunnel2IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the second VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel2InsideCidr")]
    public string? Tunnel2InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the second VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel2InsideIpv6Cidr")]
    public string? Tunnel2InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel2LogOptions")]
    public V1beta1VPNConnectionSpecForProviderTunnel2LogOptions? Tunnel2LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase1DhGroupNumbers")]
    public IList<double>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel2Phase1LifetimeSeconds")]
    public double? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase2DhGroupNumbers")]
    public IList<double>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel2Phase2LifetimeSeconds")]
    public double? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>The preshared key of the second VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
    [JsonPropertyName("tunnel2PresharedKeySecretRef")]
    public V1beta1VPNConnectionSpecForProviderTunnel2PresharedKeySecretRef? Tunnel2PresharedKeySecretRef { get; set; }

    /// <summary>The percentage of the rekey window for the second VPN tunnel (determined by tunnel2_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel2RekeyFuzzPercentage")]
    public double? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the second VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel2_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel2_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel2RekeyMarginTimeSeconds")]
    public double? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the second VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel2ReplayWindowSize")]
    public double? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the second VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel2StartupAction")]
    public string? Tunnel2StartupAction { get; set; }

    /// <summary>Indicate whether the VPN tunnels process IPv4 or IPv6 traffic. Valid values are ipv4 | ipv6. ipv6 Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("tunnelInsideIpVersion")]
    public string? TunnelInsideIpVersion { get; set; }

    /// <summary>The type of VPN connection. The only type AWS supports at this time is "ipsec.1".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Reference to a CustomerGateway in ec2 to populate type.</summary>
    [JsonPropertyName("typeRef")]
    public V1beta1VPNConnectionSpecForProviderTypeRef? TypeRef { get; set; }

    /// <summary>Selector for a CustomerGateway in ec2 to populate type.</summary>
    [JsonPropertyName("typeSelector")]
    public V1beta1VPNConnectionSpecForProviderTypeSelector? TypeSelector { get; set; }

    /// <summary>The ID of the Virtual Private Gateway.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdRef")]
    public V1beta1VPNConnectionSpecForProviderVpnGatewayIdRef? VpnGatewayIdRef { get; set; }

    /// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdSelector")]
    public V1beta1VPNConnectionSpecForProviderVpnGatewayIdSelector? VpnGatewayIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CustomerGateway in ec2 to populate customerGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CustomerGateway in ec2 to populate customerGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTransitGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel1LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel1LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionSpecInitProviderTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary>The preshared key of the first VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel1PresharedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel2LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel2LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionSpecInitProviderTunnel2LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary>The preshared key of the second VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTunnel2PresharedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CustomerGateway in ec2 to populate type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderTypeRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CustomerGateway in ec2 to populate type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderTypeSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderVpnGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderVpnGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderVpnGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderVpnGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProviderVpnGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNConnectionSpecInitProviderVpnGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecInitProvider
{
    /// <summary>The ID of the customer gateway.</summary>
    [JsonPropertyName("customerGatewayId")]
    public string? CustomerGatewayId { get; set; }

    /// <summary>Reference to a CustomerGateway in ec2 to populate customerGatewayId.</summary>
    [JsonPropertyName("customerGatewayIdRef")]
    public V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdRef? CustomerGatewayIdRef { get; set; }

    /// <summary>Selector for a CustomerGateway in ec2 to populate customerGatewayId.</summary>
    [JsonPropertyName("customerGatewayIdSelector")]
    public V1beta1VPNConnectionSpecInitProviderCustomerGatewayIdSelector? CustomerGatewayIdSelector { get; set; }

    /// <summary>Indicate whether to enable acceleration for the VPN connection. Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("enableAcceleration")]
    public bool? EnableAcceleration { get; set; }

    /// <summary>The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv4NetworkCidr")]
    public string? LocalIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv6NetworkCidr")]
    public string? LocalIpv6NetworkCidr { get; set; }

    /// <summary>Indicates if a Public S2S VPN or Private S2S VPN over AWS Direct Connect. Valid values are PublicIpv4 | PrivateIpv4</summary>
    [JsonPropertyName("outsideIpAddressType")]
    public string? OutsideIpAddressType { get; set; }

    /// <summary>Storage mode for the pre-shared key (PSK). Valid values are Standard (stored in the Site-to-Site VPN service) or SecretsManager (stored in AWS Secrets Manager).</summary>
    [JsonPropertyName("presharedKeyStorage")]
    public string? PresharedKeyStorage { get; set; }

    /// <summary>The IPv4 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv4NetworkCidr")]
    public string? RemoteIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv6NetworkCidr")]
    public string? RemoteIpv6NetworkCidr { get; set; }

    /// <summary>Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.</summary>
    [JsonPropertyName("staticRoutesOnly")]
    public bool? StaticRoutesOnly { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta1VPNConnectionSpecInitProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta1VPNConnectionSpecInitProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>. The attachment ID of the Transit Gateway attachment to Direct Connect Gateway. The ID is obtained through a data source only.</summary>
    [JsonPropertyName("transportTransitGatewayAttachmentId")]
    public string? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the first VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutAction")]
    public string? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the first VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutSeconds")]
    public double? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the first VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel1EnableTunnelLifecycleControl")]
    public bool? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the first VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel1IkeVersions")]
    public IList<string>? Tunnel1IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the first VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel1InsideCidr")]
    public string? Tunnel1InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the first VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel1InsideIpv6Cidr")]
    public string? Tunnel1InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel1LogOptions")]
    public V1beta1VPNConnectionSpecInitProviderTunnel1LogOptions? Tunnel1LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase1DhGroupNumbers")]
    public IList<double>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel1Phase1LifetimeSeconds")]
    public double? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase2DhGroupNumbers")]
    public IList<double>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel1Phase2LifetimeSeconds")]
    public double? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>The preshared key of the first VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
    [JsonPropertyName("tunnel1PresharedKeySecretRef")]
    public V1beta1VPNConnectionSpecInitProviderTunnel1PresharedKeySecretRef? Tunnel1PresharedKeySecretRef { get; set; }

    /// <summary>The percentage of the rekey window for the first VPN tunnel (determined by tunnel1_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel1RekeyFuzzPercentage")]
    public double? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the first VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel1_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel1_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel1RekeyMarginTimeSeconds")]
    public double? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the first VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel1ReplayWindowSize")]
    public double? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the first VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel1StartupAction")]
    public string? Tunnel1StartupAction { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the second VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutAction")]
    public string? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the second VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutSeconds")]
    public double? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the second VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel2EnableTunnelLifecycleControl")]
    public bool? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the second VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel2IkeVersions")]
    public IList<string>? Tunnel2IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the second VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel2InsideCidr")]
    public string? Tunnel2InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the second VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel2InsideIpv6Cidr")]
    public string? Tunnel2InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel2LogOptions")]
    public V1beta1VPNConnectionSpecInitProviderTunnel2LogOptions? Tunnel2LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase1DhGroupNumbers")]
    public IList<double>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel2Phase1LifetimeSeconds")]
    public double? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase2DhGroupNumbers")]
    public IList<double>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel2Phase2LifetimeSeconds")]
    public double? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>The preshared key of the second VPN tunnel. The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).</summary>
    [JsonPropertyName("tunnel2PresharedKeySecretRef")]
    public V1beta1VPNConnectionSpecInitProviderTunnel2PresharedKeySecretRef? Tunnel2PresharedKeySecretRef { get; set; }

    /// <summary>The percentage of the rekey window for the second VPN tunnel (determined by tunnel2_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel2RekeyFuzzPercentage")]
    public double? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the second VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel2_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel2_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel2RekeyMarginTimeSeconds")]
    public double? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the second VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel2ReplayWindowSize")]
    public double? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the second VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel2StartupAction")]
    public string? Tunnel2StartupAction { get; set; }

    /// <summary>Indicate whether the VPN tunnels process IPv4 or IPv6 traffic. Valid values are ipv4 | ipv6. ipv6 Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("tunnelInsideIpVersion")]
    public string? TunnelInsideIpVersion { get; set; }

    /// <summary>The type of VPN connection. The only type AWS supports at this time is "ipsec.1".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Reference to a CustomerGateway in ec2 to populate type.</summary>
    [JsonPropertyName("typeRef")]
    public V1beta1VPNConnectionSpecInitProviderTypeRef? TypeRef { get; set; }

    /// <summary>Selector for a CustomerGateway in ec2 to populate type.</summary>
    [JsonPropertyName("typeSelector")]
    public V1beta1VPNConnectionSpecInitProviderTypeSelector? TypeSelector { get; set; }

    /// <summary>The ID of the Virtual Private Gateway.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdRef")]
    public V1beta1VPNConnectionSpecInitProviderVpnGatewayIdRef? VpnGatewayIdRef { get; set; }

    /// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdSelector")]
    public V1beta1VPNConnectionSpecInitProviderVpnGatewayIdSelector? VpnGatewayIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VPNConnectionSpec defines the desired state of VPNConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderRoutes
{
    /// <summary>The CIDR block associated with the local subnet of the customer data center.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>Indicates how the routes were provided.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The current state of the static route.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderTunnel1LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderTunnel1LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionStatusAtProviderTunnel1LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderTunnel2LogOptionsCloudwatchLogOptions
{
    /// <summary>Enable or disable VPN tunnel logging feature. The default is false.</summary>
    [JsonPropertyName("logEnabled")]
    public bool? LogEnabled { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch log group to send logs to.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Set log format. Default format is json. Possible values are: json and text. The default is json.</summary>
    [JsonPropertyName("logOutputFormat")]
    public string? LogOutputFormat { get; set; }
}

/// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderTunnel2LogOptions
{
    /// <summary>Options for sending VPN tunnel logs to CloudWatch. See CloudWatch Log Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLogOptions")]
    public V1beta1VPNConnectionStatusAtProviderTunnel2LogOptionsCloudwatchLogOptions? CloudwatchLogOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProviderVgwTelemetry
{
    /// <summary>The number of accepted routes.</summary>
    [JsonPropertyName("acceptedRouteCount")]
    public double? AcceptedRouteCount { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the VPN tunnel endpoint certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>The date and time of the last change in status.</summary>
    [JsonPropertyName("lastStatusChange")]
    public string? LastStatusChange { get; set; }

    /// <summary>The Internet-routable IP address of the virtual private gateway's outside interface.</summary>
    [JsonPropertyName("outsideIpAddress")]
    public string? OutsideIpAddress { get; set; }

    /// <summary>The status of the VPN tunnel.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>If an error occurs, a description of the error.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the VPN Connection.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ARN of the core network.</summary>
    [JsonPropertyName("coreNetworkArn")]
    public string? CoreNetworkArn { get; set; }

    /// <summary>The ARN of the core network attachment.</summary>
    [JsonPropertyName("coreNetworkAttachmentArn")]
    public string? CoreNetworkAttachmentArn { get; set; }

    /// <summary>The ID of the customer gateway.</summary>
    [JsonPropertyName("customerGatewayId")]
    public string? CustomerGatewayId { get; set; }

    /// <summary>Indicate whether to enable acceleration for the VPN connection. Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("enableAcceleration")]
    public bool? EnableAcceleration { get; set; }

    /// <summary>The amazon-assigned ID of the VPN connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv4NetworkCidr")]
    public string? LocalIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the customer gateway (on-premises) side of the VPN connection.</summary>
    [JsonPropertyName("localIpv6NetworkCidr")]
    public string? LocalIpv6NetworkCidr { get; set; }

    /// <summary>Indicates if a Public S2S VPN or Private S2S VPN over AWS Direct Connect. Valid values are PublicIpv4 | PrivateIpv4</summary>
    [JsonPropertyName("outsideIpAddressType")]
    public string? OutsideIpAddressType { get; set; }

    /// <summary>ARN of the Secrets Manager secret storing the pre-shared key(s) for the VPN connection. Note that even if it returns a valid Secrets Manager ARN, the pre-shared key(s) will not be stored in Secrets Manager unless the preshared_key_storage argument is set to SecretsManager.</summary>
    [JsonPropertyName("presharedKeyArn")]
    public string? PresharedKeyArn { get; set; }

    /// <summary>Storage mode for the pre-shared key (PSK). Valid values are Standard (stored in the Site-to-Site VPN service) or SecretsManager (stored in AWS Secrets Manager).</summary>
    [JsonPropertyName("presharedKeyStorage")]
    public string? PresharedKeyStorage { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The IPv4 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv4NetworkCidr")]
    public string? RemoteIpv4NetworkCidr { get; set; }

    /// <summary>The IPv6 CIDR on the AWS side of the VPN connection.</summary>
    [JsonPropertyName("remoteIpv6NetworkCidr")]
    public string? RemoteIpv6NetworkCidr { get; set; }

    /// <summary>The static routes associated with the VPN connection. Detailed below.</summary>
    [JsonPropertyName("routes")]
    public IList<V1beta1VPNConnectionStatusAtProviderRoutes>? Routes { get; set; }

    /// <summary>Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.</summary>
    [JsonPropertyName("staticRoutesOnly")]
    public bool? StaticRoutesOnly { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>When associated with an EC2 Transit Gateway (transit_gateway_id argument), the attachment ID. See also the aws_ec2_tag resource for tagging the EC2 Transit Gateway VPN Attachment.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>. The attachment ID of the Transit Gateway attachment to Direct Connect Gateway. The ID is obtained through a data source only.</summary>
    [JsonPropertyName("transportTransitGatewayAttachmentId")]
    public string? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>The public IP address of the first VPN tunnel.</summary>
    [JsonPropertyName("tunnel1Address")]
    public string? Tunnel1Address { get; set; }

    /// <summary>The bgp asn number of the first VPN tunnel.</summary>
    [JsonPropertyName("tunnel1BgpAsn")]
    public string? Tunnel1BgpAsn { get; set; }

    /// <summary>The bgp holdtime of the first VPN tunnel.</summary>
    [JsonPropertyName("tunnel1BgpHoldtime")]
    public double? Tunnel1BgpHoldtime { get; set; }

    /// <summary>The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).</summary>
    [JsonPropertyName("tunnel1CgwInsideAddress")]
    public string? Tunnel1CgwInsideAddress { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the first VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutAction")]
    public string? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the first VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel1DpdTimeoutSeconds")]
    public double? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the first VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel1EnableTunnelLifecycleControl")]
    public bool? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the first VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel1IkeVersions")]
    public IList<string>? Tunnel1IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the first VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel1InsideCidr")]
    public string? Tunnel1InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the first VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel1InsideIpv6Cidr")]
    public string? Tunnel1InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel1LogOptions")]
    public V1beta1VPNConnectionStatusAtProviderTunnel1LogOptions? Tunnel1LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase1DhGroupNumbers")]
    public IList<double>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the first VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel1Phase1LifetimeSeconds")]
    public double? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel1Phase2DhGroupNumbers")]
    public IList<double>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel1Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the first VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel1Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the first VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel1Phase2LifetimeSeconds")]
    public double? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>The percentage of the rekey window for the first VPN tunnel (determined by tunnel1_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel1RekeyFuzzPercentage")]
    public double? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the first VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel1_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel1_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel1RekeyMarginTimeSeconds")]
    public double? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the first VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel1ReplayWindowSize")]
    public double? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the first VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel1StartupAction")]
    public string? Tunnel1StartupAction { get; set; }

    /// <summary>The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).</summary>
    [JsonPropertyName("tunnel1VgwInsideAddress")]
    public string? Tunnel1VgwInsideAddress { get; set; }

    /// <summary>The public IP address of the second VPN tunnel.</summary>
    [JsonPropertyName("tunnel2Address")]
    public string? Tunnel2Address { get; set; }

    /// <summary>The bgp asn number of the second VPN tunnel.</summary>
    [JsonPropertyName("tunnel2BgpAsn")]
    public string? Tunnel2BgpAsn { get; set; }

    /// <summary>The bgp holdtime of the second VPN tunnel.</summary>
    [JsonPropertyName("tunnel2BgpHoldtime")]
    public double? Tunnel2BgpHoldtime { get; set; }

    /// <summary>The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).</summary>
    [JsonPropertyName("tunnel2CgwInsideAddress")]
    public string? Tunnel2CgwInsideAddress { get; set; }

    /// <summary>The action to take after DPD timeout occurs for the second VPN tunnel. Specify restart to restart the IKE initiation. Specify clear to end the IKE session. Valid values are clear | none | restart.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutAction")]
    public string? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>The number of seconds after which a DPD timeout occurs for the second VPN tunnel. Valid value is equal or higher than 30.</summary>
    [JsonPropertyName("tunnel2DpdTimeoutSeconds")]
    public double? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>Turn on or off tunnel endpoint lifecycle control feature for the second VPN tunnel. Valid values are true | false.</summary>
    [JsonPropertyName("tunnel2EnableTunnelLifecycleControl")]
    public bool? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>The IKE versions that are permitted for the second VPN tunnel. Valid values are ikev1 | ikev2.</summary>
    [JsonPropertyName("tunnel2IkeVersions")]
    public IList<string>? Tunnel2IkeVersions { get; set; }

    /// <summary>The CIDR block of the inside IP addresses for the second VPN tunnel. Valid value is a size /30 CIDR block from the 169.254.0.0/16 range.</summary>
    [JsonPropertyName("tunnel2InsideCidr")]
    public string? Tunnel2InsideCidr { get; set; }

    /// <summary>The range of inside IPv6 addresses for the second VPN tunnel. Supports only EC2 Transit Gateway. Valid value is a size /126 CIDR block from the local fd00::/8 range.</summary>
    [JsonPropertyName("tunnel2InsideIpv6Cidr")]
    public string? Tunnel2InsideIpv6Cidr { get; set; }

    /// <summary>Options for logging VPN tunnel activity. See Log Options below for more details.</summary>
    [JsonPropertyName("tunnel2LogOptions")]
    public V1beta1VPNConnectionStatusAtProviderTunnel2LogOptions? Tunnel2LogOptions { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are  2 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase1DhGroupNumbers")]
    public IList<double>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase1EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>One or more integrity algorithms that are permitted for the second VPN tunnel for phase 1 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase1IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 1 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 28800.</summary>
    [JsonPropertyName("tunnel2Phase1LifetimeSeconds")]
    public double? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>List of one or more Diffie-Hellman group numbers that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are 2 | 5 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24.</summary>
    [JsonPropertyName("tunnel2Phase2DhGroupNumbers")]
    public IList<double>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>List of one or more encryption algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are AES128 | AES256 | AES128-GCM-16 | AES256-GCM-16.</summary>
    [JsonPropertyName("tunnel2Phase2EncryptionAlgorithms")]
    public IList<string>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>List of one or more integrity algorithms that are permitted for the second VPN tunnel for phase 2 IKE negotiations. Valid values are SHA1 | SHA2-256 | SHA2-384 | SHA2-512.</summary>
    [JsonPropertyName("tunnel2Phase2IntegrityAlgorithms")]
    public IList<string>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>The lifetime for phase 2 of the IKE negotiation for the second VPN tunnel, in seconds. Valid value is between 900 and 3600.</summary>
    [JsonPropertyName("tunnel2Phase2LifetimeSeconds")]
    public double? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>The percentage of the rekey window for the second VPN tunnel (determined by tunnel2_rekey_margin_time_seconds) during which the rekey time is randomly selected. Valid value is between 0 and 100.</summary>
    [JsonPropertyName("tunnel2RekeyFuzzPercentage")]
    public double? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>The margin time, in seconds, before the phase 2 lifetime expires, during which the AWS side of the second VPN connection performs an IKE rekey. The exact time of the rekey is randomly selected based on the value for tunnel2_rekey_fuzz_percentage. Valid value is between 60 and half of tunnel2_phase2_lifetime_seconds.</summary>
    [JsonPropertyName("tunnel2RekeyMarginTimeSeconds")]
    public double? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>The number of packets in an IKE replay window for the second VPN tunnel. Valid value is between 64 and 2048.</summary>
    [JsonPropertyName("tunnel2ReplayWindowSize")]
    public double? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>The action to take when the establishing the tunnel for the second VPN connection. By default, your customer gateway device must initiate the IKE negotiation and bring up the tunnel. Specify start for AWS to initiate the IKE negotiation. Valid values are add | start.</summary>
    [JsonPropertyName("tunnel2StartupAction")]
    public string? Tunnel2StartupAction { get; set; }

    /// <summary>The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).</summary>
    [JsonPropertyName("tunnel2VgwInsideAddress")]
    public string? Tunnel2VgwInsideAddress { get; set; }

    /// <summary>Indicate whether the VPN tunnels process IPv4 or IPv6 traffic. Valid values are ipv4 | ipv6. ipv6 Supports only EC2 Transit Gateway.</summary>
    [JsonPropertyName("tunnelInsideIpVersion")]
    public string? TunnelInsideIpVersion { get; set; }

    /// <summary>The type of VPN connection. The only type AWS supports at this time is "ipsec.1".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Telemetry for the VPN tunnels. Detailed below.</summary>
    [JsonPropertyName("vgwTelemetry")]
    public IList<V1beta1VPNConnectionStatusAtProviderVgwTelemetry>? VgwTelemetry { get; set; }

    /// <summary>The ID of the Virtual Private Gateway.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatusConditions
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

/// <summary>VPNConnectionStatus defines the observed state of VPNConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPNConnection is the Schema for the VPNConnections API. Manages a Site-to-Site VPN connection. A Site-to-Site VPN connection is an Internet Protocol security (IPsec) VPN connection between a VPC and an on-premises network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNConnectionSpec>, IStatus<V1beta1VPNConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNConnection";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpnconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNConnectionSpec defines the desired state of VPNConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNConnectionSpec Spec { get; set; }

    /// <summary>VPNConnectionStatus defines the observed state of VPNConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNConnectionStatus? Status { get; set; }
}