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
/// <summary>DistributionConfiguration is the Schema for the DistributionConfigurations API. Manage an Image Builder Distribution Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DistributionConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DistributionConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DistributionConfigurationList";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "distributionconfigurations";
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
    public IList<V1beta1DistributionConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionAmiDistributionConfigurationLaunchPermission
{
    /// <summary>Set of AWS Organization ARNs to assign.</summary>
    [JsonPropertyName("organizationArns")]
    public IList<string>? OrganizationArns { get; set; }

    /// <summary>Set of AWS Organizational Unit ARNs to assign.</summary>
    [JsonPropertyName("organizationalUnitArns")]
    public IList<string>? OrganizationalUnitArns { get; set; }

    /// <summary>Set of EC2 launch permission user groups to assign. Use all to distribute a public AMI.</summary>
    [JsonPropertyName("userGroups")]
    public IList<string>? UserGroups { get; set; }

    /// <summary>Set of AWS Account identifiers to assign.</summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionAmiDistributionConfiguration
{
    /// <summary>Key-value map of tags to apply to the distributed AMI.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Description to apply to the distributed AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key to encrypt the distributed AMI.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration block of EC2 launch permissions to apply to the distributed AMI. Detailed below.</summary>
    [JsonPropertyName("launchPermission")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionAmiDistributionConfigurationLaunchPermission>? LaunchPermission { get; set; }

    /// <summary>Name to apply to the distributed AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of AWS Account identifiers to distribute the AMI.</summary>
    [JsonPropertyName("targetAccountIds")]
    public IList<string>? TargetAccountIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionContainerDistributionConfigurationTargetRepository
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
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionContainerDistributionConfiguration
{
    /// <summary>Set of tags that are attached to the container distribution configuration.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>Description of the container distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block with the destination repository for the container distribution configuration.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionContainerDistributionConfigurationTargetRepository>? TargetRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfigurationLaunchTemplate
{
    /// <summary>The ID of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>The name of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateVersion")]
    public string? LaunchTemplateVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfigurationSnapshotConfiguration
{
    /// <summary>The number of pre-provisioned snapshots to keep on hand for a fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("targetResourceCount")]
    public double? TargetResourceCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfiguration
{
    /// <summary>The owner account ID for the fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A Boolean that represents the current state of faster launching for the Windows AMI. Set to true to start using Windows faster launching, or false to stop using it.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block for the launch template that the fast-launch enabled Windows AMI uses when it launches Windows instances to create pre-provisioned snapshots. Detailed below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfigurationLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>The maximum number of parallel instances that are launched for creating resources.</summary>
    [JsonPropertyName("maxParallelLaunches")]
    public double? MaxParallelLaunches { get; set; }

    /// <summary>Configuration block for managing the number of snapshots that are created from pre-provisioned instances for the Windows AMI when faster launching is enabled. Detailed below.</summary>
    [JsonPropertyName("snapshotConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfigurationSnapshotConfiguration>? SnapshotConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionLaunchTemplateConfiguration
{
    /// <summary>The account ID that this configuration applies to.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Indicates whether to set the specified Amazon EC2 launch template as the default launch template. Defaults to true.</summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>The ID of the Amazon EC2 launch template to use.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionS3ExportConfiguration
{
    /// <summary>The disk image format of the exported image (RAW, VHD, or VMDK)</summary>
    [JsonPropertyName("diskImageFormat")]
    public string? DiskImageFormat { get; set; }

    /// <summary>The name of the IAM role to use for exporting.</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the S3 bucket to store the exported image in. The bucket needs to exist before the export configuration is created.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The prefix for the exported image.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistributionSsmParameterConfiguration
{
    /// <summary>AWS account ID that will own the parameter in the given region. This account must be specified as a target account in the distribution settings.</summary>
    [JsonPropertyName("amiAccountId")]
    public string? AmiAccountId { get; set; }

    /// <summary>Data type of the SSM parameter. Valid values are text and aws:ec2:image. AWS recommends using aws:ec2:image.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Name of the SSM parameter that will store the AMI ID after distribution.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProviderDistribution
{
    /// <summary>Configuration block with Amazon Machine Image (AMI) distribution settings. Detailed below.</summary>
    [JsonPropertyName("amiDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionAmiDistributionConfiguration>? AmiDistributionConfiguration { get; set; }

    /// <summary>Configuration block with container distribution settings. Detailed below.</summary>
    [JsonPropertyName("containerDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionContainerDistributionConfiguration>? ContainerDistributionConfiguration { get; set; }

    /// <summary>Set of Windows faster-launching configurations to use for AMI distribution. Detailed below.</summary>
    [JsonPropertyName("fastLaunchConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionFastLaunchConfiguration>? FastLaunchConfiguration { get; set; }

    /// <summary>Set of launch template configuration settings that apply to image distribution. Detailed below.</summary>
    [JsonPropertyName("launchTemplateConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionLaunchTemplateConfiguration>? LaunchTemplateConfiguration { get; set; }

    /// <summary>Set of Amazon Resource Names (ARNs) of License Manager License Configurations.</summary>
    [JsonPropertyName("licenseConfigurationArns")]
    public IList<string>? LicenseConfigurationArns { get; set; }

    /// <summary>AWS Region for the distribution.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block with S3 export settings. Detailed below.</summary>
    [JsonPropertyName("s3ExportConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionS3ExportConfiguration>? S3ExportConfiguration { get; set; }

    /// <summary>Configuration block with SSM parameter configuration to use as AMI id output. Detailed below.</summary>
    [JsonPropertyName("ssmParameterConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistributionSsmParameterConfiguration>? SsmParameterConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecForProvider
{
    /// <summary>Description of the distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more configuration blocks with distribution settings. Detailed below.</summary>
    [JsonPropertyName("distribution")]
    public IList<V1beta1DistributionConfigurationSpecForProviderDistribution>? Distribution { get; set; }

    /// <summary>Name of the distribution configuration.</summary>
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
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionAmiDistributionConfigurationLaunchPermission
{
    /// <summary>Set of AWS Organization ARNs to assign.</summary>
    [JsonPropertyName("organizationArns")]
    public IList<string>? OrganizationArns { get; set; }

    /// <summary>Set of AWS Organizational Unit ARNs to assign.</summary>
    [JsonPropertyName("organizationalUnitArns")]
    public IList<string>? OrganizationalUnitArns { get; set; }

    /// <summary>Set of EC2 launch permission user groups to assign. Use all to distribute a public AMI.</summary>
    [JsonPropertyName("userGroups")]
    public IList<string>? UserGroups { get; set; }

    /// <summary>Set of AWS Account identifiers to assign.</summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionAmiDistributionConfiguration
{
    /// <summary>Key-value map of tags to apply to the distributed AMI.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Description to apply to the distributed AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key to encrypt the distributed AMI.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration block of EC2 launch permissions to apply to the distributed AMI. Detailed below.</summary>
    [JsonPropertyName("launchPermission")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionAmiDistributionConfigurationLaunchPermission>? LaunchPermission { get; set; }

    /// <summary>Name to apply to the distributed AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of AWS Account identifiers to distribute the AMI.</summary>
    [JsonPropertyName("targetAccountIds")]
    public IList<string>? TargetAccountIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionContainerDistributionConfigurationTargetRepository
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
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionContainerDistributionConfiguration
{
    /// <summary>Set of tags that are attached to the container distribution configuration.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>Description of the container distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block with the destination repository for the container distribution configuration.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionContainerDistributionConfigurationTargetRepository>? TargetRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfigurationLaunchTemplate
{
    /// <summary>The ID of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>The name of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateVersion")]
    public string? LaunchTemplateVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfigurationSnapshotConfiguration
{
    /// <summary>The number of pre-provisioned snapshots to keep on hand for a fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("targetResourceCount")]
    public double? TargetResourceCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfiguration
{
    /// <summary>The owner account ID for the fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A Boolean that represents the current state of faster launching for the Windows AMI. Set to true to start using Windows faster launching, or false to stop using it.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block for the launch template that the fast-launch enabled Windows AMI uses when it launches Windows instances to create pre-provisioned snapshots. Detailed below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfigurationLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>The maximum number of parallel instances that are launched for creating resources.</summary>
    [JsonPropertyName("maxParallelLaunches")]
    public double? MaxParallelLaunches { get; set; }

    /// <summary>Configuration block for managing the number of snapshots that are created from pre-provisioned instances for the Windows AMI when faster launching is enabled. Detailed below.</summary>
    [JsonPropertyName("snapshotConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfigurationSnapshotConfiguration>? SnapshotConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionLaunchTemplateConfiguration
{
    /// <summary>The account ID that this configuration applies to.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Indicates whether to set the specified Amazon EC2 launch template as the default launch template. Defaults to true.</summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>The ID of the Amazon EC2 launch template to use.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionS3ExportConfiguration
{
    /// <summary>The disk image format of the exported image (RAW, VHD, or VMDK)</summary>
    [JsonPropertyName("diskImageFormat")]
    public string? DiskImageFormat { get; set; }

    /// <summary>The name of the IAM role to use for exporting.</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the S3 bucket to store the exported image in. The bucket needs to exist before the export configuration is created.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The prefix for the exported image.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistributionSsmParameterConfiguration
{
    /// <summary>AWS account ID that will own the parameter in the given region. This account must be specified as a target account in the distribution settings.</summary>
    [JsonPropertyName("amiAccountId")]
    public string? AmiAccountId { get; set; }

    /// <summary>Data type of the SSM parameter. Valid values are text and aws:ec2:image. AWS recommends using aws:ec2:image.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Name of the SSM parameter that will store the AMI ID after distribution.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProviderDistribution
{
    /// <summary>Configuration block with Amazon Machine Image (AMI) distribution settings. Detailed below.</summary>
    [JsonPropertyName("amiDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionAmiDistributionConfiguration>? AmiDistributionConfiguration { get; set; }

    /// <summary>Configuration block with container distribution settings. Detailed below.</summary>
    [JsonPropertyName("containerDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionContainerDistributionConfiguration>? ContainerDistributionConfiguration { get; set; }

    /// <summary>Set of Windows faster-launching configurations to use for AMI distribution. Detailed below.</summary>
    [JsonPropertyName("fastLaunchConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionFastLaunchConfiguration>? FastLaunchConfiguration { get; set; }

    /// <summary>Set of launch template configuration settings that apply to image distribution. Detailed below.</summary>
    [JsonPropertyName("launchTemplateConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionLaunchTemplateConfiguration>? LaunchTemplateConfiguration { get; set; }

    /// <summary>Set of Amazon Resource Names (ARNs) of License Manager License Configurations.</summary>
    [JsonPropertyName("licenseConfigurationArns")]
    public IList<string>? LicenseConfigurationArns { get; set; }

    /// <summary>Configuration block with S3 export settings. Detailed below.</summary>
    [JsonPropertyName("s3ExportConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionS3ExportConfiguration>? S3ExportConfiguration { get; set; }

    /// <summary>Configuration block with SSM parameter configuration to use as AMI id output. Detailed below.</summary>
    [JsonPropertyName("ssmParameterConfiguration")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistributionSsmParameterConfiguration>? SsmParameterConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecInitProvider
{
    /// <summary>Description of the distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more configuration blocks with distribution settings. Detailed below.</summary>
    [JsonPropertyName("distribution")]
    public IList<V1beta1DistributionConfigurationSpecInitProviderDistribution>? Distribution { get; set; }

    /// <summary>Name of the distribution configuration.</summary>
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
public partial class V1beta1DistributionConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1DistributionConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpecWriteConnectionSecretToRef
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
/// <summary>DistributionConfigurationSpec defines the desired state of DistributionConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DistributionConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DistributionConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DistributionConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DistributionConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionAmiDistributionConfigurationLaunchPermission
{
    /// <summary>Set of AWS Organization ARNs to assign.</summary>
    [JsonPropertyName("organizationArns")]
    public IList<string>? OrganizationArns { get; set; }

    /// <summary>Set of AWS Organizational Unit ARNs to assign.</summary>
    [JsonPropertyName("organizationalUnitArns")]
    public IList<string>? OrganizationalUnitArns { get; set; }

    /// <summary>Set of EC2 launch permission user groups to assign. Use all to distribute a public AMI.</summary>
    [JsonPropertyName("userGroups")]
    public IList<string>? UserGroups { get; set; }

    /// <summary>Set of AWS Account identifiers to assign.</summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionAmiDistributionConfiguration
{
    /// <summary>Key-value map of tags to apply to the distributed AMI.</summary>
    [JsonPropertyName("amiTags")]
    public IDictionary<string, string>? AmiTags { get; set; }

    /// <summary>Description to apply to the distributed AMI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Key Management Service (KMS) Key to encrypt the distributed AMI.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration block of EC2 launch permissions to apply to the distributed AMI. Detailed below.</summary>
    [JsonPropertyName("launchPermission")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionAmiDistributionConfigurationLaunchPermission>? LaunchPermission { get; set; }

    /// <summary>Name to apply to the distributed AMI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of AWS Account identifiers to distribute the AMI.</summary>
    [JsonPropertyName("targetAccountIds")]
    public IList<string>? TargetAccountIds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionContainerDistributionConfigurationTargetRepository
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
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionContainerDistributionConfiguration
{
    /// <summary>Set of tags that are attached to the container distribution configuration.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>Description of the container distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block with the destination repository for the container distribution configuration.</summary>
    [JsonPropertyName("targetRepository")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionContainerDistributionConfigurationTargetRepository>? TargetRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfigurationLaunchTemplate
{
    /// <summary>The ID of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>The name of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version of the launch template to use for faster launching for a Windows AMI.</summary>
    [JsonPropertyName("launchTemplateVersion")]
    public string? LaunchTemplateVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfigurationSnapshotConfiguration
{
    /// <summary>The number of pre-provisioned snapshots to keep on hand for a fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("targetResourceCount")]
    public double? TargetResourceCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfiguration
{
    /// <summary>The owner account ID for the fast-launch enabled Windows AMI.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A Boolean that represents the current state of faster launching for the Windows AMI. Set to true to start using Windows faster launching, or false to stop using it.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block for the launch template that the fast-launch enabled Windows AMI uses when it launches Windows instances to create pre-provisioned snapshots. Detailed below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfigurationLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>The maximum number of parallel instances that are launched for creating resources.</summary>
    [JsonPropertyName("maxParallelLaunches")]
    public double? MaxParallelLaunches { get; set; }

    /// <summary>Configuration block for managing the number of snapshots that are created from pre-provisioned instances for the Windows AMI when faster launching is enabled. Detailed below.</summary>
    [JsonPropertyName("snapshotConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfigurationSnapshotConfiguration>? SnapshotConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionLaunchTemplateConfiguration
{
    /// <summary>The account ID that this configuration applies to.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Indicates whether to set the specified Amazon EC2 launch template as the default launch template. Defaults to true.</summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>The ID of the Amazon EC2 launch template to use.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionS3ExportConfiguration
{
    /// <summary>The disk image format of the exported image (RAW, VHD, or VMDK)</summary>
    [JsonPropertyName("diskImageFormat")]
    public string? DiskImageFormat { get; set; }

    /// <summary>The name of the IAM role to use for exporting.</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>The name of the S3 bucket to store the exported image in. The bucket needs to exist before the export configuration is created.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>The prefix for the exported image.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistributionSsmParameterConfiguration
{
    /// <summary>AWS account ID that will own the parameter in the given region. This account must be specified as a target account in the distribution settings.</summary>
    [JsonPropertyName("amiAccountId")]
    public string? AmiAccountId { get; set; }

    /// <summary>Data type of the SSM parameter. Valid values are text and aws:ec2:image. AWS recommends using aws:ec2:image.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Name of the SSM parameter that will store the AMI ID after distribution.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProviderDistribution
{
    /// <summary>Configuration block with Amazon Machine Image (AMI) distribution settings. Detailed below.</summary>
    [JsonPropertyName("amiDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionAmiDistributionConfiguration>? AmiDistributionConfiguration { get; set; }

    /// <summary>Configuration block with container distribution settings. Detailed below.</summary>
    [JsonPropertyName("containerDistributionConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionContainerDistributionConfiguration>? ContainerDistributionConfiguration { get; set; }

    /// <summary>Set of Windows faster-launching configurations to use for AMI distribution. Detailed below.</summary>
    [JsonPropertyName("fastLaunchConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionFastLaunchConfiguration>? FastLaunchConfiguration { get; set; }

    /// <summary>Set of launch template configuration settings that apply to image distribution. Detailed below.</summary>
    [JsonPropertyName("launchTemplateConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionLaunchTemplateConfiguration>? LaunchTemplateConfiguration { get; set; }

    /// <summary>Set of Amazon Resource Names (ARNs) of License Manager License Configurations.</summary>
    [JsonPropertyName("licenseConfigurationArns")]
    public IList<string>? LicenseConfigurationArns { get; set; }

    /// <summary>AWS Region for the distribution.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block with S3 export settings. Detailed below.</summary>
    [JsonPropertyName("s3ExportConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionS3ExportConfiguration>? S3ExportConfiguration { get; set; }

    /// <summary>Configuration block with SSM parameter configuration to use as AMI id output. Detailed below.</summary>
    [JsonPropertyName("ssmParameterConfiguration")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistributionSsmParameterConfiguration>? SsmParameterConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the distribution configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Date the distribution configuration was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Date the distribution configuration was updated.</summary>
    [JsonPropertyName("dateUpdated")]
    public string? DateUpdated { get; set; }

    /// <summary>Description of the distribution configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more configuration blocks with distribution settings. Detailed below.</summary>
    [JsonPropertyName("distribution")]
    public IList<V1beta1DistributionConfigurationStatusAtProviderDistribution>? Distribution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the distribution configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

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
public partial class V1beta1DistributionConfigurationStatusConditions
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
/// <summary>DistributionConfigurationStatus defines the observed state of DistributionConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DistributionConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DistributionConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DistributionConfiguration is the Schema for the DistributionConfigurations API. Manage an Image Builder Distribution Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DistributionConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DistributionConfigurationSpec>, IStatus<V1beta1DistributionConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DistributionConfiguration";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "distributionconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DistributionConfigurationSpec defines the desired state of DistributionConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1DistributionConfigurationSpec Spec { get; set; }

    /// <summary>DistributionConfigurationStatus defines the observed state of DistributionConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1DistributionConfigurationStatus? Status { get; set; }
}
#nullable disable
