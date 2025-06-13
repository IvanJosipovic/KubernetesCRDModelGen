using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tpu.cnrm.cloud.google.com;
/// <summary>The AccleratorConfig for the TPU Node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecAcceleratorConfig
{
    /// <summary>Required. Topology of TPU in chips.</summary>
    [JsonPropertyName("topology")]
    public string? Topology { get; set; }

    /// <summary>Required. Type of TPU.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecDataDisks
{
    /// <summary>The mode in which to attach this disk. If not specified, the default is READ_WRITE mode. Only applicable to data_disks.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies the full path to an existing disk. For example: "projects/my-project/zones/us-central1-c/disks/my-disk".</summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }
}

/// <summary>The network for the TPU node. It must be a preexisting Google Compute Engine network. If none is provided, "default" will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfigNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The subnetwork for the TPU node. It must be a preexisting Google Compute Engine subnetwork. If none is provided, "default" will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfigSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Network configurations for the TPU node. network_config and network_configs are mutually exclusive, you can only specify one of them. If both are specified, an error will be returned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfig
{
    /// <summary>Allows the TPU node to send and receive packets with non-matching destination or source IPs. This is required if you plan to use the TPU workers to forward routes.</summary>
    [JsonPropertyName("canIPForward")]
    public bool? CanIPForward { get; set; }

    /// <summary>Indicates that external IP addresses would be associated with the TPU workers. If set to false, the specified subnetwork or network should have Private Google Access enabled.</summary>
    [JsonPropertyName("enableExternalIPs")]
    public bool? EnableExternalIPs { get; set; }

    /// <summary>The network for the TPU node. It must be a preexisting Google Compute Engine network. If none is provided, "default" will be used.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1TPUVirtualMachineSpecNetworkConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. Specifies networking queue count for TPU VM instance's network interface.</summary>
    [JsonPropertyName("queueCount")]
    public int? QueueCount { get; set; }

    /// <summary>The subnetwork for the TPU node. It must be a preexisting Google Compute Engine subnetwork. If none is provided, "default" will be used.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1TPUVirtualMachineSpecNetworkConfigSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>The network for the TPU node. It must be a preexisting Google Compute Engine network. If none is provided, "default" will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfigsNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The subnetwork for the TPU node. It must be a preexisting Google Compute Engine subnetwork. If none is provided, "default" will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfigsSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecNetworkConfigs
{
    /// <summary>Allows the TPU node to send and receive packets with non-matching destination or source IPs. This is required if you plan to use the TPU workers to forward routes.</summary>
    [JsonPropertyName("canIPForward")]
    public bool? CanIPForward { get; set; }

    /// <summary>Indicates that external IP addresses would be associated with the TPU workers. If set to false, the specified subnetwork or network should have Private Google Access enabled.</summary>
    [JsonPropertyName("enableExternalIPs")]
    public bool? EnableExternalIPs { get; set; }

    /// <summary>The network for the TPU node. It must be a preexisting Google Compute Engine network. If none is provided, "default" will be used.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1TPUVirtualMachineSpecNetworkConfigsNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. Specifies networking queue count for TPU VM instance's network interface.</summary>
    [JsonPropertyName("queueCount")]
    public int? QueueCount { get; set; }

    /// <summary>The subnetwork for the TPU node. It must be a preexisting Google Compute Engine subnetwork. If none is provided, "default" will be used.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1TPUVirtualMachineSpecNetworkConfigsSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>The project that the TPU virtual machine belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecProjectRef
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

/// <summary>The scheduling options for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecSchedulingConfig
{
    /// <summary>Defines whether the node is preemptible.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Whether the node is created under a reservation.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>Optional. Defines whether the node is Spot VM.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>The service account to be used. If empty, the default Compute service account will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecServiceAccountServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Google Cloud Platform Service Account to be used by the TPU node VMs. If None is specified, the default compute service account will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecServiceAccount
{
    /// <summary>The list of scopes to be made available for this service account. If empty, access to all Cloud APIs will be allowed.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }

    /// <summary>The service account to be used. If empty, the default Compute service account will be used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1TPUVirtualMachineSpecServiceAccountServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary>Shielded Instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpecShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary>TPUVirtualMachineSpec defines the desired state of TPUVirtualMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineSpec
{
    /// <summary>The AccleratorConfig for the TPU Node.</summary>
    [JsonPropertyName("acceleratorConfig")]
    public V1alpha1TPUVirtualMachineSpecAcceleratorConfig? AcceleratorConfig { get; set; }

    /// <summary>Optional. The type of hardware accelerators associated with this node.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>The CIDR block that the TPU node will use when selecting an IP address. This CIDR block must be a /29 block; the Compute Engine networks API forbids a smaller block, and using a larger block would be wasteful (a node can only consume one IP address). Errors will occur if the CIDR block has already been used for a currently existing TPU node, the CIDR block conflicts with any subnetworks in the user's provided network, or the provided network is peered with another network that is using that CIDR block.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>The additional data disks for the Node.</summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1alpha1TPUVirtualMachineSpecDataDisks>? DataDisks { get; set; }

    /// <summary>The user-supplied description of the TPU. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The location where the TPU virtual machine should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Custom metadata to apply to the TPU Node. Can set startup-script and shutdown-script</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Network configurations for the TPU node. network_config and network_configs are mutually exclusive, you can only specify one of them. If both are specified, an error will be returned.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1TPUVirtualMachineSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Optional. Repeated network configurations for the TPU node. This field is used to specify multiple networks configs for the TPU node. network_config and network_configs are mutually exclusive, you can only specify one of them. If both are specified, an error will be returned.</summary>
    [JsonPropertyName("networkConfigs")]
    public IList<V1alpha1TPUVirtualMachineSpecNetworkConfigs>? NetworkConfigs { get; set; }

    /// <summary>The project that the TPU virtual machine belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1TPUVirtualMachineSpecProjectRef ProjectRef { get; set; }

    /// <summary>The TPUVirtualMachine name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The runtime version running in the Node.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The scheduling options for this node.</summary>
    [JsonPropertyName("schedulingConfig")]
    public V1alpha1TPUVirtualMachineSpecSchedulingConfig? SchedulingConfig { get; set; }

    /// <summary>The Google Cloud Platform Service Account to be used by the TPU node VMs. If None is specified, the default compute service account will be used.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1alpha1TPUVirtualMachineSpecServiceAccount? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1alpha1TPUVirtualMachineSpecShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to apply to the TPU Node. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatusConditions
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

/// <summary>The access config for the TPU worker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatusObservedStateNetworkEndpointsAccessConfig
{
    /// <summary>Output only. An external IP address associated with the TPU worker.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatusObservedStateNetworkEndpoints
{
    /// <summary>The access config for the TPU worker.</summary>
    [JsonPropertyName("accessConfig")]
    public V1alpha1TPUVirtualMachineStatusObservedStateNetworkEndpointsAccessConfig? AccessConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatusObservedStateSymptoms
{
    /// <summary>Timestamp when the Symptom is created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Detailed information of the current Symptom.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Type of the Symptom.</summary>
    [JsonPropertyName("symptomType")]
    public string? SymptomType { get; set; }

    /// <summary>A string used to uniquely distinguish a worker within a TPU node.</summary>
    [JsonPropertyName("workerID")]
    public string? WorkerID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatusObservedState
{
    /// <summary>The health status of the TPU node.</summary>
    [JsonPropertyName("health")]
    public string? Health { get; set; }

    /// <summary>Output only. If this field is populated, it contains a description of why the TPU Node is unhealthy.</summary>
    [JsonPropertyName("healthDescription")]
    public string? HealthDescription { get; set; }

    /// <summary>Output only. Whether the Node belongs to a Multislice group.</summary>
    [JsonPropertyName("multisliceNode")]
    public bool? MultisliceNode { get; set; }

    /// <summary>Output only. The network endpoints where TPU workers can be accessed and sent work. It is recommended that runtime clients of the node reach out to the 0th entry in this map first.</summary>
    [JsonPropertyName("networkEndpoints")]
    public IList<V1alpha1TPUVirtualMachineStatusObservedStateNetworkEndpoints>? NetworkEndpoints { get; set; }

    /// <summary>Output only. The qualified name of the QueuedResource that requested this Node.</summary>
    [JsonPropertyName("queuedResource")]
    public string? QueuedResource { get; set; }

    /// <summary>Output only. The current state for the TPU Node.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The Symptoms that have occurred to the TPU Node.</summary>
    [JsonPropertyName("symptoms")]
    public IList<V1alpha1TPUVirtualMachineStatusObservedStateSymptoms>? Symptoms { get; set; }
}

/// <summary>TPUVirtualMachineStatus defines the config connector machine state of TPUVirtualMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUVirtualMachineStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TPUVirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the TPUVirtualMachine resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1TPUVirtualMachineStatusObservedState? ObservedState { get; set; }
}

/// <summary>TPUVirtualMachine is the Schema for the TPUVirtualMachine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TPUVirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TPUVirtualMachineSpec>, IStatus<V1alpha1TPUVirtualMachineStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TPUVirtualMachine";
    public const string KubeGroup = "tpu.cnrm.cloud.google.com";
    public const string KubePluralName = "tpuvirtualmachines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TPUVirtualMachineSpec defines the desired state of TPUVirtualMachine</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TPUVirtualMachineSpec Spec { get; set; }

    /// <summary>TPUVirtualMachineStatus defines the config connector machine state of TPUVirtualMachine</summary>
    [JsonPropertyName("status")]
    public V1alpha1TPUVirtualMachineStatus? Status { get; set; }
}

/// <summary>TPUVirtualMachine is the Schema for the TPUVirtualMachine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TPUVirtualMachineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TPUVirtualMachine>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TPUVirtualMachineList";
    public const string KubeGroup = "tpu.cnrm.cloud.google.com";
    public const string KubePluralName = "tpuvirtualmachines";
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
    public IList<V1alpha1TPUVirtualMachine> Items { get; set; }
}