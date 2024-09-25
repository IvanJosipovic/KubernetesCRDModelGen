using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecDeletionPolicyEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchSpecification
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnRef")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRef? IamInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnSelector")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelector? IamInstanceProfileArnSelector { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector? IdSelector { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource's attribute, e.g., "${aws_launch_template.foo.latest_version}". It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public IList<V1beta1SpotFleetRequestSpecForProviderSpotMaintenanceStrategiesCapacityRebalance>? CapacityRebalance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecForProvider
{
    /// <summary>Indicates how to allocate the target capacity across the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated if the target capacity of the Spot fleet request is decreased below the current size of the Spot fleet.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>The type of fleet request. Indicates whether the Spot Fleet only requests the target capacity or also attempts to maintain it. Default is maintain.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>Grants the Spot fleet permission to terminate Spot instances on your behalf when you cancel its Spot fleet request using CancelSpotFleetRequests or when the Spot fleet request expires, if you set terminateInstancesWithExpiration.</summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>Indicates whether a Spot instance stops or terminates when it is interrupted. Default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>The number of Spot pools across which to allocate your target Spot capacity. Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects the cheapest Spot pools and evenly allocates your target Spot capacity across the number of Spot pools that you specify.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Used to define the launch configuration of the spot-fleet request. Can be specified multiple times to define different bids across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1SpotFleetRequestSpecForProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay. When the maximum amount you're willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public IList<V1beta1SpotFleetRequestSpecForProviderSpotMaintenanceStrategies>? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of units to request. You can choose to set the target capacity in terms of instances or a performance characteristic that is important to your application workload, such as vCPUs, memory, or I/O.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the resource is deleted (and the Spot fleet request cancelled). If no value is specified, the value of the terminate_instances_with_expiration argument is used.</summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the Spot fleet request expires.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchSpecification
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnRef")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRef? IamInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnSelector")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelector? IamInstanceProfileArnSelector { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector? IdSelector { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource's attribute, e.g., "${aws_launch_template.foo.latest_version}". It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderSpotMaintenanceStrategiesCapacityRebalance>? CapacityRebalance { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecInitProvider
{
    /// <summary>Indicates how to allocate the target capacity across the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated if the target capacity of the Spot fleet request is decreased below the current size of the Spot fleet.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>The type of fleet request. Indicates whether the Spot Fleet only requests the target capacity or also attempts to maintain it. Default is maintain.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>Grants the Spot fleet permission to terminate Spot instances on your behalf when you cancel its Spot fleet request using CancelSpotFleetRequests or when the Spot fleet request expires, if you set terminateInstancesWithExpiration.</summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>Indicates whether a Spot instance stops or terminates when it is interrupted. Default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>The number of Spot pools across which to allocate your target Spot capacity. Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects the cheapest Spot pools and evenly allocates your target Spot capacity across the number of Spot pools that you specify.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Used to define the launch configuration of the spot-fleet request. Can be specified multiple times to define different bids across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay. When the maximum amount you're willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public IList<V1beta1SpotFleetRequestSpecInitProviderSpotMaintenanceStrategies>? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of units to request. You can choose to set the target capacity in terms of instances or a performance characteristic that is important to your application workload, such as vCPUs, memory, or I/O.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the resource is deleted (and the Spot fleet request cancelled). If no value is specified, the value of the terminate_instances_with_expiration argument is used.</summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the Spot fleet request expires.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecManagementPoliciesEnum
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
public enum V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SpotFleetRequestSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpotFleetRequestSpec defines the desired state of SpotFleetRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotFleetRequestSpecDeletionPolicyEnum>))]
    public V1beta1SpotFleetRequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpotFleetRequestSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpotFleetRequestSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpotFleetRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpotFleetRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpotFleetRequestSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpotFleetRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationEbsBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationRootBlockDevice
{
    /// <summary></summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchSpecification
{
    /// <summary></summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary></summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource's attribute, e.g., "${aws_launch_template.foo.latest_version}". It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderSpotMaintenanceStrategiesCapacityRebalance>? CapacityRebalance { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusAtProvider
{
    /// <summary>Indicates how to allocate the target capacity across the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientToken")]
    public string? ClientToken { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated if the target capacity of the Spot fleet request is decreased below the current size of the Spot fleet.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>The type of fleet request. Indicates whether the Spot Fleet only requests the target capacity or also attempts to maintain it. Default is maintain.</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>Grants the Spot fleet permission to terminate Spot instances on your behalf when you cancel its Spot fleet request using CancelSpotFleetRequests or when the Spot fleet request expires, if you set terminateInstancesWithExpiration.</summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether a Spot instance stops or terminates when it is interrupted. Default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>The number of Spot pools across which to allocate your target Spot capacity. Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects the cheapest Spot pools and evenly allocates your target Spot capacity across the number of Spot pools that you specify.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Used to define the launch configuration of the spot-fleet request. Can be specified multiple times to define different bids across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay. When the maximum amount you're willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public IList<V1beta1SpotFleetRequestStatusAtProviderSpotMaintenanceStrategies>? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The state of the Spot fleet request.</summary>
    [JsonPropertyName("spotRequestState")]
    public string? SpotRequestState { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The number of units to request. You can choose to set the target capacity in terms of instances or a performance characteristic that is important to your application workload, such as vCPUs, memory, or I/O.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the resource is deleted (and the Spot fleet request cancelled). If no value is specified, the value of the terminate_instances_with_expiration argument is used.</summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>Indicates whether running Spot instances should be terminated when the Spot fleet request expires.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatusConditions
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

/// <summary>SpotFleetRequestStatus defines the observed state of SpotFleetRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotFleetRequestStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpotFleetRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpotFleetRequestStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpotFleetRequest is the Schema for the SpotFleetRequests API. Provides a Spot Fleet Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpotFleetRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpotFleetRequestSpec>, IStatus<V1beta1SpotFleetRequestStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpotFleetRequest";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotfleetrequests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpotFleetRequestSpec defines the desired state of SpotFleetRequest</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpotFleetRequestSpec Spec { get; set; }

    /// <summary>SpotFleetRequestStatus defines the observed state of SpotFleetRequest.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpotFleetRequestStatus? Status { get; set; }
}