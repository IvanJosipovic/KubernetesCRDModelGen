using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.upbound.io;
#nullable enable
/// <summary>ContainerRecipe is the Schema for the ContainerRecipes API. Manage an Image Builder Container Recipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerRecipeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerRecipe>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerRecipeList";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "containerrecipes";
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
    public IList<V1beta1ContainerRecipe> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponentComponentArnRefPolicy
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
/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderComponentComponentArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponentComponentArnSelectorPolicy
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
/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponentComponentArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta1ContainerRecipeSpecForProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta1ContainerRecipeSpecForProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ContainerRecipeSpecForProviderComponentParameter>? Parameter { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderInstanceConfigurationBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderInstanceConfigurationBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ContainerRecipeSpecForProviderInstanceConfigurationBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderInstanceConfiguration
{
    /// <summary>Configuration block(s) with block device mappings for the container recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ContainerRecipeSpecForProviderInstanceConfigurationBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>The AMI ID to use as the base image for a container build and test instance. If not specified, Image Builder will use the appropriate ECS-optimized AMI as a base image.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderKmsKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderKmsKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameRefPolicy
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
/// <summary>Reference to a Repository in ecr to populate repositoryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameSelectorPolicy
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
/// <summary>Selector for a Repository in ecr to populate repositoryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProviderTargetRepository
{
    /// <summary>The name of the container repository where the output container image is stored. This name is prefixed by the repository location.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Reference to a Repository in ecr to populate repositoryName.</summary>
    [JsonPropertyName("repositoryNameRef")]
    public V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameRef? RepositoryNameRef { get; set; }

    /// <summary>Selector for a Repository in ecr to populate repositoryName.</summary>
    [JsonPropertyName("repositoryNameSelector")]
    public V1beta1ContainerRecipeSpecForProviderTargetRepositoryRepositoryNameSelector? RepositoryNameSelector { get; set; }

    /// <summary>The service in which this image is registered. Valid values: ECR.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecForProvider
{
    /// <summary>Ordered configuration block(s) with components for the container recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ContainerRecipeSpecForProviderComponent>? Component { get; set; }

    /// <summary>The type of the container to create. Valid values: DOCKER.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>The description of the container recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Dockerfile template used to build the image as an inline data blob.</summary>
    [JsonPropertyName("dockerfileTemplateData")]
    public string? DockerfileTemplateData { get; set; }

    /// <summary>The Amazon S3 URI for the Dockerfile that will be used to build the container image.</summary>
    [JsonPropertyName("dockerfileTemplateUri")]
    public string? DockerfileTemplateUri { get; set; }

    /// <summary>Configuration block used to configure an instance for building and testing container images. Detailed below.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ContainerRecipeSpecForProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>The KMS key used to encrypt the container image.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ContainerRecipeSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ContainerRecipeSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of the container recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The base image for the container recipe.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Specifies the operating system platform when you use a custom base image.</summary>
    [JsonPropertyName("platformOverride")]
    public string? PlatformOverride { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The destination repository for the container image. Detailed below.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1ContainerRecipeSpecForProviderTargetRepository>? TargetRepository { get; set; }

    /// <summary>Version of the container recipe.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponentComponentArnRefPolicy
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
/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderComponentComponentArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponentComponentArnSelectorPolicy
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
/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponentComponentArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta1ContainerRecipeSpecInitProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta1ContainerRecipeSpecInitProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ContainerRecipeSpecInitProviderComponentParameter>? Parameter { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderInstanceConfigurationBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderInstanceConfigurationBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ContainerRecipeSpecInitProviderInstanceConfigurationBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderInstanceConfiguration
{
    /// <summary>Configuration block(s) with block device mappings for the container recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ContainerRecipeSpecInitProviderInstanceConfigurationBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>The AMI ID to use as the base image for a container build and test instance. If not specified, Image Builder will use the appropriate ECS-optimized AMI as a base image.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderKmsKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderKmsKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameRefPolicy
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
/// <summary>Reference to a Repository in ecr to populate repositoryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameSelectorPolicy
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
/// <summary>Selector for a Repository in ecr to populate repositoryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProviderTargetRepository
{
    /// <summary>The name of the container repository where the output container image is stored. This name is prefixed by the repository location.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Reference to a Repository in ecr to populate repositoryName.</summary>
    [JsonPropertyName("repositoryNameRef")]
    public V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameRef? RepositoryNameRef { get; set; }

    /// <summary>Selector for a Repository in ecr to populate repositoryName.</summary>
    [JsonPropertyName("repositoryNameSelector")]
    public V1beta1ContainerRecipeSpecInitProviderTargetRepositoryRepositoryNameSelector? RepositoryNameSelector { get; set; }

    /// <summary>The service in which this image is registered. Valid values: ECR.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecInitProvider
{
    /// <summary>Ordered configuration block(s) with components for the container recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ContainerRecipeSpecInitProviderComponent>? Component { get; set; }

    /// <summary>The type of the container to create. Valid values: DOCKER.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>The description of the container recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Dockerfile template used to build the image as an inline data blob.</summary>
    [JsonPropertyName("dockerfileTemplateData")]
    public string? DockerfileTemplateData { get; set; }

    /// <summary>The Amazon S3 URI for the Dockerfile that will be used to build the container image.</summary>
    [JsonPropertyName("dockerfileTemplateUri")]
    public string? DockerfileTemplateUri { get; set; }

    /// <summary>Configuration block used to configure an instance for building and testing container images. Detailed below.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ContainerRecipeSpecInitProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>The KMS key used to encrypt the container image.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ContainerRecipeSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ContainerRecipeSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The name of the container recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The base image for the container recipe.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Specifies the operating system platform when you use a custom base image.</summary>
    [JsonPropertyName("platformOverride")]
    public string? PlatformOverride { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The destination repository for the container image. Detailed below.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1ContainerRecipeSpecInitProviderTargetRepository>? TargetRepository { get; set; }

    /// <summary>Version of the container recipe.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecProviderConfigRefPolicy
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
public partial class V1beta1ContainerRecipeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerRecipeSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpecWriteConnectionSecretToRef
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
/// <summary>ContainerRecipeSpec defines the desired state of ContainerRecipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContainerRecipeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContainerRecipeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerRecipeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerRecipeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ContainerRecipeStatusAtProviderComponentParameter>? Parameter { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderInstanceConfigurationBlockDeviceMappingEbs
{
    /// <summary>Whether to delete the volume on termination. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Whether to encrypt the volume. Defaults to unset, which is the value inherited from the parent image.</summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>Number of Input/Output (I/O) operations per second to provision for an io1 or io2 volume.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key for encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Identifier of the EC2 Volume Snapshot.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>For GP3 volumes only. The throughput in MiB/s that the volume supports.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume, in GiB.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of the volume. For example, gp2 or io2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderInstanceConfigurationBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ContainerRecipeStatusAtProviderInstanceConfigurationBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderInstanceConfiguration
{
    /// <summary>Configuration block(s) with block device mappings for the container recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ContainerRecipeStatusAtProviderInstanceConfigurationBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>The AMI ID to use as the base image for a container build and test instance. If not specified, Image Builder will use the appropriate ECS-optimized AMI as a base image.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProviderTargetRepository
{
    /// <summary>The name of the container repository where the output container image is stored. This name is prefixed by the repository location.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>The service in which this image is registered. Valid values: ECR.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Ordered configuration block(s) with components for the container recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ContainerRecipeStatusAtProviderComponent>? Component { get; set; }

    /// <summary>The type of the container to create. Valid values: DOCKER.</summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>Date the container recipe was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>The description of the container recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Dockerfile template used to build the image as an inline data blob.</summary>
    [JsonPropertyName("dockerfileTemplateData")]
    public string? DockerfileTemplateData { get; set; }

    /// <summary>The Amazon S3 URI for the Dockerfile that will be used to build the container image.</summary>
    [JsonPropertyName("dockerfileTemplateUri")]
    public string? DockerfileTemplateUri { get; set; }

    /// <summary>A flag that indicates if the target container is encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block used to configure an instance for building and testing container images. Detailed below.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ContainerRecipeStatusAtProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>The KMS key used to encrypt the container image.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The name of the container recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the container recipe.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The base image for the container recipe.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Platform of the container recipe.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Specifies the operating system platform when you use a custom base image.</summary>
    [JsonPropertyName("platformOverride")]
    public string? PlatformOverride { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The destination repository for the container image. Detailed below.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1ContainerRecipeStatusAtProviderTargetRepository>? TargetRepository { get; set; }

    /// <summary>Version of the container recipe.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatusConditions
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
/// <summary>ContainerRecipeStatus defines the observed state of ContainerRecipe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerRecipeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ContainerRecipeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerRecipeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ContainerRecipe is the Schema for the ContainerRecipes API. Manage an Image Builder Container Recipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerRecipe : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerRecipeSpec>, IStatus<V1beta1ContainerRecipeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerRecipe";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "containerrecipes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerRecipeSpec defines the desired state of ContainerRecipe</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContainerRecipeSpec Spec { get; set; }

    /// <summary>ContainerRecipeStatus defines the observed state of ContainerRecipe.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerRecipeStatus? Status { get; set; }
}
#nullable disable
