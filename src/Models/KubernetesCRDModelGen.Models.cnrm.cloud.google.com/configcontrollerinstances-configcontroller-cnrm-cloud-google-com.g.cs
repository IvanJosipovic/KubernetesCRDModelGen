using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.configcontroller.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigControllerInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConfigControllerInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigControllerInstanceList";
    public const string KubeGroup = "configcontroller.cnrm.cloud.google.com";
    public const string KubePluralName = "configcontrollerinstances";
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
    public IList<V1beta1ConfigControllerInstance> Items { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecManagementConfigFullManagementConfigNetworkRef
{
    /// <summary>Existing VPC Network to put the GKE cluster and nodes in.  Allowed value: The Google Cloud resource name of a `ComputeNetwork` resource (format: `projects/{{project}}/global/networks/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Configuration of the full (Autopilot) cluster management</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecManagementConfigFullManagementConfig
{
    /// <summary>Immutable. The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterCidrBlock")]
    public string? ClusterCidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterNamedRange")]
    public string? ClusterNamedRange { get; set; }

    /// <summary>Immutable. Master Authorized Network. Allows access to the k8s master from this block.</summary>
    [JsonPropertyName("manBlock")]
    public string? ManBlock { get; set; }

    /// <summary>Immutable. The /28 network that the masters will use.</summary>
    [JsonPropertyName("masterIPv4CidrBlock")]
    public string? MasterIPv4CidrBlock { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ConfigControllerInstanceSpecManagementConfigFullManagementConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The IP address range for the cluster service IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesCidrBlock")]
    public string? ServicesCidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesNamedRange")]
    public string? ServicesNamedRange { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecManagementConfigStandardManagementConfigNetworkRef
{
    /// <summary>Existing VPC Network to put the GKE cluster and nodes in.  Allowed value: The Google Cloud resource name of a `ComputeNetwork` resource (format: `projects/{{project}}/global/networks/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Configuration of the standard (GKE) cluster management</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecManagementConfigStandardManagementConfig
{
    /// <summary>Immutable. The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterCidrBlock")]
    public string? ClusterCidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterNamedRange")]
    public string? ClusterNamedRange { get; set; }

    /// <summary>Immutable. Master Authorized Network. Allows access to the k8s master from this block.</summary>
    [JsonPropertyName("manBlock")]
    public string? ManBlock { get; set; }

    /// <summary>Immutable. The /28 network that the masters will use.</summary>
    [JsonPropertyName("masterIPv4CidrBlock")]
    public string MasterIPv4CidrBlock { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ConfigControllerInstanceSpecManagementConfigStandardManagementConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The IP address range for the cluster service IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesCidrBlock")]
    public string? ServicesCidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesNamedRange")]
    public string? ServicesNamedRange { get; set; }
}

/// <summary>Immutable. Configuration of the cluster management</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecManagementConfig
{
    /// <summary>Immutable. Configuration of the full (Autopilot) cluster management</summary>
    [JsonPropertyName("fullManagementConfig")]
    public V1beta1ConfigControllerInstanceSpecManagementConfigFullManagementConfig? FullManagementConfig { get; set; }

    /// <summary>Immutable. Configuration of the standard (GKE) cluster management</summary>
    [JsonPropertyName("standardManagementConfig")]
    public V1beta1ConfigControllerInstanceSpecManagementConfigStandardManagementConfig? StandardManagementConfig { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
public partial class V1beta1ConfigControllerInstanceSpec
{
    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Configuration of the cluster management</summary>
    [JsonPropertyName("managementConfig")]
    public V1beta1ConfigControllerInstanceSpecManagementConfig ManagementConfig { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ConfigControllerInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Only allow access to the master's private endpoint IP.</summary>
    [JsonPropertyName("usePrivateEndpoint")]
    public bool? UsePrivateEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigControllerInstanceStatusConditions
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
public partial class V1beta1ConfigControllerInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigControllerInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. KrmApiHost GCP self link used for identifying the underlying endpoint (GKE cluster currently).</summary>
    [JsonPropertyName("gkeResourceLink")]
    public string? GkeResourceLink { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The current state of the internal state machine for the KrmApiHost. Possible values: STATE_UNSPECIFIED, CREATING, RUNNING, DELETING, SUSPENDED, READ_ONLY</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigControllerInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigControllerInstanceSpec>, IStatus<V1beta1ConfigControllerInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigControllerInstance";
    public const string KubeGroup = "configcontroller.cnrm.cloud.google.com";
    public const string KubePluralName = "configcontrollerinstances";
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
    public V1beta1ConfigControllerInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigControllerInstanceStatus? Status { get; set; }
}