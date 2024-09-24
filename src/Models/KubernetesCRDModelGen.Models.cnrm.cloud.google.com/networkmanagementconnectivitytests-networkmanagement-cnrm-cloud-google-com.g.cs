using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkmanagement.cnrm.cloud.google.com;
/// <summary>Required. Destination specification of the Connectivity Test.  You can use a combination of destination IP address, Compute Engine VM instance, or VPC network to uniquely identify the destination location.  Even if the destination IP address is not unique, the source IP location is unique. Usually, the analysis can infer the destination endpoint from route information.  If the destination you specify is a VM instance and the instance has multiple network interfaces, then you must also specify either a destination IP address or VPC network to identify the destination interface.  A reachability analysis proceeds even if the destination location is ambiguous. However, the result can include endpoints that you don't intend to test.</summary>
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestination
{
    /// <summary>A Compute Engine instance URI.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>The IP address of the endpoint, which can be an external or internal IP. An IPv6 address is only allowed when the test's destination is a global load balancer VIP.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A Compute Engine network URI.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a GCP project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1NetworkManagementConnectivityTestSpecProjectRef
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

/// <summary>Required. Source specification of the Connectivity Test.  You can use a combination of source IP address, virtual machine (VM) instance, or Compute Engine network to uniquely identify the source location.  Examples: If the source IP address is an internal IP address within a Google Cloud Virtual Private Cloud (VPC) network, then you must also specify the VPC network. Otherwise, specify the VM instance, which already contains its internal IP address and VPC network information.  If the source of the test is within an on-premises network, then you must provide the destination VPC network.  If the source endpoint is a Compute Engine VM instance with multiple network interfaces, the instance itself is not sufficient to identify the endpoint. So, you must also specify the source IP address or VPC network.  A reachability analysis proceeds even if the source location is ambiguous. However, the test result may include endpoints that you don't intend to test.</summary>
public partial class V1alpha1NetworkManagementConnectivityTestSpecSource
{
    /// <summary>A Compute Engine instance URI.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>The IP address of the endpoint, which can be an external or internal IP. An IPv6 address is only allowed when the test's destination is a global load balancer VIP.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A Compute Engine network URI.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Type of the network where the endpoint is located. Possible values: ["GCP_NETWORK", "NON_GCP_NETWORK"].</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID:  1. Only the IP address is specified, and the IP address is    within a GCP project. 2. When you are using Shared VPC and the IP address    that you provide is from the service project. In this case,    the network that the IP address resides in is defined in the    host project.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary></summary>
public partial class V1alpha1NetworkManagementConnectivityTestSpec
{
    /// <summary>The user-supplied description of the Connectivity Test. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Destination specification of the Connectivity Test.  You can use a combination of destination IP address, Compute Engine VM instance, or VPC network to uniquely identify the destination location.  Even if the destination IP address is not unique, the source IP location is unique. Usually, the analysis can infer the destination endpoint from route information.  If the destination you specify is a VM instance and the instance has multiple network interfaces, then you must also specify either a destination IP address or VPC network to identify the destination interface.  A reachability analysis proceeds even if the destination location is ambiguous. However, the result can include endpoints that you don't intend to test.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestination Destination { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecProjectRef ProjectRef { get; set; }

    /// <summary>IP Protocol of the test. When not provided, "TCP" is assumed.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Other projects that may be relevant for reachability analysis. This is applicable to scenarios where a test can cross project boundaries.</summary>
    [JsonPropertyName("relatedProjects")]
    public IList<string>? RelatedProjects { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Source specification of the Connectivity Test.  You can use a combination of source IP address, virtual machine (VM) instance, or Compute Engine network to uniquely identify the source location.  Examples: If the source IP address is an internal IP address within a Google Cloud Virtual Private Cloud (VPC) network, then you must also specify the VPC network. Otherwise, specify the VM instance, which already contains its internal IP address and VPC network information.  If the source of the test is within an on-premises network, then you must provide the destination VPC network.  If the source endpoint is a Compute Engine VM instance with multiple network interfaces, the instance itself is not sufficient to identify the endpoint. So, you must also specify the source IP address or VPC network.  A reachability analysis proceeds even if the source location is ambiguous. However, the test result may include endpoints that you don't intend to test.</summary>
    [JsonPropertyName("source")]
    public V1alpha1NetworkManagementConnectivityTestSpecSource Source { get; set; }
}

/// <summary></summary>
public partial class V1alpha1NetworkManagementConnectivityTestStatusConditions
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
public partial class V1alpha1NetworkManagementConnectivityTestStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1NetworkManagementConnectivityTest : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkManagementConnectivityTestSpec>, IStatus<V1alpha1NetworkManagementConnectivityTestStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkManagementConnectivityTest";
    public const string KubeGroup = "networkmanagement.cnrm.cloud.google.com";
    public const string KubePluralName = "networkmanagementconnectivitytests";
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
    public V1alpha1NetworkManagementConnectivityTestSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkManagementConnectivityTestStatus? Status { get; set; }
}