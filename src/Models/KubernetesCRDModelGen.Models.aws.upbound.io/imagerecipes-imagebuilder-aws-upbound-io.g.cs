using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.upbound.io;
public enum V1beta1ImageRecipeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProviderBlockDeviceMappingEbs
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

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ImageRecipeSpecForProviderBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

public enum V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
public partial class V1beta1ImageRecipeSpecForProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
public partial class V1beta1ImageRecipeSpecForProviderComponentComponentArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta1ImageRecipeSpecForProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageRecipeSpecForProviderComponentParameter>? Parameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built. Defaults to false.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecForProvider
{
    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ImageRecipeSpecForProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ImageRecipeSpecForProviderComponent>? Component { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN or an AMI ID.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public IList<V1beta1ImageRecipeSpecForProviderSystemsManagerAgent>? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecInitProviderBlockDeviceMappingEbs
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

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecInitProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ImageRecipeSpecInitProviderBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

public enum V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponentComponentArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecInitProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Reference to a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnRef")]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnRef? ComponentArnRef { get; set; }

    /// <summary>Selector for a Component in imagebuilder to populate componentArn.</summary>
    [JsonPropertyName("componentArnSelector")]
    public V1beta1ImageRecipeSpecInitProviderComponentComponentArnSelector? ComponentArnSelector { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageRecipeSpecInitProviderComponentParameter>? Parameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeSpecInitProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built. Defaults to false.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ImageRecipeSpecInitProvider
{
    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ImageRecipeSpecInitProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ImageRecipeSpecInitProviderComponent>? Component { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN or an AMI ID.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public IList<V1beta1ImageRecipeSpecInitProviderSystemsManagerAgent>? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

public enum V1beta1ImageRecipeSpecManagementPoliciesEnum
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

public enum V1beta1ImageRecipeSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ImageRecipeSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ImageRecipeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ImageRecipeSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ImageRecipeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ImageRecipeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ImageRecipeSpec defines the desired state of ImageRecipe</summary>
public partial class V1beta1ImageRecipeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ImageRecipeSpecDeletionPolicyEnum>))]
    public V1beta1ImageRecipeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ImageRecipeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ImageRecipeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ImageRecipeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ImageRecipeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ImageRecipeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ImageRecipeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProviderBlockDeviceMappingEbs
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

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProviderBlockDeviceMapping
{
    /// <summary>Name of the device. For example, /dev/sda or /dev/xvdb.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configuration block with Elastic Block Storage (EBS) block device mapping settings. Detailed below.</summary>
    [JsonPropertyName("ebs")]
    public IList<V1beta1ImageRecipeStatusAtProviderBlockDeviceMappingEbs>? Ebs { get; set; }

    /// <summary>Set to true to remove a mapping from the parent image.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Virtual device name. For example, ephemeral0. Instance store volumes are numbered starting from 0.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProviderComponentParameter
{
    /// <summary>The name of the component parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for the named component parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProviderComponent
{
    /// <summary>Amazon Resource Name (ARN) of the Image Builder Component to associate.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>Configuration block(s) for parameters to configure the component. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ImageRecipeStatusAtProviderComponentParameter>? Parameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProviderSystemsManagerAgent
{
    /// <summary>Whether to remove the Systems Manager Agent after the image has been built. Defaults to false.</summary>
    [JsonPropertyName("uninstallAfterBuild")]
    public bool? UninstallAfterBuild { get; set; }
}

/// <summary></summary>
public partial class V1beta1ImageRecipeStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block(s) with block device mappings for the image recipe. Detailed below.</summary>
    [JsonPropertyName("blockDeviceMapping")]
    public IList<V1beta1ImageRecipeStatusAtProviderBlockDeviceMapping>? BlockDeviceMapping { get; set; }

    /// <summary>Ordered configuration block(s) with components for the image recipe. Detailed below.</summary>
    [JsonPropertyName("component")]
    public IList<V1beta1ImageRecipeStatusAtProviderComponent>? Component { get; set; }

    /// <summary>Date the image recipe was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Description of the image recipe.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the image recipe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the image recipe.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The image recipe uses this image as a base from which to build your customized image. The value can be the base image ARN or an AMI ID.</summary>
    [JsonPropertyName("parentImage")]
    public string? ParentImage { get; set; }

    /// <summary>Platform of the image recipe.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Configuration block for the Systems Manager Agent installed by default by Image Builder. Detailed below.</summary>
    [JsonPropertyName("systemsManagerAgent")]
    public IList<V1beta1ImageRecipeStatusAtProviderSystemsManagerAgent>? SystemsManagerAgent { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Base64 encoded user data. Use this to provide commands or a command script to run when you launch your build instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>The semantic version of the image recipe, which specifies the version in the following format, with numeric values in each position to indicate a specific version: major.minor.patch. For example: 1.0.0.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The working directory to be used during build and test workflows.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ImageRecipeStatusConditions
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

/// <summary>ImageRecipeStatus defines the observed state of ImageRecipe.</summary>
public partial class V1beta1ImageRecipeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ImageRecipeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ImageRecipeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ImageRecipe is the Schema for the ImageRecipes API. Manage an Image Builder Image Recipe</summary>
public partial class V1beta1ImageRecipe : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImageRecipeSpec>, IStatus<V1beta1ImageRecipeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageRecipe";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagerecipes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageRecipeSpec defines the desired state of ImageRecipe</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImageRecipeSpec Spec { get; set; }

    /// <summary>ImageRecipeStatus defines the observed state of ImageRecipe.</summary>
    [JsonPropertyName("status")]
    public V1beta1ImageRecipeStatus? Status { get; set; }
}