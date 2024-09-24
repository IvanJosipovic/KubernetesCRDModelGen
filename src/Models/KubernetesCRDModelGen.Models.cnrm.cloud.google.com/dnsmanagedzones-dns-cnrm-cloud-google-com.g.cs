using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.cnrm.cloud.google.com;
/// <summary>Cloud logging configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool EnableLogging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecDnssecConfigDefaultKeySpecs
{
    /// <summary>String mnemonic specifying the DNSSEC algorithm of this key Possible values: ["ecdsap256sha256", "ecdsap384sha384", "rsasha1", "rsasha256", "rsasha512"].</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits.</summary>
    [JsonPropertyName("keyLength")]
    public int? KeyLength { get; set; }

    /// <summary>Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the Secure Entry Point flag set and, when active, will only be used to sign resource record sets of type DNSKEY. Zone signing keys do not have the Secure Entry Point flag set and will be used to sign all other types of resource record sets. Possible values: ["keySigning", "zoneSigning"].</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>DNSSEC configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecDnssecConfig
{
    /// <summary>Specifies parameters that will be used for generating initial DnsKeys for this ManagedZone. If you provide a spec for keySigning or zoneSigning, you must also provide one for the other. default_key_specs can only be updated when the state is 'off'.</summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta1DNSManagedZoneSpecDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the mechanism used to provide authenticated denial-of-existence responses. non_existence can only be updated when the state is 'off'. Possible values: ["nsec", "nsec3"].</summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in Possible values: ["off", "on", "transfer"].</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecForwardingConfigTargetNameServers
{
    /// <summary>Forwarding path for this TargetNameServer. If unset or 'default' Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to 'private', Cloud DNS will always send queries through VPC for this target Possible values: ["default", "private"].</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string Ipv4Address { get; set; }
}

/// <summary>The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this field contains the set of destinations to forward to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecForwardingConfig
{
    /// <summary>List of target name servers to forward to. Cloud DNS will select the best available name server if more than one target is given.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1DNSManagedZoneSpecForwardingConfigTargetNameServers> TargetNameServers { get; set; }
}

/// <summary>VPC network to forward queries to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfigTargetNetworkNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The network with which to peer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfigTargetNetwork
{
    /// <summary>VPC network to forward queries to.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1DNSManagedZoneSpecPeeringConfigTargetNetworkNetworkRef NetworkRef { get; set; }
}

/// <summary>The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field contains the network to peer with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfig
{
    /// <summary>The network with which to peer.</summary>
    [JsonPropertyName("targetNetwork")]
    public V1beta1DNSManagedZoneSpecPeeringConfigTargetNetwork TargetNetwork { get; set; }
}

/// <summary>The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like 'projects/*/locations/*/clusters/*'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClusters
{
    /// <summary>The resource name of the cluster to bind this ManagedZone to. This should be specified in the format like 'projects/*/locations/*/clusters/*'.</summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClustersGkeClusterNameRef GkeClusterNameRef { get; set; }
}

/// <summary>VPC network to bind to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworksNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworks
{
    /// <summary>VPC network to bind to.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworksNetworkRef NetworkRef { get; set; }
}

/// <summary>For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from. At least one of 'gke_clusters' or 'networks' must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfig
{
    /// <summary>The list of Google Kubernetes Engine clusters that can see this zone.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworks>? Networks { get; set; }
}

/// <summary>The namespace associated with the zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecServiceDirectoryConfigNamespace
{
    /// <summary>The fully qualified or partial URL of the service directory namespace that should be associated with the zone. This should be formatted like 'https://servicedirectory.googleapis.com/v1/projects/{project}/locations/{location}/namespaces/{namespace_id}' or simply 'projects/{project}/locations/{location}/namespaces/{namespace_id}' Ignored for 'public' visibility zones.</summary>
    [JsonPropertyName("namespaceUrl")]
    public string NamespaceUrl { get; set; }
}

/// <summary>Immutable. The presence of this field indicates that this zone is backed by Service Directory. The value of this field contains information related to the namespace associated with the zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecServiceDirectoryConfig
{
    /// <summary>The namespace associated with the zone.</summary>
    [JsonPropertyName("namespace")]
    public V1beta1DNSManagedZoneSpecServiceDirectoryConfigNamespace Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpec
{
    /// <summary>Cloud logging configuration.</summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public V1beta1DNSManagedZoneSpecCloudLoggingConfig? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field. Defaults to 'Managed by Config Connector'.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The DNS name of this managed zone, for instance "example.com.".</summary>
    [JsonPropertyName("dnsName")]
    public string DnsName { get; set; }

    /// <summary>DNSSEC configuration.</summary>
    [JsonPropertyName("dnssecConfig")]
    public V1beta1DNSManagedZoneSpecDnssecConfig? DnssecConfig { get; set; }

    /// <summary>The presence for this field indicates that outbound forwarding is enabled for this zone. The value of this field contains the set of destinations to forward to.</summary>
    [JsonPropertyName("forwardingConfig")]
    public V1beta1DNSManagedZoneSpecForwardingConfig? ForwardingConfig { get; set; }

    /// <summary>The presence of this field indicates that DNS Peering is enabled for this zone. The value of this field contains the network to peer with.</summary>
    [JsonPropertyName("peeringConfig")]
    public V1beta1DNSManagedZoneSpecPeeringConfig? PeeringConfig { get; set; }

    /// <summary>For privately visible zones, the set of Virtual Private Cloud resources that the zone is visible from. At least one of 'gke_clusters' or 'networks' must be specified.</summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public V1beta1DNSManagedZoneSpecPrivateVisibilityConfig? PrivateVisibilityConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Specifies if this is a managed reverse lookup zone. If true, Cloud DNS will resolve reverse lookup queries using automatically configured records for VPC resources. This only applies to networks listed under 'private_visibility_config'.</summary>
    [JsonPropertyName("reverseLookup")]
    public bool? ReverseLookup { get; set; }

    /// <summary>Immutable. The presence of this field indicates that this zone is backed by Service Directory. The value of this field contains information related to the namespace associated with the zone.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1DNSManagedZoneSpecServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Immutable. The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources. Default value: "public" Possible values: ["private", "public"].</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DNSManagedZoneStatusConditions>? Conditions { get; set; }

    /// <summary>The time that this resource was created on the server. This is in RFC3339 text format.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>Unique identifier for the resource; defined by the server.</summary>
    [JsonPropertyName("managedZoneId")]
    public int? ManagedZoneId { get; set; }

    /// <summary>Delegate your managed_zone to these virtual name servers; defined by the server.</summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DNSManagedZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DNSManagedZoneSpec>, IStatus<V1beta1DNSManagedZoneStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DNSManagedZone";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnsmanagedzones";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1DNSManagedZoneSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DNSManagedZoneStatus? Status { get; set; }
}