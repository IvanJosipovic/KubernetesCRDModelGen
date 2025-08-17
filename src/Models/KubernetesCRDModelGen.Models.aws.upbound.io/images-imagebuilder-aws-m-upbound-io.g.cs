using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.m.upbound.io;
#nullable enable
/// <summary>Image is the Schema for the Images API. Manages an Image Builder Image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Image>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageList";
    public const string KubeGroup = "imagebuilder.aws.m.upbound.io";
    public const string KubePluralName = "images";
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
    public IList<V1beta1Image> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderDistributionConfigurationArnRefPolicy
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
/// <summary>Reference to a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderDistributionConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecForProviderDistributionConfigurationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderDistributionConfigurationArnSelectorPolicy
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
/// <summary>Selector for a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderDistributionConfigurationArnSelector
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
    public V1beta1ImageSpecForProviderDistributionConfigurationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageRecipeArnRefPolicy
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
/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecForProviderImageRecipeArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageRecipeArnSelectorPolicy
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
/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageRecipeArnSelector
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
    public V1beta1ImageSpecForProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with ECR configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Set of tags for Image Builder to apply to the output container image that that Amazon Inspector scans.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the container repository that Amazon Inspector scans to identify findings for your container images.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta1ImageSpecForProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Indicates whether Image Builder keeps a snapshot of the vulnerability scans that Amazon Inspector runs against the build instance when you create a new image. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderInfrastructureConfigurationArnRefPolicy
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
/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecForProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderInfrastructureConfigurationArnSelectorPolicy
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
/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderInfrastructureConfigurationArnSelector
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
    public V1beta1ImageSpecForProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageSpecForProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecForProvider
{
    /// <summary>- Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Reference to a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
    [JsonPropertyName("distributionConfigurationArnRef")]
    public V1beta1ImageSpecForProviderDistributionConfigurationArnRef? DistributionConfigurationArnRef { get; set; }

    /// <summary>Selector for a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
    [JsonPropertyName("distributionConfigurationArnSelector")]
    public V1beta1ImageSpecForProviderDistributionConfigurationArnSelector? DistributionConfigurationArnSelector { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta1ImageSpecForProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta1ImageSpecForProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1ImageSpecForProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta1ImageSpecForProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta1ImageSpecForProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta1ImageSpecForProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta1ImageSpecForProviderWorkflow>? Workflow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderDistributionConfigurationArnRefPolicy
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
/// <summary>Reference to a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderDistributionConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecInitProviderDistributionConfigurationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderDistributionConfigurationArnSelectorPolicy
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
/// <summary>Selector for a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderDistributionConfigurationArnSelector
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
    public V1beta1ImageSpecInitProviderDistributionConfigurationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageRecipeArnRefPolicy
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
/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecInitProviderImageRecipeArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageRecipeArnSelectorPolicy
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
/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageRecipeArnSelector
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
    public V1beta1ImageSpecInitProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with ECR configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Set of tags for Image Builder to apply to the output container image that that Amazon Inspector scans.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the container repository that Amazon Inspector scans to identify findings for your container images.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta1ImageSpecInitProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Indicates whether Image Builder keeps a snapshot of the vulnerability scans that Amazon Inspector runs against the build instance when you create a new image. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderInfrastructureConfigurationArnRefPolicy
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
/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageSpecInitProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderInfrastructureConfigurationArnSelectorPolicy
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
/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderInfrastructureConfigurationArnSelector
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
    public V1beta1ImageSpecInitProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageSpecInitProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecInitProvider
{
    /// <summary>- Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Reference to a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
    [JsonPropertyName("distributionConfigurationArnRef")]
    public V1beta1ImageSpecInitProviderDistributionConfigurationArnRef? DistributionConfigurationArnRef { get; set; }

    /// <summary>Selector for a DistributionConfiguration in imagebuilder to populate distributionConfigurationArn.</summary>
    [JsonPropertyName("distributionConfigurationArnSelector")]
    public V1beta1ImageSpecInitProviderDistributionConfigurationArnSelector? DistributionConfigurationArnSelector { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta1ImageSpecInitProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta1ImageSpecInitProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1ImageSpecInitProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta1ImageSpecInitProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta1ImageSpecInitProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta1ImageSpecInitProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta1ImageSpecInitProviderWorkflow>? Workflow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpecProviderConfigRef
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
public partial class V1beta1ImageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageSpec defines the desired state of Image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ImageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ImageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ImageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ImageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with ECR configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Set of tags for Image Builder to apply to the output container image that that Amazon Inspector scans.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the container repository that Amazon Inspector scans to identify findings for your container images.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta1ImageStatusAtProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Indicates whether Image Builder keeps a snapshot of the vulnerability scans that Amazon Inspector runs against the build instance when you create a new image. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderOutputResourcesAmis
{
    /// <summary>Account identifier of the AMI.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Description of the AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the AMI.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderOutputResourcesContainers
{
    /// <summary>Set of URIs for created containers.</summary>
    [JsonPropertyName("imageUris")]
    public IList<string>? ImageUris { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderOutputResources
{
    /// <summary>Set of objects with each Amazon Machine Image (AMI) created.</summary>
    [JsonPropertyName("amis")]
    public IList<V1beta1ImageStatusAtProviderOutputResourcesAmis>? Amis { get; set; }

    /// <summary>Set of objects with each container image created and stored in the output repository.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1ImageStatusAtProviderOutputResourcesContainers>? Containers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageStatusAtProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the image.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>- Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Date the image was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta1ImageStatusAtProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta1ImageStatusAtProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Name of the AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operating System version of the image.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }

    /// <summary>List of objects with resources created by the image.</summary>
    [JsonPropertyName("outputResources")]
    public IList<V1beta1ImageStatusAtProviderOutputResources>? OutputResources { get; set; }

    /// <summary>Platform of the image.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Version of the image.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta1ImageStatusAtProviderWorkflow>? Workflow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatusConditions
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
/// <summary>ImageStatus defines the observed state of Image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ImageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ImageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Image is the Schema for the Images API. Manages an Image Builder Image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Image : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImageSpec>, IStatus<V1beta1ImageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Image";
    public const string KubeGroup = "imagebuilder.aws.m.upbound.io";
    public const string KubePluralName = "images";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageSpec defines the desired state of Image</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImageSpec Spec { get; set; }

    /// <summary>ImageStatus defines the observed state of Image.</summary>
    [JsonPropertyName("status")]
    public V1beta1ImageStatus? Status { get; set; }
}
#nullable disable
