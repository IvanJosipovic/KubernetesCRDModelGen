using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ivs.aws.m.upbound.io;
#nullable enable
/// <summary>RecordingConfiguration is the Schema for the RecordingConfigurations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecordingConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RecordingConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordingConfigurationList";
    public const string KubeGroup = "ivs.aws.m.upbound.io";
    public const string KubePluralName = "recordingconfigurations";
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
    public IList<V1beta1RecordingConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>S3 destination configuration where recorded videos will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecForProviderDestinationConfigurationS3
{
    /// <summary>S3 bucket name where recorded videos will be stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecForProviderDestinationConfiguration
{
    /// <summary>S3 destination configuration where recorded videos will be stored.</summary>
    [JsonPropertyName("s3")]
    public V1beta1RecordingConfigurationSpecForProviderDestinationConfigurationS3? S3 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecForProviderThumbnailConfiguration
{
    /// <summary>Thumbnail recording mode. Valid values: DISABLED, INTERVAL.</summary>
    [JsonPropertyName("recordingMode")]
    public string? RecordingMode { get; set; }

    /// <summary>The targeted thumbnail-generation interval in seconds.</summary>
    [JsonPropertyName("targetIntervalSeconds")]
    public double? TargetIntervalSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecForProvider
{
    /// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
    [JsonPropertyName("destinationConfiguration")]
    public V1beta1RecordingConfigurationSpecForProviderDestinationConfiguration? DestinationConfiguration { get; set; }

    /// <summary>Recording Configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If a broadcast disconnects and then reconnects within the specified interval, the multiple streams will be considered a single broadcast and merged together.</summary>
    [JsonPropertyName("recordingReconnectWindowSeconds")]
    public double? RecordingReconnectWindowSeconds { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
    [JsonPropertyName("thumbnailConfiguration")]
    public V1beta1RecordingConfigurationSpecForProviderThumbnailConfiguration? ThumbnailConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>S3 destination configuration where recorded videos will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecInitProviderDestinationConfigurationS3
{
    /// <summary>S3 bucket name where recorded videos will be stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecInitProviderDestinationConfiguration
{
    /// <summary>S3 destination configuration where recorded videos will be stored.</summary>
    [JsonPropertyName("s3")]
    public V1beta1RecordingConfigurationSpecInitProviderDestinationConfigurationS3? S3 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecInitProviderThumbnailConfiguration
{
    /// <summary>Thumbnail recording mode. Valid values: DISABLED, INTERVAL.</summary>
    [JsonPropertyName("recordingMode")]
    public string? RecordingMode { get; set; }

    /// <summary>The targeted thumbnail-generation interval in seconds.</summary>
    [JsonPropertyName("targetIntervalSeconds")]
    public double? TargetIntervalSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecInitProvider
{
    /// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
    [JsonPropertyName("destinationConfiguration")]
    public V1beta1RecordingConfigurationSpecInitProviderDestinationConfiguration? DestinationConfiguration { get; set; }

    /// <summary>Recording Configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If a broadcast disconnects and then reconnects within the specified interval, the multiple streams will be considered a single broadcast and merged together.</summary>
    [JsonPropertyName("recordingReconnectWindowSeconds")]
    public double? RecordingReconnectWindowSeconds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
    [JsonPropertyName("thumbnailConfiguration")]
    public V1beta1RecordingConfigurationSpecInitProviderThumbnailConfiguration? ThumbnailConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RecordingConfigurationSpec defines the desired state of RecordingConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RecordingConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RecordingConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RecordingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RecordingConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>S3 destination configuration where recorded videos will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatusAtProviderDestinationConfigurationS3
{
    /// <summary>S3 bucket name where recorded videos will be stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatusAtProviderDestinationConfiguration
{
    /// <summary>S3 destination configuration where recorded videos will be stored.</summary>
    [JsonPropertyName("s3")]
    public V1beta1RecordingConfigurationStatusAtProviderDestinationConfigurationS3? S3 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatusAtProviderThumbnailConfiguration
{
    /// <summary>Thumbnail recording mode. Valid values: DISABLED, INTERVAL.</summary>
    [JsonPropertyName("recordingMode")]
    public string? RecordingMode { get; set; }

    /// <summary>The targeted thumbnail-generation interval in seconds.</summary>
    [JsonPropertyName("targetIntervalSeconds")]
    public double? TargetIntervalSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatusAtProvider
{
    /// <summary>ARN of the Recording Configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Object containing destination configuration for where recorded video will be stored.</summary>
    [JsonPropertyName("destinationConfiguration")]
    public V1beta1RecordingConfigurationStatusAtProviderDestinationConfiguration? DestinationConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Recording Configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If a broadcast disconnects and then reconnects within the specified interval, the multiple streams will be considered a single broadcast and merged together.</summary>
    [JsonPropertyName("recordingReconnectWindowSeconds")]
    public double? RecordingReconnectWindowSeconds { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The current state of the Recording Configuration.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Object containing information to enable/disable the recording of thumbnails for a live session and modify the interval at which thumbnails are generated for the live session.</summary>
    [JsonPropertyName("thumbnailConfiguration")]
    public V1beta1RecordingConfigurationStatusAtProviderThumbnailConfiguration? ThumbnailConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatusConditions
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
/// <summary>RecordingConfigurationStatus defines the observed state of RecordingConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordingConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RecordingConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RecordingConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RecordingConfiguration is the Schema for the RecordingConfigurations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecordingConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RecordingConfigurationSpec>, IStatus<V1beta1RecordingConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordingConfiguration";
    public const string KubeGroup = "ivs.aws.m.upbound.io";
    public const string KubePluralName = "recordingconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordingConfigurationSpec defines the desired state of RecordingConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1RecordingConfigurationSpec Spec { get; set; }

    /// <summary>RecordingConfigurationStatus defines the observed state of RecordingConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1RecordingConfigurationStatus? Status { get; set; }
}
#nullable disable
