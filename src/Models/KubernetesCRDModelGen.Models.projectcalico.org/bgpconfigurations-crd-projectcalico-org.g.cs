using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>Community contains standard or large community value and its name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecCommunities
{
    /// <summary>Name given to community value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value must be of format `aa:nn` or `aa:nn:mm`. For standard community use `aa:nn` format, where `aa` and `nn` are 16 bit number. For large community use `aa:nn:mm` format, where `aa`, `nn` and `mm` are 32 bit number. Where, `aa` is an AS Number, `nn` and `mm` are per-AS identifier.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Selects a key of a secret in the node pod's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Optional BGP password for full node-to-mesh peerings. This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPassword
{
    /// <summary>Selects a key of a secret in the node pod's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>PrefixAdvertisement configures advertisement properties for the specified CIDR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecPrefixAdvertisements
{
    /// <summary>CIDR for which properties should be advertised.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>Communities can be list of either community names already defined in `Specs.Communities` or community value of format `aa:nn` or `aa:nn:mm`. For standard community use `aa:nn` format, where `aa` and `nn` are 16 bit number. For large community use `aa:nn:mm` format, where `aa`, `nn` and `mm` are 32 bit number. Where,`aa` is an AS Number, `nn` and `mm` are per-AS identifier.</summary>
    [JsonPropertyName("communities")]
    public IList<string>? Communities { get; set; }
}

/// <summary>ServiceClusterIPBlock represents a single allowed ClusterIP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceClusterIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>ServiceExternalIPBlock represents a single allowed External IP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceExternalIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>ServiceLoadBalancerIPBlock represents a single allowed LoadBalancer IP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceLoadBalancerIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>BGPConfigurationSpec contains the values of the BGP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpec
{
    /// <summary>ASNumber is the default AS number used by a node. [Default: 64512]</summary>
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    /// <summary>BindMode indicates whether to listen for BGP connections on all addresses (None) or only on the node's canonical IP address Node.Spec.BGP.IPvXAddress (NodeIP). Default behaviour is to listen for BGP connections on all addresses.</summary>
    [JsonPropertyName("bindMode")]
    public string? BindMode { get; set; }

    /// <summary>Communities is a list of BGP community values and their arbitrary names for tagging routes.</summary>
    [JsonPropertyName("communities")]
    public IList<V1BGPConfigurationSpecCommunities>? Communities { get; set; }

    /// <summary>IgnoredInterfaces indicates the network interfaces that needs to be excluded when reading device routes.</summary>
    [JsonPropertyName("ignoredInterfaces")]
    public IList<string>? IgnoredInterfaces { get; set; }

    /// <summary>ListenPort is the port where BGP protocol should listen. Defaults to 179</summary>
    [JsonPropertyName("listenPort")]
    public int? ListenPort { get; set; }

    /// <summary>LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: INFO]</summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary>Time to allow for software restart for node-to-mesh peerings.  When specified, this is configured as the graceful restart timeout.  When not specified, the BIRD default of 120s is used. This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled</summary>
    [JsonPropertyName("nodeMeshMaxRestartTime")]
    public string? NodeMeshMaxRestartTime { get; set; }

    /// <summary>Optional BGP password for full node-to-mesh peerings. This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled</summary>
    [JsonPropertyName("nodeMeshPassword")]
    public V1BGPConfigurationSpecNodeMeshPassword? NodeMeshPassword { get; set; }

    /// <summary>NodeToNodeMeshEnabled sets whether full node to node BGP mesh is enabled. [Default: true]</summary>
    [JsonPropertyName("nodeToNodeMeshEnabled")]
    public bool? NodeToNodeMeshEnabled { get; set; }

    /// <summary>PrefixAdvertisements contains per-prefix advertisement configuration.</summary>
    [JsonPropertyName("prefixAdvertisements")]
    public IList<V1BGPConfigurationSpecPrefixAdvertisements>? PrefixAdvertisements { get; set; }

    /// <summary>ServiceClusterIPs are the CIDR blocks from which service cluster IPs are allocated. If specified, Calico will advertise these blocks, as well as any cluster IPs within them.</summary>
    [JsonPropertyName("serviceClusterIPs")]
    public IList<V1BGPConfigurationSpecServiceClusterIPs>? ServiceClusterIPs { get; set; }

    /// <summary>ServiceExternalIPs are the CIDR blocks for Kubernetes Service External IPs. Kubernetes Service ExternalIPs will only be advertised if they are within one of these blocks.</summary>
    [JsonPropertyName("serviceExternalIPs")]
    public IList<V1BGPConfigurationSpecServiceExternalIPs>? ServiceExternalIPs { get; set; }

    /// <summary>ServiceLoadBalancerIPs are the CIDR blocks for Kubernetes Service LoadBalancer IPs. Kubernetes Service status.LoadBalancer.Ingress IPs will only be advertised if they are within one of these blocks.</summary>
    [JsonPropertyName("serviceLoadBalancerIPs")]
    public IList<V1BGPConfigurationSpecServiceLoadBalancerIPs>? ServiceLoadBalancerIPs { get; set; }
}

/// <summary>BGPConfiguration contains the configuration for any BGP routing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPConfigurationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BGPConfigurationSpec contains the values of the BGP configuration.</summary>
    [JsonPropertyName("spec")]
    public V1BGPConfigurationSpec? Spec { get; set; }
}