using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hdinsight.azure.upbound.io;
public enum V1beta1HadoopClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1HadoopClusterSpecForProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderExtensionPrimaryKeySecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1HadoopClusterSpecForProviderExtensionPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderGatewayPasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderGatewayPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderMetastoresAmbariPasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderMetastoresAmbariPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderMetastoresHivePasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderMetastoresHive
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderMetastoresHivePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderMetastoresOoziePasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderMetastoresOoziePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1HadoopClusterSpecForProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1HadoopClusterSpecForProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1HadoopClusterSpecForProviderMetastoresOozie>? Oozie { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderMonitorPrimaryKeySecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1HadoopClusterSpecForProviderMonitorPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private ip address of the endpoint.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application's subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodePasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecForProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleCapacity>? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscaleRecurrence>? Recurrence { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodePasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeAutoscale>? Autoscale { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecForProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodePasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesEdgeNode>? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1HadoopClusterSpecForProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef
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

public partial class V1beta1HadoopClusterSpecForProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUserPasswordSecretRef")]
    public V1beta1HadoopClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef DomainUserPasswordSecretRef { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountStorageAccountKeySecretRef
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

public enum V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageAccountKeySecretRef StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta1HadoopClusterSpecForProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecForProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1HadoopClusterSpecForProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1HadoopClusterSpecForProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1HadoopClusterSpecForProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1HadoopClusterSpecForProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1HadoopClusterSpecForProviderGateway>? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1HadoopClusterSpecForProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1HadoopClusterSpecForProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1HadoopClusterSpecForProviderNetwork>? Network { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HadoopClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1HadoopClusterSpecForProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1HadoopClusterSpecForProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1HadoopClusterSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1HadoopClusterSpecForProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderGateway
{
    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderMetastoresHive
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1HadoopClusterSpecInitProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1HadoopClusterSpecInitProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1HadoopClusterSpecInitProviderMetastoresOozie>? Oozie { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private ip address of the endpoint.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application's subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesHeadNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecInitProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleCapacity>? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscaleRecurrence>? Recurrence { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeAutoscale>? Autoscale { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRolesZookeeperNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1HadoopClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesEdgeNode>? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1HadoopClusterSpecInitProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta1HadoopClusterSpecInitProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterSpecInitProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1HadoopClusterSpecInitProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1HadoopClusterSpecInitProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1HadoopClusterSpecInitProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1HadoopClusterSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1HadoopClusterSpecInitProviderGateway>? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1HadoopClusterSpecInitProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1HadoopClusterSpecInitProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1HadoopClusterSpecInitProviderNetwork>? Network { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1HadoopClusterSpecInitProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1HadoopClusterSpecInitProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1HadoopClusterSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1HadoopClusterSpecInitProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

public enum V1beta1HadoopClusterSpecManagementPoliciesEnum
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

public enum V1beta1HadoopClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1HadoopClusterSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1HadoopClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1HadoopClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1HadoopClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HadoopClusterSpecDeletionPolicyEnum>))]
    public V1beta1HadoopClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HadoopClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HadoopClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1HadoopClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HadoopClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1HadoopClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HadoopClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderComponentVersion
{
    /// <summary>The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hadoop")]
    public string? Hadoop { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderDiskEncryption
{
    /// <summary>This is an algorithm identifier for encryption. Possible values are RSA1_5, RSA-OAEP, RSA-OAEP-256.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>This is indicator to show whether resource disk encryption is enabled.</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The ID of the key vault key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>This is the resource ID of Managed Identity used to access the key vault.</summary>
    [JsonPropertyName("keyVaultManagedIdentityId")]
    public string? KeyVaultManagedIdentityId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderGateway
{
    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderMetastoresHive
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1HadoopClusterStatusAtProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1HadoopClusterStatusAtProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1HadoopClusterStatusAtProviderMetastoresOozie>? Oozie { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeHttpsEndpoints
{
    /// <summary>A list of access modes for the application.</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>The destination port to connect to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>The value indicates whether the gateway authentication is enabled or not.</summary>
    [JsonPropertyName("disableGatewayAuth")]
    public bool? DisableGatewayAuth { get; set; }

    /// <summary>The private ip address of the endpoint.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The application's subdomain suffix.</summary>
    [JsonPropertyName("subDomainSuffix")]
    public string? SubDomainSuffix { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeInstallScriptAction
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeUninstallScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesEdgeNode
{
    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster. One or more https_endpoints blocks as defined below.</summary>
    [JsonPropertyName("httpsEndpoints")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeHttpsEndpoints>? HttpsEndpoints { get; set; }

    /// <summary>A install_script_action block as defined below.</summary>
    [JsonPropertyName("installScriptAction")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeInstallScriptAction>? InstallScriptAction { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>A uninstall_script_actions block as defined below.</summary>
    [JsonPropertyName("uninstallScriptActions")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesEdgeNodeUninstallScriptActions>? UninstallScriptActions { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesHeadNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleCapacity
{
    /// <summary>The maximum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>The minimum number of worker nodes to autoscale to based on the cluster's activity.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrenceSchedule
{
    /// <summary>The days of the week to perform autoscale. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The time of day to perform the autoscale in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrence
{
    /// <summary>A list of schedule blocks as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The time zone for the autoscale schedule times.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscale
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleCapacity>? Capacity { get; set; }

    /// <summary>A recurrence block as defined below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscaleRecurrence>? Recurrence { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesWorkerNode
{
    /// <summary>A autoscale block as defined below.</summary>
    [JsonPropertyName("autoscale")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeAutoscale>? Autoscale { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the uninstall script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI pointing to the script to run during the installation of the edge node.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRolesZookeeperNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined above.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderRoles
{
    /// <summary>A edge_node block as defined below.</summary>
    [JsonPropertyName("edgeNode")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesEdgeNode>? EdgeNode { get; set; }

    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1HadoopClusterStatusAtProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderSecurityProfile
{
    /// <summary>The resource ID of the Azure Active Directory Domain Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("aaddsResourceId")]
    public string? AaddsResourceId { get; set; }

    /// <summary>A list of the distinguished names for the cluster user groups. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterUsersGroupDns")]
    public IList<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>The name of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The username of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("domainUsername")]
    public string? DomainUsername { get; set; }

    /// <summary>A list of the LDAPS URLs to communicate with the Azure Active Directory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ldapsUrls")]
    public IList<string>? LdapsUrls { get; set; }

    /// <summary>The User Assigned Identity for the HDInsight Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProviderStorageAccountGen2
{
    /// <summary>The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemId")]
    public string? FilesystemId { get; set; }

    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

public partial class V1beta1HadoopClusterStatusAtProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1HadoopClusterStatusAtProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1HadoopClusterStatusAtProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1HadoopClusterStatusAtProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1HadoopClusterStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1HadoopClusterStatusAtProviderGateway>? Gateway { get; set; }

    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("httpsEndpoint")]
    public string? HttpsEndpoint { get; set; }

    /// <summary>The ID of the HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1HadoopClusterStatusAtProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1HadoopClusterStatusAtProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1HadoopClusterStatusAtProviderNetwork>? Network { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1HadoopClusterStatusAtProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1HadoopClusterStatusAtProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>The SSH Connectivity Endpoint for this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("sshEndpoint")]
    public string? SshEndpoint { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1HadoopClusterStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1HadoopClusterStatusAtProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Hadoop Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

public partial class V1beta1HadoopClusterStatusConditions
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

public partial class V1beta1HadoopClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HadoopClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HadoopClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HadoopCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HadoopClusterSpec>, IStatus<V1beta1HadoopClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HadoopCluster";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "hadoopclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HadoopClusterSpec defines the desired state of HadoopCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1HadoopClusterSpec Spec { get; set; }

    /// <summary>HadoopClusterStatus defines the observed state of HadoopCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1HadoopClusterStatus? Status { get; set; }
}