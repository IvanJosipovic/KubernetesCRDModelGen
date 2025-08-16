using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.cnrm.cloud.google.com;
/// <summary>CloudBuildWorkerPool is the Schema for the CloudBuild WorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudBuildWorkerPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CloudBuildWorkerPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudBuildWorkerPoolList";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildworkerpools";
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
    public IList<V1beta1CloudBuildWorkerPool> Items { get; set; }
}

/// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfigPeeredNetworkRef
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

/// <summary>Network configuration for the pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfig
{
    /// <summary>Option to configure network egress for the workers.</summary>
    [JsonPropertyName("egressOption")]
    public string? EgressOption { get; set; }

    /// <summary>Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16` would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of `/24` will be used.</summary>
    [JsonPropertyName("peeredNetworkIPRange")]
    public string? PeeredNetworkIPRange { get; set; }

    /// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network.</summary>
    [JsonPropertyName("peeredNetworkRef")]
    public V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfigPeeredNetworkRef? PeeredNetworkRef { get; set; }
}

/// <summary>Machine configuration for the workers in the pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigWorkerConfig
{
    /// <summary>Size of the disk attached to the worker, in GB. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). Specify a value of up to 2000. If `0` is specified, Cloud Build will use a standard disk size.</summary>
    [JsonPropertyName("diskSizeGb")]
    public long? DiskSizeGb { get; set; }

    /// <summary>Machine type of a worker, such as `e2-medium`. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank, Cloud Build will use a sensible default.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

/// <summary>Legacy Private Pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1Config
{
    /// <summary>Network configuration for the pool.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Machine configuration for the workers in the pool.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigWorkerConfig WorkerConfig { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpecProjectRef
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

/// <summary>CloudBuildWorkerPoolSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolSpec
{
    /// <summary>A user-specified, human-readable name for the `WorkerPool`. If provided, this value must be 1-63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Legacy Private Pool configuration.</summary>
    [JsonPropertyName("privatePoolV1Config")]
    public V1beta1CloudBuildWorkerPoolSpecPrivatePoolV1Config PrivatePoolV1Config { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1CloudBuildWorkerPoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolStatusConditions
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

/// <summary>Network configuration for the pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolStatusObservedStateNetworkConfig
{
    /// <summary>Option to configure network egress for the workers.</summary>
    [JsonPropertyName("egressOption")]
    public string? EgressOption { get; set; }

    /// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network.</summary>
    [JsonPropertyName("peeredNetwork")]
    public string? PeeredNetwork { get; set; }

    /// <summary>Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16` would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of `/24` will be used.</summary>
    [JsonPropertyName("peeredNetworkIPRange")]
    public string? PeeredNetworkIPRange { get; set; }
}

/// <summary>Machine configuration for the workers in the pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolStatusObservedStateWorkerConfig
{
    /// <summary>Size of the disk attached to the worker, in GB. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). Specify a value of up to 2000. If `0` is specified, Cloud Build will use a standard disk size.</summary>
    [JsonPropertyName("diskSizeGb")]
    public long? DiskSizeGb { get; set; }

    /// <summary>Machine type of a worker, such as `e2-medium`. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank, Cloud Build will use a sensible default.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolStatusObservedState
{
    /// <summary>The creation timestamp of the workerpool.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The Checksum computed by the server, using weak indicator.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Network configuration for the pool.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1CloudBuildWorkerPoolStatusObservedStateNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The last update timestamp of the workerpool.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Machine configuration for the workers in the pool.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta1CloudBuildWorkerPoolStatusObservedStateWorkerConfig WorkerConfig { get; set; }
}

/// <summary>CloudBuildWorkerPoolStatus defines the observed state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudBuildWorkerPoolStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudBuildWorkerPoolStatusConditions>? Conditions { get; set; }

    /// <summary>A unique Config Connector specifier for the resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1CloudBuildWorkerPoolStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudBuildWorkerPool is the Schema for the CloudBuild WorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudBuildWorkerPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudBuildWorkerPoolSpec>, IStatus<V1beta1CloudBuildWorkerPoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudBuildWorkerPool";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildworkerpools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudBuildWorkerPoolSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1CloudBuildWorkerPoolSpec? Spec { get; set; }

    /// <summary>CloudBuildWorkerPoolStatus defines the observed state of Instance</summary>
    [JsonPropertyName("status")]
    public V1beta1CloudBuildWorkerPoolStatus? Status { get; set; }
}