using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>InstanceTemplate is the Schema for the InstanceTemplates API. Manages a VM instance template resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstanceTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceTemplateList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "instancetemplates";
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
    public IList<V1beta1InstanceTemplate> Items { get; set; }
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskDiskEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesSelector
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
    public V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicy? Policy { get; set; }
}

/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceSelector
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
    public V1beta1InstanceTemplateSpecForProviderDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether or not the disk should be auto-deleted. This defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/  tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1InstanceTemplateSpecForProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Name of the disk. When not provided, this defaults to the name of the instance.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be exactly 375GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The GCE disk type. Such as "pd-ssd", "local-ssd", "pd-balanced" or "pd-standard", "hyperdisk-balanced", "hyperdisk-throughput" or "hyperdisk-extreme".</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>A set of ket/value label pairs to assign to disk created from this template</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. Values must be between 10,000 and 120,000. For more details, see the Extreme persistent disk documentation.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>References to ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesRefs")]
    public IList<V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesRefs>? ResourcePoliciesRefs { get; set; }

    /// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesSelector")]
    public V1beta1InstanceTemplateSpecForProviderDiskResourcePoliciesSelector? ResourcePoliciesSelector { get; set; }

    /// <summary>The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceSelector? SourceSelector { get; set; }

    /// <summary>The source snapshot to create this disk. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The type of GCE disk, can be either "SCRATCH" or "PERSISTENT".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceAccessConfig
{
    /// <summary>The IP address that will be 1:1 mapped to the instance's network ip. If not given, one will be generated.</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. At the time of writing only a netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API error.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelector
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
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceTemplateSpecForProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceTemplateSpecForProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceTemplateSpecForProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>the name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceTemplateSpecForProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderScheduling
{
    /// <summary>Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta1InstanceTemplateSpecForProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceTemplateSpecForProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceTemplateSpecForProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Defines the maintenance behavior for this instance.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceTemplateSpecForProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Allows instance to be preempted. This defaults to false. Read more on this here.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderServiceAccountEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecForProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderServiceAccountEmailSelector
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
    public V1beta1InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderServiceAccount
{
    /// <summary>The service account e-mail address. If not given, the default Google Compute Engine service account is used.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta1InstanceTemplateSpecForProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta1InstanceTemplateSpecForProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecForProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceTemplateSpecForProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceTemplateSpecForProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disks to attach to instances created from this template. This can be specified multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1InstanceTemplateSpecForProviderDisk>? Disk { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceTemplateSpecForProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>A brief description to use for instances created from this template.</summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>A set of key/value label pairs to assign to instances created from this template.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within instances created from this template.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Networks to attach to instances created from this template. This can be specified multiple times for multiple networks. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceTemplateSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceTemplateSpecForProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceTemplateSpecForProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceTemplateSpecForProviderScheduling? Scheduling { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceTemplateSpecForProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceTemplateSpecForProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskDiskEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesSelector
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
    public V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicy? Policy { get; set; }
}

/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceSelector
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
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>A 256-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption), encoded in RFC 4648 base64 to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key] (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether or not the disk should be auto-deleted. This defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/  tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1InstanceTemplateSpecInitProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Name of the disk. When not provided, this defaults to the name of the instance.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be exactly 375GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The GCE disk type. Such as "pd-ssd", "local-ssd", "pd-balanced" or "pd-standard", "hyperdisk-balanced", "hyperdisk-throughput" or "hyperdisk-extreme".</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>A set of ket/value label pairs to assign to disk created from this template</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. Values must be between 10,000 and 120,000. For more details, see the Extreme persistent disk documentation.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>References to ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesRefs")]
    public IList<V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesRefs>? ResourcePoliciesRefs { get; set; }

    /// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesSelector")]
    public V1beta1InstanceTemplateSpecInitProviderDiskResourcePoliciesSelector? ResourcePoliciesSelector { get; set; }

    /// <summary>The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceSelector? SourceSelector { get; set; }

    /// <summary>The source snapshot to create this disk. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The type of GCE disk, can be either "SCRATCH" or "PERSISTENT".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceAccessConfig
{
    /// <summary>The IP address that will be 1:1 mapped to the instance's network ip. If not given, one will be generated.</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. At the time of writing only a netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API error.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelector
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
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>the name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceTemplateSpecInitProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderScheduling
{
    /// <summary>Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta1InstanceTemplateSpecInitProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceTemplateSpecInitProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceTemplateSpecInitProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Defines the maintenance behavior for this instance.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceTemplateSpecInitProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Allows instance to be preempted. This defaults to false. Read more on this here.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailSelector
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
    public V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderServiceAccount
{
    /// <summary>The service account e-mail address. If not given, the default Google Compute Engine service account is used.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta1InstanceTemplateSpecInitProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecInitProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceTemplateSpecInitProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceTemplateSpecInitProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disks to attach to instances created from this template. This can be specified multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1InstanceTemplateSpecInitProviderDisk>? Disk { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceTemplateSpecInitProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>A brief description to use for instances created from this template.</summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>A set of key/value label pairs to assign to instances created from this template.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within instances created from this template.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Networks to attach to instances created from this template. This can be specified multiple times for multiple networks. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceTemplateSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceTemplateSpecInitProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceTemplateSpecInitProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceTemplateSpecInitProviderScheduling? Scheduling { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceTemplateSpecInitProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceTemplateSpecInitProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>InstanceTemplateSpec defines the desired state of InstanceTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to "AMD Milan" or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to "AMD Milan". Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderDiskDiskEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderDiskSourceImageEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>The self link of the encryption key that is stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key may be set.</summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>The service account being used for the encryption request for the given KMS key. If absent, the Compute Engine default service account is used.</summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Whether or not the disk should be auto-deleted. This defaults to true.</summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>A unique device name that is reflected into the /dev/  tree of a Linux operating system running within the instance. If not specified, the server chooses a default device name to apply to this disk.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta1InstanceTemplateStatusAtProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Name of the disk. When not provided, this defaults to the name of the instance.</summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>The size of the image in gigabytes. If not specified, it will inherit the size of its base image. For SCRATCH disks, the size must be exactly 375GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The GCE disk type. Such as "pd-ssd", "local-ssd", "pd-balanced" or "pd-standard", "hyperdisk-balanced", "hyperdisk-throughput" or "hyperdisk-extreme".</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent disk in any other format than SCSI. Local SSDs can use either NVME or SCSI.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>A set of ket/value label pairs to assign to disk created from this template</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If you are attaching or creating a boot disk, this must read-write mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second that the disk can handle. Values must be between 10,000 and 120,000. For more details, see the Extreme persistent disk documentation.</summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The name (not self_link) of the disk (such as those managed by google_compute_disk) to attach. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The image from which to initialize this disk. This can be one of: the image's self_link, projects/{project}/global/images/{image}, projects/{project}/global/images/family/{family}, global/images/{image}, global/images/family/{family}, family/{family}, {project}/{family}, {project}/{image}, {family}, or {image}. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.</summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta1InstanceTemplateStatusAtProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>The source snapshot to create this disk. ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>The customer-supplied encryption key of the source snapshot. Structure documented below.</summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta1InstanceTemplateStatusAtProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>The type of GCE disk, can be either "SCRATCH" or "PERSISTENT".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceAccessConfig
{
    /// <summary>The IP address that will be 1:1 mapped to the instance's network ip. If not given, one will be generated.</summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceAliasIpRange
{
    /// <summary>The IP CIDR range represented by this alias IP range. This IP CIDR range must belong to the specified subnetwork and cannot contain IP addresses reserved by system or used by other network interfaces. At the time of writing only a netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API error.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The subnetwork secondary range name specifying the secondary range from which to allocate the IP CIDR range for this alias IP range. If left unspecified, the primary range of the subnetwork will be used.</summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service-level to be provided for IPv6 traffic when the subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.</summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderNetworkInterface
{
    /// <summary>Access configurations, i.e. IPs via which this instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance on that network). This block can be specified once per network_interface. Structure documented below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>An array of alias IP ranges for this network interface. Can only be specified for network interfaces on subnet-mode networks. Structure documented below.</summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no external IPv6 Internet access. Structure documented below.</summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta1InstanceTemplateStatusAtProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name or self_link of the network to attach this interface to. Use network attribute for Legacy or Auto subnetted networks and subnetwork for custom subnetted networks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The private IP address to assign to the instance. If empty, the address will be automatically assigned.</summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that's specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>the name of the subnetwork to attach this interface to. The subnetwork must exist in the same region this instance will be created in. Either network or subnetwork must be provided.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The ID of the project in which the subnetwork belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }
}

/// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderReservationAffinity
{
    /// <summary>Specifies the label selector for the reservation to use.. Structure is documented below.</summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1InstanceTemplateStatusAtProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderSchedulingMaxRunDuration
{
    /// <summary>Span of time that's a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. The value must be between 1 and 3600, which is 3,600 seconds (one hour).`</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The operator. Can be IN for node-affinities or NOT_IN for anti-affinities.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderScheduling
{
    /// <summary>Specifies whether the instance should be automatically restarted if it is terminated by Compute Engine (not terminated by a user). This defaults to true.</summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta1InstanceTemplateStatusAtProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta1InstanceTemplateStatusAtProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>Specifies node affinities or anti-affinities to determine which sole-tenant nodes your instances and managed instance groups will use as host systems. Read more on sole-tenant node creation here. Structure documented below.</summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta1InstanceTemplateStatusAtProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>Defines the maintenance behavior for this instance.</summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta1InstanceTemplateStatusAtProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>Allows instance to be preempted. This defaults to false. Read more on this here.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT, preemptible should be true and automatic_restart should be false. For more info about SPOT, read here</summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderServiceAccount
{
    /// <summary>The service account e-mail address. If not given, the default Google Compute Engine service account is used.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>A list of service scopes. Both OAuth2 URLs and gcloud short names are supported. To allow full access to all Cloud APIs, use the cloud-platform scope. See a complete list of scopes here.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusAtProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1InstanceTemplateStatusAtProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.</summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1InstanceTemplateStatusAtProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disks to attach to instances created from this template. This can be specified multiple times for multiple disks. Structure is documented below.</summary>
    [JsonPropertyName("disk")]
    public IList<V1beta1InstanceTemplateStatusAtProviderDisk>? Disk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1InstanceTemplateStatusAtProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/instanceTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A brief description to use for instances created from this template.</summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer's encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>A set of key/value label pairs to assign to instances created from this template.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Metadata key/value pairs to make available from within instances created from this template.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The unique fingerprint of the metadata.</summary>
    [JsonPropertyName("metadataFingerprint")]
    public string? MetadataFingerprint { get; set; }

    /// <summary>An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.</summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake. See the complete list here.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Networks to attach to instances created from this template. This can be specified multiple times for multiple networks. Structure is documented below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceTemplateStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>os-features, and network_interface.0.nic-type must be GVNIC in order for this setting to take effect.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1InstanceTemplateStatusAtProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>numeric identifier of the resource.</summary>
    [JsonPropertyName("numericId")]
    public string? NumericId { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the reservations that this instance can consume from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1InstanceTemplateStatusAtProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>The scheduling strategy to use. More details about this configuration option are detailed below.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta1InstanceTemplateStatusAtProviderScheduling? Scheduling { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A special URI of the created resource that uniquely identifies this instance template with the following format: projects/{{project}}/global/instanceTemplates/{{name}}?uniqueId={{uniqueId}} Referencing an instance template via this attribute prevents Time of Check to Time of Use attacks when the instance template resides in a shared/untrusted environment.</summary>
    [JsonPropertyName("selfLinkUnique")]
    public string? SelfLinkUnique { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta1InstanceTemplateStatusAtProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below. Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1InstanceTemplateStatusAtProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The unique fingerprint of the tags.</summary>
    [JsonPropertyName("tagsFingerprint")]
    public string? TagsFingerprint { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatusConditions
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

/// <summary>InstanceTemplateStatus defines the observed state of InstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceTemplate is the Schema for the InstanceTemplates API. Manages a VM instance template resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceTemplateSpec>, IStatus<V1beta1InstanceTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceTemplate";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "instancetemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceTemplateSpec defines the desired state of InstanceTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceTemplateSpec Spec { get; set; }

    /// <summary>InstanceTemplateStatus defines the observed state of InstanceTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceTemplateStatus? Status { get; set; }
}