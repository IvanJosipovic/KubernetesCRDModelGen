using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.evidently.aws.upbound.io;
#nullable enable
/// <summary>Project is the Schema for the Projects API. Provides a CloudWatch Evidently Project resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Project>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProjectList";
    public const string KubeGroup = "evidently.aws.upbound.io";
    public const string KubePluralName = "projects";
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
    public IList<V1beta1Project> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderDataDeliveryCloudwatchLogs
{
    /// <summary>The name of the log group where the project stores evaluation events.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderDataDeliveryS3Destination
{
    /// <summary>The name of the bucket in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The bucket prefix in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProviderDataDelivery
{
    /// <summary>A block that defines the CloudWatch Log Group that stores the evaluation events. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ProjectSpecForProviderDataDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>A block that defines the S3 bucket and prefix that stores the evaluation events. See below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1ProjectSpecForProviderDataDeliveryS3Destination>? S3Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecForProvider
{
    /// <summary>A block that contains information about where Evidently is to store evaluation events for longer term storage, if you choose to do so. If you choose not to store these events, Evidently deletes them after using them to produce metrics and other experiment results that you can view. See below.</summary>
    [JsonPropertyName("dataDelivery")]
    public IList<V1beta1ProjectSpecForProviderDataDelivery>? DataDelivery { get; set; }

    /// <summary>Specifies the description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A name for the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderDataDeliveryCloudwatchLogs
{
    /// <summary>The name of the log group where the project stores evaluation events.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderDataDeliveryS3Destination
{
    /// <summary>The name of the bucket in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The bucket prefix in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProviderDataDelivery
{
    /// <summary>A block that defines the CloudWatch Log Group that stores the evaluation events. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ProjectSpecInitProviderDataDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>A block that defines the S3 bucket and prefix that stores the evaluation events. See below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1ProjectSpecInitProviderDataDeliveryS3Destination>? S3Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecInitProvider
{
    /// <summary>A block that contains information about where Evidently is to store evaluation events for longer term storage, if you choose to do so. If you choose not to store these events, Evidently deletes them after using them to produce metrics and other experiment results that you can view. See below.</summary>
    [JsonPropertyName("dataDelivery")]
    public IList<V1beta1ProjectSpecInitProviderDataDelivery>? DataDelivery { get; set; }

    /// <summary>Specifies the description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A name for the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecProviderConfigRefPolicy
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
public partial class V1beta1ProjectSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ProjectSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecWriteConnectionSecretToRef
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
/// <summary>ProjectSpec defines the desired state of Project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ProjectSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ProjectSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ProjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ProjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderDataDeliveryCloudwatchLogs
{
    /// <summary>The name of the log group where the project stores evaluation events.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderDataDeliveryS3Destination
{
    /// <summary>The name of the bucket in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The bucket prefix in which Evidently stores evaluation events.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProviderDataDelivery
{
    /// <summary>A block that defines the CloudWatch Log Group that stores the evaluation events. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ProjectStatusAtProviderDataDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>A block that defines the S3 bucket and prefix that stores the evaluation events. See below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1ProjectStatusAtProviderDataDeliveryS3Destination>? S3Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusAtProvider
{
    /// <summary>The number of ongoing experiments currently in the project.</summary>
    [JsonPropertyName("activeExperimentCount")]
    public double? ActiveExperimentCount { get; set; }

    /// <summary>The number of ongoing launches currently in the project.</summary>
    [JsonPropertyName("activeLaunchCount")]
    public double? ActiveLaunchCount { get; set; }

    /// <summary>The ARN of the project.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The date and time that the project is created.</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>A block that contains information about where Evidently is to store evaluation events for longer term storage, if you choose to do so. If you choose not to store these events, Evidently deletes them after using them to produce metrics and other experiment results that you can view. See below.</summary>
    [JsonPropertyName("dataDelivery")]
    public IList<V1beta1ProjectStatusAtProviderDataDelivery>? DataDelivery { get; set; }

    /// <summary>Specifies the description of the project.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The number of experiments currently in the project. This includes all experiments that have been created and not deleted, whether they are ongoing or not.</summary>
    [JsonPropertyName("experimentCount")]
    public double? ExperimentCount { get; set; }

    /// <summary>The number of features currently in the project.</summary>
    [JsonPropertyName("featureCount")]
    public double? FeatureCount { get; set; }

    /// <summary>The ID has the same value as the arn of the project.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date and time that the project was most recently updated.</summary>
    [JsonPropertyName("lastUpdatedTime")]
    public string? LastUpdatedTime { get; set; }

    /// <summary>The number of launches currently in the project. This includes all launches that have been created and not deleted, whether they are ongoing or not.</summary>
    [JsonPropertyName("launchCount")]
    public double? LaunchCount { get; set; }

    /// <summary>A name for the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The current state of the project. Valid values are AVAILABLE and UPDATING.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusConditions
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
/// <summary>ProjectStatus defines the observed state of Project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ProjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProjectStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Project is the Schema for the Projects API. Provides a CloudWatch Evidently Project resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Project : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProjectSpec>, IStatus<V1beta1ProjectStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Project";
    public const string KubeGroup = "evidently.aws.upbound.io";
    public const string KubePluralName = "projects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProjectSpec defines the desired state of Project</summary>
    [JsonPropertyName("spec")]
    public V1beta1ProjectSpec Spec { get; set; }

    /// <summary>ProjectStatus defines the observed state of Project.</summary>
    [JsonPropertyName("status")]
    public V1beta1ProjectStatus? Status { get; set; }
}
#nullable disable
