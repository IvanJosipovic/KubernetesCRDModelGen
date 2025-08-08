using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderDelegationServiceDelegation
{
    /// <summary>A list of Actions which should be delegated. This list is specific to the service to delegate to. Possible values are Microsoft.Network/networkinterfaces/*, Microsoft.Network/publicIPAddresses/join/action, Microsoft.Network/publicIPAddresses/read, Microsoft.Network/virtualNetworks/read, Microsoft.Network/virtualNetworks/subnets/action, Microsoft.Network/virtualNetworks/subnets/join/action, Microsoft.Network/virtualNetworks/subnets/prepareNetworkPolicies/action, and Microsoft.Network/virtualNetworks/subnets/unprepareNetworkPolicies/action.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The name of service to delegate to. Possible values are GitHub.Network/networkSettings, Informatica.DataManagement/organizations, Microsoft.ApiManagement/service, Microsoft.Apollo/npu, Microsoft.App/environments, Microsoft.App/testClients, Microsoft.AVS/PrivateClouds, Microsoft.AzureCosmosDB/clusters, Microsoft.BareMetal/AzureHostedService, Microsoft.BareMetal/AzureHPC, Microsoft.BareMetal/AzurePaymentHSM, Microsoft.BareMetal/AzureVMware, Microsoft.BareMetal/CrayServers, Microsoft.BareMetal/MonitoringServers, Microsoft.Batch/batchAccounts, Microsoft.CloudTest/hostedpools, Microsoft.CloudTest/images, Microsoft.CloudTest/pools, Microsoft.Codespaces/plans, Microsoft.ContainerInstance/containerGroups, Microsoft.ContainerService/managedClusters, Microsoft.ContainerService/TestClients, Microsoft.Databricks/workspaces, Microsoft.DBforMySQL/flexibleServers, Microsoft.DBforMySQL/servers, Microsoft.DBforMySQL/serversv2, Microsoft.DBforPostgreSQL/flexibleServers, Microsoft.DBforPostgreSQL/serversv2, Microsoft.DBforPostgreSQL/singleServers, Microsoft.DelegatedNetwork/controller, Microsoft.DevCenter/networkConnection, Microsoft.DevOpsInfrastructure/pools, Microsoft.DocumentDB/cassandraClusters, Microsoft.Fidalgo/networkSettings, Microsoft.HardwareSecurityModules/dedicatedHSMs, Microsoft.Kusto/clusters, Microsoft.LabServices/labplans, Microsoft.Logic/integrationServiceEnvironments, Microsoft.MachineLearningServices/workspaces, Microsoft.Netapp/volumes, Microsoft.Network/applicationGateways, Microsoft.Network/dnsResolvers, Microsoft.Network/managedResolvers, Microsoft.Network/fpgaNetworkInterfaces, Microsoft.Network/networkWatchers., Microsoft.Network/virtualNetworkGateways, Microsoft.Orbital/orbitalGateways, Microsoft.PowerAutomate/hostedRpa, Microsoft.PowerPlatform/enterprisePolicies, Microsoft.PowerPlatform/vnetaccesslinks, Microsoft.ServiceFabricMesh/networks, Microsoft.ServiceNetworking/trafficControllers, Microsoft.Singularity/accounts/networks, Microsoft.Singularity/accounts/npu, Microsoft.Sql/managedInstances, Microsoft.Sql/managedInstancesOnebox, Microsoft.Sql/managedInstancesStage, Microsoft.Sql/managedInstancesTest, Microsoft.Sql/servers, Microsoft.StoragePool/diskPools, Microsoft.StreamAnalytics/streamingJobs, Microsoft.Synapse/workspaces, Microsoft.Web/hostingEnvironments, Microsoft.Web/serverFarms, NGINX.NGINXPLUS/nginxDeployments, PaloAltoNetworks.Cloudngfw/firewalls, Qumulo.Storage/fileSystems, and Oracle.Database/networkAttachments.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderDelegation
{
    /// <summary>A name for this delegation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A service_delegation block as defined below.</summary>
    [JsonPropertyName("serviceDelegation")]
    public IList<V1beta1SubnetSpecForProviderDelegationServiceDelegation>? ServiceDelegation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1SubnetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1SubnetSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVirtualNetworkNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetwork in network to populate virtualNetworkName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVirtualNetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecForProviderVirtualNetworkNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVirtualNetworkNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetwork in network to populate virtualNetworkName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProviderVirtualNetworkNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecForProviderVirtualNetworkNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecForProvider
{
    /// <summary>The address prefixes to use for the subnet.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>Enable default outbound access to the internet for the subnet. Defaults to true.</summary>
    [JsonPropertyName("defaultOutboundAccessEnabled")]
    public bool? DefaultOutboundAccessEnabled { get; set; }

    /// <summary>One or more delegation blocks as defined below.</summary>
    [JsonPropertyName("delegation")]
    public IList<V1beta1SubnetSpecForProviderDelegation>? Delegation { get; set; }

    /// <summary>Enable or Disable network policies for the private endpoint on the subnet. Possible values are Disabled, Enabled, NetworkSecurityGroupEnabled and RouteTableEnabled. Defaults to Disabled.</summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>Enable or Disable network policies for the private link service on the subnet. Defaults to true.</summary>
    [JsonPropertyName("privateLinkServiceNetworkPoliciesEnabled")]
    public bool? PrivateLinkServiceNetworkPoliciesEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the subnet. This must be the resource group that the virtual network resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SubnetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SubnetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The list of IDs of Service Endpoint Policies to associate with the subnet.</summary>
    [JsonPropertyName("serviceEndpointPolicyIds")]
    public IList<string>? ServiceEndpointPolicyIds { get; set; }

    /// <summary>The list of Service endpoints to associate with the subnet. Possible values include: Microsoft.AzureActiveDirectory, Microsoft.AzureCosmosDB, Microsoft.ContainerRegistry, Microsoft.EventHub, Microsoft.KeyVault, Microsoft.ServiceBus, Microsoft.Sql, Microsoft.Storage, Microsoft.Storage.Global and Microsoft.Web.</summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<string>? ServiceEndpoints { get; set; }

    /// <summary>The name of the virtual network to which to attach the subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkName")]
    public string? VirtualNetworkName { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate virtualNetworkName.</summary>
    [JsonPropertyName("virtualNetworkNameRef")]
    public V1beta1SubnetSpecForProviderVirtualNetworkNameRef? VirtualNetworkNameRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate virtualNetworkName.</summary>
    [JsonPropertyName("virtualNetworkNameSelector")]
    public V1beta1SubnetSpecForProviderVirtualNetworkNameSelector? VirtualNetworkNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderDelegationServiceDelegation
{
    /// <summary>A list of Actions which should be delegated. This list is specific to the service to delegate to. Possible values are Microsoft.Network/networkinterfaces/*, Microsoft.Network/publicIPAddresses/join/action, Microsoft.Network/publicIPAddresses/read, Microsoft.Network/virtualNetworks/read, Microsoft.Network/virtualNetworks/subnets/action, Microsoft.Network/virtualNetworks/subnets/join/action, Microsoft.Network/virtualNetworks/subnets/prepareNetworkPolicies/action, and Microsoft.Network/virtualNetworks/subnets/unprepareNetworkPolicies/action.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The name of service to delegate to. Possible values are GitHub.Network/networkSettings, Informatica.DataManagement/organizations, Microsoft.ApiManagement/service, Microsoft.Apollo/npu, Microsoft.App/environments, Microsoft.App/testClients, Microsoft.AVS/PrivateClouds, Microsoft.AzureCosmosDB/clusters, Microsoft.BareMetal/AzureHostedService, Microsoft.BareMetal/AzureHPC, Microsoft.BareMetal/AzurePaymentHSM, Microsoft.BareMetal/AzureVMware, Microsoft.BareMetal/CrayServers, Microsoft.BareMetal/MonitoringServers, Microsoft.Batch/batchAccounts, Microsoft.CloudTest/hostedpools, Microsoft.CloudTest/images, Microsoft.CloudTest/pools, Microsoft.Codespaces/plans, Microsoft.ContainerInstance/containerGroups, Microsoft.ContainerService/managedClusters, Microsoft.ContainerService/TestClients, Microsoft.Databricks/workspaces, Microsoft.DBforMySQL/flexibleServers, Microsoft.DBforMySQL/servers, Microsoft.DBforMySQL/serversv2, Microsoft.DBforPostgreSQL/flexibleServers, Microsoft.DBforPostgreSQL/serversv2, Microsoft.DBforPostgreSQL/singleServers, Microsoft.DelegatedNetwork/controller, Microsoft.DevCenter/networkConnection, Microsoft.DevOpsInfrastructure/pools, Microsoft.DocumentDB/cassandraClusters, Microsoft.Fidalgo/networkSettings, Microsoft.HardwareSecurityModules/dedicatedHSMs, Microsoft.Kusto/clusters, Microsoft.LabServices/labplans, Microsoft.Logic/integrationServiceEnvironments, Microsoft.MachineLearningServices/workspaces, Microsoft.Netapp/volumes, Microsoft.Network/applicationGateways, Microsoft.Network/dnsResolvers, Microsoft.Network/managedResolvers, Microsoft.Network/fpgaNetworkInterfaces, Microsoft.Network/networkWatchers., Microsoft.Network/virtualNetworkGateways, Microsoft.Orbital/orbitalGateways, Microsoft.PowerAutomate/hostedRpa, Microsoft.PowerPlatform/enterprisePolicies, Microsoft.PowerPlatform/vnetaccesslinks, Microsoft.ServiceFabricMesh/networks, Microsoft.ServiceNetworking/trafficControllers, Microsoft.Singularity/accounts/networks, Microsoft.Singularity/accounts/npu, Microsoft.Sql/managedInstances, Microsoft.Sql/managedInstancesOnebox, Microsoft.Sql/managedInstancesStage, Microsoft.Sql/managedInstancesTest, Microsoft.Sql/servers, Microsoft.StoragePool/diskPools, Microsoft.StreamAnalytics/streamingJobs, Microsoft.Synapse/workspaces, Microsoft.Web/hostingEnvironments, Microsoft.Web/serverFarms, NGINX.NGINXPLUS/nginxDeployments, PaloAltoNetworks.Cloudngfw/firewalls, Qumulo.Storage/fileSystems, and Oracle.Database/networkAttachments.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProviderDelegation
{
    /// <summary>A name for this delegation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A service_delegation block as defined below.</summary>
    [JsonPropertyName("serviceDelegation")]
    public IList<V1beta1SubnetSpecInitProviderDelegationServiceDelegation>? ServiceDelegation { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecInitProvider
{
    /// <summary>The address prefixes to use for the subnet.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>Enable default outbound access to the internet for the subnet. Defaults to true.</summary>
    [JsonPropertyName("defaultOutboundAccessEnabled")]
    public bool? DefaultOutboundAccessEnabled { get; set; }

    /// <summary>One or more delegation blocks as defined below.</summary>
    [JsonPropertyName("delegation")]
    public IList<V1beta1SubnetSpecInitProviderDelegation>? Delegation { get; set; }

    /// <summary>Enable or Disable network policies for the private endpoint on the subnet. Possible values are Disabled, Enabled, NetworkSecurityGroupEnabled and RouteTableEnabled. Defaults to Disabled.</summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>Enable or Disable network policies for the private link service on the subnet. Defaults to true.</summary>
    [JsonPropertyName("privateLinkServiceNetworkPoliciesEnabled")]
    public bool? PrivateLinkServiceNetworkPoliciesEnabled { get; set; }

    /// <summary>The list of IDs of Service Endpoint Policies to associate with the subnet.</summary>
    [JsonPropertyName("serviceEndpointPolicyIds")]
    public IList<string>? ServiceEndpointPolicyIds { get; set; }

    /// <summary>The list of Service endpoints to associate with the subnet. Possible values include: Microsoft.AzureActiveDirectory, Microsoft.AzureCosmosDB, Microsoft.ContainerRegistry, Microsoft.EventHub, Microsoft.KeyVault, Microsoft.ServiceBus, Microsoft.Sql, Microsoft.Storage, Microsoft.Storage.Global and Microsoft.Web.</summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<string>? ServiceEndpoints { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecProviderConfigRefPolicy
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
public partial class V1beta1SubnetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SubnetSpec defines the desired state of Subnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubnetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubnetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubnetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubnetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusAtProviderDelegationServiceDelegation
{
    /// <summary>A list of Actions which should be delegated. This list is specific to the service to delegate to. Possible values are Microsoft.Network/networkinterfaces/*, Microsoft.Network/publicIPAddresses/join/action, Microsoft.Network/publicIPAddresses/read, Microsoft.Network/virtualNetworks/read, Microsoft.Network/virtualNetworks/subnets/action, Microsoft.Network/virtualNetworks/subnets/join/action, Microsoft.Network/virtualNetworks/subnets/prepareNetworkPolicies/action, and Microsoft.Network/virtualNetworks/subnets/unprepareNetworkPolicies/action.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The name of service to delegate to. Possible values are GitHub.Network/networkSettings, Informatica.DataManagement/organizations, Microsoft.ApiManagement/service, Microsoft.Apollo/npu, Microsoft.App/environments, Microsoft.App/testClients, Microsoft.AVS/PrivateClouds, Microsoft.AzureCosmosDB/clusters, Microsoft.BareMetal/AzureHostedService, Microsoft.BareMetal/AzureHPC, Microsoft.BareMetal/AzurePaymentHSM, Microsoft.BareMetal/AzureVMware, Microsoft.BareMetal/CrayServers, Microsoft.BareMetal/MonitoringServers, Microsoft.Batch/batchAccounts, Microsoft.CloudTest/hostedpools, Microsoft.CloudTest/images, Microsoft.CloudTest/pools, Microsoft.Codespaces/plans, Microsoft.ContainerInstance/containerGroups, Microsoft.ContainerService/managedClusters, Microsoft.ContainerService/TestClients, Microsoft.Databricks/workspaces, Microsoft.DBforMySQL/flexibleServers, Microsoft.DBforMySQL/servers, Microsoft.DBforMySQL/serversv2, Microsoft.DBforPostgreSQL/flexibleServers, Microsoft.DBforPostgreSQL/serversv2, Microsoft.DBforPostgreSQL/singleServers, Microsoft.DelegatedNetwork/controller, Microsoft.DevCenter/networkConnection, Microsoft.DevOpsInfrastructure/pools, Microsoft.DocumentDB/cassandraClusters, Microsoft.Fidalgo/networkSettings, Microsoft.HardwareSecurityModules/dedicatedHSMs, Microsoft.Kusto/clusters, Microsoft.LabServices/labplans, Microsoft.Logic/integrationServiceEnvironments, Microsoft.MachineLearningServices/workspaces, Microsoft.Netapp/volumes, Microsoft.Network/applicationGateways, Microsoft.Network/dnsResolvers, Microsoft.Network/managedResolvers, Microsoft.Network/fpgaNetworkInterfaces, Microsoft.Network/networkWatchers., Microsoft.Network/virtualNetworkGateways, Microsoft.Orbital/orbitalGateways, Microsoft.PowerAutomate/hostedRpa, Microsoft.PowerPlatform/enterprisePolicies, Microsoft.PowerPlatform/vnetaccesslinks, Microsoft.ServiceFabricMesh/networks, Microsoft.ServiceNetworking/trafficControllers, Microsoft.Singularity/accounts/networks, Microsoft.Singularity/accounts/npu, Microsoft.Sql/managedInstances, Microsoft.Sql/managedInstancesOnebox, Microsoft.Sql/managedInstancesStage, Microsoft.Sql/managedInstancesTest, Microsoft.Sql/servers, Microsoft.StoragePool/diskPools, Microsoft.StreamAnalytics/streamingJobs, Microsoft.Synapse/workspaces, Microsoft.Web/hostingEnvironments, Microsoft.Web/serverFarms, NGINX.NGINXPLUS/nginxDeployments, PaloAltoNetworks.Cloudngfw/firewalls, Qumulo.Storage/fileSystems, and Oracle.Database/networkAttachments.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusAtProviderDelegation
{
    /// <summary>A name for this delegation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A service_delegation block as defined below.</summary>
    [JsonPropertyName("serviceDelegation")]
    public IList<V1beta1SubnetStatusAtProviderDelegationServiceDelegation>? ServiceDelegation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusAtProvider
{
    /// <summary>The address prefixes to use for the subnet.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>Enable default outbound access to the internet for the subnet. Defaults to true.</summary>
    [JsonPropertyName("defaultOutboundAccessEnabled")]
    public bool? DefaultOutboundAccessEnabled { get; set; }

    /// <summary>One or more delegation blocks as defined below.</summary>
    [JsonPropertyName("delegation")]
    public IList<V1beta1SubnetStatusAtProviderDelegation>? Delegation { get; set; }

    /// <summary>The subnet ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Enable or Disable network policies for the private endpoint on the subnet. Possible values are Disabled, Enabled, NetworkSecurityGroupEnabled and RouteTableEnabled. Defaults to Disabled.</summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>Enable or Disable network policies for the private link service on the subnet. Defaults to true.</summary>
    [JsonPropertyName("privateLinkServiceNetworkPoliciesEnabled")]
    public bool? PrivateLinkServiceNetworkPoliciesEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the subnet. This must be the resource group that the virtual network resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The list of IDs of Service Endpoint Policies to associate with the subnet.</summary>
    [JsonPropertyName("serviceEndpointPolicyIds")]
    public IList<string>? ServiceEndpointPolicyIds { get; set; }

    /// <summary>The list of Service endpoints to associate with the subnet. Possible values include: Microsoft.AzureActiveDirectory, Microsoft.AzureCosmosDB, Microsoft.ContainerRegistry, Microsoft.EventHub, Microsoft.KeyVault, Microsoft.ServiceBus, Microsoft.Sql, Microsoft.Storage, Microsoft.Storage.Global and Microsoft.Web.</summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<string>? ServiceEndpoints { get; set; }

    /// <summary>The name of the virtual network to which to attach the subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkName")]
    public string? VirtualNetworkName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatusConditions
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

/// <summary>SubnetStatus defines the observed state of Subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubnetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubnetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subnet is the Schema for the Subnets API. Manages a subnet. Subnets represent network segments within the IP space defined by the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Subnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubnetSpec>, IStatus<V1beta1SubnetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Subnet";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "subnets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubnetSpec defines the desired state of Subnet</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubnetSpec Spec { get; set; }

    /// <summary>SubnetStatus defines the observed state of Subnet.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubnetStatus? Status { get; set; }
}

/// <summary>Subnet is the Schema for the Subnets API. Manages a subnet. Subnets represent network segments within the IP space defined by the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubnetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Subnet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubnetList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "subnets";
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
    public IList<V1beta1Subnet> Items { get; set; }
}