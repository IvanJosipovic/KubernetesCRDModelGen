using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
#nullable enable
/// <summary>EBSSnapshotImport is the Schema for the EBSSnapshotImports API. Provides an elastic block storage snapshot import resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EBSSnapshotImportList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EBSSnapshotImport>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EBSSnapshotImportList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "ebssnapshotimports";
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
    public IList<V1beta1EBSSnapshotImport> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderClientData
{
    /// <summary>A user-defined comment about the disk upload.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The time that the disk upload ends.</summary>
    [JsonPropertyName("uploadEnd")]
    public string? UploadEnd { get; set; }

    /// <summary>The size of the uploaded disk image, in GiB.</summary>
    [JsonPropertyName("uploadSize")]
    public double? UploadSize { get; set; }

    /// <summary>The time that the disk upload starts.</summary>
    [JsonPropertyName("uploadStart")]
    public string? UploadStart { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderDiskContainerUserBucket
{
    /// <summary>The name of the Amazon S3 bucket where the disk image is located.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The file name of the disk image.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderDiskContainer
{
    /// <summary>The description of the disk image being imported.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The format of the disk image being imported. One of VHD or VMDK.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The URL to the Amazon S3-based disk image being imported. It can either be a https URL (https://..) or an Amazon S3 URL (s3://..). One of url or user_bucket must be set.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The Amazon S3 bucket for the disk image. One of url or user_bucket must be set. Detailed below.</summary>
    [JsonPropertyName("userBucket")]
    public IList<V1beta1EBSSnapshotImportSpecForProviderDiskContainerUserBucket>? UserBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecForProvider
{
    /// <summary>The client-specific data. Detailed below.</summary>
    [JsonPropertyName("clientData")]
    public IList<V1beta1EBSSnapshotImportSpecForProviderClientData>? ClientData { get; set; }

    /// <summary>The description string for the import snapshot task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the disk container. Detailed below.</summary>
    [JsonPropertyName("diskContainer")]
    public IList<V1beta1EBSSnapshotImportSpecForProviderDiskContainer>? DiskContainer { get; set; }

    /// <summary>Specifies whether the destination snapshot of the imported image should be encrypted. The default KMS key for EBS is used unless you specify a non-default KMS key using KmsKeyId.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>An identifier for the symmetric KMS key to use when creating the encrypted snapshot. This parameter is only required if you want to use a non-default KMS key; if this parameter is not specified, the default KMS key for EBS is used. If a KmsKeyId is specified, the Encrypted flag must also be set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1EBSSnapshotImportSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Indicates whether to permanently restore an archived snapshot.</summary>
    [JsonPropertyName("permanentRestore")]
    public bool? PermanentRestore { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the IAM Role the VM Import/Export service will assume. This role needs certain permissions. See https://docs.aws.amazon.com/vm-import/latest/userguide/vmie_prereqs.html#vmimport-role. Default: vmimport</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the storage tier. Valid values are archive and standard. Default value is standard.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the number of days for which to temporarily restore an archived snapshot. Required for temporary restores only. The snapshot will be automatically re-archived after this period.</summary>
    [JsonPropertyName("temporaryRestoreDays")]
    public double? TemporaryRestoreDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderClientData
{
    /// <summary>A user-defined comment about the disk upload.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The time that the disk upload ends.</summary>
    [JsonPropertyName("uploadEnd")]
    public string? UploadEnd { get; set; }

    /// <summary>The size of the uploaded disk image, in GiB.</summary>
    [JsonPropertyName("uploadSize")]
    public double? UploadSize { get; set; }

    /// <summary>The time that the disk upload starts.</summary>
    [JsonPropertyName("uploadStart")]
    public string? UploadStart { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderDiskContainerUserBucket
{
    /// <summary>The name of the Amazon S3 bucket where the disk image is located.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The file name of the disk image.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderDiskContainer
{
    /// <summary>The description of the disk image being imported.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The format of the disk image being imported. One of VHD or VMDK.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The URL to the Amazon S3-based disk image being imported. It can either be a https URL (https://..) or an Amazon S3 URL (s3://..). One of url or user_bucket must be set.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The Amazon S3 bucket for the disk image. One of url or user_bucket must be set. Detailed below.</summary>
    [JsonPropertyName("userBucket")]
    public IList<V1beta1EBSSnapshotImportSpecInitProviderDiskContainerUserBucket>? UserBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecInitProvider
{
    /// <summary>The client-specific data. Detailed below.</summary>
    [JsonPropertyName("clientData")]
    public IList<V1beta1EBSSnapshotImportSpecInitProviderClientData>? ClientData { get; set; }

    /// <summary>The description string for the import snapshot task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the disk container. Detailed below.</summary>
    [JsonPropertyName("diskContainer")]
    public IList<V1beta1EBSSnapshotImportSpecInitProviderDiskContainer>? DiskContainer { get; set; }

    /// <summary>Specifies whether the destination snapshot of the imported image should be encrypted. The default KMS key for EBS is used unless you specify a non-default KMS key using KmsKeyId.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>An identifier for the symmetric KMS key to use when creating the encrypted snapshot. This parameter is only required if you want to use a non-default KMS key; if this parameter is not specified, the default KMS key for EBS is used. If a KmsKeyId is specified, the Encrypted flag must also be set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1EBSSnapshotImportSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Indicates whether to permanently restore an archived snapshot.</summary>
    [JsonPropertyName("permanentRestore")]
    public bool? PermanentRestore { get; set; }

    /// <summary>The name of the IAM Role the VM Import/Export service will assume. This role needs certain permissions. See https://docs.aws.amazon.com/vm-import/latest/userguide/vmie_prereqs.html#vmimport-role. Default: vmimport</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the storage tier. Valid values are archive and standard. Default value is standard.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the number of days for which to temporarily restore an archived snapshot. Required for temporary restores only. The snapshot will be automatically re-archived after this period.</summary>
    [JsonPropertyName("temporaryRestoreDays")]
    public double? TemporaryRestoreDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EBSSnapshotImportSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EBSSnapshotImportSpec defines the desired state of EBSSnapshotImport</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EBSSnapshotImportSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EBSSnapshotImportSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EBSSnapshotImportSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EBSSnapshotImportSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatusAtProviderClientData
{
    /// <summary>A user-defined comment about the disk upload.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The time that the disk upload ends.</summary>
    [JsonPropertyName("uploadEnd")]
    public string? UploadEnd { get; set; }

    /// <summary>The size of the uploaded disk image, in GiB.</summary>
    [JsonPropertyName("uploadSize")]
    public double? UploadSize { get; set; }

    /// <summary>The time that the disk upload starts.</summary>
    [JsonPropertyName("uploadStart")]
    public string? UploadStart { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatusAtProviderDiskContainerUserBucket
{
    /// <summary>The name of the Amazon S3 bucket where the disk image is located.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The file name of the disk image.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatusAtProviderDiskContainer
{
    /// <summary>The description of the disk image being imported.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The format of the disk image being imported. One of VHD or VMDK.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The URL to the Amazon S3-based disk image being imported. It can either be a https URL (https://..) or an Amazon S3 URL (s3://..). One of url or user_bucket must be set.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The Amazon S3 bucket for the disk image. One of url or user_bucket must be set. Detailed below.</summary>
    [JsonPropertyName("userBucket")]
    public IList<V1beta1EBSSnapshotImportStatusAtProviderDiskContainerUserBucket>? UserBucket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the EBS Snapshot.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The client-specific data. Detailed below.</summary>
    [JsonPropertyName("clientData")]
    public IList<V1beta1EBSSnapshotImportStatusAtProviderClientData>? ClientData { get; set; }

    /// <summary>The data encryption key identifier for the snapshot.</summary>
    [JsonPropertyName("dataEncryptionKeyId")]
    public string? DataEncryptionKeyId { get; set; }

    /// <summary>The description string for the import snapshot task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the disk container. Detailed below.</summary>
    [JsonPropertyName("diskContainer")]
    public IList<V1beta1EBSSnapshotImportStatusAtProviderDiskContainer>? DiskContainer { get; set; }

    /// <summary>Specifies whether the destination snapshot of the imported image should be encrypted. The default KMS key for EBS is used unless you specify a non-default KMS key using KmsKeyId.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The snapshot ID (e.g., snap-59fcb34e).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identifier for the symmetric KMS key to use when creating the encrypted snapshot. This parameter is only required if you want to use a non-default KMS key; if this parameter is not specified, the default KMS key for EBS is used. If a KmsKeyId is specified, the Encrypted flag must also be set.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the EBS Snapshot.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>Value from an Amazon-maintained list (amazon, aws-marketplace, microsoft) of snapshot owners.</summary>
    [JsonPropertyName("ownerAlias")]
    public string? OwnerAlias { get; set; }

    /// <summary>The AWS account ID of the EBS snapshot owner.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Indicates whether to permanently restore an archived snapshot.</summary>
    [JsonPropertyName("permanentRestore")]
    public bool? PermanentRestore { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the IAM Role the VM Import/Export service will assume. This role needs certain permissions. See https://docs.aws.amazon.com/vm-import/latest/userguide/vmie_prereqs.html#vmimport-role. Default: vmimport</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the storage tier. Valid values are archive and standard. Default value is standard.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies the number of days for which to temporarily restore an archived snapshot. Required for temporary restores only. The snapshot will be automatically re-archived after this period.</summary>
    [JsonPropertyName("temporaryRestoreDays")]
    public double? TemporaryRestoreDays { get; set; }

    /// <summary>The snapshot ID (e.g., snap-59fcb34e).</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary>The size of the drive in GiBs.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatusConditions
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
/// <summary>EBSSnapshotImportStatus defines the observed state of EBSSnapshotImport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EBSSnapshotImportStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EBSSnapshotImportStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EBSSnapshotImportStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EBSSnapshotImport is the Schema for the EBSSnapshotImports API. Provides an elastic block storage snapshot import resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EBSSnapshotImport : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EBSSnapshotImportSpec>, IStatus<V1beta1EBSSnapshotImportStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EBSSnapshotImport";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "ebssnapshotimports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EBSSnapshotImportSpec defines the desired state of EBSSnapshotImport</summary>
    [JsonPropertyName("spec")]
    public V1beta1EBSSnapshotImportSpec Spec { get; set; }

    /// <summary>EBSSnapshotImportStatus defines the observed state of EBSSnapshotImport.</summary>
    [JsonPropertyName("status")]
    public V1beta1EBSSnapshotImportStatus? Status { get; set; }
}
#nullable disable
