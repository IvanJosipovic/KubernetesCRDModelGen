using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fsx.aws.upbound.io;
public enum V1beta1WindowsFileSystemSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderAuditLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) for the destination of the audit logs. The destination can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis Data Firehose delivery stream ARN. Can be specified when file_access_audit_log_level and file_share_access_audit_log_level are not set to DISABLED. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. The name of the Amazon Kinesis Data Firehouse delivery stream must begin with the aws-fsx prefix. If you do not provide a destination in audit_log_destionation, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/windows log group.</summary>
    [JsonPropertyName("auditLogDestination")]
    public string? AuditLogDestination { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file and folder accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileAccessAuditLogLevel")]
    public string? FileAccessAuditLogLevel { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file share accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileShareAccessAuditLogLevel")]
    public string? FileShareAccessAuditLogLevel { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSelfManagedActiveDirectoryPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSelfManagedActiveDirectory
{
    /// <summary>A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in RFC 1918.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1WindowsFileSystemSpecForProviderSelfManagedActiveDirectoryPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecForProvider
{
    /// <summary>The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with self_managed_active_directory.</summary>
    [JsonPropertyName("activeDirectoryId")]
    public string? ActiveDirectoryId { get; set; }

    /// <summary>Reference to a Directory in ds to populate activeDirectoryId.</summary>
    [JsonPropertyName("activeDirectoryIdRef")]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdRef? ActiveDirectoryIdRef { get; set; }

    /// <summary>Selector for a Directory in ds to populate activeDirectoryId.</summary>
    [JsonPropertyName("activeDirectoryIdSelector")]
    public V1beta1WindowsFileSystemSpecForProviderActiveDirectoryIdSelector? ActiveDirectoryIdSelector { get; set; }

    /// <summary>An array DNS alias names that you want to associate with the Amazon FSx file system.  For more information, see Working with DNS Aliases</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>The configuration that Amazon FSx for Windows File Server uses to audit and log user accesses of files, folders, and file shares on the Amazon FSx for Windows File Server file system. See Audit Log Configuration below.</summary>
    [JsonPropertyName("auditLogConfiguration")]
    public IList<V1beta1WindowsFileSystemSpecForProviderAuditLogConfiguration>? AuditLogConfiguration { get; set; }

    /// <summary>The number of days to retain automatic backups. Minimum of 0 and maximum of 90. Defaults to 7. Set to 0 to disable.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>The preferred time (in HH:MM format) to take daily automatic backups, in the UTC time zone.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Specifies the file system deployment type, valid values are MULTI_AZ_1, SINGLE_AZ_1 and SINGLE_AZ_2. Default value is SINGLE_AZ_1.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for Windows File Server file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public IList<V1beta1WindowsFileSystemSpecForProviderDiskIopsConfiguration>? DiskIopsConfiguration { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1WindowsFileSystemSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Specifies the subnet in which you want the preferred file server to be located. Required for when deployment type is MULTI_AZ_1.</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1WindowsFileSystemSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with active_directory_id. See Self-Managed Active Directory below.</summary>
    [JsonPropertyName("selfManagedActiveDirectory")]
    public IList<V1beta1WindowsFileSystemSpecForProviderSelfManagedActiveDirectory>? SelfManagedActiveDirectory { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to false.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536. If the storage type is set to HDD the minimum value is 2000. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>Specifies the storage type, Valid values are SSD and HDD. HDD is supported on SINGLE_AZ_2 and MULTI_AZ_1 Windows file system deployment types. Default value is SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1WindowsFileSystemSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1WindowsFileSystemSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. To specify more than a single subnet set deployment_type to MULTI_AZ_1.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of 8 and maximum of 2048.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderAuditLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) for the destination of the audit logs. The destination can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis Data Firehose delivery stream ARN. Can be specified when file_access_audit_log_level and file_share_access_audit_log_level are not set to DISABLED. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. The name of the Amazon Kinesis Data Firehouse delivery stream must begin with the aws-fsx prefix. If you do not provide a destination in audit_log_destionation, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/windows log group.</summary>
    [JsonPropertyName("auditLogDestination")]
    public string? AuditLogDestination { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file and folder accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileAccessAuditLogLevel")]
    public string? FileAccessAuditLogLevel { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file share accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileShareAccessAuditLogLevel")]
    public string? FileShareAccessAuditLogLevel { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSelfManagedActiveDirectoryPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSelfManagedActiveDirectory
{
    /// <summary>A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in RFC 1918.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1WindowsFileSystemSpecInitProviderSelfManagedActiveDirectoryPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecInitProvider
{
    /// <summary>The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with self_managed_active_directory.</summary>
    [JsonPropertyName("activeDirectoryId")]
    public string? ActiveDirectoryId { get; set; }

    /// <summary>Reference to a Directory in ds to populate activeDirectoryId.</summary>
    [JsonPropertyName("activeDirectoryIdRef")]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdRef? ActiveDirectoryIdRef { get; set; }

    /// <summary>Selector for a Directory in ds to populate activeDirectoryId.</summary>
    [JsonPropertyName("activeDirectoryIdSelector")]
    public V1beta1WindowsFileSystemSpecInitProviderActiveDirectoryIdSelector? ActiveDirectoryIdSelector { get; set; }

    /// <summary>An array DNS alias names that you want to associate with the Amazon FSx file system.  For more information, see Working with DNS Aliases</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>The configuration that Amazon FSx for Windows File Server uses to audit and log user accesses of files, folders, and file shares on the Amazon FSx for Windows File Server file system. See Audit Log Configuration below.</summary>
    [JsonPropertyName("auditLogConfiguration")]
    public IList<V1beta1WindowsFileSystemSpecInitProviderAuditLogConfiguration>? AuditLogConfiguration { get; set; }

    /// <summary>The number of days to retain automatic backups. Minimum of 0 and maximum of 90. Defaults to 7. Set to 0 to disable.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>The preferred time (in HH:MM format) to take daily automatic backups, in the UTC time zone.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Specifies the file system deployment type, valid values are MULTI_AZ_1, SINGLE_AZ_1 and SINGLE_AZ_2. Default value is SINGLE_AZ_1.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for Windows File Server file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public IList<V1beta1WindowsFileSystemSpecInitProviderDiskIopsConfiguration>? DiskIopsConfiguration { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1WindowsFileSystemSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Specifies the subnet in which you want the preferred file server to be located. Required for when deployment type is MULTI_AZ_1.</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1WindowsFileSystemSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with active_directory_id. See Self-Managed Active Directory below.</summary>
    [JsonPropertyName("selfManagedActiveDirectory")]
    public IList<V1beta1WindowsFileSystemSpecInitProviderSelfManagedActiveDirectory>? SelfManagedActiveDirectory { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to false.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536. If the storage type is set to HDD the minimum value is 2000. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>Specifies the storage type, Valid values are SSD and HDD. HDD is supported on SINGLE_AZ_2 and MULTI_AZ_1 Windows file system deployment types. Default value is SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1WindowsFileSystemSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1WindowsFileSystemSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. To specify more than a single subnet set deployment_type to MULTI_AZ_1.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of 8 and maximum of 2048.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

public enum V1beta1WindowsFileSystemSpecManagementPoliciesEnum
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

public enum V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1WindowsFileSystemSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1WindowsFileSystemSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WindowsFileSystemSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WindowsFileSystemSpecDeletionPolicyEnum>))]
    public V1beta1WindowsFileSystemSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WindowsFileSystemSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WindowsFileSystemSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WindowsFileSystemSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WindowsFileSystemSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WindowsFileSystemSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WindowsFileSystemSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1WindowsFileSystemStatusAtProviderAuditLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) for the destination of the audit logs. The destination can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis Data Firehose delivery stream ARN. Can be specified when file_access_audit_log_level and file_share_access_audit_log_level are not set to DISABLED. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. The name of the Amazon Kinesis Data Firehouse delivery stream must begin with the aws-fsx prefix. If you do not provide a destination in audit_log_destionation, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/windows log group.</summary>
    [JsonPropertyName("auditLogDestination")]
    public string? AuditLogDestination { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file and folder accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileAccessAuditLogLevel")]
    public string? FileAccessAuditLogLevel { get; set; }

    /// <summary>Sets which attempt type is logged by Amazon FSx for file share accesses. Valid values are SUCCESS_ONLY, FAILURE_ONLY, SUCCESS_AND_FAILURE, and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("fileShareAccessAuditLogLevel")]
    public string? FileShareAccessAuditLogLevel { get; set; }
}

public partial class V1beta1WindowsFileSystemStatusAtProviderDiskIopsConfiguration
{
    /// <summary>- The total number of SSD IOPS provisioned for the file system.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>- Specifies whether the number of IOPS for the file system is using the system. Valid values are AUTOMATIC and USER_PROVISIONED. Default value is AUTOMATIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1WindowsFileSystemStatusAtProviderSelfManagedActiveDirectory
{
    /// <summary>A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD directory. The IP addresses need to be either in the same VPC CIDR range as the file system or in the private IP version 4 (IPv4) address ranges as specified in RFC 1918.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the file system. Administrative privileges include taking ownership of files and folders, and setting audit controls (audit ACLs) on files and folders. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the file system. If none is provided, the FSx file system is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1WindowsFileSystemStatusAtProvider
{
    /// <summary>The ID for an existing Microsoft Active Directory instance that the file system should join when it's created. Cannot be specified with self_managed_active_directory.</summary>
    [JsonPropertyName("activeDirectoryId")]
    public string? ActiveDirectoryId { get; set; }

    /// <summary>An array DNS alias names that you want to associate with the Amazon FSx file system.  For more information, see Working with DNS Aliases</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>Amazon Resource Name of the file system.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The configuration that Amazon FSx for Windows File Server uses to audit and log user accesses of files, folders, and file shares on the Amazon FSx for Windows File Server file system. See Audit Log Configuration below.</summary>
    [JsonPropertyName("auditLogConfiguration")]
    public IList<V1beta1WindowsFileSystemStatusAtProviderAuditLogConfiguration>? AuditLogConfiguration { get; set; }

    /// <summary>The number of days to retain automatic backups. Minimum of 0 and maximum of 90. Defaults to 7. Set to 0 to disable.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags on the file system should be copied to backups. Defaults to false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>The preferred time (in HH:MM format) to take daily automatic backups, in the UTC time zone.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Specifies the file system deployment type, valid values are MULTI_AZ_1, SINGLE_AZ_1 and SINGLE_AZ_2. Default value is SINGLE_AZ_1.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>The SSD IOPS configuration for the Amazon FSx for Windows File Server file system. See Disk Iops Configuration below.</summary>
    [JsonPropertyName("diskIopsConfiguration")]
    public IList<V1beta1WindowsFileSystemStatusAtProviderDiskIopsConfiguration>? DiskIopsConfiguration { get; set; }

    /// <summary>DNS name for the file system, e.g., fs-12345678.corp.example.com (domain name matching the Active Directory domain name)</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>Identifier of the file system (e.g. fs-12345678).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Set of Elastic Network Interface identifiers from which the file system is accessible.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>AWS account identifier that created the file system.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The IP address of the primary, or preferred, file server.</summary>
    [JsonPropertyName("preferredFileServerIp")]
    public string? PreferredFileServerIp { get; set; }

    /// <summary>Specifies the subnet in which you want the preferred file server to be located. Required for when deployment type is MULTI_AZ_1.</summary>
    [JsonPropertyName("preferredSubnetId")]
    public string? PreferredSubnetId { get; set; }

    /// <summary>For MULTI_AZ_1 deployment types, use this endpoint when performing administrative tasks on the file system using Amazon FSx Remote PowerShell. For SINGLE_AZ_1 deployment types, this is the DNS name of the file system.</summary>
    [JsonPropertyName("remoteAdministrationEndpoint")]
    public string? RemoteAdministrationEndpoint { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the Windows File Server instance to your self-managed (including on-premises) Microsoft Active Directory (AD) directory. Cannot be specified with active_directory_id. See Self-Managed Active Directory below.</summary>
    [JsonPropertyName("selfManagedActiveDirectory")]
    public IList<V1beta1WindowsFileSystemStatusAtProviderSelfManagedActiveDirectory>? SelfManagedActiveDirectory { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to false.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>Storage capacity (GiB) of the file system. Minimum of 32 and maximum of 65536. If the storage type is set to HDD the minimum value is 2000. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>Specifies the storage type, Valid values are SSD and HDD. HDD is supported on SINGLE_AZ_2 and MULTI_AZ_1 Windows file system deployment types. Default value is SSD.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. To specify more than a single subnet set deployment_type to MULTI_AZ_1.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput (megabytes per second) of the file system in power of 2 increments. Minimum of 8 and maximum of 2048.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>Identifier of the Virtual Private Cloud for the file system.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

public partial class V1beta1WindowsFileSystemStatusConditions
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

public partial class V1beta1WindowsFileSystemStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WindowsFileSystemStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WindowsFileSystemStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WindowsFileSystem : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WindowsFileSystemSpec>, IStatus<V1beta1WindowsFileSystemStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WindowsFileSystem";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "windowsfilesystems";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WindowsFileSystemSpec defines the desired state of WindowsFileSystem</summary>
    [JsonPropertyName("spec")]
    public V1beta1WindowsFileSystemSpec Spec { get; set; }

    /// <summary>WindowsFileSystemStatus defines the observed state of WindowsFileSystem.</summary>
    [JsonPropertyName("status")]
    public V1beta1WindowsFileSystemStatus? Status { get; set; }
}