using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.operationalinsights.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecForProvider
{
    /// <summary>The additional properties that can be set for the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("additionalSettingsJson")]
    public string? AdditionalSettingsJson { get; set; }

    /// <summary>The body of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of the related categories for the function. Possible values are applications, audit, container, databases, desktopanalytics, management, monitor, network, resources, security, virtualmachines, windowsvirtualdesktop and workloads.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique display name for the query within the Log Analytics Query Pack.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An unique UUID/GUID which identifies this Log Analytics Query Pack Query - one will be generated if not specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Log Analytics Query Pack. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("queryPackId")]
    public string? QueryPackId { get; set; }

    /// <summary>Reference to a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
    [JsonPropertyName("queryPackIdRef")]
    public V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdRef? QueryPackIdRef { get; set; }

    /// <summary>Selector for a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
    [JsonPropertyName("queryPackIdSelector")]
    public V1beta1LogAnalyticsQueryPackQuerySpecForProviderQueryPackIdSelector? QueryPackIdSelector { get; set; }

    /// <summary>A list of the related resource types for the function. Possible values are default, microsoft.aad/domainservices, microsoft.aadiam/tenants, microsoft.agfoodplatform/farmbeats, microsoft.analysisservices/servers, microsoft.apimanagement/service, microsoft.appconfiguration/configurationstores, microsoft.appplatform/spring, microsoft.attestation/attestationproviders, microsoft.authorization/tenants, microsoft.automation/automationaccounts, microsoft.autonomousdevelopmentplatform/accounts, microsoft.azurestackhci/virtualmachines, microsoft.batch/batchaccounts, microsoft.blockchain/blockchainmembers, microsoft.botservice/botservices, microsoft.cache/redis, microsoft.cdn/profiles, microsoft.cognitiveservices/accounts, microsoft.communication/communicationservices, microsoft.compute/virtualmachines, microsoft.compute/virtualmachinescalesets, microsoft.connectedcache/cachenodes, microsoft.connectedvehicle/platformaccounts, microsoft.conenctedvmwarevsphere/virtualmachines, microsoft.containerregistry/registries, microsoft.containerservice/managedclusters, microsoft.d365customerinsights/instances, microsoft.dashboard/grafana, microsoft.databricks/workspaces, microsoft.datacollaboration/workspaces, microsoft.datafactory/factories, microsoft.datalakeanalytics/accounts, microsoft.datalakestore/accounts, microsoft.datashare/accounts, microsoft.dbformariadb/servers, microsoft.dbformysql/servers, microsoft.dbforpostgresql/flexibleservers, microsoft.dbforpostgresql/servers, microsoft.dbforpostgresql/serversv2, microsoft.digitaltwins/digitaltwinsinstances, microsoft.documentdb/cassandraclusters, microsoft.documentdb/databaseaccounts, microsoft.desktopvirtualization/applicationgroups, microsoft.desktopvirtualization/hostpools, microsoft.desktopvirtualization/workspaces, microsoft.devices/iothubs, microsoft.devices/provisioningservices, microsoft.dynamics/fraudprotection/purchase, microsoft.eventgrid/domains, microsoft.eventgrid/topics, microsoft.eventgrid/partnernamespaces, microsoft.eventgrid/partnertopics, microsoft.eventgrid/systemtopics, microsoft.eventhub/namespaces, microsoft.experimentation/experimentworkspaces, microsoft.hdinsight/clusters, microsoft.healthcareapis/services, microsoft.informationprotection/datasecuritymanagement, microsoft.intune/operations, microsoft.insights/autoscalesettings, microsoft.insights/components, microsoft.insights/workloadmonitoring, microsoft.keyvault/vaults, microsoft.kubernetes/connectedclusters, microsoft.kusto/clusters, microsoft.loadtestservice/loadtests, microsoft.logic/workflows, microsoft.machinelearningservices/workspaces, microsoft.media/mediaservices, microsoft.netapp/netappaccounts/capacitypools, microsoft.network/applicationgateways, microsoft.network/azurefirewalls, microsoft.network/bastionhosts, microsoft.network/expressroutecircuits, microsoft.network/frontdoors, microsoft.network/loadbalancers, microsoft.network/networkinterfaces, microsoft.network/networksecuritygroups, microsoft.network/networksecurityperimeters, microsoft.network/networkwatchers/connectionmonitors, microsoft.network/networkwatchers/trafficanalytics, microsoft.network/publicipaddresses, microsoft.network/trafficmanagerprofiles, microsoft.network/virtualnetworks, microsoft.network/virtualnetworkgateways, microsoft.network/vpngateways, microsoft.networkfunction/azuretrafficcollectors, microsoft.openenergyplatform/energyservices, microsoft.openlogisticsplatform/workspaces, microsoft.operationalinsights/workspaces, microsoft.powerbi/tenants, microsoft.powerbi/tenants/workspaces, microsoft.powerbidedicated/capacities, microsoft.purview/accounts, microsoft.recoveryservices/vaults, microsoft.resources/azureactivity, microsoft.scvmm/virtualmachines, microsoft.search/searchservices, microsoft.security/antimalwaresettings, microsoft.securityinsights/amazon, microsoft.securityinsights/anomalies, microsoft.securityinsights/cef, microsoft.securityinsights/datacollection, microsoft.securityinsights/dnsnormalized, microsoft.securityinsights/mda, microsoft.securityinsights/mde, microsoft.securityinsights/mdi, microsoft.securityinsights/mdo, microsoft.securityinsights/networksessionnormalized, microsoft.securityinsights/office365, microsoft.securityinsights/purview, microsoft.securityinsights/securityinsights, microsoft.securityinsights/securityinsights/mcas, microsoft.securityinsights/tvm, microsoft.securityinsights/watchlists, microsoft.servicebus/namespaces, microsoft.servicefabric/clusters, microsoft.signalrservice/signalr, microsoft.signalrservice/webpubsub, microsoft.sql/managedinstances, microsoft.sql/servers, microsoft.sql/servers/databases, microsoft.storage/storageaccounts, microsoft.storagecache/caches, microsoft.streamanalytics/streamingjobs, microsoft.synapse/workspaces, microsoft.timeseriesinsights/environments, microsoft.videoindexer/accounts, microsoft.web/sites, microsoft.workloadmonitor/monitors, resourcegroup and subscription.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A list of the related Log Analytics solutions for the function. Possible values are AADDomainServices, ADAssessment, ADAssessmentPlus, ADReplication, ADSecurityAssessment, AlertManagement, AntiMalware, ApplicationInsights, AzureAssessment, AzureSecurityOfThings, AzureSentinelDSRE, AzureSentinelPrivatePreview, BehaviorAnalyticsInsights, ChangeTracking, CompatibilityAssessment, ContainerInsights, Containers, CustomizedWindowsEventsFiltering, DeviceHealthProd, DnsAnalytics, ExchangeAssessment, ExchangeOnlineAssessment, IISAssessmentPlus, InfrastructureInsights, InternalWindowsEvent, LogManagement, Microsoft365Analytics, NetworkMonitoring, SCCMAssessmentPlus, SCOMAssessment, SCOMAssessmentPlus, Security, SecurityCenter, SecurityCenterFree, SecurityInsights, ServiceMap, SfBAssessment, SfBOnlineAssessment, SharePointOnlineAssessment, SPAssessment, SQLAdvancedThreatProtection, SQLAssessment, SQLAssessmentPlus, SQLDataClassification, SQLThreatDetection, SQLVulnerabilityAssessment, SurfaceHub, Updates, VMInsights, WEFInternalUat, WEF_10x, WEF_10xDSRE, WaaSUpdateInsights, WinLog, WindowsClientAssessmentPlus, WindowsEventForwarding, WindowsFirewall, WindowsServerAssessment, WireData and WireData2.</summary>
    [JsonPropertyName("solutions")]
    public IList<string>? Solutions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecInitProvider
{
    /// <summary>The additional properties that can be set for the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("additionalSettingsJson")]
    public string? AdditionalSettingsJson { get; set; }

    /// <summary>The body of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of the related categories for the function. Possible values are applications, audit, container, databases, desktopanalytics, management, monitor, network, resources, security, virtualmachines, windowsvirtualdesktop and workloads.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique display name for the query within the Log Analytics Query Pack.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An unique UUID/GUID which identifies this Log Analytics Query Pack Query - one will be generated if not specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Log Analytics Query Pack. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("queryPackId")]
    public string? QueryPackId { get; set; }

    /// <summary>Reference to a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
    [JsonPropertyName("queryPackIdRef")]
    public V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdRef? QueryPackIdRef { get; set; }

    /// <summary>Selector for a LogAnalyticsQueryPack in operationalinsights to populate queryPackId.</summary>
    [JsonPropertyName("queryPackIdSelector")]
    public V1beta1LogAnalyticsQueryPackQuerySpecInitProviderQueryPackIdSelector? QueryPackIdSelector { get; set; }

    /// <summary>A list of the related resource types for the function. Possible values are default, microsoft.aad/domainservices, microsoft.aadiam/tenants, microsoft.agfoodplatform/farmbeats, microsoft.analysisservices/servers, microsoft.apimanagement/service, microsoft.appconfiguration/configurationstores, microsoft.appplatform/spring, microsoft.attestation/attestationproviders, microsoft.authorization/tenants, microsoft.automation/automationaccounts, microsoft.autonomousdevelopmentplatform/accounts, microsoft.azurestackhci/virtualmachines, microsoft.batch/batchaccounts, microsoft.blockchain/blockchainmembers, microsoft.botservice/botservices, microsoft.cache/redis, microsoft.cdn/profiles, microsoft.cognitiveservices/accounts, microsoft.communication/communicationservices, microsoft.compute/virtualmachines, microsoft.compute/virtualmachinescalesets, microsoft.connectedcache/cachenodes, microsoft.connectedvehicle/platformaccounts, microsoft.conenctedvmwarevsphere/virtualmachines, microsoft.containerregistry/registries, microsoft.containerservice/managedclusters, microsoft.d365customerinsights/instances, microsoft.dashboard/grafana, microsoft.databricks/workspaces, microsoft.datacollaboration/workspaces, microsoft.datafactory/factories, microsoft.datalakeanalytics/accounts, microsoft.datalakestore/accounts, microsoft.datashare/accounts, microsoft.dbformariadb/servers, microsoft.dbformysql/servers, microsoft.dbforpostgresql/flexibleservers, microsoft.dbforpostgresql/servers, microsoft.dbforpostgresql/serversv2, microsoft.digitaltwins/digitaltwinsinstances, microsoft.documentdb/cassandraclusters, microsoft.documentdb/databaseaccounts, microsoft.desktopvirtualization/applicationgroups, microsoft.desktopvirtualization/hostpools, microsoft.desktopvirtualization/workspaces, microsoft.devices/iothubs, microsoft.devices/provisioningservices, microsoft.dynamics/fraudprotection/purchase, microsoft.eventgrid/domains, microsoft.eventgrid/topics, microsoft.eventgrid/partnernamespaces, microsoft.eventgrid/partnertopics, microsoft.eventgrid/systemtopics, microsoft.eventhub/namespaces, microsoft.experimentation/experimentworkspaces, microsoft.hdinsight/clusters, microsoft.healthcareapis/services, microsoft.informationprotection/datasecuritymanagement, microsoft.intune/operations, microsoft.insights/autoscalesettings, microsoft.insights/components, microsoft.insights/workloadmonitoring, microsoft.keyvault/vaults, microsoft.kubernetes/connectedclusters, microsoft.kusto/clusters, microsoft.loadtestservice/loadtests, microsoft.logic/workflows, microsoft.machinelearningservices/workspaces, microsoft.media/mediaservices, microsoft.netapp/netappaccounts/capacitypools, microsoft.network/applicationgateways, microsoft.network/azurefirewalls, microsoft.network/bastionhosts, microsoft.network/expressroutecircuits, microsoft.network/frontdoors, microsoft.network/loadbalancers, microsoft.network/networkinterfaces, microsoft.network/networksecuritygroups, microsoft.network/networksecurityperimeters, microsoft.network/networkwatchers/connectionmonitors, microsoft.network/networkwatchers/trafficanalytics, microsoft.network/publicipaddresses, microsoft.network/trafficmanagerprofiles, microsoft.network/virtualnetworks, microsoft.network/virtualnetworkgateways, microsoft.network/vpngateways, microsoft.networkfunction/azuretrafficcollectors, microsoft.openenergyplatform/energyservices, microsoft.openlogisticsplatform/workspaces, microsoft.operationalinsights/workspaces, microsoft.powerbi/tenants, microsoft.powerbi/tenants/workspaces, microsoft.powerbidedicated/capacities, microsoft.purview/accounts, microsoft.recoveryservices/vaults, microsoft.resources/azureactivity, microsoft.scvmm/virtualmachines, microsoft.search/searchservices, microsoft.security/antimalwaresettings, microsoft.securityinsights/amazon, microsoft.securityinsights/anomalies, microsoft.securityinsights/cef, microsoft.securityinsights/datacollection, microsoft.securityinsights/dnsnormalized, microsoft.securityinsights/mda, microsoft.securityinsights/mde, microsoft.securityinsights/mdi, microsoft.securityinsights/mdo, microsoft.securityinsights/networksessionnormalized, microsoft.securityinsights/office365, microsoft.securityinsights/purview, microsoft.securityinsights/securityinsights, microsoft.securityinsights/securityinsights/mcas, microsoft.securityinsights/tvm, microsoft.securityinsights/watchlists, microsoft.servicebus/namespaces, microsoft.servicefabric/clusters, microsoft.signalrservice/signalr, microsoft.signalrservice/webpubsub, microsoft.sql/managedinstances, microsoft.sql/servers, microsoft.sql/servers/databases, microsoft.storage/storageaccounts, microsoft.storagecache/caches, microsoft.streamanalytics/streamingjobs, microsoft.synapse/workspaces, microsoft.timeseriesinsights/environments, microsoft.videoindexer/accounts, microsoft.web/sites, microsoft.workloadmonitor/monitors, resourcegroup and subscription.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A list of the related Log Analytics solutions for the function. Possible values are AADDomainServices, ADAssessment, ADAssessmentPlus, ADReplication, ADSecurityAssessment, AlertManagement, AntiMalware, ApplicationInsights, AzureAssessment, AzureSecurityOfThings, AzureSentinelDSRE, AzureSentinelPrivatePreview, BehaviorAnalyticsInsights, ChangeTracking, CompatibilityAssessment, ContainerInsights, Containers, CustomizedWindowsEventsFiltering, DeviceHealthProd, DnsAnalytics, ExchangeAssessment, ExchangeOnlineAssessment, IISAssessmentPlus, InfrastructureInsights, InternalWindowsEvent, LogManagement, Microsoft365Analytics, NetworkMonitoring, SCCMAssessmentPlus, SCOMAssessment, SCOMAssessmentPlus, Security, SecurityCenter, SecurityCenterFree, SecurityInsights, ServiceMap, SfBAssessment, SfBOnlineAssessment, SharePointOnlineAssessment, SPAssessment, SQLAdvancedThreatProtection, SQLAssessment, SQLAssessmentPlus, SQLDataClassification, SQLThreatDetection, SQLVulnerabilityAssessment, SurfaceHub, Updates, VMInsights, WEFInternalUat, WEF_10x, WEF_10xDSRE, WaaSUpdateInsights, WinLog, WindowsClientAssessmentPlus, WindowsEventForwarding, WindowsFirewall, WindowsServerAssessment, WireData and WireData2.</summary>
    [JsonPropertyName("solutions")]
    public IList<string>? Solutions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecProviderConfigRefPolicy
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
public partial class V1beta1LogAnalyticsQueryPackQuerySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LogAnalyticsQueryPackQuerySpec defines the desired state of LogAnalyticsQueryPackQuery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQuerySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LogAnalyticsQueryPackQuerySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LogAnalyticsQueryPackQuerySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LogAnalyticsQueryPackQuerySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LogAnalyticsQueryPackQuerySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LogAnalyticsQueryPackQuerySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQueryStatusAtProvider
{
    /// <summary>The additional properties that can be set for the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("additionalSettingsJson")]
    public string? AdditionalSettingsJson { get; set; }

    /// <summary>The body of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of the related categories for the function. Possible values are applications, audit, container, databases, desktopanalytics, management, monitor, network, resources, security, virtualmachines, windowsvirtualdesktop and workloads.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The description of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The unique display name for the query within the Log Analytics Query Pack.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An unique UUID/GUID which identifies this Log Analytics Query Pack Query - one will be generated if not specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Log Analytics Query Pack. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("queryPackId")]
    public string? QueryPackId { get; set; }

    /// <summary>A list of the related resource types for the function. Possible values are default, microsoft.aad/domainservices, microsoft.aadiam/tenants, microsoft.agfoodplatform/farmbeats, microsoft.analysisservices/servers, microsoft.apimanagement/service, microsoft.appconfiguration/configurationstores, microsoft.appplatform/spring, microsoft.attestation/attestationproviders, microsoft.authorization/tenants, microsoft.automation/automationaccounts, microsoft.autonomousdevelopmentplatform/accounts, microsoft.azurestackhci/virtualmachines, microsoft.batch/batchaccounts, microsoft.blockchain/blockchainmembers, microsoft.botservice/botservices, microsoft.cache/redis, microsoft.cdn/profiles, microsoft.cognitiveservices/accounts, microsoft.communication/communicationservices, microsoft.compute/virtualmachines, microsoft.compute/virtualmachinescalesets, microsoft.connectedcache/cachenodes, microsoft.connectedvehicle/platformaccounts, microsoft.conenctedvmwarevsphere/virtualmachines, microsoft.containerregistry/registries, microsoft.containerservice/managedclusters, microsoft.d365customerinsights/instances, microsoft.dashboard/grafana, microsoft.databricks/workspaces, microsoft.datacollaboration/workspaces, microsoft.datafactory/factories, microsoft.datalakeanalytics/accounts, microsoft.datalakestore/accounts, microsoft.datashare/accounts, microsoft.dbformariadb/servers, microsoft.dbformysql/servers, microsoft.dbforpostgresql/flexibleservers, microsoft.dbforpostgresql/servers, microsoft.dbforpostgresql/serversv2, microsoft.digitaltwins/digitaltwinsinstances, microsoft.documentdb/cassandraclusters, microsoft.documentdb/databaseaccounts, microsoft.desktopvirtualization/applicationgroups, microsoft.desktopvirtualization/hostpools, microsoft.desktopvirtualization/workspaces, microsoft.devices/iothubs, microsoft.devices/provisioningservices, microsoft.dynamics/fraudprotection/purchase, microsoft.eventgrid/domains, microsoft.eventgrid/topics, microsoft.eventgrid/partnernamespaces, microsoft.eventgrid/partnertopics, microsoft.eventgrid/systemtopics, microsoft.eventhub/namespaces, microsoft.experimentation/experimentworkspaces, microsoft.hdinsight/clusters, microsoft.healthcareapis/services, microsoft.informationprotection/datasecuritymanagement, microsoft.intune/operations, microsoft.insights/autoscalesettings, microsoft.insights/components, microsoft.insights/workloadmonitoring, microsoft.keyvault/vaults, microsoft.kubernetes/connectedclusters, microsoft.kusto/clusters, microsoft.loadtestservice/loadtests, microsoft.logic/workflows, microsoft.machinelearningservices/workspaces, microsoft.media/mediaservices, microsoft.netapp/netappaccounts/capacitypools, microsoft.network/applicationgateways, microsoft.network/azurefirewalls, microsoft.network/bastionhosts, microsoft.network/expressroutecircuits, microsoft.network/frontdoors, microsoft.network/loadbalancers, microsoft.network/networkinterfaces, microsoft.network/networksecuritygroups, microsoft.network/networksecurityperimeters, microsoft.network/networkwatchers/connectionmonitors, microsoft.network/networkwatchers/trafficanalytics, microsoft.network/publicipaddresses, microsoft.network/trafficmanagerprofiles, microsoft.network/virtualnetworks, microsoft.network/virtualnetworkgateways, microsoft.network/vpngateways, microsoft.networkfunction/azuretrafficcollectors, microsoft.openenergyplatform/energyservices, microsoft.openlogisticsplatform/workspaces, microsoft.operationalinsights/workspaces, microsoft.powerbi/tenants, microsoft.powerbi/tenants/workspaces, microsoft.powerbidedicated/capacities, microsoft.purview/accounts, microsoft.recoveryservices/vaults, microsoft.resources/azureactivity, microsoft.scvmm/virtualmachines, microsoft.search/searchservices, microsoft.security/antimalwaresettings, microsoft.securityinsights/amazon, microsoft.securityinsights/anomalies, microsoft.securityinsights/cef, microsoft.securityinsights/datacollection, microsoft.securityinsights/dnsnormalized, microsoft.securityinsights/mda, microsoft.securityinsights/mde, microsoft.securityinsights/mdi, microsoft.securityinsights/mdo, microsoft.securityinsights/networksessionnormalized, microsoft.securityinsights/office365, microsoft.securityinsights/purview, microsoft.securityinsights/securityinsights, microsoft.securityinsights/securityinsights/mcas, microsoft.securityinsights/tvm, microsoft.securityinsights/watchlists, microsoft.servicebus/namespaces, microsoft.servicefabric/clusters, microsoft.signalrservice/signalr, microsoft.signalrservice/webpubsub, microsoft.sql/managedinstances, microsoft.sql/servers, microsoft.sql/servers/databases, microsoft.storage/storageaccounts, microsoft.storagecache/caches, microsoft.streamanalytics/streamingjobs, microsoft.synapse/workspaces, microsoft.timeseriesinsights/environments, microsoft.videoindexer/accounts, microsoft.web/sites, microsoft.workloadmonitor/monitors, resourcegroup and subscription.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A list of the related Log Analytics solutions for the function. Possible values are AADDomainServices, ADAssessment, ADAssessmentPlus, ADReplication, ADSecurityAssessment, AlertManagement, AntiMalware, ApplicationInsights, AzureAssessment, AzureSecurityOfThings, AzureSentinelDSRE, AzureSentinelPrivatePreview, BehaviorAnalyticsInsights, ChangeTracking, CompatibilityAssessment, ContainerInsights, Containers, CustomizedWindowsEventsFiltering, DeviceHealthProd, DnsAnalytics, ExchangeAssessment, ExchangeOnlineAssessment, IISAssessmentPlus, InfrastructureInsights, InternalWindowsEvent, LogManagement, Microsoft365Analytics, NetworkMonitoring, SCCMAssessmentPlus, SCOMAssessment, SCOMAssessmentPlus, Security, SecurityCenter, SecurityCenterFree, SecurityInsights, ServiceMap, SfBAssessment, SfBOnlineAssessment, SharePointOnlineAssessment, SPAssessment, SQLAdvancedThreatProtection, SQLAssessment, SQLAssessmentPlus, SQLDataClassification, SQLThreatDetection, SQLVulnerabilityAssessment, SurfaceHub, Updates, VMInsights, WEFInternalUat, WEF_10x, WEF_10xDSRE, WaaSUpdateInsights, WinLog, WindowsClientAssessmentPlus, WindowsEventForwarding, WindowsFirewall, WindowsServerAssessment, WireData and WireData2.</summary>
    [JsonPropertyName("solutions")]
    public IList<string>? Solutions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Log Analytics Query Pack Query.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQueryStatusConditions
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

/// <summary>LogAnalyticsQueryPackQueryStatus defines the observed state of LogAnalyticsQueryPackQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LogAnalyticsQueryPackQueryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LogAnalyticsQueryPackQueryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LogAnalyticsQueryPackQueryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LogAnalyticsQueryPackQuery is the Schema for the LogAnalyticsQueryPackQuerys API. Manages a Log Analytics Query Pack Query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LogAnalyticsQueryPackQuery : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LogAnalyticsQueryPackQuerySpec>, IStatus<V1beta1LogAnalyticsQueryPackQueryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LogAnalyticsQueryPackQuery";
    public const string KubeGroup = "operationalinsights.azure.upbound.io";
    public const string KubePluralName = "loganalyticsquerypackqueries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LogAnalyticsQueryPackQuerySpec defines the desired state of LogAnalyticsQueryPackQuery</summary>
    [JsonPropertyName("spec")]
    public V1beta1LogAnalyticsQueryPackQuerySpec Spec { get; set; }

    /// <summary>LogAnalyticsQueryPackQueryStatus defines the observed state of LogAnalyticsQueryPackQuery.</summary>
    [JsonPropertyName("status")]
    public V1beta1LogAnalyticsQueryPackQueryStatus? Status { get; set; }
}

/// <summary>LogAnalyticsQueryPackQuery is the Schema for the LogAnalyticsQueryPackQuerys API. Manages a Log Analytics Query Pack Query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LogAnalyticsQueryPackQueryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LogAnalyticsQueryPackQuery>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LogAnalyticsQueryPackQueryList";
    public const string KubeGroup = "operationalinsights.azure.upbound.io";
    public const string KubePluralName = "loganalyticsquerypackqueries";
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
    public IList<V1beta1LogAnalyticsQueryPackQuery> Items { get; set; }
}