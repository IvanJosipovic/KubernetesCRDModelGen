using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
/// <summary>DBSnapshotCopy is the Schema for the DBSnapshotCopys API. Manages an RDS database instance snapshot copy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBSnapshotCopyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DBSnapshotCopy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBSnapshotCopyList";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "dbsnapshotcopies";
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
    public IList<V1beta1DBSnapshotCopy> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderKmsKeyIdRefPolicy
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
public partial class V1beta1DBSnapshotCopySpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderKmsKeyIdSelectorPolicy
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
public partial class V1beta1DBSnapshotCopySpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecForProvider
{
    /// <summary>Whether to copy existing tags. Defaults to false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>The Destination region to place snapshot copy.</summary>
    [JsonPropertyName("destinationRegion")]
    public string? DestinationRegion { get; set; }

    /// <summary>KMS key ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DBSnapshotCopySpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DBSnapshotCopySpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of an option group to associate with the copy of the snapshot.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>he URL that contains a Signature Version 4 signed request.</summary>
    [JsonPropertyName("presignedUrl")]
    public string? PresignedUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of AWS Account IDs to share the snapshot with. Use all to make the snapshot public.</summary>
    [JsonPropertyName("sharedAccounts")]
    public IList<string>? SharedAccounts { get; set; }

    /// <summary>Snapshot identifier of the source snapshot.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifier")]
    public string? SourceDbSnapshotIdentifier { get; set; }

    /// <summary>Reference to a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifierRef")]
    public V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierRef? SourceDbSnapshotIdentifierRef { get; set; }

    /// <summary>Selector for a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifierSelector")]
    public V1beta1DBSnapshotCopySpecForProviderSourceDbSnapshotIdentifierSelector? SourceDbSnapshotIdentifierSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The external custom Availability Zone.</summary>
    [JsonPropertyName("targetCustomAvailabilityZone")]
    public string? TargetCustomAvailabilityZone { get; set; }

    /// <summary>The Identifier for the snapshot.</summary>
    [JsonPropertyName("targetDbSnapshotIdentifier")]
    public string? TargetDbSnapshotIdentifier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdRefPolicy
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
public partial class V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdSelectorPolicy
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
public partial class V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecInitProvider
{
    /// <summary>Whether to copy existing tags. Defaults to false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>The Destination region to place snapshot copy.</summary>
    [JsonPropertyName("destinationRegion")]
    public string? DestinationRegion { get; set; }

    /// <summary>KMS key ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DBSnapshotCopySpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of an option group to associate with the copy of the snapshot.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>he URL that contains a Signature Version 4 signed request.</summary>
    [JsonPropertyName("presignedUrl")]
    public string? PresignedUrl { get; set; }

    /// <summary>List of AWS Account IDs to share the snapshot with. Use all to make the snapshot public.</summary>
    [JsonPropertyName("sharedAccounts")]
    public IList<string>? SharedAccounts { get; set; }

    /// <summary>Snapshot identifier of the source snapshot.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifier")]
    public string? SourceDbSnapshotIdentifier { get; set; }

    /// <summary>Reference to a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifierRef")]
    public V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierRef? SourceDbSnapshotIdentifierRef { get; set; }

    /// <summary>Selector for a Snapshot in rds to populate sourceDbSnapshotIdentifier.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifierSelector")]
    public V1beta1DBSnapshotCopySpecInitProviderSourceDbSnapshotIdentifierSelector? SourceDbSnapshotIdentifierSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The external custom Availability Zone.</summary>
    [JsonPropertyName("targetCustomAvailabilityZone")]
    public string? TargetCustomAvailabilityZone { get; set; }

    /// <summary>The Identifier for the snapshot.</summary>
    [JsonPropertyName("targetDbSnapshotIdentifier")]
    public string? TargetDbSnapshotIdentifier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecProviderConfigRefPolicy
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
public partial class V1beta1DBSnapshotCopySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBSnapshotCopySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DBSnapshotCopySpec defines the desired state of DBSnapshotCopy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DBSnapshotCopySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DBSnapshotCopySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DBSnapshotCopySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DBSnapshotCopySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopyStatusAtProvider
{
    /// <summary>Specifies the allocated storage size in gigabytes (GB).</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>Specifies the name of the Availability Zone the DB instance was located in at the time of the DB snapshot.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Whether to copy existing tags. Defaults to false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the DB snapshot.</summary>
    [JsonPropertyName("dbSnapshotArn")]
    public string? DbSnapshotArn { get; set; }

    /// <summary>The Destination region to place snapshot copy.</summary>
    [JsonPropertyName("destinationRegion")]
    public string? DestinationRegion { get; set; }

    /// <summary>Specifies whether the DB snapshot is encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the name of the database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Specifies the version of the database engine.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Snapshot Identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Provisioned IOPS (I/O operations per second) value of the DB instance at the time of the snapshot.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>KMS key ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>License model information for the restored DB instance.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The name of an option group to associate with the copy of the snapshot.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>he URL that contains a Signature Version 4 signed request.</summary>
    [JsonPropertyName("presignedUrl")]
    public string? PresignedUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>List of AWS Account IDs to share the snapshot with. Use all to make the snapshot public.</summary>
    [JsonPropertyName("sharedAccounts")]
    public IList<string>? SharedAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("snapshotType")]
    public string? SnapshotType { get; set; }

    /// <summary>Snapshot identifier of the source snapshot.</summary>
    [JsonPropertyName("sourceDbSnapshotIdentifier")]
    public string? SourceDbSnapshotIdentifier { get; set; }

    /// <summary>The region that the DB snapshot was created in or copied from.</summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies the storage type associated with DB snapshot.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The external custom Availability Zone.</summary>
    [JsonPropertyName("targetCustomAvailabilityZone")]
    public string? TargetCustomAvailabilityZone { get; set; }

    /// <summary>The Identifier for the snapshot.</summary>
    [JsonPropertyName("targetDbSnapshotIdentifier")]
    public string? TargetDbSnapshotIdentifier { get; set; }

    /// <summary>Provides the VPC ID associated with the DB snapshot.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopyStatusConditions
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

/// <summary>DBSnapshotCopyStatus defines the observed state of DBSnapshotCopy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBSnapshotCopyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DBSnapshotCopyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DBSnapshotCopyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DBSnapshotCopy is the Schema for the DBSnapshotCopys API. Manages an RDS database instance snapshot copy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBSnapshotCopy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DBSnapshotCopySpec>, IStatus<V1beta1DBSnapshotCopyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBSnapshotCopy";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "dbsnapshotcopies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DBSnapshotCopySpec defines the desired state of DBSnapshotCopy</summary>
    [JsonPropertyName("spec")]
    public V1beta1DBSnapshotCopySpec Spec { get; set; }

    /// <summary>DBSnapshotCopyStatus defines the observed state of DBSnapshotCopy.</summary>
    [JsonPropertyName("status")]
    public V1beta1DBSnapshotCopyStatus? Status { get; set; }
}