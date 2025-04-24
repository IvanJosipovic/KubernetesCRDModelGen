using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kusto.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1ClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy
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
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfiguration
{
    /// <summary>Data management's service public IP address resource id.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>Engine service's public IP address resource id.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The subnet resource id.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>Specifies if the cluster's disks are encrypted.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster's double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ClusterSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>An list of language_extensions to enable. Valid values are: PYTHON, PYTHON_3.10.8 and R. PYTHON is used to specify Python 3.6.5 image and PYTHON_3.10.8 is used to specify Python 3.10.8 image. Note that PYTHON_3.10.8 is only available in skus which support nested virtualization.</summary>
    [JsonPropertyName("languageExtensions")]
    public IList<string>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public IList<V1beta1ClusterSpecForProviderOptimizedAutoScale>? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Value is optional but if passed in, must be true or false, default is false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>Specifies the Resource Group where the Kusto Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ClusterSpecForProviderSku>? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = ["*"] to explicitly allow all other tenants, trusted_external_tenants = ["MyTenantOnly"] for only your tenant or trusted_external_tenants = ["&lt;tenantId1&gt;", "&lt;tenantIdx&gt;"] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public IList<V1beta1ClusterSpecForProviderVirtualNetworkConfiguration>? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy
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
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfiguration
{
    /// <summary>Data management's service public IP address resource id.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>Engine service's public IP address resource id.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The subnet resource id.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>Specifies if the cluster's disks are encrypted.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster's double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ClusterSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>An list of language_extensions to enable. Valid values are: PYTHON, PYTHON_3.10.8 and R. PYTHON is used to specify Python 3.6.5 image and PYTHON_3.10.8 is used to specify Python 3.10.8 image. Note that PYTHON_3.10.8 is only available in skus which support nested virtualization.</summary>
    [JsonPropertyName("languageExtensions")]
    public IList<string>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public IList<V1beta1ClusterSpecInitProviderOptimizedAutoScale>? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Value is optional but if passed in, must be true or false, default is false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ClusterSpecInitProviderSku>? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = ["*"] to explicitly allow all other tenants, trusted_external_tenants = ["MyTenantOnly"] for only your tenant or trusted_external_tenants = ["&lt;tenantId1&gt;", "&lt;tenantIdx&gt;"] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public IList<V1beta1ClusterSpecInitProviderVirtualNetworkConfiguration>? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
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
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Must between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualNetworkConfiguration
{
    /// <summary>Data management's service public IP address resource id.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>Engine service's public IP address resource id.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The subnet resource id.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>The Kusto Cluster URI to be used for data ingestion.</summary>
    [JsonPropertyName("dataIngestionUri")]
    public string? DataIngestionUri { get; set; }

    /// <summary>Specifies if the cluster's disks are encrypted.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster's double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ClusterStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>An list of language_extensions to enable. Valid values are: PYTHON, PYTHON_3.10.8 and R. PYTHON is used to specify Python 3.6.5 image and PYTHON_3.10.8 is used to specify Python 3.10.8 image. Note that PYTHON_3.10.8 is only available in skus which support nested virtualization.</summary>
    [JsonPropertyName("languageExtensions")]
    public IList<string>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public IList<V1beta1ClusterStatusAtProviderOptimizedAutoScale>? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Value is optional but if passed in, must be true or false, default is false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>Specifies the Resource Group where the Kusto Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1ClusterStatusAtProviderSku>? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = ["*"] to explicitly allow all other tenants, trusted_external_tenants = ["MyTenantOnly"] for only your tenant or trusted_external_tenants = ["&lt;tenantId1&gt;", "&lt;tenantIdx&gt;"] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    /// <summary>The FQDN of the Azure Kusto Cluster.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public IList<V1beta1ClusterStatusAtProviderVirtualNetworkConfiguration>? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages Kusto (also known as Azure Data Explorer) Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kusto.azure.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages Kusto (also known as Azure Data Explorer) Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kusto.azure.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}