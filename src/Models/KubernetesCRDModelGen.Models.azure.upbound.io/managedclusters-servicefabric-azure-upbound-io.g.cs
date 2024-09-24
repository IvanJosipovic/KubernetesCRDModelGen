using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicefabric.azure.upbound.io;
public enum V1beta1ManagedClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1ManagedClusterSpecForProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderAuthenticationCertificate
{
    /// <summary>The certificate's CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1ManagedClusterSpecForProviderAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagedClusterSpecForProviderAuthenticationCertificate>? Certificate { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta1ManagedClusterSpecForProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they're created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta1ManagedClusterSpecForProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderPasswordSecretRef
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

public enum V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ManagedClusterSpecForProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ManagedClusterSpecForProviderAuthentication>? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta1ManagedClusterSpecForProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster's name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta1ManagedClusterSpecForProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ManagedClusterSpecForProviderNodeType>? NodeType { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ManagedClusterSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The name of the Resource Group where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ManagedClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderAuthenticationCertificate
{
    /// <summary>The certificate's CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1ManagedClusterSpecInitProviderAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagedClusterSpecInitProviderAuthenticationCertificate>? Certificate { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta1ManagedClusterSpecInitProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they're created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta1ManagedClusterSpecInitProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1ManagedClusterSpecInitProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ManagedClusterSpecInitProviderAuthentication>? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta1ManagedClusterSpecInitProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster's name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta1ManagedClusterSpecInitProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ManagedClusterSpecInitProviderNodeType>? NodeType { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1ManagedClusterSpecManagementPoliciesEnum
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

public enum V1beta1ManagedClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ManagedClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ManagedClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ManagedClusterSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ManagedClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ManagedClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ManagedClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedClusterSpecDeletionPolicyEnum>))]
    public V1beta1ManagedClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagedClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagedClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ManagedClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagedClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ManagedClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagedClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderAuthenticationActiveDirectory
{
    /// <summary>The ID of the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The ID of the Cluster Application.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The ID of the Tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderAuthenticationCertificate
{
    /// <summary>The certificate's CN.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The type of the certificate. Can be AdminClient or ReadOnlyClient.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderAuthentication
{
    /// <summary>A active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public IList<V1beta1ManagedClusterStatusAtProviderAuthenticationActiveDirectory>? ActiveDirectory { get; set; }

    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ManagedClusterStatusAtProviderAuthenticationCertificate>? Certificate { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderCustomFabricSetting
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Section name.</summary>
    [JsonPropertyName("section")]
    public string? Section { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderLbRule
{
    /// <summary>LB Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>LB Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Protocol for the probe. Can be one of tcp, udp, http, or https.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>Path for the probe to check, when probe protocol is set to http.</summary>
    [JsonPropertyName("probeRequestPath")]
    public string? ProbeRequestPath { get; set; }

    /// <summary>The transport protocol used in this rule. Can be one of tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderNodeTypeVmSecretsCertificates
{
    /// <summary>The certificate store on the Virtual Machine to which the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The URL of a certificate that has been uploaded to Key Vault as a secret</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderNodeTypeVmSecrets
{
    /// <summary>One or more certificates blocks as defined above.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1beta1ManagedClusterStatusAtProviderNodeTypeVmSecretsCertificates>? Certificates { get; set; }

    /// <summary>The ID of the Vault that contain the certificates.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProviderNodeType
{
    /// <summary>Sets the port range available for applications. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000.</summary>
    [JsonPropertyName("applicationPortRange")]
    public string? ApplicationPortRange { get; set; }

    /// <summary>Specifies a list of key/value pairs used to set capacity tags for this node type.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The size of the data disk in gigabytes..</summary>
    [JsonPropertyName("dataDiskSizeGb")]
    public double? DataDiskSizeGb { get; set; }

    /// <summary>The type of the disk to use for storing data. It can be one of Premium_LRS, Standard_LRS, or StandardSSD_LRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("dataDiskType")]
    public string? DataDiskType { get; set; }

    /// <summary>Sets the port range available for the OS. Format is &lt;from_port&gt;-&lt;to_port&gt;, for example 10000-20000. There has to be at least 255 ports available and cannot overlap with application_port_range..</summary>
    [JsonPropertyName("ephemeralPortRange")]
    public string? EphemeralPortRange { get; set; }

    /// <summary>The ID of the Resource Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set the node type can be composed of multiple placement groups.</summary>
    [JsonPropertyName("multiplePlacementGroupsEnabled")]
    public bool? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>The name which should be used for this node type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of placement tags that can be used to indicate where services should run..</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>If set to true, system services will run on this node type. Only one node type should be marked as primary. Primary node type cannot be deleted or changed once they're created.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>If set to true, only stateless workloads can run on this node type.</summary>
    [JsonPropertyName("stateless")]
    public bool? Stateless { get; set; }

    /// <summary>The offer type of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageOffer")]
    public string? VmImageOffer { get; set; }

    /// <summary>The publisher of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImagePublisher")]
    public string? VmImagePublisher { get; set; }

    /// <summary>The SKU of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageSku")]
    public string? VmImageSku { get; set; }

    /// <summary>The version of the marketplace image cluster VMs will use.</summary>
    [JsonPropertyName("vmImageVersion")]
    public string? VmImageVersion { get; set; }

    /// <summary>The number of instances this node type will launch.</summary>
    [JsonPropertyName("vmInstanceCount")]
    public double? VmInstanceCount { get; set; }

    /// <summary>One or more vm_secrets blocks as defined below.</summary>
    [JsonPropertyName("vmSecrets")]
    public IList<V1beta1ManagedClusterStatusAtProviderNodeTypeVmSecrets>? VmSecrets { get; set; }

    /// <summary>The size of the instances in this node type.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1ManagedClusterStatusAtProvider
{
    /// <summary>Controls how connections to the cluster are authenticated. A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ManagedClusterStatusAtProviderAuthentication>? Authentication { get; set; }

    /// <summary>If true, backup service is enabled.</summary>
    [JsonPropertyName("backupServiceEnabled")]
    public bool? BackupServiceEnabled { get; set; }

    /// <summary>Port to use when connecting to the cluster.</summary>
    [JsonPropertyName("clientConnectionPort")]
    public double? ClientConnectionPort { get; set; }

    /// <summary>One or more custom_fabric_setting blocks as defined below.</summary>
    [JsonPropertyName("customFabricSetting")]
    public IList<V1beta1ManagedClusterStatusAtProviderCustomFabricSetting>? CustomFabricSetting { get; set; }

    /// <summary>Hostname for the cluster. If unset the cluster's name will be used..</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>If true, DNS service is enabled.</summary>
    [JsonPropertyName("dnsServiceEnabled")]
    public bool? DnsServiceEnabled { get; set; }

    /// <summary>Port that should be used by the Service Fabric Explorer to visualize applications and cluster status.</summary>
    [JsonPropertyName("httpGatewayPort")]
    public double? HttpGatewayPort { get; set; }

    /// <summary>The ID of the Resource Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more lb_rule blocks as defined below.</summary>
    [JsonPropertyName("lbRule")]
    public IList<V1beta1ManagedClusterStatusAtProviderLbRule>? LbRule { get; set; }

    /// <summary>The Azure Region where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ManagedClusterStatusAtProviderNodeType>? NodeType { get; set; }

    /// <summary>The name of the Resource Group where the Resource Group should exist. Changing this forces a new Resource Group to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>SKU for this cluster. Changing this forces a new resource to be created. Default is Basic, allowed values are either Basic or Standard.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Resource Group.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Upgrade wave for the fabric runtime. Default is Wave0, allowed value must be one of Wave0, Wave1, or Wave2.</summary>
    [JsonPropertyName("upgradeWave")]
    public string? UpgradeWave { get; set; }

    /// <summary>Administrator password for the VMs that will be created as part of this cluster.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1ManagedClusterStatusConditions
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

public partial class V1beta1ManagedClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagedClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedClusterSpec>, IStatus<V1beta1ManagedClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
    public const string KubePluralName = "managedclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedClusterSpec defines the desired state of ManagedCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagedClusterSpec Spec { get; set; }

    /// <summary>ManagedClusterStatus defines the observed state of ManagedCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedClusterStatus? Status { get; set; }
}