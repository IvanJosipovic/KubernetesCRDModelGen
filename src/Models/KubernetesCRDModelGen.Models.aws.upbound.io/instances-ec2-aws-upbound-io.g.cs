using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
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
public partial class V1beta1InstanceSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be "open" or "none". (Default: "open").</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1InstanceSpecForProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you're willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid value is spot. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1InstanceSpecForProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required. Defaults to optional.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance's Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1InstanceSpecForProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1InstanceSpecForProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1InstanceSpecForProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1InstanceSpecForProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1InstanceSpecForProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1InstanceSpecForProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1InstanceSpecForProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1InstanceSpecForProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Placement Group to start the instance in.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to "partition".</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1InstanceSpecForProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceSpecForProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance's primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1InstanceSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1InstanceSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1InstanceSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1InstanceSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be "open" or "none". (Default: "open").</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1InstanceSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you're willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid value is spot. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1InstanceSpecInitProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required. Defaults to optional.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta1InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance's Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1InstanceSpecInitProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1InstanceSpecInitProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1InstanceSpecInitProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1InstanceSpecInitProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1InstanceSpecInitProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1InstanceSpecInitProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1InstanceSpecInitProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1InstanceSpecInitProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Placement Group to start the instance in.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to "partition".</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1InstanceSpecInitProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceSpecInitProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance's primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1InstanceSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1InstanceSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1InstanceSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1InstanceSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
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
public partial class V1beta1InstanceStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance's Capacity Reservation preferences. Can be "open" or "none". (Default: "open").</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public IList<V1beta1InstanceStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget>? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>ID of the volume. For example, the ID can be accessed like this, aws_instance.web.ebs_block_device.2.volume_id.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI's block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you're willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid value is spot. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public IList<V1beta1InstanceStatusAtProviderInstanceMarketOptionsSpotOptions>? SpotOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be "default" or "disabled". See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required. Defaults to optional.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device name, e.g., /dev/sdh or xvdh.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Map of tags to assign to the device.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>ID of the volume. For example, the ID can be accessed like this, aws_instance.web.root_block_device.0.volume_id.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>ARN of the instance.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance's Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public IList<V1beta1InstanceStatusAtProviderCapacityReservationSpecification>? CapacityReservationSpecification { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("cpuCoreCount")]
    public double? CpuCoreCount { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public IList<V1beta1InstanceStatusAtProviderCpuOptions>? CpuOptions { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("cpuThreadsPerCore")]
    public double? CpuThreadsPerCore { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public IList<V1beta1InstanceStatusAtProviderCreditSpecification>? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public IList<V1beta1InstanceStatusAtProviderEnclaveOptions>? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as "Instance Store") volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>ID of the instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates whether this is a Spot Instance or a Scheduled Instance.</summary>
    [JsonPropertyName("instanceLifecycle")]
    public string? InstanceLifecycle { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public IList<V1beta1InstanceStatusAtProviderInstanceMarketOptions>? InstanceMarketOptions { get; set; }

    /// <summary>State of the instance. One of: pending, running, shutting-down, terminated, stopping, stopped. See Instance Lifecycle for more information.</summary>
    [JsonPropertyName("instanceState")]
    public string? InstanceState { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta1InstanceStatusAtProviderLaunchTemplate>? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public IList<V1beta1InstanceStatusAtProviderMaintenanceOptions>? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public IList<V1beta1InstanceStatusAtProviderMetadataOptions>? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1InstanceStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>ARN of the Outpost the instance is assigned to.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>Base-64 encoded encrypted password data for the instance. Useful for getting the administrator password for instances running Microsoft Windows. This attribute is only exported if get_password_data is true. Note that this encrypted value will be stored in the state file, as with all exported attributes. See GetPasswordData for more information.</summary>
    [JsonPropertyName("passwordData")]
    public string? PasswordData { get; set; }

    /// <summary>Placement Group to start the instance in.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to "partition".</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>ID of the instance's primary network interface.</summary>
    [JsonPropertyName("primaryNetworkInterfaceId")]
    public string? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>Private DNS name assigned to the instance. Can only be used inside the Amazon EC2, and only available if you've enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("privateDns")]
    public string? PrivateDns { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public IList<V1beta1InstanceStatusAtProviderPrivateDnsNameOptions>? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Public DNS name assigned to the instance. For EC2-VPC, this is only available if you've enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("publicDns")]
    public string? PublicDns { get; set; }

    /// <summary>Public IP address assigned to the instance, if applicable. NOTE: If you are using an aws_eip with your instance, you should refer to the EIP's address directly and not use public_ip as this field will change after the EIP is attached.</summary>
    [JsonPropertyName("publicIp")]
    public string? PublicIp { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta1InstanceStatusAtProviderRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance's primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>List of security group names to associate with.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>If the request is a Spot Instance request, the ID of the request.</summary>
    [JsonPropertyName("spotInstanceRequestId")]
    public string? SpotInstanceRequestId { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
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

/// <summary>Instance is the Schema for the Instances API. Provides an EC2 instance resource. This allows instances to be created, updated, and deleted. Instances also support provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "ec2.aws.upbound.io";
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