using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workstations.cnrm.cloud.google.com;
#nullable enable
/// <summary>WorkstationConfig is the Schema for the WorkstationConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkstationConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WorkstationConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkstationConfigList";
    public const string KubeGroup = "workstations.cnrm.cloud.google.com";
    public const string KubePluralName = "workstationconfigs";
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
    public IList<V1beta1WorkstationConfig> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecAnnotations
{
    /// <summary>Key for the annotation.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the annotation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecContainerEnv
{
    /// <summary>Name is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Container that runs upon startup for each workstation using this workstation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecContainer
{
    /// <summary>Optional. Arguments passed to the entrypoint.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. If set, overrides the default ENTRYPOINT specified by the image.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Optional. Environment variables passed to the container's entrypoint.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1WorkstationConfigSpecContainerEnv>? Env { get; set; }

    /// <summary>Optional. A Docker container image that defines a custom environment.   Cloud Workstations provides a number of  [preconfigured  images](https://cloud.google.com/workstations/docs/preconfigured-base-images),  but you can create your own  [custom container  images](https://cloud.google.com/workstations/docs/custom-container-images).  If using a private image, the `host.gceInstance.serviceAccount` field  must be specified in the workstation configuration and must have  permission to pull the specified image. Otherwise, the image must be  publicly accessible.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Optional. If set, overrides the USER specified in the image with the given uid.</summary>
    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    /// <summary>Optional. If set, overrides the default DIR specified by the image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. A reference to the Google Cloud KMS encryption key. For example, `"projects/PROJECT_ID/locations/REGION/keyRings/KEY_RING/cryptoKeys/KEY_NAME"`. The key must be in the same region as the workstation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecEncryptionKeyKmsCryptoKeyRef
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
#nullable disable

#nullable enable
/// <summary>Immutable. A reference to a service account to use with the specified KMS key. We recommend that you use a separate service account and follow KMS best practices. For more information, see [Separation of duties](https://cloud.google.com/kms/docs/separation-of-duties) and `gcloud kms keys add-iam-policy-binding` [`--member`](https://cloud.google.com/sdk/gcloud/reference/kms/keys/add-iam-policy-binding#--member).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecEncryptionKeyServiceAccountRef
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
#nullable disable

#nullable enable
/// <summary>Immutable. Encrypts resources of this workstation configuration using a  customer-managed encryption key (CMEK).   If specified, the boot disk of the Compute Engine instance and the  persistent disk are encrypted using this encryption key. If  this field is not set, the disks are encrypted using a generated  key. Customer-managed encryption keys do not protect disk metadata.   If the customer-managed encryption key is rotated, when the workstation  instance is stopped, the system attempts to recreate the  persistent disk with the new version of the key. Be sure to keep  older versions of the key until the persistent disk is recreated.  Otherwise, data on the persistent disk might be lost.   If the encryption key is revoked, the workstation session automatically  stops within 7 hours.   Immutable after the workstation configuration is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecEncryptionKey
{
    /// <summary>Immutable. A reference to the Google Cloud KMS encryption key. For example, `"projects/PROJECT_ID/locations/REGION/keyRings/KEY_RING/cryptoKeys/KEY_NAME"`. The key must be in the same region as the workstation configuration.</summary>
    [JsonPropertyName("kmsCryptoKeyRef")]
    public V1beta1WorkstationConfigSpecEncryptionKeyKmsCryptoKeyRef? KmsCryptoKeyRef { get; set; }

    /// <summary>Immutable. A reference to a service account to use with the specified KMS key. We recommend that you use a separate service account and follow KMS best practices. For more information, see [Separation of duties](https://cloud.google.com/kms/docs/separation-of-duties) and `gcloud kms keys add-iam-policy-binding` [`--member`](https://cloud.google.com/sdk/gcloud/reference/kms/keys/add-iam-policy-binding#--member).</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1WorkstationConfigSpecEncryptionKeyServiceAccountRef? ServiceAccountRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. A set of Compute Engine Confidential VM instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecHostGceInstanceConfidentialInstanceConfig
{
    /// <summary>Optional. Whether the instance has confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. A reference to the service account for Cloud  Workstations VMs created with this configuration. When specified, be  sure that the service account has `logginglogEntries.create` permission  on the project so it can write logs out to Cloud Logging. If using a  custom container image, the service account must have permissions to  pull the specified image.   If you as the administrator want to be able to `ssh` into the  underlying VM, you need to set this value to a service account  for which you have the `iam.serviceAccounts.actAs` permission.  Conversely, if you don't want anyone to be able to `ssh` into the  underlying VM, use a service account where no one has that  permission.   If not set, VMs run with a service account provided by the  Cloud Workstations service, and the image must be publicly  accessible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecHostGceInstanceServiceAccountRef
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
#nullable disable

#nullable enable
/// <summary>Optional. A set of Compute Engine Shielded instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecHostGceInstanceShieldedInstanceConfig
{
    /// <summary>Optional. Whether the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Optional. Whether the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Optional. Whether the instance has the vTPM enabled.</summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies a Compute Engine instance as the host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecHostGceInstance
{
    /// <summary>Optional. The size of the boot disk for the VM in gigabytes (GB). The minimum boot disk size is `30` GB. Defaults to `50` GB.</summary>
    [JsonPropertyName("bootDiskSizeGB")]
    public int? BootDiskSizeGB { get; set; }

    /// <summary>Optional. A set of Compute Engine Confidential VM instance options.</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta1WorkstationConfigSpecHostGceInstanceConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Optional. When set to true, disables public IP addresses for VMs. If you disable public IP addresses, you must set up Private Google Access or Cloud NAT on your network. If you use Private Google Access and you use `private.googleapis.com` or `restricted.googleapis.com` for Container Registry and Artifact Registry, make sure that you set up DNS records for domains `*.gcr.io` and `*.pkg.dev`. Defaults to false (VMs have public IP addresses).</summary>
    [JsonPropertyName("disablePublicIPAddresses")]
    public bool? DisablePublicIPAddresses { get; set; }

    /// <summary>Optional. Whether to enable nested virtualization on Cloud Workstations  VMs created under this workstation configuration.   Nested virtualization lets you run virtual machine (VM) instances  inside your workstation. Before enabling nested virtualization,  consider the following important considerations. Cloud Workstations  instances are subject to the [same restrictions as Compute Engine  instances](https://cloud.google.com/compute/docs/instances/nested-virtualization/overview#restrictions):   * **Organization policy**: projects, folders, or  organizations may be restricted from creating nested VMs if the  **Disable VM nested virtualization** constraint is enforced in  the organization policy. For more information, see the  Compute Engine section,  [Checking whether nested virtualization is  allowed](https://cloud.google.com/compute/docs/instances/nested-virtualization/managing-constraint#checking_whether_nested_virtualization_is_allowed).  * **Performance**: nested VMs might experience a 10% or greater  decrease in performance for workloads that are CPU-bound and  possibly greater than a 10% decrease for workloads that are  input/output bound.  * **Machine Type**: nested virtualization can only be enabled on  workstation configurations that specify a  [machine_type][google.cloud.workstations.v1.WorkstationConfig.Host.GceInstance.machine_type]  in the N1 or N2 machine series.  * **GPUs**: nested virtualization may not be enabled on workstation  configurations with accelerators.  * **Operating System**: Because  [Container-Optimized  OS](https://cloud.google.com/compute/docs/images/os-details#container-optimized_os_cos)  does not support nested virtualization, when nested virtualization is  enabled, the underlying Compute Engine VM instances boot from an  [Ubuntu  LTS](https://cloud.google.com/compute/docs/images/os-details#ubuntu_lts)  image.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Optional. The type of machine to use for VM instances—for example, `"e2-standard-4"`. For more information about machine types that Cloud Workstations supports, see the list of [available machine types](https://cloud.google.com/workstations/docs/available-machine-types).</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Optional. The number of VMs that the system should keep idle so that new workstations can be started quickly for new users. Defaults to `0` in the API.</summary>
    [JsonPropertyName("poolSize")]
    public int? PoolSize { get; set; }

    /// <summary>Optional. A reference to the service account for Cloud  Workstations VMs created with this configuration. When specified, be  sure that the service account has `logginglogEntries.create` permission  on the project so it can write logs out to Cloud Logging. If using a  custom container image, the service account must have permissions to  pull the specified image.   If you as the administrator want to be able to `ssh` into the  underlying VM, you need to set this value to a service account  for which you have the `iam.serviceAccounts.actAs` permission.  Conversely, if you don't want anyone to be able to `ssh` into the  underlying VM, use a service account where no one has that  permission.   If not set, VMs run with a service account provided by the  Cloud Workstations service, and the image must be publicly  accessible.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1WorkstationConfigSpecHostGceInstanceServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Scopes to grant to the [service_account][google.cloud.workstations.v1.WorkstationConfig.Host.GceInstance.service_account]. Various scopes are automatically added based on feature usage. When specified, users of workstations under this configuration must have `iam.serviceAccounts.actAs` on the service account.</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Optional. A set of Compute Engine Shielded instance options.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1WorkstationConfigSpecHostGceInstanceShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Optional. Network tags to add to the Compute Engine VMs backing the workstations. This option applies [network tags](https://cloud.google.com/vpc/docs/add-remove-network-tags) to VMs created with this configuration. These network tags enable the creation of [firewall rules](https://cloud.google.com/workstations/docs/configure-firewall-rules).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Runtime host for the workstation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecHost
{
    /// <summary>Specifies a Compute Engine instance as the host.</summary>
    [JsonPropertyName("gceInstance")]
    public V1beta1WorkstationConfigSpecHostGceInstance? GceInstance { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecLabels
{
    /// <summary>Key for the label.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for the label.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parent is a reference to the parent WorkstationCluster for this WorkstationConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecParentRef
{
    /// <summary>A reference to an externally managed WorkstationCluster resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/workstationClusters/{{workstationclusterID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a WorkstationCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a WorkstationCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A PersistentDirectory backed by a Compute Engine persistent disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecPersistentDirectoriesGcePD
{
    /// <summary>Optional. The [type of the persistent disk](https://cloud.google.com/compute/docs/disks#disk-types) for the home directory. Defaults to `"pd-standard"`.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Optional. Type of file system that the disk should be formatted with. The workstation image must support this file system type. Must be empty if [source_snapshot][google.cloud.workstations.v1.WorkstationConfig.PersistentDirectory.GceRegionalPersistentDisk.source_snapshot] is set. Defaults to `"ext4"`.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>Optional. Whether the persistent disk should be deleted when the workstation is deleted. Valid values are `DELETE` and `RETAIN`. Defaults to `DELETE`.</summary>
    [JsonPropertyName("reclaimPolicy")]
    public string? ReclaimPolicy { get; set; }

    /// <summary>Optional. The GB capacity of a persistent home directory for each  workstation created with this configuration. Must be empty if  [source_snapshot][google.cloud.workstations.v1.WorkstationConfig.PersistentDirectory.GceRegionalPersistentDisk.source_snapshot]  is set.   Valid values are `10`, `50`, `100`, `200`, `500`, or `1000`.  Defaults to `200`. If less than `200` GB, the  [disk_type][google.cloud.workstations.v1.WorkstationConfig.PersistentDirectory.GceRegionalPersistentDisk.disk_type]  must be  `"pd-balanced"` or `"pd-ssd"`.</summary>
    [JsonPropertyName("sizeGB")]
    public int? SizeGB { get; set; }

    /// <summary>Optional. Name of the snapshot to use as the source for the disk. If set, [size_gb][google.cloud.workstations.v1.WorkstationConfig.PersistentDirectory.GceRegionalPersistentDisk.size_gb] and [fs_type][google.cloud.workstations.v1.WorkstationConfig.PersistentDirectory.GceRegionalPersistentDisk.fs_type] must be empty.</summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecPersistentDirectories
{
    /// <summary>A PersistentDirectory backed by a Compute Engine persistent disk.</summary>
    [JsonPropertyName("gcePD")]
    public V1beta1WorkstationConfigSpecPersistentDirectoriesGcePD? GcePD { get; set; }

    /// <summary>Optional. Location of this directory in the running workstation.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpecReadinessChecks
{
    /// <summary>Optional. Path to which the request should be sent.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Port to which the request should be sent.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WorkstationConfigSpec defines the desired state of WorkstationConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigSpec
{
    /// <summary>Optional. Client-specified annotations.</summary>
    [JsonPropertyName("annotations")]
    public IList<V1beta1WorkstationConfigSpecAnnotations>? Annotations { get; set; }

    /// <summary>Optional. Container that runs upon startup for each workstation using this workstation configuration.</summary>
    [JsonPropertyName("container")]
    public V1beta1WorkstationConfigSpecContainer? Container { get; set; }

    /// <summary>Optional. Human-readable name for this workstation configuration.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. Encrypts resources of this workstation configuration using a  customer-managed encryption key (CMEK).   If specified, the boot disk of the Compute Engine instance and the  persistent disk are encrypted using this encryption key. If  this field is not set, the disks are encrypted using a generated  key. Customer-managed encryption keys do not protect disk metadata.   If the customer-managed encryption key is rotated, when the workstation  instance is stopped, the system attempts to recreate the  persistent disk with the new version of the key. Be sure to keep  older versions of the key until the persistent disk is recreated.  Otherwise, data on the persistent disk might be lost.   If the encryption key is revoked, the workstation session automatically  stops within 7 hours.   Immutable after the workstation configuration is created.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1beta1WorkstationConfigSpecEncryptionKey? EncryptionKey { get; set; }

    /// <summary>Optional. Runtime host for the workstation.</summary>
    [JsonPropertyName("host")]
    public V1beta1WorkstationConfigSpecHost? Host { get; set; }

    /// <summary>Optional. Number of seconds to wait before automatically stopping a  workstation after it last received user traffic.   A value of `"0s"` indicates that Cloud Workstations VMs created with this  configuration should never time out due to idleness.  Provide  [duration](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#duration)  terminated by `s` for seconds—for example, `"7200s"` (2 hours).  The default is `"1200s"` (20 minutes).</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>Optional. [Labels](https://cloud.google.com/workstations/docs/label-resources) that are applied to the workstation configuration and that are also propagated to the underlying Compute Engine resources.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1WorkstationConfigSpecLabels>? Labels { get; set; }

    /// <summary>Parent is a reference to the parent WorkstationCluster for this WorkstationConfig.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WorkstationConfigSpecParentRef ParentRef { get; set; }

    /// <summary>Optional. Directories to persist across workstation sessions.</summary>
    [JsonPropertyName("persistentDirectories")]
    public IList<V1beta1WorkstationConfigSpecPersistentDirectories>? PersistentDirectories { get; set; }

    /// <summary>Optional. Readiness checks to perform when starting a workstation using this workstation configuration. Mark a workstation as running only after all specified readiness checks return 200 status codes.</summary>
    [JsonPropertyName("readinessChecks")]
    public IList<V1beta1WorkstationConfigSpecReadinessChecks>? ReadinessChecks { get; set; }

    /// <summary>Optional. Immutable. Specifies the zones used to replicate the VM and disk  resources within the region. If set, exactly two zones within the  workstation cluster's region must be specified—for example,  `['us-central1-a', 'us-central1-f']`. If this field is empty, two default  zones within the region are used.   Immutable after the workstation configuration is created.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>The WorkstationConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Number of seconds that a workstation can run until it is  automatically shut down. We recommend that workstations be shut down daily  to reduce costs and so that security updates can be applied upon restart.  The  [idle_timeout][google.cloud.workstations.v1.WorkstationConfig.idle_timeout]  and  [running_timeout][google.cloud.workstations.v1.WorkstationConfig.running_timeout]  fields are independent of each other. Note that the  [running_timeout][google.cloud.workstations.v1.WorkstationConfig.running_timeout]  field shuts down VMs after the specified time, regardless of whether or not  the VMs are idle.   Provide duration terminated by `s` for seconds—for example, `"54000s"`  (15 hours). Defaults to `"43200s"` (12 hours). A value of `"0s"` indicates  that workstations using this configuration should never time out. If  [encryption_key][google.cloud.workstations.v1.WorkstationConfig.encryption_key]  is set, it must be greater than `"0s"` and less than  `"86400s"` (24 hours).   Warning: A value of `"0s"` indicates that Cloud Workstations VMs created  with this configuration have no maximum running time. This is strongly  discouraged because you incur costs and will not pick up security updates.</summary>
    [JsonPropertyName("runningTimeout")]
    public string? RunningTimeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatusConditions
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
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatusObservedStateGcpConditions
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Observed state of the Compute Engine runtime host for the workstation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatusObservedStateHostGceInstance
{
    /// <summary>Output only. Number of instances currently available in the pool for faster workstation startup.</summary>
    [JsonPropertyName("pooledInstances")]
    public int? PooledInstances { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Observed state of the runtime host for the workstation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatusObservedStateHost
{
    /// <summary>Output only. Observed state of the Compute Engine runtime host for the workstation configuration.</summary>
    [JsonPropertyName("gceInstance")]
    public V1beta1WorkstationConfigStatusObservedStateHostGceInstance? GceInstance { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatusObservedState
{
    /// <summary>Output only. Time when this workstation configuration was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Whether this resource is degraded, in which case it may require user action to restore full functionality. See also the [conditions][google.cloud.workstations.v1.WorkstationConfig.conditions] field.</summary>
    [JsonPropertyName("degraded")]
    public bool? Degraded { get; set; }

    /// <summary>Output only. Time when this workstation configuration was soft-deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. Checksum computed by the server. May be sent on update and delete requests to make sure that the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Status conditions describing the current resource state.</summary>
    [JsonPropertyName("gcpConditions")]
    public IList<V1beta1WorkstationConfigStatusObservedStateGcpConditions>? GcpConditions { get; set; }

    /// <summary>Output only. Observed state of the runtime host for the workstation configuration.</summary>
    [JsonPropertyName("host")]
    public V1beta1WorkstationConfigStatusObservedStateHost? Host { get; set; }

    /// <summary>Output only. A system-assigned unique identifier for this workstation configuration.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Time when this workstation configuration was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WorkstationConfigStatus defines the config connector machine state of WorkstationConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkstationConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkstationConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the WorkstationConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1WorkstationConfigStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WorkstationConfig is the Schema for the WorkstationConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkstationConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkstationConfigSpec>, IStatus<V1beta1WorkstationConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkstationConfig";
    public const string KubeGroup = "workstations.cnrm.cloud.google.com";
    public const string KubePluralName = "workstationconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkstationConfigSpec defines the desired state of WorkstationConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkstationConfigSpec? Spec { get; set; }

    /// <summary>WorkstationConfigStatus defines the config connector machine state of WorkstationConfig</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkstationConfigStatus? Status { get; set; }
}
#nullable disable
