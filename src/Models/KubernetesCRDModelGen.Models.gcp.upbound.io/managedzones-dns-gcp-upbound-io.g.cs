using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.upbound.io;
#nullable enable
/// <summary>ManagedZone is the Schema for the ManagedZones API. A zone is a subtree of the DNS namespace under one administrative responsibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedZoneList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagedZone>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedZoneList";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "managedzones";
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
    public IList<V1beta1ManagedZone> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>String mnemonic specifying the DNSSEC algorithm of this key Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the Secure Entry Point flag set and, when active, will only be used to sign resource record sets of type DNSKEY. Zone signing keys do not have the Secure Entry Point flag set and will be used to sign all other types of resource record sets. Possible values are: keySigning, zoneSigning.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderDnssecConfig
{
    /// <summary>Specifies parameters that will be used for generating initial DnsKeys for this ManagedZone. If you provide a spec for keySigning or zoneSigning, you must also provide one for the other. default_key_specs can only be updated when the state is off. Structure is documented below.</summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta1ManagedZoneSpecForProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the mechanism used to provide authenticated denial-of-existence responses. non_existence can only be updated when the state is off. Possible values are: nsec, nsec3.</summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in Possible values are: off, on, transfer.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderForwardingConfig
{
    /// <summary>List of target name servers to forward to. Cloud DNS will select the best available name server if more than one target is given. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1ManagedZoneSpecForProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetwork
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelector? NetworkUrlSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPeeringConfig
{
    /// <summary>The network with which to peer. Structure is documented below.</summary>
    [JsonPropertyName("targetNetwork")]
    public IList<V1beta1ManagedZoneSpecForProviderPeeringConfigTargetNetwork>? TargetNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like projects/*/locations/*/clusters/*</summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }

    /// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef? GkeClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameSelector")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector? GkeClusterNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworks
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelector? NetworkUrlSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfig
{
    /// <summary>The list of Google Kubernetes Engine clusters that can see this zone. Structure is documented below.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>The list of VPC networks that can see this zone.12 SDK in a future release, you may experience issues with this resource while updating. If you encounter this issue, remove all networks blocks in an update and then apply another update adding all of them back simultaneously. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecForProvider
{
    /// <summary>Cloud logging configuration Structure is documented below.</summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public IList<V1beta1ManagedZoneSpecForProviderCloudLoggingConfig>? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance "example.com.".</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>DNSSEC configuration Structure is documented below.</summary>
    [JsonPropertyName("dnssecConfig")]
    public IList<V1beta1ManagedZoneSpecForProviderDnssecConfig>? DnssecConfig { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this field contains the set of destinations to forward to. Structure is documented below.</summary>
    [JsonPropertyName("forwardingConfig")]
    public IList<V1beta1ManagedZoneSpecForProviderForwardingConfig>? ForwardingConfig { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field contains the network to peer with. Structure is documented below.</summary>
    [JsonPropertyName("peeringConfig")]
    public IList<V1beta1ManagedZoneSpecForProviderPeeringConfig>? PeeringConfig { get; set; }

    /// <summary>For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from. At least one of gke_clusters or networks must be specified. Structure is documented below.</summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public IList<V1beta1ManagedZoneSpecForProviderPrivateVisibilityConfig>? PrivateVisibilityConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources. Default value is public. Possible values are: private, public.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>String mnemonic specifying the DNSSEC algorithm of this key Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the Secure Entry Point flag set and, when active, will only be used to sign resource record sets of type DNSKEY. Zone signing keys do not have the Secure Entry Point flag set and will be used to sign all other types of resource record sets. Possible values are: keySigning, zoneSigning.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderDnssecConfig
{
    /// <summary>Specifies parameters that will be used for generating initial DnsKeys for this ManagedZone. If you provide a spec for keySigning or zoneSigning, you must also provide one for the other. default_key_specs can only be updated when the state is off. Structure is documented below.</summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta1ManagedZoneSpecInitProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the mechanism used to provide authenticated denial-of-existence responses. non_existence can only be updated when the state is off. Possible values are: nsec, nsec3.</summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in Possible values are: off, on, transfer.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderForwardingConfig
{
    /// <summary>List of target name servers to forward to. Cloud DNS will select the best available name server if more than one target is given. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1ManagedZoneSpecInitProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetwork
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelector? NetworkUrlSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPeeringConfig
{
    /// <summary>The network with which to peer. Structure is documented below.</summary>
    [JsonPropertyName("targetNetwork")]
    public IList<V1beta1ManagedZoneSpecInitProviderPeeringConfigTargetNetwork>? TargetNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like projects/*/locations/*/clusters/*</summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }

    /// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef? GkeClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameSelector")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector? GkeClusterNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworks
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelector? NetworkUrlSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfig
{
    /// <summary>The list of Google Kubernetes Engine clusters that can see this zone. Structure is documented below.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>The list of VPC networks that can see this zone.12 SDK in a future release, you may experience issues with this resource while updating. If you encounter this issue, remove all networks blocks in an update and then apply another update adding all of them back simultaneously. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecInitProvider
{
    /// <summary>Cloud logging configuration Structure is documented below.</summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public IList<V1beta1ManagedZoneSpecInitProviderCloudLoggingConfig>? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance "example.com.".</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>DNSSEC configuration Structure is documented below.</summary>
    [JsonPropertyName("dnssecConfig")]
    public IList<V1beta1ManagedZoneSpecInitProviderDnssecConfig>? DnssecConfig { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this field contains the set of destinations to forward to. Structure is documented below.</summary>
    [JsonPropertyName("forwardingConfig")]
    public IList<V1beta1ManagedZoneSpecInitProviderForwardingConfig>? ForwardingConfig { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field contains the network to peer with. Structure is documented below.</summary>
    [JsonPropertyName("peeringConfig")]
    public IList<V1beta1ManagedZoneSpecInitProviderPeeringConfig>? PeeringConfig { get; set; }

    /// <summary>For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from. At least one of gke_clusters or networks must be specified. Structure is documented below.</summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public IList<V1beta1ManagedZoneSpecInitProviderPrivateVisibilityConfig>? PrivateVisibilityConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources. Default value is public. Possible values are: private, public.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedZoneSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedZoneSpec defines the desired state of ManagedZone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagedZoneSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagedZoneSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagedZoneSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagedZoneSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>String mnemonic specifying the DNSSEC algorithm of this key Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the Secure Entry Point flag set and, when active, will only be used to sign resource record sets of type DNSKEY. Zone signing keys do not have the Secure Entry Point flag set and will be used to sign all other types of resource record sets. Possible values are: keySigning, zoneSigning.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderDnssecConfig
{
    /// <summary>Specifies parameters that will be used for generating initial DnsKeys for this ManagedZone. If you provide a spec for keySigning or zoneSigning, you must also provide one for the other. default_key_specs can only be updated when the state is off. Structure is documented below.</summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta1ManagedZoneStatusAtProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the mechanism used to provide authenticated denial-of-existence responses. non_existence can only be updated when the state is off. Possible values are: nsec, nsec3.</summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in Possible values are: off, on, transfer.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderForwardingConfig
{
    /// <summary>List of target name servers to forward to. Cloud DNS will select the best available name server if more than one target is given. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1ManagedZoneStatusAtProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderPeeringConfigTargetNetwork
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderPeeringConfig
{
    /// <summary>The network with which to peer. Structure is documented below.</summary>
    [JsonPropertyName("targetNetwork")]
    public IList<V1beta1ManagedZoneStatusAtProviderPeeringConfigTargetNetwork>? TargetNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like projects/*/locations/*/clusters/*</summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfigNetworks
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfig
{
    /// <summary>The list of Google Kubernetes Engine clusters that can see this zone. Structure is documented below.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>The list of VPC networks that can see this zone.12 SDK in a future release, you may experience issues with this resource while updating. If you encounter this issue, remove all networks blocks in an update and then apply another update adding all of them back simultaneously. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusAtProvider
{
    /// <summary>Cloud logging configuration Structure is documented below.</summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public IList<V1beta1ManagedZoneStatusAtProviderCloudLoggingConfig>? CloudLoggingConfig { get; set; }

    /// <summary>The time that this resource was created on the server. This is in RFC3339 text format.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance "example.com.".</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>DNSSEC configuration Structure is documented below.</summary>
    [JsonPropertyName("dnssecConfig")]
    public IList<V1beta1ManagedZoneStatusAtProviderDnssecConfig>? DnssecConfig { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this field contains the set of destinations to forward to. Structure is documented below.</summary>
    [JsonPropertyName("forwardingConfig")]
    public IList<V1beta1ManagedZoneStatusAtProviderForwardingConfig>? ForwardingConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/managedZones/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Unique identifier for the resource; defined by the server.</summary>
    [JsonPropertyName("managedZoneId")]
    public double? ManagedZoneId { get; set; }

    /// <summary>Delegate your managed_zone to these virtual name servers; defined by the server</summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary>The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field contains the network to peer with. Structure is documented below.</summary>
    [JsonPropertyName("peeringConfig")]
    public IList<V1beta1ManagedZoneStatusAtProviderPeeringConfig>? PeeringConfig { get; set; }

    /// <summary>For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from. At least one of gke_clusters or networks must be specified. Structure is documented below.</summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public IList<V1beta1ManagedZoneStatusAtProviderPrivateVisibilityConfig>? PrivateVisibilityConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources. Default value is public. Possible values are: private, public.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ManagedZoneStatus defines the observed state of ManagedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedZoneStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagedZoneStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedZoneStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedZone is the Schema for the ManagedZones API. A zone is a subtree of the DNS namespace under one administrative responsibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedZoneSpec>, IStatus<V1beta1ManagedZoneStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedZone";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "managedzones";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedZoneSpec defines the desired state of ManagedZone</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagedZoneSpec Spec { get; set; }

    /// <summary>ManagedZoneStatus defines the observed state of ManagedZone.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedZoneStatus? Status { get; set; }
}
#nullable disable
