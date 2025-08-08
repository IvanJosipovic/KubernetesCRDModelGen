using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.azure.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderAdditionalWorkspace
{
    /// <summary>A list of data types which sent to workspace. Possible values are Alerts and RawEvents.</summary>
    [JsonPropertyName("dataTypes")]
    public IList<string>? DataTypes { get; set; }

    /// <summary>The resource ID of the Log Analytics Workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderIothubIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderIothubIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecForProviderIothubIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderIothubIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of IOTHub in devices to populate iothubIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderIothubIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecForProviderIothubIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderRecommendationsEnabled
{
    /// <summary>Is Principal Authentication enabled for the ACR repository? Defaults to true.</summary>
    [JsonPropertyName("acrAuthentication")]
    public bool? AcrAuthentication { get; set; }

    /// <summary>Is Agent send underutilized messages enabled? Defaults to true.</summary>
    [JsonPropertyName("agentSendUnutilizedMsg")]
    public bool? AgentSendUnutilizedMsg { get; set; }

    /// <summary>Is Security related system configuration issues identified? Defaults to true.</summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>Is IoT Edge Hub memory optimized? Defaults to true.</summary>
    [JsonPropertyName("edgeHubMemOptimize")]
    public bool? EdgeHubMemOptimize { get; set; }

    /// <summary>Is logging configured for IoT Edge module? Defaults to true.</summary>
    [JsonPropertyName("edgeLoggingOption")]
    public bool? EdgeLoggingOption { get; set; }

    /// <summary>Is inconsistent module settings enabled for SecurityGroup? Defaults to true.</summary>
    [JsonPropertyName("inconsistentModuleSettings")]
    public bool? InconsistentModuleSettings { get; set; }

    /// <summary>is Azure IoT Security agent installed? Defaults to true.</summary>
    [JsonPropertyName("installAgent")]
    public bool? InstallAgent { get; set; }

    /// <summary>Is Default IP filter policy denied? Defaults to true.</summary>
    [JsonPropertyName("ipFilterDenyAll")]
    public bool? IpFilterDenyAll { get; set; }

    /// <summary>Is IP filter rule source allowable IP range too large? Defaults to true.</summary>
    [JsonPropertyName("ipFilterPermissiveRule")]
    public bool? IpFilterPermissiveRule { get; set; }

    /// <summary>Is any ports open on the device? Defaults to true.</summary>
    [JsonPropertyName("openPorts")]
    public bool? OpenPorts { get; set; }

    /// <summary>Does firewall policy exist which allow necessary communication to/from the device? Defaults to true.</summary>
    [JsonPropertyName("permissiveFirewallPolicy")]
    public bool? PermissiveFirewallPolicy { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted in? Defaults to true.</summary>
    [JsonPropertyName("permissiveInputFirewallRules")]
    public bool? PermissiveInputFirewallRules { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted out? Defaults to true.</summary>
    [JsonPropertyName("permissiveOutputFirewallRules")]
    public bool? PermissiveOutputFirewallRules { get; set; }

    /// <summary>Is high level permissions are needed for the module? Defaults to true.</summary>
    [JsonPropertyName("privilegedDockerOptions")]
    public bool? PrivilegedDockerOptions { get; set; }

    /// <summary>Is any credentials shared among devices? Defaults to true.</summary>
    [JsonPropertyName("sharedCredentials")]
    public bool? SharedCredentials { get; set; }

    /// <summary>Does TLS cipher suite need to be updated? Defaults to true.</summary>
    [JsonPropertyName("vulnerableTlsCipherSuite")]
    public bool? VulnerableTlsCipherSuite { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecForProvider
{
    /// <summary>A additional_workspace block as defined below.</summary>
    [JsonPropertyName("additionalWorkspace")]
    public IList<V1beta1IOTSecuritySolutionSpecForProviderAdditionalWorkspace>? AdditionalWorkspace { get; set; }

    /// <summary>A list of disabled data sources for the Iot Security Solution. Possible value is TwinData.</summary>
    [JsonPropertyName("disabledDataSources")]
    public IList<string>? DisabledDataSources { get; set; }

    /// <summary>Specifies the Display Name for this Iot Security Solution.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Is the Iot Security Solution enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of data which is to exported to analytic workspace. Valid values include RawEvents.</summary>
    [JsonPropertyName("eventsToExport")]
    public IList<string>? EventsToExport { get; set; }

    /// <summary>Specifies the IoT Hub resource IDs to which this Iot Security Solution is applied.</summary>
    [JsonPropertyName("iothubIds")]
    public IList<string>? IothubIds { get; set; }

    /// <summary>References to IOTHub in devices to populate iothubIds.</summary>
    [JsonPropertyName("iothubIdsRefs")]
    public IList<V1beta1IOTSecuritySolutionSpecForProviderIothubIdsRefs>? IothubIdsRefs { get; set; }

    /// <summary>Selector for a list of IOTHub in devices to populate iothubIds.</summary>
    [JsonPropertyName("iothubIdsSelector")]
    public V1beta1IOTSecuritySolutionSpecForProviderIothubIdsSelector? IothubIdsSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Log Analytics Workspace ID to which the security data will be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Should IP addressed be unmasked in the log? Defaults to false.</summary>
    [JsonPropertyName("logUnmaskedIpsEnabled")]
    public bool? LogUnmaskedIpsEnabled { get; set; }

    /// <summary>Specifies the name of the Iot Security Solution. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An Azure Resource Graph query used to set the resources monitored.</summary>
    [JsonPropertyName("queryForResources")]
    public string? QueryForResources { get; set; }

    /// <summary>A list of subscription Ids on which the user defined resources query should be executed.</summary>
    [JsonPropertyName("querySubscriptionIds")]
    public IList<string>? QuerySubscriptionIds { get; set; }

    /// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
    [JsonPropertyName("recommendationsEnabled")]
    public V1beta1IOTSecuritySolutionSpecForProviderRecommendationsEnabled? RecommendationsEnabled { get; set; }

    /// <summary>Specifies the name of the resource group in which to create the Iot Security Solution. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1IOTSecuritySolutionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderAdditionalWorkspace
{
    /// <summary>A list of data types which sent to workspace. Possible values are Alerts and RawEvents.</summary>
    [JsonPropertyName("dataTypes")]
    public IList<string>? DataTypes { get; set; }

    /// <summary>The resource ID of the Log Analytics Workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of IOTHub in devices to populate iothubIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProviderRecommendationsEnabled
{
    /// <summary>Is Principal Authentication enabled for the ACR repository? Defaults to true.</summary>
    [JsonPropertyName("acrAuthentication")]
    public bool? AcrAuthentication { get; set; }

    /// <summary>Is Agent send underutilized messages enabled? Defaults to true.</summary>
    [JsonPropertyName("agentSendUnutilizedMsg")]
    public bool? AgentSendUnutilizedMsg { get; set; }

    /// <summary>Is Security related system configuration issues identified? Defaults to true.</summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>Is IoT Edge Hub memory optimized? Defaults to true.</summary>
    [JsonPropertyName("edgeHubMemOptimize")]
    public bool? EdgeHubMemOptimize { get; set; }

    /// <summary>Is logging configured for IoT Edge module? Defaults to true.</summary>
    [JsonPropertyName("edgeLoggingOption")]
    public bool? EdgeLoggingOption { get; set; }

    /// <summary>Is inconsistent module settings enabled for SecurityGroup? Defaults to true.</summary>
    [JsonPropertyName("inconsistentModuleSettings")]
    public bool? InconsistentModuleSettings { get; set; }

    /// <summary>is Azure IoT Security agent installed? Defaults to true.</summary>
    [JsonPropertyName("installAgent")]
    public bool? InstallAgent { get; set; }

    /// <summary>Is Default IP filter policy denied? Defaults to true.</summary>
    [JsonPropertyName("ipFilterDenyAll")]
    public bool? IpFilterDenyAll { get; set; }

    /// <summary>Is IP filter rule source allowable IP range too large? Defaults to true.</summary>
    [JsonPropertyName("ipFilterPermissiveRule")]
    public bool? IpFilterPermissiveRule { get; set; }

    /// <summary>Is any ports open on the device? Defaults to true.</summary>
    [JsonPropertyName("openPorts")]
    public bool? OpenPorts { get; set; }

    /// <summary>Does firewall policy exist which allow necessary communication to/from the device? Defaults to true.</summary>
    [JsonPropertyName("permissiveFirewallPolicy")]
    public bool? PermissiveFirewallPolicy { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted in? Defaults to true.</summary>
    [JsonPropertyName("permissiveInputFirewallRules")]
    public bool? PermissiveInputFirewallRules { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted out? Defaults to true.</summary>
    [JsonPropertyName("permissiveOutputFirewallRules")]
    public bool? PermissiveOutputFirewallRules { get; set; }

    /// <summary>Is high level permissions are needed for the module? Defaults to true.</summary>
    [JsonPropertyName("privilegedDockerOptions")]
    public bool? PrivilegedDockerOptions { get; set; }

    /// <summary>Is any credentials shared among devices? Defaults to true.</summary>
    [JsonPropertyName("sharedCredentials")]
    public bool? SharedCredentials { get; set; }

    /// <summary>Does TLS cipher suite need to be updated? Defaults to true.</summary>
    [JsonPropertyName("vulnerableTlsCipherSuite")]
    public bool? VulnerableTlsCipherSuite { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecInitProvider
{
    /// <summary>A additional_workspace block as defined below.</summary>
    [JsonPropertyName("additionalWorkspace")]
    public IList<V1beta1IOTSecuritySolutionSpecInitProviderAdditionalWorkspace>? AdditionalWorkspace { get; set; }

    /// <summary>A list of disabled data sources for the Iot Security Solution. Possible value is TwinData.</summary>
    [JsonPropertyName("disabledDataSources")]
    public IList<string>? DisabledDataSources { get; set; }

    /// <summary>Specifies the Display Name for this Iot Security Solution.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Is the Iot Security Solution enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of data which is to exported to analytic workspace. Valid values include RawEvents.</summary>
    [JsonPropertyName("eventsToExport")]
    public IList<string>? EventsToExport { get; set; }

    /// <summary>Specifies the IoT Hub resource IDs to which this Iot Security Solution is applied.</summary>
    [JsonPropertyName("iothubIds")]
    public IList<string>? IothubIds { get; set; }

    /// <summary>References to IOTHub in devices to populate iothubIds.</summary>
    [JsonPropertyName("iothubIdsRefs")]
    public IList<V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsRefs>? IothubIdsRefs { get; set; }

    /// <summary>Selector for a list of IOTHub in devices to populate iothubIds.</summary>
    [JsonPropertyName("iothubIdsSelector")]
    public V1beta1IOTSecuritySolutionSpecInitProviderIothubIdsSelector? IothubIdsSelector { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Log Analytics Workspace ID to which the security data will be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Should IP addressed be unmasked in the log? Defaults to false.</summary>
    [JsonPropertyName("logUnmaskedIpsEnabled")]
    public bool? LogUnmaskedIpsEnabled { get; set; }

    /// <summary>Specifies the name of the Iot Security Solution. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An Azure Resource Graph query used to set the resources monitored.</summary>
    [JsonPropertyName("queryForResources")]
    public string? QueryForResources { get; set; }

    /// <summary>A list of subscription Ids on which the user defined resources query should be executed.</summary>
    [JsonPropertyName("querySubscriptionIds")]
    public IList<string>? QuerySubscriptionIds { get; set; }

    /// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
    [JsonPropertyName("recommendationsEnabled")]
    public V1beta1IOTSecuritySolutionSpecInitProviderRecommendationsEnabled? RecommendationsEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>IOTSecuritySolutionSpec defines the desired state of IOTSecuritySolution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IOTSecuritySolutionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IOTSecuritySolutionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IOTSecuritySolutionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IOTSecuritySolutionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionStatusAtProviderAdditionalWorkspace
{
    /// <summary>A list of data types which sent to workspace. Possible values are Alerts and RawEvents.</summary>
    [JsonPropertyName("dataTypes")]
    public IList<string>? DataTypes { get; set; }

    /// <summary>The resource ID of the Log Analytics Workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionStatusAtProviderRecommendationsEnabled
{
    /// <summary>Is Principal Authentication enabled for the ACR repository? Defaults to true.</summary>
    [JsonPropertyName("acrAuthentication")]
    public bool? AcrAuthentication { get; set; }

    /// <summary>Is Agent send underutilized messages enabled? Defaults to true.</summary>
    [JsonPropertyName("agentSendUnutilizedMsg")]
    public bool? AgentSendUnutilizedMsg { get; set; }

    /// <summary>Is Security related system configuration issues identified? Defaults to true.</summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>Is IoT Edge Hub memory optimized? Defaults to true.</summary>
    [JsonPropertyName("edgeHubMemOptimize")]
    public bool? EdgeHubMemOptimize { get; set; }

    /// <summary>Is logging configured for IoT Edge module? Defaults to true.</summary>
    [JsonPropertyName("edgeLoggingOption")]
    public bool? EdgeLoggingOption { get; set; }

    /// <summary>Is inconsistent module settings enabled for SecurityGroup? Defaults to true.</summary>
    [JsonPropertyName("inconsistentModuleSettings")]
    public bool? InconsistentModuleSettings { get; set; }

    /// <summary>is Azure IoT Security agent installed? Defaults to true.</summary>
    [JsonPropertyName("installAgent")]
    public bool? InstallAgent { get; set; }

    /// <summary>Is Default IP filter policy denied? Defaults to true.</summary>
    [JsonPropertyName("ipFilterDenyAll")]
    public bool? IpFilterDenyAll { get; set; }

    /// <summary>Is IP filter rule source allowable IP range too large? Defaults to true.</summary>
    [JsonPropertyName("ipFilterPermissiveRule")]
    public bool? IpFilterPermissiveRule { get; set; }

    /// <summary>Is any ports open on the device? Defaults to true.</summary>
    [JsonPropertyName("openPorts")]
    public bool? OpenPorts { get; set; }

    /// <summary>Does firewall policy exist which allow necessary communication to/from the device? Defaults to true.</summary>
    [JsonPropertyName("permissiveFirewallPolicy")]
    public bool? PermissiveFirewallPolicy { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted in? Defaults to true.</summary>
    [JsonPropertyName("permissiveInputFirewallRules")]
    public bool? PermissiveInputFirewallRules { get; set; }

    /// <summary>Is only necessary addresses or ports are permitted out? Defaults to true.</summary>
    [JsonPropertyName("permissiveOutputFirewallRules")]
    public bool? PermissiveOutputFirewallRules { get; set; }

    /// <summary>Is high level permissions are needed for the module? Defaults to true.</summary>
    [JsonPropertyName("privilegedDockerOptions")]
    public bool? PrivilegedDockerOptions { get; set; }

    /// <summary>Is any credentials shared among devices? Defaults to true.</summary>
    [JsonPropertyName("sharedCredentials")]
    public bool? SharedCredentials { get; set; }

    /// <summary>Does TLS cipher suite need to be updated? Defaults to true.</summary>
    [JsonPropertyName("vulnerableTlsCipherSuite")]
    public bool? VulnerableTlsCipherSuite { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionStatusAtProvider
{
    /// <summary>A additional_workspace block as defined below.</summary>
    [JsonPropertyName("additionalWorkspace")]
    public IList<V1beta1IOTSecuritySolutionStatusAtProviderAdditionalWorkspace>? AdditionalWorkspace { get; set; }

    /// <summary>A list of disabled data sources for the Iot Security Solution. Possible value is TwinData.</summary>
    [JsonPropertyName("disabledDataSources")]
    public IList<string>? DisabledDataSources { get; set; }

    /// <summary>Specifies the Display Name for this Iot Security Solution.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Is the Iot Security Solution enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of data which is to exported to analytic workspace. Valid values include RawEvents.</summary>
    [JsonPropertyName("eventsToExport")]
    public IList<string>? EventsToExport { get; set; }

    /// <summary>The ID of the Iot Security Solution resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the IoT Hub resource IDs to which this Iot Security Solution is applied.</summary>
    [JsonPropertyName("iothubIds")]
    public IList<string>? IothubIds { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the Log Analytics Workspace ID to which the security data will be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Should IP addressed be unmasked in the log? Defaults to false.</summary>
    [JsonPropertyName("logUnmaskedIpsEnabled")]
    public bool? LogUnmaskedIpsEnabled { get; set; }

    /// <summary>Specifies the name of the Iot Security Solution. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An Azure Resource Graph query used to set the resources monitored.</summary>
    [JsonPropertyName("queryForResources")]
    public string? QueryForResources { get; set; }

    /// <summary>A list of subscription Ids on which the user defined resources query should be executed.</summary>
    [JsonPropertyName("querySubscriptionIds")]
    public IList<string>? QuerySubscriptionIds { get; set; }

    /// <summary>A recommendations_enabled block of options to enable or disable as defined below.</summary>
    [JsonPropertyName("recommendationsEnabled")]
    public V1beta1IOTSecuritySolutionStatusAtProviderRecommendationsEnabled? RecommendationsEnabled { get; set; }

    /// <summary>Specifies the name of the resource group in which to create the Iot Security Solution. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionStatusConditions
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

/// <summary>IOTSecuritySolutionStatus defines the observed state of IOTSecuritySolution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTSecuritySolutionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IOTSecuritySolutionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IOTSecuritySolutionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IOTSecuritySolution is the Schema for the IOTSecuritySolutions API. Manages an iot security solution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTSecuritySolution : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IOTSecuritySolutionSpec>, IStatus<V1beta1IOTSecuritySolutionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTSecuritySolution";
    public const string KubeGroup = "security.azure.m.upbound.io";
    public const string KubePluralName = "iotsecuritysolutions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTSecuritySolutionSpec defines the desired state of IOTSecuritySolution</summary>
    [JsonPropertyName("spec")]
    public V1beta1IOTSecuritySolutionSpec Spec { get; set; }

    /// <summary>IOTSecuritySolutionStatus defines the observed state of IOTSecuritySolution.</summary>
    [JsonPropertyName("status")]
    public V1beta1IOTSecuritySolutionStatus? Status { get; set; }
}

/// <summary>IOTSecuritySolution is the Schema for the IOTSecuritySolutions API. Manages an iot security solution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTSecuritySolutionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IOTSecuritySolution>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTSecuritySolutionList";
    public const string KubeGroup = "security.azure.m.upbound.io";
    public const string KubePluralName = "iotsecuritysolutions";
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
    public IList<V1beta1IOTSecuritySolution> Items { get; set; }
}