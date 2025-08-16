using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.efs.aws.upbound.io;
/// <summary>ReplicationConfiguration is the Schema for the ReplicationConfigurations API. Provides an Elastic File System (EFS) Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicationConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReplicationConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicationConfigurationList";
    public const string KubeGroup = "efs.aws.upbound.io";
    public const string KubePluralName = "replicationconfigurations";
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
    public IList<V1beta1ReplicationConfiguration> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderDestination
{
    /// <summary>The availability zone in which the replica should be created. If specified, the replica will be created with One Zone storage. If omitted, regional storage will be used.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>The ID of the destination file system for the replication. If no ID is provided, then EFS creates a new file system with the default settings.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The Key ID, ARN, alias, or alias ARN of the KMS key that should be used to encrypt the replica file system. If omitted, the default KMS key for EFS /aws/elasticfilesystem will be used.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FileSystem in efs to populate sourceFileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FileSystem in efs to populate sourceFileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecForProvider
{
    /// <summary>A destination configuration block (documented below).</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationSpecForProviderDestination>? Destination { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ID of the file system that is to be replicated.</summary>
    [JsonPropertyName("sourceFileSystemId")]
    public string? SourceFileSystemId { get; set; }

    /// <summary>Reference to a FileSystem in efs to populate sourceFileSystemId.</summary>
    [JsonPropertyName("sourceFileSystemIdRef")]
    public V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdRef? SourceFileSystemIdRef { get; set; }

    /// <summary>Selector for a FileSystem in efs to populate sourceFileSystemId.</summary>
    [JsonPropertyName("sourceFileSystemIdSelector")]
    public V1beta1ReplicationConfigurationSpecForProviderSourceFileSystemIdSelector? SourceFileSystemIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderDestination
{
    /// <summary>The availability zone in which the replica should be created. If specified, the replica will be created with One Zone storage. If omitted, regional storage will be used.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>The ID of the destination file system for the replication. If no ID is provided, then EFS creates a new file system with the default settings.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The Key ID, ARN, alias, or alias ARN of the KMS key that should be used to encrypt the replica file system. If omitted, the default KMS key for EFS /aws/elasticfilesystem will be used.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FileSystem in efs to populate sourceFileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FileSystem in efs to populate sourceFileSystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecInitProvider
{
    /// <summary>A destination configuration block (documented below).</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationSpecInitProviderDestination>? Destination { get; set; }

    /// <summary>The ID of the file system that is to be replicated.</summary>
    [JsonPropertyName("sourceFileSystemId")]
    public string? SourceFileSystemId { get; set; }

    /// <summary>Reference to a FileSystem in efs to populate sourceFileSystemId.</summary>
    [JsonPropertyName("sourceFileSystemIdRef")]
    public V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdRef? SourceFileSystemIdRef { get; set; }

    /// <summary>Selector for a FileSystem in efs to populate sourceFileSystemId.</summary>
    [JsonPropertyName("sourceFileSystemIdSelector")]
    public V1beta1ReplicationConfigurationSpecInitProviderSourceFileSystemIdSelector? SourceFileSystemIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1ReplicationConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ReplicationConfigurationSpec defines the desired state of ReplicationConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReplicationConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReplicationConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReplicationConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReplicationConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProviderDestination
{
    /// <summary>The availability zone in which the replica should be created. If specified, the replica will be created with One Zone storage. If omitted, regional storage will be used.</summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>The ID of the destination file system for the replication. If no ID is provided, then EFS creates a new file system with the default settings.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The Key ID, ARN, alias, or alias ARN of the KMS key that should be used to encrypt the replica file system. If omitted, the default KMS key for EFS /aws/elasticfilesystem will be used.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The status of the replication.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusAtProvider
{
    /// <summary>When the replication configuration was created.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>A destination configuration block (documented below).</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ReplicationConfigurationStatusAtProviderDestination>? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the original source Amazon EFS file system in the replication configuration.</summary>
    [JsonPropertyName("originalSourceFileSystemArn")]
    public string? OriginalSourceFileSystemArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the current source file system in the replication configuration.</summary>
    [JsonPropertyName("sourceFileSystemArn")]
    public string? SourceFileSystemArn { get; set; }

    /// <summary>The ID of the file system that is to be replicated.</summary>
    [JsonPropertyName("sourceFileSystemId")]
    public string? SourceFileSystemId { get; set; }

    /// <summary>The AWS Region in which the source Amazon EFS file system is located.</summary>
    [JsonPropertyName("sourceFileSystemRegion")]
    public string? SourceFileSystemRegion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatusConditions
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

/// <summary>ReplicationConfigurationStatus defines the observed state of ReplicationConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicationConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReplicationConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReplicationConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ReplicationConfiguration is the Schema for the ReplicationConfigurations API. Provides an Elastic File System (EFS) Replication Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicationConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReplicationConfigurationSpec>, IStatus<V1beta1ReplicationConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicationConfiguration";
    public const string KubeGroup = "efs.aws.upbound.io";
    public const string KubePluralName = "replicationconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicationConfigurationSpec defines the desired state of ReplicationConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReplicationConfigurationSpec Spec { get; set; }

    /// <summary>ReplicationConfigurationStatus defines the observed state of ReplicationConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReplicationConfigurationStatus? Status { get; set; }
}