using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fsx.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LustreFileSystem in fsx to populate fileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LustreFileSystem in fsx to populate fileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderS3AutoExportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderS3AutoImportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProviderS3
{
    /// <summary>Specifies the type of updated objects that will be automatically exported from your file system to the linked S3 bucket. See the events configuration block.</summary>
    [JsonPropertyName("autoExportPolicy")]
    public IList<V1beta1DataRepositoryAssociationSpecForProviderS3AutoExportPolicy>? AutoExportPolicy { get; set; }

    /// <summary>Specifies the type of updated objects that will be automatically imported from the linked S3 bucket to your file system. See the events configuration block.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public IList<V1beta1DataRepositoryAssociationSpecForProviderS3AutoImportPolicy>? AutoImportPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecForProvider
{
    /// <summary>Set to true to run an import data repository task to import metadata from the data repository to the file system after the data repository association is created. Defaults to false.</summary>
    [JsonPropertyName("batchImportMetaDataOnCreate")]
    public bool? BatchImportMetaDataOnCreate { get; set; }

    /// <summary>The path to the Amazon S3 data repository that will be linked to the file system. The path must be an S3 bucket s3://myBucket/myPrefix/. This path specifies where in the S3 data repository files will be imported from or exported to. The same S3 bucket cannot be linked more than once to the same file system.</summary>
    [JsonPropertyName("dataRepositoryPath")]
    public string? DataRepositoryPath { get; set; }

    /// <summary>Set to true to delete files from the file system upon deleting this data repository association. Defaults to false.</summary>
    [JsonPropertyName("deleteDataInFilesystem")]
    public bool? DeleteDataInFilesystem { get; set; }

    /// <summary>The ID of the Amazon FSx file system to on which to create a data repository association.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a LustreFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a LustreFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1DataRepositoryAssociationSpecForProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>A path on the file system that points to a high-level directory (such as /ns1/) or subdirectory (such as /ns1/subdir/) that will be mapped 1-1 with data_repository_path. The leading forward slash in the name is required. Two data repository associations cannot have overlapping file system paths. For example, if a data repository is associated with file system path /ns1/, then you cannot link another data repository with file system path /ns1/ns2. This path specifies where in your file system files will be exported from or imported to. This file system directory can be linked to only one Amazon S3 bucket, and no other S3 bucket can be linked to the directory.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. The maximum number of disks that a single file can be striped across is limited by the total number of disks that make up the file system.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>See the s3 configuration block. Max of 1. The configuration for an Amazon S3 data repository linked to an Amazon FSx Lustre file system with a data repository association. The configuration defines which file events (new, changed, or deleted files or directories) are automatically imported from the linked data repository to the file system or automatically exported from the file system to the data repository.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1DataRepositoryAssociationSpecForProviderS3>? S3 { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LustreFileSystem in fsx to populate fileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LustreFileSystem in fsx to populate fileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderS3AutoExportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderS3AutoImportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProviderS3
{
    /// <summary>Specifies the type of updated objects that will be automatically exported from your file system to the linked S3 bucket. See the events configuration block.</summary>
    [JsonPropertyName("autoExportPolicy")]
    public IList<V1beta1DataRepositoryAssociationSpecInitProviderS3AutoExportPolicy>? AutoExportPolicy { get; set; }

    /// <summary>Specifies the type of updated objects that will be automatically imported from the linked S3 bucket to your file system. See the events configuration block.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public IList<V1beta1DataRepositoryAssociationSpecInitProviderS3AutoImportPolicy>? AutoImportPolicy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecInitProvider
{
    /// <summary>Set to true to run an import data repository task to import metadata from the data repository to the file system after the data repository association is created. Defaults to false.</summary>
    [JsonPropertyName("batchImportMetaDataOnCreate")]
    public bool? BatchImportMetaDataOnCreate { get; set; }

    /// <summary>The path to the Amazon S3 data repository that will be linked to the file system. The path must be an S3 bucket s3://myBucket/myPrefix/. This path specifies where in the S3 data repository files will be imported from or exported to. The same S3 bucket cannot be linked more than once to the same file system.</summary>
    [JsonPropertyName("dataRepositoryPath")]
    public string? DataRepositoryPath { get; set; }

    /// <summary>Set to true to delete files from the file system upon deleting this data repository association. Defaults to false.</summary>
    [JsonPropertyName("deleteDataInFilesystem")]
    public bool? DeleteDataInFilesystem { get; set; }

    /// <summary>The ID of the Amazon FSx file system to on which to create a data repository association.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a LustreFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a LustreFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1DataRepositoryAssociationSpecInitProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>A path on the file system that points to a high-level directory (such as /ns1/) or subdirectory (such as /ns1/subdir/) that will be mapped 1-1 with data_repository_path. The leading forward slash in the name is required. Two data repository associations cannot have overlapping file system paths. For example, if a data repository is associated with file system path /ns1/, then you cannot link another data repository with file system path /ns1/ns2. This path specifies where in your file system files will be exported from or imported to. This file system directory can be linked to only one Amazon S3 bucket, and no other S3 bucket can be linked to the directory.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. The maximum number of disks that a single file can be striped across is limited by the total number of disks that make up the file system.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>See the s3 configuration block. Max of 1. The configuration for an Amazon S3 data repository linked to an Amazon FSx Lustre file system with a data repository association. The configuration defines which file events (new, changed, or deleted files or directories) are automatically imported from the linked data repository to the file system or automatically exported from the file system to the data repository.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1DataRepositoryAssociationSpecInitProviderS3>? S3 { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataRepositoryAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataRepositoryAssociationSpec defines the desired state of DataRepositoryAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataRepositoryAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataRepositoryAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataRepositoryAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataRepositoryAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatusAtProviderS3AutoExportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatusAtProviderS3AutoImportPolicy
{
    /// <summary>A list of file event types to automatically export to your linked S3 bucket or import from the linked S3 bucket. Valid values are NEW, CHANGED, DELETED. Max of 3.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatusAtProviderS3
{
    /// <summary>Specifies the type of updated objects that will be automatically exported from your file system to the linked S3 bucket. See the events configuration block.</summary>
    [JsonPropertyName("autoExportPolicy")]
    public IList<V1beta1DataRepositoryAssociationStatusAtProviderS3AutoExportPolicy>? AutoExportPolicy { get; set; }

    /// <summary>Specifies the type of updated objects that will be automatically imported from the linked S3 bucket to your file system. See the events configuration block.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public IList<V1beta1DataRepositoryAssociationStatusAtProviderS3AutoImportPolicy>? AutoImportPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatusAtProvider
{
    /// <summary>Amazon Resource Name of the file system.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier of the data repository association, e.g., dra-12345678</summary>
    [JsonPropertyName("associationId")]
    public string? AssociationId { get; set; }

    /// <summary>Set to true to run an import data repository task to import metadata from the data repository to the file system after the data repository association is created. Defaults to false.</summary>
    [JsonPropertyName("batchImportMetaDataOnCreate")]
    public bool? BatchImportMetaDataOnCreate { get; set; }

    /// <summary>The path to the Amazon S3 data repository that will be linked to the file system. The path must be an S3 bucket s3://myBucket/myPrefix/. This path specifies where in the S3 data repository files will be imported from or exported to. The same S3 bucket cannot be linked more than once to the same file system.</summary>
    [JsonPropertyName("dataRepositoryPath")]
    public string? DataRepositoryPath { get; set; }

    /// <summary>Set to true to delete files from the file system upon deleting this data repository association. Defaults to false.</summary>
    [JsonPropertyName("deleteDataInFilesystem")]
    public bool? DeleteDataInFilesystem { get; set; }

    /// <summary>The ID of the Amazon FSx file system to on which to create a data repository association.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>A path on the file system that points to a high-level directory (such as /ns1/) or subdirectory (such as /ns1/subdir/) that will be mapped 1-1 with data_repository_path. The leading forward slash in the name is required. Two data repository associations cannot have overlapping file system paths. For example, if a data repository is associated with file system path /ns1/, then you cannot link another data repository with file system path /ns1/ns2. This path specifies where in your file system files will be exported from or imported to. This file system directory can be linked to only one Amazon S3 bucket, and no other S3 bucket can be linked to the directory.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }

    /// <summary>Identifier of the data repository association, e.g., dra-12345678</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. The maximum number of disks that a single file can be striped across is limited by the total number of disks that make up the file system.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>See the s3 configuration block. Max of 1. The configuration for an Amazon S3 data repository linked to an Amazon FSx Lustre file system with a data repository association. The configuration defines which file events (new, changed, or deleted files or directories) are automatically imported from the linked data repository to the file system or automatically exported from the file system to the data repository.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1DataRepositoryAssociationStatusAtProviderS3>? S3 { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatusConditions
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

/// <summary>DataRepositoryAssociationStatus defines the observed state of DataRepositoryAssociation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataRepositoryAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataRepositoryAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataRepositoryAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataRepositoryAssociation is the Schema for the DataRepositoryAssociations API. Manages a FSx for Lustre Data Repository Association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataRepositoryAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataRepositoryAssociationSpec>, IStatus<V1beta1DataRepositoryAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataRepositoryAssociation";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "datarepositoryassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataRepositoryAssociationSpec defines the desired state of DataRepositoryAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataRepositoryAssociationSpec Spec { get; set; }

    /// <summary>DataRepositoryAssociationStatus defines the observed state of DataRepositoryAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataRepositoryAssociationStatus? Status { get; set; }
}

/// <summary>DataRepositoryAssociation is the Schema for the DataRepositoryAssociations API. Manages a FSx for Lustre Data Repository Association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataRepositoryAssociationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataRepositoryAssociation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataRepositoryAssociationList";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "datarepositoryassociations";
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
    public IList<V1beta1DataRepositoryAssociation> Items { get; set; }
}