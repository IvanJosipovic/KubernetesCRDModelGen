using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageRecipeArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public IList<V1beta1ImagePipelineSpecForProviderImageScanningConfigurationEcrConfiguration>? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, "Etc/UTC", "America/Los_Angeles" in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecForProvider
{
    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta1ImagePipelineSpecForProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public IList<V1beta1ImagePipelineSpecForProviderImageScanningConfiguration>? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public IList<V1beta1ImagePipelineSpecForProviderImageTestsConfiguration>? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta1ImagePipelineSpecForProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ImagePipelineSpecForProviderSchedule>? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public IList<V1beta1ImagePipelineSpecInitProviderImageScanningConfigurationEcrConfiguration>? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, "Etc/UTC", "America/Los_Angeles" in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecInitProvider
{
    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta1ImagePipelineSpecInitProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public IList<V1beta1ImagePipelineSpecInitProviderImageScanningConfiguration>? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public IList<V1beta1ImagePipelineSpecInitProviderImageTestsConfiguration>? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta1ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ImagePipelineSpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ImagePipelineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ImagePipelineSpec defines the desired state of ImagePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImagePipelineSpecDeletionPolicyEnum>))]
    public V1beta1ImagePipelineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ImagePipelineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ImagePipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ImagePipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ImagePipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ImagePipelineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ImagePipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusAtProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusAtProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public IList<V1beta1ImagePipelineStatusAtProviderImageScanningConfigurationEcrConfiguration>? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusAtProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusAtProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, "Etc/UTC", "America/Los_Angeles" in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the image pipeline.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Date the image pipeline was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Date the image pipeline was last run.</summary>
    [JsonPropertyName("dateLastRun")]
    public string? DateLastRun { get; set; }

    /// <summary>Date the image pipeline will run next.</summary>
    [JsonPropertyName("dateNextRun")]
    public string? DateNextRun { get; set; }

    /// <summary>Date the image pipeline was updated.</summary>
    [JsonPropertyName("dateUpdated")]
    public string? DateUpdated { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public IList<V1beta1ImagePipelineStatusAtProviderImageScanningConfiguration>? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public IList<V1beta1ImagePipelineStatusAtProviderImageTestsConfiguration>? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Platform of the image pipeline.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ImagePipelineStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatusConditions
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

/// <summary>ImagePipelineStatus defines the observed state of ImagePipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImagePipelineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ImagePipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ImagePipelineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ImagePipeline is the Schema for the ImagePipelines API. Manages an Image Builder Image Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ImagePipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImagePipelineSpec>, IStatus<V1beta1ImagePipelineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImagePipeline";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagepipelines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImagePipelineSpec defines the desired state of ImagePipeline</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImagePipelineSpec Spec { get; set; }

    /// <summary>ImagePipelineStatus defines the observed state of ImagePipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta1ImagePipelineStatus? Status { get; set; }
}