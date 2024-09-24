using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>Specifies maximum number of nodes allocated to the instance. If set, this number should be greater than or equal to min_nodes.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>Specifies maximum number of processing units allocated to the instance. If set, this number should be multiples of 1000 and be greater than or equal to min_processing_units.</summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>Specifies number of nodes allocated to the instance. If set, this number should be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>Specifies minimum number of processing units allocated to the instance. If set, this number should be multiples of 1000.</summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>Specifies the target high priority cpu utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization)..</summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>Specifies the target storage utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization).</summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutoscalingConfig
{
    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events. Users can define the minimum and maximum compute capacity allocated to the instance, and the autoscaler will only scale within that range. Users can either use nodes or processing units to specify the limits, but should use the same unit to set both the min_limit and max_limit. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingLimits")]
    public IList<V1beta1InstanceSpecForProviderAutoscalingConfigAutoscalingLimits>? AutoscalingLimits { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("autoscalingTargets")]
    public IList<V1beta1InstanceSpecForProviderAutoscalingConfigAutoscalingTargets>? AutoscalingTargets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is enabled, num_nodes and processing_units are treated as, OUTPUT_ONLY fields and reflect the current compute capacity allocated to the instance. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1InstanceSpecForProviderAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>The name of the instance's configuration (similar but not quite the same as a region) which defines the geographic placement and replication of your databases in this instance. It determines where your data is stored. Values are typically of the form regional-europe-west1 , us-central etc. In order to obtain a valid list please consult the Configuration section of the docs.</summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters in length.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>When deleting a spanner instance, this boolean option will delete all backups of this instance. This must be set to true if you created a backup manually in the console.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>Specifies maximum number of nodes allocated to the instance. If set, this number should be greater than or equal to min_nodes.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>Specifies maximum number of processing units allocated to the instance. If set, this number should be multiples of 1000 and be greater than or equal to min_processing_units.</summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>Specifies number of nodes allocated to the instance. If set, this number should be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>Specifies minimum number of processing units allocated to the instance. If set, this number should be multiples of 1000.</summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>Specifies the target high priority cpu utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization)..</summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>Specifies the target storage utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization).</summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutoscalingConfig
{
    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events. Users can define the minimum and maximum compute capacity allocated to the instance, and the autoscaler will only scale within that range. Users can either use nodes or processing units to specify the limits, but should use the same unit to set both the min_limit and max_limit. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingLimits")]
    public IList<V1beta1InstanceSpecInitProviderAutoscalingConfigAutoscalingLimits>? AutoscalingLimits { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("autoscalingTargets")]
    public IList<V1beta1InstanceSpecInitProviderAutoscalingConfigAutoscalingTargets>? AutoscalingTargets { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is enabled, num_nodes and processing_units are treated as, OUTPUT_ONLY fields and reflect the current compute capacity allocated to the instance. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1InstanceSpecInitProviderAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>The name of the instance's configuration (similar but not quite the same as a region) which defines the geographic placement and replication of your databases in this instance. It determines where your data is stored. Values are typically of the form regional-europe-west1 , us-central etc. In order to obtain a valid list please consult the Configuration section of the docs.</summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters in length.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>When deleting a spanner instance, this boolean option will delete all backups of this instance. This must be set to true if you created a backup manually in the console.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1InstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1InstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1InstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecDeletionPolicyEnum>))]
    public V1beta1InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1InstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>Specifies maximum number of nodes allocated to the instance. If set, this number should be greater than or equal to min_nodes.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>Specifies maximum number of processing units allocated to the instance. If set, this number should be multiples of 1000 and be greater than or equal to min_processing_units.</summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>Specifies number of nodes allocated to the instance. If set, this number should be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>Specifies minimum number of processing units allocated to the instance. If set, this number should be multiples of 1000.</summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>Specifies the target high priority cpu utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization)..</summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>Specifies the target storage utilization percentage that the autoscaler should be trying to achieve for the instance. This number is on a scale from 0 (no utilization) to 100 (full utilization).</summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutoscalingConfig
{
    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events. Users can define the minimum and maximum compute capacity allocated to the instance, and the autoscaler will only scale within that range. Users can either use nodes or processing units to specify the limits, but should use the same unit to set both the min_limit and max_limit. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingLimits")]
    public IList<V1beta1InstanceStatusAtProviderAutoscalingConfigAutoscalingLimits>? AutoscalingLimits { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("autoscalingTargets")]
    public IList<V1beta1InstanceStatusAtProviderAutoscalingConfigAutoscalingTargets>? AutoscalingTargets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>The autoscaling configuration. Autoscaling is enabled if this field is set. When autoscaling is enabled, num_nodes and processing_units are treated as, OUTPUT_ONLY fields and reflect the current compute capacity allocated to the instance. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1InstanceStatusAtProviderAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>The name of the instance's configuration (similar but not quite the same as a region) which defines the geographic placement and replication of your databases in this instance. It determines where your data is stored. Values are typically of the form regional-europe-west1 , us-central etc. In order to obtain a valid list please consult the Configuration section of the docs.</summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters in length.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>When deleting a spanner instance, this boolean option will delete all backups of this instance. This must be set to true if you created a backup manually in the console.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Instance status: CREATING or READY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. An isolated set of Cloud Spanner resources on which databases can be hosted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "spanner.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}