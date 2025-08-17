using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.upbound.io;
#nullable enable
/// <summary>Environment is the Schema for the Environments API. Manages a Container App Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Environment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentList";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "environments";
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
    public IList<V1beta1Environment> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created. Application Insights connection string used by Dapr to export Service to Service communication telemetry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderDaprApplicationInsightsConnectionStringSecretRef
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicy
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
/// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicy
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
/// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicy
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
/// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy
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
/// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProvider
{
    /// <summary>Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created. Application Insights connection string used by Dapr to export Service to Service communication telemetry.</summary>
    [JsonPropertyName("daprApplicationInsightsConnectionStringSecretRef")]
    public V1beta1EnvironmentSpecForProviderDaprApplicationInsightsConnectionStringSecretRef? DaprApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created. Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.</summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameRef")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRef? InfrastructureResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameSelector")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelector? InfrastructureResourceGroupNameSelector { get; set; }

    /// <summary>The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created. The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.</summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdRef")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRef? InfrastructureSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdSelector")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelector? InfrastructureSubnetIdSelector { get; set; }

    /// <summary>Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created. Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.</summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to. The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>Should mutual transport layer security (mTLS) be enabled? Defaults to false. Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.</summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentSpecForProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created. Application Insights connection string used by Dapr to export Service to Service communication telemetry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderDaprApplicationInsightsConnectionStringSecretRef
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicy
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
/// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicy
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
/// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy
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
/// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy
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
/// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProvider
{
    /// <summary>Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created. Application Insights connection string used by Dapr to export Service to Service communication telemetry.</summary>
    [JsonPropertyName("daprApplicationInsightsConnectionStringSecretRef")]
    public V1beta1EnvironmentSpecInitProviderDaprApplicationInsightsConnectionStringSecretRef? DaprApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created. Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.</summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameRef")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRef? InfrastructureResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameSelector")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelector? InfrastructureResourceGroupNameSelector { get; set; }

    /// <summary>The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created. The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.</summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdRef")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRef? InfrastructureSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdSelector")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelector? InfrastructureSubnetIdSelector { get; set; }

    /// <summary>Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created. Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.</summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to. The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>Should mutual transport layer security (mTLS) be enabled? Defaults to false. Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.</summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentSpecInitProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecProviderConfigRefPolicy
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
public partial class V1beta1EnvironmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecWriteConnectionSecretToRef
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
/// <summary>EnvironmentSpec defines the desired state of Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EnvironmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusAtProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusAtProvider
{
    /// <summary>The ID of the Custom Domain Verification for this Container App Environment. The ID of the Custom Domain Verification for this Container App Environment.</summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>The default, publicly resolvable, name of this Container App Environment. The default publicly resolvable name of this Container App Environment</summary>
    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    /// <summary>The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation. The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.</summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>The ID of the Container App Environment</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created. Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.</summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created. The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.</summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created. Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.</summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to. The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>Should mutual transport layer security (mTLS) be enabled? Defaults to false. Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.</summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses. The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.</summary>
    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    /// <summary>The IP address from the IP range defined by platform_reserved_cidr that is reserved for the internal DNS server. The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.</summary>
    [JsonPropertyName("platformReservedDnsIpAddress")]
    public string? PlatformReservedDnsIpAddress { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Static IP address of the Environment. The Static IP Address of the Environment.</summary>
    [JsonPropertyName("staticIpAddress")]
    public string? StaticIpAddress { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentStatusAtProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusConditions
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
/// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Environment is the Schema for the Environments API. Manages a Container App Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Environment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvironmentSpec>, IStatus<V1beta1EnvironmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Environment";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentSpec defines the desired state of Environment</summary>
    [JsonPropertyName("spec")]
    public V1beta1EnvironmentSpec Spec { get; set; }

    /// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvironmentStatus? Status { get; set; }
}
#nullable disable
