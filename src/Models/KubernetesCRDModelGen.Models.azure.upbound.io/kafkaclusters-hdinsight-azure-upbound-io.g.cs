using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hdinsight.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderDiskEncryption
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

/// <summary>The workspace key of the log analytics extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderExtensionPrimaryKeySecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1KafkaClusterSpecForProviderExtensionPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderGatewayPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderGatewayPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderMetastoresAmbariPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderMetastoresAmbariPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderMetastoresHivePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderMetastoresHive
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderMetastoresHivePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderMetastoresOoziePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderMetastoresOoziePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1KafkaClusterSpecForProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1KafkaClusterSpecForProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1KafkaClusterSpecForProviderMetastoresOozie>? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderMonitorPrimaryKeySecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1KafkaClusterSpecForProviderMonitorPrimaryKeySecretRef? PrimaryKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. The only possible value now is Dynamic.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1KafkaClusterSpecForProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecForProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecForProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecForProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecForProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesKafkaManagementNode>? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1KafkaClusterSpecForProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecForProviderSecurityProfile
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
    public V1beta1KafkaClusterSpecForProviderSecurityProfileDomainUserPasswordSecretRef? DomainUserPasswordSecretRef { get; set; }

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

/// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountStorageAccountKeySecretRef
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public V1beta1KafkaClusterSpecForProviderStorageAccountStorageAccountKeySecretRef? StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta1KafkaClusterSpecForProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProviderStorageAccountGen2
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecForProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1KafkaClusterSpecForProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1KafkaClusterSpecForProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1KafkaClusterSpecForProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1KafkaClusterSpecForProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1KafkaClusterSpecForProviderGateway>? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1KafkaClusterSpecForProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1KafkaClusterSpecForProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1KafkaClusterSpecForProviderNetwork>? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1KafkaClusterSpecForProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1KafkaClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1KafkaClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public IList<V1beta1KafkaClusterSpecForProviderRestProxy>? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1KafkaClusterSpecForProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1KafkaClusterSpecForProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1KafkaClusterSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1KafkaClusterSpecForProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderDiskEncryption
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

/// <summary>The workspace key of the log analytics extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderExtensionPrimaryKeySecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The workspace key of the log analytics extension.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1KafkaClusterSpecInitProviderExtensionPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary>The password used for the Ambari Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderGatewayPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderGateway
{
    /// <summary>The password used for the Ambari Portal.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderGatewayPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresAmbariPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresAmbari
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderMetastoresAmbariPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresHivePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresHive
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderMetastoresHivePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresOoziePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderMetastoresOozie
{
    /// <summary>The external Oozie metastore's existing SQL database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderMetastoresOoziePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1KafkaClusterSpecInitProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1KafkaClusterSpecInitProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1KafkaClusterSpecInitProviderMetastoresOozie>? Oozie { get; set; }
}

/// <summary>The Operations Management Suite (OMS) workspace key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderMonitorPrimaryKeySecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Operations Management Suite (OMS) workspace key.</summary>
    [JsonPropertyName("primaryKeySecretRef")]
    public V1beta1KafkaClusterSpecInitProviderMonitorPrimaryKeySecretRef PrimaryKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. The only possible value now is Dynamic.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1KafkaClusterSpecInitProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesHeadNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesHeadNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderRolesHeadNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesWorkerNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderRolesWorkerNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The number of instances which should be run for the Worker Nodes.</summary>
    [JsonPropertyName("targetInstanceCount")]
    public double? TargetInstanceCount { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRolesZookeeperNode
{
    /// <summary>The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

    /// <summary>A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sshKeys")]
    public IList<string>? SshKeys { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderRolesZookeeperNodeSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesKafkaManagementNode>? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1KafkaClusterSpecInitProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

/// <summary>The user password of the Azure Active Directory Domain. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef
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
public partial class V1beta1KafkaClusterSpecInitProviderSecurityProfile
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
    public V1beta1KafkaClusterSpecInitProviderSecurityProfileDomainUserPasswordSecretRef DomainUserPasswordSecretRef { get; set; }

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

/// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccount
{
    /// <summary>Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountKeySecretRef")]
    public V1beta1KafkaClusterSpecInitProviderStorageAccountStorageAccountKeySecretRef StorageAccountKeySecretRef { get; set; }

    /// <summary>The ID of the Storage Container. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdRef")]
    public V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdRef? StorageContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerId.</summary>
    [JsonPropertyName("storageContainerIdSelector")]
    public V1beta1KafkaClusterSpecInitProviderStorageAccountStorageContainerIdSelector? StorageContainerIdSelector { get; set; }

    /// <summary>The ID of the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageResourceId")]
    public string? StorageResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProviderStorageAccountGen2
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

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecInitProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1KafkaClusterSpecInitProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1KafkaClusterSpecInitProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1KafkaClusterSpecInitProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1KafkaClusterSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1KafkaClusterSpecInitProviderGateway>? Gateway { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1KafkaClusterSpecInitProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1KafkaClusterSpecInitProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1KafkaClusterSpecInitProviderNetwork>? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1KafkaClusterSpecInitProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public IList<V1beta1KafkaClusterSpecInitProviderRestProxy>? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1KafkaClusterSpecInitProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1KafkaClusterSpecInitProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1KafkaClusterSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1KafkaClusterSpecInitProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecProviderConfigRefPolicy
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
public partial class V1beta1KafkaClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KafkaClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1KafkaClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1KafkaClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1KafkaClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>KafkaClusterSpec defines the desired state of KafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KafkaClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KafkaClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KafkaClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1KafkaClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KafkaClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderComponentVersion
{
    /// <summary>The version of Kafka which should be used for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kafka")]
    public string? Kafka { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderComputeIsolation
{
    /// <summary>This field indicates whether enable compute isolation or not. Possible values are true or false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>The name of the host SKU.</summary>
    [JsonPropertyName("hostSku")]
    public string? HostSku { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderDiskEncryption
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderExtension
{
    /// <summary>The workspace ID of the log analytics extension.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderGateway
{
    /// <summary>The username used for the Ambari Portal. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderMetastoresAmbari
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderMetastoresHive
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderMetastoresOozie
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderMetastores
{
    /// <summary>An ambari block as defined below.</summary>
    [JsonPropertyName("ambari")]
    public IList<V1beta1KafkaClusterStatusAtProviderMetastoresAmbari>? Ambari { get; set; }

    /// <summary>A hive block as defined below.</summary>
    [JsonPropertyName("hive")]
    public IList<V1beta1KafkaClusterStatusAtProviderMetastoresHive>? Hive { get; set; }

    /// <summary>An oozie block as defined below.</summary>
    [JsonPropertyName("oozie")]
    public IList<V1beta1KafkaClusterStatusAtProviderMetastoresOozie>? Oozie { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderMonitor
{
    /// <summary>The Operations Management Suite (OMS) workspace ID.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderNetwork
{
    /// <summary>The direction of the resource provider connection. Possible values include Inbound or Outbound. Defaults to Inbound. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("connectionDirection")]
    public string? ConnectionDirection { get; set; }

    /// <summary>Is the private link enabled? Possible values include true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateLinkEnabled")]
    public bool? PrivateLinkEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether this IP configuration is primary.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The private IP allocation method. The only possible value now is Dynamic.</summary>
    [JsonPropertyName("privateIpAllocationMethod")]
    public string? PrivateIpAllocationMethod { get; set; }

    /// <summary>The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link service group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1KafkaClusterStatusAtProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRestProxy
{
    /// <summary>The Azure Active Directory Security Group ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }

    /// <summary>The Azure Active Directory Security Group name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityGroupName")]
    public string? SecurityGroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesHeadNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesHeadNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesHeadNodeScriptActions>? ScriptActions { get; set; }

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

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesKafkaManagementNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesKafkaManagementNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesKafkaManagementNodeScriptActions>? ScriptActions { get; set; }

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

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesWorkerNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesWorkerNode
{
    /// <summary>The number of Data Disks which should be assigned to each Worker Node, which can be between 1 and 8. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("numberOfDisksPerNode")]
    public double? NumberOfDisksPerNode { get; set; }

    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesWorkerNodeScriptActions>? ScriptActions { get; set; }

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

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesZookeeperNodeScriptActions
{
    /// <summary>The name of the script action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameters for the script provided.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The URI to the script.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRolesZookeeperNode
{
    /// <summary>The script action which will run on the cluster. One or more script_actions blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scriptActions")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesZookeeperNodeScriptActions>? ScriptActions { get; set; }

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

    /// <summary>The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Possible values are ExtraSmall, Small, Medium, Large, ExtraLarge, A5, A6, A7, A8, A9, A10, A11, Standard_A1_V2, Standard_A2_V2, Standard_A2m_V2, Standard_A3, Standard_A4_V2, Standard_A4m_V2, Standard_A8_V2, Standard_A8m_V2, Standard_D1, Standard_D2, Standard_D3, Standard_D4, Standard_D11, Standard_D12, Standard_D13, Standard_D14, Standard_D1_V2, Standard_D2_V2, Standard_D3_V2, Standard_D4_V2, Standard_D5_V2, Standard_D11_V2, Standard_D12_V2, Standard_D13_V2, Standard_D14_V2, Standard_DS1_V2, Standard_DS2_V2, Standard_DS3_V2, Standard_DS4_V2, Standard_DS5_V2, Standard_DS11_V2, Standard_DS12_V2, Standard_DS13_V2, Standard_DS14_V2, Standard_E2_V3, Standard_E4_V3, Standard_E8_V3, Standard_E16_V3, Standard_E20_V3, Standard_E32_V3, Standard_E64_V3, Standard_E64i_V3, Standard_E2s_V3, Standard_E4s_V3, Standard_E8s_V3, Standard_E16s_V3, Standard_E20s_V3, Standard_E32s_V3, Standard_E64s_V3, Standard_E64is_V3, Standard_D2a_V4, Standard_D4a_V4, Standard_D8a_V4, Standard_D16a_V4, Standard_D32a_V4, Standard_D48a_V4, Standard_D64a_V4, Standard_D96a_V4, Standard_E2a_V4, Standard_E4a_V4, Standard_E8a_V4, Standard_E16a_V4, Standard_E20a_V4, Standard_E32a_V4, Standard_E48a_V4, Standard_E64a_V4, Standard_E96a_V4, Standard_D2ads_V5, Standard_D4ads_V5, Standard_D8ads_V5, Standard_D16ads_V5, Standard_D32ads_V5, Standard_D48ads_V5, Standard_D64ads_V5, Standard_D96ads_V5, Standard_E2ads_V5, Standard_E4ads_V5, Standard_E8ads_V5, Standard_E16ads_V5, Standard_E20ads_V5, Standard_E32ads_V5, Standard_E48ads_V5, Standard_E64ads_V5, Standard_E96ads_V5, Standard_G1, Standard_G2, Standard_G3, Standard_G4, Standard_G5, Standard_F2s_V2, Standard_F4s_V2, Standard_F8s_V2, Standard_F16s_V2, Standard_F32s_V2, Standard_F64s_V2, Standard_F72s_V2, Standard_GS1, Standard_GS2, Standard_GS3, Standard_GS4, Standard_GS5 and Standard_NC24. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderRoles
{
    /// <summary>A head_node block as defined above.</summary>
    [JsonPropertyName("headNode")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesHeadNode>? HeadNode { get; set; }

    /// <summary>A kafka_management_node block as defined below.</summary>
    [JsonPropertyName("kafkaManagementNode")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesKafkaManagementNode>? KafkaManagementNode { get; set; }

    /// <summary>A worker_node block as defined below.</summary>
    [JsonPropertyName("workerNode")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesWorkerNode>? WorkerNode { get; set; }

    /// <summary>A zookeeper_node block as defined below.</summary>
    [JsonPropertyName("zookeeperNode")]
    public IList<V1beta1KafkaClusterStatusAtProviderRolesZookeeperNode>? ZookeeperNode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderSecurityProfile
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderStorageAccount
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProviderStorageAccountGen2
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusAtProvider
{
    /// <summary>Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clusterVersion")]
    public string? ClusterVersion { get; set; }

    /// <summary>A component_version block as defined below.</summary>
    [JsonPropertyName("componentVersion")]
    public IList<V1beta1KafkaClusterStatusAtProviderComponentVersion>? ComponentVersion { get; set; }

    /// <summary>A compute_isolation block as defined below.</summary>
    [JsonPropertyName("computeIsolation")]
    public IList<V1beta1KafkaClusterStatusAtProviderComputeIsolation>? ComputeIsolation { get; set; }

    /// <summary>One or more disk_encryption block as defined below.</summary>
    [JsonPropertyName("diskEncryption")]
    public IList<V1beta1KafkaClusterStatusAtProviderDiskEncryption>? DiskEncryption { get; set; }

    /// <summary>Whether encryption in transit is enabled for this HDInsight Kafka Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encryptionInTransitEnabled")]
    public bool? EncryptionInTransitEnabled { get; set; }

    /// <summary>An extension block as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1KafkaClusterStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>A gateway block as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1KafkaClusterStatusAtProviderGateway>? Gateway { get; set; }

    /// <summary>The HTTPS Connectivity Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("httpsEndpoint")]
    public string? HttpsEndpoint { get; set; }

    /// <summary>The ID of the HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kafka Rest Proxy Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("kafkaRestProxyEndpoint")]
    public string? KafkaRestProxyEndpoint { get; set; }

    /// <summary>Specifies the Azure Region which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A metastores block as defined below.</summary>
    [JsonPropertyName("metastores")]
    public IList<V1beta1KafkaClusterStatusAtProviderMetastores>? Metastores { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1KafkaClusterStatusAtProviderMonitor>? Monitor { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1KafkaClusterStatusAtProviderNetwork>? Network { get; set; }

    /// <summary>A private_link_configuration block as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta1KafkaClusterStatusAtProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>Specifies the name of the Resource Group in which this HDInsight Kafka Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rest_proxy block as defined below.</summary>
    [JsonPropertyName("restProxy")]
    public IList<V1beta1KafkaClusterStatusAtProviderRestProxy>? RestProxy { get; set; }

    /// <summary>A roles block as defined below.</summary>
    [JsonPropertyName("roles")]
    public IList<V1beta1KafkaClusterStatusAtProviderRoles>? Roles { get; set; }

    /// <summary>A security_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityProfile")]
    public IList<V1beta1KafkaClusterStatusAtProviderSecurityProfile>? SecurityProfile { get; set; }

    /// <summary>The SSH Connectivity Endpoint for this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("sshEndpoint")]
    public string? SshEndpoint { get; set; }

    /// <summary>One or more storage_account block as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1KafkaClusterStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A storage_account_gen2 block as defined below.</summary>
    [JsonPropertyName("storageAccountGen2")]
    public IList<V1beta1KafkaClusterStatusAtProviderStorageAccountGen2>? StorageAccountGen2 { get; set; }

    /// <summary>A map of Tags which should be assigned to this HDInsight Kafka Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Tier which should be used for this HDInsight Kafka Cluster. Possible values are Standard or Premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The minimal supported TLS version. Possible values are 1.0, 1.1 or 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatusConditions
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

/// <summary>KafkaClusterStatus defines the observed state of KafkaCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KafkaClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KafkaClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KafkaClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KafkaCluster is the Schema for the KafkaClusters API. Manages a HDInsight Kafka Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KafkaCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KafkaClusterSpec>, IStatus<V1beta1KafkaClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KafkaCluster";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "kafkaclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KafkaClusterSpec defines the desired state of KafkaCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1KafkaClusterSpec Spec { get; set; }

    /// <summary>KafkaClusterStatus defines the observed state of KafkaCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1KafkaClusterStatus? Status { get; set; }
}

/// <summary>KafkaCluster is the Schema for the KafkaClusters API. Manages a HDInsight Kafka Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KafkaClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KafkaCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KafkaClusterList";
    public const string KubeGroup = "hdinsight.azure.upbound.io";
    public const string KubePluralName = "kafkaclusters";
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
    public IList<V1beta1KafkaCluster> Items { get; set; }
}