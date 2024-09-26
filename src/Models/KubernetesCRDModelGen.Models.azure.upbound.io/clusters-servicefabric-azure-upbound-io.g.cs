using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicefabric.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterSpecForProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public IList<V1beta1ClusterSpecForProviderNodeTypeApplicationPorts>? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public IList<V1beta1ClusterSpecForProviderNodeTypeEphemeralPorts>? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
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
public partial class V1beta1ClusterSpecForProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterSpecForProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public IList<V1beta1ClusterSpecForProviderUpgradePolicyDeltaHealthPolicy>? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public IList<V1beta1ClusterSpecForProviderUpgradePolicyHealthPolicy>? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public IList<V1beta1ClusterSpecForProviderAzureActiveDirectory>? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ClusterSpecForProviderCertificate>? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public IList<V1beta1ClusterSpecForProviderCertificateCommonNames>? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta1ClusterSpecForProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta1ClusterSpecForProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public IList<V1beta1ClusterSpecForProviderDiagnosticsConfig>? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta1ClusterSpecForProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ClusterSpecForProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public IList<V1beta1ClusterSpecForProviderReverseProxyCertificate>? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public IList<V1beta1ClusterSpecForProviderReverseProxyCertificateCommonNames>? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterSpecForProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterSpecInitProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public IList<V1beta1ClusterSpecInitProviderNodeTypeApplicationPorts>? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public IList<V1beta1ClusterSpecInitProviderNodeTypeEphemeralPorts>? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterSpecInitProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public IList<V1beta1ClusterSpecInitProviderUpgradePolicyDeltaHealthPolicy>? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public IList<V1beta1ClusterSpecInitProviderUpgradePolicyHealthPolicy>? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public IList<V1beta1ClusterSpecInitProviderAzureActiveDirectory>? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ClusterSpecInitProviderCertificate>? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public IList<V1beta1ClusterSpecInitProviderCertificateCommonNames>? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta1ClusterSpecInitProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta1ClusterSpecInitProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public IList<V1beta1ClusterSpecInitProviderDiagnosticsConfig>? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta1ClusterSpecInitProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ClusterSpecInitProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public IList<V1beta1ClusterSpecInitProviderReverseProxyCertificate>? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public IList<V1beta1ClusterSpecInitProviderReverseProxyCertificateCommonNames>? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterSpecInitProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
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
public partial class V1beta1ClusterStatusAtProviderAzureActiveDirectory
{
    /// <summary>The Azure Active Directory Client ID which should be used for the Client Application.</summary>
    [JsonPropertyName("clientApplicationId")]
    public string? ClientApplicationId { get; set; }

    /// <summary>The Azure Active Directory Cluster Application ID.</summary>
    [JsonPropertyName("clusterApplicationId")]
    public string? ClusterApplicationId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterStatusAtProviderCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClientCertificateCommonName
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("issuerThumbprint")]
    public string? IssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClientCertificateThumbprint
{
    /// <summary>Does the Client Certificate have Admin Access to the cluster? Non-admin clients can only perform read only operations on the cluster.</summary>
    [JsonPropertyName("isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>The Thumbprint associated with the Client Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDiagnosticsConfig
{
    /// <summary>The Blob Endpoint of the Storage Account.</summary>
    [JsonPropertyName("blobEndpoint")]
    public string? BlobEndpoint { get; set; }

    /// <summary>The protected diagnostics storage key name, such as StorageAccountKey1.</summary>
    [JsonPropertyName("protectedAccountKeyName")]
    public string? ProtectedAccountKeyName { get; set; }

    /// <summary>The Queue Endpoint of the Storage Account.</summary>
    [JsonPropertyName("queueEndpoint")]
    public string? QueueEndpoint { get; set; }

    /// <summary>The name of the Storage Account where the Diagnostics should be sent to.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>The Table Endpoint of the Storage Account.</summary>
    [JsonPropertyName("tableEndpoint")]
    public string? TableEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderFabricSettings
{
    /// <summary>The name of the Fabric Setting, such as Security or Federation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map containing settings for the specified Fabric Setting.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeTypeApplicationPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeTypeEphemeralPorts
{
    /// <summary>The end of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("endPort")]
    public double? EndPort { get; set; }

    /// <summary>The start of the Ephemeral Port Range on this Node Type.</summary>
    [JsonPropertyName("startPort")]
    public double? StartPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeType
{
    /// <summary>A application_ports block as defined below.</summary>
    [JsonPropertyName("applicationPorts")]
    public IList<V1beta1ClusterStatusAtProviderNodeTypeApplicationPorts>? ApplicationPorts { get; set; }

    /// <summary>The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.</summary>
    [JsonPropertyName("capacities")]
    public IDictionary<string, string>? Capacities { get; set; }

    /// <summary>The Port used for the Client Endpoint for this Node Type.</summary>
    [JsonPropertyName("clientEndpointPort")]
    public double? ClientEndpointPort { get; set; }

    /// <summary>The Durability Level for this Node Type. Possible values include Bronze, Gold and Silver. Defaults to Bronze.</summary>
    [JsonPropertyName("durabilityLevel")]
    public string? DurabilityLevel { get; set; }

    /// <summary>A ephemeral_ports block as defined below.</summary>
    [JsonPropertyName("ephemeralPorts")]
    public IList<V1beta1ClusterStatusAtProviderNodeTypeEphemeralPorts>? EphemeralPorts { get; set; }

    /// <summary>The Port used for the HTTP Endpoint for this Node Type.</summary>
    [JsonPropertyName("httpEndpointPort")]
    public double? HttpEndpointPort { get; set; }

    /// <summary>The number of nodes for this Node Type.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is this the Primary Node Type?</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>Should this node type run only stateless services?</summary>
    [JsonPropertyName("isStateless")]
    public bool? IsStateless { get; set; }

    /// <summary>Does this node type span availability zones?</summary>
    [JsonPropertyName("multipleAvailabilityZones")]
    public bool? MultipleAvailabilityZones { get; set; }

    /// <summary>The name of the Node Type.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.</summary>
    [JsonPropertyName("placementProperties")]
    public IDictionary<string, string>? PlacementProperties { get; set; }

    /// <summary>The Port used for the Reverse Proxy Endpoint for this Node Type. Changing this will upgrade the cluster.</summary>
    [JsonPropertyName("reverseProxyEndpointPort")]
    public double? ReverseProxyEndpointPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderReverseProxyCertificate
{
    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>The Secondary Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprintSecondary")]
    public string? ThumbprintSecondary { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderReverseProxyCertificateCommonNamesCommonNames
{
    /// <summary>The common or subject name of the certificate.</summary>
    [JsonPropertyName("certificateCommonName")]
    public string? CertificateCommonName { get; set; }

    /// <summary>The Issuer Thumbprint of the Certificate.</summary>
    [JsonPropertyName("certificateIssuerThumbprint")]
    public string? CertificateIssuerThumbprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderReverseProxyCertificateCommonNames
{
    /// <summary>A common_names block as defined below.</summary>
    [JsonPropertyName("commonNames")]
    public IList<V1beta1ClusterStatusAtProviderReverseProxyCertificateCommonNamesCommonNames>? CommonNames { get; set; }

    /// <summary>The X509 Store where the Certificate Exists, such as My.</summary>
    [JsonPropertyName("x509StoreName")]
    public string? X509StoreName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderUpgradePolicyDeltaHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy applications that can have aggregated health states of error. If the current unhealthy applications do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyApplicationsPercent")]
    public double? MaxDeltaUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of delta unhealthy nodes that can have aggregated health states of error. If the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxDeltaUnhealthyNodesPercent")]
    public double? MaxDeltaUnhealthyNodesPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of upgrade domain delta unhealthy nodes that can have aggregated health state of error. If there is any upgrade domain where the current unhealthy nodes do not respect the percentage relative to the state at the beginning of the upgrade, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUpgradeDomainDeltaUnhealthyNodesPercent")]
    public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderUpgradePolicyHealthPolicy
{
    /// <summary>Specifies the maximum tolerated percentage of applications that can have aggregated health state of error. If the upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyApplicationsPercent")]
    public double? MaxUnhealthyApplicationsPercent { get; set; }

    /// <summary>Specifies the maximum tolerated percentage of nodes that can have aggregated health states of error. If an upgrade exceeds this percentage, the cluster is unhealthy. Defaults to 0.</summary>
    [JsonPropertyName("maxUnhealthyNodesPercent")]
    public double? MaxUnhealthyNodesPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderUpgradePolicy
{
    /// <summary>A delta_health_policy block as defined below</summary>
    [JsonPropertyName("deltaHealthPolicy")]
    public IList<V1beta1ClusterStatusAtProviderUpgradePolicyDeltaHealthPolicy>? DeltaHealthPolicy { get; set; }

    /// <summary>Indicates whether to restart the Service Fabric node even if only dynamic configurations have changed.</summary>
    [JsonPropertyName("forceRestartEnabled")]
    public bool? ForceRestartEnabled { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, after which Service Fabric retries the health check if the previous health check fails. Defaults to 00:45:00.</summary>
    [JsonPropertyName("healthCheckRetryTimeout")]
    public string? HealthCheckRetryTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits in order to verify that the cluster is stable before it continues to the next upgrade domain or completes the upgrade. This wait duration prevents undetected changes of health right after the health check is performed. Defaults to 00:01:00.</summary>
    [JsonPropertyName("healthCheckStableDuration")]
    public string? HealthCheckStableDuration { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits before it performs the initial health check after it finishes the upgrade on the upgrade domain. Defaults to 00:00:30.</summary>
    [JsonPropertyName("healthCheckWaitDuration")]
    public string? HealthCheckWaitDuration { get; set; }

    /// <summary>A health_policy block as defined below</summary>
    [JsonPropertyName("healthPolicy")]
    public IList<V1beta1ClusterStatusAtProviderUpgradePolicyHealthPolicy>? HealthPolicy { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes to upgrade a single upgrade domain. After this period, the upgrade fails. Defaults to 02:00:00.</summary>
    [JsonPropertyName("upgradeDomainTimeout")]
    public string? UpgradeDomainTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric waits for a replica set to reconfigure into a safe state, if it is not already in a safe state, before Service Fabric proceeds with the upgrade. Defaults to 10675199.02:48:05.4775807.</summary>
    [JsonPropertyName("upgradeReplicaSetCheckTimeout")]
    public string? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>Specifies the duration, in "hh:mm:ss" string format, that Service Fabric takes for the entire upgrade. After this period, the upgrade fails. Defaults to 12:00:00.</summary>
    [JsonPropertyName("upgradeTimeout")]
    public string? UpgradeTimeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>A List of one or more features which should be enabled, such as DnsService.</summary>
    [JsonPropertyName("addOnFeatures")]
    public IList<string>? AddOnFeatures { get; set; }

    /// <summary>An azure_active_directory block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public IList<V1beta1ClusterStatusAtProviderAzureActiveDirectory>? AzureActiveDirectory { get; set; }

    /// <summary>A certificate block as defined below. Conflicts with certificate_common_names.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1ClusterStatusAtProviderCertificate>? Certificate { get; set; }

    /// <summary>A certificate_common_names block as defined below. Conflicts with certificate.</summary>
    [JsonPropertyName("certificateCommonNames")]
    public IList<V1beta1ClusterStatusAtProviderCertificateCommonNames>? CertificateCommonNames { get; set; }

    /// <summary>A client_certificate_common_name block as defined below.</summary>
    [JsonPropertyName("clientCertificateCommonName")]
    public IList<V1beta1ClusterStatusAtProviderClientCertificateCommonName>? ClientCertificateCommonName { get; set; }

    /// <summary>One or more client_certificate_thumbprint blocks as defined below.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public IList<V1beta1ClusterStatusAtProviderClientCertificateThumbprint>? ClientCertificateThumbprint { get; set; }

    /// <summary>Required if Upgrade Mode set to Manual, Specifies the Version of the Cluster Code of the cluster.</summary>
    [JsonPropertyName("clusterCodeVersion")]
    public string? ClusterCodeVersion { get; set; }

    /// <summary>The Cluster Endpoint for this Service Fabric Cluster.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>A diagnostics_config block as defined below.</summary>
    [JsonPropertyName("diagnosticsConfig")]
    public IList<V1beta1ClusterStatusAtProviderDiagnosticsConfig>? DiagnosticsConfig { get; set; }

    /// <summary>One or more fabric_settings blocks as defined below.</summary>
    [JsonPropertyName("fabricSettings")]
    public IList<V1beta1ClusterStatusAtProviderFabricSettings>? FabricSettings { get; set; }

    /// <summary>The ID of the Service Fabric Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Management Endpoint of the cluster such as http://example.com. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementEndpoint")]
    public string? ManagementEndpoint { get; set; }

    /// <summary>One or more node_type blocks as defined below.</summary>
    [JsonPropertyName("nodeType")]
    public IList<V1beta1ClusterStatusAtProviderNodeType>? NodeType { get; set; }

    /// <summary>Specifies the Reliability Level of the Cluster. Possible values include None, Bronze, Silver, Gold and Platinum.</summary>
    [JsonPropertyName("reliabilityLevel")]
    public string? ReliabilityLevel { get; set; }

    /// <summary>The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A reverse_proxy_certificate block as defined below. Conflicts with reverse_proxy_certificate_common_names.</summary>
    [JsonPropertyName("reverseProxyCertificate")]
    public IList<V1beta1ClusterStatusAtProviderReverseProxyCertificate>? ReverseProxyCertificate { get; set; }

    /// <summary>A reverse_proxy_certificate_common_names block as defined below. Conflicts with reverse_proxy_certificate.</summary>
    [JsonPropertyName("reverseProxyCertificateCommonNames")]
    public IList<V1beta1ClusterStatusAtProviderReverseProxyCertificateCommonNames>? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>Specifies the logical grouping of VMs in upgrade domains. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("serviceFabricZonalUpgradeMode")]
    public string? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Upgrade Mode of the cluster. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>A upgrade_policy block as defined below.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterStatusAtProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Specifies the Image expected for the Service Fabric Cluster, such as Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmImage")]
    public string? VmImage { get; set; }

    /// <summary>Specifies the upgrade mode for the virtual machine scale set updates that happen in all availability zones at once. Possible values are Hierarchical or Parallel.</summary>
    [JsonPropertyName("vmssZonalUpgradeMode")]
    public string? VmssZonalUpgradeMode { get; set; }
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

/// <summary>Cluster is the Schema for the Clusters API. Manages a Service Fabric Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "servicefabric.azure.upbound.io";
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