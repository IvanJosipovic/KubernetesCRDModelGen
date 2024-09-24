using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagecache.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecDeletionPolicyEnum
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
public partial class V1beta1HPCCacheSpecForProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheSpecForProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryActiveDirectoryPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain's NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HPCCacheSpecForProviderDirectoryActiveDirectoryPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary>The password of the Active Directory domain administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryLdapBindPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }

    /// <summary>The password of the Active Directory domain administrator.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HPCCacheSpecForProviderDirectoryLdapBindPasswordSecretRef PasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public IList<V1beta1HPCCacheSpecForProviderDirectoryLdapBind>? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecForProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public IList<V1beta1HPCCacheSpecForProviderDefaultAccessPolicy>? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public IList<V1beta1HPCCacheSpecForProviderDirectoryActiveDirectory>? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public IList<V1beta1HPCCacheSpecForProviderDirectoryFlatFile>? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public IList<V1beta1HPCCacheSpecForProviderDirectoryLdap>? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1HPCCacheSpecForProviderDns>? Dns { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HPCCacheSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HPCCacheSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HPCCacheSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HPCCacheSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheSpecInitProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain's NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public IList<V1beta1HPCCacheSpecInitProviderDirectoryLdapBind>? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecInitProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public IList<V1beta1HPCCacheSpecInitProviderDefaultAccessPolicy>? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public IList<V1beta1HPCCacheSpecInitProviderDirectoryActiveDirectory>? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public IList<V1beta1HPCCacheSpecInitProviderDirectoryFlatFile>? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public IList<V1beta1HPCCacheSpecInitProviderDirectoryLdap>? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1HPCCacheSpecInitProviderDns>? Dns { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HPCCacheSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HPCCacheSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HPCCacheSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecManagementPoliciesEnum
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
public enum V1beta1HPCCacheSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1HPCCacheSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1HPCCacheSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1HPCCacheSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>HPCCacheSpec defines the desired state of HPCCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheSpecDeletionPolicyEnum>))]
    public V1beta1HPCCacheSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HPCCacheSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HPCCacheSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1HPCCacheSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HPCCacheSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1HPCCacheSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HPCCacheSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDefaultAccessPolicyAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDefaultAccessPolicy
{
    /// <summary>One or more access_rule blocks (up to three) as defined above.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheStatusAtProviderDefaultAccessPolicyAccessRule>? AccessRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDirectoryActiveDirectory
{
    /// <summary>The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server.</summary>
    [JsonPropertyName("cacheNetbiosName")]
    public string? CacheNetbiosName { get; set; }

    /// <summary>The primary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsPrimaryIp")]
    public string? DnsPrimaryIp { get; set; }

    /// <summary>The secondary DNS IP address used to resolve the Active Directory domain controller's FQDN.</summary>
    [JsonPropertyName("dnsSecondaryIp")]
    public string? DnsSecondaryIp { get; set; }

    /// <summary>The fully qualified domain name of the Active Directory domain controller.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The Active Directory domain's NetBIOS name.</summary>
    [JsonPropertyName("domainNetbiosName")]
    public string? DomainNetbiosName { get; set; }

    /// <summary>The username of the Active Directory domain administrator.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDirectoryFlatFile
{
    /// <summary>The URI of the file containing group information (/etc/group file format in Unix-like OS).</summary>
    [JsonPropertyName("groupFileUri")]
    public string? GroupFileUri { get; set; }

    /// <summary>The URI of the file containing user information (/etc/passwd file format in Unix-like OS).</summary>
    [JsonPropertyName("passwordFileUri")]
    public string? PasswordFileUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDirectoryLdapBind
{
    /// <summary>The Bind Distinguished Name (DN) identity to be used in the secure LDAP connection.</summary>
    [JsonPropertyName("dn")]
    public string? Dn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDirectoryLdap
{
    /// <summary>The base distinguished name (DN) for the LDAP domain.</summary>
    [JsonPropertyName("baseDn")]
    public string? BaseDn { get; set; }

    /// <summary>A bind block as defined above.</summary>
    [JsonPropertyName("bind")]
    public IList<V1beta1HPCCacheStatusAtProviderDirectoryLdapBind>? Bind { get; set; }

    /// <summary>The URI of the CA certificate to validate the LDAP secure connection.</summary>
    [JsonPropertyName("certificateValidationUri")]
    public string? CertificateValidationUri { get; set; }

    /// <summary>Whether the certificate should be automatically downloaded. This can be set to true only when certificate_validation_uri is provided.</summary>
    [JsonPropertyName("downloadCertificateAutomatically")]
    public bool? DownloadCertificateAutomatically { get; set; }

    /// <summary>Whether the LDAP connection should be encrypted?</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>The FQDN or IP address of the LDAP server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderDns
{
    /// <summary>The DNS search domain for the HPC Cache.</summary>
    [JsonPropertyName("searchDomain")]
    public string? SearchDomain { get; set; }

    /// <summary>A list of DNS servers for the HPC Cache. At most three IP(s) are allowed to set.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this HPC Cache. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusAtProvider
{
    /// <summary>Specifies whether the HPC Cache automatically rotates Encryption Key to the latest version.</summary>
    [JsonPropertyName("automaticallyRotateKeyToLatestEnabled")]
    public bool? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>The size of the HPC Cache, in GB. Possible values are 3072, 6144, 12288, 21623, 24576, 43246, 49152 and 86491. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cacheSizeInGb")]
    public double? CacheSizeInGb { get; set; }

    /// <summary>A default_access_policy block as defined below.</summary>
    [JsonPropertyName("defaultAccessPolicy")]
    public IList<V1beta1HPCCacheStatusAtProviderDefaultAccessPolicy>? DefaultAccessPolicy { get; set; }

    /// <summary>A directory_active_directory block as defined below.</summary>
    [JsonPropertyName("directoryActiveDirectory")]
    public IList<V1beta1HPCCacheStatusAtProviderDirectoryActiveDirectory>? DirectoryActiveDirectory { get; set; }

    /// <summary>A directory_flat_file block as defined below.</summary>
    [JsonPropertyName("directoryFlatFile")]
    public IList<V1beta1HPCCacheStatusAtProviderDirectoryFlatFile>? DirectoryFlatFile { get; set; }

    /// <summary>A directory_ldap block as defined below.</summary>
    [JsonPropertyName("directoryLdap")]
    public IList<V1beta1HPCCacheStatusAtProviderDirectoryLdap>? DirectoryLdap { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public IList<V1beta1HPCCacheStatusAtProviderDns>? Dns { get; set; }

    /// <summary>The id of the HPC Cache.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1HPCCacheStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The ID of the Key Vault Key which should be used to encrypt the data in this HPC Cache.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of IP Addresses where the HPC Cache can be mounted.</summary>
    [JsonPropertyName("mountAddresses")]
    public IList<string>? MountAddresses { get; set; }

    /// <summary>The IPv4 maximum transmission unit configured for the subnet of the HPC Cache. Possible values range from 576 - 1500. Defaults to 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The NTP server IP Address or FQDN for the HPC Cache. Defaults to time.windows.com.</summary>
    [JsonPropertyName("ntpServer")]
    public string? NtpServer { get; set; }

    /// <summary>The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The SKU of HPC Cache to use. Possible values are (ReadWrite) - Standard_2G, Standard_4G Standard_8G or (ReadOnly) - Standard_L4_5G, Standard_L9G, and Standard_L16G. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the HPC Cache.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatusConditions
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

/// <summary>HPCCacheStatus defines the observed state of HPCCache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HPCCacheStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HPCCacheStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>HPCCache is the Schema for the HPCCaches API. Manages a HPC Cache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HPCCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HPCCacheSpec>, IStatus<V1beta1HPCCacheStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCache";
    public const string KubeGroup = "storagecache.azure.upbound.io";
    public const string KubePluralName = "hpccaches";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HPCCacheSpec defines the desired state of HPCCache</summary>
    [JsonPropertyName("spec")]
    public V1beta1HPCCacheSpec Spec { get; set; }

    /// <summary>HPCCacheStatus defines the observed state of HPCCache.</summary>
    [JsonPropertyName("status")]
    public V1beta1HPCCacheStatus? Status { get; set; }
}