using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecForProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination (Default: true).</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecForProviderEphemeralBlockDevice
{
    /// <summary>The name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecForProviderMetadataOptions
{
    /// <summary>The state of the metadata service: enabled, disabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>If session tokens are required: optional, required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecForProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecForProvider
{
    /// <summary>Associate a public ip address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>Additional EBS block devices to attach to the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enables/disables detailed monitoring. This is enabled by default.</summary>
    [JsonPropertyName("enableMonitoring")]
    public bool? EnableMonitoring { get; set; }

    /// <summary>Customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>The name attribute of the IAM instance profile to associate with launched instances.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>The EC2 image ID to launch.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The size of instance to launch.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The key name that should be used for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The metadata options for the instance.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchConfigurationSpecForProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The tenancy of the instance. Valid values are default or dedicated, see AWS's Create Launch Configuration for more details.</summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Customize details about the root block device of the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecForProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>A list of associated security group IDS.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The maximum price to use for reserving spot instances.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecInitProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination (Default: true).</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecInitProviderEphemeralBlockDevice
{
    /// <summary>The name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecInitProviderMetadataOptions
{
    /// <summary>The state of the metadata service: enabled, disabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>If session tokens are required: optional, required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecInitProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecInitProvider
{
    /// <summary>Associate a public ip address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>Additional EBS block devices to attach to the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enables/disables detailed monitoring. This is enabled by default.</summary>
    [JsonPropertyName("enableMonitoring")]
    public bool? EnableMonitoring { get; set; }

    /// <summary>Customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>The name attribute of the IAM instance profile to associate with launched instances.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>The EC2 image ID to launch.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The size of instance to launch.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The key name that should be used for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The metadata options for the instance.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchConfigurationSpecInitProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The tenancy of the instance. Valid values are default or dedicated, see AWS's Create Launch Configuration for more details.</summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary>Customize details about the root block device of the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1LaunchConfigurationSpecInitProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>A list of associated security group IDS.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The maximum price to use for reserving spot instances.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LaunchConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LaunchConfigurationSpec defines the desired state of LaunchConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LaunchConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LaunchConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LaunchConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LaunchConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusAtProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination (Default: true).</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of "io1".</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusAtProviderEphemeralBlockDevice
{
    /// <summary>The name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether the device in the block device mapping of the AMI is suppressed.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>The Instance Store Device Name.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusAtProviderMetadataOptions
{
    /// <summary>The state of the metadata service: enabled, disabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>If session tokens are required: optional, required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusAtProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether the volume should be encrypted or not. Defaults to false.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The amount of provisioned IOPS. This must be set with a volume_type of io1.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The throughput (MiBps) to provision for a gp3 volume.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>The type of volume. Can be standard, gp2, gp3, st1, sc1 or io1.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusAtProvider
{
    /// <summary>The Amazon Resource Name of the launch configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Associate a public ip address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>Additional EBS block devices to attach to the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1LaunchConfigurationStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enables/disables detailed monitoring. This is enabled by default.</summary>
    [JsonPropertyName("enableMonitoring")]
    public bool? EnableMonitoring { get; set; }

    /// <summary>Customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1LaunchConfigurationStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>The name attribute of the IAM instance profile to associate with launched instances.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>The ID of the launch configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The EC2 image ID to launch.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The size of instance to launch.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The key name that should be used for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The metadata options for the instance.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1LaunchConfigurationStatusAtProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>The tenancy of the instance. Valid values are default or dedicated, see AWS's Create Launch Configuration for more details.</summary>
    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Customize details about the root block device of the instance. See Block Devices below for details.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1LaunchConfigurationStatusAtProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>A list of associated security group IDS.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The maximum price to use for reserving spot instances.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatusConditions
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

/// <summary>LaunchConfigurationStatus defines the observed state of LaunchConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LaunchConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LaunchConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LaunchConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LaunchConfiguration is the Schema for the LaunchConfigurations API. Provides a resource to create a new launch configuration, used for autoscaling groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LaunchConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LaunchConfigurationSpec>, IStatus<V1beta1LaunchConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LaunchConfiguration";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
    public const string KubePluralName = "launchconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LaunchConfigurationSpec defines the desired state of LaunchConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1LaunchConfigurationSpec Spec { get; set; }

    /// <summary>LaunchConfigurationStatus defines the observed state of LaunchConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1LaunchConfigurationStatus? Status { get; set; }
}

/// <summary>LaunchConfiguration is the Schema for the LaunchConfigurations API. Provides a resource to create a new launch configuration, used for autoscaling groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LaunchConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LaunchConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LaunchConfigurationList";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
    public const string KubePluralName = "launchconfigurations";
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
    public IList<V1beta1LaunchConfiguration> Items { get; set; }
}