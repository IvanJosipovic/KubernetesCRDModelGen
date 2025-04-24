using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecManagedZoneRef
{
    /// <summary>Allowed value: The `name` field of a `DNSManagedZone` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersIpAddressRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersNetworkRef
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
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersRegionRef
{
    /// <summary>Allowed value: The `location` field of a `ComputeForwardingRule` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary></summary>
    [JsonPropertyName("ipAddressRef")]
    public DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersIpAddressRef IpAddressRef { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"].</summary>
    [JsonPropertyName("ipProtocol")]
    public string IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"].</summary>
    [JsonPropertyName("loadBalancerType")]
    public string LoadBalancerType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersNetworkRef NetworkRef { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersProjectRef ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionRef")]
    public DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancersRegionRef? RegionRef { get; set; }
}

/// <summary>For A and AAAA types only. The list of targets to be health checked. These can be specified along with `rrdatas` within this item.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of internal load balancers to health check.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers> InternalLoadBalancers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyGeoRrdatasRefs
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: ComputeAddress</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyGeo
{
    /// <summary>For A and AAAA types only. The list of targets to be health checked. These can be specified along with `rrdatas` within this item.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public DNSRecordSetSpecRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rrdatasRefs")]
    public IList<DNSRecordSetSpecRoutingPolicyGeoRrdatasRefs>? RrdatasRefs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersIpAddressRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersNetworkRef
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersRegionRef
{
    /// <summary>Allowed value: The `location` field of a `ComputeForwardingRule` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary></summary>
    [JsonPropertyName("ipAddressRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersIpAddressRef IpAddressRef { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"].</summary>
    [JsonPropertyName("ipProtocol")]
    public string IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"].</summary>
    [JsonPropertyName("loadBalancerType")]
    public string LoadBalancerType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersNetworkRef NetworkRef { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersProjectRef ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancersRegionRef? RegionRef { get; set; }
}

/// <summary>For A and AAAA types only. The list of targets to be health checked. These can be specified along with `rrdatas` within this item.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of internal load balancers to health check.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers> InternalLoadBalancers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoRrdatasRefs
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>For A and AAAA types only. The list of targets to be health checked. These can be specified along with `rrdatas` within this item.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rrdatasRefs")]
    public IList<DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeoRrdatasRefs>? RrdatasRefs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkRef
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Allowed value: The `location` field of a `ComputeForwardingRule` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary></summary>
    [JsonPropertyName("ipAddressRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef IpAddressRef { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"].</summary>
    [JsonPropertyName("ipProtocol")]
    public string IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"].</summary>
    [JsonPropertyName("loadBalancerType")]
    public string LoadBalancerType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkRef NetworkRef { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionRef")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }
}

/// <summary>The list of global primary targets to be health checked.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of internal load balancers to health check.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers> InternalLoadBalancers { get; set; }
}

/// <summary>The configuration for a primary-backup policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyPrimaryBackup
{
    /// <summary>The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.</summary>
    [JsonPropertyName("backupGeo")]
    public IList<DNSRecordSetSpecRoutingPolicyPrimaryBackupBackupGeo> BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>The list of global primary targets to be health checked.</summary>
    [JsonPropertyName("primary")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackupPrimary Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersIpAddressRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersNetworkRef
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
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersRegionRef
{
    /// <summary>Allowed value: The `location` field of a `ComputeForwardingRule` resource.</summary>
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
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary></summary>
    [JsonPropertyName("ipAddressRef")]
    public DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersIpAddressRef IpAddressRef { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"].</summary>
    [JsonPropertyName("ipProtocol")]
    public string IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"].</summary>
    [JsonPropertyName("loadBalancerType")]
    public string LoadBalancerType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersNetworkRef NetworkRef { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersProjectRef ProjectRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionRef")]
    public DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancersRegionRef? RegionRef { get; set; }
}

/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of `rrdatas` or `health_checked_targets` can be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of internal load balancers to health check.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers> InternalLoadBalancers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyWrrRrdatasRefs
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: ComputeAddress</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicyWrr
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of `rrdatas` or `health_checked_targets` can be set.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public DNSRecordSetSpecRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rrdatasRefs")]
    public IList<DNSRecordSetSpecRoutingPolicyWrrRrdatasRefs>? RrdatasRefs { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double Weight { get; set; }
}

/// <summary>The configuration for steering traffic based on query. You can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>The configuration for Geo location based routing policy.</summary>
    [JsonPropertyName("geo")]
    public IList<DNSRecordSetSpecRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>The configuration for a primary-backup policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.</summary>
    [JsonPropertyName("primaryBackup")]
    public DNSRecordSetSpecRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>The configuration for Weighted Round Robin based routing policy.</summary>
    [JsonPropertyName("wrr")]
    public IList<DNSRecordSetSpecRoutingPolicyWrr>? Wrr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpecRrdatasRefs
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: ComputeAddress</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("managedZoneRef")]
    public DNSRecordSetSpecManagedZoneRef ManagedZoneRef { get; set; }

    /// <summary>Immutable. The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The configuration for steering traffic based on query. You can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.</summary>
    [JsonPropertyName("routingPolicy")]
    public DNSRecordSetSpecRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>DEPRECATED. Although this field is still available, there is limited support. We recommend that you use `spec.rrdatasRefs` instead.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rrdatasRefs")]
    public IList<DNSRecordSetSpecRrdatasRefs>? RrdatasRefs { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSetStatusConditions
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
public partial class DNSRecordSetStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<DNSRecordSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DNSRecordSet
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public DNSRecordSetMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public DNSRecordSetSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public DNSRecordSetStatus? Status { get; set; }
}