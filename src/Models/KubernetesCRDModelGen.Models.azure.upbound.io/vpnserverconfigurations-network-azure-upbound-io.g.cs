using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VPNServerConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>The Secret used to communicate with the Radius Server.</summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderRadiusServerSecretSecretRef
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
public partial class V1beta1VPNServerConfigurationSpecForProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>The Secret used to communicate with the Radius Server.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta1VPNServerConfigurationSpecForProviderRadiusServerSecretSecretRef SecretSecretRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
}

public enum V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecForProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public IList<V1beta1VPNServerConfigurationSpecForProviderRadius>? Radius { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VPNServerConfigurationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationSpecInitProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VPNServerConfigurationSpecInitProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public IList<V1beta1VPNServerConfigurationSpecInitProviderRadius>? Radius { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

public enum V1beta1VPNServerConfigurationSpecManagementPoliciesEnum
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

public enum V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VPNServerConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VPNServerConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VPNServerConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPNServerConfigurationSpec defines the desired state of VPNServerConfiguration</summary>
public partial class V1beta1VPNServerConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNServerConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1VPNServerConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNServerConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNServerConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPNServerConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNServerConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPNServerConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNServerConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNServerConfigurationStatusAtProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>The ID of the VPN Server Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public IList<V1beta1VPNServerConfigurationStatusAtProviderRadius>? Radius { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VPNServerConfigurationStatusConditions
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

/// <summary>VPNServerConfigurationStatus defines the observed state of VPNServerConfiguration.</summary>
public partial class V1beta1VPNServerConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNServerConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNServerConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VPNServerConfiguration is the Schema for the VPNServerConfigurations API. Manages a VPN Server Configuration.</summary>
public partial class V1beta1VPNServerConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNServerConfigurationSpec>, IStatus<V1beta1VPNServerConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNServerConfiguration";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpnserverconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNServerConfigurationSpec defines the desired state of VPNServerConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNServerConfigurationSpec Spec { get; set; }

    /// <summary>VPNServerConfigurationStatus defines the observed state of VPNServerConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNServerConfigurationStatus? Status { get; set; }
}