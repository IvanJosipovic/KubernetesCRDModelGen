using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
#nullable enable
/// <summary>VMwareEnginePrivateCloud is the Schema for the VMwareEnginePrivateCloud API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEnginePrivateCloudList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VMwareEnginePrivateCloud>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEnginePrivateCloudList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineprivateclouds";
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
    public IList<V1alpha1VMwareEnginePrivateCloud> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpecManagementClusterNodeTypeConfigs
{
    /// <summary>Optional. Customized number of cores available to each node of the type. This number must always be one of `nodeType.availableCustomCoreCounts`. If zero is provided max value from `nodeType.availableCustomCoreCounts` will be used.</summary>
    [JsonPropertyName("customCoreCount")]
    public int? CustomCoreCount { get; set; }

    /// <summary>Required. The number of nodes of this type in the cluster</summary>
    [JsonPropertyName("nodeCount")]
    public int NodeCount { get; set; }

    /// <summary>Required. The type of the node. The canonical identifier of the node type (corresponds to the NodeType). For example: standard-72.</summary>
    [JsonPropertyName("nodeTypeID")]
    public string NodeTypeID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Input only. The management cluster for this private cloud.  This field is required during creation of the private cloud to provide  details for the default cluster.   The following fields can't be changed after private cloud creation:  `ManagementCluster.clusterId`, `ManagementCluster.nodeTypeId`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpecManagementCluster
{
    /// <summary>Required. The user-provided identifier of the new `Cluster`.  The identifier must meet the following requirements:   * Only contains 1-63 alphanumeric characters and hyphens  * Begins with an alphabetical character  * Ends with a non-hyphen character  * Not formatted as a UUID  * Complies with [RFC  1034](https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)</summary>
    [JsonPropertyName("clusterID")]
    public string ClusterID { get; set; }

    /// <summary>Required. A list of cluster node types in this cluster.</summary>
    [JsonPropertyName("nodeTypeConfigs")]
    public IList<V1alpha1VMwareEnginePrivateCloudSpecManagementClusterNodeTypeConfigs> NodeTypeConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The name of the VMware Engine network attached to the private cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpecNetworkConfigVmwareEngineNetworkRef
{
    /// <summary>A reference to an externally managed VMwareEngineNetwork resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/vmwareEngineNetworks/{{vmwareenginenetworkID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Network configuration of the private cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpecNetworkConfig
{
    /// <summary>Required. Management CIDR used by VMware management appliances.</summary>
    [JsonPropertyName("managementCIDR")]
    public string ManagementCIDR { get; set; }

    /// <summary>Optional. The name of the VMware Engine network attached to the private cloud.</summary>
    [JsonPropertyName("vmwareEngineNetworkRef")]
    public V1alpha1VMwareEnginePrivateCloudSpecNetworkConfigVmwareEngineNetworkRef? VmwareEngineNetworkRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VMwareEnginePrivateCloudSpec defines the desired state of VMwareEnginePrivateCloud</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudSpec
{
    /// <summary>User-provided description for this private cloud.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. Input only. The management cluster for this private cloud.  This field is required during creation of the private cloud to provide  details for the default cluster.   The following fields can't be changed after private cloud creation:  `ManagementCluster.clusterId`, `ManagementCluster.nodeTypeId`.</summary>
    [JsonPropertyName("managementCluster")]
    public V1alpha1VMwareEnginePrivateCloudSpecManagementCluster ManagementCluster { get; set; }

    /// <summary>Required. Network configuration of the private cloud.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1VMwareEnginePrivateCloudSpecNetworkConfig NetworkConfig { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VMwareEnginePrivateCloudSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VMwareEnginePrivateCloud name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Type of the private cloud. Defaults to STANDARD.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Output only. HCX appliance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusObservedStateHcx
{
    /// <summary>Fully qualified domain name of the appliance.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Internal IP address of the appliance.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Output only. The state of the appliance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version of the appliance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Network configuration of the private cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusObservedStateNetworkConfig
{
    /// <summary>Output only. DNS Server IP of the Private Cloud. All DNS queries can be forwarded to this address for name resolution of Private Cloud's management entities like vCenter, NSX-T Manager and ESXi hosts.</summary>
    [JsonPropertyName("dnsServerIP")]
    public string? DnsServerIP { get; set; }

    /// <summary>Output only. The IP address layout version of the management IP address range. Possible versions include: * `managementIpAddressLayoutVersion=1`: Indicates the legacy IP address layout used by some existing private cloudqs. This is no longer supported for new private clouds as it does not support all features. * `managementIpAddressLayoutVersion=2`: Indicates the latest IP address layout used by all newly created private clouds. This version supports all current features.</summary>
    [JsonPropertyName("managementIPAddressLayoutVersion")]
    public int? ManagementIPAddressLayoutVersion { get; set; }

    /// <summary>Output only. The canonical name of the VMware Engine network in the form: `projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network_id}`</summary>
    [JsonPropertyName("vmwareEngineNetworkCanonical")]
    public string? VmwareEngineNetworkCanonical { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. NSX appliance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusObservedStateNsx
{
    /// <summary>Fully qualified domain name of the appliance.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Internal IP address of the appliance.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Output only. The state of the appliance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version of the appliance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Vcenter appliance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusObservedStateVcenter
{
    /// <summary>Fully qualified domain name of the appliance.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Internal IP address of the appliance.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Output only. The state of the appliance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version of the appliance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Time when the resource was scheduled for deletion.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. Time when the resource will be irreversibly deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. HCX appliance.</summary>
    [JsonPropertyName("hcx")]
    public V1alpha1VMwareEnginePrivateCloudStatusObservedStateHcx? Hcx { get; set; }

    /// <summary>Network configuration of the private cloud.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1VMwareEnginePrivateCloudStatusObservedStateNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Output only. NSX appliance.</summary>
    [JsonPropertyName("nsx")]
    public V1alpha1VMwareEnginePrivateCloudStatusObservedStateNsx? Nsx { get; set; }

    /// <summary>Output only. State of the resource. New values may be added to this enum when appropriate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. Vcenter appliance.</summary>
    [JsonPropertyName("vcenter")]
    public V1alpha1VMwareEnginePrivateCloudStatusObservedStateVcenter? Vcenter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VMwareEnginePrivateCloudStatus defines the config connector machine state of VMwareEnginePrivateCloud</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEnginePrivateCloudStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VMwareEnginePrivateCloudStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEnginePrivateCloud resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VMwareEnginePrivateCloudStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VMwareEnginePrivateCloud is the Schema for the VMwareEnginePrivateCloud API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEnginePrivateCloud : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VMwareEnginePrivateCloudSpec>, IStatus<V1alpha1VMwareEnginePrivateCloudStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEnginePrivateCloud";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineprivateclouds";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEnginePrivateCloudSpec defines the desired state of VMwareEnginePrivateCloud</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VMwareEnginePrivateCloudSpec Spec { get; set; }

    /// <summary>VMwareEnginePrivateCloudStatus defines the config connector machine state of VMwareEnginePrivateCloud</summary>
    [JsonPropertyName("status")]
    public V1alpha1VMwareEnginePrivateCloudStatus? Status { get; set; }
}
#nullable disable
