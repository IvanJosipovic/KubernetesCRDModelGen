using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderEnabledLogRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderEnabledLog
{
    /// <summary>The name of a Diagnostic Log Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The name of a Diagnostic Log Category Group for this Resource.</summary>
    [JsonPropertyName("categoryGroup")]
    public string? CategoryGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingSpecForProviderEnabledLogRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderEnabledMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderMetricRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingSpecForProviderMetricRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdSelector
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
    public V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecForProvider
{
    /// <summary>One or more enabled_log blocks as defined below.</summary>
    [JsonPropertyName("enabledLog")]
    public IList<V1beta1MonitorDiagnosticSettingSpecForProviderEnabledLog>? EnabledLog { get; set; }

    /// <summary>One or more enabled_metric blocks as defined below.</summary>
    [JsonPropertyName("enabledMetric")]
    public IList<V1beta1MonitorDiagnosticSettingSpecForProviderEnabledMetric>? EnabledMetric { get; set; }

    /// <summary>Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data.</summary>
    [JsonPropertyName("eventhubAuthorizationRuleId")]
    public string? EventhubAuthorizationRuleId { get; set; }

    /// <summary>Specifies the name of the Event Hub where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Possible values are AzureDiagnostics and Dedicated. When set to Dedicated, logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.</summary>
    [JsonPropertyName("logAnalyticsDestinationType")]
    public string? LogAnalyticsDestinationType { get; set; }

    /// <summary>Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MonitorDiagnosticSettingSpecForProviderMetric>? Metric { get; set; }

    /// <summary>Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the market partner solution where Diagnostics Data should be sent. For potential partner integrations, click to learn more about partner integration.</summary>
    [JsonPropertyName("partnerSolutionId")]
    public string? PartnerSolutionId { get; set; }

    /// <summary>The ID of the Storage Account where logs should be sent.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1MonitorDiagnosticSettingSpecForProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }

    /// <summary>The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledLogRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledLog
{
    /// <summary>The name of a Diagnostic Log Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The name of a Diagnostic Log Category Group for this Resource.</summary>
    [JsonPropertyName("categoryGroup")]
    public string? CategoryGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledLogRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderMetricRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingSpecInitProviderMetricRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdSelector
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
    public V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecInitProvider
{
    /// <summary>One or more enabled_log blocks as defined below.</summary>
    [JsonPropertyName("enabledLog")]
    public IList<V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledLog>? EnabledLog { get; set; }

    /// <summary>One or more enabled_metric blocks as defined below.</summary>
    [JsonPropertyName("enabledMetric")]
    public IList<V1beta1MonitorDiagnosticSettingSpecInitProviderEnabledMetric>? EnabledMetric { get; set; }

    /// <summary>Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data.</summary>
    [JsonPropertyName("eventhubAuthorizationRuleId")]
    public string? EventhubAuthorizationRuleId { get; set; }

    /// <summary>Specifies the name of the Event Hub where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>Possible values are AzureDiagnostics and Dedicated. When set to Dedicated, logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.</summary>
    [JsonPropertyName("logAnalyticsDestinationType")]
    public string? LogAnalyticsDestinationType { get; set; }

    /// <summary>Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MonitorDiagnosticSettingSpecInitProviderMetric>? Metric { get; set; }

    /// <summary>Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the market partner solution where Diagnostics Data should be sent. For potential partner integrations, click to learn more about partner integration.</summary>
    [JsonPropertyName("partnerSolutionId")]
    public string? PartnerSolutionId { get; set; }

    /// <summary>The ID of the Storage Account where logs should be sent.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1MonitorDiagnosticSettingSpecInitProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }

    /// <summary>The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpecProviderConfigRef
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
public partial class V1beta1MonitorDiagnosticSettingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MonitorDiagnosticSettingSpec defines the desired state of MonitorDiagnosticSetting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorDiagnosticSettingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorDiagnosticSettingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorDiagnosticSettingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorDiagnosticSettingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledLogRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledLog
{
    /// <summary>The name of a Diagnostic Log Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The name of a Diagnostic Log Category Group for this Resource.</summary>
    [JsonPropertyName("categoryGroup")]
    public string? CategoryGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledLogRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProviderMetricRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProviderMetric
{
    /// <summary>The name of a Diagnostic Metric Category for this Resource.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1MonitorDiagnosticSettingStatusAtProviderMetricRetentionPolicy? RetentionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusAtProvider
{
    /// <summary>One or more enabled_log blocks as defined below.</summary>
    [JsonPropertyName("enabledLog")]
    public IList<V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledLog>? EnabledLog { get; set; }

    /// <summary>One or more enabled_metric blocks as defined below.</summary>
    [JsonPropertyName("enabledMetric")]
    public IList<V1beta1MonitorDiagnosticSettingStatusAtProviderEnabledMetric>? EnabledMetric { get; set; }

    /// <summary>Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data.</summary>
    [JsonPropertyName("eventhubAuthorizationRuleId")]
    public string? EventhubAuthorizationRuleId { get; set; }

    /// <summary>Specifies the name of the Event Hub where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("eventhubName")]
    public string? EventhubName { get; set; }

    /// <summary>The ID of the Diagnostic Setting.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Possible values are AzureDiagnostics and Dedicated. When set to Dedicated, logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.</summary>
    [JsonPropertyName("logAnalyticsDestinationType")]
    public string? LogAnalyticsDestinationType { get; set; }

    /// <summary>Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MonitorDiagnosticSettingStatusAtProviderMetric>? Metric { get; set; }

    /// <summary>Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the market partner solution where Diagnostics Data should be sent. For potential partner integrations, click to learn more about partner integration.</summary>
    [JsonPropertyName("partnerSolutionId")]
    public string? PartnerSolutionId { get; set; }

    /// <summary>The ID of the Storage Account where logs should be sent.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatusConditions
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

/// <summary>MonitorDiagnosticSettingStatus defines the observed state of MonitorDiagnosticSetting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDiagnosticSettingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorDiagnosticSettingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorDiagnosticSettingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorDiagnosticSetting is the Schema for the MonitorDiagnosticSettings API. Manages a Diagnostic Setting for an existing Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorDiagnosticSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorDiagnosticSettingSpec>, IStatus<V1beta1MonitorDiagnosticSettingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorDiagnosticSetting";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "monitordiagnosticsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorDiagnosticSettingSpec defines the desired state of MonitorDiagnosticSetting</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorDiagnosticSettingSpec Spec { get; set; }

    /// <summary>MonitorDiagnosticSettingStatus defines the observed state of MonitorDiagnosticSetting.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorDiagnosticSettingStatus? Status { get; set; }
}

/// <summary>MonitorDiagnosticSetting is the Schema for the MonitorDiagnosticSettings API. Manages a Diagnostic Setting for an existing Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorDiagnosticSettingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorDiagnosticSetting>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorDiagnosticSettingList";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "monitordiagnosticsettings";
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
    public IList<V1beta1MonitorDiagnosticSetting> Items { get; set; }
}