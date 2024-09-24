using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fsx.aws.upbound.io;
public enum V1beta1OntapStorageVirtualMachineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationPasswordSecretRef
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

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration
{
    /// <summary>A list of up to three IP addresses of DNS servers or domain controllers in the self-managed AD directory.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the SVM. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the SVM. If none is provided, the SVM is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfiguration
{
    /// <summary>The NetBIOS name of the Active Directory computer object that will be created for your SVM. This is often the same as the SVM name but can be different. AWS limits to 15 characters because of standard NetBIOS naming limits.</summary>
    [JsonPropertyName("netbiosName")]
    public string? NetbiosName { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("selfManagedActiveDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration>? SelfManagedActiveDirectoryConfiguration { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecForProviderSvmAdminPasswordSecretRef
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

public partial class V1beta1OntapStorageVirtualMachineSpecForProvider
{
    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("activeDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineSpecForProviderActiveDirectoryConfiguration>? ActiveDirectoryConfiguration { get; set; }

    /// <summary>The ID of the Amazon FSx ONTAP File System that this SVM will be created on.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a OntapFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a OntapFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>The name of the SVM. You can use a maximum of 47 alphanumeric characters, plus the underscore (_) special character.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the root volume security style, Valid values are UNIX, NTFS, and MIXED. All volumes created under this SVM will inherit the root security style unless the security style is specified on the volume. Default value is UNIX.</summary>
    [JsonPropertyName("rootVolumeSecurityStyle")]
    public string? RootVolumeSecurityStyle { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("svmAdminPasswordSecretRef")]
    public V1beta1OntapStorageVirtualMachineSpecForProviderSvmAdminPasswordSecretRef? SvmAdminPasswordSecretRef { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationPasswordSecretRef
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

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration
{
    /// <summary>A list of up to three IP addresses of DNS servers or domain controllers in the self-managed AD directory.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the SVM. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the SVM. If none is provided, the SVM is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The password for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfiguration
{
    /// <summary>The NetBIOS name of the Active Directory computer object that will be created for your SVM. This is often the same as the SVM name but can be different. AWS limits to 15 characters because of standard NetBIOS naming limits.</summary>
    [JsonPropertyName("netbiosName")]
    public string? NetbiosName { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("selfManagedActiveDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration>? SelfManagedActiveDirectoryConfiguration { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecInitProviderSvmAdminPasswordSecretRef
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

public partial class V1beta1OntapStorageVirtualMachineSpecInitProvider
{
    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("activeDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineSpecInitProviderActiveDirectoryConfiguration>? ActiveDirectoryConfiguration { get; set; }

    /// <summary>The ID of the Amazon FSx ONTAP File System that this SVM will be created on.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Reference to a OntapFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdRef")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdRef? FileSystemIdRef { get; set; }

    /// <summary>Selector for a OntapFileSystem in fsx to populate fileSystemId.</summary>
    [JsonPropertyName("fileSystemIdSelector")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderFileSystemIdSelector? FileSystemIdSelector { get; set; }

    /// <summary>The name of the SVM. You can use a maximum of 47 alphanumeric characters, plus the underscore (_) special character.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the root volume security style, Valid values are UNIX, NTFS, and MIXED. All volumes created under this SVM will inherit the root security style unless the security style is specified on the volume. Default value is UNIX.</summary>
    [JsonPropertyName("rootVolumeSecurityStyle")]
    public string? RootVolumeSecurityStyle { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("svmAdminPasswordSecretRef")]
    public V1beta1OntapStorageVirtualMachineSpecInitProviderSvmAdminPasswordSecretRef? SvmAdminPasswordSecretRef { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecManagementPoliciesEnum
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

public enum V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OntapStorageVirtualMachineSpecDeletionPolicyEnum>))]
    public V1beta1OntapStorageVirtualMachineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OntapStorageVirtualMachineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OntapStorageVirtualMachineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1OntapStorageVirtualMachineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OntapStorageVirtualMachineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1OntapStorageVirtualMachineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OntapStorageVirtualMachineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration
{
    /// <summary>A list of up to three IP addresses of DNS servers or domain controllers in the self-managed AD directory.</summary>
    [JsonPropertyName("dnsIps")]
    public IList<string>? DnsIps { get; set; }

    /// <summary>The fully qualified domain name of the self-managed AD directory. For example, corp.example.com.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The name of the domain group whose members are granted administrative privileges for the SVM. The group that you specify must already exist in your domain. Defaults to Domain Admins.</summary>
    [JsonPropertyName("fileSystemAdministratorsGroup")]
    public string? FileSystemAdministratorsGroup { get; set; }

    /// <summary>The fully qualified distinguished name of the organizational unit within your self-managed AD directory that the Windows File Server instance will join. For example, OU=FSx,DC=yourdomain,DC=corp,DC=com. Only accepts OU as the direct parent of the SVM. If none is provided, the SVM is created in the default location of your self-managed AD directory. To learn more, see RFC 2253.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>The user name for the service account on your self-managed AD domain that Amazon FSx will use to join to your AD domain.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderActiveDirectoryConfiguration
{
    /// <summary>The NetBIOS name of the Active Directory computer object that will be created for your SVM. This is often the same as the SVM name but can be different. AWS limits to 15 characters because of standard NetBIOS naming limits.</summary>
    [JsonPropertyName("netbiosName")]
    public string? NetbiosName { get; set; }

    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("selfManagedActiveDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration>? SelfManagedActiveDirectoryConfiguration { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsIscsi
{
    /// <summary>The Domain Name Service (DNS) name for the storage virtual machine. You can mount your storage virtual machine using its DNS name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the storage virtual machine endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsManagement
{
    /// <summary>The Domain Name Service (DNS) name for the storage virtual machine. You can mount your storage virtual machine using its DNS name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the storage virtual machine endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsNfs
{
    /// <summary>The Domain Name Service (DNS) name for the storage virtual machine. You can mount your storage virtual machine using its DNS name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the storage virtual machine endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsSmb
{
    /// <summary>The Domain Name Service (DNS) name for the storage virtual machine. You can mount your storage virtual machine using its DNS name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>IP addresses of the storage virtual machine endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProviderEndpoints
{
    /// <summary>An endpoint for accessing data on your storage virtual machine via iSCSI protocol. See Endpoint.</summary>
    [JsonPropertyName("iscsi")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsIscsi>? Iscsi { get; set; }

    /// <summary>An endpoint for managing your file system using the NetApp ONTAP CLI and NetApp ONTAP API. See Endpoint.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsManagement>? Management { get; set; }

    /// <summary>An endpoint for accessing data on your storage virtual machine via NFS protocol. See Endpoint.</summary>
    [JsonPropertyName("nfs")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsNfs>? Nfs { get; set; }

    /// <summary>An endpoint for accessing data on your storage virtual machine via SMB protocol. This is only set if an active_directory_configuration has been set. See Endpoint.</summary>
    [JsonPropertyName("smb")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderEndpointsSmb>? Smb { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusAtProvider
{
    /// <summary>Configuration block that Amazon FSx uses to join the FSx ONTAP Storage Virtual Machine(SVM) to your Microsoft Active Directory (AD) directory. Detailed below.</summary>
    [JsonPropertyName("activeDirectoryConfiguration")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderActiveDirectoryConfiguration>? ActiveDirectoryConfiguration { get; set; }

    /// <summary>Amazon Resource Name of the storage virtual machine.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The endpoints that are used to access data or to manage the storage virtual machine using the NetApp ONTAP CLI, REST API, or NetApp SnapMirror. See Endpoints below.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1beta1OntapStorageVirtualMachineStatusAtProviderEndpoints>? Endpoints { get; set; }

    /// <summary>The ID of the Amazon FSx ONTAP File System that this SVM will be created on.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Identifier of the storage virtual machine, e.g., svm-12345678</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the SVM. You can use a maximum of 47 alphanumeric characters, plus the underscore (_) special character.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the root volume security style, Valid values are UNIX, NTFS, and MIXED. All volumes created under this SVM will inherit the root security style unless the security style is specified on the volume. Default value is UNIX.</summary>
    [JsonPropertyName("rootVolumeSecurityStyle")]
    public string? RootVolumeSecurityStyle { get; set; }

    /// <summary>Describes the SVM's subtype, e.g. DEFAULT</summary>
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The SVM's UUID (universally unique identifier).</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public partial class V1beta1OntapStorageVirtualMachineStatusConditions
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

public partial class V1beta1OntapStorageVirtualMachineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OntapStorageVirtualMachineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OntapStorageVirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OntapStorageVirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OntapStorageVirtualMachineSpec>, IStatus<V1beta1OntapStorageVirtualMachineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OntapStorageVirtualMachine";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "ontapstoragevirtualmachines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OntapStorageVirtualMachineSpec defines the desired state of OntapStorageVirtualMachine</summary>
    [JsonPropertyName("spec")]
    public V1beta1OntapStorageVirtualMachineSpec Spec { get; set; }

    /// <summary>OntapStorageVirtualMachineStatus defines the observed state of OntapStorageVirtualMachine.</summary>
    [JsonPropertyName("status")]
    public V1beta1OntapStorageVirtualMachineStatus? Status { get; set; }
}