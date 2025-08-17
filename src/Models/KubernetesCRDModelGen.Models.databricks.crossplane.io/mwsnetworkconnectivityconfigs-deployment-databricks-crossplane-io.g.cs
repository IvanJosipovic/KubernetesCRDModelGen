using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
#nullable enable
/// <summary>MwsNetworkConnectivityConfig is the Schema for the MwsNetworkConnectivityConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNetworkConnectivityConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsNetworkConnectivityConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNetworkConnectivityConfigList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworkconnectivityconfigs";
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
    public IList<V1alpha1MwsNetworkConnectivityConfig> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAwsStableIpRule>? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAzureServiceEndpointRule>? AzureServiceEndpointRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRules>? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRules>? TargetRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecForProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecForProviderEgressConfig>? EgressConfig { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAwsStableIpRule>? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAzureServiceEndpointRule>? AzureServiceEndpointRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRules>? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRules>? TargetRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecInitProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public IList<V1alpha1MwsNetworkConnectivityConfigSpecInitProviderEgressConfig>? EgressConfig { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToConfigRefPolicy
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
/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToMetadata
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
#nullable disable

#nullable enable
/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsNetworkConnectivityConfigSpec defines the desired state of MwsNetworkConnectivityConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsNetworkConnectivityConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsNetworkConnectivityConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsNetworkConnectivityConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsNetworkConnectivityConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsNetworkConnectivityConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAwsStableIpRule>? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAzureServiceEndpointRule>? AzureServiceEndpointRule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    /// <summary></summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRules>? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRules>? TargetRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusAtProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusAtProviderEgressConfig>? EgressConfig { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatusConditions
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
/// <summary>MwsNetworkConnectivityConfigStatus defines the observed state of MwsNetworkConnectivityConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworkConnectivityConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsNetworkConnectivityConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsNetworkConnectivityConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsNetworkConnectivityConfig is the Schema for the MwsNetworkConnectivityConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNetworkConnectivityConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsNetworkConnectivityConfigSpec>, IStatus<V1alpha1MwsNetworkConnectivityConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNetworkConnectivityConfig";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworkconnectivityconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsNetworkConnectivityConfigSpec defines the desired state of MwsNetworkConnectivityConfig</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsNetworkConnectivityConfigSpec Spec { get; set; }

    /// <summary>MwsNetworkConnectivityConfigStatus defines the observed state of MwsNetworkConnectivityConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsNetworkConnectivityConfigStatus? Status { get; set; }
}
#nullable disable
