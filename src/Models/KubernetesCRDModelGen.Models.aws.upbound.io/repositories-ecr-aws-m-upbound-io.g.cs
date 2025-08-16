using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecr.aws.m.upbound.io;
/// <summary>Repository is the Schema for the Repositorys API. Provides an Elastic Container Registry Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Repository>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RepositoryList";
    public const string KubeGroup = "ecr.aws.m.upbound.io";
    public const string KubePluralName = "repositories";
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
    public IList<V1beta1Repository> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeySelector
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
    public V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for the repository. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1RepositorySpecForProviderEncryptionConfigurationKmsKeySelector? KmsKeySelector { get; set; }
}

/// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProviderImageScanningConfiguration
{
    /// <summary>Indicates whether images are scanned after being pushed to the repository (true) or not scanned (false).</summary>
    [JsonPropertyName("scanOnPush")]
    public bool? ScanOnPush { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecForProvider
{
    /// <summary>Encryption configuration for the repository. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositorySpecForProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>If true, will delete the repository even if it contains images. Defaults to false.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1RepositorySpecForProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>The tag mutability setting for the repository. Must be one of: MUTABLE or IMMUTABLE. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeySelector
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
    public V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for the repository. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1RepositorySpecInitProviderEncryptionConfigurationKmsKeySelector? KmsKeySelector { get; set; }
}

/// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProviderImageScanningConfiguration
{
    /// <summary>Indicates whether images are scanned after being pushed to the repository (true) or not scanned (false).</summary>
    [JsonPropertyName("scanOnPush")]
    public bool? ScanOnPush { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecInitProvider
{
    /// <summary>Encryption configuration for the repository. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositorySpecInitProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>If true, will delete the repository even if it contains images. Defaults to false.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1RepositorySpecInitProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>The tag mutability setting for the repository. Must be one of: MUTABLE or IMMUTABLE. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpecProviderConfigRef
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
public partial class V1beta1RepositorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RepositorySpec defines the desired state of Repository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositorySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RepositorySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RepositorySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RepositorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RepositorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryStatusAtProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for the repository. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryStatusAtProviderImageScanningConfiguration
{
    /// <summary>Indicates whether images are scanned after being pushed to the repository (true) or not scanned (false).</summary>
    [JsonPropertyName("scanOnPush")]
    public bool? ScanOnPush { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryStatusAtProvider
{
    /// <summary>Full ARN of the repository.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Encryption configuration for the repository. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositoryStatusAtProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>If true, will delete the repository even if it contains images. Defaults to false.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block that defines image scanning configuration for the repository. By default, image scanning must be manually triggered. See the ECR User Guide for more information about image scanning.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1RepositoryStatusAtProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>The tag mutability setting for the repository. Must be one of: MUTABLE or IMMUTABLE. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The registry ID where the repository was created.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }

    /// <summary>The URL of the repository (in the form aws_account_id.dkr.ecr.region.amazonaws.com/repositoryName).</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryStatusConditions
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

/// <summary>RepositoryStatus defines the observed state of Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RepositoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Repository is the Schema for the Repositorys API. Provides an Elastic Container Registry Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Repository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RepositorySpec>, IStatus<V1beta1RepositoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Repository";
    public const string KubeGroup = "ecr.aws.m.upbound.io";
    public const string KubePluralName = "repositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RepositorySpec defines the desired state of Repository</summary>
    [JsonPropertyName("spec")]
    public V1beta1RepositorySpec Spec { get; set; }

    /// <summary>RepositoryStatus defines the observed state of Repository.</summary>
    [JsonPropertyName("status")]
    public V1beta1RepositoryStatus? Status { get; set; }
}