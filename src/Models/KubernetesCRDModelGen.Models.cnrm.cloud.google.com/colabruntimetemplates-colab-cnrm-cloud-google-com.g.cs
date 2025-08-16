using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.colab.cnrm.cloud.google.com;
/// <summary>ColabRuntimeTemplate is the Schema for the ColabRuntimeTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ColabRuntimeTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ColabRuntimeTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ColabRuntimeTemplateList";
    public const string KubeGroup = "colab.cnrm.cloud.google.com";
    public const string KubePluralName = "colabruntimetemplates";
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
    public IList<V1alpha1ColabRuntimeTemplate> Items { get; set; }
}

/// <summary>Optional. The specification of [persistent disk][https://cloud.google.com/compute/docs/disks/persistent-disks] attached to the runtime as data disk storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecDataPersistentDiskSpec
{
    /// <summary>Size in GB of the disk (default is 100GB).</summary>
    [JsonPropertyName("diskSizeGB")]
    public long? DiskSizeGB { get; set; }

    /// <summary>Type of the disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) "pd-standard" (Persistent Disk Hard Disk Drive) "pd-balanced" (Balanced Persistent Disk) "pd-extreme" (Extreme Persistent Disk)</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }
}

/// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecEncryptionSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Customer-managed encryption key spec for the notebook runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1ColabRuntimeTemplateSpecEncryptionSpecKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>EUC configuration of the NotebookRuntimeTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecEucConfig
{
    /// <summary>Input only. Whether EUC is disabled in this NotebookRuntimeTemplate. In proto3, the default value of a boolean is false. In this way, by default EUC will be enabled for NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("eucDisabled")]
    public bool? EucDisabled { get; set; }
}

/// <summary>The idle shutdown configuration of NotebookRuntimeTemplate. This config will only be set when idle shutdown is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecIdleShutdownConfig
{
    /// <summary>Whether Idle Shutdown is disabled in this NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("idleShutdownDisabled")]
    public bool? IdleShutdownDisabled { get; set; }

    /// <summary>Required. Duration is accurate to the second. In Notebook, Idle Timeout is accurate to minute so the range of idle_timeout (second) is: 10 * 60 ~ 1440 * 60.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }
}

/// <summary>Optional. Immutable. Configuration controlling how this resource pool consumes reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecMachineSpecReservationAffinity
{
    /// <summary>Optional. Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, use `compute.googleapis.com/reservation-name` as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. Specifies the reservation affinity type.</summary>
    [JsonPropertyName("reservationAffinityType")]
    public string? ReservationAffinityType { get; set; }

    /// <summary>Optional. Corresponds to the label values of a reservation resource. This must be the full resource name of the reservation.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. Immutable. The specification of a single machine for the template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecMachineSpec
{
    /// <summary>The number of accelerators to attach to the machine.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Immutable. The type of accelerator(s) that may be attached to the machine as per [accelerator_count][google.cloud.aiplatform.v1beta1.MachineSpec.accelerator_count].</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Immutable. The type of the machine.   See the [list of machine types supported for  prediction](https://cloud.google.com/vertex-ai/docs/predictions/configure-compute#machine-types)   See the [list of machine types supported for custom  training](https://cloud.google.com/vertex-ai/docs/training/configure-compute#machine-types).   For [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] this  field is optional, and the default value is `n1-standard-2`. For  [BatchPredictionJob][google.cloud.aiplatform.v1beta1.BatchPredictionJob] or  as part of [WorkerPoolSpec][google.cloud.aiplatform.v1beta1.WorkerPoolSpec]  this field is required.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Optional. Immutable. Configuration controlling how this resource pool consumes reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1alpha1ColabRuntimeTemplateSpecMachineSpecReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>Immutable. The topology of the TPUs. Corresponds to the TPU topologies available from GKE. (Example: tpu_topology: "2x2x1").</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }
}

/// <summary>The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecNetworkSpecNetworkRef
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

/// <summary>The name of the subnet that this instance is in. Format: `projects/{project_id_or_number}/regions/{region}/subnetworks/{subnetwork_id}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecNetworkSpecSubnetworkRef
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

/// <summary>Optional. Network spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecNetworkSpec
{
    /// <summary>Whether to enable public internet access. Default false.</summary>
    [JsonPropertyName("enableInternetAccess")]
    public bool? EnableInternetAccess { get; set; }

    /// <summary>The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks)</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1ColabRuntimeTemplateSpecNetworkSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The name of the subnet that this instance is in. Format: `projects/{project_id_or_number}/regions/{region}/subnetworks/{subnetwork_id}`</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1ColabRuntimeTemplateSpecNetworkSpecSubnetworkRef SubnetworkRef { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecProjectRef
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

/// <summary>The service account that the runtime workload runs as.  You can use any service account within the same project, but you  must have the service account user permission to use the instance.   If not specified, the [Compute Engine default service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecServiceAccountRef
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

/// <summary>Optional. Immutable. Runtime Shielded VM spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpecShieldedVMConfig
{
    /// <summary>Defines whether the instance has [Secure  Boot](https://cloud.google.com/compute/shielded-vm/docs/shielded-vm#secure-boot)  enabled.   Secure Boot helps ensure that the system only runs authentic software by  verifying the digital signature of all boot components, and halting the  boot process if signature verification fails.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary>ColabRuntimeTemplateSpec defines the desired state of ColabRuntimeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateSpec
{
    /// <summary>Optional. The specification of [persistent disk][https://cloud.google.com/compute/docs/disks/persistent-disks] attached to the runtime as data disk storage.</summary>
    [JsonPropertyName("dataPersistentDiskSpec")]
    public V1alpha1ColabRuntimeTemplateSpecDataPersistentDiskSpec? DataPersistentDiskSpec { get; set; }

    /// <summary>The description of the NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the NotebookRuntimeTemplate. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Customer-managed encryption key spec for the notebook runtime.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1ColabRuntimeTemplateSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>EUC configuration of the NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("eucConfig")]
    public V1alpha1ColabRuntimeTemplateSpecEucConfig? EucConfig { get; set; }

    /// <summary>The idle shutdown configuration of NotebookRuntimeTemplate. This config will only be set when idle shutdown is enabled.</summary>
    [JsonPropertyName("idleShutdownConfig")]
    public V1alpha1ColabRuntimeTemplateSpecIdleShutdownConfig? IdleShutdownConfig { get; set; }

    /// <summary>The labels with user-defined metadata to organize the  NotebookRuntimeTemplates.   Label keys and values can be no longer than 64 characters  (Unicode codepoints), can only contain lowercase letters, numeric  characters, underscores and dashes. International characters are allowed.   See https://goo.gl/xmQnxf for more information and examples of labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The name of the location where the RuntimeTemplate will be created. Required.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Immutable. The specification of a single machine for the template.</summary>
    [JsonPropertyName("machineSpec")]
    public V1alpha1ColabRuntimeTemplateSpecMachineSpec? MachineSpec { get; set; }

    /// <summary>Optional. Network spec.</summary>
    [JsonPropertyName("networkSpec")]
    public V1alpha1ColabRuntimeTemplateSpecNetworkSpec? NetworkSpec { get; set; }

    /// <summary>Optional. The Compute Engine tags to add to runtime (see [Tagging instances](https://cloud.google.com/vpc/docs/add-remove-network-tags)).</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. Immutable. The type of the notebook runtime template.</summary>
    [JsonPropertyName("notebookRuntimeType")]
    public string? NotebookRuntimeType { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ColabRuntimeTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ColabRuntimeTemplate name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The service account that the runtime workload runs as.  You can use any service account within the same project, but you  must have the service account user permission to use the instance.   If not specified, the [Compute Engine default service  account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account)  is used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1ColabRuntimeTemplateSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Immutable. Runtime Shielded VM spec.</summary>
    [JsonPropertyName("shieldedVMConfig")]
    public V1alpha1ColabRuntimeTemplateSpecShieldedVMConfig? ShieldedVMConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateStatusConditions
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

/// <summary>EUC configuration of the NotebookRuntimeTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateStatusObservedStateEucConfig
{
    /// <summary>Output only. Whether ActAs check is bypassed for service account attached to the VM. If false, we need ActAs check for the default Compute Engine Service account. When a Runtime is created, a VM is allocated using Default Compute Engine Service Account. Any user requesting to use this Runtime requires Service Account User (ActAs) permission over this SA. If true, Runtime owner is using EUC and does not require the above permission as VM no longer use default Compute Engine SA, but a P4SA.</summary>
    [JsonPropertyName("bypassActasCheck")]
    public bool? BypassActasCheck { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateStatusObservedState
{
    /// <summary>Output only. Timestamp when this NotebookRuntimeTemplate was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>EUC configuration of the NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("eucConfig")]
    public V1alpha1ColabRuntimeTemplateStatusObservedStateEucConfig? EucConfig { get; set; }

    /// <summary>Output only. Timestamp when this NotebookRuntimeTemplate was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ColabRuntimeTemplateStatus defines the config connector machine state of ColabRuntimeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeTemplateStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ColabRuntimeTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ColabRuntimeTemplate resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ColabRuntimeTemplateStatusObservedState? ObservedState { get; set; }
}

/// <summary>ColabRuntimeTemplate is the Schema for the ColabRuntimeTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ColabRuntimeTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ColabRuntimeTemplateSpec>, IStatus<V1alpha1ColabRuntimeTemplateStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ColabRuntimeTemplate";
    public const string KubeGroup = "colab.cnrm.cloud.google.com";
    public const string KubePluralName = "colabruntimetemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ColabRuntimeTemplateSpec defines the desired state of ColabRuntimeTemplate</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ColabRuntimeTemplateSpec Spec { get; set; }

    /// <summary>ColabRuntimeTemplateStatus defines the config connector machine state of ColabRuntimeTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1ColabRuntimeTemplateStatus? Status { get; set; }
}