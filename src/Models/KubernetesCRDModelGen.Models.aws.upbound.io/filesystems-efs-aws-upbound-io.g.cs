using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.efs.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderLifecyclePolicy
{
    /// <summary>Indicates how long it takes to transition files to the archive storage class. Requires transition_to_ia, Elastic Throughput and General Purpose performance mode. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToArchive")]
    public string? TransitionToArchive { get; set; }

    /// <summary>Indicates how long it takes to transition files to the IA storage class. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToIa")]
    public string? TransitionToIa { get; set; }

    /// <summary>Describes the policy used to transition a file from infequent access storage to primary storage. Valid values: AFTER_1_ACCESS.</summary>
    [JsonPropertyName("transitionToPrimaryStorageClass")]
    public string? TransitionToPrimaryStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProviderProtection
{
    /// <summary>Indicates whether replication overwrite protection is enabled. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("replicationOverwrite")]
    public string? ReplicationOverwrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecForProvider
{
    /// <summary>the AWS Availability Zone in which to create the file system. Used to create a file system that uses One Zone storage classes. See user guide for more information.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>A unique name (a maximum of 64 characters are allowed) used as reference when creating the Elastic File System to ensure idempotent file system creation. See Elastic File System user guide for more information.</summary>
    [JsonPropertyName("creationToken")]
    public string? CreationToken { get; set; }

    /// <summary>If true, the disk will be encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1FileSystemSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1FileSystemSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>A file system lifecycle policy object. See lifecycle_policy block below for details.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public IList<V1beta1FileSystemSpecForProviderLifecyclePolicy>? LifecyclePolicy { get; set; }

    /// <summary>The file system performance mode. Can be either "generalPurpose" or "maxIO" (Default: "generalPurpose").</summary>
    [JsonPropertyName("performanceMode")]
    public string? PerformanceMode { get; set; }

    /// <summary>A file system protection object. See protection block below for details.</summary>
    [JsonPropertyName("protection")]
    public IList<V1beta1FileSystemSpecForProviderProtection>? Protection { get; set; }

    /// <summary>The throughput, measured in MiB/s, that you want to provision for the file system. Only applicable with throughput_mode set to provisioned.</summary>
    [JsonPropertyName("provisionedThroughputInMibps")]
    public double? ProvisionedThroughputInMibps { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput mode for the file system. Defaults to bursting. Valid values: bursting, provisioned, or elastic. When using provisioned, also set provisioned_throughput_in_mibps.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderLifecyclePolicy
{
    /// <summary>Indicates how long it takes to transition files to the archive storage class. Requires transition_to_ia, Elastic Throughput and General Purpose performance mode. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToArchive")]
    public string? TransitionToArchive { get; set; }

    /// <summary>Indicates how long it takes to transition files to the IA storage class. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToIa")]
    public string? TransitionToIa { get; set; }

    /// <summary>Describes the policy used to transition a file from infequent access storage to primary storage. Valid values: AFTER_1_ACCESS.</summary>
    [JsonPropertyName("transitionToPrimaryStorageClass")]
    public string? TransitionToPrimaryStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProviderProtection
{
    /// <summary>Indicates whether replication overwrite protection is enabled. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("replicationOverwrite")]
    public string? ReplicationOverwrite { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecInitProvider
{
    /// <summary>the AWS Availability Zone in which to create the file system. Used to create a file system that uses One Zone storage classes. See user guide for more information.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>A unique name (a maximum of 64 characters are allowed) used as reference when creating the Elastic File System to ensure idempotent file system creation. See Elastic File System user guide for more information.</summary>
    [JsonPropertyName("creationToken")]
    public string? CreationToken { get; set; }

    /// <summary>If true, the disk will be encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1FileSystemSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1FileSystemSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>A file system lifecycle policy object. See lifecycle_policy block below for details.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public IList<V1beta1FileSystemSpecInitProviderLifecyclePolicy>? LifecyclePolicy { get; set; }

    /// <summary>The file system performance mode. Can be either "generalPurpose" or "maxIO" (Default: "generalPurpose").</summary>
    [JsonPropertyName("performanceMode")]
    public string? PerformanceMode { get; set; }

    /// <summary>A file system protection object. See protection block below for details.</summary>
    [JsonPropertyName("protection")]
    public IList<V1beta1FileSystemSpecInitProviderProtection>? Protection { get; set; }

    /// <summary>The throughput, measured in MiB/s, that you want to provision for the file system. Only applicable with throughput_mode set to provisioned.</summary>
    [JsonPropertyName("provisionedThroughputInMibps")]
    public double? ProvisionedThroughputInMibps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput mode for the file system. Defaults to bursting. Valid values: bursting, provisioned, or elastic. When using provisioned, also set provisioned_throughput_in_mibps.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecProviderConfigRefPolicy
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
public partial class V1beta1FileSystemSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FileSystemSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FileSystemSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FileSystemSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FileSystemSpec defines the desired state of FileSystem</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FileSystemSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FileSystemSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FileSystemSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FileSystemSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FileSystemSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatusAtProviderLifecyclePolicy
{
    /// <summary>Indicates how long it takes to transition files to the archive storage class. Requires transition_to_ia, Elastic Throughput and General Purpose performance mode. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToArchive")]
    public string? TransitionToArchive { get; set; }

    /// <summary>Indicates how long it takes to transition files to the IA storage class. Valid values: AFTER_1_DAY, AFTER_7_DAYS, AFTER_14_DAYS, AFTER_30_DAYS, AFTER_60_DAYS, AFTER_90_DAYS, AFTER_180_DAYS, AFTER_270_DAYS, or AFTER_365_DAYS.</summary>
    [JsonPropertyName("transitionToIa")]
    public string? TransitionToIa { get; set; }

    /// <summary>Describes the policy used to transition a file from infequent access storage to primary storage. Valid values: AFTER_1_ACCESS.</summary>
    [JsonPropertyName("transitionToPrimaryStorageClass")]
    public string? TransitionToPrimaryStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatusAtProviderProtection
{
    /// <summary>Indicates whether replication overwrite protection is enabled. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("replicationOverwrite")]
    public string? ReplicationOverwrite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatusAtProviderSizeInBytes
{
    /// <summary>The latest known metered size (in bytes) of data stored in the file system.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    /// <summary>The latest known metered size (in bytes) of data stored in the Infrequent Access storage class.</summary>
    [JsonPropertyName("valueInIa")]
    public double? ValueInIa { get; set; }

    /// <summary>The latest known metered size (in bytes) of data stored in the Standard storage class.</summary>
    [JsonPropertyName("valueInStandard")]
    public double? ValueInStandard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatusAtProvider
{
    /// <summary>Amazon Resource Name of the file system.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the Availability Zone in which the file system's One Zone storage classes exist.</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>the AWS Availability Zone in which to create the file system. Used to create a file system that uses One Zone storage classes. See user guide for more information.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>A unique name (a maximum of 64 characters are allowed) used as reference when creating the Elastic File System to ensure idempotent file system creation. See Elastic File System user guide for more information.</summary>
    [JsonPropertyName("creationToken")]
    public string? CreationToken { get; set; }

    /// <summary>The DNS name for the filesystem per documented convention.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, the disk will be encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The ID that identifies the file system (e.g., fs-ccfc0d65).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>A file system lifecycle policy object. See lifecycle_policy block below for details.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public IList<V1beta1FileSystemStatusAtProviderLifecyclePolicy>? LifecyclePolicy { get; set; }

    /// <summary>The value of the file system's Name tag.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The current number of mount targets that the file system has.</summary>
    [JsonPropertyName("numberOfMountTargets")]
    public double? NumberOfMountTargets { get; set; }

    /// <summary>The AWS account that created the file system. If the file system was createdby an IAM user, the parent account to which the user belongs is the owner.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The file system performance mode. Can be either "generalPurpose" or "maxIO" (Default: "generalPurpose").</summary>
    [JsonPropertyName("performanceMode")]
    public string? PerformanceMode { get; set; }

    /// <summary>A file system protection object. See protection block below for details.</summary>
    [JsonPropertyName("protection")]
    public IList<V1beta1FileSystemStatusAtProviderProtection>? Protection { get; set; }

    /// <summary>The throughput, measured in MiB/s, that you want to provision for the file system. Only applicable with throughput_mode set to provisioned.</summary>
    [JsonPropertyName("provisionedThroughputInMibps")]
    public double? ProvisionedThroughputInMibps { get; set; }

    /// <summary>The latest known metered size (in bytes) of data stored in the file system, the value is not the exact size that the file system was at any point in time. See Size In Bytes.</summary>
    [JsonPropertyName("sizeInBytes")]
    public IList<V1beta1FileSystemStatusAtProviderSizeInBytes>? SizeInBytes { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput mode for the file system. Defaults to bursting. Valid values: bursting, provisioned, or elastic. When using provisioned, also set provisioned_throughput_in_mibps.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatusConditions
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

/// <summary>FileSystemStatus defines the observed state of FileSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FileSystemStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FileSystemStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FileSystemStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FileSystem is the Schema for the FileSystems API. Provides an Elastic File System (EFS) File System resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FileSystem : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FileSystemSpec>, IStatus<V1beta1FileSystemStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FileSystem";
    public const string KubeGroup = "efs.aws.upbound.io";
    public const string KubePluralName = "filesystems";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FileSystemSpec defines the desired state of FileSystem</summary>
    [JsonPropertyName("spec")]
    public V1beta1FileSystemSpec Spec { get; set; }

    /// <summary>FileSystemStatus defines the observed state of FileSystem.</summary>
    [JsonPropertyName("status")]
    public V1beta1FileSystemStatus? Status { get; set; }
}