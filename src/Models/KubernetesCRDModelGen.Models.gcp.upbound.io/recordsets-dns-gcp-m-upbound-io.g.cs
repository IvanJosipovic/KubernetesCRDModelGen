using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.m.upbound.io;
#nullable enable
/// <summary>RecordSet is the Schema for the RecordSets API. Manages a set of DNS records within Google Cloud DNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecordSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RecordSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordSetList";
    public const string KubeGroup = "dns.gcp.m.upbound.io";
    public const string KubePluralName = "recordsets";
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
    public IList<V1beta1RecordSet> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneRefPolicy
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
/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderManagedZoneRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicy
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
/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneSelector
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
    public V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy
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
/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy
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
/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackup
{
    /// <summary>The backup geo targets, which provide a regional failover policy for the otherwise global primary targets. Structure is document above.</summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrr
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>The configuration for Geolocation based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>The configuration for Weighted Round Robin based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyWrr>? Wrr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProvider
{
    /// <summary>The name of the zone in which this record set will reside.</summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta1RecordSetSpecForProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta1RecordSetSpecForProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \" if you don't want your string to get split on spaces.g. "first255characters\" \"morecharacters").</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneRefPolicy
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
/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicy
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
/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneSelector
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
    public V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy
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
/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy
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
/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
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
/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
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
/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackup
{
    /// <summary>The backup geo targets, which provide a regional failover policy for the otherwise global primary targets. Structure is document above.</summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrr
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>The configuration for Geolocation based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>The configuration for Weighted Round Robin based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyWrr>? Wrr { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProvider
{
    /// <summary>The name of the zone in which this record set will reside.</summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta1RecordSetSpecInitProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \" if you don't want your string to get split on spaces.g. "first255characters\" \"morecharacters").</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RecordSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RecordSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RecordSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RecordSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackup
{
    /// <summary>The backup geo targets, which provide a regional failover policy for the otherwise global primary targets. Structure is document above.</summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>The list of global primary targets to be health checked. Structure is documented below.</summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: ["tcp", "udp"]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: ["regionalL4ilb", "regionalL7ilb", "globalL7ilb"]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>The list of internal load balancers to health check. Structure is documented below.</summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrr
{
    /// <summary>The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set. Structure is documented below.</summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>The configuration for Geolocation based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy. Structure is documented below.</summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>The configuration for Weighted Round Robin based routing policy. Structure is documented below.</summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyWrr>? Wrr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProvider
{
    /// <summary>an identifier for the resource with format projects/{{project}}/managedZones/{{zone}}/rrsets/{{name}}/{{type}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the zone in which this record set will reside.</summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The configuration for steering traffic based on query. Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type. Structure is documented below.</summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \" if you don't want your string to get split on spaces.g. "first255characters\" \"morecharacters").</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusConditions
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
/// <summary>RecordSetStatus defines the observed state of RecordSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RecordSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RecordSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RecordSet is the Schema for the RecordSets API. Manages a set of DNS records within Google Cloud DNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecordSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RecordSetSpec>, IStatus<V1beta1RecordSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordSet";
    public const string KubeGroup = "dns.gcp.m.upbound.io";
    public const string KubePluralName = "recordsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1RecordSetSpec Spec { get; set; }

    /// <summary>RecordSetStatus defines the observed state of RecordSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1RecordSetStatus? Status { get; set; }
}
#nullable disable
