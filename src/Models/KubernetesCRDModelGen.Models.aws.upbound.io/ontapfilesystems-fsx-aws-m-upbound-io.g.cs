using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fsx.aws.m.upbound.io;
#nullable enable
/// <summary>OntapFileSystem is the Schema for the OntapFileSystems API. Manages an Amazon FSx for NetApp ONTAP file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OntapFileSystemList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OntapFileSystem>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OntapFileSystemList";
    public const string KubeGroup = "fsx.aws.m.upbound.io";
    public const string KubePluralName = "ontapfilesystems";
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
    public IList<V1beta1OntapFileSystem> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The ONTAP administrative password for the fsxadmin user that you can use to administer your file system using the ONTAP CLI and REST API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderFsxAdminPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderKmsKeyIdRefPolicy
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
public partial class V1beta1OntapFileSystemSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderKmsKeyIdSelectorPolicy
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
public partial class V1beta1OntapFileSystemSpecForProviderKmsKeyIdSelector
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
    public V1beta1OntapFileSystemSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdRefPolicy
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
/// <summary>Reference to a Subnet in ec2 to populate preferredSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdSelectorPolicy
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
/// <summary>Selector for a Subnet in ec2 to populate preferredSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdSelector
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
    public V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSecurityGroupIdRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSecurityGroupIdSelectorPolicy
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
/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSecurityGroupIdSelector
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
    public V1beta1OntapFileSystemSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSubnetIdRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSubnetIdSelectorPolicy
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
/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProviderSubnetIdSelector
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
    public V1beta1OntapFileSystemSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecForProvider
{
    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>- The filesystem deployment type. Supports MULTI_AZ_1, MULTI_AZ_2, SINGLE_AZ_1, and SINGLE_AZ_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public V1beta1OntapFileSystemSpecForProviderDiskIopsConfiguration? DiskIopsConfiguration { get; set; }

    /// <summary>Specifies the IP address range in which the endpoints to access your file system will be created. By default, Amazon FSx selects an unused IP address range for you from the 198.19.* range.</summary>
    [JsonPropertyName("endpointIpAddressRange")]
    public string? EndpointIpAddressRange { get; set; }

    /// <summary>The ONTAP administrative password for the fsxadmin user that you can use to administer your file system using the ONTAP CLI and REST API.</summary>
    [JsonPropertyName("fsxAdminPasswordSecretRef")]
    public V1beta1OntapFileSystemSpecForProviderFsxAdminPasswordSecretRef? FsxAdminPasswordSecretRef { get; set; }

    /// <summary>- The number of ha_pairs to deploy for the file system. Valid value is 1 for SINGLE_AZ_1 or MULTI_AZ_1 and MULTI_AZ_2. Valid values are 1 through 12 for SINGLE_AZ_2.</summary>
    [JsonPropertyName("haPairs")]
    public double? HaPairs { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1OntapFileSystemSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1OntapFileSystemSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The ID for a subnet. A subnet is a range of IP addresses in your virtual private cloud (VPC).</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate preferredSubnetId.</summary>
    [JsonPropertyName("preferredSubnetIdRef")]
    public V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdRef? PreferredSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate preferredSubnetId.</summary>
    [JsonPropertyName("preferredSubnetIdSelector")]
    public V1beta1OntapFileSystemSpecForProviderPreferredSubnetIdSelector? PreferredSubnetIdSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the VPC route tables in which your file system's endpoints will be created. You should specify all VPC route tables associated with the subnets in which your clients are located. By default, Amazon FSx selects your VPC's default route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1OntapFileSystemSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1OntapFileSystemSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Valid values between 1024 and 196608 for file systems with deployment_type SINGLE_AZ_1 and MULTI_AZ_1. Valid values are between 1024 and 524288 for MULTI_AZ_2. Valid values between 1024 (1024 per ha pair) and 1048576 for file systems with deployment_type SINGLE_AZ_2. For SINGLE_AZ_2, the 1048576 (1PB) maximum is only supported when using 2 or more ha_pairs, the maximum is 524288 (512TB) when using 1 ha_pair.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. defaults to SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1OntapFileSystemSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1OntapFileSystemSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. Up to 2 subnets can be provided.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Sets the throughput capacity (in MBps) for the file system that you're creating. Valid values are 128, 256, 512, 1024, 2048, and 4096. This parameter is only supported when not using the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>Sets the per-HA-pair throughput capacity (in MBps) for the file system that you're creating, as opposed to throughput_capacity which specifies the total throughput capacity for the file system. Valid value for MULTI_AZ_1 and SINGLE_AZ_1 are 128, 256, 512, 1024, 2048, and 4096. Valid values for deployment type MULTI_AZ_2 and SINGLE_AZ_2 are 384,768,1536,3072,6144 where ha_pairs is 1. Valid values for deployment type SINGLE_AZ_2 are 1536, 3072, and 6144 where ha_pairs is greater than 1. This parameter is only supported when specifying the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacityPerHaPair")]
    public double? ThroughputCapacityPerHaPair { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The ONTAP administrative password for the fsxadmin user that you can use to administer your file system using the ONTAP CLI and REST API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderFsxAdminPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderKmsKeyIdRefPolicy
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
public partial class V1beta1OntapFileSystemSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderKmsKeyIdSelectorPolicy
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
public partial class V1beta1OntapFileSystemSpecInitProviderKmsKeyIdSelector
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
    public V1beta1OntapFileSystemSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdRefPolicy
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
/// <summary>Reference to a Subnet in ec2 to populate preferredSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdSelectorPolicy
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
/// <summary>Selector for a Subnet in ec2 to populate preferredSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdSelector
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
    public V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy
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
/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdSelector
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
    public V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSubnetIdRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapFileSystemSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSubnetIdSelectorPolicy
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
/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProviderSubnetIdSelector
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
    public V1beta1OntapFileSystemSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecInitProvider
{
    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>- The filesystem deployment type. Supports MULTI_AZ_1, MULTI_AZ_2, SINGLE_AZ_1, and SINGLE_AZ_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public V1beta1OntapFileSystemSpecInitProviderDiskIopsConfiguration? DiskIopsConfiguration { get; set; }

    /// <summary>Specifies the IP address range in which the endpoints to access your file system will be created. By default, Amazon FSx selects an unused IP address range for you from the 198.19.* range.</summary>
    [JsonPropertyName("endpointIpAddressRange")]
    public string? EndpointIpAddressRange { get; set; }

    /// <summary>The ONTAP administrative password for the fsxadmin user that you can use to administer your file system using the ONTAP CLI and REST API.</summary>
    [JsonPropertyName("fsxAdminPasswordSecretRef")]
    public V1beta1OntapFileSystemSpecInitProviderFsxAdminPasswordSecretRef? FsxAdminPasswordSecretRef { get; set; }

    /// <summary>- The number of ha_pairs to deploy for the file system. Valid value is 1 for SINGLE_AZ_1 or MULTI_AZ_1 and MULTI_AZ_2. Valid values are 1 through 12 for SINGLE_AZ_2.</summary>
    [JsonPropertyName("haPairs")]
    public double? HaPairs { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1OntapFileSystemSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1OntapFileSystemSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The ID for a subnet. A subnet is a range of IP addresses in your virtual private cloud (VPC).</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate preferredSubnetId.</summary>
    [JsonPropertyName("preferredSubnetIdRef")]
    public V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdRef? PreferredSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate preferredSubnetId.</summary>
    [JsonPropertyName("preferredSubnetIdSelector")]
    public V1beta1OntapFileSystemSpecInitProviderPreferredSubnetIdSelector? PreferredSubnetIdSelector { get; set; }

    /// <summary>Specifies the VPC route tables in which your file system's endpoints will be created. You should specify all VPC route tables associated with the subnets in which your clients are located. By default, Amazon FSx selects your VPC's default route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1OntapFileSystemSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Valid values between 1024 and 196608 for file systems with deployment_type SINGLE_AZ_1 and MULTI_AZ_1. Valid values are between 1024 and 524288 for MULTI_AZ_2. Valid values between 1024 (1024 per ha pair) and 1048576 for file systems with deployment_type SINGLE_AZ_2. For SINGLE_AZ_2, the 1048576 (1PB) maximum is only supported when using 2 or more ha_pairs, the maximum is 524288 (512TB) when using 1 ha_pair.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. defaults to SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1OntapFileSystemSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1OntapFileSystemSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. Up to 2 subnets can be provided.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Sets the throughput capacity (in MBps) for the file system that you're creating. Valid values are 128, 256, 512, 1024, 2048, and 4096. This parameter is only supported when not using the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>Sets the per-HA-pair throughput capacity (in MBps) for the file system that you're creating, as opposed to throughput_capacity which specifies the total throughput capacity for the file system. Valid value for MULTI_AZ_1 and SINGLE_AZ_1 are 128, 256, 512, 1024, 2048, and 4096. Valid values for deployment type MULTI_AZ_2 and SINGLE_AZ_2 are 384,768,1536,3072,6144 where ha_pairs is 1. Valid values for deployment type SINGLE_AZ_2 are 1536, 3072, and 6144 where ha_pairs is greater than 1. This parameter is only supported when specifying the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacityPerHaPair")]
    public double? ThroughputCapacityPerHaPair { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpecProviderConfigRef
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
public partial class V1beta1OntapFileSystemSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OntapFileSystemSpec defines the desired state of OntapFileSystem</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OntapFileSystemSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OntapFileSystemSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OntapFileSystemSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OntapFileSystemSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusAtProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusAtProviderEndpointsIntercluster
{
    /// <summary>DNS name for the file system.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the file system endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusAtProviderEndpointsManagement
{
    /// <summary>DNS name for the file system.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the file system endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusAtProviderEndpoints
{
    /// <summary>An endpoint for managing your file system by setting up NetApp SnapMirror with other ONTAP systems. See Endpoint.</summary>
    [JsonPropertyName("intercluster")]
    public IList<V1beta1OntapFileSystemStatusAtProviderEndpointsIntercluster>? Intercluster { get; set; }

    /// <summary>An endpoint for managing your file system using the NetApp ONTAP CLI and NetApp ONTAP API. See Endpoint.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1OntapFileSystemStatusAtProviderEndpointsManagement>? Management { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusAtProvider
{
    /// <summary>Amazon Resource Name of the file system.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>- The filesystem deployment type. Supports MULTI_AZ_1, MULTI_AZ_2, SINGLE_AZ_1, and SINGLE_AZ_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for NetApp ONTAP file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public V1beta1OntapFileSystemStatusAtProviderDiskIopsConfiguration? DiskIopsConfiguration { get; set; }

    /// <summary>DNS name for the file system.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>Specifies the IP address range in which the endpoints to access your file system will be created. By default, Amazon FSx selects an unused IP address range for you from the 198.19.* range.</summary>
    [JsonPropertyName("endpointIpAddressRange")]
    public string? EndpointIpAddressRange { get; set; }

    /// <summary>The endpoints that are used to access data or to manage the file system using the NetApp ONTAP CLI, REST API, or NetApp SnapMirror. See Endpoints below.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1beta1OntapFileSystemStatusAtProviderEndpoints>? Endpoints { get; set; }

    /// <summary>- The number of ha_pairs to deploy for the file system. Valid value is 1 for SINGLE_AZ_1 or MULTI_AZ_1 and MULTI_AZ_2. Valid values are 1 through 12 for SINGLE_AZ_2.</summary>
    [JsonPropertyName("haPairs")]
    public double? HaPairs { get; set; }

    /// <summary>Identifier of the file system, e.g., fs-12345678</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Set of Elastic Network Interface identifiers from which the file system is accessible The first network interface returned is the primary network interface.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>AWS account identifier that created the file system.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The ID for a subnet. A subnet is a range of IP addresses in your virtual private cloud (VPC).</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the VPC route tables in which your file system's endpoints will be created. You should specify all VPC route tables associated with the subnets in which your clients are located. By default, Amazon FSx selects your VPC's default route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Valid values between 1024 and 196608 for file systems with deployment_type SINGLE_AZ_1 and MULTI_AZ_1. Valid values are between 1024 and 524288 for MULTI_AZ_2. Valid values between 1024 (1024 per ha pair) and 1048576 for file systems with deployment_type SINGLE_AZ_2. For SINGLE_AZ_2, the 1048576 (1PB) maximum is only supported when using 2 or more ha_pairs, the maximum is 524288 (512TB) when using 1 ha_pair.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. defaults to SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. Up to 2 subnets can be provided.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Sets the throughput capacity (in MBps) for the file system that you're creating. Valid values are 128, 256, 512, 1024, 2048, and 4096. This parameter is only supported when not using the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>Sets the per-HA-pair throughput capacity (in MBps) for the file system that you're creating, as opposed to throughput_capacity which specifies the total throughput capacity for the file system. Valid value for MULTI_AZ_1 and SINGLE_AZ_1 are 128, 256, 512, 1024, 2048, and 4096. Valid values for deployment type MULTI_AZ_2 and SINGLE_AZ_2 are 384,768,1536,3072,6144 where ha_pairs is 1. Valid values for deployment type SINGLE_AZ_2 are 1536, 3072, and 6144 where ha_pairs is greater than 1. This parameter is only supported when specifying the ha_pairs parameter. Either throughput_capacity or throughput_capacity_per_ha_pair must be specified.</summary>
    [JsonPropertyName("throughputCapacityPerHaPair")]
    public double? ThroughputCapacityPerHaPair { get; set; }

    /// <summary>Identifier of the Virtual Private Cloud for the file system.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatusConditions
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
/// <summary>OntapFileSystemStatus defines the observed state of OntapFileSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OntapFileSystemStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OntapFileSystemStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OntapFileSystemStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OntapFileSystem is the Schema for the OntapFileSystems API. Manages an Amazon FSx for NetApp ONTAP file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OntapFileSystem : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OntapFileSystemSpec>, IStatus<V1beta1OntapFileSystemStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OntapFileSystem";
    public const string KubeGroup = "fsx.aws.m.upbound.io";
    public const string KubePluralName = "ontapfilesystems";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OntapFileSystemSpec defines the desired state of OntapFileSystem</summary>
    [JsonPropertyName("spec")]
    public V1beta1OntapFileSystemSpec Spec { get; set; }

    /// <summary>OntapFileSystemStatus defines the observed state of OntapFileSystem.</summary>
    [JsonPropertyName("status")]
    public V1beta1OntapFileSystemStatus? Status { get; set; }
}
#nullable disable
