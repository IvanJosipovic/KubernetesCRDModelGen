using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.m.upbound.io;
/// <summary>DirectoryBucket is the Schema for the DirectoryBuckets API. Provides an Amazon S3 Express directory bucket resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DirectoryBucketList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DirectoryBucket>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DirectoryBucketList";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "directorybuckets";
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
    public IList<V1beta1DirectoryBucket> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpecForProviderLocation
{
    /// <summary>Availability Zone ID or Local Zone ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Location type. Valid values: AvailabilityZone, LocalZone.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpecForProvider
{
    /// <summary>Data redundancy. Valid values: SingleAvailabilityZone, SingleLocalZone. The default value depends on the value of the location.type attribute.</summary>
    [JsonPropertyName("dataRedundancy")]
    public string? DataRedundancy { get; set; }

    /// <summary>Boolean that indicates all objects should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Bucket location. See Location below for more details.</summary>
    [JsonPropertyName("location")]
    public IList<V1beta1DirectoryBucketSpecForProviderLocation>? Location { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Bucket type. Valid values: Directory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpecInitProviderLocation
{
    /// <summary>Availability Zone ID or Local Zone ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Location type. Valid values: AvailabilityZone, LocalZone.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpecInitProvider
{
    /// <summary>Data redundancy. Valid values: SingleAvailabilityZone, SingleLocalZone. The default value depends on the value of the location.type attribute.</summary>
    [JsonPropertyName("dataRedundancy")]
    public string? DataRedundancy { get; set; }

    /// <summary>Boolean that indicates all objects should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Bucket location. See Location below for more details.</summary>
    [JsonPropertyName("location")]
    public IList<V1beta1DirectoryBucketSpecInitProviderLocation>? Location { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Bucket type. Valid values: Directory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpecProviderConfigRef
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
public partial class V1beta1DirectoryBucketSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DirectoryBucketSpec defines the desired state of DirectoryBucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DirectoryBucketSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DirectoryBucketSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DirectoryBucketSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DirectoryBucketSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketStatusAtProviderLocation
{
    /// <summary>Availability Zone ID or Local Zone ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Location type. Valid values: AvailabilityZone, LocalZone.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketStatusAtProvider
{
    /// <summary>ARN of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Data redundancy. Valid values: SingleAvailabilityZone, SingleLocalZone. The default value depends on the value of the location.type attribute.</summary>
    [JsonPropertyName("dataRedundancy")]
    public string? DataRedundancy { get; set; }

    /// <summary>Boolean that indicates all objects should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>(Deprecated, use bucket instead) Name of the bucket.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Bucket location. See Location below for more details.</summary>
    [JsonPropertyName("location")]
    public IList<V1beta1DirectoryBucketStatusAtProviderLocation>? Location { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Bucket type. Valid values: Directory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketStatusConditions
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

/// <summary>DirectoryBucketStatus defines the observed state of DirectoryBucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryBucketStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DirectoryBucketStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DirectoryBucketStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DirectoryBucket is the Schema for the DirectoryBuckets API. Provides an Amazon S3 Express directory bucket resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DirectoryBucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DirectoryBucketSpec>, IStatus<V1beta1DirectoryBucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DirectoryBucket";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "directorybuckets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DirectoryBucketSpec defines the desired state of DirectoryBucket</summary>
    [JsonPropertyName("spec")]
    public V1beta1DirectoryBucketSpec Spec { get; set; }

    /// <summary>DirectoryBucketStatus defines the observed state of DirectoryBucket.</summary>
    [JsonPropertyName("status")]
    public V1beta1DirectoryBucketStatus? Status { get; set; }
}